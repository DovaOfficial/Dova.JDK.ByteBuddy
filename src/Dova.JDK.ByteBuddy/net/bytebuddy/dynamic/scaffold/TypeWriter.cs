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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter;", "public abstract interface")]
public partial interface TypeWriter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUMP_PROPERTY", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DUMP_PROPERTY_Property
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

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;", "public abstract static")]
	public partial class Default
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_REFERENCE", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUMP_FOLDER", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldPool", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentPool", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Lnet/bytebuddy/description/field/FieldList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Lnet/bytebuddy/description/method/MethodList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethods", "Lnet/bytebuddy/description/method/MethodList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponents", "Lnet/bytebuddy/description/type/RecordComponentList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypeInitializer", "Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInitializer", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAttributeAppender", "Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asmVisitorWrapper", "Lnet/bytebuddy/asm/AsmVisitorWrapper;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationRetention", "Lnet/bytebuddy/implementation/attribute/AnnotationRetention;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypeNamingStrategy", "Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContextFactory", "Lnet/bytebuddy/implementation/Implementation$Context$Factory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeValidation", "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classWriterStrategy", "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1400", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forCreation", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forRedefinition", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forRebasing", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forDecoration", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String NO_REFERENCE_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
		public static Dova.JDK.java.lang.String DUMP_FOLDER_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "protected final")]
		public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool fieldPool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool recordComponentPool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "protected final")]
		public Dova.JDK.java.util.List auxiliaryTypes_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList fields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodList;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList methods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodList;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList instrumentedMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList recordComponents_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer loadedTypeInitializer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer typeInitializer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender typeAttributeAppender_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper;", "protected final")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper asmVisitorWrapper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationRetention;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention annotationRetention_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy auxiliaryTypeNamingStrategy_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Factory;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory implementationContextFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation typeValidation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy classWriterStrategy_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "protected final")]
		public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[22]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[22], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;)V", "protected")]
		public Default(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg3, Dova.JDK.java.util.List arg4, Dova.JDK.net.bytebuddy.description.field.FieldList arg5, Dova.JDK.net.bytebuddy.description.method.MethodList arg6, Dova.JDK.net.bytebuddy.description.method.MethodList arg7, Dova.JDK.net.bytebuddy.description.type.RecordComponentList arg8, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg10, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg11, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg12, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg13, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg14, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg15, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg16, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg17, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg18, Dova.JDK.net.bytebuddy.pool.TypePool arg19) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;";
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

		[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedExceptionAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.UnresolvedType create(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.UnresolvedType>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object access_1400(Dova.JDK.java.security.PrivilegedExceptionAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "static")]
		public static Dova.JDK.java.lang.String access_300()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter forCreation(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Compiled arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg8, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg12, Dova.JDK.net.bytebuddy.pool.TypePool arg13)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter forRedefinition(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg8, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg12, Dova.JDK.net.bytebuddy.pool.TypePool arg13, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg14, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg15)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter forRebasing(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg8, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg12, Dova.JDK.net.bytebuddy.pool.TypePool arg13, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg14, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg15, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver arg16)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter forDecoration(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg6, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg7, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg8, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg11, Dova.JDK.net.bytebuddy.pool.TypePool arg12, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg13)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction;", "protected static")]
		public partial class ClassDumpAction
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.security.PrivilegedExceptionAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassDumpAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOTHING", "Ljava/lang/Void;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "original", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suffix", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;ZJ[B)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			}

			[JniSignatureAttribute("Ljava/lang/Void;", "private static final")]
			public static Dova.JDK.java.lang.Void NOTHING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String target_Property
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
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

			[JniSignatureAttribute("Z", "private final")]
			public bool original_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("J", "private final")]
			public long suffix_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> binaryRepresentation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassDumpAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;ZJ[B)V", "protected")]
			public ClassDumpAction(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, bool arg2, long arg3, JavaArray<byte> arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object run_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void run_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
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

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;", "protected abstract static interface")]
			public partial interface Dispatcher
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Dispatcher()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Lnet/bytebuddy/description/type/TypeDescription;Z[B)V"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Z[B)V", "public abstract")]
				void dump(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, bool arg1, JavaArray<byte> arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Enabled;", "public static")]
				public partial class Enabled
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Enabled()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Enabled;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timestamp", "J"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;J)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Lnet/bytebuddy/description/type/TypeDescription;Z[B)V"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String folder_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("J", "private final")]
					public long timestamp_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Enabled(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;J)V", "protected")]
					public Enabled(Dova.JDK.java.lang.String arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Enabled;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Z[B)V", "public")]
					public void dump(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, bool arg1, JavaArray<byte> arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;", "public static final")]
				public partial class Disabled
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Disabled()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Lnet/bytebuddy/description/type/TypeDescription;Z[B)V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled>>(ret);
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

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher$Disabled;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher.Disabled>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Z[B)V", "public")]
					public void dump(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, bool arg1, JavaArray<byte> arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForCreation;", "public static")]
		public partial class ForCreation
			: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForCreation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForCreation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodPool", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool methodPool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForCreation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;)V", "protected")]
			public ForCreation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool arg3, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg4, Dova.JDK.java.util.List arg5, Dova.JDK.net.bytebuddy.description.field.FieldList arg6, Dova.JDK.net.bytebuddy.description.method.MethodList arg7, Dova.JDK.net.bytebuddy.description.method.MethodList arg8, Dova.JDK.net.bytebuddy.description.type.RecordComponentList arg9, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg11, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg12, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg13, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg14, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg15, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg16, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg17, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg18, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg19, Dova.JDK.net.bytebuddy.pool.TypePool arg20) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForCreation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.UnresolvedType create(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.UnresolvedType>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining;", "public abstract static")]
		public partial class ForInlining
			: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForInlining()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_FIELD", "Lnet/bytebuddy/jar/asm/FieldVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_METHOD", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_RECORD_COMPONENT", "Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_ANNOTATION", "Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeTo", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "()Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$700", "()Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "()Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldVisitor;", "private static final")]
			public static Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor IGNORE_FIELD_Property
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
			public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor IGNORE_METHOD_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "private static final")]
			public static Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor IGNORE_RECORD_COMPONENT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "private static final")]
			public static Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor IGNORE_ANNOTATION_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "protected final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription originalType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "protected final")]
			public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForInlining(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "protected")]
			public ForInlining(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg3, Dova.JDK.java.util.List arg4, Dova.JDK.net.bytebuddy.description.field.FieldList arg5, Dova.JDK.net.bytebuddy.description.method.MethodList arg6, Dova.JDK.net.bytebuddy.description.method.MethodList arg7, Dova.JDK.net.bytebuddy.description.type.RecordComponentList arg8, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg10, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg11, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg12, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg13, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg14, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg15, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg16, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg17, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg18, Dova.JDK.net.bytebuddy.pool.TypePool arg19, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg20, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg21) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ClassDumpAction$Dispatcher;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.UnresolvedType create(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ClassDumpAction.Dispatcher arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.UnresolvedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor writeTo(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry arg2, int arg3, int arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "static")]
			public static Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor access_400()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "static")]
			public static Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor access_500()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/MethodVisitor;", "static")]
			public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor access_700()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/FieldVisitor;", "static")]
			public static Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor access_600()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;", "protected static")]
			public partial class WithDecorationOnly
				: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithDecorationOnly()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Ljava/util/List;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeTo", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithDecorationOnly(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Ljava/util/List;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "protected")]
				public WithDecorationOnly(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.description.method.MethodList arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg6, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg7, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg8, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg11, Dova.JDK.net.bytebuddy.pool.TypePool arg12, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg13) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "protected")]
				public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor writeTo(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry arg2, int arg3, int arg4)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly$DecorationClassVisitor;", "protected")]
				public partial class DecorationClassVisitor
					: Dova.JDK.net.bytebuddy.utility.visitor.MetadataAwareClassVisitor
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static DecorationClassVisitor()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly$DecorationClassVisitor;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextRegistry", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writerFlags", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerFlags", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContext", "Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterAttributes", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitEnd", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;", "private final")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry contextRegistry_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int writerFlags_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int readerFlags_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "private")]
					public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView implementationContext_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithDecorationOnly this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithDecorationOnly>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public DecorationClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)V", "protected")]
					public DecorationClassVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithDecorationOnly arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly$DecorationClassVisitor;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V", "public")]
					public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
					public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
					}

					[JniSignatureAttribute("()V", "protected")]
					public void onAfterAttributes()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor onVisitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor onVisitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
					}

					[JniSignatureAttribute("()V", "protected")]
					public void onVisitEnd()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly$LazyFieldList;", "protected static")]
				public partial class LazyFieldList
					: Dova.JDK.net.bytebuddy.description.field.FieldList.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyFieldList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly$LazyFieldList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyFieldList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public LazyFieldList(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithDecorationOnly$LazyFieldList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
					public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;", "protected static")]
			public partial class WithFullProcessing
				: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithFullProcessing()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY", "[Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodRegistry", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationTargetFactory", "Lnet/bytebuddy/implementation/Implementation$Target$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodRebaseResolver", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;Lnet/bytebuddy/implementation/Implementation$Target$Factory;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeTo", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1300", "()[Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$800", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;)Lnet/bytebuddy/implementation/Implementation$Target$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;"));
				}

				[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
				public static JavaArray<Dova.JDK.java.lang.Object> EMPTY_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared methodRegistry_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$Factory;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory implementationTargetFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver methodRebaseResolver_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithFullProcessing(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;Ljava/util/List;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/description/type/RecordComponentList;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;Lnet/bytebuddy/implementation/Implementation$Target$Factory;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)V", "protected")]
				public WithFullProcessing(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool arg3, Dova.JDK.java.util.List arg4, Dova.JDK.net.bytebuddy.description.field.FieldList arg5, Dova.JDK.net.bytebuddy.description.method.MethodList arg6, Dova.JDK.net.bytebuddy.description.method.MethodList arg7, Dova.JDK.net.bytebuddy.description.type.RecordComponentList arg8, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg10, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg11, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg12, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg13, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg14, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg15, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg16, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg17, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg18, Dova.JDK.net.bytebuddy.pool.TypePool arg19, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg20, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg21, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared arg22, Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory arg23, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver arg24) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "protected")]
				public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor writeTo(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry arg2, int arg3, int arg4)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
				}

				[JniSignatureAttribute("()[Ljava/lang/Object;", "static")]
				public static JavaArray<Dova.JDK.java.lang.Object> access_1300()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;", "static")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver access_800(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;)Lnet/bytebuddy/implementation/Implementation$Target$Factory;", "static")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory access_100(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;", "static")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared access_200(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$SignatureKey;", "protected static")]
				public partial class SignatureKey
					: Dova.JDK.java.lang.Object
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static SignatureKey()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$SignatureKey;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String internalName_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String descriptor_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public SignatureKey(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
					public SignatureKey(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$SignatureKey;";
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
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;", "protected")]
				public partial class RedefinitionClassVisitor
					: Dova.JDK.net.bytebuddy.utility.visitor.MetadataAwareClassVisitor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static RedefinitionClassVisitor()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInitializer", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contextRegistry", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writerFlags", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerFlags", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declarableFields", "Ljava/util/LinkedHashMap;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declarableMethods", "Ljava/util/LinkedHashMap;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declarableRecordComponents", "Ljava/util/LinkedHashMap;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestMembers", "Ljava/util/Set;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredTypes", "Ljava/util/LinkedHashMap;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "permittedSubclasses", "Ljava/util/Set;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodPool", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initializationHandler", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContext", "Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retainDeprecationModifiers", "Z"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1000", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1200", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$900", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefine", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;Ljava/lang/Object;ILjava/lang/String;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefine", "(Lnet/bytebuddy/description/method/MethodDescription;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefine", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveDeprecationModifiers", "(I)I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitNestHost", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNestHost", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitPermittedSubclass", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitOuterClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onOuterType", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterAttributes", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitRecordComponent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitInnerClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitNestMember", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitEnd", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1100", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)I"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "private final")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer typeInitializer_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;", "private final")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry contextRegistry_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int writerFlags_Property
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

					[JniSignatureAttribute("I", "private final")]
					public int readerFlags_Property
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

					[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
					public Dova.JDK.java.util.LinkedHashMap declarableFields_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
					public Dova.JDK.java.util.LinkedHashMap declarableMethods_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
					public Dova.JDK.java.util.LinkedHashMap declarableRecordComponents_Property
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

					[JniSignatureAttribute("Ljava/util/Set;", "private final")]
					public Dova.JDK.java.util.Set nestMembers_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
					public Dova.JDK.java.util.LinkedHashMap declaredTypes_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/Set;", "private final")]
					public Dova.JDK.java.util.Set permittedSubclasses_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;", "private")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool methodPool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler;", "private")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler initializationHandler_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "private")]
					public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView implementationContext_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "private")]
					public bool retainDeprecationModifiers_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public RedefinitionClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;II)V", "protected")]
					public RedefinitionClassVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.ContextRegistry arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
					public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)Lnet/bytebuddy/jar/asm/ClassVisitor;", "static")]
					public static Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor access_1000(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)I", "static")]
					public static int access_1200(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0)
					{
						var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "static")]
					public static Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView access_900(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;Ljava/lang/Object;ILjava/lang/String;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor redefine(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.String arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor redefine(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor redefine(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
					}

					[JniSignatureAttribute("(I)I", "private")]
					public int resolveDeprecationModifiers(int arg0)
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public void onVisitNestHost(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					}

					[JniSignatureAttribute("()V", "protected")]
					public void onNestHost()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public void onVisitPermittedSubclass(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
					public void onVisitOuterClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "protected")]
					public void onOuterType()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "protected")]
					public void onAfterAttributes()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor onVisitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor onVisitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor onVisitRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
					}

					[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor onVisitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
					}

					[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "protected")]
					public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor onVisitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "protected")]
					public void onVisitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public void onVisitNestMember(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
					}

					[JniSignatureAttribute("()V", "protected")]
					public void onVisitEnd()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;)I", "static")]
					public static int access_1100(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0)
					{
						var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingMethodVisitor;", "protected")]
					public partial class AttributeObtainingMethodVisitor
						: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AttributeObtainingMethodVisitor()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingMethodVisitor;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actualMethodVisitor", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "record", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotableParameterCount", "(IZ)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotation", "(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private final")]
						public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor actualMethodVisitor_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "private final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record record_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AttributeObtainingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)V", "protected")]
						public AttributeObtainingMethodVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingMethodVisitor;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("()V", "public")]
						public void visitEnd()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
						}

						[JniSignatureAttribute("()V", "public")]
						public void visitCode()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotationDefault()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("(IZ)V", "public")]
						public void visitAnnotableParameterCount(int arg0, bool arg1)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
						}

						[JniSignatureAttribute("(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitParameterAnnotation(int arg0, Dova.JDK.java.lang.String arg1, bool arg2)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$CodePreservingMethodVisitor;", "protected")]
					public partial class CodePreservingMethodVisitor
						: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static CodePreservingMethodVisitor()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$CodePreservingMethodVisitor;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actualMethodVisitor", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "record", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolution", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMaxs", "(II)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotableParameterCount", "(IZ)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotation", "(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private final")]
						public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor actualMethodVisitor_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "private final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record record_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "private final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution resolution_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public CodePreservingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;)V", "protected")]
						public CodePreservingMethodVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$CodePreservingMethodVisitor;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("()V", "public")]
						public void visitCode()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
						}

						[JniSignatureAttribute("(II)V", "public")]
						public void visitMaxs(int arg0, int arg1)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotationDefault()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("(IZ)V", "public")]
						public void visitAnnotableParameterCount(int arg0, bool arg1)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
						}

						[JniSignatureAttribute("(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitParameterAnnotation(int arg0, Dova.JDK.java.lang.String arg1, bool arg2)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingRecordComponentVisitor;", "protected")]
					public partial class AttributeObtainingRecordComponentVisitor
						: Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AttributeObtainingRecordComponentVisitor()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingRecordComponentVisitor;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "record", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;", "private final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record record_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AttributeObtainingRecordComponentVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;)V", "protected")]
						public AttributeObtainingRecordComponentVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingRecordComponentVisitor;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("()V", "public")]
						public void visitEnd()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
						}

						[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingFieldVisitor;", "protected")]
					public partial class AttributeObtainingFieldVisitor
						: Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AttributeObtainingFieldVisitor()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingFieldVisitor;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "record", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "private final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record record_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AttributeObtainingFieldVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor;Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;)V", "protected")]
						public AttributeObtainingFieldVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.RedefinitionClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$RedefinitionClassVisitor$AttributeObtainingFieldVisitor;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}

						[JniSignatureAttribute("()V", "public")]
						public void visitEnd()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
						}

						[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
						public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler;", "protected abstract static interface")]
				public partial interface InitializationHandler
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static InitializationHandler()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V"));
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V", "public abstract")]
					void complete(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending;", "public abstract static")]
					public partial class Appending
						: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
						, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler
						, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Appending()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "record", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameWriter", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackSize", "I"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableLength", "I"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFrame", "(II[Ljava/lang/Object;I[Ljava/lang/Object;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(ZLnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMaxs", "(II)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onStart", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withDrain", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withoutDrain", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "protected final")]
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

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "protected final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record record_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "protected final")]
						public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter;", "protected final")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter frameWriter_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("I", "protected")]
						public int stackSize_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
								return ret;
							}
							set
							{
								DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
							}
						}

						[JniSignatureAttribute("I", "protected")]
						public int localVariableLength_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
								return ret;
							}
							set
							{
								DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Appending(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V", "protected")]
						public Appending(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(II[Ljava/lang/Object;I[Ljava/lang/Object;)V", "public")]
						public void visitFrame(int arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V", "public")]
						public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
						}

						[JniSignatureAttribute("(ZLnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler;", "protected static")]
						public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler of(bool arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool arg3, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg4, bool arg5, bool arg6)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler>(ret);
						}

						[JniSignatureAttribute("()V", "public abstract")]
						public void visitEnd()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
						}

						[JniSignatureAttribute("()V", "public")]
						public void visitCode()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
						}

						[JniSignatureAttribute("(II)V", "public")]
						public void visitMaxs(int arg0, int arg1)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V", "public")]
						public void complete(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView arg1)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
						}

						[JniSignatureAttribute("()V", "protected abstract")]
						public void onStart()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected abstract")]
						public void onComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain;", "private static")]
						public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithDrain withDrain(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithDrain>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain;", "private static")]
						public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithoutDrain withoutDrain(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithoutDrain>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain;", "protected abstract static")]
						public partial class WithDrain
							: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static WithDrain()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appended", "Lnet/bytebuddy/jar/asm/Label;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "original", "Lnet/bytebuddy/jar/asm/Label;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onStart", "()V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "protected final")]
							public Dova.JDK.net.bytebuddy.jar.asm.Label appended_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "protected final")]
							public Dova.JDK.net.bytebuddy.jar.asm.Label original_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public WithDrain(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V", "protected")]
							public WithDrain(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()V", "public")]
							public void visitEnd()
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
							}

							[JniSignatureAttribute("()V", "protected")]
							public void onStart()
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected")]
							public void onComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected abstract")]
							public void onAfterComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain$WithActiveRecord;", "protected static")]
							public partial class WithActiveRecord
								: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithDrain
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static WithActiveRecord()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain$WithActiveRecord;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Lnet/bytebuddy/jar/asm/Label;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsn", "(I)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private final")]
								public Dova.JDK.net.bytebuddy.jar.asm.Label label_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public WithActiveRecord(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V", "protected")]
								public WithActiveRecord(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain$WithActiveRecord;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(I)V", "public")]
								public void visitInsn(int arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected")]
								public void onAfterComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain$WithoutActiveRecord;", "protected static")]
							public partial class WithoutActiveRecord
								: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithDrain
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static WithoutActiveRecord()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain$WithoutActiveRecord;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public WithoutActiveRecord(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V", "protected")]
								public WithoutActiveRecord(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithDrain$WithoutActiveRecord;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected")]
								public void onAfterComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								}
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain;", "protected abstract static")]
						public partial class WithoutDrain
							: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static WithoutDrain()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onStart", "()V"));
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public WithoutDrain(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V", "protected")]
							public WithoutDrain(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()V", "public")]
							public void visitEnd()
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
							}

							[JniSignatureAttribute("()V", "protected")]
							public void onStart()
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain$WithActiveRecord;", "protected static")]
							public partial class WithActiveRecord
								: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithoutDrain
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static WithActiveRecord()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain$WithActiveRecord;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Lnet/bytebuddy/jar/asm/Label;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsn", "(I)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private final")]
								public Dova.JDK.net.bytebuddy.jar.asm.Label label_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public WithActiveRecord(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;ZZ)V", "protected")]
								public WithActiveRecord(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain$WithActiveRecord;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(I)V", "public")]
								public void visitInsn(int arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected")]
								public void onComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain$WithoutActiveRecord;", "protected static")]
							public partial class WithoutActiveRecord
								: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.WithoutDrain
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static WithoutActiveRecord()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain$WithoutActiveRecord;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/implementation/Implementation$Context;)V"));
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public WithoutActiveRecord(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "protected")]
								public WithoutActiveRecord(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$WithoutDrain$WithoutActiveRecord;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context;)V", "protected")]
								public void onComplete(Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								}
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter;", "protected abstract static interface")]
						public partial interface FrameWriter
							: IJavaObject
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static FrameWriter()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY", "[Ljava/lang/Object;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onFrame", "(II)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitFrame", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
							}

							[JniSignatureAttribute("[Ljava/lang/Object;", "public static final")]
							public static JavaArray<Dova.JDK.java.lang.Object> EMPTY_Property
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

							[JniSignatureAttribute("(II)V", "public abstract")]
							void onFrame(int arg0, int arg1)
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public abstract")]
							void emitFrame(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
							{
								DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Active;", "public static")]
							public partial class Active
								: Dova.JDK.java.lang.Object
								, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static Active()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Active;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentLocalVariableLength", "I"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onFrame", "(II)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitFrame", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
								}

								[JniSignatureAttribute("I", "private")]
								public int currentLocalVariableLength_Property
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

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public Active(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("()V", "public")]
								public Active() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Active;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(II)V", "public")]
								public void onFrame(int arg0, int arg1)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
								public void emitFrame(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;", "public static final")]
							public partial class Expanding
								: Dova.JDK.java.lang.Enum
								, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static Expanding()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;"));
									FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;"));
									MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onFrame", "(II)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitFrame", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;", "public static final")]
								public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding INSTANCE_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding>(ret);
									}
									set
									{
										DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;", "private static final")]
								public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding> VALUES_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
										return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding>>(ret);
									}
									set
									{
										DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public Expanding(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
								public Expanding(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;", "public static")]
								public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding> values()
								{
									var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
									return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding>>(ret);
								}

								[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$Expanding;", "public static")]
								public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding valueOf(Dova.JDK.java.lang.String arg0)
								{
									var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.Expanding>(ret);
								}

								[JniSignatureAttribute("(II)V", "public")]
								public void onFrame(int arg0, int arg1)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
								public void emitFrame(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;", "public static final")]
							public partial class NoOp
								: Dova.JDK.java.lang.Enum
								, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static NoOp()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;"));
									FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;"));
									MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onFrame", "(II)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emitFrame", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;", "public static final")]
								public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp INSTANCE_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp>(ret);
									}
									set
									{
										DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;", "private static final")]
								public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp> VALUES_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
										return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp>>(ret);
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

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;", "public static")]
								public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp> values()
								{
									var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
									return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp>>(ret);
								}

								[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Appending$FrameWriter$NoOp;", "public static")]
								public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp valueOf(Dova.JDK.java.lang.String arg0)
								{
									var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler.Appending.FrameWriter.NoOp>(ret);
								}

								[JniSignatureAttribute("(II)V", "public")]
								public void onFrame(int arg0, int arg1)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
								public void emitFrame(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
								{
									DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
								}
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Creating;", "public static")]
					public partial class Creating
						: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain.Default
						, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ForInlining.WithFullProcessing.InitializationHandler
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Creating()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Creating;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Creating(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "protected")]
						public Creating(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$InitializationHandler$Creating;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V", "public")]
						public void complete(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView arg1)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$OpenedClassRemapper;", "protected static")]
				public partial class OpenedClassRemapper
					: Dova.JDK.net.bytebuddy.jar.asm.commons.ClassRemapper
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OpenedClassRemapper()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$OpenedClassRemapper;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OpenedClassRemapper(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "protected")]
					public OpenedClassRemapper(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$WithFullProcessing$OpenedClassRemapper;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;", "protected static")]
			public partial class ContextRegistry
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ContextRegistry()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContext", "Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setImplementationContext", "(Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "private")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView implementationContext_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ContextRegistry(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "protected")]
				public ContextRegistry() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ForInlining$ContextRegistry;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List getAuxiliaryTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;)V", "public")]
				public void setImplementationContext(Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;", "protected static")]
		public partial class ValidatingClassVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ValidatingClassVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_PARAMETERS", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNS_VOID", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING_DESCRIPTOR", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_FIELD", "Lnet/bytebuddy/jar/asm/FieldVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_METHOD", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constraint", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMember", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPermittedSubclass", "(Ljava/lang/String;)V"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String NO_PARAMETERS_Property
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
			public static Dova.JDK.java.lang.String RETURNS_VOID_Property
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
			public static Dova.JDK.java.lang.String STRING_DESCRIPTOR_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldVisitor;", "private static final")]
			public static Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor IGNORE_FIELD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private static final")]
			public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor IGNORE_METHOD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint;", "private")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint constraint_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ValidatingClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;)V", "protected")]
			public ValidatingClassVisitor(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;)Lnet/bytebuddy/jar/asm/ClassVisitor;", "protected static")]
			public static Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor of(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
			}

			[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
			public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitNestHost(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitNestMember(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint;", "static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint access_000(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitPermittedSubclass(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$ValidatingMethodVisitor;", "protected")]
			public partial class ValidatingMethodVisitor
				: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ValidatingMethodVisitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$ValidatingMethodVisitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitJumpInsn", "(ILnet/bytebuddy/jar/asm/Label;)V"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;", "final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ValidatingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/String;)V", "protected")]
				public ValidatingMethodVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$ValidatingMethodVisitor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
				public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
				public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotationDefault()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V", "public transient")]
				public void visitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				}

				[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public")]
				public void visitJumpInsn(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$ValidatingFieldVisitor;", "protected")]
			public partial class ValidatingFieldVisitor
				: Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ValidatingFieldVisitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$ValidatingFieldVisitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;Lnet/bytebuddy/jar/asm/FieldVisitor;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;", "final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ValidatingFieldVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor;Lnet/bytebuddy/jar/asm/FieldVisitor;)V", "protected")]
				public ValidatingFieldVisitor(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$ValidatingFieldVisitor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint;", "protected abstract static interface")]
			public partial interface Constraint
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Constraint()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertAnnotation()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertNestMate()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
				}

				[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public abstract")]
				void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				}

				[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public abstract")]
				void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertPermittedSubclass()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("(IZZ)V", "public abstract")]
				void assertType(int arg0, bool arg1, bool arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertRecord()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertTypeAnnotation()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
				void assertDefaultValue(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertTypeInConstantPool()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertMethodTypeInConstantPool()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertHandleInConstantPool()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertDynamicValueInConstantPool()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertDefaultMethodCall()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertInvokeDynamic()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void assertSubRoutine()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$Compound;", "public static")]
				public partial class Compound
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Compound()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$Compound;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constraints", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List constraints_Property
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

					[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
					public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$Compound;";
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

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClassFileVersion;", "public static")]
				public partial class ForClassFileVersion
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForClassFileVersion()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClassFileVersion;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/ClassFileVersion;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "private final")]
					public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForClassFileVersion(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;)V", "protected")]
					public ForClassFileVersion(Dova.JDK.net.bytebuddy.ClassFileVersion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClassFileVersion;";
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

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;", "public static final")]
				public partial class ForAnnotation
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForAnnotation()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASSIC", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_8", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classic", "Z"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation CLASSIC_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation JAVA_8_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "private final")]
					public bool classic_Property
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

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForAnnotation(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
					public ForAnnotation(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForAnnotation;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForAnnotation>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;", "public static final")]
				public partial class ForRecord
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForRecord()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForRecord(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public ForRecord(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForRecord;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForRecord>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;", "public static final")]
				public partial class ForInterface
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForInterface()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASSIC", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_8", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classic", "Z"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface CLASSIC_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface JAVA_8_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "private final")]
					public bool classic_Property
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

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForInterface(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
					public ForInterface(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForInterface;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForInterface>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;", "public static final")]
				public partial class ForPackageType
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForPackageType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForPackageType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public ForPackageType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForPackageType;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForPackageType>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;", "public static final")]
				public partial class ForClass
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForClass()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MANIFEST", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSTRACT", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifestType", "Z"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertNestMate", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertField", "(Ljava/lang/String;ZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethod", "(Ljava/lang/String;ZZZZZZZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertPermittedSubclass", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertType", "(IZZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertRecord", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeAnnotation", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultValue", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertMethodTypeInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertHandleInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDynamicValueInConstantPool", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertDefaultMethodCall", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertInvokeDynamic", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertSubRoutine", "()V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass MANIFEST_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass ABSTRACT_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "private final")]
					public bool manifestType_Property
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

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForClass(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
					public ForClass(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$ValidatingClassVisitor$Constraint$ForClass;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default.ValidatingClassVisitor.Constraint.ForClass>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertNestMate()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZ)V", "public")]
					public void assertField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
					}

					[JniSignatureAttribute("(Ljava/lang/String;ZZZZZZZZ)V", "public")]
					public void assertMethod(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, bool arg8)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertPermittedSubclass()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
					}

					[JniSignatureAttribute("(IZZ)V", "public")]
					public void assertType(int arg0, bool arg1, bool arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertRecord()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeAnnotation()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public void assertDefaultValue(Dova.JDK.java.lang.String arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertMethodTypeInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertHandleInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDynamicValueInConstantPool()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertDefaultMethodCall()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertInvokeDynamic()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
					}

					[JniSignatureAttribute("()V", "public")]
					public void assertSubRoutine()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;", "protected")]
		public partial class UnresolvedType
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnresolvedType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypes", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;[BLjava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBinaryRepresentation", "()[B"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDynamicType", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> binaryRepresentation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List auxiliaryTypes_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;", "final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnresolvedType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default;[BLjava/util/List;)V", "protected")]
			public UnresolvedType(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.Default arg0, JavaArray<byte> arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$Default$UnresolvedType;";
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

			[JniSignatureAttribute("()[B", "protected")]
			public JavaArray<byte> getBinaryRepresentation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded toDynamicType(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;", "public abstract static interface")]
	public partial interface RecordComponentPool
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RecordComponentPool()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record target(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;", "public static final")]
		public partial class Disabled
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Disabled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record target(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Disabled;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Disabled>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;", "public abstract static interface")]
		public partial interface Record
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Record()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicit", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponent", "()Lnet/bytebuddy/description/type/RecordComponentDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponentAppender", "()Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("()Z", "public abstract")]
			bool isImplicit()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription getRecordComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender getRecordComponentAppender()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record$ForExplicitRecordComponent;", "public static")]
			public partial class ForExplicitRecordComponent
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForExplicitRecordComponent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record$ForExplicitRecordComponent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppender", "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentDescription", "Lnet/bytebuddy/description/type/RecordComponentDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;Lnet/bytebuddy/description/type/RecordComponentDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicit", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponent", "()Lnet/bytebuddy/description/type/RecordComponentDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponentAppender", "()Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender attributeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription recordComponentDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForExplicitRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;Lnet/bytebuddy/description/type/RecordComponentDescription;)V", "public")]
				public ForExplicitRecordComponent(Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record$ForExplicitRecordComponent;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isImplicit()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription getRecordComponent()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender getRecordComponentAppender()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record$ForImplicitRecordComponent;", "public static")]
			public partial class ForImplicitRecordComponent
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.RecordComponentPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForImplicitRecordComponent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record$ForImplicitRecordComponent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentDescription", "Lnet/bytebuddy/description/type/RecordComponentDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicit", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponent", "()Lnet/bytebuddy/description/type/RecordComponentDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponentAppender", "()Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription recordComponentDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForImplicitRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)V", "public")]
				public ForImplicitRecordComponent(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$RecordComponentPool$Record$ForImplicitRecordComponent;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isImplicit()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription getRecordComponent()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender getRecordComponentAppender()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;", "public abstract static interface")]
	public partial interface MethodPool
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodPool()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record target(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public abstract static interface")]
		public partial interface Record
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Record()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public abstract")]
			void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper;", "public static")]
			public partial class AccessBridgeWrapper
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AccessBridgeWrapper()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTarget", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTypes", "Ljava/util/Set;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription bridgeTarget_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Set;", "private final")]
				public Dova.JDK.java.util.Set bridgeTypes_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender attributeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AccessBridgeWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)V", "protected")]
				public AccessBridgeWrapper(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record of(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg4)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
				public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
				public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper$BridgeTarget;", "protected static")]
				public partial class BridgeTarget
					: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static BridgeTarget()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper$BridgeTarget;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTarget", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription bridgeTarget_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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
					public BridgeTarget(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public BridgeTarget(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper$BridgeTarget;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper$AccessorBridge;", "protected static")]
				public partial class AccessorBridge
					: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AccessorBridge()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper$AccessorBridge;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTarget", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeType", "Lnet/bytebuddy/description/method/MethodDescription$TypeToken;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription$TypeToken;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription bridgeTarget_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$TypeToken;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken bridgeType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AccessorBridge(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription$TypeToken;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public AccessorBridge(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$AccessBridgeWrapper$AccessorBridge;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod;", "public abstract static")]
			public partial class ForDefinedMethod
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForDefinedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForDefinedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public ForDefinedMethod() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$OfVisibilityBridge;", "public static")]
				public partial class OfVisibilityBridge
					: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.ForDefinedMethod
					, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfVisibilityBridge()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$OfVisibilityBridge;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibilityBridge", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTarget", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription visibilityBridge_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription bridgeTarget_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription bridgeType_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender attributeAppender_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfVisibilityBridge(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)V", "protected")]
					public OfVisibilityBridge(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$OfVisibilityBridge;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg2)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
					public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
					public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$OfVisibilityBridge$VisibilityBridge;", "protected static")]
					public partial class VisibilityBridge
						: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static VisibilityBridge()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$OfVisibilityBridge$VisibilityBridge;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTarget", "Lnet/bytebuddy/description/method/MethodDescription;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
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

						[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
						public Dova.JDK.net.bytebuddy.description.method.MethodDescription bridgeTarget_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public VisibilityBridge(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)V", "protected")]
						public VisibilityBridge(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$OfVisibilityBridge$VisibilityBridge;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithAnnotationDefaultValue;", "public static")]
				public partial class WithAnnotationDefaultValue
					: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.ForDefinedMethod
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithAnnotationDefaultValue()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithAnnotationDefaultValue;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValue", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/annotation/AnnotationValue;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private final")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue annotationValue_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender methodAttributeAppender_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithAnnotationDefaultValue(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/annotation/AnnotationValue;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;)V", "public")]
					public WithAnnotationDefaultValue(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithAnnotationDefaultValue;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
					public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
					public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithoutBody;", "public static")]
				public partial class WithoutBody
					: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.ForDefinedMethod
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithoutBody()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithoutBody;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender methodAttributeAppender_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
					public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithoutBody(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)V", "public")]
					public WithoutBody(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithoutBody;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
					public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
					public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithBody;", "public static")]
				public partial class WithBody
					: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.ForDefinedMethod
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithBody()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithBody;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteCodeAppender", "Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender byteCodeAppender_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender methodAttributeAppender_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
					public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithBody(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V", "public")]
					public WithBody(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)V", "public")]
					public WithBody(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg2, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForDefinedMethod$WithBody;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
					public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
					public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
					public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForNonImplementedMethod;", "public static")]
			public partial class ForNonImplementedMethod
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForNonImplementedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForNonImplementedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForNonImplementedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)V", "public")]
				public ForNonImplementedMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$ForNonImplementedMethod;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
				public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
				public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public static final")]
			public partial class Sort
				: Dova.JDK.java.lang.Enum
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Sort()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIPPED", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFINED", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLEMENTED", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "define", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implement", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZZ)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplemented", "()Z"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort SKIPPED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort DEFINED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort IMPLEMENTED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool define_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool implement_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Sort(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;IZZ)V", "private")]
				public Sort(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isDefined()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isImplemented()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;", "public abstract static interface")]
	public partial interface FieldPool
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldPool()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record target(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;", "public static final")]
		public partial class Disabled
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Disabled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record target(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Disabled;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Disabled>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "public abstract static interface")]
		public partial interface Record
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Record()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField", "()Lnet/bytebuddy/description/field/FieldDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicit", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAppender", "()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveDefault", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.field.FieldDescription getField()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public abstract")]
			bool isImplicit()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender getFieldAppender()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object resolveDefault(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record$ForExplicitField;", "public static")]
			public partial class ForExplicitField
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForExplicitField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record$ForExplicitField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppender", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField", "()Lnet/bytebuddy/description/field/FieldDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicit", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAppender", "()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveDefault", "(Ljava/lang/Object;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender attributeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object defaultValue_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForExplicitField(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;)V", "public")]
				public ForExplicitField(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record$ForExplicitField;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription getField()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isImplicit()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender getFieldAppender()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object resolveDefault(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record$ForImplicitField;", "public static")]
			public partial class ForImplicitField
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForImplicitField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record$ForImplicitField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField", "()Lnet/bytebuddy/description/field/FieldDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicit", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAppender", "()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveDefault", "(Ljava/lang/Object;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForImplicitField(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "public")]
				public ForImplicitField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record$ForImplicitField;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription getField()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isImplicit()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender getFieldAppender()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object resolveDefault(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}
		}
	}
}
