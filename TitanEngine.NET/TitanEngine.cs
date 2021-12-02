using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace TitanEngine.NET
{
    public unsafe partial class PE32Struct : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 96, Pack = 1)]
        public partial struct __Internal
        {
            internal uint PE32Offset;
            internal uint ImageBase;
            internal uint OriginalEntryPoint;
            internal uint BaseOfCode;
            internal uint BaseOfData;
            internal uint NtSizeOfImage;
            internal uint NtSizeOfHeaders;
            internal ushort SizeOfOptionalHeaders;
            internal uint FileAlignment;
            internal uint SectionAligment;
            internal uint ImportTableAddress;
            internal uint ImportTableSize;
            internal uint ResourceTableAddress;
            internal uint ResourceTableSize;
            internal uint ExportTableAddress;
            internal uint ExportTableSize;
            internal uint TLSTableAddress;
            internal uint TLSTableSize;
            internal uint RelocationTableAddress;
            internal uint RelocationTableSize;
            internal uint TimeDateStamp;
            internal ushort SectionNumber;
            internal uint CheckSum;
            internal ushort SubSystem;
            internal ushort Characteristics;
            internal uint NumberOfRvaAndSizes;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0PE32Struct@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PE32Struct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PE32Struct>();

        protected bool __ownsNativeInstance;

        internal static PE32Struct __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new PE32Struct(native.ToPointer(), skipVTables);
        }

        internal static PE32Struct __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (PE32Struct)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static PE32Struct __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PE32Struct(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private PE32Struct(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected PE32Struct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public PE32Struct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PE32Struct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public PE32Struct(global::TitanEngine.NET.PE32Struct __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PE32Struct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.PE32Struct.__Internal*)__Instance) = *((global::TitanEngine.NET.PE32Struct.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint PE32Offset
        {
            get
            {
                return ((__Internal*)__Instance)->PE32Offset;
            }

            set
            {
                ((__Internal*)__Instance)->PE32Offset = value;
            }
        }

        public uint ImageBase
        {
            get
            {
                return ((__Internal*)__Instance)->ImageBase;
            }

            set
            {
                ((__Internal*)__Instance)->ImageBase = value;
            }
        }

        public uint OriginalEntryPoint
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalEntryPoint;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalEntryPoint = value;
            }
        }

        public uint BaseOfCode
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfCode;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfCode = value;
            }
        }

        public uint BaseOfData
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfData;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfData = value;
            }
        }

        public uint NtSizeOfImage
        {
            get
            {
                return ((__Internal*)__Instance)->NtSizeOfImage;
            }

            set
            {
                ((__Internal*)__Instance)->NtSizeOfImage = value;
            }
        }

        public uint NtSizeOfHeaders
        {
            get
            {
                return ((__Internal*)__Instance)->NtSizeOfHeaders;
            }

            set
            {
                ((__Internal*)__Instance)->NtSizeOfHeaders = value;
            }
        }

        public ushort SizeOfOptionalHeaders
        {
            get
            {
                return ((__Internal*)__Instance)->SizeOfOptionalHeaders;
            }

            set
            {
                ((__Internal*)__Instance)->SizeOfOptionalHeaders = value;
            }
        }

        public uint FileAlignment
        {
            get
            {
                return ((__Internal*)__Instance)->FileAlignment;
            }

            set
            {
                ((__Internal*)__Instance)->FileAlignment = value;
            }
        }

        public uint SectionAligment
        {
            get
            {
                return ((__Internal*)__Instance)->SectionAligment;
            }

            set
            {
                ((__Internal*)__Instance)->SectionAligment = value;
            }
        }

        public uint ImportTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTableAddress = value;
            }
        }

        public uint ImportTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTableSize = value;
            }
        }

        public uint ResourceTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ResourceTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ResourceTableAddress = value;
            }
        }

        public uint ResourceTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->ResourceTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->ResourceTableSize = value;
            }
        }

        public uint ExportTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ExportTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ExportTableAddress = value;
            }
        }

        public uint ExportTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->ExportTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->ExportTableSize = value;
            }
        }

        public uint TLSTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->TLSTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->TLSTableAddress = value;
            }
        }

        public uint TLSTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->TLSTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->TLSTableSize = value;
            }
        }

        public uint RelocationTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->RelocationTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->RelocationTableAddress = value;
            }
        }

        public uint RelocationTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->RelocationTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->RelocationTableSize = value;
            }
        }

        public uint TimeDateStamp
        {
            get
            {
                return ((__Internal*)__Instance)->TimeDateStamp;
            }

            set
            {
                ((__Internal*)__Instance)->TimeDateStamp = value;
            }
        }

        public ushort SectionNumber
        {
            get
            {
                return ((__Internal*)__Instance)->SectionNumber;
            }

            set
            {
                ((__Internal*)__Instance)->SectionNumber = value;
            }
        }

        public uint CheckSum
        {
            get
            {
                return ((__Internal*)__Instance)->CheckSum;
            }

            set
            {
                ((__Internal*)__Instance)->CheckSum = value;
            }
        }

        public ushort SubSystem
        {
            get
            {
                return ((__Internal*)__Instance)->SubSystem;
            }

            set
            {
                ((__Internal*)__Instance)->SubSystem = value;
            }
        }

        public ushort Characteristics
        {
            get
            {
                return ((__Internal*)__Instance)->Characteristics;
            }

            set
            {
                ((__Internal*)__Instance)->Characteristics = value;
            }
        }

        public uint NumberOfRvaAndSizes
        {
            get
            {
                return ((__Internal*)__Instance)->NumberOfRvaAndSizes;
            }

            set
            {
                ((__Internal*)__Instance)->NumberOfRvaAndSizes = value;
            }
        }
    }

    public unsafe partial class PE64Struct : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 100, Pack = 1)]
        public partial struct __Internal
        {
            internal uint PE64Offset;
            internal ulong ImageBase;
            internal uint OriginalEntryPoint;
            internal uint BaseOfCode;
            internal uint BaseOfData;
            internal uint NtSizeOfImage;
            internal uint NtSizeOfHeaders;
            internal ushort SizeOfOptionalHeaders;
            internal uint FileAlignment;
            internal uint SectionAligment;
            internal uint ImportTableAddress;
            internal uint ImportTableSize;
            internal uint ResourceTableAddress;
            internal uint ResourceTableSize;
            internal uint ExportTableAddress;
            internal uint ExportTableSize;
            internal uint TLSTableAddress;
            internal uint TLSTableSize;
            internal uint RelocationTableAddress;
            internal uint RelocationTableSize;
            internal uint TimeDateStamp;
            internal ushort SectionNumber;
            internal uint CheckSum;
            internal ushort SubSystem;
            internal ushort Characteristics;
            internal uint NumberOfRvaAndSizes;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0PE64Struct@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PE64Struct> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PE64Struct>();

        protected bool __ownsNativeInstance;

        internal static PE64Struct __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new PE64Struct(native.ToPointer(), skipVTables);
        }

        internal static PE64Struct __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (PE64Struct)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static PE64Struct __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PE64Struct(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private PE64Struct(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected PE64Struct(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public PE64Struct()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PE64Struct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public PE64Struct(global::TitanEngine.NET.PE64Struct __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PE64Struct.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.PE64Struct.__Internal*)__Instance) = *((global::TitanEngine.NET.PE64Struct.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint PE64Offset
        {
            get
            {
                return ((__Internal*)__Instance)->PE64Offset;
            }

            set
            {
                ((__Internal*)__Instance)->PE64Offset = value;
            }
        }

        public ulong ImageBase
        {
            get
            {
                return ((__Internal*)__Instance)->ImageBase;
            }

            set
            {
                ((__Internal*)__Instance)->ImageBase = value;
            }
        }

        public uint OriginalEntryPoint
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalEntryPoint;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalEntryPoint = value;
            }
        }

        public uint BaseOfCode
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfCode;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfCode = value;
            }
        }

        public uint BaseOfData
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfData;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfData = value;
            }
        }

        public uint NtSizeOfImage
        {
            get
            {
                return ((__Internal*)__Instance)->NtSizeOfImage;
            }

            set
            {
                ((__Internal*)__Instance)->NtSizeOfImage = value;
            }
        }

        public uint NtSizeOfHeaders
        {
            get
            {
                return ((__Internal*)__Instance)->NtSizeOfHeaders;
            }

            set
            {
                ((__Internal*)__Instance)->NtSizeOfHeaders = value;
            }
        }

        public ushort SizeOfOptionalHeaders
        {
            get
            {
                return ((__Internal*)__Instance)->SizeOfOptionalHeaders;
            }

            set
            {
                ((__Internal*)__Instance)->SizeOfOptionalHeaders = value;
            }
        }

        public uint FileAlignment
        {
            get
            {
                return ((__Internal*)__Instance)->FileAlignment;
            }

            set
            {
                ((__Internal*)__Instance)->FileAlignment = value;
            }
        }

        public uint SectionAligment
        {
            get
            {
                return ((__Internal*)__Instance)->SectionAligment;
            }

            set
            {
                ((__Internal*)__Instance)->SectionAligment = value;
            }
        }

        public uint ImportTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTableAddress = value;
            }
        }

        public uint ImportTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTableSize = value;
            }
        }

        public uint ResourceTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ResourceTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ResourceTableAddress = value;
            }
        }

        public uint ResourceTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->ResourceTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->ResourceTableSize = value;
            }
        }

        public uint ExportTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ExportTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ExportTableAddress = value;
            }
        }

        public uint ExportTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->ExportTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->ExportTableSize = value;
            }
        }

        public uint TLSTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->TLSTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->TLSTableAddress = value;
            }
        }

        public uint TLSTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->TLSTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->TLSTableSize = value;
            }
        }

        public uint RelocationTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->RelocationTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->RelocationTableAddress = value;
            }
        }

        public uint RelocationTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->RelocationTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->RelocationTableSize = value;
            }
        }

        public uint TimeDateStamp
        {
            get
            {
                return ((__Internal*)__Instance)->TimeDateStamp;
            }

            set
            {
                ((__Internal*)__Instance)->TimeDateStamp = value;
            }
        }

        public ushort SectionNumber
        {
            get
            {
                return ((__Internal*)__Instance)->SectionNumber;
            }

            set
            {
                ((__Internal*)__Instance)->SectionNumber = value;
            }
        }

        public uint CheckSum
        {
            get
            {
                return ((__Internal*)__Instance)->CheckSum;
            }

            set
            {
                ((__Internal*)__Instance)->CheckSum = value;
            }
        }

        public ushort SubSystem
        {
            get
            {
                return ((__Internal*)__Instance)->SubSystem;
            }

            set
            {
                ((__Internal*)__Instance)->SubSystem = value;
            }
        }

        public ushort Characteristics
        {
            get
            {
                return ((__Internal*)__Instance)->Characteristics;
            }

            set
            {
                ((__Internal*)__Instance)->Characteristics = value;
            }
        }

        public uint NumberOfRvaAndSizes
        {
            get
            {
                return ((__Internal*)__Instance)->NumberOfRvaAndSizes;
            }

            set
            {
                ((__Internal*)__Instance)->NumberOfRvaAndSizes = value;
            }
        }
    }

    public unsafe partial class ImportEnumData : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 45, Pack = 1)]
        public partial struct __Internal
        {
            internal byte NewDll;
            internal int NumberOfImports;
            internal ulong ImageBase;
            internal ulong BaseImportThunk;
            internal ulong ImportThunk;
            internal __IntPtr APIName;
            internal __IntPtr DLLName;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0ImportEnumData@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.ImportEnumData> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.ImportEnumData>();

        protected bool __ownsNativeInstance;

        internal static ImportEnumData __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new ImportEnumData(native.ToPointer(), skipVTables);
        }

        internal static ImportEnumData __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (ImportEnumData)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static ImportEnumData __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new ImportEnumData(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ImportEnumData(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ImportEnumData(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public ImportEnumData()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.ImportEnumData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ImportEnumData(global::TitanEngine.NET.ImportEnumData __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.ImportEnumData.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.ImportEnumData.__Internal*)__Instance) = *((global::TitanEngine.NET.ImportEnumData.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public bool NewDll
        {
            get
            {
                return ((__Internal*)__Instance)->NewDll != 0;
            }

            set
            {
                ((__Internal*)__Instance)->NewDll = (byte)(value ? 1 : 0);
            }
        }

        public int NumberOfImports
        {
            get
            {
                return ((__Internal*)__Instance)->NumberOfImports;
            }

            set
            {
                ((__Internal*)__Instance)->NumberOfImports = value;
            }
        }

        public ulong ImageBase
        {
            get
            {
                return ((__Internal*)__Instance)->ImageBase;
            }

            set
            {
                ((__Internal*)__Instance)->ImageBase = value;
            }
        }

        public ulong BaseImportThunk
        {
            get
            {
                return ((__Internal*)__Instance)->BaseImportThunk;
            }

            set
            {
                ((__Internal*)__Instance)->BaseImportThunk = value;
            }
        }

        public ulong ImportThunk
        {
            get
            {
                return ((__Internal*)__Instance)->ImportThunk;
            }

            set
            {
                ((__Internal*)__Instance)->ImportThunk = value;
            }
        }

        public sbyte* APIName
        {
            get
            {
                return (sbyte*)((__Internal*)__Instance)->APIName;
            }

            set
            {
                ((__Internal*)__Instance)->APIName = (__IntPtr)value;
            }
        }

        public sbyte* DLLName
        {
            get
            {
                return (sbyte*)((__Internal*)__Instance)->DLLName;
            }

            set
            {
                ((__Internal*)__Instance)->DLLName = (__IntPtr)value;
            }
        }
    }

    public unsafe partial class THREAD_ITEM_DATA : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 60, Pack = 1)]
        public partial struct __Internal
        {
            internal __IntPtr hThread;
            internal uint dwThreadId;
            internal __IntPtr ThreadStartAddress;
            internal __IntPtr ThreadLocalBase;
            internal __IntPtr TebAddress;
            internal uint WaitTime;
            internal int Priority;
            internal int BasePriority;
            internal uint ContextSwitches;
            internal uint ThreadState;
            internal uint WaitReason;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0THREAD_ITEM_DATA@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.THREAD_ITEM_DATA> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.THREAD_ITEM_DATA>();

        protected bool __ownsNativeInstance;

        internal static THREAD_ITEM_DATA __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new THREAD_ITEM_DATA(native.ToPointer(), skipVTables);
        }

        internal static THREAD_ITEM_DATA __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (THREAD_ITEM_DATA)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static THREAD_ITEM_DATA __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new THREAD_ITEM_DATA(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private THREAD_ITEM_DATA(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected THREAD_ITEM_DATA(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public THREAD_ITEM_DATA()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.THREAD_ITEM_DATA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public THREAD_ITEM_DATA(global::TitanEngine.NET.THREAD_ITEM_DATA __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.THREAD_ITEM_DATA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.THREAD_ITEM_DATA.__Internal*)__Instance) = *((global::TitanEngine.NET.THREAD_ITEM_DATA.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public __IntPtr HThread
        {
            get
            {
                return ((__Internal*)__Instance)->hThread;
            }

            set
            {
                ((__Internal*)__Instance)->hThread = (__IntPtr)value;
            }
        }

        public uint DwThreadId
        {
            get
            {
                return ((__Internal*)__Instance)->dwThreadId;
            }

            set
            {
                ((__Internal*)__Instance)->dwThreadId = value;
            }
        }

        public __IntPtr ThreadStartAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ThreadStartAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ThreadStartAddress = (__IntPtr)value;
            }
        }

        public __IntPtr ThreadLocalBase
        {
            get
            {
                return ((__Internal*)__Instance)->ThreadLocalBase;
            }

            set
            {
                ((__Internal*)__Instance)->ThreadLocalBase = (__IntPtr)value;
            }
        }

        public __IntPtr TebAddress
        {
            get
            {
                return ((__Internal*)__Instance)->TebAddress;
            }

            set
            {
                ((__Internal*)__Instance)->TebAddress = (__IntPtr)value;
            }
        }

        public uint WaitTime
        {
            get
            {
                return ((__Internal*)__Instance)->WaitTime;
            }

            set
            {
                ((__Internal*)__Instance)->WaitTime = value;
            }
        }

        public int Priority
        {
            get
            {
                return ((__Internal*)__Instance)->Priority;
            }

            set
            {
                ((__Internal*)__Instance)->Priority = value;
            }
        }

        public int BasePriority
        {
            get
            {
                return ((__Internal*)__Instance)->BasePriority;
            }

            set
            {
                ((__Internal*)__Instance)->BasePriority = value;
            }
        }

        public uint ContextSwitches
        {
            get
            {
                return ((__Internal*)__Instance)->ContextSwitches;
            }

            set
            {
                ((__Internal*)__Instance)->ContextSwitches = value;
            }
        }

        public uint ThreadState
        {
            get
            {
                return ((__Internal*)__Instance)->ThreadState;
            }

            set
            {
                ((__Internal*)__Instance)->ThreadState = value;
            }
        }

        public uint WaitReason
        {
            get
            {
                return ((__Internal*)__Instance)->WaitReason;
            }

            set
            {
                ((__Internal*)__Instance)->WaitReason = value;
            }
        }
    }

    public unsafe partial class LIBRARY_ITEM_DATA : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 552, Pack = 1)]
        public partial struct __Internal
        {
            internal __IntPtr hFile;
            internal __IntPtr BaseOfDll;
            internal __IntPtr hFileMapping;
            internal __IntPtr hFileMappingView;
            internal fixed sbyte szLibraryPath[260];
            internal fixed sbyte szLibraryName[260];

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0LIBRARY_ITEM_DATA@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.LIBRARY_ITEM_DATA> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.LIBRARY_ITEM_DATA>();

        protected bool __ownsNativeInstance;

        internal static LIBRARY_ITEM_DATA __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new LIBRARY_ITEM_DATA(native.ToPointer(), skipVTables);
        }

        internal static LIBRARY_ITEM_DATA __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (LIBRARY_ITEM_DATA)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static LIBRARY_ITEM_DATA __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new LIBRARY_ITEM_DATA(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private LIBRARY_ITEM_DATA(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LIBRARY_ITEM_DATA(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public LIBRARY_ITEM_DATA()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.LIBRARY_ITEM_DATA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public LIBRARY_ITEM_DATA(global::TitanEngine.NET.LIBRARY_ITEM_DATA __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.LIBRARY_ITEM_DATA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.LIBRARY_ITEM_DATA.__Internal*)__Instance) = *((global::TitanEngine.NET.LIBRARY_ITEM_DATA.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public __IntPtr HFile
        {
            get
            {
                return ((__Internal*)__Instance)->hFile;
            }

            set
            {
                ((__Internal*)__Instance)->hFile = (__IntPtr)value;
            }
        }

        public __IntPtr BaseOfDll
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfDll;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfDll = (__IntPtr)value;
            }
        }

        public __IntPtr HFileMapping
        {
            get
            {
                return ((__Internal*)__Instance)->hFileMapping;
            }

            set
            {
                ((__Internal*)__Instance)->hFileMapping = (__IntPtr)value;
            }
        }

        public __IntPtr HFileMappingView
        {
            get
            {
                return ((__Internal*)__Instance)->hFileMappingView;
            }

            set
            {
                ((__Internal*)__Instance)->hFileMappingView = (__IntPtr)value;
            }
        }

        public sbyte[] SzLibraryPath
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->szLibraryPath, 260);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 260; i++)
                        ((__Internal*)__Instance)->szLibraryPath[i] = value[i];
                }
            }
        }

        public sbyte[] SzLibraryName
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->szLibraryName, 260);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 260; i++)
                        ((__Internal*)__Instance)->szLibraryName[i] = value[i];
                }
            }
        }
    }

    public unsafe partial class LIBRARY_ITEM_DATAW : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 1072, Pack = 1)]
        public partial struct __Internal
        {
            internal __IntPtr hFile;
            internal __IntPtr BaseOfDll;
            internal __IntPtr hFileMapping;
            internal __IntPtr hFileMappingView;
            internal fixed char szLibraryPath[260];
            internal fixed char szLibraryName[260];

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0LIBRARY_ITEM_DATAW@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.LIBRARY_ITEM_DATAW> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.LIBRARY_ITEM_DATAW>();

        protected bool __ownsNativeInstance;

        internal static LIBRARY_ITEM_DATAW __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new LIBRARY_ITEM_DATAW(native.ToPointer(), skipVTables);
        }

        internal static LIBRARY_ITEM_DATAW __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (LIBRARY_ITEM_DATAW)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static LIBRARY_ITEM_DATAW __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new LIBRARY_ITEM_DATAW(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private LIBRARY_ITEM_DATAW(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LIBRARY_ITEM_DATAW(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public LIBRARY_ITEM_DATAW()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.LIBRARY_ITEM_DATAW.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public LIBRARY_ITEM_DATAW(global::TitanEngine.NET.LIBRARY_ITEM_DATAW __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.LIBRARY_ITEM_DATAW.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.LIBRARY_ITEM_DATAW.__Internal*)__Instance) = *((global::TitanEngine.NET.LIBRARY_ITEM_DATAW.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public __IntPtr HFile
        {
            get
            {
                return ((__Internal*)__Instance)->hFile;
            }

            set
            {
                ((__Internal*)__Instance)->hFile = (__IntPtr)value;
            }
        }

        public __IntPtr BaseOfDll
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfDll;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfDll = (__IntPtr)value;
            }
        }

        public __IntPtr HFileMapping
        {
            get
            {
                return ((__Internal*)__Instance)->hFileMapping;
            }

            set
            {
                ((__Internal*)__Instance)->hFileMapping = (__IntPtr)value;
            }
        }

        public __IntPtr HFileMappingView
        {
            get
            {
                return ((__Internal*)__Instance)->hFileMappingView;
            }

            set
            {
                ((__Internal*)__Instance)->hFileMappingView = (__IntPtr)value;
            }
        }

        public char[] SzLibraryPath
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->szLibraryPath, 260);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 260; i++)
                        ((__Internal*)__Instance)->szLibraryPath[i] = value[i];
                }
            }
        }

        public char[] SzLibraryName
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<char>(((__Internal*)__Instance)->szLibraryName, 260);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 260; i++)
                        ((__Internal*)__Instance)->szLibraryName[i] = value[i];
                }
            }
        }
    }

    public unsafe partial class PROCESS_ITEM_DATA : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 56, Pack = 1)]
        public partial struct __Internal
        {
            internal __IntPtr hProcess;
            internal uint dwProcessId;
            internal __IntPtr hThread;
            internal uint dwThreadId;
            internal __IntPtr hFile;
            internal __IntPtr BaseOfImage;
            internal __IntPtr ThreadStartAddress;
            internal __IntPtr ThreadLocalBase;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0PROCESS_ITEM_DATA@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PROCESS_ITEM_DATA> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PROCESS_ITEM_DATA>();

        protected bool __ownsNativeInstance;

        internal static PROCESS_ITEM_DATA __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new PROCESS_ITEM_DATA(native.ToPointer(), skipVTables);
        }

        internal static PROCESS_ITEM_DATA __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (PROCESS_ITEM_DATA)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static PROCESS_ITEM_DATA __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PROCESS_ITEM_DATA(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private PROCESS_ITEM_DATA(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected PROCESS_ITEM_DATA(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public PROCESS_ITEM_DATA()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PROCESS_ITEM_DATA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public PROCESS_ITEM_DATA(global::TitanEngine.NET.PROCESS_ITEM_DATA __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PROCESS_ITEM_DATA.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.PROCESS_ITEM_DATA.__Internal*)__Instance) = *((global::TitanEngine.NET.PROCESS_ITEM_DATA.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public __IntPtr HProcess
        {
            get
            {
                return ((__Internal*)__Instance)->hProcess;
            }

            set
            {
                ((__Internal*)__Instance)->hProcess = (__IntPtr)value;
            }
        }

        public uint DwProcessId
        {
            get
            {
                return ((__Internal*)__Instance)->dwProcessId;
            }

            set
            {
                ((__Internal*)__Instance)->dwProcessId = value;
            }
        }

        public __IntPtr HThread
        {
            get
            {
                return ((__Internal*)__Instance)->hThread;
            }

            set
            {
                ((__Internal*)__Instance)->hThread = (__IntPtr)value;
            }
        }

        public uint DwThreadId
        {
            get
            {
                return ((__Internal*)__Instance)->dwThreadId;
            }

            set
            {
                ((__Internal*)__Instance)->dwThreadId = value;
            }
        }

        public __IntPtr HFile
        {
            get
            {
                return ((__Internal*)__Instance)->hFile;
            }

            set
            {
                ((__Internal*)__Instance)->hFile = (__IntPtr)value;
            }
        }

        public __IntPtr BaseOfImage
        {
            get
            {
                return ((__Internal*)__Instance)->BaseOfImage;
            }

            set
            {
                ((__Internal*)__Instance)->BaseOfImage = (__IntPtr)value;
            }
        }

        public __IntPtr ThreadStartAddress
        {
            get
            {
                return ((__Internal*)__Instance)->ThreadStartAddress;
            }

            set
            {
                ((__Internal*)__Instance)->ThreadStartAddress = (__IntPtr)value;
            }
        }

        public __IntPtr ThreadLocalBase
        {
            get
            {
                return ((__Internal*)__Instance)->ThreadLocalBase;
            }

            set
            {
                ((__Internal*)__Instance)->ThreadLocalBase = (__IntPtr)value;
            }
        }
    }

    public unsafe partial class HandlerArray : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 12, Pack = 1)]
        public partial struct __Internal
        {
            internal uint ProcessId;
            internal __IntPtr hHandle;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0HandlerArray@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.HandlerArray> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.HandlerArray>();

        protected bool __ownsNativeInstance;

        internal static HandlerArray __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new HandlerArray(native.ToPointer(), skipVTables);
        }

        internal static HandlerArray __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (HandlerArray)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static HandlerArray __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new HandlerArray(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private HandlerArray(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected HandlerArray(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public HandlerArray()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.HandlerArray.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public HandlerArray(global::TitanEngine.NET.HandlerArray __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.HandlerArray.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.HandlerArray.__Internal*)__Instance) = *((global::TitanEngine.NET.HandlerArray.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint ProcessId
        {
            get
            {
                return ((__Internal*)__Instance)->ProcessId;
            }

            set
            {
                ((__Internal*)__Instance)->ProcessId = value;
            }
        }

        public __IntPtr HHandle
        {
            get
            {
                return ((__Internal*)__Instance)->hHandle;
            }

            set
            {
                ((__Internal*)__Instance)->hHandle = (__IntPtr)value;
            }
        }
    }

    public unsafe partial class PluginInformation : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 113, Pack = 1)]
        public partial struct __Internal
        {
            internal fixed sbyte PluginName[64];
            internal uint PluginMajorVersion;
            internal uint PluginMinorVersion;
            internal __IntPtr PluginBaseAddress;
            internal __IntPtr TitanDebuggingCallBack;
            internal __IntPtr TitanRegisterPlugin;
            internal __IntPtr TitanReleasePlugin;
            internal __IntPtr TitanResetPlugin;
            internal byte PluginDisabled;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0PluginInformation@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PluginInformation> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.PluginInformation>();

        protected bool __ownsNativeInstance;

        internal static PluginInformation __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new PluginInformation(native.ToPointer(), skipVTables);
        }

        internal static PluginInformation __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (PluginInformation)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static PluginInformation __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PluginInformation(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private PluginInformation(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected PluginInformation(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public PluginInformation()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PluginInformation.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public PluginInformation(global::TitanEngine.NET.PluginInformation __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.PluginInformation.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.PluginInformation.__Internal*)__Instance) = *((global::TitanEngine.NET.PluginInformation.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] PluginName
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<sbyte>(((__Internal*)__Instance)->PluginName, 64);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 64; i++)
                        ((__Internal*)__Instance)->PluginName[i] = value[i];
                }
            }
        }

        public uint PluginMajorVersion
        {
            get
            {
                return ((__Internal*)__Instance)->PluginMajorVersion;
            }

            set
            {
                ((__Internal*)__Instance)->PluginMajorVersion = value;
            }
        }

        public uint PluginMinorVersion
        {
            get
            {
                return ((__Internal*)__Instance)->PluginMinorVersion;
            }

            set
            {
                ((__Internal*)__Instance)->PluginMinorVersion = value;
            }
        }

        public __IntPtr TitanDebuggingCallBack
        {
            get
            {
                return ((__Internal*)__Instance)->TitanDebuggingCallBack;
            }

            set
            {
                ((__Internal*)__Instance)->TitanDebuggingCallBack = (__IntPtr)value;
            }
        }

        public __IntPtr TitanRegisterPlugin
        {
            get
            {
                return ((__Internal*)__Instance)->TitanRegisterPlugin;
            }

            set
            {
                ((__Internal*)__Instance)->TitanRegisterPlugin = (__IntPtr)value;
            }
        }

        public __IntPtr TitanReleasePlugin
        {
            get
            {
                return ((__Internal*)__Instance)->TitanReleasePlugin;
            }

            set
            {
                ((__Internal*)__Instance)->TitanReleasePlugin = (__IntPtr)value;
            }
        }

        public __IntPtr TitanResetPlugin
        {
            get
            {
                return ((__Internal*)__Instance)->TitanResetPlugin;
            }

            set
            {
                ((__Internal*)__Instance)->TitanResetPlugin = (__IntPtr)value;
            }
        }

        public bool PluginDisabled
        {
            get
            {
                return ((__Internal*)__Instance)->PluginDisabled != 0;
            }

            set
            {
                ((__Internal*)__Instance)->PluginDisabled = (byte)(value ? 1 : 0);
            }
        }
    }

    public unsafe partial class HOOK_ENTRY : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 104, Pack = 1)]
        public partial struct __Internal
        {
            internal byte IATHook;
            internal byte HookType;
            internal uint HookSize;
            internal __IntPtr HookAddress;
            internal __IntPtr RedirectionAddress;
            internal fixed byte HookBytes[14];
            internal fixed byte OriginalBytes[14];
            internal __IntPtr IATHookModuleBase;
            internal uint IATHookNameHash;
            internal byte HookIsEnabled;
            internal byte HookIsRemote;
            internal __IntPtr PatchedEntry;
            internal fixed uint RelocationInfo[7];
            internal int RelocationCount;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0HOOK_ENTRY@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.HOOK_ENTRY> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.HOOK_ENTRY>();

        protected bool __ownsNativeInstance;

        internal static HOOK_ENTRY __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new HOOK_ENTRY(native.ToPointer(), skipVTables);
        }

        internal static HOOK_ENTRY __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (HOOK_ENTRY)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static HOOK_ENTRY __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new HOOK_ENTRY(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private HOOK_ENTRY(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected HOOK_ENTRY(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public HOOK_ENTRY()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.HOOK_ENTRY.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public HOOK_ENTRY(global::TitanEngine.NET.HOOK_ENTRY _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.HOOK_ENTRY.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.HOOK_ENTRY.__Internal*)__Instance) = *((global::TitanEngine.NET.HOOK_ENTRY.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public bool IATHook
        {
            get
            {
                return ((__Internal*)__Instance)->IATHook != 0;
            }

            set
            {
                ((__Internal*)__Instance)->IATHook = (byte)(value ? 1 : 0);
            }
        }

        public byte HookType
        {
            get
            {
                return ((__Internal*)__Instance)->HookType;
            }

            set
            {
                ((__Internal*)__Instance)->HookType = value;
            }
        }

        public uint HookSize
        {
            get
            {
                return ((__Internal*)__Instance)->HookSize;
            }

            set
            {
                ((__Internal*)__Instance)->HookSize = value;
            }
        }

        public __IntPtr HookAddress
        {
            get
            {
                return ((__Internal*)__Instance)->HookAddress;
            }

            set
            {
                ((__Internal*)__Instance)->HookAddress = (__IntPtr)value;
            }
        }

        public __IntPtr RedirectionAddress
        {
            get
            {
                return ((__Internal*)__Instance)->RedirectionAddress;
            }

            set
            {
                ((__Internal*)__Instance)->RedirectionAddress = (__IntPtr)value;
            }
        }

        public byte[] HookBytes
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->HookBytes, 14);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 14; i++)
                        ((__Internal*)__Instance)->HookBytes[i] = value[i];
                }
            }
        }

        public byte[] OriginalBytes
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->OriginalBytes, 14);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 14; i++)
                        ((__Internal*)__Instance)->OriginalBytes[i] = value[i];
                }
            }
        }

        public __IntPtr IATHookModuleBase
        {
            get
            {
                return ((__Internal*)__Instance)->IATHookModuleBase;
            }

            set
            {
                ((__Internal*)__Instance)->IATHookModuleBase = (__IntPtr)value;
            }
        }

        public uint IATHookNameHash
        {
            get
            {
                return ((__Internal*)__Instance)->IATHookNameHash;
            }

            set
            {
                ((__Internal*)__Instance)->IATHookNameHash = value;
            }
        }

        public bool HookIsEnabled
        {
            get
            {
                return ((__Internal*)__Instance)->HookIsEnabled != 0;
            }

            set
            {
                ((__Internal*)__Instance)->HookIsEnabled = (byte)(value ? 1 : 0);
            }
        }

        public bool HookIsRemote
        {
            get
            {
                return ((__Internal*)__Instance)->HookIsRemote != 0;
            }

            set
            {
                ((__Internal*)__Instance)->HookIsRemote = (byte)(value ? 1 : 0);
            }
        }

        public __IntPtr PatchedEntry
        {
            get
            {
                return ((__Internal*)__Instance)->PatchedEntry;
            }

            set
            {
                ((__Internal*)__Instance)->PatchedEntry = (__IntPtr)value;
            }
        }

        public uint[] RelocationInfo
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->RelocationInfo, 7);
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 7; i++)
                        ((__Internal*)__Instance)->RelocationInfo[i] = value[i];
                }
            }
        }

        public int RelocationCount
        {
            get
            {
                return ((__Internal*)__Instance)->RelocationCount;
            }

            set
            {
                ((__Internal*)__Instance)->RelocationCount = value;
            }
        }
    }

    public unsafe partial class FILE_STATUS_INFO : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 27, Pack = 1)]
        public partial struct __Internal
        {
            internal byte OveralEvaluation;
            internal byte EvaluationTerminatedByException;
            internal byte FileIs64Bit;
            internal byte FileIsDLL;
            internal byte FileIsConsole;
            internal byte MissingDependencies;
            internal byte MissingDeclaredAPIs;
            internal byte SignatureMZ;
            internal byte SignaturePE;
            internal byte EntryPoint;
            internal byte ImageBase;
            internal byte SizeOfImage;
            internal byte FileAlignment;
            internal byte SectionAlignment;
            internal byte ExportTable;
            internal byte RelocationTable;
            internal byte ImportTable;
            internal byte ImportTableSection;
            internal byte ImportTableData;
            internal byte IATTable;
            internal byte TLSTable;
            internal byte LoadConfigTable;
            internal byte BoundImportTable;
            internal byte COMHeaderTable;
            internal byte ResourceTable;
            internal byte ResourceData;
            internal byte SectionTable;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0FILE_STATUS_INFO@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.FILE_STATUS_INFO> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.FILE_STATUS_INFO>();

        protected bool __ownsNativeInstance;

        internal static FILE_STATUS_INFO __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new FILE_STATUS_INFO(native.ToPointer(), skipVTables);
        }

        internal static FILE_STATUS_INFO __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (FILE_STATUS_INFO)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static FILE_STATUS_INFO __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new FILE_STATUS_INFO(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FILE_STATUS_INFO(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FILE_STATUS_INFO(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public FILE_STATUS_INFO()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.FILE_STATUS_INFO.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FILE_STATUS_INFO(global::TitanEngine.NET.FILE_STATUS_INFO __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.FILE_STATUS_INFO.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.FILE_STATUS_INFO.__Internal*)__Instance) = *((global::TitanEngine.NET.FILE_STATUS_INFO.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte OveralEvaluation
        {
            get
            {
                return ((__Internal*)__Instance)->OveralEvaluation;
            }

            set
            {
                ((__Internal*)__Instance)->OveralEvaluation = value;
            }
        }

        public bool EvaluationTerminatedByException
        {
            get
            {
                return ((__Internal*)__Instance)->EvaluationTerminatedByException != 0;
            }

            set
            {
                ((__Internal*)__Instance)->EvaluationTerminatedByException = (byte)(value ? 1 : 0);
            }
        }

        public bool FileIs64Bit
        {
            get
            {
                return ((__Internal*)__Instance)->FileIs64Bit != 0;
            }

            set
            {
                ((__Internal*)__Instance)->FileIs64Bit = (byte)(value ? 1 : 0);
            }
        }

        public bool FileIsDLL
        {
            get
            {
                return ((__Internal*)__Instance)->FileIsDLL != 0;
            }

            set
            {
                ((__Internal*)__Instance)->FileIsDLL = (byte)(value ? 1 : 0);
            }
        }

        public bool FileIsConsole
        {
            get
            {
                return ((__Internal*)__Instance)->FileIsConsole != 0;
            }

            set
            {
                ((__Internal*)__Instance)->FileIsConsole = (byte)(value ? 1 : 0);
            }
        }

        public bool MissingDependencies
        {
            get
            {
                return ((__Internal*)__Instance)->MissingDependencies != 0;
            }

            set
            {
                ((__Internal*)__Instance)->MissingDependencies = (byte)(value ? 1 : 0);
            }
        }

        public bool MissingDeclaredAPIs
        {
            get
            {
                return ((__Internal*)__Instance)->MissingDeclaredAPIs != 0;
            }

            set
            {
                ((__Internal*)__Instance)->MissingDeclaredAPIs = (byte)(value ? 1 : 0);
            }
        }

        public byte SignatureMZ
        {
            get
            {
                return ((__Internal*)__Instance)->SignatureMZ;
            }

            set
            {
                ((__Internal*)__Instance)->SignatureMZ = value;
            }
        }

        public byte SignaturePE
        {
            get
            {
                return ((__Internal*)__Instance)->SignaturePE;
            }

            set
            {
                ((__Internal*)__Instance)->SignaturePE = value;
            }
        }

        public byte EntryPoint
        {
            get
            {
                return ((__Internal*)__Instance)->EntryPoint;
            }

            set
            {
                ((__Internal*)__Instance)->EntryPoint = value;
            }
        }

        public byte ImageBase
        {
            get
            {
                return ((__Internal*)__Instance)->ImageBase;
            }

            set
            {
                ((__Internal*)__Instance)->ImageBase = value;
            }
        }

        public byte SizeOfImage
        {
            get
            {
                return ((__Internal*)__Instance)->SizeOfImage;
            }

            set
            {
                ((__Internal*)__Instance)->SizeOfImage = value;
            }
        }

        public byte FileAlignment
        {
            get
            {
                return ((__Internal*)__Instance)->FileAlignment;
            }

            set
            {
                ((__Internal*)__Instance)->FileAlignment = value;
            }
        }

        public byte SectionAlignment
        {
            get
            {
                return ((__Internal*)__Instance)->SectionAlignment;
            }

            set
            {
                ((__Internal*)__Instance)->SectionAlignment = value;
            }
        }

        public byte ExportTable
        {
            get
            {
                return ((__Internal*)__Instance)->ExportTable;
            }

            set
            {
                ((__Internal*)__Instance)->ExportTable = value;
            }
        }

        public byte RelocationTable
        {
            get
            {
                return ((__Internal*)__Instance)->RelocationTable;
            }

            set
            {
                ((__Internal*)__Instance)->RelocationTable = value;
            }
        }

        public byte ImportTable
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTable;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTable = value;
            }
        }

        public byte ImportTableSection
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTableSection;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTableSection = value;
            }
        }

        public byte ImportTableData
        {
            get
            {
                return ((__Internal*)__Instance)->ImportTableData;
            }

            set
            {
                ((__Internal*)__Instance)->ImportTableData = value;
            }
        }

        public byte IATTable
        {
            get
            {
                return ((__Internal*)__Instance)->IATTable;
            }

            set
            {
                ((__Internal*)__Instance)->IATTable = value;
            }
        }

        public byte TLSTable
        {
            get
            {
                return ((__Internal*)__Instance)->TLSTable;
            }

            set
            {
                ((__Internal*)__Instance)->TLSTable = value;
            }
        }

        public byte LoadConfigTable
        {
            get
            {
                return ((__Internal*)__Instance)->LoadConfigTable;
            }

            set
            {
                ((__Internal*)__Instance)->LoadConfigTable = value;
            }
        }

        public byte BoundImportTable
        {
            get
            {
                return ((__Internal*)__Instance)->BoundImportTable;
            }

            set
            {
                ((__Internal*)__Instance)->BoundImportTable = value;
            }
        }

        public byte COMHeaderTable
        {
            get
            {
                return ((__Internal*)__Instance)->COMHeaderTable;
            }

            set
            {
                ((__Internal*)__Instance)->COMHeaderTable = value;
            }
        }

        public byte ResourceTable
        {
            get
            {
                return ((__Internal*)__Instance)->ResourceTable;
            }

            set
            {
                ((__Internal*)__Instance)->ResourceTable = value;
            }
        }

        public byte ResourceData
        {
            get
            {
                return ((__Internal*)__Instance)->ResourceData;
            }

            set
            {
                ((__Internal*)__Instance)->ResourceData = value;
            }
        }

        public byte SectionTable
        {
            get
            {
                return ((__Internal*)__Instance)->SectionTable;
            }

            set
            {
                ((__Internal*)__Instance)->SectionTable = value;
            }
        }
    }

    public unsafe partial class FILE_FIX_INFO : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 83, Pack = 1)]
        public partial struct __Internal
        {
            internal byte OveralEvaluation;
            internal byte FixingTerminatedByException;
            internal byte FileFixPerformed;
            internal byte StrippedRelocation;
            internal byte DontFixRelocations;
            internal uint OriginalRelocationTableAddress;
            internal uint OriginalRelocationTableSize;
            internal byte StrippedExports;
            internal byte DontFixExports;
            internal uint OriginalExportTableAddress;
            internal uint OriginalExportTableSize;
            internal byte StrippedResources;
            internal byte DontFixResources;
            internal uint OriginalResourceTableAddress;
            internal uint OriginalResourceTableSize;
            internal byte StrippedTLS;
            internal byte DontFixTLS;
            internal uint OriginalTLSTableAddress;
            internal uint OriginalTLSTableSize;
            internal byte StrippedLoadConfig;
            internal byte DontFixLoadConfig;
            internal uint OriginalLoadConfigTableAddress;
            internal uint OriginalLoadConfigTableSize;
            internal byte StrippedBoundImports;
            internal byte DontFixBoundImports;
            internal uint OriginalBoundImportTableAddress;
            internal uint OriginalBoundImportTableSize;
            internal byte StrippedIAT;
            internal byte DontFixIAT;
            internal uint OriginalImportAddressTableAddress;
            internal uint OriginalImportAddressTableSize;
            internal byte StrippedCOM;
            internal byte DontFixCOM;
            internal uint OriginalCOMTableAddress;
            internal uint OriginalCOMTableSize;

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "??0FILE_FIX_INFO@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr __0);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.FILE_FIX_INFO> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::TitanEngine.NET.FILE_FIX_INFO>();

        protected bool __ownsNativeInstance;

        internal static FILE_FIX_INFO __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new FILE_FIX_INFO(native.ToPointer(), skipVTables);
        }

        internal static FILE_FIX_INFO __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (FILE_FIX_INFO)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static FILE_FIX_INFO __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new FILE_FIX_INFO(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        private FILE_FIX_INFO(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected FILE_FIX_INFO(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public FILE_FIX_INFO()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.FILE_FIX_INFO.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public FILE_FIX_INFO(global::TitanEngine.NET.FILE_FIX_INFO __0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::TitanEngine.NET.TitanEngine.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::TitanEngine.NET.FILE_FIX_INFO.__Internal*)__Instance) = *((global::TitanEngine.NET.FILE_FIX_INFO.__Internal*)__0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte OveralEvaluation
        {
            get
            {
                return ((__Internal*)__Instance)->OveralEvaluation;
            }

            set
            {
                ((__Internal*)__Instance)->OveralEvaluation = value;
            }
        }

        public bool FixingTerminatedByException
        {
            get
            {
                return ((__Internal*)__Instance)->FixingTerminatedByException != 0;
            }

            set
            {
                ((__Internal*)__Instance)->FixingTerminatedByException = (byte)(value ? 1 : 0);
            }
        }

        public bool FileFixPerformed
        {
            get
            {
                return ((__Internal*)__Instance)->FileFixPerformed != 0;
            }

            set
            {
                ((__Internal*)__Instance)->FileFixPerformed = (byte)(value ? 1 : 0);
            }
        }

        public bool StrippedRelocation
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedRelocation != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedRelocation = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixRelocations
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixRelocations != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixRelocations = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalRelocationTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalRelocationTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalRelocationTableAddress = value;
            }
        }

        public uint OriginalRelocationTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalRelocationTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalRelocationTableSize = value;
            }
        }

        public bool StrippedExports
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedExports != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedExports = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixExports
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixExports != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixExports = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalExportTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalExportTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalExportTableAddress = value;
            }
        }

        public uint OriginalExportTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalExportTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalExportTableSize = value;
            }
        }

        public bool StrippedResources
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedResources != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedResources = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixResources
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixResources != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixResources = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalResourceTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalResourceTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalResourceTableAddress = value;
            }
        }

        public uint OriginalResourceTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalResourceTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalResourceTableSize = value;
            }
        }

        public bool StrippedTLS
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedTLS != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedTLS = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixTLS
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixTLS != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixTLS = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalTLSTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalTLSTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalTLSTableAddress = value;
            }
        }

        public uint OriginalTLSTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalTLSTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalTLSTableSize = value;
            }
        }

        public bool StrippedLoadConfig
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedLoadConfig != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedLoadConfig = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixLoadConfig
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixLoadConfig != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixLoadConfig = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalLoadConfigTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalLoadConfigTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalLoadConfigTableAddress = value;
            }
        }

        public uint OriginalLoadConfigTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalLoadConfigTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalLoadConfigTableSize = value;
            }
        }

        public bool StrippedBoundImports
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedBoundImports != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedBoundImports = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixBoundImports
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixBoundImports != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixBoundImports = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalBoundImportTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalBoundImportTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalBoundImportTableAddress = value;
            }
        }

        public uint OriginalBoundImportTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalBoundImportTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalBoundImportTableSize = value;
            }
        }

        public bool StrippedIAT
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedIAT != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedIAT = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixIAT
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixIAT != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixIAT = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalImportAddressTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalImportAddressTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalImportAddressTableAddress = value;
            }
        }

        public uint OriginalImportAddressTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalImportAddressTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalImportAddressTableSize = value;
            }
        }

        public bool StrippedCOM
        {
            get
            {
                return ((__Internal*)__Instance)->StrippedCOM != 0;
            }

            set
            {
                ((__Internal*)__Instance)->StrippedCOM = (byte)(value ? 1 : 0);
            }
        }

        public bool DontFixCOM
        {
            get
            {
                return ((__Internal*)__Instance)->DontFixCOM != 0;
            }

            set
            {
                ((__Internal*)__Instance)->DontFixCOM = (byte)(value ? 1 : 0);
            }
        }

        public uint OriginalCOMTableAddress
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalCOMTableAddress;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalCOMTableAddress = value;
            }
        }

        public uint OriginalCOMTableSize
        {
            get
            {
                return ((__Internal*)__Instance)->OriginalCOMTableSize;
            }

            set
            {
                ((__Internal*)__Instance)->OriginalCOMTableSize = value;
            }
        }
    }

    public unsafe partial class TitanEngine
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpProcess", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpProcess(__IntPtr hProcess, __IntPtr ImageBase, sbyte* szDumpFileName, ulong EntryPoint);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpProcessW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpProcessW(__IntPtr hProcess, __IntPtr ImageBase, char* szDumpFileName, ulong EntryPoint);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpProcessEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpProcessEx(uint ProcessId, __IntPtr ImageBase, sbyte* szDumpFileName, ulong EntryPoint);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpProcessExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpProcessExW(uint ProcessId, __IntPtr ImageBase, char* szDumpFileName, ulong EntryPoint);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpMemory", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpMemory(__IntPtr hProcess, __IntPtr MemoryStart, ulong MemorySize, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpMemoryW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpMemoryW(__IntPtr hProcess, __IntPtr MemoryStart, ulong MemorySize, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpMemoryEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpMemoryEx(uint ProcessId, __IntPtr MemoryStart, ulong MemorySize, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpMemoryExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpMemoryExW(uint ProcessId, __IntPtr MemoryStart, ulong MemorySize, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpRegions", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpRegions(__IntPtr hProcess, sbyte* szDumpFolder, bool DumpAboveImageBaseOnly);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpRegionsW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpRegionsW(__IntPtr hProcess, char* szDumpFolder, bool DumpAboveImageBaseOnly);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpRegionsEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpRegionsEx(uint ProcessId, sbyte* szDumpFolder, bool DumpAboveImageBaseOnly);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpRegionsExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpRegionsExW(uint ProcessId, char* szDumpFolder, bool DumpAboveImageBaseOnly);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpModule", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpModule(__IntPtr hProcess, __IntPtr ModuleBase, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpModuleW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpModuleW(__IntPtr hProcess, __IntPtr ModuleBase, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpModuleEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpModuleEx(uint ProcessId, __IntPtr ModuleBase, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DumpModuleExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DumpModuleExW(uint ProcessId, __IntPtr ModuleBase, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "PastePEHeader", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool PastePEHeader(__IntPtr hProcess, __IntPtr ImageBase, sbyte* szDebuggedFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "PastePEHeaderW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool PastePEHeaderW(__IntPtr hProcess, __IntPtr ImageBase, char* szDebuggedFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtractSection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtractSection(sbyte* szFileName, sbyte* szDumpFileName, uint SectionNumber);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtractSectionW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtractSectionW(char* szFileName, char* szDumpFileName, uint SectionNumber);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResortFileSections", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResortFileSections(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResortFileSectionsW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResortFileSectionsW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FindOverlay", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FindOverlay(sbyte* szFileName, uint* OverlayStart, uint* OverlaySize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FindOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FindOverlayW(char* szFileName, uint* OverlayStart, uint* OverlaySize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtractOverlay", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtractOverlay(sbyte* szFileName, sbyte* szExtractedFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtractOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtractOverlayW(char* szFileName, char* szExtractedFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AddOverlay", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool AddOverlay(sbyte* szFileName, sbyte* szOverlayFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AddOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool AddOverlayW(char* szFileName, char* szOverlayFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "CopyOverlay", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool CopyOverlay(sbyte* szInFileName, sbyte* szOutFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "CopyOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool CopyOverlayW(char* szInFileName, char* szOutFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoveOverlay", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoveOverlay(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoveOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoveOverlayW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "MakeAllSectionsRWE", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool MakeAllSectionsRWE(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "MakeAllSectionsRWEW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool MakeAllSectionsRWEW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AddNewSectionEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int AddNewSectionEx(sbyte* szFileName, sbyte* szSectionName, uint SectionSize, uint SectionAttributes, __IntPtr SectionContent, uint ContentSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AddNewSectionExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int AddNewSectionExW(char* szFileName, sbyte* szSectionName, uint SectionSize, uint SectionAttributes, __IntPtr SectionContent, uint ContentSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AddNewSection", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int AddNewSection(sbyte* szFileName, sbyte* szSectionName, uint SectionSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AddNewSectionW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int AddNewSectionW(char* szFileName, sbyte* szSectionName, uint SectionSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResizeLastSection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResizeLastSection(sbyte* szFileName, uint NumberOfExpandBytes, bool AlignResizeData);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResizeLastSectionW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResizeLastSectionW(char* szFileName, uint NumberOfExpandBytes, bool AlignResizeData);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetSharedOverlay", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetSharedOverlay(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetSharedOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetSharedOverlayW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetSharedOverlay", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern sbyte* GetSharedOverlay();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetSharedOverlayW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern char* GetSharedOverlayW();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteLastSection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteLastSection(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteLastSectionW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteLastSectionW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteLastSectionEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteLastSectionEx(sbyte* szFileName, uint NumberOfSections);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteLastSectionExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteLastSectionExW(char* szFileName, uint NumberOfSections);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32DataFromMappedFile", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetPE32DataFromMappedFile(ulong FileMapVA, uint WhichSection, uint WhichData);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32Data", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetPE32Data(sbyte* szFileName, uint WhichSection, uint WhichData);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32DataW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetPE32DataW([MarshalAs(UnmanagedType.LPWStr)] string szFileName, uint WhichSection, uint WhichData);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32DataFromMappedFileEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetPE32DataFromMappedFileEx(ulong FileMapVA, __IntPtr DataStorage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32DataEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetPE32DataEx(sbyte* szFileName, __IntPtr DataStorage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32DataExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetPE32DataExW(char* szFileName, __IntPtr DataStorage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetPE32DataForMappedFile", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetPE32DataForMappedFile(ulong FileMapVA, uint WhichSection, uint WhichData, ulong NewDataValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetPE32Data", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetPE32Data(sbyte* szFileName, uint WhichSection, uint WhichData, ulong NewDataValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetPE32DataW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetPE32DataW(char* szFileName, uint WhichSection, uint WhichData, ulong NewDataValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetPE32DataForMappedFileEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetPE32DataForMappedFileEx(ulong FileMapVA, __IntPtr DataStorage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetPE32DataEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetPE32DataEx(sbyte* szFileName, __IntPtr DataStorage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetPE32DataExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetPE32DataExW(char* szFileName, __IntPtr DataStorage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPE32SectionNumberFromVA", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetPE32SectionNumberFromVA(ulong FileMapVA, ulong AddressToConvert);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ConvertVAtoFileOffset", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ConvertVAtoFileOffset(ulong FileMapVA, ulong AddressToConvert, bool ReturnType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ConvertVAtoFileOffsetEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ConvertVAtoFileOffsetEx(ulong FileMapVA, uint FileSize, ulong ImageBase, ulong AddressToConvert, bool AddressIsRVA, bool ReturnType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ConvertFileOffsetToVA", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ConvertFileOffsetToVA(ulong FileMapVA, ulong AddressToConvert, bool ReturnType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ConvertFileOffsetToVAEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ConvertFileOffsetToVAEx(ulong FileMapVA, uint FileSize, ulong ImageBase, ulong AddressToConvert, bool ReturnType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "MemoryReadSafe", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool MemoryReadSafe(__IntPtr hProcess, __IntPtr lpBaseAddress, __IntPtr lpBuffer, ulong nSize, ulong* lpNumberOfBytesRead);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "MemoryWriteSafe", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool MemoryWriteSafe(__IntPtr hProcess, __IntPtr lpBaseAddress, __IntPtr lpBuffer, ulong nSize, ulong* lpNumberOfBytesWritten);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FixHeaderCheckSum", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FixHeaderCheckSum(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FixHeaderCheckSumW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FixHeaderCheckSumW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RealignPE", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int RealignPE(ulong FileMapVA, uint FileSize, uint RealingMode);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RealignPEEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int RealignPEEx(sbyte* szFileName, uint RealingFileSize, uint ForcedFileAlignment);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RealignPEExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int RealignPEExW(char* szFileName, uint RealingFileSize, uint ForcedFileAlignment);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "WipeSection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool WipeSection(sbyte* szFileName, int WipeSectionNumber, bool RemovePhysically);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "WipeSectionW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool WipeSectionW(char* szFileName, int WipeSectionNumber, bool RemovePhysically);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsPE32FileValidEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsPE32FileValidEx(sbyte* szFileName, uint CheckDepth, __IntPtr FileStatusInfo);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsPE32FileValidExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsPE32FileValidExW(char* szFileName, uint CheckDepth, __IntPtr FileStatusInfo);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FixBrokenPE32FileEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FixBrokenPE32FileEx(sbyte* szFileName, __IntPtr FileStatusInfo, __IntPtr FileFixInfo);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FixBrokenPE32FileExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FixBrokenPE32FileExW(char* szFileName, __IntPtr FileStatusInfo, __IntPtr FileFixInfo);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsFileDLL", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsFileDLL(sbyte* szFileName, ulong FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsFileDLLW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsFileDLLW(char* szFileName, ulong FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPEBLocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetPEBLocation(__IntPtr hProcess);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetPEBLocation64", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetPEBLocation64(__IntPtr hProcess);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetTEBLocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetTEBLocation(__IntPtr hThread);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetTEBLocation64", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetTEBLocation64(__IntPtr hThread);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HideDebugger", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HideDebugger(__IntPtr hProcess, uint PatchAPILevel);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "UnHideDebugger", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool UnHideDebugger(__IntPtr hProcess, uint PatchAPILevel);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterCleanup", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void RelocaterCleanup();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterInit", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void RelocaterInit(uint MemorySize, ulong OldImageBase, ulong NewImageBase);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterAddNewRelocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void RelocaterAddNewRelocation(__IntPtr hProcess, ulong RelocateAddress, uint RelocateState);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterEstimatedSize", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int RelocaterEstimatedSize();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterExportRelocation", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterExportRelocation(ulong StorePlace, uint StorePlaceRVA, ulong FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterExportRelocationEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterExportRelocationEx(sbyte* szFileName, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterExportRelocationExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterExportRelocationExW(char* szFileName, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterGrabRelocationTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterGrabRelocationTable(__IntPtr hProcess, ulong MemoryStart, uint MemorySize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterGrabRelocationTableEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterGrabRelocationTableEx(__IntPtr hProcess, ulong MemoryStart, ulong MemorySize, uint NtSizeOfImage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterMakeSnapshot", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterMakeSnapshot(__IntPtr hProcess, sbyte* szSaveFileName, __IntPtr MemoryStart, ulong MemorySize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterMakeSnapshotW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterMakeSnapshotW(__IntPtr hProcess, char* szSaveFileName, __IntPtr MemoryStart, ulong MemorySize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterCompareTwoSnapshots", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterCompareTwoSnapshots(__IntPtr hProcess, ulong LoadedImageBase, ulong NtSizeOfImage, sbyte* szDumpFile1, sbyte* szDumpFile2, ulong MemStart);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterCompareTwoSnapshotsW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterCompareTwoSnapshotsW(__IntPtr hProcess, ulong LoadedImageBase, ulong NtSizeOfImage, char* szDumpFile1, char* szDumpFile2, ulong MemStart);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterChangeFileBase", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterChangeFileBase(sbyte* szFileName, ulong NewImageBase);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterChangeFileBaseW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterChangeFileBaseW(char* szFileName, ulong NewImageBase);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterRelocateMemoryBlock", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterRelocateMemoryBlock(ulong FileMapVA, ulong MemoryLocation, __IntPtr RelocateMemory, uint RelocateMemorySize, ulong CurrentLoadedBase, ulong RelocateBase);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterWipeRelocationTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterWipeRelocationTable(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RelocaterWipeRelocationTableW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RelocaterWipeRelocationTableW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerLoadFileForResourceUse", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ResourcerLoadFileForResourceUse(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerLoadFileForResourceUseW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ResourcerLoadFileForResourceUseW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerFreeLoadedFile", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResourcerFreeLoadedFile(__IntPtr LoadedFileBase);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerExtractResourceFromFile", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResourcerExtractResourceFromFile(sbyte* szFileName, sbyte* szResourceType, sbyte* szResourceName, sbyte* szExtractedFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerExtractResourceFromFileW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResourcerExtractResourceFromFileW(char* szFileName, sbyte* szResourceType, sbyte* szResourceName, sbyte* szExtractedFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerFindResource", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResourcerFindResource(sbyte* szFileName, sbyte* szResourceType, uint ResourceType, sbyte* szResourceName, uint ResourceName, uint ResourceLanguage, ulong* pResourceData, uint* pResourceSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerFindResourceW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResourcerFindResourceW(char* szFileName, char* szResourceType, uint ResourceType, char* szResourceName, uint ResourceName, uint ResourceLanguage, ulong* pResourceData, uint* pResourceSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerFindResourceEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ResourcerFindResourceEx(ulong FileMapVA, uint FileSize, char* szResourceType, uint ResourceType, char* szResourceName, uint ResourceName, uint ResourceLanguage, ulong* pResourceData, uint* pResourceSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerEnumerateResource", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ResourcerEnumerateResource(sbyte* szFileName, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerEnumerateResourceW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ResourcerEnumerateResourceW(char* szFileName, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ResourcerEnumerateResourceEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ResourcerEnumerateResourceEx(ulong FileMapVA, uint FileSize, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderImportRunningThreadData", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderImportRunningThreadData(uint ProcessId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderGetThreadInfo", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ThreaderGetThreadInfo(__IntPtr hThread, uint ThreadId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderEnumThreadInfo", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ThreaderEnumThreadInfo(__IntPtr EnumCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderPauseThread", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderPauseThread(__IntPtr hThread);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderResumeThread", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderResumeThread(__IntPtr hThread);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderTerminateThread", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderTerminateThread(__IntPtr hThread, uint ThreadExitCode);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderPauseAllThreads", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderPauseAllThreads(bool LeaveMainRunning);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderResumeAllThreads", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderResumeAllThreads(bool LeaveMainPaused);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderPauseProcess", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderPauseProcess();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderResumeProcess", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderResumeProcess();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderCreateRemoteThread", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ThreaderCreateRemoteThread(ulong ThreadStartAddress, bool AutoCloseTheHandle, __IntPtr ThreadPassParameter, uint* ThreadId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderInjectAndExecuteCode", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderInjectAndExecuteCode(__IntPtr InjectCode, uint StartDelta, uint InjectSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderCreateRemoteThreadEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ThreaderCreateRemoteThreadEx(__IntPtr hProcess, ulong ThreadStartAddress, bool AutoCloseTheHandle, __IntPtr ThreadPassParameter, uint* ThreadId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderInjectAndExecuteCodeEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderInjectAndExecuteCodeEx(__IntPtr hProcess, __IntPtr InjectCode, uint StartDelta, uint InjectSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderSetCallBackForNextExitThreadEvent", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ThreaderSetCallBackForNextExitThreadEvent(__IntPtr exitThreadCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderIsThreadStillRunning", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderIsThreadStillRunning(__IntPtr hThread);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderIsThreadActive", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderIsThreadActive(__IntPtr hThread);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderIsAnyThreadActive", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderIsAnyThreadActive();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderExecuteOnlyInjectedThreads", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderExecuteOnlyInjectedThreads();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderGetOpenHandleForThread", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ThreaderGetOpenHandleForThread(uint ThreadId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ThreaderIsExceptionInMainThread", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ThreaderIsExceptionInMainThread();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticDisassembleEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr StaticDisassembleEx(ulong DisassmStart, __IntPtr DisassmAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticDisassemble", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr StaticDisassemble(__IntPtr DisassmAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DisassembleEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr DisassembleEx(__IntPtr hProcess, __IntPtr DisassmAddress, bool ReturnInstructionType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "Disassemble", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr Disassemble(__IntPtr DisassmAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticLengthDisassemble", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int StaticLengthDisassemble(__IntPtr DisassmAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LengthDisassembleEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LengthDisassembleEx(__IntPtr hProcess, __IntPtr DisassmAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LengthDisassemble", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int LengthDisassemble(__IntPtr DisassmAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitDebug", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitDebug(sbyte* szFileName, sbyte* szCommandLine, sbyte* szCurrentFolder);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitDebugW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitDebugW(char* szFileName, char* szCommandLine, char* szCurrentFolder);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitNativeDebug", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitNativeDebug(sbyte* szFileName, sbyte* szCommandLine, sbyte* szCurrentFolder);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitNativeDebugW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitNativeDebugW(char* szFileName, char* szCommandLine, char* szCurrentFolder);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitDebugEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitDebugEx(sbyte* szFileName, sbyte* szCommandLine, sbyte* szCurrentFolder, __IntPtr EntryCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitDebugExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitDebugExW(char* szFileName, char* szCommandLine, char* szCurrentFolder, __IntPtr EntryCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitDLLDebug", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitDLLDebug(sbyte* szFileName, bool ReserveModuleBase, sbyte* szCommandLine, sbyte* szCurrentFolder, __IntPtr EntryCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "InitDLLDebugW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr InitDLLDebugW(char* szFileName, bool ReserveModuleBase, char* szCommandLine, char* szCurrentFolder, __IntPtr EntryCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StopDebug", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StopDebug();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetBPXOptions", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetBPXOptions(int DefaultBreakPointType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsBPXEnabled", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsBPXEnabled(ulong bpxAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EnableBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EnableBPX(ulong bpxAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DisableBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DisableBPX(ulong bpxAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetBPX(ulong bpxAddress, uint bpxType, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteBPX(ulong bpxAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SafeDeleteBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SafeDeleteBPX(ulong bpxAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetAPIBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetAPIBreakPoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szDLLName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szAPIName, uint bpxType, uint bpxPlace, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteAPIBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteAPIBreakPoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szDLLName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szAPIName, uint bpxPlace);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SafeDeleteAPIBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SafeDeleteAPIBreakPoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szDLLName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szAPIName, uint bpxPlace);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetMemoryBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetMemoryBPX(ulong MemoryStart, ulong SizeOfMemory, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetMemoryBPXEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetMemoryBPXEx(ulong MemoryStart, ulong SizeOfMemory, uint BreakPointType, bool RestoreOnHit, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoveMemoryBPX", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoveMemoryBPX(ulong MemoryStart, ulong SizeOfMemory);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetContextFPUDataEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetContextFPUDataEx(__IntPtr hActiveThread, __IntPtr FPUSaveArea);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetContextDataEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetContextDataEx(__IntPtr hActiveThread, uint IndexOfRegister);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetContextData", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetContextData(uint IndexOfRegister);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetContextFPUDataEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetContextFPUDataEx(__IntPtr hActiveThread, __IntPtr FPUSaveArea);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetContextDataEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetContextDataEx(__IntPtr hActiveThread, uint IndexOfRegister, ulong NewRegisterValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetContextData", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetContextData(uint IndexOfRegister, ulong NewRegisterValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ClearExceptionNumber", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ClearExceptionNumber();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "CurrentExceptionNumber", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int CurrentExceptionNumber();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "MatchPatternEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool MatchPatternEx(__IntPtr hProcess, __IntPtr MemoryToCheck, int SizeOfMemoryToCheck, __IntPtr PatternToMatch, int SizeOfPatternToMatch, byte* WildCard);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "MatchPattern", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool MatchPattern(__IntPtr MemoryToCheck, int SizeOfMemoryToCheck, __IntPtr PatternToMatch, int SizeOfPatternToMatch, byte* WildCard);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FindEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong FindEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, byte* WildCard);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "Find", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong Find(__IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, byte* WildCard);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FillEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FillEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, byte* FillByte);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "Fill", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool Fill(__IntPtr MemoryStart, uint MemorySize, byte* FillByte);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "PatchEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool PatchEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, __IntPtr ReplacePattern, uint ReplaceSize, bool AppendNOP, bool PrependNOP);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "Patch", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool Patch(__IntPtr MemoryStart, uint MemorySize, __IntPtr ReplacePattern, uint ReplaceSize, bool AppendNOP, bool PrependNOP);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ReplaceEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ReplaceEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, uint NumberOfRepetitions, __IntPtr ReplacePattern, uint ReplaceSize, byte* WildCard);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "Replace", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool Replace(__IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, uint NumberOfRepetitions, __IntPtr ReplacePattern, uint ReplaceSize, byte* WildCard);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetDebugData", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetDebugData();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetTerminationData", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetTerminationData();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetExitCode", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetExitCode();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetDebuggedDLLBaseAddress", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetDebuggedDLLBaseAddress();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetDebuggedFileBaseAddress", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetDebuggedFileBaseAddress();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetRemoteString", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetRemoteString(__IntPtr hProcess, __IntPtr StringAddress, __IntPtr StringStorage, int MaximumStringSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetFunctionParameter", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetFunctionParameter(__IntPtr hProcess, uint FunctionType, uint ParameterNumber, uint ParameterType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetJumpDestinationEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetJumpDestinationEx(__IntPtr hProcess, ulong InstructionAddress, bool JustJumps);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetJumpDestination", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong GetJumpDestination(__IntPtr hProcess, ulong InstructionAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsJumpGoingToExecuteEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsJumpGoingToExecuteEx(__IntPtr hProcess, __IntPtr hThread, ulong InstructionAddress, ulong RegFlags);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsJumpGoingToExecute", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsJumpGoingToExecute();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetCustomHandler", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetCustomHandler(uint ExceptionId, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ForceClose", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ForceClose();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StepInto", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StepInto(__IntPtr traceCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StepOver", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StepOver(__IntPtr traceCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StepOut", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StepOut(__IntPtr StepOut, bool StepFinal);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SingleStep", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SingleStep(uint StepCount, __IntPtr StepCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetUnusedHardwareBreakPointRegister", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool GetUnusedHardwareBreakPointRegister(uint* RegisterIndex);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetHardwareBreakPointEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetHardwareBreakPointEx(__IntPtr hActiveThread, ulong bpxAddress, uint IndexOfRegister, uint bpxType, uint bpxSize, __IntPtr bpxCallBack, uint* IndexOfSelectedRegister);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetHardwareBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool SetHardwareBreakPoint(ulong bpxAddress, uint IndexOfRegister, uint bpxType, uint bpxSize, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DeleteHardwareBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DeleteHardwareBreakPoint(uint IndexOfRegister);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoveAllBreakPoints", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoveAllBreakPoints(uint RemoveOption);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DebugLoop", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void DebugLoop();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetDebugLoopTimeOut", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetDebugLoopTimeOut(uint TimeOut);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetNextDbgContinueStatus", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetNextDbgContinueStatus(uint SetDbgCode);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AttachDebugger", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool AttachDebugger(uint ProcessId, bool KillOnExit, __IntPtr DebugInfo, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DetachDebugger", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DetachDebugger(uint ProcessId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DetachDebuggerEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool DetachDebuggerEx(uint ProcessId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "DebugLoopEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void DebugLoopEx(uint TimeOut);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AutoDebugEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void AutoDebugEx(sbyte* szFileName, bool ReserveModuleBase, sbyte* szCommandLine, sbyte* szCurrentFolder, uint TimeOut, __IntPtr EntryCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "AutoDebugExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void AutoDebugExW(char* szFileName, bool ReserveModuleBase, char* szCommandLine, char* szCurrentFolder, uint TimeOut, __IntPtr EntryCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "IsFileBeingDebugged", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool IsFileBeingDebugged();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetErrorModel", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetErrorModel(bool DisplayErrorMessages);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FindOEPInit", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void FindOEPInit();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FindOEPGenerically", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FindOEPGenerically(sbyte* szFileName, __IntPtr TraceInitCallBack, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "FindOEPGenericallyW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool FindOEPGenericallyW(char* szFileName, __IntPtr TraceInitCallBack, __IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAddNewDll", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterAddNewDll(sbyte* szDLLName, ulong FirstThunk);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAddNewAPI", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterAddNewAPI(sbyte* szAPIName, ulong ThunkValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAddNewOrdinalAPI", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterAddNewOrdinalAPI(ulong OrdinalNumber, ulong ThunkValue);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAddedDllCount", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterGetAddedDllCount();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAddedAPICount", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterGetAddedAPICount();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterExportIAT", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterExportIAT(ulong StorePlace, ulong FileMapVA, __IntPtr hFileMap);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterEstimatedSize", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterEstimatedSize();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterExportIATEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterExportIATEx(sbyte* szDumpFileName, sbyte* szExportFileName, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterExportIATExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterExportIATExW(char* szDumpFileName, char* szExportFileName, char* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterFindAPIWriteLocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterFindAPIWriteLocation(sbyte* szAPIName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterFindOrdinalAPIWriteLocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterFindOrdinalAPIWriteLocation(ulong OrdinalNumber);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterFindAPIByWriteLocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterFindAPIByWriteLocation(ulong APIWriteLocation);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterFindDLLByWriteLocation", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterFindDLLByWriteLocation(ulong APIWriteLocation);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetDLLName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetDLLName(ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetDLLNameW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetDLLNameW(ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAPIName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetAPIName(ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAPIOrdinalNumber", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetAPIOrdinalNumber(ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAPINameEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetAPINameEx(ulong APIAddress, ulong DLLBasesList);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetRemoteAPIAddress", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetRemoteAPIAddress(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetRemoteAPIAddressEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetRemoteAPIAddressEx(sbyte* szDLLName, sbyte* szAPIName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetLocalAPIAddress", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetLocalAPIAddress(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetDLLNameFromDebugee", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetDLLNameFromDebugee(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetDLLNameFromDebugeeW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetDLLNameFromDebugeeW(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAPINameFromDebugee", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetAPINameFromDebugee(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetAPIOrdinalNumberFromDebugee", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetAPIOrdinalNumberFromDebugee(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetDLLIndexEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterGetDLLIndexEx(ulong APIAddress, ulong DLLBasesList);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetDLLIndex", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterGetDLLIndex(__IntPtr hProcess, ulong APIAddress, ulong DLLBasesList);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetRemoteDLLBaseEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetRemoteDLLBaseEx(__IntPtr hProcess, sbyte* szModuleName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetRemoteDLLBaseExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetRemoteDLLBaseExW(__IntPtr hProcess, char* szModuleName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterIsForwardedAPI", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterIsForwardedAPI(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetForwardedAPIName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetForwardedAPIName(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetForwardedDLLName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetForwardedDLLName(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetForwardedDLLIndex", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterGetForwardedDLLIndex(__IntPtr hProcess, ulong APIAddress, ulong DLLBasesList);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetForwardedAPIOrdinalNumber", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetForwardedAPIOrdinalNumber(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetNearestAPIAddress", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong ImporterGetNearestAPIAddress(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterGetNearestAPIName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ImporterGetNearestAPIName(__IntPtr hProcess, ulong APIAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterCopyOriginalIAT", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterCopyOriginalIAT(sbyte* szOriginalFile, sbyte* szDumpFile);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterCopyOriginalIATW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterCopyOriginalIATW(char* szOriginalFile, char* szDumpFile);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterLoadImportTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterLoadImportTable(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterLoadImportTableW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterLoadImportTableW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterMoveOriginalIAT", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterMoveOriginalIAT(sbyte* szOriginalFile, sbyte* szDumpFile, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterMoveOriginalIATW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterMoveOriginalIATW(char* szOriginalFile, char* szDumpFile, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoSearchIAT", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterAutoSearchIAT(uint ProcessId, sbyte* szFileName, ulong SearchStart, __IntPtr pIATStart, __IntPtr pIATSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoSearchIATW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterAutoSearchIATW(uint ProcessIds, char* szFileName, ulong SearchStart, __IntPtr pIATStart, __IntPtr pIATSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoSearchIATEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterAutoSearchIATEx(uint ProcessId, ulong ImageBase, ulong SearchStart, __IntPtr pIATStart, __IntPtr pIATSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterEnumAddedData", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ImporterEnumAddedData(__IntPtr EnumCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoFixIATEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterAutoFixIATEx(uint ProcessId, sbyte* szDumpedFile, sbyte* szSectionName, bool DumpRunningProcess, bool RealignFile, ulong EntryPointAddress, ulong ImageBase, ulong SearchStart, bool TryAutoFix, bool FixEliminations, __IntPtr UnknownPointerFixCallback);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoFixIATExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterAutoFixIATExW(uint ProcessId, char* szDumpedFile, sbyte* szSectionName, bool DumpRunningProcess, bool RealignFile, ulong EntryPointAddress, ulong ImageBase, ulong SearchStart, bool TryAutoFix, bool FixEliminations, __IntPtr UnknownPointerFixCallback);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoFixIAT", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterAutoFixIAT(uint ProcessId, sbyte* szDumpedFile, ulong SearchStart);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterAutoFixIATW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ImporterAutoFixIATW(uint ProcessId, char* szDumpedFile, ulong SearchStart);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ImporterDeleteAPI", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ImporterDeleteAPI(ulong apiAddr);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksSafeTransitionEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksSafeTransitionEx(__IntPtr HookAddressArray, int NumberOfHooks, bool TransitionStart);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksSafeTransition", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksSafeTransition(__IntPtr HookAddress, bool TransitionStart);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksIsAddressRedirected", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksIsAddressRedirected(__IntPtr HookAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksGetTrampolineAddress", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr HooksGetTrampolineAddress(__IntPtr HookAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksGetHookEntryDetails", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr HooksGetHookEntryDetails(__IntPtr HookAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksInsertNewRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksInsertNewRedirection(__IntPtr HookAddress, __IntPtr RedirectTo, int HookType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksInsertNewIATRedirectionEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksInsertNewIATRedirectionEx(ulong FileMapVA, ulong LoadedModuleBase, sbyte* szHookFunction, __IntPtr RedirectTo);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksInsertNewIATRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksInsertNewIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, __IntPtr RedirectTo);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksRemoveRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksRemoveRedirection(__IntPtr HookAddress, bool RemoveAll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksRemoveIATRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksRemoveIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, bool RemoveAll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksDisableRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksDisableRedirection(__IntPtr HookAddress, bool DisableAll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksDisableIATRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksDisableIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, bool DisableAll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksEnableRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksEnableRedirection(__IntPtr HookAddress, bool EnableAll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksEnableIATRedirection", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HooksEnableIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, bool EnableAll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksScanEntireProcessMemory", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void HooksScanEntireProcessMemory(__IntPtr CallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HooksScanEntireProcessMemoryEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void HooksScanEntireProcessMemoryEx();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TracerInit", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void TracerInit();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TracerLevel1", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong TracerLevel1(__IntPtr hProcess, ulong AddressToTrace);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HashTracerLevel1", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong HashTracerLevel1(__IntPtr hProcess, ulong AddressToTrace, uint InputNumberOfInstructions);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TracerDetectRedirection", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int TracerDetectRedirection(__IntPtr hProcess, ulong AddressToTrace);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TracerFixKnownRedirection", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong TracerFixKnownRedirection(__IntPtr hProcess, ulong AddressToTrace, uint RedirectionId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TracerFixRedirectionViaImpRecPlugin", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int TracerFixRedirectionViaImpRecPlugin(__IntPtr hProcess, sbyte* szPluginName, ulong AddressToTrace);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterCleanup", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ExporterCleanup();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterSetImageBase", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ExporterSetImageBase(ulong ImageBase);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterInit", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ExporterInit(uint MemorySize, ulong ImageBase, uint ExportOrdinalBase, sbyte* szExportModuleName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterAddNewExport", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterAddNewExport(sbyte* szExportName, uint ExportRelativeAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterAddNewOrdinalExport", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterAddNewOrdinalExport(uint OrdinalNumber, uint ExportRelativeAddress);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterGetAddedExportCount", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ExporterGetAddedExportCount();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterEstimatedSize", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int ExporterEstimatedSize();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterBuildExportTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterBuildExportTable(ulong StorePlace, ulong FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterBuildExportTableEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterBuildExportTableEx(sbyte* szExportFileName, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterBuildExportTableExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterBuildExportTableExW(char* szExportFileName, sbyte* szSectionName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterLoadExportTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterLoadExportTable(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExporterLoadExportTableW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExporterLoadExportTableW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianSetBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibrarianSetBreakPoint(sbyte* szLibraryName, uint bpxType, bool SingleShoot, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianRemoveBreakPoint", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool LibrarianRemoveBreakPoint(sbyte* szLibraryName, uint bpxType);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianGetLibraryInfo", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr LibrarianGetLibraryInfo(sbyte* szLibraryName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianGetLibraryInfoW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr LibrarianGetLibraryInfoW(char* szLibraryName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianGetLibraryInfoEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr LibrarianGetLibraryInfoEx(__IntPtr BaseOfDll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianGetLibraryInfoExW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr LibrarianGetLibraryInfoExW(__IntPtr BaseOfDll);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianEnumLibraryInfo", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void LibrarianEnumLibraryInfo(__IntPtr EnumCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "LibrarianEnumLibraryInfoW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void LibrarianEnumLibraryInfoW(__IntPtr EnumCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetActiveProcessId", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetActiveProcessId(sbyte* szImageName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "GetActiveProcessIdW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetActiveProcessIdW(char* szImageName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EnumProcessesWithLibrary", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void EnumProcessesWithLibrary(sbyte* szLibraryName, __IntPtr EnumFunction);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TitanOpenProcess", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr TitanOpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TitanOpenThread", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr TitanOpenThread(uint dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBreakOnCallBack", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBreakOnCallBack(__IntPtr ArrayOfCallBacks, uint NumberOfCallBacks, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSGrabCallBackData", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSGrabCallBackData(sbyte* szFileName, __IntPtr ArrayOfCallBacks, uint* NumberOfCallBacks);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSGrabCallBackDataW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSGrabCallBackDataW(char* szFileName, __IntPtr ArrayOfCallBacks, uint* NumberOfCallBacks);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBreakOnCallBackEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBreakOnCallBackEx(sbyte* szFileName, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBreakOnCallBackExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBreakOnCallBackExW(char* szFileName, __IntPtr bpxCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSRemoveCallback", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSRemoveCallback(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSRemoveCallbackW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSRemoveCallbackW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSRemoveTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSRemoveTable(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSRemoveTableW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSRemoveTableW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBackupData", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBackupData(sbyte* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBackupDataW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBackupDataW(char* szFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSRestoreData", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSRestoreData();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBuildNewTable", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBuildNewTable(ulong FileMapVA, ulong StorePlace, ulong StorePlaceRVA, __IntPtr ArrayOfCallBacks, uint NumberOfCallBacks);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBuildNewTableEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBuildNewTableEx(sbyte* szFileName, sbyte* szSectionName, __IntPtr ArrayOfCallBacks, uint NumberOfCallBacks);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TLSBuildNewTableExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool TLSBuildNewTableExW(char* szFileName, sbyte* szSectionName, __IntPtr ArrayOfCallBacks, uint NumberOfCallBacks);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TranslateNativeName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr TranslateNativeName(sbyte* szNativeName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "TranslateNativeNameW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr TranslateNativeNameW(char* szNativeName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetActiveHandleCount", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerGetActiveHandleCount(uint ProcessId);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerIsHandleOpen", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HandlerIsHandleOpen(uint ProcessId, __IntPtr hHandle);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetHandleName", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr HandlerGetHandleName(__IntPtr hProcess, uint ProcessId, __IntPtr hHandle, bool TranslateName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetHandleNameW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr HandlerGetHandleNameW(__IntPtr hProcess, uint ProcessId, __IntPtr hHandle, bool TranslateName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerEnumerateOpenHandles", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerEnumerateOpenHandles(uint ProcessId, __IntPtr HandleBuffer, uint MaxHandleCount);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetHandleDetails", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong HandlerGetHandleDetails(__IntPtr hProcess, uint ProcessId, __IntPtr hHandle, uint InformationReturn);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerCloseRemoteHandle", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HandlerCloseRemoteHandle(__IntPtr hProcess, __IntPtr hHandle);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerEnumerateLockHandles", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerEnumerateLockHandles(sbyte* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated, __IntPtr HandleDataBuffer, uint MaxHandleCount);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerEnumerateLockHandlesW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerEnumerateLockHandlesW(char* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated, __IntPtr HandleDataBuffer, uint MaxHandleCount);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerCloseAllLockHandles", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HandlerCloseAllLockHandles(sbyte* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerCloseAllLockHandlesW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HandlerCloseAllLockHandlesW(char* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerIsFileLocked", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HandlerIsFileLocked(sbyte* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerIsFileLockedW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool HandlerIsFileLockedW(char* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerEnumerateOpenMutexes", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerEnumerateOpenMutexes(__IntPtr hProcess, uint ProcessId, __IntPtr HandleBuffer, uint MaxHandleCount);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetOpenMutexHandle", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong HandlerGetOpenMutexHandle(__IntPtr hProcess, uint ProcessId, sbyte* szMutexString);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetOpenMutexHandleW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern ulong HandlerGetOpenMutexHandleW(__IntPtr hProcess, uint ProcessId, char* szMutexString);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetProcessIdWhichCreatedMutex", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerGetProcessIdWhichCreatedMutex(sbyte* szMutexString);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "HandlerGetProcessIdWhichCreatedMutexW", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int HandlerGetProcessIdWhichCreatedMutexW(char* szMutexString);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoteLoadLibrary", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoteLoadLibrary(__IntPtr hProcess, sbyte* szLibraryFile, bool WaitForThreadExit);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoteLoadLibraryW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoteLoadLibraryW(__IntPtr hProcess, char* szLibraryFile, bool WaitForThreadExit);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "RemoteExitProcess", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool RemoteExitProcess(__IntPtr hProcess, uint ExitCode);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileLoad", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileLoad(sbyte* szFileName, uint DesiredAccess, bool SimulateLoad, __IntPtr* FileHandle, uint* LoadedSize, __IntPtr* FileMap, ulong* FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileLoadW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileLoadW(char* szFileName, uint DesiredAccess, bool SimulateLoad, __IntPtr* FileHandle, uint* LoadedSize, __IntPtr* FileMap, ulong* FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileUnload", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileUnload(sbyte* szFileName, bool CommitChanges, __IntPtr FileHandle, uint LoadedSize, __IntPtr FileMap, ulong FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileUnloadW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileUnloadW(char* szFileName, bool CommitChanges, __IntPtr FileHandle, uint LoadedSize, __IntPtr FileMap, ulong FileMapVA);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileOpen", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileOpen(sbyte* szFileName, uint DesiredAccess, __IntPtr* FileHandle, uint* FileSizeLow, uint* FileSizeHigh);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileOpenW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileOpenW(char* szFileName, uint DesiredAccess, __IntPtr* FileHandle, uint* FileSizeLow, uint* FileSizeHigh);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileGetContent", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticFileGetContent(__IntPtr FileHandle, uint FilePositionLow, uint* FilePositionHigh, __IntPtr Buffer, uint Size);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticFileClose", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StaticFileClose(__IntPtr FileHandle);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticMemoryDecrypt", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StaticMemoryDecrypt(__IntPtr MemoryStart, uint MemorySize, uint DecryptionType, uint DecryptionKeySize, ulong DecryptionKey);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticMemoryDecryptEx", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StaticMemoryDecryptEx(__IntPtr MemoryStart, uint MemorySize, uint DecryptionKeySize, __IntPtr DecryptionCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticMemoryDecryptSpecial", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StaticMemoryDecryptSpecial(__IntPtr MemoryStart, uint MemorySize, uint DecryptionKeySize, uint SpecDecryptionType, __IntPtr DecryptionCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticSectionDecrypt", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void StaticSectionDecrypt(ulong FileMapVA, uint SectionNumber, bool SimulateLoad, uint DecryptionType, uint DecryptionKeySize, ulong DecryptionKey);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticMemoryDecompress", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticMemoryDecompress(__IntPtr Source, uint SourceSize, __IntPtr Destination, uint DestinationSize, int Algorithm);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticRawMemoryCopy", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticRawMemoryCopy(__IntPtr hFile, ulong FileMapVA, ulong VitualAddressToCopy, uint Size, bool AddressIsRVA, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticRawMemoryCopyW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticRawMemoryCopyW(__IntPtr hFile, ulong FileMapVA, ulong VitualAddressToCopy, uint Size, bool AddressIsRVA, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticRawMemoryCopyEx", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticRawMemoryCopyEx(__IntPtr hFile, uint RawAddressToCopy, uint Size, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticRawMemoryCopyExW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticRawMemoryCopyExW(__IntPtr hFile, uint RawAddressToCopy, uint Size, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticRawMemoryCopyEx64", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticRawMemoryCopyEx64(__IntPtr hFile, ulong RawAddressToCopy, ulong Size, sbyte* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticRawMemoryCopyEx64W", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticRawMemoryCopyEx64W(__IntPtr hFile, ulong RawAddressToCopy, ulong Size, char* szDumpFileName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticHashMemory", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticHashMemory(__IntPtr MemoryToHash, uint SizeOfMemory, __IntPtr HashDigest, bool OutputString, int Algorithm);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticHashFile", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticHashFile(sbyte* szFileName, sbyte* HashDigest, bool OutputString, int Algorithm);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "StaticHashFileW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool StaticHashFileW(char* szFileName, sbyte* HashDigest, bool OutputString, int Algorithm);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "SetEngineVariable", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetEngineVariable(uint VariableId, bool VariableSet);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineCreateMissingDependencies", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EngineCreateMissingDependencies(sbyte* szFileName, sbyte* szOutputFolder, bool LogCreatedFiles);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineCreateMissingDependenciesW", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EngineCreateMissingDependenciesW(char* szFileName, char* szOutputFolder, bool LogCreatedFiles);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineFakeMissingDependencies", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EngineFakeMissingDependencies(__IntPtr hProcess);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineDeleteCreatedDependencies", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EngineDeleteCreatedDependencies();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineCreateUnpackerWindow", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EngineCreateUnpackerWindow(sbyte* WindowUnpackerTitle, sbyte* WindowUnpackerLongTitle, sbyte* WindowUnpackerName, sbyte* WindowUnpackerAuthor, __IntPtr StartUnpackingCallBack);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineAddUnpackerWindowLogMessage", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void EngineAddUnpackerWindowLogMessage(sbyte* szLogMessage);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "EngineCheckStructAlignment", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool EngineCheckStructAlignment(uint StructureType, ulong StructureSize);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerIsPluginLoaded", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerIsPluginLoaded(sbyte* szPluginName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerIsPluginEnabled", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerIsPluginEnabled(sbyte* szPluginName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerDisableAllPlugins", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerDisableAllPlugins();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerDisablePlugin", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerDisablePlugin(sbyte* szPluginName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerEnableAllPlugins", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerEnableAllPlugins();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerEnablePlugin", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerEnablePlugin(sbyte* szPluginName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerUnloadAllPlugins", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerUnloadAllPlugins();

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerUnloadPlugin", CallingConvention = __CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ExtensionManagerUnloadPlugin(sbyte* szPluginName);

            [SuppressUnmanagedCodeSecurity, DllImport("TitanEngine", EntryPoint = "ExtensionManagerGetPluginInfo", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ExtensionManagerGetPluginInfo(sbyte* szPluginName);
        }

        public static bool DumpProcess(__IntPtr hProcess, __IntPtr ImageBase, sbyte* szDumpFileName, ulong EntryPoint)
        {
            var __ret = __Internal.DumpProcess(hProcess, ImageBase, szDumpFileName, EntryPoint);
            return __ret;
        }

        public static bool DumpProcessW(__IntPtr hProcess, __IntPtr ImageBase, char* szDumpFileName, ulong EntryPoint)
        {
            var __ret = __Internal.DumpProcessW(hProcess, ImageBase, szDumpFileName, EntryPoint);
            return __ret;
        }

        public static bool DumpProcessEx(uint ProcessId, __IntPtr ImageBase, sbyte* szDumpFileName, ulong EntryPoint)
        {
            var __ret = __Internal.DumpProcessEx(ProcessId, ImageBase, szDumpFileName, EntryPoint);
            return __ret;
        }

        public static bool DumpProcessExW(uint ProcessId, __IntPtr ImageBase, char* szDumpFileName, ulong EntryPoint)
        {
            var __ret = __Internal.DumpProcessExW(ProcessId, ImageBase, szDumpFileName, EntryPoint);
            return __ret;
        }

        public static bool DumpMemory(__IntPtr hProcess, __IntPtr MemoryStart, ulong MemorySize, sbyte* szDumpFileName)
        {
            var __ret = __Internal.DumpMemory(hProcess, MemoryStart, MemorySize, szDumpFileName);
            return __ret;
        }

        public static bool DumpMemoryW(__IntPtr hProcess, __IntPtr MemoryStart, ulong MemorySize, char* szDumpFileName)
        {
            var __ret = __Internal.DumpMemoryW(hProcess, MemoryStart, MemorySize, szDumpFileName);
            return __ret;
        }

        public static bool DumpMemoryEx(uint ProcessId, __IntPtr MemoryStart, ulong MemorySize, sbyte* szDumpFileName)
        {
            var __ret = __Internal.DumpMemoryEx(ProcessId, MemoryStart, MemorySize, szDumpFileName);
            return __ret;
        }

        public static bool DumpMemoryExW(uint ProcessId, __IntPtr MemoryStart, ulong MemorySize, char* szDumpFileName)
        {
            var __ret = __Internal.DumpMemoryExW(ProcessId, MemoryStart, MemorySize, szDumpFileName);
            return __ret;
        }

        public static bool DumpRegions(__IntPtr hProcess, sbyte* szDumpFolder, bool DumpAboveImageBaseOnly)
        {
            var __ret = __Internal.DumpRegions(hProcess, szDumpFolder, DumpAboveImageBaseOnly);
            return __ret;
        }

        public static bool DumpRegionsW(__IntPtr hProcess, char* szDumpFolder, bool DumpAboveImageBaseOnly)
        {
            var __ret = __Internal.DumpRegionsW(hProcess, szDumpFolder, DumpAboveImageBaseOnly);
            return __ret;
        }

        public static bool DumpRegionsEx(uint ProcessId, sbyte* szDumpFolder, bool DumpAboveImageBaseOnly)
        {
            var __ret = __Internal.DumpRegionsEx(ProcessId, szDumpFolder, DumpAboveImageBaseOnly);
            return __ret;
        }

        public static bool DumpRegionsExW(uint ProcessId, char* szDumpFolder, bool DumpAboveImageBaseOnly)
        {
            var __ret = __Internal.DumpRegionsExW(ProcessId, szDumpFolder, DumpAboveImageBaseOnly);
            return __ret;
        }

        public static bool DumpModule(__IntPtr hProcess, __IntPtr ModuleBase, sbyte* szDumpFileName)
        {
            var __ret = __Internal.DumpModule(hProcess, ModuleBase, szDumpFileName);
            return __ret;
        }

        public static bool DumpModuleW(__IntPtr hProcess, __IntPtr ModuleBase, char* szDumpFileName)
        {
            var __ret = __Internal.DumpModuleW(hProcess, ModuleBase, szDumpFileName);
            return __ret;
        }

        public static bool DumpModuleEx(uint ProcessId, __IntPtr ModuleBase, sbyte* szDumpFileName)
        {
            var __ret = __Internal.DumpModuleEx(ProcessId, ModuleBase, szDumpFileName);
            return __ret;
        }

        public static bool DumpModuleExW(uint ProcessId, __IntPtr ModuleBase, char* szDumpFileName)
        {
            var __ret = __Internal.DumpModuleExW(ProcessId, ModuleBase, szDumpFileName);
            return __ret;
        }

        public static bool PastePEHeader(__IntPtr hProcess, __IntPtr ImageBase, sbyte* szDebuggedFileName)
        {
            var __ret = __Internal.PastePEHeader(hProcess, ImageBase, szDebuggedFileName);
            return __ret;
        }

        public static bool PastePEHeaderW(__IntPtr hProcess, __IntPtr ImageBase, char* szDebuggedFileName)
        {
            var __ret = __Internal.PastePEHeaderW(hProcess, ImageBase, szDebuggedFileName);
            return __ret;
        }

        public static bool ExtractSection(sbyte* szFileName, sbyte* szDumpFileName, uint SectionNumber)
        {
            var __ret = __Internal.ExtractSection(szFileName, szDumpFileName, SectionNumber);
            return __ret;
        }

        public static bool ExtractSectionW(char* szFileName, char* szDumpFileName, uint SectionNumber)
        {
            var __ret = __Internal.ExtractSectionW(szFileName, szDumpFileName, SectionNumber);
            return __ret;
        }

        public static bool ResortFileSections(sbyte* szFileName)
        {
            var __ret = __Internal.ResortFileSections(szFileName);
            return __ret;
        }

        public static bool ResortFileSectionsW(char* szFileName)
        {
            var __ret = __Internal.ResortFileSectionsW(szFileName);
            return __ret;
        }

        public static bool FindOverlay(sbyte* szFileName, ref uint OverlayStart, ref uint OverlaySize)
        {
            fixed (uint* __OverlayStart1 = &OverlayStart)
            {
                var __arg1 = __OverlayStart1;
                fixed (uint* __OverlaySize2 = &OverlaySize)
                {
                    var __arg2 = __OverlaySize2;
                    var __ret = __Internal.FindOverlay(szFileName, __arg1, __arg2);
                    return __ret;
                }
            }
        }

        public static bool FindOverlayW(char* szFileName, ref uint OverlayStart, ref uint OverlaySize)
        {
            fixed (uint* __OverlayStart1 = &OverlayStart)
            {
                var __arg1 = __OverlayStart1;
                fixed (uint* __OverlaySize2 = &OverlaySize)
                {
                    var __arg2 = __OverlaySize2;
                    var __ret = __Internal.FindOverlayW(szFileName, __arg1, __arg2);
                    return __ret;
                }
            }
        }

        public static bool ExtractOverlay(sbyte* szFileName, sbyte* szExtractedFileName)
        {
            var __ret = __Internal.ExtractOverlay(szFileName, szExtractedFileName);
            return __ret;
        }

        public static bool ExtractOverlayW(char* szFileName, char* szExtractedFileName)
        {
            var __ret = __Internal.ExtractOverlayW(szFileName, szExtractedFileName);
            return __ret;
        }

        public static bool AddOverlay(sbyte* szFileName, sbyte* szOverlayFileName)
        {
            var __ret = __Internal.AddOverlay(szFileName, szOverlayFileName);
            return __ret;
        }

        public static bool AddOverlayW(char* szFileName, char* szOverlayFileName)
        {
            var __ret = __Internal.AddOverlayW(szFileName, szOverlayFileName);
            return __ret;
        }

        public static bool CopyOverlay(sbyte* szInFileName, sbyte* szOutFileName)
        {
            var __ret = __Internal.CopyOverlay(szInFileName, szOutFileName);
            return __ret;
        }

        public static bool CopyOverlayW(char* szInFileName, char* szOutFileName)
        {
            var __ret = __Internal.CopyOverlayW(szInFileName, szOutFileName);
            return __ret;
        }

        public static bool RemoveOverlay(sbyte* szFileName)
        {
            var __ret = __Internal.RemoveOverlay(szFileName);
            return __ret;
        }

        public static bool RemoveOverlayW(char* szFileName)
        {
            var __ret = __Internal.RemoveOverlayW(szFileName);
            return __ret;
        }

        public static bool MakeAllSectionsRWE(sbyte* szFileName)
        {
            var __ret = __Internal.MakeAllSectionsRWE(szFileName);
            return __ret;
        }

        public static bool MakeAllSectionsRWEW(char* szFileName)
        {
            var __ret = __Internal.MakeAllSectionsRWEW(szFileName);
            return __ret;
        }

        public static int AddNewSectionEx(sbyte* szFileName, sbyte* szSectionName, uint SectionSize, uint SectionAttributes, __IntPtr SectionContent, uint ContentSize)
        {
            var __ret = __Internal.AddNewSectionEx(szFileName, szSectionName, SectionSize, SectionAttributes, SectionContent, ContentSize);
            return __ret;
        }

        public static int AddNewSectionExW(char* szFileName, sbyte* szSectionName, uint SectionSize, uint SectionAttributes, __IntPtr SectionContent, uint ContentSize)
        {
            var __ret = __Internal.AddNewSectionExW(szFileName, szSectionName, SectionSize, SectionAttributes, SectionContent, ContentSize);
            return __ret;
        }

        public static int AddNewSection(sbyte* szFileName, sbyte* szSectionName, uint SectionSize)
        {
            var __ret = __Internal.AddNewSection(szFileName, szSectionName, SectionSize);
            return __ret;
        }

        public static int AddNewSectionW(char* szFileName, sbyte* szSectionName, uint SectionSize)
        {
            var __ret = __Internal.AddNewSectionW(szFileName, szSectionName, SectionSize);
            return __ret;
        }

        public static bool ResizeLastSection(sbyte* szFileName, uint NumberOfExpandBytes, bool AlignResizeData)
        {
            var __ret = __Internal.ResizeLastSection(szFileName, NumberOfExpandBytes, AlignResizeData);
            return __ret;
        }

        public static bool ResizeLastSectionW(char* szFileName, uint NumberOfExpandBytes, bool AlignResizeData)
        {
            var __ret = __Internal.ResizeLastSectionW(szFileName, NumberOfExpandBytes, AlignResizeData);
            return __ret;
        }

        public static void SetSharedOverlay(sbyte* szFileName)
        {
            __Internal.SetSharedOverlay(szFileName);
        }

        public static void SetSharedOverlayW(char* szFileName)
        {
            __Internal.SetSharedOverlayW(szFileName);
        }

        public static sbyte* GetSharedOverlay()
        {
            var __ret = __Internal.GetSharedOverlay();
            return __ret;
        }

        public static char* GetSharedOverlayW()
        {
            var __ret = __Internal.GetSharedOverlayW();
            return __ret;
        }

        public static bool DeleteLastSection(sbyte* szFileName)
        {
            var __ret = __Internal.DeleteLastSection(szFileName);
            return __ret;
        }

        public static bool DeleteLastSectionW(char* szFileName)
        {
            var __ret = __Internal.DeleteLastSectionW(szFileName);
            return __ret;
        }

        public static bool DeleteLastSectionEx(sbyte* szFileName, uint NumberOfSections)
        {
            var __ret = __Internal.DeleteLastSectionEx(szFileName, NumberOfSections);
            return __ret;
        }

        public static bool DeleteLastSectionExW(char* szFileName, uint NumberOfSections)
        {
            var __ret = __Internal.DeleteLastSectionExW(szFileName, NumberOfSections);
            return __ret;
        }

        public static ulong GetPE32DataFromMappedFile(ulong FileMapVA, uint WhichSection, uint WhichData)
        {
            var __ret = __Internal.GetPE32DataFromMappedFile(FileMapVA, WhichSection, WhichData);
            return __ret;
        }

        public static ulong GetPE32Data(sbyte* szFileName, uint WhichSection, uint WhichData)
        {
            var __ret = __Internal.GetPE32Data(szFileName, WhichSection, WhichData);
            return __ret;
        }

        public static ulong GetPE32DataW(string szFileName, uint WhichSection, uint WhichData)
        {
            var __ret = __Internal.GetPE32DataW(szFileName, WhichSection, WhichData);
            return __ret;
        }

        public static bool GetPE32DataFromMappedFileEx(ulong FileMapVA, __IntPtr DataStorage)
        {
            var __ret = __Internal.GetPE32DataFromMappedFileEx(FileMapVA, DataStorage);
            return __ret;
        }

        public static bool GetPE32DataEx(sbyte* szFileName, __IntPtr DataStorage)
        {
            var __ret = __Internal.GetPE32DataEx(szFileName, DataStorage);
            return __ret;
        }

        public static bool GetPE32DataExW(char* szFileName, __IntPtr DataStorage)
        {
            var __ret = __Internal.GetPE32DataExW(szFileName, DataStorage);
            return __ret;
        }

        public static bool SetPE32DataForMappedFile(ulong FileMapVA, uint WhichSection, uint WhichData, ulong NewDataValue)
        {
            var __ret = __Internal.SetPE32DataForMappedFile(FileMapVA, WhichSection, WhichData, NewDataValue);
            return __ret;
        }

        public static bool SetPE32Data(sbyte* szFileName, uint WhichSection, uint WhichData, ulong NewDataValue)
        {
            var __ret = __Internal.SetPE32Data(szFileName, WhichSection, WhichData, NewDataValue);
            return __ret;
        }

        public static bool SetPE32DataW(char* szFileName, uint WhichSection, uint WhichData, ulong NewDataValue)
        {
            var __ret = __Internal.SetPE32DataW(szFileName, WhichSection, WhichData, NewDataValue);
            return __ret;
        }

        public static bool SetPE32DataForMappedFileEx(ulong FileMapVA, __IntPtr DataStorage)
        {
            var __ret = __Internal.SetPE32DataForMappedFileEx(FileMapVA, DataStorage);
            return __ret;
        }

        public static bool SetPE32DataEx(sbyte* szFileName, __IntPtr DataStorage)
        {
            var __ret = __Internal.SetPE32DataEx(szFileName, DataStorage);
            return __ret;
        }

        public static bool SetPE32DataExW(char* szFileName, __IntPtr DataStorage)
        {
            var __ret = __Internal.SetPE32DataExW(szFileName, DataStorage);
            return __ret;
        }

        public static int GetPE32SectionNumberFromVA(ulong FileMapVA, ulong AddressToConvert)
        {
            var __ret = __Internal.GetPE32SectionNumberFromVA(FileMapVA, AddressToConvert);
            return __ret;
        }

        public static ulong ConvertVAtoFileOffset(ulong FileMapVA, ulong AddressToConvert, bool ReturnType)
        {
            var __ret = __Internal.ConvertVAtoFileOffset(FileMapVA, AddressToConvert, ReturnType);
            return __ret;
        }

        public static ulong ConvertVAtoFileOffsetEx(ulong FileMapVA, uint FileSize, ulong ImageBase, ulong AddressToConvert, bool AddressIsRVA, bool ReturnType)
        {
            var __ret = __Internal.ConvertVAtoFileOffsetEx(FileMapVA, FileSize, ImageBase, AddressToConvert, AddressIsRVA, ReturnType);
            return __ret;
        }

        public static ulong ConvertFileOffsetToVA(ulong FileMapVA, ulong AddressToConvert, bool ReturnType)
        {
            var __ret = __Internal.ConvertFileOffsetToVA(FileMapVA, AddressToConvert, ReturnType);
            return __ret;
        }

        public static ulong ConvertFileOffsetToVAEx(ulong FileMapVA, uint FileSize, ulong ImageBase, ulong AddressToConvert, bool ReturnType)
        {
            var __ret = __Internal.ConvertFileOffsetToVAEx(FileMapVA, FileSize, ImageBase, AddressToConvert, ReturnType);
            return __ret;
        }

        public static bool MemoryReadSafe(__IntPtr hProcess, __IntPtr lpBaseAddress, __IntPtr lpBuffer, ulong nSize, ref ulong lpNumberOfBytesRead)
        {
            fixed (ulong* __lpNumberOfBytesRead4 = &lpNumberOfBytesRead)
            {
                var __arg4 = __lpNumberOfBytesRead4;
                var __ret = __Internal.MemoryReadSafe(hProcess, lpBaseAddress, lpBuffer, nSize, __arg4);
                return __ret;
            }
        }

        public static bool MemoryWriteSafe(__IntPtr hProcess, __IntPtr lpBaseAddress, __IntPtr lpBuffer, ulong nSize, ref ulong lpNumberOfBytesWritten)
        {
            fixed (ulong* __lpNumberOfBytesWritten4 = &lpNumberOfBytesWritten)
            {
                var __arg4 = __lpNumberOfBytesWritten4;
                var __ret = __Internal.MemoryWriteSafe(hProcess, lpBaseAddress, lpBuffer, nSize, __arg4);
                return __ret;
            }
        }

        public static bool FixHeaderCheckSum(sbyte* szFileName)
        {
            var __ret = __Internal.FixHeaderCheckSum(szFileName);
            return __ret;
        }

        public static bool FixHeaderCheckSumW(char* szFileName)
        {
            var __ret = __Internal.FixHeaderCheckSumW(szFileName);
            return __ret;
        }

        public static int RealignPE(ulong FileMapVA, uint FileSize, uint RealingMode)
        {
            var __ret = __Internal.RealignPE(FileMapVA, FileSize, RealingMode);
            return __ret;
        }

        public static int RealignPEEx(sbyte* szFileName, uint RealingFileSize, uint ForcedFileAlignment)
        {
            var __ret = __Internal.RealignPEEx(szFileName, RealingFileSize, ForcedFileAlignment);
            return __ret;
        }

        public static int RealignPEExW(char* szFileName, uint RealingFileSize, uint ForcedFileAlignment)
        {
            var __ret = __Internal.RealignPEExW(szFileName, RealingFileSize, ForcedFileAlignment);
            return __ret;
        }

        public static bool WipeSection(sbyte* szFileName, int WipeSectionNumber, bool RemovePhysically)
        {
            var __ret = __Internal.WipeSection(szFileName, WipeSectionNumber, RemovePhysically);
            return __ret;
        }

        public static bool WipeSectionW(char* szFileName, int WipeSectionNumber, bool RemovePhysically)
        {
            var __ret = __Internal.WipeSectionW(szFileName, WipeSectionNumber, RemovePhysically);
            return __ret;
        }

        public static bool IsPE32FileValidEx(sbyte* szFileName, uint CheckDepth, __IntPtr FileStatusInfo)
        {
            var __ret = __Internal.IsPE32FileValidEx(szFileName, CheckDepth, FileStatusInfo);
            return __ret;
        }

        public static bool IsPE32FileValidExW(char* szFileName, uint CheckDepth, __IntPtr FileStatusInfo)
        {
            var __ret = __Internal.IsPE32FileValidExW(szFileName, CheckDepth, FileStatusInfo);
            return __ret;
        }

        public static bool FixBrokenPE32FileEx(sbyte* szFileName, __IntPtr FileStatusInfo, __IntPtr FileFixInfo)
        {
            var __ret = __Internal.FixBrokenPE32FileEx(szFileName, FileStatusInfo, FileFixInfo);
            return __ret;
        }

        public static bool FixBrokenPE32FileExW(char* szFileName, __IntPtr FileStatusInfo, __IntPtr FileFixInfo)
        {
            var __ret = __Internal.FixBrokenPE32FileExW(szFileName, FileStatusInfo, FileFixInfo);
            return __ret;
        }

        public static bool IsFileDLL(sbyte* szFileName, ulong FileMapVA)
        {
            var __ret = __Internal.IsFileDLL(szFileName, FileMapVA);
            return __ret;
        }

        public static bool IsFileDLLW(char* szFileName, ulong FileMapVA)
        {
            var __ret = __Internal.IsFileDLLW(szFileName, FileMapVA);
            return __ret;
        }

        public static __IntPtr GetPEBLocation(__IntPtr hProcess)
        {
            var __ret = __Internal.GetPEBLocation(hProcess);
            return __ret;
        }

        public static __IntPtr GetPEBLocation64(__IntPtr hProcess)
        {
            var __ret = __Internal.GetPEBLocation64(hProcess);
            return __ret;
        }

        public static __IntPtr GetTEBLocation(__IntPtr hThread)
        {
            var __ret = __Internal.GetTEBLocation(hThread);
            return __ret;
        }

        public static __IntPtr GetTEBLocation64(__IntPtr hThread)
        {
            var __ret = __Internal.GetTEBLocation64(hThread);
            return __ret;
        }

        public static bool HideDebugger(__IntPtr hProcess, uint PatchAPILevel)
        {
            var __ret = __Internal.HideDebugger(hProcess, PatchAPILevel);
            return __ret;
        }

        public static bool UnHideDebugger(__IntPtr hProcess, uint PatchAPILevel)
        {
            var __ret = __Internal.UnHideDebugger(hProcess, PatchAPILevel);
            return __ret;
        }

        public static void RelocaterCleanup()
        {
            __Internal.RelocaterCleanup();
        }

        public static void RelocaterInit(uint MemorySize, ulong OldImageBase, ulong NewImageBase)
        {
            __Internal.RelocaterInit(MemorySize, OldImageBase, NewImageBase);
        }

        public static void RelocaterAddNewRelocation(__IntPtr hProcess, ulong RelocateAddress, uint RelocateState)
        {
            __Internal.RelocaterAddNewRelocation(hProcess, RelocateAddress, RelocateState);
        }

        public static int RelocaterEstimatedSize()
        {
            var __ret = __Internal.RelocaterEstimatedSize();
            return __ret;
        }

        public static bool RelocaterExportRelocation(ulong StorePlace, uint StorePlaceRVA, ulong FileMapVA)
        {
            var __ret = __Internal.RelocaterExportRelocation(StorePlace, StorePlaceRVA, FileMapVA);
            return __ret;
        }

        public static bool RelocaterExportRelocationEx(sbyte* szFileName, sbyte* szSectionName)
        {
            var __ret = __Internal.RelocaterExportRelocationEx(szFileName, szSectionName);
            return __ret;
        }

        public static bool RelocaterExportRelocationExW(char* szFileName, sbyte* szSectionName)
        {
            var __ret = __Internal.RelocaterExportRelocationExW(szFileName, szSectionName);
            return __ret;
        }

        public static bool RelocaterGrabRelocationTable(__IntPtr hProcess, ulong MemoryStart, uint MemorySize)
        {
            var __ret = __Internal.RelocaterGrabRelocationTable(hProcess, MemoryStart, MemorySize);
            return __ret;
        }

        public static bool RelocaterGrabRelocationTableEx(__IntPtr hProcess, ulong MemoryStart, ulong MemorySize, uint NtSizeOfImage)
        {
            var __ret = __Internal.RelocaterGrabRelocationTableEx(hProcess, MemoryStart, MemorySize, NtSizeOfImage);
            return __ret;
        }

        public static bool RelocaterMakeSnapshot(__IntPtr hProcess, sbyte* szSaveFileName, __IntPtr MemoryStart, ulong MemorySize)
        {
            var __ret = __Internal.RelocaterMakeSnapshot(hProcess, szSaveFileName, MemoryStart, MemorySize);
            return __ret;
        }

        public static bool RelocaterMakeSnapshotW(__IntPtr hProcess, char* szSaveFileName, __IntPtr MemoryStart, ulong MemorySize)
        {
            var __ret = __Internal.RelocaterMakeSnapshotW(hProcess, szSaveFileName, MemoryStart, MemorySize);
            return __ret;
        }

        public static bool RelocaterCompareTwoSnapshots(__IntPtr hProcess, ulong LoadedImageBase, ulong NtSizeOfImage, sbyte* szDumpFile1, sbyte* szDumpFile2, ulong MemStart)
        {
            var __ret = __Internal.RelocaterCompareTwoSnapshots(hProcess, LoadedImageBase, NtSizeOfImage, szDumpFile1, szDumpFile2, MemStart);
            return __ret;
        }

        public static bool RelocaterCompareTwoSnapshotsW(__IntPtr hProcess, ulong LoadedImageBase, ulong NtSizeOfImage, char* szDumpFile1, char* szDumpFile2, ulong MemStart)
        {
            var __ret = __Internal.RelocaterCompareTwoSnapshotsW(hProcess, LoadedImageBase, NtSizeOfImage, szDumpFile1, szDumpFile2, MemStart);
            return __ret;
        }

        public static bool RelocaterChangeFileBase(sbyte* szFileName, ulong NewImageBase)
        {
            var __ret = __Internal.RelocaterChangeFileBase(szFileName, NewImageBase);
            return __ret;
        }

        public static bool RelocaterChangeFileBaseW(char* szFileName, ulong NewImageBase)
        {
            var __ret = __Internal.RelocaterChangeFileBaseW(szFileName, NewImageBase);
            return __ret;
        }

        public static bool RelocaterRelocateMemoryBlock(ulong FileMapVA, ulong MemoryLocation, __IntPtr RelocateMemory, uint RelocateMemorySize, ulong CurrentLoadedBase, ulong RelocateBase)
        {
            var __ret = __Internal.RelocaterRelocateMemoryBlock(FileMapVA, MemoryLocation, RelocateMemory, RelocateMemorySize, CurrentLoadedBase, RelocateBase);
            return __ret;
        }

        public static bool RelocaterWipeRelocationTable(sbyte* szFileName)
        {
            var __ret = __Internal.RelocaterWipeRelocationTable(szFileName);
            return __ret;
        }

        public static bool RelocaterWipeRelocationTableW(char* szFileName)
        {
            var __ret = __Internal.RelocaterWipeRelocationTableW(szFileName);
            return __ret;
        }

        public static ulong ResourcerLoadFileForResourceUse(sbyte* szFileName)
        {
            var __ret = __Internal.ResourcerLoadFileForResourceUse(szFileName);
            return __ret;
        }

        public static ulong ResourcerLoadFileForResourceUseW(char* szFileName)
        {
            var __ret = __Internal.ResourcerLoadFileForResourceUseW(szFileName);
            return __ret;
        }

        public static bool ResourcerFreeLoadedFile(__IntPtr LoadedFileBase)
        {
            var __ret = __Internal.ResourcerFreeLoadedFile(LoadedFileBase);
            return __ret;
        }

        public static bool ResourcerExtractResourceFromFile(sbyte* szFileName, sbyte* szResourceType, sbyte* szResourceName, sbyte* szExtractedFileName)
        {
            var __ret = __Internal.ResourcerExtractResourceFromFile(szFileName, szResourceType, szResourceName, szExtractedFileName);
            return __ret;
        }

        public static bool ResourcerExtractResourceFromFileW(char* szFileName, sbyte* szResourceType, sbyte* szResourceName, sbyte* szExtractedFileName)
        {
            var __ret = __Internal.ResourcerExtractResourceFromFileW(szFileName, szResourceType, szResourceName, szExtractedFileName);
            return __ret;
        }

        public static bool ResourcerFindResource(sbyte* szFileName, sbyte* szResourceType, uint ResourceType, sbyte* szResourceName, uint ResourceName, uint ResourceLanguage, ref ulong pResourceData, ref uint pResourceSize)
        {
            fixed (ulong* __pResourceData6 = &pResourceData)
            {
                var __arg6 = __pResourceData6;
                fixed (uint* __pResourceSize7 = &pResourceSize)
                {
                    var __arg7 = __pResourceSize7;
                    var __ret = __Internal.ResourcerFindResource(szFileName, szResourceType, ResourceType, szResourceName, ResourceName, ResourceLanguage, __arg6, __arg7);
                    return __ret;
                }
            }
        }

        public static bool ResourcerFindResourceW(char* szFileName, char* szResourceType, uint ResourceType, char* szResourceName, uint ResourceName, uint ResourceLanguage, ref ulong pResourceData, ref uint pResourceSize)
        {
            fixed (ulong* __pResourceData6 = &pResourceData)
            {
                var __arg6 = __pResourceData6;
                fixed (uint* __pResourceSize7 = &pResourceSize)
                {
                    var __arg7 = __pResourceSize7;
                    var __ret = __Internal.ResourcerFindResourceW(szFileName, szResourceType, ResourceType, szResourceName, ResourceName, ResourceLanguage, __arg6, __arg7);
                    return __ret;
                }
            }
        }

        public static bool ResourcerFindResourceEx(ulong FileMapVA, uint FileSize, char* szResourceType, uint ResourceType, char* szResourceName, uint ResourceName, uint ResourceLanguage, ref ulong pResourceData, ref uint pResourceSize)
        {
            fixed (ulong* __pResourceData7 = &pResourceData)
            {
                var __arg7 = __pResourceData7;
                fixed (uint* __pResourceSize8 = &pResourceSize)
                {
                    var __arg8 = __pResourceSize8;
                    var __ret = __Internal.ResourcerFindResourceEx(FileMapVA, FileSize, szResourceType, ResourceType, szResourceName, ResourceName, ResourceLanguage, __arg7, __arg8);
                    return __ret;
                }
            }
        }

        public static void ResourcerEnumerateResource(sbyte* szFileName, __IntPtr CallBack)
        {
            __Internal.ResourcerEnumerateResource(szFileName, CallBack);
        }

        public static void ResourcerEnumerateResourceW(char* szFileName, __IntPtr CallBack)
        {
            __Internal.ResourcerEnumerateResourceW(szFileName, CallBack);
        }

        public static void ResourcerEnumerateResourceEx(ulong FileMapVA, uint FileSize, __IntPtr CallBack)
        {
            __Internal.ResourcerEnumerateResourceEx(FileMapVA, FileSize, CallBack);
        }

        public static bool ThreaderImportRunningThreadData(uint ProcessId)
        {
            var __ret = __Internal.ThreaderImportRunningThreadData(ProcessId);
            return __ret;
        }

        public static __IntPtr ThreaderGetThreadInfo(__IntPtr hThread, uint ThreadId)
        {
            var __ret = __Internal.ThreaderGetThreadInfo(hThread, ThreadId);
            return __ret;
        }

        public static void ThreaderEnumThreadInfo(__IntPtr EnumCallBack)
        {
            __Internal.ThreaderEnumThreadInfo(EnumCallBack);
        }

        public static bool ThreaderPauseThread(__IntPtr hThread)
        {
            var __ret = __Internal.ThreaderPauseThread(hThread);
            return __ret;
        }

        public static bool ThreaderResumeThread(__IntPtr hThread)
        {
            var __ret = __Internal.ThreaderResumeThread(hThread);
            return __ret;
        }

        public static bool ThreaderTerminateThread(__IntPtr hThread, uint ThreadExitCode)
        {
            var __ret = __Internal.ThreaderTerminateThread(hThread, ThreadExitCode);
            return __ret;
        }

        public static bool ThreaderPauseAllThreads(bool LeaveMainRunning)
        {
            var __ret = __Internal.ThreaderPauseAllThreads(LeaveMainRunning);
            return __ret;
        }

        public static bool ThreaderResumeAllThreads(bool LeaveMainPaused)
        {
            var __ret = __Internal.ThreaderResumeAllThreads(LeaveMainPaused);
            return __ret;
        }

        public static bool ThreaderPauseProcess()
        {
            var __ret = __Internal.ThreaderPauseProcess();
            return __ret;
        }

        public static bool ThreaderResumeProcess()
        {
            var __ret = __Internal.ThreaderResumeProcess();
            return __ret;
        }

        public static ulong ThreaderCreateRemoteThread(ulong ThreadStartAddress, bool AutoCloseTheHandle, __IntPtr ThreadPassParameter, ref uint ThreadId)
        {
            fixed (uint* __ThreadId3 = &ThreadId)
            {
                var __arg3 = __ThreadId3;
                var __ret = __Internal.ThreaderCreateRemoteThread(ThreadStartAddress, AutoCloseTheHandle, ThreadPassParameter, __arg3);
                return __ret;
            }
        }

        public static bool ThreaderInjectAndExecuteCode(__IntPtr InjectCode, uint StartDelta, uint InjectSize)
        {
            var __ret = __Internal.ThreaderInjectAndExecuteCode(InjectCode, StartDelta, InjectSize);
            return __ret;
        }

        public static ulong ThreaderCreateRemoteThreadEx(__IntPtr hProcess, ulong ThreadStartAddress, bool AutoCloseTheHandle, __IntPtr ThreadPassParameter, ref uint ThreadId)
        {
            fixed (uint* __ThreadId4 = &ThreadId)
            {
                var __arg4 = __ThreadId4;
                var __ret = __Internal.ThreaderCreateRemoteThreadEx(hProcess, ThreadStartAddress, AutoCloseTheHandle, ThreadPassParameter, __arg4);
                return __ret;
            }
        }

        public static bool ThreaderInjectAndExecuteCodeEx(__IntPtr hProcess, __IntPtr InjectCode, uint StartDelta, uint InjectSize)
        {
            var __ret = __Internal.ThreaderInjectAndExecuteCodeEx(hProcess, InjectCode, StartDelta, InjectSize);
            return __ret;
        }

        public static void ThreaderSetCallBackForNextExitThreadEvent(__IntPtr exitThreadCallBack)
        {
            __Internal.ThreaderSetCallBackForNextExitThreadEvent(exitThreadCallBack);
        }

        public static bool ThreaderIsThreadStillRunning(__IntPtr hThread)
        {
            var __ret = __Internal.ThreaderIsThreadStillRunning(hThread);
            return __ret;
        }

        public static bool ThreaderIsThreadActive(__IntPtr hThread)
        {
            var __ret = __Internal.ThreaderIsThreadActive(hThread);
            return __ret;
        }

        public static bool ThreaderIsAnyThreadActive()
        {
            var __ret = __Internal.ThreaderIsAnyThreadActive();
            return __ret;
        }

        public static bool ThreaderExecuteOnlyInjectedThreads()
        {
            var __ret = __Internal.ThreaderExecuteOnlyInjectedThreads();
            return __ret;
        }

        public static ulong ThreaderGetOpenHandleForThread(uint ThreadId)
        {
            var __ret = __Internal.ThreaderGetOpenHandleForThread(ThreadId);
            return __ret;
        }

        public static bool ThreaderIsExceptionInMainThread()
        {
            var __ret = __Internal.ThreaderIsExceptionInMainThread();
            return __ret;
        }

        public static __IntPtr StaticDisassembleEx(ulong DisassmStart, __IntPtr DisassmAddress)
        {
            var __ret = __Internal.StaticDisassembleEx(DisassmStart, DisassmAddress);
            return __ret;
        }

        public static __IntPtr StaticDisassemble(__IntPtr DisassmAddress)
        {
            var __ret = __Internal.StaticDisassemble(DisassmAddress);
            return __ret;
        }

        public static __IntPtr DisassembleEx(__IntPtr hProcess, __IntPtr DisassmAddress, bool ReturnInstructionType)
        {
            var __ret = __Internal.DisassembleEx(hProcess, DisassmAddress, ReturnInstructionType);
            return __ret;
        }

        public static __IntPtr Disassemble(__IntPtr DisassmAddress)
        {
            var __ret = __Internal.Disassemble(DisassmAddress);
            return __ret;
        }

        public static int StaticLengthDisassemble(__IntPtr DisassmAddress)
        {
            var __ret = __Internal.StaticLengthDisassemble(DisassmAddress);
            return __ret;
        }

        public static int LengthDisassembleEx(__IntPtr hProcess, __IntPtr DisassmAddress)
        {
            var __ret = __Internal.LengthDisassembleEx(hProcess, DisassmAddress);
            return __ret;
        }

        public static int LengthDisassemble(__IntPtr DisassmAddress)
        {
            var __ret = __Internal.LengthDisassemble(DisassmAddress);
            return __ret;
        }

        public static __IntPtr InitDebug(sbyte* szFileName, sbyte* szCommandLine, sbyte* szCurrentFolder)
        {
            var __ret = __Internal.InitDebug(szFileName, szCommandLine, szCurrentFolder);
            return __ret;
        }

        public static __IntPtr InitDebugW(char* szFileName, char* szCommandLine, char* szCurrentFolder)
        {
            var __ret = __Internal.InitDebugW(szFileName, szCommandLine, szCurrentFolder);
            return __ret;
        }

        public static __IntPtr InitNativeDebug(sbyte* szFileName, sbyte* szCommandLine, sbyte* szCurrentFolder)
        {
            var __ret = __Internal.InitNativeDebug(szFileName, szCommandLine, szCurrentFolder);
            return __ret;
        }

        public static __IntPtr InitNativeDebugW(char* szFileName, char* szCommandLine, char* szCurrentFolder)
        {
            var __ret = __Internal.InitNativeDebugW(szFileName, szCommandLine, szCurrentFolder);
            return __ret;
        }

        public static __IntPtr InitDebugEx(sbyte* szFileName, sbyte* szCommandLine, sbyte* szCurrentFolder, __IntPtr EntryCallBack)
        {
            var __ret = __Internal.InitDebugEx(szFileName, szCommandLine, szCurrentFolder, EntryCallBack);
            return __ret;
        }

        public static __IntPtr InitDebugExW(char* szFileName, char* szCommandLine, char* szCurrentFolder, __IntPtr EntryCallBack)
        {
            var __ret = __Internal.InitDebugExW(szFileName, szCommandLine, szCurrentFolder, EntryCallBack);
            return __ret;
        }

        public static __IntPtr InitDLLDebug(sbyte* szFileName, bool ReserveModuleBase, sbyte* szCommandLine, sbyte* szCurrentFolder, __IntPtr EntryCallBack)
        {
            var __ret = __Internal.InitDLLDebug(szFileName, ReserveModuleBase, szCommandLine, szCurrentFolder, EntryCallBack);
            return __ret;
        }

        public static __IntPtr InitDLLDebugW(char* szFileName, bool ReserveModuleBase, char* szCommandLine, char* szCurrentFolder, __IntPtr EntryCallBack)
        {
            var __ret = __Internal.InitDLLDebugW(szFileName, ReserveModuleBase, szCommandLine, szCurrentFolder, EntryCallBack);
            return __ret;
        }

        public static bool StopDebug()
        {
            var __ret = __Internal.StopDebug();
            return __ret;
        }

        public static void SetBPXOptions(int DefaultBreakPointType)
        {
            __Internal.SetBPXOptions(DefaultBreakPointType);
        }

        public static bool IsBPXEnabled(ulong bpxAddress)
        {
            var __ret = __Internal.IsBPXEnabled(bpxAddress);
            return __ret;
        }

        public static bool EnableBPX(ulong bpxAddress)
        {
            var __ret = __Internal.EnableBPX(bpxAddress);
            return __ret;
        }

        public static bool DisableBPX(ulong bpxAddress)
        {
            var __ret = __Internal.DisableBPX(bpxAddress);
            return __ret;
        }

        public static bool SetBPX(ulong bpxAddress, uint bpxType, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.SetBPX(bpxAddress, bpxType, bpxCallBack);
            return __ret;
        }

        public static bool DeleteBPX(ulong bpxAddress)
        {
            var __ret = __Internal.DeleteBPX(bpxAddress);
            return __ret;
        }

        public static bool SafeDeleteBPX(ulong bpxAddress)
        {
            var __ret = __Internal.SafeDeleteBPX(bpxAddress);
            return __ret;
        }

        public static bool SetAPIBreakPoint(string szDLLName, string szAPIName, uint bpxType, uint bpxPlace, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.SetAPIBreakPoint(szDLLName, szAPIName, bpxType, bpxPlace, bpxCallBack);
            return __ret;
        }

        public static bool DeleteAPIBreakPoint(string szDLLName, string szAPIName, uint bpxPlace)
        {
            var __ret = __Internal.DeleteAPIBreakPoint(szDLLName, szAPIName, bpxPlace);
            return __ret;
        }

        public static bool SafeDeleteAPIBreakPoint(string szDLLName, string szAPIName, uint bpxPlace)
        {
            var __ret = __Internal.SafeDeleteAPIBreakPoint(szDLLName, szAPIName, bpxPlace);
            return __ret;
        }

        public static bool SetMemoryBPX(ulong MemoryStart, ulong SizeOfMemory, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.SetMemoryBPX(MemoryStart, SizeOfMemory, bpxCallBack);
            return __ret;
        }

        public static bool SetMemoryBPXEx(ulong MemoryStart, ulong SizeOfMemory, uint BreakPointType, bool RestoreOnHit, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.SetMemoryBPXEx(MemoryStart, SizeOfMemory, BreakPointType, RestoreOnHit, bpxCallBack);
            return __ret;
        }

        public static bool RemoveMemoryBPX(ulong MemoryStart, ulong SizeOfMemory)
        {
            var __ret = __Internal.RemoveMemoryBPX(MemoryStart, SizeOfMemory);
            return __ret;
        }

        public static bool GetContextFPUDataEx(__IntPtr hActiveThread, __IntPtr FPUSaveArea)
        {
            var __ret = __Internal.GetContextFPUDataEx(hActiveThread, FPUSaveArea);
            return __ret;
        }

        public static ulong GetContextDataEx(__IntPtr hActiveThread, uint IndexOfRegister)
        {
            var __ret = __Internal.GetContextDataEx(hActiveThread, IndexOfRegister);
            return __ret;
        }

        public static ulong GetContextData(uint IndexOfRegister)
        {
            var __ret = __Internal.GetContextData(IndexOfRegister);
            return __ret;
        }

        public static bool SetContextFPUDataEx(__IntPtr hActiveThread, __IntPtr FPUSaveArea)
        {
            var __ret = __Internal.SetContextFPUDataEx(hActiveThread, FPUSaveArea);
            return __ret;
        }

        public static bool SetContextDataEx(__IntPtr hActiveThread, uint IndexOfRegister, ulong NewRegisterValue)
        {
            var __ret = __Internal.SetContextDataEx(hActiveThread, IndexOfRegister, NewRegisterValue);
            return __ret;
        }

        public static bool SetContextData(uint IndexOfRegister, ulong NewRegisterValue)
        {
            var __ret = __Internal.SetContextData(IndexOfRegister, NewRegisterValue);
            return __ret;
        }

        public static void ClearExceptionNumber()
        {
            __Internal.ClearExceptionNumber();
        }

        public static int CurrentExceptionNumber()
        {
            var __ret = __Internal.CurrentExceptionNumber();
            return __ret;
        }

        public static bool MatchPatternEx(__IntPtr hProcess, __IntPtr MemoryToCheck, int SizeOfMemoryToCheck, __IntPtr PatternToMatch, int SizeOfPatternToMatch, byte* WildCard)
        {
            var __ret = __Internal.MatchPatternEx(hProcess, MemoryToCheck, SizeOfMemoryToCheck, PatternToMatch, SizeOfPatternToMatch, WildCard);
            return __ret;
        }

        public static bool MatchPattern(__IntPtr MemoryToCheck, int SizeOfMemoryToCheck, __IntPtr PatternToMatch, int SizeOfPatternToMatch, byte* WildCard)
        {
            var __ret = __Internal.MatchPattern(MemoryToCheck, SizeOfMemoryToCheck, PatternToMatch, SizeOfPatternToMatch, WildCard);
            return __ret;
        }

        public static ulong FindEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, byte* WildCard)
        {
            var __ret = __Internal.FindEx(hProcess, MemoryStart, MemorySize, SearchPattern, PatternSize, WildCard);
            return __ret;
        }

        public static ulong Find(__IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, byte* WildCard)
        {
            var __ret = __Internal.Find(MemoryStart, MemorySize, SearchPattern, PatternSize, WildCard);
            return __ret;
        }

        public static bool FillEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, byte* FillByte)
        {
            var __ret = __Internal.FillEx(hProcess, MemoryStart, MemorySize, FillByte);
            return __ret;
        }

        public static bool Fill(__IntPtr MemoryStart, uint MemorySize, byte* FillByte)
        {
            var __ret = __Internal.Fill(MemoryStart, MemorySize, FillByte);
            return __ret;
        }

        public static bool PatchEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, __IntPtr ReplacePattern, uint ReplaceSize, bool AppendNOP, bool PrependNOP)
        {
            var __ret = __Internal.PatchEx(hProcess, MemoryStart, MemorySize, ReplacePattern, ReplaceSize, AppendNOP, PrependNOP);
            return __ret;
        }

        public static bool Patch(__IntPtr MemoryStart, uint MemorySize, __IntPtr ReplacePattern, uint ReplaceSize, bool AppendNOP, bool PrependNOP)
        {
            var __ret = __Internal.Patch(MemoryStart, MemorySize, ReplacePattern, ReplaceSize, AppendNOP, PrependNOP);
            return __ret;
        }

        public static bool ReplaceEx(__IntPtr hProcess, __IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, uint NumberOfRepetitions, __IntPtr ReplacePattern, uint ReplaceSize, byte* WildCard)
        {
            var __ret = __Internal.ReplaceEx(hProcess, MemoryStart, MemorySize, SearchPattern, PatternSize, NumberOfRepetitions, ReplacePattern, ReplaceSize, WildCard);
            return __ret;
        }

        public static bool Replace(__IntPtr MemoryStart, uint MemorySize, __IntPtr SearchPattern, uint PatternSize, uint NumberOfRepetitions, __IntPtr ReplacePattern, uint ReplaceSize, byte* WildCard)
        {
            var __ret = __Internal.Replace(MemoryStart, MemorySize, SearchPattern, PatternSize, NumberOfRepetitions, ReplacePattern, ReplaceSize, WildCard);
            return __ret;
        }

        public static __IntPtr GetDebugData()
        {
            var __ret = __Internal.GetDebugData();
            return __ret;
        }

        public static __IntPtr GetTerminationData()
        {
            var __ret = __Internal.GetTerminationData();
            return __ret;
        }

        public static int GetExitCode()
        {
            var __ret = __Internal.GetExitCode();
            return __ret;
        }

        public static ulong GetDebuggedDLLBaseAddress()
        {
            var __ret = __Internal.GetDebuggedDLLBaseAddress();
            return __ret;
        }

        public static ulong GetDebuggedFileBaseAddress()
        {
            var __ret = __Internal.GetDebuggedFileBaseAddress();
            return __ret;
        }

        public static bool GetRemoteString(__IntPtr hProcess, __IntPtr StringAddress, __IntPtr StringStorage, int MaximumStringSize)
        {
            var __ret = __Internal.GetRemoteString(hProcess, StringAddress, StringStorage, MaximumStringSize);
            return __ret;
        }

        public static ulong GetFunctionParameter(__IntPtr hProcess, uint FunctionType, uint ParameterNumber, uint ParameterType)
        {
            var __ret = __Internal.GetFunctionParameter(hProcess, FunctionType, ParameterNumber, ParameterType);
            return __ret;
        }

        public static ulong GetJumpDestinationEx(__IntPtr hProcess, ulong InstructionAddress, bool JustJumps)
        {
            var __ret = __Internal.GetJumpDestinationEx(hProcess, InstructionAddress, JustJumps);
            return __ret;
        }

        public static ulong GetJumpDestination(__IntPtr hProcess, ulong InstructionAddress)
        {
            var __ret = __Internal.GetJumpDestination(hProcess, InstructionAddress);
            return __ret;
        }

        public static bool IsJumpGoingToExecuteEx(__IntPtr hProcess, __IntPtr hThread, ulong InstructionAddress, ulong RegFlags)
        {
            var __ret = __Internal.IsJumpGoingToExecuteEx(hProcess, hThread, InstructionAddress, RegFlags);
            return __ret;
        }

        public static bool IsJumpGoingToExecute()
        {
            var __ret = __Internal.IsJumpGoingToExecute();
            return __ret;
        }

        public static void SetCustomHandler(uint ExceptionId, __IntPtr CallBack)
        {
            __Internal.SetCustomHandler(ExceptionId, CallBack);
        }

        public static void ForceClose()
        {
            __Internal.ForceClose();
        }

        public static void StepInto(__IntPtr traceCallBack)
        {
            __Internal.StepInto(traceCallBack);
        }

        public static void StepOver(__IntPtr traceCallBack)
        {
            __Internal.StepOver(traceCallBack);
        }

        public static void StepOut(__IntPtr StepOut, bool StepFinal)
        {
            __Internal.StepOut(StepOut, StepFinal);
        }

        public static void SingleStep(uint StepCount, __IntPtr StepCallBack)
        {
            __Internal.SingleStep(StepCount, StepCallBack);
        }

        public static bool GetUnusedHardwareBreakPointRegister(ref uint RegisterIndex)
        {
            fixed (uint* __RegisterIndex0 = &RegisterIndex)
            {
                var __arg0 = __RegisterIndex0;
                var __ret = __Internal.GetUnusedHardwareBreakPointRegister(__arg0);
                return __ret;
            }
        }

        public static bool SetHardwareBreakPointEx(__IntPtr hActiveThread, ulong bpxAddress, uint IndexOfRegister, uint bpxType, uint bpxSize, __IntPtr bpxCallBack, ref uint IndexOfSelectedRegister)
        {
            fixed (uint* __IndexOfSelectedRegister6 = &IndexOfSelectedRegister)
            {
                var __arg6 = __IndexOfSelectedRegister6;
                var __ret = __Internal.SetHardwareBreakPointEx(hActiveThread, bpxAddress, IndexOfRegister, bpxType, bpxSize, bpxCallBack, __arg6);
                return __ret;
            }
        }

        public static bool SetHardwareBreakPoint(ulong bpxAddress, uint IndexOfRegister, uint bpxType, uint bpxSize, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.SetHardwareBreakPoint(bpxAddress, IndexOfRegister, bpxType, bpxSize, bpxCallBack);
            return __ret;
        }

        public static bool DeleteHardwareBreakPoint(uint IndexOfRegister)
        {
            var __ret = __Internal.DeleteHardwareBreakPoint(IndexOfRegister);
            return __ret;
        }

        public static bool RemoveAllBreakPoints(uint RemoveOption)
        {
            var __ret = __Internal.RemoveAllBreakPoints(RemoveOption);
            return __ret;
        }

        public static void DebugLoop()
        {
            __Internal.DebugLoop();
        }

        public static void SetDebugLoopTimeOut(uint TimeOut)
        {
            __Internal.SetDebugLoopTimeOut(TimeOut);
        }

        public static void SetNextDbgContinueStatus(uint SetDbgCode)
        {
            __Internal.SetNextDbgContinueStatus(SetDbgCode);
        }

        public static bool AttachDebugger(uint ProcessId, bool KillOnExit, __IntPtr DebugInfo, __IntPtr CallBack)
        {
            var __ret = __Internal.AttachDebugger(ProcessId, KillOnExit, DebugInfo, CallBack);
            return __ret;
        }

        public static bool DetachDebugger(uint ProcessId)
        {
            var __ret = __Internal.DetachDebugger(ProcessId);
            return __ret;
        }

        public static bool DetachDebuggerEx(uint ProcessId)
        {
            var __ret = __Internal.DetachDebuggerEx(ProcessId);
            return __ret;
        }

        public static void DebugLoopEx(uint TimeOut)
        {
            __Internal.DebugLoopEx(TimeOut);
        }

        public static void AutoDebugEx(sbyte* szFileName, bool ReserveModuleBase, sbyte* szCommandLine, sbyte* szCurrentFolder, uint TimeOut, __IntPtr EntryCallBack)
        {
            __Internal.AutoDebugEx(szFileName, ReserveModuleBase, szCommandLine, szCurrentFolder, TimeOut, EntryCallBack);
        }

        public static void AutoDebugExW(char* szFileName, bool ReserveModuleBase, char* szCommandLine, char* szCurrentFolder, uint TimeOut, __IntPtr EntryCallBack)
        {
            __Internal.AutoDebugExW(szFileName, ReserveModuleBase, szCommandLine, szCurrentFolder, TimeOut, EntryCallBack);
        }

        public static bool IsFileBeingDebugged()
        {
            var __ret = __Internal.IsFileBeingDebugged();
            return __ret;
        }

        public static void SetErrorModel(bool DisplayErrorMessages)
        {
            __Internal.SetErrorModel(DisplayErrorMessages);
        }

        public static void FindOEPInit()
        {
            __Internal.FindOEPInit();
        }

        public static bool FindOEPGenerically(sbyte* szFileName, __IntPtr TraceInitCallBack, __IntPtr CallBack)
        {
            var __ret = __Internal.FindOEPGenerically(szFileName, TraceInitCallBack, CallBack);
            return __ret;
        }

        public static bool FindOEPGenericallyW(char* szFileName, __IntPtr TraceInitCallBack, __IntPtr CallBack)
        {
            var __ret = __Internal.FindOEPGenericallyW(szFileName, TraceInitCallBack, CallBack);
            return __ret;
        }

        public static void ImporterAddNewDll(sbyte* szDLLName, ulong FirstThunk)
        {
            __Internal.ImporterAddNewDll(szDLLName, FirstThunk);
        }

        public static void ImporterAddNewAPI(sbyte* szAPIName, ulong ThunkValue)
        {
            __Internal.ImporterAddNewAPI(szAPIName, ThunkValue);
        }

        public static void ImporterAddNewOrdinalAPI(ulong OrdinalNumber, ulong ThunkValue)
        {
            __Internal.ImporterAddNewOrdinalAPI(OrdinalNumber, ThunkValue);
        }

        public static int ImporterGetAddedDllCount()
        {
            var __ret = __Internal.ImporterGetAddedDllCount();
            return __ret;
        }

        public static int ImporterGetAddedAPICount()
        {
            var __ret = __Internal.ImporterGetAddedAPICount();
            return __ret;
        }

        public static bool ImporterExportIAT(ulong StorePlace, ulong FileMapVA, __IntPtr hFileMap)
        {
            var __ret = __Internal.ImporterExportIAT(StorePlace, FileMapVA, hFileMap);
            return __ret;
        }

        public static int ImporterEstimatedSize()
        {
            var __ret = __Internal.ImporterEstimatedSize();
            return __ret;
        }

        public static bool ImporterExportIATEx(sbyte* szDumpFileName, sbyte* szExportFileName, sbyte* szSectionName)
        {
            var __ret = __Internal.ImporterExportIATEx(szDumpFileName, szExportFileName, szSectionName);
            return __ret;
        }

        public static bool ImporterExportIATExW(char* szDumpFileName, char* szExportFileName, string szSectionName = ".RL!TEv2")
        {
            unsafe
            {
                fixed (char* arg3 = szSectionName)
                {
                    var __ret = __Internal.ImporterExportIATExW(szDumpFileName, szExportFileName, arg3);
                    return __ret;
                }
            }
        }

        public static ulong ImporterFindAPIWriteLocation(sbyte* szAPIName)
        {
            var __ret = __Internal.ImporterFindAPIWriteLocation(szAPIName);
            return __ret;
        }

        public static ulong ImporterFindOrdinalAPIWriteLocation(ulong OrdinalNumber)
        {
            var __ret = __Internal.ImporterFindOrdinalAPIWriteLocation(OrdinalNumber);
            return __ret;
        }

        public static ulong ImporterFindAPIByWriteLocation(ulong APIWriteLocation)
        {
            var __ret = __Internal.ImporterFindAPIByWriteLocation(APIWriteLocation);
            return __ret;
        }

        public static ulong ImporterFindDLLByWriteLocation(ulong APIWriteLocation)
        {
            var __ret = __Internal.ImporterFindDLLByWriteLocation(APIWriteLocation);
            return __ret;
        }

        public static __IntPtr ImporterGetDLLName(ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetDLLName(APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetDLLNameW(ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetDLLNameW(APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetAPIName(ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetAPIName(APIAddress);
            return __ret;
        }

        public static ulong ImporterGetAPIOrdinalNumber(ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetAPIOrdinalNumber(APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetAPINameEx(ulong APIAddress, ulong DLLBasesList)
        {
            var __ret = __Internal.ImporterGetAPINameEx(APIAddress, DLLBasesList);
            return __ret;
        }

        public static ulong ImporterGetRemoteAPIAddress(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetRemoteAPIAddress(hProcess, APIAddress);
            return __ret;
        }

        public static ulong ImporterGetRemoteAPIAddressEx(sbyte* szDLLName, sbyte* szAPIName)
        {
            var __ret = __Internal.ImporterGetRemoteAPIAddressEx(szDLLName, szAPIName);
            return __ret;
        }

        public static ulong ImporterGetLocalAPIAddress(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetLocalAPIAddress(hProcess, APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetDLLNameFromDebugee(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetDLLNameFromDebugee(hProcess, APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetDLLNameFromDebugeeW(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetDLLNameFromDebugeeW(hProcess, APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetAPINameFromDebugee(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetAPINameFromDebugee(hProcess, APIAddress);
            return __ret;
        }

        public static ulong ImporterGetAPIOrdinalNumberFromDebugee(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetAPIOrdinalNumberFromDebugee(hProcess, APIAddress);
            return __ret;
        }

        public static int ImporterGetDLLIndexEx(ulong APIAddress, ulong DLLBasesList)
        {
            var __ret = __Internal.ImporterGetDLLIndexEx(APIAddress, DLLBasesList);
            return __ret;
        }

        public static int ImporterGetDLLIndex(__IntPtr hProcess, ulong APIAddress, ulong DLLBasesList)
        {
            var __ret = __Internal.ImporterGetDLLIndex(hProcess, APIAddress, DLLBasesList);
            return __ret;
        }

        public static ulong ImporterGetRemoteDLLBaseEx(__IntPtr hProcess, sbyte* szModuleName)
        {
            var __ret = __Internal.ImporterGetRemoteDLLBaseEx(hProcess, szModuleName);
            return __ret;
        }

        public static __IntPtr ImporterGetRemoteDLLBaseExW(__IntPtr hProcess, char* szModuleName)
        {
            var __ret = __Internal.ImporterGetRemoteDLLBaseExW(hProcess, szModuleName);
            return __ret;
        }

        public static bool ImporterIsForwardedAPI(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterIsForwardedAPI(hProcess, APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetForwardedAPIName(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetForwardedAPIName(hProcess, APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetForwardedDLLName(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetForwardedDLLName(hProcess, APIAddress);
            return __ret;
        }

        public static int ImporterGetForwardedDLLIndex(__IntPtr hProcess, ulong APIAddress, ulong DLLBasesList)
        {
            var __ret = __Internal.ImporterGetForwardedDLLIndex(hProcess, APIAddress, DLLBasesList);
            return __ret;
        }

        public static ulong ImporterGetForwardedAPIOrdinalNumber(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetForwardedAPIOrdinalNumber(hProcess, APIAddress);
            return __ret;
        }

        public static ulong ImporterGetNearestAPIAddress(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetNearestAPIAddress(hProcess, APIAddress);
            return __ret;
        }

        public static __IntPtr ImporterGetNearestAPIName(__IntPtr hProcess, ulong APIAddress)
        {
            var __ret = __Internal.ImporterGetNearestAPIName(hProcess, APIAddress);
            return __ret;
        }

        public static bool ImporterCopyOriginalIAT(sbyte* szOriginalFile, sbyte* szDumpFile)
        {
            var __ret = __Internal.ImporterCopyOriginalIAT(szOriginalFile, szDumpFile);
            return __ret;
        }

        public static bool ImporterCopyOriginalIATW(char* szOriginalFile, char* szDumpFile)
        {
            var __ret = __Internal.ImporterCopyOriginalIATW(szOriginalFile, szDumpFile);
            return __ret;
        }

        public static bool ImporterLoadImportTable(sbyte* szFileName)
        {
            var __ret = __Internal.ImporterLoadImportTable(szFileName);
            return __ret;
        }

        public static bool ImporterLoadImportTableW(char* szFileName)
        {
            var __ret = __Internal.ImporterLoadImportTableW(szFileName);
            return __ret;
        }

        public static bool ImporterMoveOriginalIAT(sbyte* szOriginalFile, sbyte* szDumpFile, sbyte* szSectionName)
        {
            var __ret = __Internal.ImporterMoveOriginalIAT(szOriginalFile, szDumpFile, szSectionName);
            return __ret;
        }

        public static bool ImporterMoveOriginalIATW(char* szOriginalFile, char* szDumpFile, sbyte* szSectionName)
        {
            var __ret = __Internal.ImporterMoveOriginalIATW(szOriginalFile, szDumpFile, szSectionName);
            return __ret;
        }

        public static void ImporterAutoSearchIAT(uint ProcessId, sbyte* szFileName, ulong SearchStart, __IntPtr pIATStart, __IntPtr pIATSize)
        {
            __Internal.ImporterAutoSearchIAT(ProcessId, szFileName, SearchStart, pIATStart, pIATSize);
        }

        public static void ImporterAutoSearchIATW(uint ProcessIds, char* szFileName, ulong SearchStart, __IntPtr pIATStart, __IntPtr pIATSize)
        {
            __Internal.ImporterAutoSearchIATW(ProcessIds, szFileName, SearchStart, pIATStart, pIATSize);
        }

        public static void ImporterAutoSearchIATEx(uint ProcessId, ulong ImageBase, ulong SearchStart, __IntPtr pIATStart, __IntPtr pIATSize)
        {
            __Internal.ImporterAutoSearchIATEx(ProcessId, ImageBase, SearchStart, pIATStart, pIATSize);
        }

        public static void ImporterEnumAddedData(__IntPtr EnumCallBack)
        {
            __Internal.ImporterEnumAddedData(EnumCallBack);
        }

        public static int ImporterAutoFixIATEx(uint ProcessId, sbyte* szDumpedFile, sbyte* szSectionName, bool DumpRunningProcess, bool RealignFile, ulong EntryPointAddress, ulong ImageBase, ulong SearchStart, bool TryAutoFix, bool FixEliminations, __IntPtr UnknownPointerFixCallback)
        {
            var __ret = __Internal.ImporterAutoFixIATEx(ProcessId, szDumpedFile, szSectionName, DumpRunningProcess, RealignFile, EntryPointAddress, ImageBase, SearchStart, TryAutoFix, FixEliminations, UnknownPointerFixCallback);
            return __ret;
        }

        public static int ImporterAutoFixIATExW(uint ProcessId, char* szDumpedFile, sbyte* szSectionName, bool DumpRunningProcess, bool RealignFile, ulong EntryPointAddress, ulong ImageBase, ulong SearchStart, bool TryAutoFix, bool FixEliminations, __IntPtr UnknownPointerFixCallback)
        {
            var __ret = __Internal.ImporterAutoFixIATExW(ProcessId, szDumpedFile, szSectionName, DumpRunningProcess, RealignFile, EntryPointAddress, ImageBase, SearchStart, TryAutoFix, FixEliminations, UnknownPointerFixCallback);
            return __ret;
        }

        public static int ImporterAutoFixIAT(uint ProcessId, sbyte* szDumpedFile, ulong SearchStart)
        {
            var __ret = __Internal.ImporterAutoFixIAT(ProcessId, szDumpedFile, SearchStart);
            return __ret;
        }

        public static int ImporterAutoFixIATW(uint ProcessId, char* szDumpedFile, ulong SearchStart)
        {
            var __ret = __Internal.ImporterAutoFixIATW(ProcessId, szDumpedFile, SearchStart);
            return __ret;
        }

        public static bool ImporterDeleteAPI(ulong apiAddr)
        {
            var __ret = __Internal.ImporterDeleteAPI(apiAddr);
            return __ret;
        }

        public static bool HooksSafeTransitionEx(__IntPtr HookAddressArray, int NumberOfHooks, bool TransitionStart)
        {
            var __ret = __Internal.HooksSafeTransitionEx(HookAddressArray, NumberOfHooks, TransitionStart);
            return __ret;
        }

        public static bool HooksSafeTransition(__IntPtr HookAddress, bool TransitionStart)
        {
            var __ret = __Internal.HooksSafeTransition(HookAddress, TransitionStart);
            return __ret;
        }

        public static bool HooksIsAddressRedirected(__IntPtr HookAddress)
        {
            var __ret = __Internal.HooksIsAddressRedirected(HookAddress);
            return __ret;
        }

        public static __IntPtr HooksGetTrampolineAddress(__IntPtr HookAddress)
        {
            var __ret = __Internal.HooksGetTrampolineAddress(HookAddress);
            return __ret;
        }

        public static __IntPtr HooksGetHookEntryDetails(__IntPtr HookAddress)
        {
            var __ret = __Internal.HooksGetHookEntryDetails(HookAddress);
            return __ret;
        }

        public static bool HooksInsertNewRedirection(__IntPtr HookAddress, __IntPtr RedirectTo, int HookType)
        {
            var __ret = __Internal.HooksInsertNewRedirection(HookAddress, RedirectTo, HookType);
            return __ret;
        }

        public static bool HooksInsertNewIATRedirectionEx(ulong FileMapVA, ulong LoadedModuleBase, sbyte* szHookFunction, __IntPtr RedirectTo)
        {
            var __ret = __Internal.HooksInsertNewIATRedirectionEx(FileMapVA, LoadedModuleBase, szHookFunction, RedirectTo);
            return __ret;
        }

        public static bool HooksInsertNewIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, __IntPtr RedirectTo)
        {
            var __ret = __Internal.HooksInsertNewIATRedirection(szModuleName, szHookFunction, RedirectTo);
            return __ret;
        }

        public static bool HooksRemoveRedirection(__IntPtr HookAddress, bool RemoveAll)
        {
            var __ret = __Internal.HooksRemoveRedirection(HookAddress, RemoveAll);
            return __ret;
        }

        public static bool HooksRemoveIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, bool RemoveAll)
        {
            var __ret = __Internal.HooksRemoveIATRedirection(szModuleName, szHookFunction, RemoveAll);
            return __ret;
        }

        public static bool HooksDisableRedirection(__IntPtr HookAddress, bool DisableAll)
        {
            var __ret = __Internal.HooksDisableRedirection(HookAddress, DisableAll);
            return __ret;
        }

        public static bool HooksDisableIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, bool DisableAll)
        {
            var __ret = __Internal.HooksDisableIATRedirection(szModuleName, szHookFunction, DisableAll);
            return __ret;
        }

        public static bool HooksEnableRedirection(__IntPtr HookAddress, bool EnableAll)
        {
            var __ret = __Internal.HooksEnableRedirection(HookAddress, EnableAll);
            return __ret;
        }

        public static bool HooksEnableIATRedirection(sbyte* szModuleName, sbyte* szHookFunction, bool EnableAll)
        {
            var __ret = __Internal.HooksEnableIATRedirection(szModuleName, szHookFunction, EnableAll);
            return __ret;
        }

        public static void HooksScanEntireProcessMemory(__IntPtr CallBack)
        {
            __Internal.HooksScanEntireProcessMemory(CallBack);
        }

        public static void HooksScanEntireProcessMemoryEx()
        {
            __Internal.HooksScanEntireProcessMemoryEx();
        }

        public static void TracerInit()
        {
            __Internal.TracerInit();
        }

        public static ulong TracerLevel1(__IntPtr hProcess, ulong AddressToTrace)
        {
            var __ret = __Internal.TracerLevel1(hProcess, AddressToTrace);
            return __ret;
        }

        public static ulong HashTracerLevel1(__IntPtr hProcess, ulong AddressToTrace, uint InputNumberOfInstructions)
        {
            var __ret = __Internal.HashTracerLevel1(hProcess, AddressToTrace, InputNumberOfInstructions);
            return __ret;
        }

        public static int TracerDetectRedirection(__IntPtr hProcess, ulong AddressToTrace)
        {
            var __ret = __Internal.TracerDetectRedirection(hProcess, AddressToTrace);
            return __ret;
        }

        public static ulong TracerFixKnownRedirection(__IntPtr hProcess, ulong AddressToTrace, uint RedirectionId)
        {
            var __ret = __Internal.TracerFixKnownRedirection(hProcess, AddressToTrace, RedirectionId);
            return __ret;
        }

        public static int TracerFixRedirectionViaImpRecPlugin(__IntPtr hProcess, sbyte* szPluginName, ulong AddressToTrace)
        {
            var __ret = __Internal.TracerFixRedirectionViaImpRecPlugin(hProcess, szPluginName, AddressToTrace);
            return __ret;
        }

        public static void ExporterCleanup()
        {
            __Internal.ExporterCleanup();
        }

        public static void ExporterSetImageBase(ulong ImageBase)
        {
            __Internal.ExporterSetImageBase(ImageBase);
        }

        public static void ExporterInit(uint MemorySize, ulong ImageBase, uint ExportOrdinalBase, sbyte* szExportModuleName)
        {
            __Internal.ExporterInit(MemorySize, ImageBase, ExportOrdinalBase, szExportModuleName);
        }

        public static bool ExporterAddNewExport(sbyte* szExportName, uint ExportRelativeAddress)
        {
            var __ret = __Internal.ExporterAddNewExport(szExportName, ExportRelativeAddress);
            return __ret;
        }

        public static bool ExporterAddNewOrdinalExport(uint OrdinalNumber, uint ExportRelativeAddress)
        {
            var __ret = __Internal.ExporterAddNewOrdinalExport(OrdinalNumber, ExportRelativeAddress);
            return __ret;
        }

        public static int ExporterGetAddedExportCount()
        {
            var __ret = __Internal.ExporterGetAddedExportCount();
            return __ret;
        }

        public static int ExporterEstimatedSize()
        {
            var __ret = __Internal.ExporterEstimatedSize();
            return __ret;
        }

        public static bool ExporterBuildExportTable(ulong StorePlace, ulong FileMapVA)
        {
            var __ret = __Internal.ExporterBuildExportTable(StorePlace, FileMapVA);
            return __ret;
        }

        public static bool ExporterBuildExportTableEx(sbyte* szExportFileName, sbyte* szSectionName)
        {
            var __ret = __Internal.ExporterBuildExportTableEx(szExportFileName, szSectionName);
            return __ret;
        }

        public static bool ExporterBuildExportTableExW(char* szExportFileName, sbyte* szSectionName)
        {
            var __ret = __Internal.ExporterBuildExportTableExW(szExportFileName, szSectionName);
            return __ret;
        }

        public static bool ExporterLoadExportTable(sbyte* szFileName)
        {
            var __ret = __Internal.ExporterLoadExportTable(szFileName);
            return __ret;
        }

        public static bool ExporterLoadExportTableW(char* szFileName)
        {
            var __ret = __Internal.ExporterLoadExportTableW(szFileName);
            return __ret;
        }

        public static bool LibrarianSetBreakPoint(sbyte* szLibraryName, uint bpxType, bool SingleShoot, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.LibrarianSetBreakPoint(szLibraryName, bpxType, SingleShoot, bpxCallBack);
            return __ret;
        }

        public static bool LibrarianRemoveBreakPoint(sbyte* szLibraryName, uint bpxType)
        {
            var __ret = __Internal.LibrarianRemoveBreakPoint(szLibraryName, bpxType);
            return __ret;
        }

        public static __IntPtr LibrarianGetLibraryInfo(sbyte* szLibraryName)
        {
            var __ret = __Internal.LibrarianGetLibraryInfo(szLibraryName);
            return __ret;
        }

        public static __IntPtr LibrarianGetLibraryInfoW(char* szLibraryName)
        {
            var __ret = __Internal.LibrarianGetLibraryInfoW(szLibraryName);
            return __ret;
        }

        public static __IntPtr LibrarianGetLibraryInfoEx(__IntPtr BaseOfDll)
        {
            var __ret = __Internal.LibrarianGetLibraryInfoEx(BaseOfDll);
            return __ret;
        }

        public static __IntPtr LibrarianGetLibraryInfoExW(__IntPtr BaseOfDll)
        {
            var __ret = __Internal.LibrarianGetLibraryInfoExW(BaseOfDll);
            return __ret;
        }

        public static void LibrarianEnumLibraryInfo(__IntPtr EnumCallBack)
        {
            __Internal.LibrarianEnumLibraryInfo(EnumCallBack);
        }

        public static void LibrarianEnumLibraryInfoW(__IntPtr EnumCallBack)
        {
            __Internal.LibrarianEnumLibraryInfoW(EnumCallBack);
        }

        public static int GetActiveProcessId(sbyte* szImageName)
        {
            var __ret = __Internal.GetActiveProcessId(szImageName);
            return __ret;
        }

        public static int GetActiveProcessIdW(char* szImageName)
        {
            var __ret = __Internal.GetActiveProcessIdW(szImageName);
            return __ret;
        }

        public static void EnumProcessesWithLibrary(sbyte* szLibraryName, __IntPtr EnumFunction)
        {
            __Internal.EnumProcessesWithLibrary(szLibraryName, EnumFunction);
        }

        public static __IntPtr TitanOpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId)
        {
            var __ret = __Internal.TitanOpenProcess(dwDesiredAccess, bInheritHandle, dwProcessId);
            return __ret;
        }

        public static __IntPtr TitanOpenThread(uint dwDesiredAccess, bool bInheritHandle, uint dwThreadId)
        {
            var __ret = __Internal.TitanOpenThread(dwDesiredAccess, bInheritHandle, dwThreadId);
            return __ret;
        }

        public static bool TLSBreakOnCallBack(__IntPtr ArrayOfCallBacks, uint NumberOfCallBacks, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.TLSBreakOnCallBack(ArrayOfCallBacks, NumberOfCallBacks, bpxCallBack);
            return __ret;
        }

        public static bool TLSGrabCallBackData(sbyte* szFileName, __IntPtr ArrayOfCallBacks, ref uint NumberOfCallBacks)
        {
            fixed (uint* __NumberOfCallBacks2 = &NumberOfCallBacks)
            {
                var __arg2 = __NumberOfCallBacks2;
                var __ret = __Internal.TLSGrabCallBackData(szFileName, ArrayOfCallBacks, __arg2);
                return __ret;
            }
        }

        public static bool TLSGrabCallBackDataW(char* szFileName, __IntPtr ArrayOfCallBacks, ref uint NumberOfCallBacks)
        {
            fixed (uint* __NumberOfCallBacks2 = &NumberOfCallBacks)
            {
                var __arg2 = __NumberOfCallBacks2;
                var __ret = __Internal.TLSGrabCallBackDataW(szFileName, ArrayOfCallBacks, __arg2);
                return __ret;
            }
        }

        public static bool TLSBreakOnCallBackEx(sbyte* szFileName, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.TLSBreakOnCallBackEx(szFileName, bpxCallBack);
            return __ret;
        }

        public static bool TLSBreakOnCallBackExW(char* szFileName, __IntPtr bpxCallBack)
        {
            var __ret = __Internal.TLSBreakOnCallBackExW(szFileName, bpxCallBack);
            return __ret;
        }

        public static bool TLSRemoveCallback(sbyte* szFileName)
        {
            var __ret = __Internal.TLSRemoveCallback(szFileName);
            return __ret;
        }

        public static bool TLSRemoveCallbackW(char* szFileName)
        {
            var __ret = __Internal.TLSRemoveCallbackW(szFileName);
            return __ret;
        }

        public static bool TLSRemoveTable(sbyte* szFileName)
        {
            var __ret = __Internal.TLSRemoveTable(szFileName);
            return __ret;
        }

        public static bool TLSRemoveTableW(char* szFileName)
        {
            var __ret = __Internal.TLSRemoveTableW(szFileName);
            return __ret;
        }

        public static bool TLSBackupData(sbyte* szFileName)
        {
            var __ret = __Internal.TLSBackupData(szFileName);
            return __ret;
        }

        public static bool TLSBackupDataW(char* szFileName)
        {
            var __ret = __Internal.TLSBackupDataW(szFileName);
            return __ret;
        }

        public static bool TLSRestoreData()
        {
            var __ret = __Internal.TLSRestoreData();
            return __ret;
        }

        public static bool TLSBuildNewTable(ulong FileMapVA, ulong StorePlace, ulong StorePlaceRVA, __IntPtr ArrayOfCallBacks, uint NumberOfCallBacks)
        {
            var __ret = __Internal.TLSBuildNewTable(FileMapVA, StorePlace, StorePlaceRVA, ArrayOfCallBacks, NumberOfCallBacks);
            return __ret;
        }

        public static bool TLSBuildNewTableEx(sbyte* szFileName, sbyte* szSectionName, __IntPtr ArrayOfCallBacks, uint NumberOfCallBacks)
        {
            var __ret = __Internal.TLSBuildNewTableEx(szFileName, szSectionName, ArrayOfCallBacks, NumberOfCallBacks);
            return __ret;
        }

        public static bool TLSBuildNewTableExW(char* szFileName, sbyte* szSectionName, __IntPtr ArrayOfCallBacks, uint NumberOfCallBacks)
        {
            var __ret = __Internal.TLSBuildNewTableExW(szFileName, szSectionName, ArrayOfCallBacks, NumberOfCallBacks);
            return __ret;
        }

        public static __IntPtr TranslateNativeName(sbyte* szNativeName)
        {
            var __ret = __Internal.TranslateNativeName(szNativeName);
            return __ret;
        }

        public static __IntPtr TranslateNativeNameW(char* szNativeName)
        {
            var __ret = __Internal.TranslateNativeNameW(szNativeName);
            return __ret;
        }

        public static int HandlerGetActiveHandleCount(uint ProcessId)
        {
            var __ret = __Internal.HandlerGetActiveHandleCount(ProcessId);
            return __ret;
        }

        public static bool HandlerIsHandleOpen(uint ProcessId, __IntPtr hHandle)
        {
            var __ret = __Internal.HandlerIsHandleOpen(ProcessId, hHandle);
            return __ret;
        }

        public static __IntPtr HandlerGetHandleName(__IntPtr hProcess, uint ProcessId, __IntPtr hHandle, bool TranslateName)
        {
            var __ret = __Internal.HandlerGetHandleName(hProcess, ProcessId, hHandle, TranslateName);
            return __ret;
        }

        public static __IntPtr HandlerGetHandleNameW(__IntPtr hProcess, uint ProcessId, __IntPtr hHandle, bool TranslateName)
        {
            var __ret = __Internal.HandlerGetHandleNameW(hProcess, ProcessId, hHandle, TranslateName);
            return __ret;
        }

        public static int HandlerEnumerateOpenHandles(uint ProcessId, __IntPtr HandleBuffer, uint MaxHandleCount)
        {
            var __ret = __Internal.HandlerEnumerateOpenHandles(ProcessId, HandleBuffer, MaxHandleCount);
            return __ret;
        }

        public static ulong HandlerGetHandleDetails(__IntPtr hProcess, uint ProcessId, __IntPtr hHandle, uint InformationReturn)
        {
            var __ret = __Internal.HandlerGetHandleDetails(hProcess, ProcessId, hHandle, InformationReturn);
            return __ret;
        }

        public static bool HandlerCloseRemoteHandle(__IntPtr hProcess, __IntPtr hHandle)
        {
            var __ret = __Internal.HandlerCloseRemoteHandle(hProcess, hHandle);
            return __ret;
        }

        public static int HandlerEnumerateLockHandles(sbyte* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated, __IntPtr HandleDataBuffer, uint MaxHandleCount)
        {
            var __ret = __Internal.HandlerEnumerateLockHandles(szFileOrFolderName, NameIsFolder, NameIsTranslated, HandleDataBuffer, MaxHandleCount);
            return __ret;
        }

        public static int HandlerEnumerateLockHandlesW(char* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated, __IntPtr HandleDataBuffer, uint MaxHandleCount)
        {
            var __ret = __Internal.HandlerEnumerateLockHandlesW(szFileOrFolderName, NameIsFolder, NameIsTranslated, HandleDataBuffer, MaxHandleCount);
            return __ret;
        }

        public static bool HandlerCloseAllLockHandles(sbyte* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated)
        {
            var __ret = __Internal.HandlerCloseAllLockHandles(szFileOrFolderName, NameIsFolder, NameIsTranslated);
            return __ret;
        }

        public static bool HandlerCloseAllLockHandlesW(char* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated)
        {
            var __ret = __Internal.HandlerCloseAllLockHandlesW(szFileOrFolderName, NameIsFolder, NameIsTranslated);
            return __ret;
        }

        public static bool HandlerIsFileLocked(sbyte* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated)
        {
            var __ret = __Internal.HandlerIsFileLocked(szFileOrFolderName, NameIsFolder, NameIsTranslated);
            return __ret;
        }

        public static bool HandlerIsFileLockedW(char* szFileOrFolderName, bool NameIsFolder, bool NameIsTranslated)
        {
            var __ret = __Internal.HandlerIsFileLockedW(szFileOrFolderName, NameIsFolder, NameIsTranslated);
            return __ret;
        }

        public static int HandlerEnumerateOpenMutexes(__IntPtr hProcess, uint ProcessId, __IntPtr HandleBuffer, uint MaxHandleCount)
        {
            var __ret = __Internal.HandlerEnumerateOpenMutexes(hProcess, ProcessId, HandleBuffer, MaxHandleCount);
            return __ret;
        }

        public static ulong HandlerGetOpenMutexHandle(__IntPtr hProcess, uint ProcessId, sbyte* szMutexString)
        {
            var __ret = __Internal.HandlerGetOpenMutexHandle(hProcess, ProcessId, szMutexString);
            return __ret;
        }

        public static ulong HandlerGetOpenMutexHandleW(__IntPtr hProcess, uint ProcessId, char* szMutexString)
        {
            var __ret = __Internal.HandlerGetOpenMutexHandleW(hProcess, ProcessId, szMutexString);
            return __ret;
        }

        public static int HandlerGetProcessIdWhichCreatedMutex(sbyte* szMutexString)
        {
            var __ret = __Internal.HandlerGetProcessIdWhichCreatedMutex(szMutexString);
            return __ret;
        }

        public static int HandlerGetProcessIdWhichCreatedMutexW(char* szMutexString)
        {
            var __ret = __Internal.HandlerGetProcessIdWhichCreatedMutexW(szMutexString);
            return __ret;
        }

        public static bool RemoteLoadLibrary(__IntPtr hProcess, sbyte* szLibraryFile, bool WaitForThreadExit)
        {
            var __ret = __Internal.RemoteLoadLibrary(hProcess, szLibraryFile, WaitForThreadExit);
            return __ret;
        }

        public static bool RemoteLoadLibraryW(__IntPtr hProcess, char* szLibraryFile, bool WaitForThreadExit)
        {
            var __ret = __Internal.RemoteLoadLibraryW(hProcess, szLibraryFile, WaitForThreadExit);
            return __ret;
        }

        public static bool RemoteExitProcess(__IntPtr hProcess, uint ExitCode)
        {
            var __ret = __Internal.RemoteExitProcess(hProcess, ExitCode);
            return __ret;
        }

        public static bool StaticFileLoad(sbyte* szFileName, uint DesiredAccess, bool SimulateLoad, __IntPtr* FileHandle, ref uint LoadedSize, __IntPtr* FileMap, ref ulong FileMapVA)
        {
            fixed (uint* __LoadedSize4 = &LoadedSize)
            {
                var __arg4 = __LoadedSize4;
                fixed (ulong* __FileMapVA6 = &FileMapVA)
                {
                    var __arg6 = __FileMapVA6;
                    var __ret = __Internal.StaticFileLoad(szFileName, DesiredAccess, SimulateLoad, FileHandle, __arg4, FileMap, __arg6);
                    return __ret;
                }
            }
        }

        public static bool StaticFileLoadW(char* szFileName, uint DesiredAccess, bool SimulateLoad, __IntPtr* FileHandle, ref uint LoadedSize, __IntPtr* FileMap, ref ulong FileMapVA)
        {
            fixed (uint* __LoadedSize4 = &LoadedSize)
            {
                var __arg4 = __LoadedSize4;
                fixed (ulong* __FileMapVA6 = &FileMapVA)
                {
                    var __arg6 = __FileMapVA6;
                    var __ret = __Internal.StaticFileLoadW(szFileName, DesiredAccess, SimulateLoad, FileHandle, __arg4, FileMap, __arg6);
                    return __ret;
                }
            }
        }

        public static bool StaticFileUnload(sbyte* szFileName, bool CommitChanges, __IntPtr FileHandle, uint LoadedSize, __IntPtr FileMap, ulong FileMapVA)
        {
            var __ret = __Internal.StaticFileUnload(szFileName, CommitChanges, FileHandle, LoadedSize, FileMap, FileMapVA);
            return __ret;
        }

        public static bool StaticFileUnloadW(char* szFileName, bool CommitChanges, __IntPtr FileHandle, uint LoadedSize, __IntPtr FileMap, ulong FileMapVA)
        {
            var __ret = __Internal.StaticFileUnloadW(szFileName, CommitChanges, FileHandle, LoadedSize, FileMap, FileMapVA);
            return __ret;
        }

        public static bool StaticFileOpen(sbyte* szFileName, uint DesiredAccess, __IntPtr* FileHandle, ref uint FileSizeLow, ref uint FileSizeHigh)
        {
            fixed (uint* __FileSizeLow3 = &FileSizeLow)
            {
                var __arg3 = __FileSizeLow3;
                fixed (uint* __FileSizeHigh4 = &FileSizeHigh)
                {
                    var __arg4 = __FileSizeHigh4;
                    var __ret = __Internal.StaticFileOpen(szFileName, DesiredAccess, FileHandle, __arg3, __arg4);
                    return __ret;
                }
            }
        }

        public static bool StaticFileOpenW(char* szFileName, uint DesiredAccess, __IntPtr* FileHandle, ref uint FileSizeLow, ref uint FileSizeHigh)
        {
            fixed (uint* __FileSizeLow3 = &FileSizeLow)
            {
                var __arg3 = __FileSizeLow3;
                fixed (uint* __FileSizeHigh4 = &FileSizeHigh)
                {
                    var __arg4 = __FileSizeHigh4;
                    var __ret = __Internal.StaticFileOpenW(szFileName, DesiredAccess, FileHandle, __arg3, __arg4);
                    return __ret;
                }
            }
        }

        public static bool StaticFileGetContent(__IntPtr FileHandle, uint FilePositionLow, ref uint FilePositionHigh, __IntPtr Buffer, uint Size)
        {
            fixed (uint* __FilePositionHigh2 = &FilePositionHigh)
            {
                var __arg2 = __FilePositionHigh2;
                var __ret = __Internal.StaticFileGetContent(FileHandle, FilePositionLow, __arg2, Buffer, Size);
                return __ret;
            }
        }

        public static void StaticFileClose(__IntPtr FileHandle)
        {
            __Internal.StaticFileClose(FileHandle);
        }

        public static void StaticMemoryDecrypt(__IntPtr MemoryStart, uint MemorySize, uint DecryptionType, uint DecryptionKeySize, ulong DecryptionKey)
        {
            __Internal.StaticMemoryDecrypt(MemoryStart, MemorySize, DecryptionType, DecryptionKeySize, DecryptionKey);
        }

        public static void StaticMemoryDecryptEx(__IntPtr MemoryStart, uint MemorySize, uint DecryptionKeySize, __IntPtr DecryptionCallBack)
        {
            __Internal.StaticMemoryDecryptEx(MemoryStart, MemorySize, DecryptionKeySize, DecryptionCallBack);
        }

        public static void StaticMemoryDecryptSpecial(__IntPtr MemoryStart, uint MemorySize, uint DecryptionKeySize, uint SpecDecryptionType, __IntPtr DecryptionCallBack)
        {
            __Internal.StaticMemoryDecryptSpecial(MemoryStart, MemorySize, DecryptionKeySize, SpecDecryptionType, DecryptionCallBack);
        }

        public static void StaticSectionDecrypt(ulong FileMapVA, uint SectionNumber, bool SimulateLoad, uint DecryptionType, uint DecryptionKeySize, ulong DecryptionKey)
        {
            __Internal.StaticSectionDecrypt(FileMapVA, SectionNumber, SimulateLoad, DecryptionType, DecryptionKeySize, DecryptionKey);
        }

        public static bool StaticMemoryDecompress(__IntPtr Source, uint SourceSize, __IntPtr Destination, uint DestinationSize, int Algorithm)
        {
            var __ret = __Internal.StaticMemoryDecompress(Source, SourceSize, Destination, DestinationSize, Algorithm);
            return __ret;
        }

        public static bool StaticRawMemoryCopy(__IntPtr hFile, ulong FileMapVA, ulong VitualAddressToCopy, uint Size, bool AddressIsRVA, sbyte* szDumpFileName)
        {
            var __ret = __Internal.StaticRawMemoryCopy(hFile, FileMapVA, VitualAddressToCopy, Size, AddressIsRVA, szDumpFileName);
            return __ret;
        }

        public static bool StaticRawMemoryCopyW(__IntPtr hFile, ulong FileMapVA, ulong VitualAddressToCopy, uint Size, bool AddressIsRVA, char* szDumpFileName)
        {
            var __ret = __Internal.StaticRawMemoryCopyW(hFile, FileMapVA, VitualAddressToCopy, Size, AddressIsRVA, szDumpFileName);
            return __ret;
        }

        public static bool StaticRawMemoryCopyEx(__IntPtr hFile, uint RawAddressToCopy, uint Size, sbyte* szDumpFileName)
        {
            var __ret = __Internal.StaticRawMemoryCopyEx(hFile, RawAddressToCopy, Size, szDumpFileName);
            return __ret;
        }

        public static bool StaticRawMemoryCopyExW(__IntPtr hFile, uint RawAddressToCopy, uint Size, char* szDumpFileName)
        {
            var __ret = __Internal.StaticRawMemoryCopyExW(hFile, RawAddressToCopy, Size, szDumpFileName);
            return __ret;
        }

        public static bool StaticRawMemoryCopyEx64(__IntPtr hFile, ulong RawAddressToCopy, ulong Size, sbyte* szDumpFileName)
        {
            var __ret = __Internal.StaticRawMemoryCopyEx64(hFile, RawAddressToCopy, Size, szDumpFileName);
            return __ret;
        }

        public static bool StaticRawMemoryCopyEx64W(__IntPtr hFile, ulong RawAddressToCopy, ulong Size, char* szDumpFileName)
        {
            var __ret = __Internal.StaticRawMemoryCopyEx64W(hFile, RawAddressToCopy, Size, szDumpFileName);
            return __ret;
        }

        public static bool StaticHashMemory(__IntPtr MemoryToHash, uint SizeOfMemory, __IntPtr HashDigest, bool OutputString, int Algorithm)
        {
            var __ret = __Internal.StaticHashMemory(MemoryToHash, SizeOfMemory, HashDigest, OutputString, Algorithm);
            return __ret;
        }

        public static bool StaticHashFile(sbyte* szFileName, sbyte* HashDigest, bool OutputString, int Algorithm)
        {
            var __ret = __Internal.StaticHashFile(szFileName, HashDigest, OutputString, Algorithm);
            return __ret;
        }

        public static bool StaticHashFileW(char* szFileName, sbyte* HashDigest, bool OutputString, int Algorithm)
        {
            var __ret = __Internal.StaticHashFileW(szFileName, HashDigest, OutputString, Algorithm);
            return __ret;
        }

        public static void SetEngineVariable(uint VariableId, bool VariableSet)
        {
            __Internal.SetEngineVariable(VariableId, VariableSet);
        }

        public static bool EngineCreateMissingDependencies(sbyte* szFileName, sbyte* szOutputFolder, bool LogCreatedFiles)
        {
            var __ret = __Internal.EngineCreateMissingDependencies(szFileName, szOutputFolder, LogCreatedFiles);
            return __ret;
        }

        public static bool EngineCreateMissingDependenciesW(char* szFileName, char* szOutputFolder, bool LogCreatedFiles)
        {
            var __ret = __Internal.EngineCreateMissingDependenciesW(szFileName, szOutputFolder, LogCreatedFiles);
            return __ret;
        }

        public static bool EngineFakeMissingDependencies(__IntPtr hProcess)
        {
            var __ret = __Internal.EngineFakeMissingDependencies(hProcess);
            return __ret;
        }

        public static bool EngineDeleteCreatedDependencies()
        {
            var __ret = __Internal.EngineDeleteCreatedDependencies();
            return __ret;
        }

        public static bool EngineCreateUnpackerWindow(sbyte* WindowUnpackerTitle, sbyte* WindowUnpackerLongTitle, sbyte* WindowUnpackerName, sbyte* WindowUnpackerAuthor, __IntPtr StartUnpackingCallBack)
        {
            var __ret = __Internal.EngineCreateUnpackerWindow(WindowUnpackerTitle, WindowUnpackerLongTitle, WindowUnpackerName, WindowUnpackerAuthor, StartUnpackingCallBack);
            return __ret;
        }

        public static void EngineAddUnpackerWindowLogMessage(sbyte* szLogMessage)
        {
            __Internal.EngineAddUnpackerWindowLogMessage(szLogMessage);
        }

        public static bool EngineCheckStructAlignment(uint StructureType, ulong StructureSize)
        {
            var __ret = __Internal.EngineCheckStructAlignment(StructureType, StructureSize);
            return __ret;
        }

        public static bool ExtensionManagerIsPluginLoaded(sbyte* szPluginName)
        {
            var __ret = __Internal.ExtensionManagerIsPluginLoaded(szPluginName);
            return __ret;
        }

        public static bool ExtensionManagerIsPluginEnabled(sbyte* szPluginName)
        {
            var __ret = __Internal.ExtensionManagerIsPluginEnabled(szPluginName);
            return __ret;
        }

        public static bool ExtensionManagerDisableAllPlugins()
        {
            var __ret = __Internal.ExtensionManagerDisableAllPlugins();
            return __ret;
        }

        public static bool ExtensionManagerDisablePlugin(sbyte* szPluginName)
        {
            var __ret = __Internal.ExtensionManagerDisablePlugin(szPluginName);
            return __ret;
        }

        public static bool ExtensionManagerEnableAllPlugins()
        {
            var __ret = __Internal.ExtensionManagerEnableAllPlugins();
            return __ret;
        }

        public static bool ExtensionManagerEnablePlugin(sbyte* szPluginName)
        {
            var __ret = __Internal.ExtensionManagerEnablePlugin(szPluginName);
            return __ret;
        }

        public static bool ExtensionManagerUnloadAllPlugins()
        {
            var __ret = __Internal.ExtensionManagerUnloadAllPlugins();
            return __ret;
        }

        public static bool ExtensionManagerUnloadPlugin(sbyte* szPluginName)
        {
            var __ret = __Internal.ExtensionManagerUnloadPlugin(szPluginName);
            return __ret;
        }

        public static __IntPtr ExtensionManagerGetPluginInfo(sbyte* szPluginName)
        {
            var __ret = __Internal.ExtensionManagerGetPluginInfo(szPluginName);
            return __ret;
        }

        public static byte UE_STRUCT_PE32STRUCT { get; } = 1;

        public static byte UE_STRUCT_PE64STRUCT { get; } = 2;

        public static byte UE_STRUCT_PESTRUCT { get; } = 3;

        public static byte UE_STRUCT_IMPORTENUMDATA { get; } = 4;

        public static byte UE_STRUCT_THREAD_ITEM_DATA { get; } = 5;

        public static byte UE_STRUCT_LIBRARY_ITEM_DATA { get; } = 6;

        public static byte UE_STRUCT_LIBRARY_ITEM_DATAW { get; } = 7;

        public static byte UE_STRUCT_PROCESS_ITEM_DATA { get; } = 8;

        public static byte UE_STRUCT_HANDLERARRAY { get; } = 9;

        public static byte UE_STRUCT_PLUGININFORMATION { get; } = 10;

        public static byte UE_STRUCT_HOOK_ENTRY { get; } = 11;

        public static byte UE_STRUCT_FILE_STATUS_INFO { get; } = 12;

        public static byte UE_STRUCT_FILE_FIX_INFO { get; } = 13;

        public static byte UE_ACCESS_READ { get; } = 0;

        public static byte UE_ACCESS_WRITE { get; } = 1;

        public static byte UE_ACCESS_ALL { get; } = 2;

        public static byte UE_HIDE_PEBONLY { get; } = 0;

        public static byte UE_HIDE_BASIC { get; } = 1;

        public static byte UE_PLUGIN_CALL_REASON_PREDEBUG { get; } = 1;

        public static byte UE_PLUGIN_CALL_REASON_EXCEPTION { get; } = 2;

        public static byte UE_PLUGIN_CALL_REASON_POSTDEBUG { get; } = 3;

        public static byte UE_PLUGIN_CALL_REASON_UNHANDLEDEXCEPTION { get; } = 4;

        public static byte TEE_HOOK_NRM_JUMP { get; } = 1;

        public static byte TEE_HOOK_NRM_CALL { get; } = 3;

        public static byte TEE_HOOK_IAT { get; } = 5;

        public static byte UE_ENGINE_ALOW_MODULE_LOADING { get; } = 1;

        public static byte UE_ENGINE_AUTOFIX_FORWARDERS { get; } = 2;

        public static byte UE_ENGINE_PASS_ALL_EXCEPTIONS { get; } = 3;

        public static byte UE_ENGINE_NO_CONSOLE_WINDOW { get; } = 4;

        public static byte UE_ENGINE_BACKUP_FOR_CRITICAL_FUNCTIONS { get; } = 5;

        public static byte UE_ENGINE_CALL_PLUGIN_CALLBACK { get; } = 6;

        public static byte UE_ENGINE_RESET_CUSTOM_HANDLER { get; } = 7;

        public static byte UE_ENGINE_CALL_PLUGIN_DEBUG_CALLBACK { get; } = 8;

        public static byte UE_ENGINE_SET_DEBUG_PRIVILEGE { get; } = 9;

        public static byte UE_ENGINE_SAFE_ATTACH { get; } = 10;

        public static byte UE_ENGINE_MEMBP_ALT { get; } = 11;

        public static byte UE_OPTION_REMOVEALL { get; } = 1;

        public static byte UE_OPTION_DISABLEALL { get; } = 2;

        public static byte UE_OPTION_REMOVEALLDISABLED { get; } = 3;

        public static byte UE_OPTION_REMOVEALLENABLED { get; } = 4;

        public static byte UE_STATIC_DECRYPTOR_XOR { get; } = 1;

        public static byte UE_STATIC_DECRYPTOR_SUB { get; } = 2;

        public static byte UE_STATIC_DECRYPTOR_ADD { get; } = 3;

        public static byte UE_STATIC_DECRYPTOR_FOREWARD { get; } = 1;

        public static byte UE_STATIC_DECRYPTOR_BACKWARD { get; } = 2;

        public static byte UE_STATIC_KEY_SIZE_1 { get; } = 1;

        public static byte UE_STATIC_KEY_SIZE_2 { get; } = 2;

        public static byte UE_STATIC_KEY_SIZE_4 { get; } = 4;

        public static byte UE_STATIC_KEY_SIZE_8 { get; } = 8;

        public static byte UE_STATIC_APLIB { get; } = 1;

        public static byte UE_STATIC_APLIB_DEPACK { get; } = 2;

        public static byte UE_STATIC_LZMA { get; } = 3;

        public static byte UE_STATIC_HASH_MD5 { get; } = 1;

        public static byte UE_STATIC_HASH_SHA1 { get; } = 2;

        public static byte UE_STATIC_HASH_CRC32 { get; } = 3;

        public static int UE_RESOURCE_LANGUAGE_ANY { get; } = -1;

        public static byte UE_PE_OFFSET { get; } = 0;

        public static byte UE_IMAGEBASE { get; } = 1;

        public static byte UE_OEP { get; } = 2;

        public static byte UE_SIZEOFIMAGE { get; } = 3;

        public static byte UE_SIZEOFHEADERS { get; } = 4;

        public static byte UE_SIZEOFOPTIONALHEADER { get; } = 5;

        public static byte UE_SECTIONALIGNMENT { get; } = 6;

        public static byte UE_IMPORTTABLEADDRESS { get; } = 7;

        public static byte UE_IMPORTTABLESIZE { get; } = 8;

        public static byte UE_RESOURCETABLEADDRESS { get; } = 9;

        public static byte UE_RESOURCETABLESIZE { get; } = 10;

        public static byte UE_EXPORTTABLEADDRESS { get; } = 11;

        public static byte UE_EXPORTTABLESIZE { get; } = 12;

        public static byte UE_TLSTABLEADDRESS { get; } = 13;

        public static byte UE_TLSTABLESIZE { get; } = 14;

        public static byte UE_RELOCATIONTABLEADDRESS { get; } = 15;

        public static byte UE_RELOCATIONTABLESIZE { get; } = 16;

        public static byte UE_TIMEDATESTAMP { get; } = 17;

        public static byte UE_SECTIONNUMBER { get; } = 18;

        public static byte UE_CHECKSUM { get; } = 19;

        public static byte UE_SUBSYSTEM { get; } = 20;

        public static byte UE_CHARACTERISTICS { get; } = 21;

        public static byte UE_NUMBEROFRVAANDSIZES { get; } = 22;

        public static byte UE_BASEOFCODE { get; } = 23;

        public static byte UE_BASEOFDATA { get; } = 24;

        public static byte UE_DLLCHARACTERISTICS { get; } = 25;

        public static byte UE_SECTIONNAME { get; } = 40;

        public static byte UE_SECTIONVIRTUALOFFSET { get; } = 41;

        public static byte UE_SECTIONVIRTUALSIZE { get; } = 42;

        public static byte UE_SECTIONRAWOFFSET { get; } = 43;

        public static byte UE_SECTIONRAWSIZE { get; } = 44;

        public static byte UE_SECTIONFLAGS { get; } = 45;

        public static int UE_VANOTFOUND { get; } = -2;

        public static byte UE_CH_BREAKPOINT { get; } = 1;

        public static byte UE_CH_SINGLESTEP { get; } = 2;

        public static byte UE_CH_ACCESSVIOLATION { get; } = 3;

        public static byte UE_CH_ILLEGALINSTRUCTION { get; } = 4;

        public static byte UE_CH_NONCONTINUABLEEXCEPTION { get; } = 5;

        public static byte UE_CH_ARRAYBOUNDSEXCEPTION { get; } = 6;

        public static byte UE_CH_FLOATDENORMALOPERAND { get; } = 7;

        public static byte UE_CH_FLOATDEVIDEBYZERO { get; } = 8;

        public static byte UE_CH_INTEGERDEVIDEBYZERO { get; } = 9;

        public static byte UE_CH_INTEGEROVERFLOW { get; } = 10;

        public static byte UE_CH_PRIVILEGEDINSTRUCTION { get; } = 11;

        public static byte UE_CH_PAGEGUARD { get; } = 12;

        public static byte UE_CH_EVERYTHINGELSE { get; } = 13;

        public static byte UE_CH_CREATETHREAD { get; } = 14;

        public static byte UE_CH_EXITTHREAD { get; } = 15;

        public static byte UE_CH_CREATEPROCESS { get; } = 16;

        public static byte UE_CH_EXITPROCESS { get; } = 17;

        public static byte UE_CH_LOADDLL { get; } = 18;

        public static byte UE_CH_UNLOADDLL { get; } = 19;

        public static byte UE_CH_OUTPUTDEBUGSTRING { get; } = 20;

        public static byte UE_CH_AFTEREXCEPTIONPROCESSING { get; } = 21;

        public static byte UE_CH_SYSTEMBREAKPOINT { get; } = 23;

        public static byte UE_CH_UNHANDLEDEXCEPTION { get; } = 24;

        public static byte UE_CH_RIPEVENT { get; } = 25;

        public static byte UE_CH_DEBUGEVENT { get; } = 26;

        public static byte UE_OPTION_HANDLER_RETURN_HANDLECOUNT { get; } = 1;

        public static byte UE_OPTION_HANDLER_RETURN_ACCESS { get; } = 2;

        public static byte UE_OPTION_HANDLER_RETURN_FLAGS { get; } = 3;

        public static byte UE_OPTION_HANDLER_RETURN_TYPENAME { get; } = 4;

        public static byte UE_BREAKPOINT_INT3 { get; } = 1;

        public static byte UE_BREAKPOINT_LONG_INT3 { get; } = 2;

        public static byte UE_BREAKPOINT_UD2 { get; } = 3;

        public static byte UE_BPXREMOVED { get; } = 0;

        public static byte UE_BPXACTIVE { get; } = 1;

        public static byte UE_BPXINACTIVE { get; } = 2;

        public static byte UE_BREAKPOINT { get; } = 0;

        public static byte UE_SINGLESHOOT { get; } = 1;

        public static byte UE_HARDWARE { get; } = 2;

        public static byte UE_MEMORY { get; } = 3;

        public static byte UE_MEMORY_READ { get; } = 4;

        public static byte UE_MEMORY_WRITE { get; } = 5;

        public static byte UE_MEMORY_EXECUTE { get; } = 6;

        public static uint UE_BREAKPOINT_TYPE_INT3 { get; } = 268435456;

        public static uint UE_BREAKPOINT_TYPE_LONG_INT3 { get; } = 536870912;

        public static uint UE_BREAKPOINT_TYPE_UD2 { get; } = 805306368;

        public static byte UE_HARDWARE_EXECUTE { get; } = 4;

        public static byte UE_HARDWARE_WRITE { get; } = 5;

        public static byte UE_HARDWARE_READWRITE { get; } = 6;

        public static byte UE_HARDWARE_SIZE_1 { get; } = 7;

        public static byte UE_HARDWARE_SIZE_2 { get; } = 8;

        public static byte UE_HARDWARE_SIZE_4 { get; } = 9;

        public static byte UE_HARDWARE_SIZE_8 { get; } = 10;

        public static byte UE_ON_LIB_LOAD { get; } = 1;

        public static byte UE_ON_LIB_UNLOAD { get; } = 2;

        public static byte UE_ON_LIB_ALL { get; } = 3;

        public static byte UE_APISTART { get; } = 0;

        public static byte UE_APIEND { get; } = 1;

        public static byte UE_PLATFORM_x86 { get; } = 1;

        public static byte UE_PLATFORM_x64 { get; } = 2;

        public static byte UE_PLATFORM_ALL { get; } = 3;

        public static byte UE_FUNCTION_STDCALL { get; } = 1;

        public static byte UE_FUNCTION_CCALL { get; } = 2;

        public static byte UE_FUNCTION_FASTCALL { get; } = 3;

        public static byte UE_FUNCTION_STDCALL_RET { get; } = 4;

        public static byte UE_FUNCTION_CCALL_RET { get; } = 5;

        public static byte UE_FUNCTION_FASTCALL_RET { get; } = 6;

        public static byte UE_FUNCTION_STDCALL_CALL { get; } = 7;

        public static byte UE_FUNCTION_CCALL_CALL { get; } = 8;

        public static byte UE_FUNCTION_FASTCALL_CALL { get; } = 9;

        public static byte UE_PARAMETER_BYTE { get; } = 0;

        public static byte UE_PARAMETER_WORD { get; } = 1;

        public static byte UE_PARAMETER_DWORD { get; } = 2;

        public static byte UE_PARAMETER_QWORD { get; } = 3;

        public static byte UE_PARAMETER_PTR_BYTE { get; } = 4;

        public static byte UE_PARAMETER_PTR_WORD { get; } = 5;

        public static byte UE_PARAMETER_PTR_DWORD { get; } = 6;

        public static byte UE_PARAMETER_PTR_QWORD { get; } = 7;

        public static byte UE_PARAMETER_STRING { get; } = 8;

        public static byte UE_PARAMETER_UNICODE { get; } = 9;

        public static byte UE_EAX { get; } = 1;

        public static byte UE_EBX { get; } = 2;

        public static byte UE_ECX { get; } = 3;

        public static byte UE_EDX { get; } = 4;

        public static byte UE_EDI { get; } = 5;

        public static byte UE_ESI { get; } = 6;

        public static byte UE_EBP { get; } = 7;

        public static byte UE_ESP { get; } = 8;

        public static byte UE_EIP { get; } = 9;

        public static byte UE_EFLAGS { get; } = 10;

        public static byte UE_DR0 { get; } = 11;

        public static byte UE_DR1 { get; } = 12;

        public static byte UE_DR2 { get; } = 13;

        public static byte UE_DR3 { get; } = 14;

        public static byte UE_DR6 { get; } = 15;

        public static byte UE_DR7 { get; } = 16;

        public static byte UE_RAX { get; } = 17;

        public static byte UE_RBX { get; } = 18;

        public static byte UE_RCX { get; } = 19;

        public static byte UE_RDX { get; } = 20;

        public static byte UE_RDI { get; } = 21;

        public static byte UE_RSI { get; } = 22;

        public static byte UE_RBP { get; } = 23;

        public static byte UE_RSP { get; } = 24;

        public static byte UE_RIP { get; } = 25;

        public static byte UE_RFLAGS { get; } = 26;

        public static byte UE_R8 { get; } = 27;

        public static byte UE_R9 { get; } = 28;

        public static byte UE_R10 { get; } = 29;

        public static byte UE_R11 { get; } = 30;

        public static byte UE_R12 { get; } = 31;

        public static byte UE_R13 { get; } = 32;

        public static byte UE_R14 { get; } = 33;

        public static byte UE_R15 { get; } = 34;

        public static byte UE_CIP { get; } = 35;

        public static byte UE_CSP { get; } = 36;

        public static byte UE_CFLAGS { get; } = UE_RFLAGS;

        public static byte UE_SEG_GS { get; } = 37;

        public static byte UE_SEG_FS { get; } = 38;

        public static byte UE_SEG_ES { get; } = 39;

        public static byte UE_SEG_DS { get; } = 40;

        public static byte UE_SEG_CS { get; } = 41;

        public static byte UE_SEG_SS { get; } = 42;

        public static ulong TEE_MAXIMUM_HOOK_SIZE { get; } = 14;

        public static ulong TEE_MAXIMUM_HOOK_RELOCS { get; } = 7;

        public static ulong TEE_MAXIMUM_HOOK_INSERT_SIZE { get; } = 14;

        public static byte UE_DEPTH_SURFACE { get; } = 0;

        public static byte UE_DEPTH_DEEP { get; } = 1;

        public static byte UE_UNPACKER_CONDITION_SEARCH_FROM_EP { get; } = 1;

        public static byte UE_UNPACKER_CONDITION_LOADLIBRARY { get; } = 1;

        public static byte UE_UNPACKER_CONDITION_GETPROCADDRESS { get; } = 2;

        public static byte UE_UNPACKER_CONDITION_ENTRYPOINTBREAK { get; } = 3;

        public static byte UE_UNPACKER_CONDITION_RELOCSNAPSHOT1 { get; } = 4;

        public static byte UE_UNPACKER_CONDITION_RELOCSNAPSHOT2 { get; } = 5;

        public static byte UE_FIELD_OK { get; } = 0;

        public static byte UE_FIELD_BROKEN_NON_FIXABLE { get; } = 1;

        public static byte UE_FIELD_BROKEN_NON_CRITICAL { get; } = 2;

        public static byte UE_FIELD_BROKEN_FIXABLE_FOR_STATIC_USE { get; } = 3;

        public static byte UE_FIELD_BROKEN_BUT_CAN_BE_EMULATED { get; } = 4;

        public static byte UE_FIELD_FIXABLE_NON_CRITICAL { get; } = 5;

        public static byte UE_FIELD_FIXABLE_CRITICAL { get; } = 6;

        public static byte UE_FIELD_NOT_PRESET { get; } = 7;

        public static byte UE_FIELD_NOT_PRESET_WARNING { get; } = 8;

        public static byte UE_RESULT_FILE_OK { get; } = 10;

        public static byte UE_RESULT_FILE_INVALID_BUT_FIXABLE { get; } = 11;

        public static byte UE_RESULT_FILE_INVALID_AND_NON_FIXABLE { get; } = 12;

        public static byte UE_RESULT_FILE_INVALID_FORMAT { get; } = 13;
    }
}