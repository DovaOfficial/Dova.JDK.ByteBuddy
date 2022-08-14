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

namespace Dova.JDK.com.sun.jna;

[JniSignatureAttribute("Lcom/sun/jna/Native;", "public final")]
public partial class Native
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.jna.Version
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Native()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Native;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Ljava/util/logging/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_CHARSET", "Ljava/nio/charset/Charset;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_ENCODING", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_LOAD", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_JNA_LOAD", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_JNA_LOAD_LEVEL", "Ljava/util/logging/Level;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "jnidispatchPath", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "typeOptions", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "libraries", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_OPTION_ENCLOSING_LIBRARY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_HANDLER", "Lcom/sun/jna/Callback$UncaughtExceptionHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "callbackExceptionHandler", "Lcom/sun/jna/Callback$UncaughtExceptionHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POINTER_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WCHAR_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZE_T_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOL_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_DOUBLE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_VOIDP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_LONG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_WCHAR_T", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_SIZE_T", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_BOOL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_LONG_DOUBLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_ALIGNMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_PADDING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "finalizer", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JNA_TMPLIB_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "registeredClasses", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "registeredLibraries", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CB_HAS_INITIALIZER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_UNSUPPORTED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_DEFAULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_POINTER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_STRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_STRUCTURE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_STRUCTURE_BYVAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_BUFFER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_BYTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_CHAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_INT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_LONG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_FLOAT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_DOUBLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_ARRAY_BOOLEAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_BOOLEAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_CALLBACK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_FLOAT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_NATIVE_MAPPED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_NATIVE_MAPPED_STRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_NATIVE_MAPPED_WSTRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_WSTRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_INTEGER_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_POINTER_TYPE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_TYPE_MAPPER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_TYPE_MAPPER_STRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_TYPE_MAPPER_WSTRING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_OBJECT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_JNIENV", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CVT_BYTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CB_OPTION_DIRECT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CB_OPTION_IN_DLL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nativeThreadTerminationFlag", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nativeThreads", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "main", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([BLjava/nio/charset/Charset;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toString", "([BLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indexOf", "(Lcom/sun/jna/Pointer;JJB)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByte", "(Lcom/sun/jna/Pointer;JJ)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getShort", "(Lcom/sun/jna/Pointer;JJ)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getChar", "(Lcom/sun/jna/Pointer;JJ)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInt", "(Lcom/sun/jna/Pointer;JJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLong", "(Lcom/sun/jna/Pointer;JJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFloat", "(Lcom/sun/jna/Pointer;JJ)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDouble", "(Lcom/sun/jna/Pointer;JJ)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/Class;Ljava/util/Map;)Lcom/sun/jna/Library;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/sun/jna/Library;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/Class;)Lcom/sun/jna/Library;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/String;Ljava/lang/Class;Ljava/util/Map;)Lcom/sun/jna/Library;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBytes", "(Ljava/lang/String;Ljava/nio/charset/Charset;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBytes", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toCharArray", "(Ljava/lang/String;)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "(Lcom/sun/jna/NativeLibrary;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "(Ljava/lang/Class;Lcom/sun/jna/NativeLibrary;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "(Ljava/lang/Class;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLibrary", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLibrary", "(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLibrary", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLibrary", "(Ljava/lang/String;Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "write", "(Lcom/sun/jna/Pointer;JJ[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Lcom/sun/jna/Pointer;JJ[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "close", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toByteArray", "(Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toByteArray", "(Ljava/lang/String;Ljava/nio/charset/Charset;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toByteArray", "(Ljava/lang/String;Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "open", "(Ljava/lang/String;I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isProtected", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setByte", "(Lcom/sun/jna/Pointer;JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setChar", "(Lcom/sun/jna/Pointer;JJC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setShort", "(Lcom/sun/jna/Pointer;JJS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setInt", "(Lcom/sun/jna/Pointer;JJI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLong", "(Lcom/sun/jna/Pointer;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setFloat", "(Lcom/sun/jna/Pointer;JJF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDouble", "(Lcom/sun/jna/Pointer;JJD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSignature", "(Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setMemory", "(Lcom/sun/jna/Pointer;JJJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unregister", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unregister", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unregister", "(Ljava/lang/Class;[J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getString", "(Lcom/sun/jna/Pointer;JLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getString", "(Lcom/sun/jna/Pointer;J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "free", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "detach", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultStringEncoding", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWebStartLibraryPath", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extractFromResourcePath", "(Ljava/lang/String;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extractFromResourcePath", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUnpacked", "(Ljava/io/File;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deleteLibrary", "(Ljava/io/File;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findSymbol", "(JLjava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWideString", "(Lcom/sun/jna/Pointer;JJ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setPointer", "(Lcom/sun/jna/Pointer;JJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setWideString", "(Lcom/sun/jna/Pointer;JJLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDirectBufferPointer", "(Ljava/nio/Buffer;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromNative", "(Lcom/sun/jna/FromNativeConverter;Ljava/lang/Object;Ljava/lang/reflect/Method;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromNative", "(Ljava/lang/reflect/Method;Ljava/lang/Object;)Lcom/sun/jna/NativeMapped;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromNative", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/sun/jna/NativeMapped;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNativeSize", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNativeSize", "(Ljava/lang/Class;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDirectByteBuffer", "(Lcom/sun/jna/Pointer;JJJ)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toNative", "(Lcom/sun/jna/ToNativeConverter;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "freeNativeCallback", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokePointer", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeObject", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeInt", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeLong", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeFloat", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeDouble", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeVoid", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallbackExceptionHandler", "()Lcom/sun/jna/Callback$UncaughtExceptionHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeStructure", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeStructure", "(Lcom/sun/jna/Function;JI[Ljava/lang/Object;Lcom/sun/jna/Structure;)Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSupportedNativeType", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malloc", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStructureAlignment", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Ljava/util/logging/Logger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLibraryInstance", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findEnclosingLibraryClass", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupField", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadNativeDispatchLibrary", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadNativeDispatchLibraryFromClasspath", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sizeof", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNativeVersion", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAPIChecksum", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLastError", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLastError", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "synchronizedLibrary", "(Lcom/sun/jna/Library;)Lcom/sun/jna/Library;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "markTemporaryFile", "(Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTempDir", "()Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeTemporaryFiles", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCallbackExceptionHandler", "(Lcom/sun/jna/Callback$UncaughtExceptionHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findDirectMappedClass", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallingClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLibraryOptions", "(Ljava/lang/Class;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTypeMapper", "(Ljava/lang/Class;)Lcom/sun/jna/TypeMapper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStringEncoding", "(Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createNativeCallback", "(Lcom/sun/jna/Callback;Ljava/lang/reflect/Method;[Ljava/lang/Class;Ljava/lang/Class;IILjava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nativeType", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPointer", "(J)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isCompatibleVersion", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setProtected", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCallbackThreadInitializer", "(Lcom/sun/jna/Callback;Lcom/sun/jna/CallbackThreadInitializer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowID", "(Ljava/awt/Window;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getComponentID", "(Ljava/awt/Component;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowPointer", "(Ljava/awt/Window;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getComponentPointer", "(Ljava/awt/Component;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowHandle0", "(Ljava/awt/Component;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "_getDirectBufferPointer", "(Ljava/nio/Buffer;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCharset", "(Ljava/lang/String;)Ljava/nio/charset/Charset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toStringList", "([CII)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toStringList", "([C)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unregisterAll", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registered", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConversion", "(Ljava/lang/Class;Lcom/sun/jna/TypeMapper;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cacheOptions", "(Ljava/lang/Class;Ljava/util/Map;Ljava/lang/Object;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerMethod", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;[I[J[JIJJLjava/lang/reflect/Method;JIZ[Lcom/sun/jna/ToNativeConverter;Lcom/sun/jna/FromNativeConverter;Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ffi_prep_cif", "(IIJJ)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ffi_call", "(JJJJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ffi_prep_closure", "(JLcom/sun/jna/Native$ffi_callback;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ffi_free_closure", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initialize_ffi_type", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "_getPointer", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getStringBytes", "(Lcom/sun/jna/Pointer;JJ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTerminationFlag", "(Ljava/lang/Thread;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDetachState", "(ZJ)V"));
	}

	[JniSignatureAttribute("Ljava/util/logging/Logger;", "private static final")]
	public static Dova.JDK.java.util.logging.Logger LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.logging.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/nio/charset/Charset;", "public static final")]
	public static Dova.JDK.java.nio.charset.Charset DEFAULT_CHARSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_ENCODING_Property
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

	[JniSignatureAttribute("Z", "public static final")]
	public static bool DEBUG_LOAD_Property
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

	[JniSignatureAttribute("Z", "public static final")]
	public static bool DEBUG_JNA_LOAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/logging/Level;", "private static final")]
	public static Dova.JDK.java.util.logging.Level DEBUG_JNA_LOAD_LEVEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.logging.Level>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String jnidispatchPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map typeOptions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map libraries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String _OPTION_ENCLOSING_LIBRARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Callback$UncaughtExceptionHandler;", "private static final")]
	public static Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler DEFAULT_HANDLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Callback$UncaughtExceptionHandler;", "private static")]
	public static Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler callbackExceptionHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int POINTER_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LONG_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int WCHAR_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SIZE_T_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BOOL_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LONG_DOUBLE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE_VOIDP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE_LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE_WCHAR_T_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE_SIZE_T_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE_BOOL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TYPE_LONG_DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_ALIGNMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int MAX_PADDING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object finalizer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String JNA_TMPLIB_PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map registeredClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map registeredLibraries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CB_HAS_INITIALIZER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_UNSUPPORTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_POINTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_STRUCTURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_STRUCTURE_BYVAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_BUFFER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_INT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_ARRAY_BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_CALLBACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_NATIVE_MAPPED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_NATIVE_MAPPED_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_NATIVE_MAPPED_WSTRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[51]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[51], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_WSTRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[52]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[52], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_INTEGER_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[53]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[53], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_POINTER_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[54]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[54], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_TYPE_MAPPER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_TYPE_MAPPER_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_TYPE_MAPPER_WSTRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[57]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[57], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_OBJECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[58]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[58], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_JNIENV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[59]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[59], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[60]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[60], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CVT_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[61]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[61], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CB_OPTION_DIRECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[62]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[62], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CB_OPTION_IN_DLL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[63]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[63], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static final")]
	public static Dova.JDK.java.lang.ThreadLocal nativeThreadTerminationFlag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map nativeThreads_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Native(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Native() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/Native;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public static")]
	public static void main(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("([C)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BLjava/nio/charset/Charset;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<byte> arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BLjava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String toString(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJB)J", "static native")]
	public static long indexOf(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, byte arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)B", "static native")]
	public static byte getByte(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)S", "static native")]
	public static short getShort(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticShortMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)C", "static native")]
	public static char getChar(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)I", "static native")]
	public static int getInt(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)J", "static native")]
	public static long getLong(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)F", "static native")]
	public static float getFloat(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)D", "static native")]
	public static double getDouble(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Map;)Lcom/sun/jna/Library;", "public static")]
	public static Dova.JDK.java.lang.Object load(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Lcom/sun/jna/Library;", "public static")]
	public static Dova.JDK.java.lang.Object load(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/Library;", "public static")]
	public static Dova.JDK.java.lang.Object load(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;Ljava/util/Map;)Lcom/sun/jna/Library;", "public static")]
	public static Dova.JDK.java.lang.Object load(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)[B", "static")]
	public static JavaArray<byte> getBytes(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;)[B", "static")]
	public static JavaArray<byte> getBytes(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "static")]
	public static JavaArray<byte> getBytes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String replace(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[C", "public static")]
	public static JavaArray<char> toCharArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/NativeLibrary;)V", "public static")]
	public static void register(Dova.JDK.com.sun.jna.NativeLibrary arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void register(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/NativeLibrary;)V", "public static")]
	public static void register(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.NativeLibrary arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)V", "public static")]
	public static void register(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object loadLibrary(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object loadLibrary(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object loadLibrary(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object loadLibrary(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[SII)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<short> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[CII)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<char> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[BII)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[DII)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[FII)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<float> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[JII)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<long> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[III)V", "static native")]
	public static void write(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[JII)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<long> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[III)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<int> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[FII)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<float> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[CII)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<char> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[SII)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<short> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[BII)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<byte> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ[DII)V", "static native")]
	public static void read(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, JavaArray<double> arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void close(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[B", "public static")]
	public static JavaArray<byte> toByteArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/nio/charset/Charset;)[B", "public static")]
	public static JavaArray<byte> toByteArray(Dova.JDK.java.lang.String arg0, Dova.JDK.java.nio.charset.Charset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)[B", "public static")]
	public static JavaArray<byte> toByteArray(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "static")]
	public static long open(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)J", "static native")]
	public static long open(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static synchronized native")]
	public static bool isProtected()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJB)V", "static native")]
	public static void setByte(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, byte arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJC)V", "static native")]
	public static void setChar(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, char arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJS)V", "static native")]
	public static void setShort(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, short arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJI)V", "static native")]
	public static void setInt(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJJ)V", "static native")]
	public static void setLong(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJF)V", "static native")]
	public static void setFloat(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, float arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJD)V", "static native")]
	public static void setDouble(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, double arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getSignature(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJJB)V", "static native")]
	public static void setMemory(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, long arg3, byte arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[59], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[60]);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void unregister()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[61]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public static")]
	public static void unregister(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[J)V", "private static native")]
	public static void unregister(Dova.JDK.java.lang.Class arg0, JavaArray<long> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JLjava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getString(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;J)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getString(Dova.JDK.com.sun.jna.Pointer arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)V", "public static native")]
	public static void free(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void dispose()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[67]);
	}

	[JniSignatureAttribute("(Z)V", "public static")]
	public static void detach(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getDefaultStringEncoding()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getWebStartLibraryPath(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/File;", "public static")]
	public static Dova.JDK.java.io.File extractFromResourcePath(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/io/File;", "public static")]
	public static Dova.JDK.java.io.File extractFromResourcePath(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Z", "static")]
	public static bool isUnpacked(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[73], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/File;)Z", "static")]
	public static bool deleteLibrary(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[74], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/lang/String;)J", "static native")]
	public static long findSymbol(long arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)Ljava/lang/String;", "static native")]
	public static Dova.JDK.java.lang.String getWideString(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJJ)V", "static native")]
	public static void setPointer(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJLjava/lang/String;)V", "static native")]
	public static void setWideString(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[78], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/nio/Buffer;)Lcom/sun/jna/Pointer;", "public static")]
	public static Dova.JDK.com.sun.jna.Pointer getDirectBufferPointer(Dova.JDK.java.nio.Buffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/FromNativeConverter;Ljava/lang/Object;Ljava/lang/reflect/Method;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object fromNative(Dova.JDK.com.sun.jna.FromNativeConverter arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.reflect.Method arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Object;)Lcom/sun/jna/NativeMapped;", "private static")]
	public static Dova.JDK.com.sun.jna.NativeMapped fromNative(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeMapped>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Lcom/sun/jna/NativeMapped;", "private static")]
	public static Dova.JDK.com.sun.jna.NativeMapped fromNative(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeMapped>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public static")]
	public static int getNativeSize(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[83], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)I", "public static")]
	public static int getNativeSize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[84], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJJ)Ljava/nio/ByteBuffer;", "static native")]
	public static Dova.JDK.java.nio.ByteBuffer getDirectByteBuffer(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/ToNativeConverter;Ljava/lang/Object;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object toNative(Dova.JDK.com.sun.jna.ToNativeConverter arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(J)V", "static synchronized native")]
	public static void freeNativeCallback(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[87], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)J", "static native")]
	public static long invokePointer(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[88], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)Ljava/lang/Object;", "static native")]
	public static Dova.JDK.java.lang.Object invokeObject(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[89], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)I", "static native")]
	public static int invokeInt(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[90], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)J", "static native")]
	public static long invokeLong(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[91], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)F", "static native")]
	public static float invokeFloat(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticFloatMethodA(ClassRefPtr, MethodPtrs[92], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)D", "static native")]
	public static double invokeDouble(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[93], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;)V", "static native")]
	public static void invokeVoid(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Callback$UncaughtExceptionHandler;", "public static")]
	public static Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler getCallbackExceptionHandler()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[95]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;JJ)V", "private static native")]
	public static void invokeStructure(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, long arg4, long arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[96], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;JI[Ljava/lang/Object;Lcom/sun/jna/Structure;)Lcom/sun/jna/Structure;", "static")]
	public static Dova.JDK.com.sun.jna.Structure invokeStructure(Dova.JDK.com.sun.jna.Function arg0, long arg1, int arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, Dova.JDK.com.sun.jna.Structure arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[97], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public static")]
	public static bool isSupportedNativeType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[98], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public static native")]
	public static long malloc(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[99], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "public static")]
	public static int getStructureAlignment(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[100], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "static")]
	public static void access_100()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[101]);
	}

	[JniSignatureAttribute("()Ljava/util/logging/Logger;", "static")]
	public static Dova.JDK.java.util.logging.Logger access_000()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.logging.Logger>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void loadLibraryInstance(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[103], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class findEnclosingLibraryClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[104], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object lookupField(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void loadNativeDispatchLibrary()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[106]);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void loadNativeDispatchLibraryFromClasspath()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[107]);
	}

	[JniSignatureAttribute("(I)I", "private static native")]
	public static int @sizeof(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[108], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String getNativeVersion()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private static native")]
	public static Dova.JDK.java.lang.String getAPIChecksum()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public static native")]
	public static int getLastError()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[111]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public static native")]
	public static void setLastError(int arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[112], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Library;)Lcom/sun/jna/Library;", "public static")]
	public static Dova.JDK.com.sun.jna.Library synchronizedLibrary(Dova.JDK.com.sun.jna.Library arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Library>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)V", "static")]
	public static void markTemporaryFile(Dova.JDK.java.io.File arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[114], arg0);
	}

	[JniSignatureAttribute("()Ljava/io/File;", "static")]
	public static Dova.JDK.java.io.File getTempDir()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[115]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("()V", "static")]
	public static void removeTemporaryFiles()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[116]);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback$UncaughtExceptionHandler;)V", "public static")]
	public static void setCallbackExceptionHandler(Dova.JDK.com.sun.jna.Callback.UncaughtExceptionHandler arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[117], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class findDirectMappedClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[118], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class getCallingClass()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[119]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/Map;", "public static")]
	public static Dova.JDK.java.util.Map getLibraryOptions(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[120], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/TypeMapper;", "public static")]
	public static Dova.JDK.com.sun.jna.TypeMapper getTypeMapper(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[121], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.TypeMapper>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getStringEncoding(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[122], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;Ljava/lang/reflect/Method;[Ljava/lang/Class;Ljava/lang/Class;IILjava/lang/String;)J", "static synchronized native")]
	public static long createNativeCallback(Dova.JDK.com.sun.jna.Callback arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, Dova.JDK.java.lang.Class arg3, int arg4, int arg5, Dova.JDK.java.lang.String arg6)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[123], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class nativeType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[124], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "static")]
	public static Dova.JDK.com.sun.jna.Pointer getPointer(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[125], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "static")]
	public static bool isCompatibleVersion(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[126], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public static synchronized native")]
	public static void setProtected(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[127], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;Lcom/sun/jna/CallbackThreadInitializer;)V", "public static")]
	public static void setCallbackThreadInitializer(Dova.JDK.com.sun.jna.Callback arg0, Dova.JDK.com.sun.jna.CallbackThreadInitializer arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[128], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)J", "public static")]
	public static long getWindowID(Dova.JDK.java.awt.Window arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[129], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)J", "public static")]
	public static long getComponentID(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[130], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Window;)Lcom/sun/jna/Pointer;", "public static")]
	public static Dova.JDK.com.sun.jna.Pointer getWindowPointer(Dova.JDK.java.awt.Window arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Lcom/sun/jna/Pointer;", "public static")]
	public static Dova.JDK.com.sun.jna.Pointer getComponentPointer(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[132], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)J", "static native")]
	public static long getWindowHandle0(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[133], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/Buffer;)J", "private static native")]
	public static long _getDirectBufferPointer(Dova.JDK.java.nio.Buffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[134], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/charset/Charset;", "private static")]
	public static Dova.JDK.java.nio.charset.Charset getCharset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[135], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
	}

	[JniSignatureAttribute("([CII)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List toStringList(JavaArray<char> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[136], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("([C)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List toStringList(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[137], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void unregisterAll()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[138]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public static")]
	public static bool registered(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[139], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/TypeMapper;Z)I", "private static")]
	public static int getConversion(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.TypeMapper arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[140], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Map;Ljava/lang/Object;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map cacheOptions(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[141], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;[I[J[JIJJLjava/lang/reflect/Method;JIZ[Lcom/sun/jna/ToNativeConverter;Lcom/sun/jna/FromNativeConverter;Ljava/lang/String;)J", "private static native")]
	public static long registerMethod(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<int> arg3, JavaArray<long> arg4, JavaArray<long> arg5, int arg6, long arg7, long arg8, Dova.JDK.java.lang.reflect.Method arg9, long arg10, int arg11, bool arg12, JavaArray<Dova.JDK.com.sun.jna.ToNativeConverter> arg13, Dova.JDK.com.sun.jna.FromNativeConverter arg14, Dova.JDK.java.lang.String arg15)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[142], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
		return ret;
	}

	[JniSignatureAttribute("(IIJJ)J", "public static native")]
	public static long ffi_prep_cif(int arg0, int arg1, long arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[143], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJJJ)V", "public static native")]
	public static void ffi_call(long arg0, long arg1, long arg2, long arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[144], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JLcom/sun/jna/Native$ffi_callback;)J", "public static native")]
	public static long ffi_prep_closure(long arg0, Dova.JDK.com.sun.jna.Native.ffi_callback arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[145], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public static native")]
	public static void ffi_free_closure(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[146], arg0);
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int initialize_ffi_type(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[147], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "private static native")]
	public static long _getPointer(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[148], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;JJ)[B", "static native")]
	public static JavaArray<byte> getStringBytes(Dova.JDK.com.sun.jna.Pointer arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[149], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Thread;)Lcom/sun/jna/Pointer;", "static")]
	public static Dova.JDK.com.sun.jna.Pointer getTerminationFlag(Dova.JDK.java.lang.Thread arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[150], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(ZJ)V", "private static native")]
	public static void setDetachState(bool arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[151], arg0, arg1);
	}

	[JniSignatureAttribute("Lcom/sun/jna/Native$AWT;", "private static")]
	public partial class AWT
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AWT()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Native$AWT;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getWindowID", "(Ljava/awt/Window;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getComponentID", "(Ljava/lang/Object;)J"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AWT(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AWT() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Native$AWT;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Window;)J", "static")]
		public static long getWindowID(Dova.JDK.java.awt.Window arg0)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)J", "static")]
		public static long getComponentID(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Native$Buffers;", "private static")]
	public partial class Buffers
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Buffers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Native$Buffers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isBuffer", "(Ljava/lang/Class;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Buffers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Buffers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Native$Buffers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "static")]
		public static bool isBuffer(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Native$ffi_callback;", "public abstract static interface")]
	public partial interface ffi_callback
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ffi_callback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Native$ffi_callback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(JJJ)V"));
		}

		[JniSignatureAttribute("(JJJ)V", "public abstract")]
		void invoke(long arg0, long arg1, long arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}
}
