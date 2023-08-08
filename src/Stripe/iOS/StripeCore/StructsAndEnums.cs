using System;
using System.Runtime.InteropServices;
using CFNetwork;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace Chi.MauiBinding.iOS.StripeCore
{
	[StructLayout (LayoutKind.Explicit)]
	public struct __darwin_mbstate_t
	{
		[FieldOffset (0)]
		public sbyte[] __mbstate8;

		[FieldOffset (0)]
		public long _mbstateL;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_pthread_handler_rec
	{
		public unsafe Action<void*>* __routine;

		public unsafe void* __arg;

		public unsafe __darwin_pthread_handler_rec* __next;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_attr_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_cond_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_condattr_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_mutex_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_mutexattr_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_once_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_rwlock_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct pthread_rwlockattr_t
	{
		public nint __sig;

		public sbyte[] __opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _opaque_pthread_t
	{
		public nint __sig;

		public unsafe __darwin_pthread_handler_rec* __cleanup_stack;

		public sbyte[] __opaque;
	}

	static class CFunctions
	{
		// uint16_t _OSSwapInt16 (uint16_t _data);
		[DllImport ("__Internal")]
		static extern ushort _OSSwapInt16 (ushort _data);

		// uint32_t _OSSwapInt32 (uint32_t _data);
		[DllImport ("__Internal")]
		static extern uint _OSSwapInt32 (uint _data);

		// extern unsigned int __builtin_bswap32 (unsigned int)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern uint __builtin_bswap32 (uint);

		// uint64_t _OSSwapInt64 (uint64_t _data);
		[DllImport ("__Internal")]
		static extern ulong _OSSwapInt64 (ulong _data);

		// extern unsigned long long __builtin_bswap64 (unsigned long long)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern ulong __builtin_bswap64 (ulong);

		// uint16_t OSReadSwapInt16 (const volatile void *_base, uintptr_t _offset);
		[DllImport ("__Internal")]
		static extern unsafe ushort OSReadSwapInt16 (void* _base, UIntPtr _offset);

		// uint32_t OSReadSwapInt32 (const volatile void *_base, uintptr_t _offset);
		[DllImport ("__Internal")]
		static extern unsafe uint OSReadSwapInt32 (void* _base, UIntPtr _offset);

		// uint64_t OSReadSwapInt64 (const volatile void *_base, uintptr_t _offset);
		[DllImport ("__Internal")]
		static extern unsafe ulong OSReadSwapInt64 (void* _base, UIntPtr _offset);

		// void OSWriteSwapInt16 (volatile void *_base, uintptr_t _offset, uint16_t _data);
		[DllImport ("__Internal")]
		static extern unsafe void OSWriteSwapInt16 (void* _base, UIntPtr _offset, ushort _data);

		// void OSWriteSwapInt32 (volatile void *_base, uintptr_t _offset, uint32_t _data);
		[DllImport ("__Internal")]
		static extern unsafe void OSWriteSwapInt32 (void* _base, UIntPtr _offset, uint _data);

		// void OSWriteSwapInt64 (volatile void *_base, uintptr_t _offset, uint64_t _data);
		[DllImport ("__Internal")]
		static extern unsafe void OSWriteSwapInt64 (void* _base, UIntPtr _offset, ulong _data);

		// extern int __darwin_check_fd_set_overflow (int, const void *, int) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0)));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int __darwin_check_fd_set_overflow (int, void*, int);

		// extern int __darwin_check_fd_set (int _a, const void *_b) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe int __darwin_check_fd_set (int _a, void* _b);

		// extern int __darwin_fd_isset (int _fd, const struct fd_set *_p) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe int __darwin_fd_isset (int _fd, fd_set* _p);

		// extern void __darwin_fd_set (int _fd, struct fd_set *const _p) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __darwin_fd_set (int _fd, fd_set* _p);

		// extern void __darwin_fd_clr (int _fd, struct fd_set *const _p) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __darwin_fd_clr (int _fd, fd_set* _p);

		// extern void __assert_rtn (const char *, const char *, int, const char *) __attribute__((cold)) __attribute__((disable_tail_calls));
		[DllImport ("__Internal")]
		static extern unsafe void __assert_rtn (sbyte*, sbyte*, int, sbyte*);

		// extern unsigned long ___runetype (__darwin_ct_rune_t);
		[DllImport ("__Internal")]
		static extern nuint ___runetype (int);

		// extern __darwin_ct_rune_t ___tolower (__darwin_ct_rune_t);
		[DllImport ("__Internal")]
		static extern int ___tolower (int);

		// extern __darwin_ct_rune_t ___toupper (__darwin_ct_rune_t);
		[DllImport ("__Internal")]
		static extern int ___toupper (int);

		// extern int isascii (int _c);
		[DllImport ("__Internal")]
		static extern int isascii (int _c);

		// extern int __maskrune (__darwin_ct_rune_t, unsigned long);
		[DllImport ("__Internal")]
		static extern int __maskrune (int, nuint);

		// extern int __istype (__darwin_ct_rune_t _c, unsigned long _f);
		[DllImport ("__Internal")]
		static extern int __istype (int _c, nuint _f);

		// extern __darwin_ct_rune_t __isctype (__darwin_ct_rune_t _c, unsigned long _f);
		[DllImport ("__Internal")]
		static extern int __isctype (int _c, nuint _f);

		// extern __darwin_ct_rune_t __toupper (__darwin_ct_rune_t);
		[DllImport ("__Internal")]
		static extern int __toupper (int);

		// extern __darwin_ct_rune_t __tolower (__darwin_ct_rune_t);
		[DllImport ("__Internal")]
		static extern int __tolower (int);

		// extern int __wcwidth (__darwin_ct_rune_t _c);
		[DllImport ("__Internal")]
		static extern int __wcwidth (int _c);

		// extern int isalnum (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isalnum (int);

		// extern int isalnum (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isalnum (int _c);

		// extern int isalpha (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isalpha (int);

		// extern int isalpha (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isalpha (int _c);

		// extern int isblank (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isblank (int);

		// extern int isblank (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isblank (int _c);

		// extern int iscntrl (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int iscntrl (int);

		// extern int iscntrl (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int iscntrl (int _c);

		// extern int isdigit (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isdigit (int);

		// extern int isdigit (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isdigit (int _c);

		// extern int isgraph (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isgraph (int);

		// extern int isgraph (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isgraph (int _c);

		// extern int islower (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int islower (int);

		// extern int islower (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int islower (int _c);

		// extern int isprint (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isprint (int);

		// extern int isprint (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isprint (int _c);

		// extern int ispunct (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int ispunct (int);

		// extern int ispunct (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int ispunct (int _c);

		// extern int isspace (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isspace (int);

		// extern int isspace (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isspace (int _c);

		// extern int isupper (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isupper (int);

		// extern int isupper (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isupper (int _c);

		// extern int isxdigit (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isxdigit (int);

		// extern int isxdigit (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int isxdigit (int _c);

		// extern int toascii (int _c);
		[DllImport ("__Internal")]
		static extern int toascii (int _c);

		// extern int tolower (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int tolower (int);

		// extern int tolower (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int tolower (int _c);

		// extern int toupper (int)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int toupper (int);

		// extern int toupper (int _c)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern int toupper (int _c);

		// extern int digittoint (int _c);
		[DllImport ("__Internal")]
		static extern int digittoint (int _c);

		// extern int ishexnumber (int _c);
		[DllImport ("__Internal")]
		static extern int ishexnumber (int _c);

		// extern int isideogram (int _c);
		[DllImport ("__Internal")]
		static extern int isideogram (int _c);

		// extern int isnumber (int _c);
		[DllImport ("__Internal")]
		static extern int isnumber (int _c);

		// extern int isphonogram (int _c);
		[DllImport ("__Internal")]
		static extern int isphonogram (int _c);

		// extern int isrune (int _c);
		[DllImport ("__Internal")]
		static extern int isrune (int _c);

		// extern int isspecial (int _c);
		[DllImport ("__Internal")]
		static extern int isspecial (int _c);

		// extern int * __error ();
		[DllImport ("__Internal")]
		static extern unsafe int* __error ();

		// extern struct lconv * localeconv ();
		[DllImport ("__Internal")]
		static extern unsafe lconv* localeconv ();

		// extern char * setlocale (int, const char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* setlocale (int, sbyte*);

		// extern int __math_errhandling ();
		[DllImport ("__Internal")]
		static extern int __math_errhandling ();

		// extern int __fpclassifyf (float);
		[DllImport ("__Internal")]
		static extern int __fpclassifyf (float);

		// extern int __fpclassifyd (double);
		[DllImport ("__Internal")]
		static extern int __fpclassifyd (double);

		// extern int __fpclassifyl (long double);
		[DllImport ("__Internal")]
		static extern int __fpclassifyl ([unsupported Builtin: long double]);

		// extern int __inline_isfinitef (float) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isfinitef (float);

		// extern int __inline_isfinited (double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isfinited (double);

		// extern int __inline_isfinitel (long double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isfinitel ([unsupported Builtin: long double]);

		// extern int __inline_isinff (float) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isinff (float);

		// extern int __inline_isinfd (double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isinfd (double);

		// extern int __inline_isinfl (long double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isinfl ([unsupported Builtin: long double]);

		// extern int __inline_isnanf (float) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnanf (float);

		// extern int __inline_isnand (double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnand (double);

		// extern int __inline_isnanl (long double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnanl ([unsupported Builtin: long double]);

		// extern int __inline_isnormalf (float) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnormalf (float);

		// extern int __inline_isnormald (double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnormald (double);

		// extern int __inline_isnormall (long double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnormall ([unsupported Builtin: long double]);

		// extern int __inline_signbitf (float) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_signbitf (float);

		// extern int __inline_signbitd (double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_signbitd (double);

		// extern int __inline_signbitl (long double) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_signbitl ([unsupported Builtin: long double]);

		// extern int __inline_isfinitef (float __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isfinitef (float __x);

		// extern float __builtin_fabsf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float __builtin_fabsf (float);

		// extern float __builtin_inff ()  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float __builtin_inff ();

		// extern int __inline_isfinited (double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isfinited (double __x);

		// extern double __builtin_fabs (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double __builtin_fabs (double);

		// extern double __builtin_inf ()  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double __builtin_inf ();

		// extern int __inline_isfinitel (long double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isfinitel ([unsupported Builtin: long double] __x);

		// extern long double __builtin_fabsl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] __builtin_fabsl ([unsupported Builtin: long double]);

		// extern long double __builtin_infl ()  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] __builtin_infl ();

		// extern int __inline_isinff (float __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isinff (float __x);

		// extern int __inline_isinfd (double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isinfd (double __x);

		// extern int __inline_isinfl (long double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isinfl ([unsupported Builtin: long double] __x);

		// extern int __inline_isnanf (float __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnanf (float __x);

		// extern int __inline_isnand (double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnand (double __x);

		// extern int __inline_isnanl (long double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnanl ([unsupported Builtin: long double] __x);

		// extern int __inline_signbitf (float __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_signbitf (float __x);

		// extern int __inline_signbitd (double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_signbitd (double __x);

		// extern int __inline_signbitl (long double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_signbitl ([unsupported Builtin: long double] __x);

		// extern int __inline_isnormalf (float __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnormalf (float __x);

		// extern int __inline_isnormald (double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnormald (double __x);

		// extern int __inline_isnormall (long double __x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __inline_isnormall ([unsupported Builtin: long double] __x);

		// extern float acosf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float acosf (float);

		// extern float acosf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float acosf (float);

		// extern double acos (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double acos (double);

		// extern double acos (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double acos (double);

		// extern long double acosl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] acosl ([unsupported Builtin: long double]);

		// extern long double acosl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] acosl ([unsupported Builtin: long double]);

		// extern float asinf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float asinf (float);

		// extern float asinf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float asinf (float);

		// extern double asin (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double asin (double);

		// extern double asin (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double asin (double);

		// extern long double asinl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] asinl ([unsupported Builtin: long double]);

		// extern long double asinl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] asinl ([unsupported Builtin: long double]);

		// extern float atanf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float atanf (float);

		// extern float atanf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float atanf (float);

		// extern double atan (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double atan (double);

		// extern double atan (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double atan (double);

		// extern long double atanl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] atanl ([unsupported Builtin: long double]);

		// extern long double atanl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] atanl ([unsupported Builtin: long double]);

		// extern float atan2f (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float atan2f (float, float);

		// extern float atan2f (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float atan2f (float, float);

		// extern double atan2 (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double atan2 (double, double);

		// extern double atan2 (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double atan2 (double, double);

		// extern long double atan2l (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] atan2l ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double atan2l (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] atan2l ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float cosf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float cosf (float);

		// extern float cosf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float cosf (float);

		// extern double cos (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double cos (double);

		// extern double cos (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double cos (double);

		// extern long double cosl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] cosl ([unsupported Builtin: long double]);

		// extern long double cosl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] cosl ([unsupported Builtin: long double]);

		// extern float sinf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float sinf (float);

		// extern float sinf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float sinf (float);

		// extern double sin (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double sin (double);

		// extern double sin (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double sin (double);

		// extern long double sinl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] sinl ([unsupported Builtin: long double]);

		// extern long double sinl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] sinl ([unsupported Builtin: long double]);

		// extern float tanf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float tanf (float);

		// extern float tanf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float tanf (float);

		// extern double tan (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double tan (double);

		// extern double tan (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double tan (double);

		// extern long double tanl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] tanl ([unsupported Builtin: long double]);

		// extern long double tanl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] tanl ([unsupported Builtin: long double]);

		// extern float acoshf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float acoshf (float);

		// extern float acoshf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float acoshf (float);

		// extern double acosh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double acosh (double);

		// extern double acosh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double acosh (double);

		// extern long double acoshl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] acoshl ([unsupported Builtin: long double]);

		// extern long double acoshl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] acoshl ([unsupported Builtin: long double]);

		// extern float asinhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float asinhf (float);

		// extern float asinhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float asinhf (float);

		// extern double asinh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double asinh (double);

		// extern double asinh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double asinh (double);

		// extern long double asinhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] asinhl ([unsupported Builtin: long double]);

		// extern long double asinhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] asinhl ([unsupported Builtin: long double]);

		// extern float atanhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float atanhf (float);

		// extern float atanhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float atanhf (float);

		// extern double atanh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double atanh (double);

		// extern double atanh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double atanh (double);

		// extern long double atanhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] atanhl ([unsupported Builtin: long double]);

		// extern long double atanhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] atanhl ([unsupported Builtin: long double]);

		// extern float coshf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float coshf (float);

		// extern float coshf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float coshf (float);

		// extern double cosh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double cosh (double);

		// extern double cosh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double cosh (double);

		// extern long double coshl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] coshl ([unsupported Builtin: long double]);

		// extern long double coshl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] coshl ([unsupported Builtin: long double]);

		// extern float sinhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float sinhf (float);

		// extern float sinhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float sinhf (float);

		// extern double sinh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double sinh (double);

		// extern double sinh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double sinh (double);

		// extern long double sinhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] sinhl ([unsupported Builtin: long double]);

		// extern long double sinhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] sinhl ([unsupported Builtin: long double]);

		// extern float tanhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float tanhf (float);

		// extern float tanhf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float tanhf (float);

		// extern double tanh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double tanh (double);

		// extern double tanh (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double tanh (double);

		// extern long double tanhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] tanhl ([unsupported Builtin: long double]);

		// extern long double tanhl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] tanhl ([unsupported Builtin: long double]);

		// extern float expf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float expf (float);

		// extern float expf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float expf (float);

		// extern double exp (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double exp (double);

		// extern double exp (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double exp (double);

		// extern long double expl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] expl ([unsupported Builtin: long double]);

		// extern long double expl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] expl ([unsupported Builtin: long double]);

		// extern float exp2f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float exp2f (float);

		// extern float exp2f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float exp2f (float);

		// extern double exp2 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double exp2 (double);

		// extern double exp2 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double exp2 (double);

		// extern long double exp2l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] exp2l ([unsupported Builtin: long double]);

		// extern long double exp2l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] exp2l ([unsupported Builtin: long double]);

		// extern float expm1f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float expm1f (float);

		// extern float expm1f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float expm1f (float);

		// extern double expm1 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double expm1 (double);

		// extern double expm1 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double expm1 (double);

		// extern long double expm1l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] expm1l ([unsupported Builtin: long double]);

		// extern long double expm1l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] expm1l ([unsupported Builtin: long double]);

		// extern float logf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float logf (float);

		// extern float logf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float logf (float);

		// extern double log (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log (double);

		// extern double log (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log (double);

		// extern long double logl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] logl ([unsupported Builtin: long double]);

		// extern long double logl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] logl ([unsupported Builtin: long double]);

		// extern float log10f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float log10f (float);

		// extern float log10f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float log10f (float);

		// extern double log10 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log10 (double);

		// extern double log10 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log10 (double);

		// extern long double log10l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] log10l ([unsupported Builtin: long double]);

		// extern long double log10l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] log10l ([unsupported Builtin: long double]);

		// extern float log2f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float log2f (float);

		// extern float log2f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float log2f (float);

		// extern double log2 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log2 (double);

		// extern double log2 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log2 (double);

		// extern long double log2l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] log2l ([unsupported Builtin: long double]);

		// extern long double log2l (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] log2l ([unsupported Builtin: long double]);

		// extern float log1pf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float log1pf (float);

		// extern float log1pf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float log1pf (float);

		// extern double log1p (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log1p (double);

		// extern double log1p (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double log1p (double);

		// extern long double log1pl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] log1pl ([unsupported Builtin: long double]);

		// extern long double log1pl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] log1pl ([unsupported Builtin: long double]);

		// extern float logbf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float logbf (float);

		// extern float logbf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float logbf (float);

		// extern double logb (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double logb (double);

		// extern double logb (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double logb (double);

		// extern long double logbl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] logbl ([unsupported Builtin: long double]);

		// extern long double logbl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] logbl ([unsupported Builtin: long double]);

		// extern float modff (float, float *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe float modff (float, float*);

		// extern float modff (float, float *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe float modff (float, float*);

		// extern double modf (double, double *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe double modf (double, double*);

		// extern double modf (double, double *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe double modf (double, double*);

		// extern long double modfl (long double, long double *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] modfl ([unsupported Builtin: long double], [unsupported Builtin: long double]*);

		// extern long double modfl (long double, long double *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] modfl ([unsupported Builtin: long double], [unsupported Builtin: long double]*);

		// extern float ldexpf (float, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float ldexpf (float, int);

		// extern float ldexpf (float, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float ldexpf (float, int);

		// extern double ldexp (double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double ldexp (double, int);

		// extern double ldexp (double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double ldexp (double, int);

		// extern long double ldexpl (long double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] ldexpl ([unsupported Builtin: long double], int);

		// extern long double ldexpl (long double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] ldexpl ([unsupported Builtin: long double], int);

		// extern float frexpf (float, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe float frexpf (float, int*);

		// extern float frexpf (float, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe float frexpf (float, int*);

		// extern double frexp (double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe double frexp (double, int*);

		// extern double frexp (double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe double frexp (double, int*);

		// extern long double frexpl (long double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] frexpl ([unsupported Builtin: long double], int*);

		// extern long double frexpl (long double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] frexpl ([unsupported Builtin: long double], int*);

		// extern int ilogbf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern int ilogbf (float);

		// extern int ilogbf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern int ilogbf (float);

		// extern int ilogb (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern int ilogb (double);

		// extern int ilogb (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern int ilogb (double);

		// extern int ilogbl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern int ilogbl ([unsupported Builtin: long double]);

		// extern int ilogbl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern int ilogbl ([unsupported Builtin: long double]);

		// extern float scalbnf (float, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float scalbnf (float, int);

		// extern float scalbnf (float, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float scalbnf (float, int);

		// extern double scalbn (double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double scalbn (double, int);

		// extern double scalbn (double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double scalbn (double, int);

		// extern long double scalbnl (long double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] scalbnl ([unsupported Builtin: long double], int);

		// extern long double scalbnl (long double, int)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] scalbnl ([unsupported Builtin: long double], int);

		// extern float scalblnf (float, long)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float scalblnf (float, nint);

		// extern float scalblnf (float, long)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float scalblnf (float, nint);

		// extern double scalbln (double, long)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double scalbln (double, nint);

		// extern double scalbln (double, long)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double scalbln (double, nint);

		// extern long double scalblnl (long double, long)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] scalblnl ([unsupported Builtin: long double], nint);

		// extern long double scalblnl (long double, long)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] scalblnl ([unsupported Builtin: long double], nint);

		// extern float fabsf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float fabsf (float);

		// extern float fabsf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float fabsf (float);

		// extern double fabs (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double fabs (double);

		// extern double fabs (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double fabs (double);

		// extern long double fabsl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fabsl ([unsupported Builtin: long double]);

		// extern long double fabsl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fabsl ([unsupported Builtin: long double]);

		// extern float cbrtf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float cbrtf (float);

		// extern float cbrtf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float cbrtf (float);

		// extern double cbrt (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double cbrt (double);

		// extern double cbrt (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double cbrt (double);

		// extern long double cbrtl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] cbrtl ([unsupported Builtin: long double]);

		// extern long double cbrtl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] cbrtl ([unsupported Builtin: long double]);

		// extern float hypotf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float hypotf (float, float);

		// extern float hypotf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float hypotf (float, float);

		// extern double hypot (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double hypot (double, double);

		// extern double hypot (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double hypot (double, double);

		// extern long double hypotl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] hypotl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double hypotl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] hypotl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float powf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float powf (float, float);

		// extern float powf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float powf (float, float);

		// extern double pow (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double pow (double, double);

		// extern double pow (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double pow (double, double);

		// extern long double powl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] powl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double powl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] powl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float sqrtf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float sqrtf (float);

		// extern float sqrtf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float sqrtf (float);

		// extern double sqrt (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double sqrt (double);

		// extern double sqrt (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double sqrt (double);

		// extern long double sqrtl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] sqrtl ([unsupported Builtin: long double]);

		// extern long double sqrtl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] sqrtl ([unsupported Builtin: long double]);

		// extern float erff (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float erff (float);

		// extern float erff (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float erff (float);

		// extern double erf (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double erf (double);

		// extern double erf (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double erf (double);

		// extern long double erfl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] erfl ([unsupported Builtin: long double]);

		// extern long double erfl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] erfl ([unsupported Builtin: long double]);

		// extern float erfcf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float erfcf (float);

		// extern float erfcf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float erfcf (float);

		// extern double erfc (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double erfc (double);

		// extern double erfc (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double erfc (double);

		// extern long double erfcl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] erfcl ([unsupported Builtin: long double]);

		// extern long double erfcl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] erfcl ([unsupported Builtin: long double]);

		// extern float lgammaf (float)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float lgammaf (float);

		// extern float lgammaf (float)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float lgammaf (float);

		// extern double lgamma (double)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double lgamma (double);

		// extern double lgamma (double)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double lgamma (double);

		// extern long double lgammal (long double)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] lgammal ([unsupported Builtin: long double]);

		// extern long double lgammal (long double)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] lgammal ([unsupported Builtin: long double]);

		// extern float tgammaf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float tgammaf (float);

		// extern float tgammaf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float tgammaf (float);

		// extern double tgamma (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double tgamma (double);

		// extern double tgamma (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double tgamma (double);

		// extern long double tgammal (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] tgammal ([unsupported Builtin: long double]);

		// extern long double tgammal (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] tgammal ([unsupported Builtin: long double]);

		// extern float ceilf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float ceilf (float);

		// extern float ceilf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float ceilf (float);

		// extern double ceil (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double ceil (double);

		// extern double ceil (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double ceil (double);

		// extern long double ceill (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] ceill ([unsupported Builtin: long double]);

		// extern long double ceill (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] ceill ([unsupported Builtin: long double]);

		// extern float floorf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float floorf (float);

		// extern float floorf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float floorf (float);

		// extern double floor (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double floor (double);

		// extern double floor (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double floor (double);

		// extern long double floorl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] floorl ([unsupported Builtin: long double]);

		// extern long double floorl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] floorl ([unsupported Builtin: long double]);

		// extern float nearbyintf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float nearbyintf (float);

		// extern float nearbyintf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float nearbyintf (float);

		// extern double nearbyint (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double nearbyint (double);

		// extern double nearbyint (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double nearbyint (double);

		// extern long double nearbyintl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] nearbyintl ([unsupported Builtin: long double]);

		// extern long double nearbyintl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] nearbyintl ([unsupported Builtin: long double]);

		// extern float rintf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float rintf (float);

		// extern float rintf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float rintf (float);

		// extern double rint (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double rint (double);

		// extern double rint (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double rint (double);

		// extern long double rintl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] rintl ([unsupported Builtin: long double]);

		// extern long double rintl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] rintl ([unsupported Builtin: long double]);

		// extern long lrintf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lrintf (float);

		// extern long lrintf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lrintf (float);

		// extern long lrint (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lrint (double);

		// extern long lrint (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lrint (double);

		// extern long lrintl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lrintl ([unsupported Builtin: long double]);

		// extern long lrintl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lrintl ([unsupported Builtin: long double]);

		// extern float roundf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float roundf (float);

		// extern float roundf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float roundf (float);

		// extern double round (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double round (double);

		// extern double round (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double round (double);

		// extern long double roundl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] roundl ([unsupported Builtin: long double]);

		// extern long double roundl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] roundl ([unsupported Builtin: long double]);

		// extern long lroundf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lroundf (float);

		// extern long lroundf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lroundf (float);

		// extern long lround (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lround (double);

		// extern long lround (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lround (double);

		// extern long lroundl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lroundl ([unsupported Builtin: long double]);

		// extern long lroundl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern nint lroundl ([unsupported Builtin: long double]);

		// extern long long llrintf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llrintf (float);

		// extern long long llrintf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llrintf (float);

		// extern long long llrint (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llrint (double);

		// extern long long llrint (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llrint (double);

		// extern long long llrintl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llrintl ([unsupported Builtin: long double]);

		// extern long long llrintl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llrintl ([unsupported Builtin: long double]);

		// extern long long llroundf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llroundf (float);

		// extern long long llroundf (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llroundf (float);

		// extern long long llround (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llround (double);

		// extern long long llround (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llround (double);

		// extern long long llroundl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llroundl ([unsupported Builtin: long double]);

		// extern long long llroundl (long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern long llroundl ([unsupported Builtin: long double]);

		// extern float truncf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float truncf (float);

		// extern float truncf (float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float truncf (float);

		// extern double trunc (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double trunc (double);

		// extern double trunc (double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double trunc (double);

		// extern long double truncl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] truncl ([unsupported Builtin: long double]);

		// extern long double truncl (long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] truncl ([unsupported Builtin: long double]);

		// extern float fmodf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float fmodf (float, float);

		// extern float fmodf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float fmodf (float, float);

		// extern double fmod (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double fmod (double, double);

		// extern double fmod (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double fmod (double, double);

		// extern long double fmodl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fmodl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double fmodl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fmodl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float remainderf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float remainderf (float, float);

		// extern float remainderf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float remainderf (float, float);

		// extern double remainder (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double remainder (double, double);

		// extern double remainder (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double remainder (double, double);

		// extern long double remainderl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] remainderl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double remainderl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] remainderl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float remquof (float, float, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe float remquof (float, float, int*);

		// extern float remquof (float, float, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe float remquof (float, float, int*);

		// extern double remquo (double, double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe double remquo (double, double, int*);

		// extern double remquo (double, double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe double remquo (double, double, int*);

		// extern long double remquol (long double, long double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] remquol ([unsupported Builtin: long double], [unsupported Builtin: long double], int*);

		// extern long double remquol (long double, long double, int *)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] remquol ([unsupported Builtin: long double], [unsupported Builtin: long double], int*);

		// extern float copysignf (float, float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float copysignf (float, float);

		// extern float copysignf (float, float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float copysignf (float, float);

		// extern double copysign (double, double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double copysign (double, double);

		// extern double copysign (double, double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double copysign (double, double);

		// extern long double copysignl (long double, long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] copysignl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double copysignl (long double, long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] copysignl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float nanf (const char *)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern unsafe float nanf (sbyte*);

		// extern float nanf (const char *)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern unsafe float nanf (sbyte*);

		// extern double nan (const char *)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern unsafe double nan (sbyte*);

		// extern double nan (const char *)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern unsafe double nan (sbyte*);

		// extern long double nanl (const char *)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] nanl (sbyte*);

		// extern long double nanl (const char *)  __attribute__((nothrow)) __attribute__((pure));
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] nanl (sbyte*);

		// extern float nextafterf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float nextafterf (float, float);

		// extern float nextafterf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float nextafterf (float, float);

		// extern double nextafter (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double nextafter (double, double);

		// extern double nextafter (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double nextafter (double, double);

		// extern long double nextafterl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] nextafterl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double nextafterl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] nextafterl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern double nexttoward (double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double nexttoward (double, [unsupported Builtin: long double]);

		// extern double nexttoward (double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double nexttoward (double, [unsupported Builtin: long double]);

		// extern float nexttowardf (float, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float nexttowardf (float, [unsupported Builtin: long double]);

		// extern float nexttowardf (float, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float nexttowardf (float, [unsupported Builtin: long double]);

		// extern long double nexttowardl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] nexttowardl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double nexttowardl (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] nexttowardl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float fdimf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float fdimf (float, float);

		// extern float fdimf (float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float fdimf (float, float);

		// extern double fdim (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double fdim (double, double);

		// extern double fdim (double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double fdim (double, double);

		// extern long double fdiml (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fdiml ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double fdiml (long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fdiml ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float fmaxf (float, float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float fmaxf (float, float);

		// extern float fmaxf (float, float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float fmaxf (float, float);

		// extern double fmax (double, double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double fmax (double, double);

		// extern double fmax (double, double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double fmax (double, double);

		// extern long double fmaxl (long double, long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fmaxl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double fmaxl (long double, long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fmaxl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float fminf (float, float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float fminf (float, float);

		// extern float fminf (float, float)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern float fminf (float, float);

		// extern double fmin (double, double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double fmin (double, double);

		// extern double fmin (double, double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern double fmin (double, double);

		// extern long double fminl (long double, long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fminl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double fminl (long double, long double)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fminl ([unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float fmaf (float, float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float fmaf (float, float, float);

		// extern float fmaf (float, float, float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float fmaf (float, float, float);

		// extern double fma (double, double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double fma (double, double, double);

		// extern double fma (double, double, double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double fma (double, double, double);

		// extern long double fmal (long double, long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fmal ([unsupported Builtin: long double], [unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern long double fmal (long double, long double, long double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern [unsupported Builtin: long double] fmal ([unsupported Builtin: long double], [unsupported Builtin: long double], [unsupported Builtin: long double]);

		// extern float __exp10f (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float __exp10f (float);

		// extern float __exp10f (float)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern float __exp10f (float);

		// extern double __exp10 (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double __exp10 (double);

		// extern double __exp10 (double)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern double __exp10 (double);

		// extern void __sincosf (float __x, float *__sinp, float *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincosf (float __x, float* __sinp, float* __cosp);

		// extern void __sincos (double __x, double *__sinp, double *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincos (double __x, double* __sinp, double* __cosp);

		// extern float __cospif (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float __cospif (float);

		// extern float __cospif (float)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern float __cospif (float);

		// extern double __cospi (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double __cospi (double);

		// extern double __cospi (double)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern double __cospi (double);

		// extern float __sinpif (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float __sinpif (float);

		// extern float __sinpif (float)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern float __sinpif (float);

		// extern double __sinpi (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double __sinpi (double);

		// extern double __sinpi (double)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern double __sinpi (double);

		// extern float __tanpif (float)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern float __tanpif (float);

		// extern float __tanpif (float)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern float __tanpif (float);

		// extern double __tanpi (double)  __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern double __tanpi (double);

		// extern double __tanpi (double)  __attribute__((const)) __attribute__((nothrow)) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern double __tanpi (double);

		// extern void __sincospif (float __x, float *__sinp, float *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincospif (float __x, float* __sinp, float* __cosp);

		// extern void __sincospi (double __x, double *__sinp, double *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincospi (double __x, double* __sinp, double* __cosp);

		// extern struct __float2 __sincosf_stret (float);
		[DllImport ("__Internal")]
		static extern __float2 __sincosf_stret (float);

		// extern struct __double2 __sincos_stret (double);
		[DllImport ("__Internal")]
		static extern __double2 __sincos_stret (double);

		// extern struct __float2 __sincospif_stret (float);
		[DllImport ("__Internal")]
		static extern __float2 __sincospif_stret (float);

		// extern struct __double2 __sincospi_stret (double);
		[DllImport ("__Internal")]
		static extern __double2 __sincospi_stret (double);

		// extern void __sincosf (float __x, float *__sinp, float *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincosf (float __x, float* __sinp, float* __cosp);

		// extern void __sincos (double __x, double *__sinp, double *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincos (double __x, double* __sinp, double* __cosp);

		// extern void __sincospif (float __x, float *__sinp, float *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincospif (float __x, float* __sinp, float* __cosp);

		// extern void __sincospi (double __x, double *__sinp, double *__cosp) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe void __sincospi (double __x, double* __sinp, double* __cosp);

		// extern double j0 (double) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.2)));
		[Mac (10,0), iOS (3,2)]
		[DllImport ("__Internal")]
		static extern double j0 (double);

		// extern double j1 (double) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.2)));
		[Mac (10,0), iOS (3,2)]
		[DllImport ("__Internal")]
		static extern double j1 (double);

		// extern double jn (int, double) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.2)));
		[Mac (10,0), iOS (3,2)]
		[DllImport ("__Internal")]
		static extern double jn (int, double);

		// extern double y0 (double) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.2)));
		[Mac (10,0), iOS (3,2)]
		[DllImport ("__Internal")]
		static extern double y0 (double);

		// extern double y1 (double) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.2)));
		[Mac (10,0), iOS (3,2)]
		[DllImport ("__Internal")]
		static extern double y1 (double);

		// extern double yn (int, double) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.2)));
		[Mac (10,0), iOS (3,2)]
		[DllImport ("__Internal")]
		static extern double yn (int, double);

		// extern double scalb (double, double);
		[DllImport ("__Internal")]
		static extern double scalb (double, double);

		// extern int setjmp (int *)  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern unsafe int setjmp (int*);

		// extern int setjmp (int *)  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern int setjmp (int[]);

		// extern void longjmp (int *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe void longjmp (int*, int);

		// extern void longjmp (int *, int) ;
		[DllImport ("__Internal")]
		static extern void longjmp (int[], int);

		// extern int _setjmp (int *)  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern unsafe int _setjmp (int*);

		// extern int _setjmp (int *)  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern int _setjmp (int[]);

		// extern void _longjmp (int *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe void _longjmp (int*, int);

		// extern void _longjmp (int *, int) ;
		[DllImport ("__Internal")]
		static extern void _longjmp (int[], int);

		// extern int sigsetjmp (int *, int)  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern unsafe int sigsetjmp (int*, int);

		// extern int sigsetjmp (int *, int)  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern int sigsetjmp (int[], int);

		// extern void siglongjmp (int *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe void siglongjmp (int*, int);

		// extern void siglongjmp (int *, int) ;
		[DllImport ("__Internal")]
		static extern void siglongjmp (int[], int);

		// extern void longjmperror ();
		[DllImport ("__Internal")]
		static extern void longjmperror ();

		// extern void (*)(int) signal (int, void (*)(int));
		[DllImport ("__Internal")]
		static extern unsafe Action<int>* signal (int, Action<int>*);

		// extern int raise (int);
		[DllImport ("__Internal")]
		static extern int raise (int);

		// extern void (* _Nullable)(int) bsd_signal (int, void (* _Nullable)(int));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe Action<int>* bsd_signal (int, [NullAllowed] Action<int>*);

		// extern int kill (pid_t, int) asm("_kill");
		[DllImport ("__Internal")]
		static extern int kill (int, int);

		// extern int killpg (pid_t, int) asm("_killpg");
		[DllImport ("__Internal")]
		static extern int killpg (int, int);

		// extern int pthread_kill (pthread_t, int);
		[DllImport ("__Internal")]
		static extern unsafe int pthread_kill (pthread_t*, int);

		// extern int pthread_sigmask (int, const sigset_t *, sigset_t *) asm("_pthread_sigmask");
		[DllImport ("__Internal")]
		static extern unsafe int pthread_sigmask (int, uint*, uint*);

		// extern int sigaction (int, const struct sigaction *__restrict, struct sigaction *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe int sigaction (int, sigaction*, sigaction*);

		// extern int sigaddset (sigset_t *, int);
		[DllImport ("__Internal")]
		static extern unsafe int sigaddset (uint*, int);

		// extern int sigaltstack (const stack_t *__restrict, stack_t *__restrict) asm("_sigaltstack") __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int sigaltstack (stack_t*, stack_t*);

		// extern int sigdelset (sigset_t *, int);
		[DllImport ("__Internal")]
		static extern unsafe int sigdelset (uint*, int);

		// extern int sigemptyset (sigset_t *);
		[DllImport ("__Internal")]
		static extern unsafe int sigemptyset (uint*);

		// extern int sigfillset (sigset_t *);
		[DllImport ("__Internal")]
		static extern unsafe int sigfillset (uint*);

		// extern int sighold (int);
		[DllImport ("__Internal")]
		static extern int sighold (int);

		// extern int sigignore (int);
		[DllImport ("__Internal")]
		static extern int sigignore (int);

		// extern int siginterrupt (int, int);
		[DllImport ("__Internal")]
		static extern int siginterrupt (int, int);

		// extern int sigismember (const sigset_t *, int);
		[DllImport ("__Internal")]
		static extern unsafe int sigismember (uint*, int);

		// extern int sigpause (int) asm("_sigpause");
		[DllImport ("__Internal")]
		static extern int sigpause (int);

		// extern int sigpending (sigset_t *);
		[DllImport ("__Internal")]
		static extern unsafe int sigpending (uint*);

		// extern int sigprocmask (int, const sigset_t *__restrict, sigset_t *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe int sigprocmask (int, uint*, uint*);

		// extern int sigrelse (int);
		[DllImport ("__Internal")]
		static extern int sigrelse (int);

		// extern void (* _Nullable)(int) sigset (int, void (* _Nullable)(int));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe Action<int>* sigset (int, [NullAllowed] Action<int>*);

		// extern int sigsuspend (const sigset_t *) asm("_sigsuspend");
		[DllImport ("__Internal")]
		static extern unsafe int sigsuspend (uint*);

		// extern int sigwait (const sigset_t *__restrict, int *__restrict) asm("_sigwait");
		[DllImport ("__Internal")]
		static extern unsafe int sigwait (uint*, int*);

		// extern void psignal (unsigned int, const char *);
		[DllImport ("__Internal")]
		static extern unsafe void psignal (uint, sbyte*);

		// extern int sigblock (int);
		[DllImport ("__Internal")]
		static extern int sigblock (int);

		// extern int sigsetmask (int);
		[DllImport ("__Internal")]
		static extern int sigsetmask (int);

		// extern int sigvec (int, struct sigvec *, struct sigvec *);
		[DllImport ("__Internal")]
		static extern unsafe int sigvec (int, sigvec*, sigvec*);

		// extern int __sigbits (int __signo) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern int __sigbits (int __signo);

		// extern int renameat (int, const char *, int, const char *) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int renameat (int, sbyte*, int, sbyte*);

		// extern int renamex_np (const char *, const char *, unsigned int) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int renamex_np (sbyte*, sbyte*, uint);

		// extern int renameatx_np (int, const char *, int, const char *, unsigned int) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int renameatx_np (int, sbyte*, int, sbyte*, uint);

		// extern void clearerr (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe void clearerr (FILE*);

		// extern int fclose (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int fclose (FILE*);

		// extern int feof (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int feof (FILE*);

		// extern int ferror (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int ferror (FILE*);

		// extern int fflush (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int fflush (FILE*);

		// extern int fgetc (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int fgetc (FILE*);

		// extern int fgetpos (FILE *__restrict, fpos_t *);
		[DllImport ("__Internal")]
		static extern unsafe int fgetpos (FILE*, long*);

		// extern char * fgets (char *__restrict, int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* fgets (sbyte*, int, FILE*);

		// extern FILE * fopen (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe FILE* fopen (sbyte*, sbyte*);

		// extern FILE * fopen (const char *__restrict __filename, const char *__restrict __mode)  asm("_fopen");
		[DllImport ("__Internal")]
		static extern unsafe FILE* fopen (sbyte* __filename, sbyte* __mode);

		// extern int fprintf (FILE *, const char *, ...)  __attribute__((format(printf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int fprintf (FILE*, sbyte*, IntPtr varArgs);

		// extern int fprintf (FILE *__restrict, const char *__restrict, ...)  __attribute__((format(printf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int fprintf (FILE*, sbyte*, IntPtr varArgs);

		// extern int fputc (int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int fputc (int, FILE*);

		// extern int fputs (const char *__restrict, FILE *__restrict) asm("_fputs");
		[DllImport ("__Internal")]
		static extern unsafe int fputs (sbyte*, FILE*);

		// extern unsigned long fread (void *, unsigned long, unsigned long, FILE *) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint fread (void*, nuint, nuint, FILE*);

		// extern unsigned long fread (void *__restrict __ptr, size_t __size, size_t __nitems, FILE *__restrict __stream) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint fread (void* __ptr, nuint __size, nuint __nitems, FILE* __stream);

		// extern FILE * freopen (const char *__restrict, const char *__restrict, FILE *__restrict) asm("_freopen");
		[DllImport ("__Internal")]
		static extern unsafe FILE* freopen (sbyte*, sbyte*, FILE*);

		// extern int fscanf (FILE *__restrict, const char *__restrict, ...)  __attribute__((format(scanf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int fscanf (FILE*, sbyte*, IntPtr varArgs);

		// extern int fscanf (FILE *__restrict, const char *__restrict, ...)  __attribute__((format(scanf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int fscanf (FILE*, sbyte*, IntPtr varArgs);

		// extern int fseek (FILE *, long, int);
		[DllImport ("__Internal")]
		static extern unsafe int fseek (FILE*, nint, int);

		// extern int fsetpos (FILE *, const fpos_t *);
		[DllImport ("__Internal")]
		static extern unsafe int fsetpos (FILE*, long*);

		// extern long ftell (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe nint ftell (FILE*);

		// extern unsigned long fwrite (const void *, unsigned long, unsigned long, FILE *) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint fwrite (void*, nuint, nuint, FILE*);

		// extern unsigned long fwrite (const void *__restrict __ptr, size_t __size, size_t __nitems, FILE *__restrict __stream)  asm("_fwrite");
		[DllImport ("__Internal")]
		static extern unsafe nuint fwrite (void* __ptr, nuint __size, nuint __nitems, FILE* __stream);

		// extern int getc (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int getc (FILE*);

		// extern int getchar ();
		[DllImport ("__Internal")]
		static extern int getchar ();

		// extern char * gets (char *) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of gets(3), it is highly recommended that you use fgets(3) instead.")));
		[DllImport ("__Internal")]
		static extern unsafe sbyte* gets (sbyte*);

		// extern void perror (const char *) __attribute__((cold));
		[DllImport ("__Internal")]
		static extern unsafe void perror (sbyte*);

		// extern int printf (const char *, ...)  __attribute__((format(printf, 1, 2)));
		[DllImport ("__Internal")]
		static extern unsafe int printf (sbyte*, IntPtr varArgs);

		// extern int printf (const char *__restrict, ...)  __attribute__((format(printf, 1, 2)));
		[DllImport ("__Internal")]
		static extern unsafe int printf (sbyte*, IntPtr varArgs);

		// extern int putc (int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int putc (int, FILE*);

		// extern int putchar (int);
		[DllImport ("__Internal")]
		static extern int putchar (int);

		// extern int puts (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int puts (sbyte*);

		// extern int remove (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int remove (sbyte*);

		// extern int rename (const char *__old, const char *__new);
		[DllImport ("__Internal")]
		static extern unsafe int rename (sbyte* __old, sbyte* __new);

		// extern void rewind (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe void rewind (FILE*);

		// extern int scanf (const char *__restrict, ...)  __attribute__((format(scanf, 1, 2)));
		[DllImport ("__Internal")]
		static extern unsafe int scanf (sbyte*, IntPtr varArgs);

		// extern int scanf (const char *__restrict, ...)  __attribute__((format(scanf, 1, 2)));
		[DllImport ("__Internal")]
		static extern unsafe int scanf (sbyte*, IntPtr varArgs);

		// extern void setbuf (FILE *__restrict, char *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe void setbuf (FILE*, sbyte*);

		// extern int setvbuf (FILE *__restrict, char *__restrict, int, size_t);
		[DllImport ("__Internal")]
		static extern unsafe int setvbuf (FILE*, sbyte*, int, nuint);

		// extern int sprintf (char *, const char *, ...)  __attribute__((format(printf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int sprintf (sbyte*, sbyte*, IntPtr varArgs);

		// extern int sprintf (char *__restrict, const char *__restrict, ...)  __attribute__((availability(swift, unavailable))) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of sprintf(3), it is highly recommended that you use snprintf(3) instead."))) __attribute__((format(printf, 2, 3)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe int sprintf (sbyte*, sbyte*, IntPtr varArgs);

		// extern int sscanf (const char *__restrict, const char *__restrict, ...)  __attribute__((format(scanf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int sscanf (sbyte*, sbyte*, IntPtr varArgs);

		// extern int sscanf (const char *__restrict, const char *__restrict, ...)  __attribute__((format(scanf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int sscanf (sbyte*, sbyte*, IntPtr varArgs);

		// extern FILE * tmpfile ();
		[DllImport ("__Internal")]
		static extern unsafe FILE* tmpfile ();

		// extern char * tmpnam (char *) __attribute__((availability(swift, unavailable))) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of tmpnam(3), it is highly recommended that you use mkstemp(3) instead.")));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* tmpnam (sbyte*);

		// extern int ungetc (int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int ungetc (int, FILE*);

		// extern int vfprintf (FILE *, const char *, __builtin_va_list)  __attribute__((format(printf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vfprintf (FILE*, sbyte*, sbyte*);

		// extern int vfprintf (FILE *__restrict, const char *__restrict, va_list)  __attribute__((format(printf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vfprintf (FILE*, sbyte*, sbyte*);

		// extern int vprintf (const char *, __builtin_va_list)  __attribute__((format(printf, 1, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vprintf (sbyte*, sbyte*);

		// extern int vprintf (const char *__restrict, va_list)  __attribute__((format(printf, 1, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vprintf (sbyte*, sbyte*);

		// extern int vsprintf (char *, const char *, __builtin_va_list)  __attribute__((format(printf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vsprintf (sbyte*, sbyte*, sbyte*);

		// extern int vsprintf (char *__restrict, const char *__restrict, va_list)  __attribute__((availability(swift, unavailable))) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of sprintf(3), it is highly recommended that you use vsnprintf(3) instead."))) __attribute__((format(printf, 2, 0)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe int vsprintf (sbyte*, sbyte*, sbyte*);

		// extern char * ctermid (char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ctermid (sbyte*);

		// extern FILE * fdopen (int, const char *) asm("_fdopen");
		[DllImport ("__Internal")]
		static extern unsafe FILE* fdopen (int, sbyte*);

		// extern int fileno (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int fileno (FILE*);

		// extern int pclose (FILE *) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe int pclose (FILE*);

		// extern FILE * popen (const char *, const char *) asm("_popen") __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe FILE* popen (sbyte*, sbyte*);

		// extern int __srget (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int __srget (FILE*);

		// extern int __svfscanf (FILE *, const char *, va_list) __attribute__((format(scanf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int __svfscanf (FILE*, sbyte*, sbyte*);

		// extern int __swbuf (int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int __swbuf (int, FILE*);

		// extern int __sputc (int _c, FILE *_p) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe int __sputc (int _c, FILE* _p);

		// extern void flockfile (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe void flockfile (FILE*);

		// extern int ftrylockfile (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int ftrylockfile (FILE*);

		// extern void funlockfile (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe void funlockfile (FILE*);

		// extern int getc_unlocked (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int getc_unlocked (FILE*);

		// extern int getchar_unlocked ();
		[DllImport ("__Internal")]
		static extern int getchar_unlocked ();

		// extern int putc_unlocked (int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int putc_unlocked (int, FILE*);

		// extern int putchar_unlocked (int);
		[DllImport ("__Internal")]
		static extern int putchar_unlocked (int);

		// extern int getw (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int getw (FILE*);

		// extern int putw (int, FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int putw (int, FILE*);

		// extern char * tempnam (const char *__dir, const char *__prefix) asm("_tempnam") __attribute__((availability(swift, unavailable))) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of tempnam(3), it is highly recommended that you use mkstemp(3) instead.")));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* tempnam (sbyte* __dir, sbyte* __prefix);

		// extern int fseeko (FILE *__stream, off_t __offset, int __whence);
		[DllImport ("__Internal")]
		static extern unsafe int fseeko (FILE* __stream, long __offset, int __whence);

		// extern off_t ftello (FILE *__stream);
		[DllImport ("__Internal")]
		static extern unsafe long ftello (FILE* __stream);

		// extern int snprintf (char *, unsigned long, const char *, ...)  __attribute__((format(printf, 3, 4)));
		[DllImport ("__Internal")]
		static extern unsafe int snprintf (sbyte*, nuint, sbyte*, IntPtr varArgs);

		// extern int snprintf (char *__restrict __str, size_t __size, const char *__restrict __format, ...)  __attribute__((format(printf, 3, 4)));
		[DllImport ("__Internal")]
		static extern unsafe int snprintf (sbyte* __str, nuint __size, sbyte* __format, IntPtr varArgs);

		// extern int vfscanf (FILE *__restrict, const char *__restrict, __builtin_va_list)  __attribute__((format(scanf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vfscanf (FILE*, sbyte*, sbyte*);

		// extern int vfscanf (FILE *__restrict __stream, const char *__restrict __format, va_list)  __attribute__((format(scanf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vfscanf (FILE* __stream, sbyte* __format, sbyte*);

		// extern int vscanf (const char *__restrict, __builtin_va_list)  __attribute__((format(scanf, 1, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vscanf (sbyte*, sbyte*);

		// extern int vscanf (const char *__restrict __format, va_list)  __attribute__((format(scanf, 1, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vscanf (sbyte* __format, sbyte*);

		// extern int vsnprintf (char *, unsigned long, const char *, __builtin_va_list)  __attribute__((format(printf, 3, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vsnprintf (sbyte*, nuint, sbyte*, sbyte*);

		// extern int vsnprintf (char *__restrict __str, size_t __size, const char *__restrict __format, va_list)  __attribute__((format(printf, 3, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vsnprintf (sbyte* __str, nuint __size, sbyte* __format, sbyte*);

		// extern int vsscanf (const char *__restrict, const char *__restrict, __builtin_va_list)  __attribute__((format(scanf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vsscanf (sbyte*, sbyte*, sbyte*);

		// extern int vsscanf (const char *__restrict __str, const char *__restrict __format, va_list)  __attribute__((format(scanf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vsscanf (sbyte* __str, sbyte* __format, sbyte*);

		// extern int dprintf (int, const char *__restrict, ...) __attribute__((format(printf, 2, 3))) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe int dprintf (int, sbyte*, IntPtr varArgs);

		// extern int vdprintf (int, const char *__restrict, va_list) __attribute__((format(printf, 2, 0))) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe int vdprintf (int, sbyte*, sbyte*);

		// extern ssize_t getdelim (char **__restrict __linep, size_t *__restrict __linecapp, int __delimiter, FILE *__restrict __stream) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe nint getdelim (sbyte** __linep, nuint* __linecapp, int __delimiter, FILE* __stream);

		// extern ssize_t getline (char **__restrict __linep, size_t *__restrict __linecapp, FILE *__restrict __stream) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe nint getline (sbyte** __linep, nuint* __linecapp, FILE* __stream);

		// extern FILE * fmemopen (void *__restrict __buf, size_t __size, const char *__restrict __mode) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe FILE* fmemopen (void* __buf, nuint __size, sbyte* __mode);

		// extern FILE * open_memstream (char **__bufp, size_t *__sizep) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe FILE* open_memstream (sbyte** __bufp, nuint* __sizep);

		// extern int asprintf (char **__restrict, const char *__restrict, ...) __attribute__((format(printf, 2, 3)));
		[DllImport ("__Internal")]
		static extern unsafe int asprintf (sbyte**, sbyte*, IntPtr varArgs);

		// extern char * ctermid_r (char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ctermid_r (sbyte*);

		// extern char * fgetln (FILE *, size_t *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* fgetln (FILE*, nuint*);

		// extern const char * fmtcheck (const char *, const char *) __attribute__((format_arg(2)));
		[DllImport ("__Internal")]
		static extern unsafe sbyte* fmtcheck (sbyte*, sbyte*);

		// extern int fpurge (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int fpurge (FILE*);

		// extern void setbuffer (FILE *, char *, int);
		[DllImport ("__Internal")]
		static extern unsafe void setbuffer (FILE*, sbyte*, int);

		// extern int setlinebuf (FILE *);
		[DllImport ("__Internal")]
		static extern unsafe int setlinebuf (FILE*);

		// extern int vasprintf (char **__restrict, const char *__restrict, va_list) __attribute__((format(printf, 2, 0)));
		[DllImport ("__Internal")]
		static extern unsafe int vasprintf (sbyte**, sbyte*, sbyte*);

		// extern FILE * funopen (const void *, int (* _Nullable)(void *, char *, int), int (* _Nullable)(void *, const char *, int), fpos_t (* _Nullable)(void *, fpos_t, int), int (* _Nullable)(void *));
		[DllImport ("__Internal")]
		static extern unsafe FILE* funopen (void*, [NullAllowed] Func<void*, sbyte*, int, int>*, [NullAllowed] Func<void*, sbyte*, int, int>*, [NullAllowed] Func<void*, long, int, long>*, [NullAllowed] Func<void*, int>*);

		// extern int __sprintf_chk (char *__restrict, int, size_t, const char *__restrict, ...);
		[DllImport ("__Internal")]
		static extern unsafe int __sprintf_chk (sbyte*, int, nuint, sbyte*, IntPtr varArgs);

		// extern int __snprintf_chk (char *__restrict, size_t, int, size_t, const char *__restrict, ...);
		[DllImport ("__Internal")]
		static extern unsafe int __snprintf_chk (sbyte*, nuint, int, nuint, sbyte*, IntPtr varArgs);

		// extern int __vsprintf_chk (char *__restrict, int, size_t, const char *__restrict, va_list);
		[DllImport ("__Internal")]
		static extern unsafe int __vsprintf_chk (sbyte*, int, nuint, sbyte*, sbyte*);

		// extern int __vsnprintf_chk (char *__restrict, size_t, int, size_t, const char *__restrict, va_list);
		[DllImport ("__Internal")]
		static extern unsafe int __vsnprintf_chk (sbyte*, nuint, int, nuint, sbyte*, sbyte*);

		// extern int getpriority (int, id_t);
		[DllImport ("__Internal")]
		static extern int getpriority (int, uint);

		// extern int getiopolicy_np (int, int) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern int getiopolicy_np (int, int);

		// extern int getrlimit (int, struct rlimit *) asm("_getrlimit");
		[DllImport ("__Internal")]
		static extern unsafe int getrlimit (int, rlimit*);

		// extern int getrusage (int, struct rusage *);
		[DllImport ("__Internal")]
		static extern unsafe int getrusage (int, rusage*);

		// extern int setpriority (int, id_t, int);
		[DllImport ("__Internal")]
		static extern int setpriority (int, uint, int);

		// extern int setiopolicy_np (int, int, int) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern int setiopolicy_np (int, int, int);

		// extern int setrlimit (int, const struct rlimit *) asm("_setrlimit");
		[DllImport ("__Internal")]
		static extern unsafe int setrlimit (int, rlimit*);

		// extern pid_t wait (int *) asm("_wait");
		[DllImport ("__Internal")]
		static extern unsafe int wait (int*);

		// extern pid_t waitpid (pid_t, int *, int) asm("_waitpid");
		[DllImport ("__Internal")]
		static extern unsafe int waitpid (int, int*, int);

		// extern int waitid (idtype_t, id_t, siginfo_t *, int) asm("_waitid");
		[DllImport ("__Internal")]
		static extern unsafe int waitid (idtype_t, uint, siginfo_t*, int);

		// extern pid_t wait3 (int *, int, struct rusage *);
		[DllImport ("__Internal")]
		static extern unsafe int wait3 (int*, int, rusage*);

		// extern pid_t wait4 (pid_t, int *, int, struct rusage *);
		[DllImport ("__Internal")]
		static extern unsafe int wait4 (int, int*, int, rusage*);

		// extern void * alloca (unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void* alloca (nuint);

		// extern void * alloca (size_t) ;
		[DllImport ("__Internal")]
		static extern unsafe void* alloca (nuint);

		// extern void * malloc (unsigned long)  __attribute__((alloc_size(1)));
		[DllImport ("__Internal")]
		static extern unsafe void* malloc (nuint);

		// extern void * malloc (size_t __size)  __attribute__((warn_unused_result(""))) __attribute__((alloc_size(1))) __attribute__((alloc_size(1)));
		[DllImport ("__Internal")]
		static extern unsafe void* malloc (nuint __size);

		// extern void * calloc (unsigned long, unsigned long)  __attribute__((alloc_size(1, 2)));
		[DllImport ("__Internal")]
		static extern unsafe void* calloc (nuint, nuint);

		// extern void * calloc (size_t __count, size_t __size)  __attribute__((warn_unused_result(""))) __attribute__((alloc_size(1, 2))) __attribute__((alloc_size(1, 2)));
		[DllImport ("__Internal")]
		static extern unsafe void* calloc (nuint __count, nuint __size);

		// extern void free (void *) ;
		[DllImport ("__Internal")]
		static extern unsafe void free (void*);

		// extern void free (void *) ;
		[DllImport ("__Internal")]
		static extern unsafe void free (void*);

		// extern void * realloc (void *, unsigned long)  __attribute__((alloc_size(2)));
		[DllImport ("__Internal")]
		static extern unsafe void* realloc (void*, nuint);

		// extern void * realloc (void *__ptr, size_t __size)  __attribute__((warn_unused_result(""))) __attribute__((alloc_size(2))) __attribute__((alloc_size(2)));
		[DllImport ("__Internal")]
		static extern unsafe void* realloc (void* __ptr, nuint __size);

		// extern void * valloc (size_t) __attribute__((alloc_size(1)));
		[DllImport ("__Internal")]
		static extern unsafe void* valloc (nuint);

		// extern void * aligned_alloc (unsigned long, unsigned long)  __attribute__((alloc_align(1))) __attribute__((alloc_size(2)));
		[DllImport ("__Internal")]
		static extern unsafe void* aligned_alloc (nuint, nuint);

		// extern void * aligned_alloc (size_t __alignment, size_t __size)  __attribute__((alloc_align(1))) __attribute__((warn_unused_result(""))) __attribute__((alloc_size(2))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((alloc_size(2)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* aligned_alloc (nuint __alignment, nuint __size);

		// extern int posix_memalign (void **__memptr, size_t __alignment, size_t __size) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe int posix_memalign (void** __memptr, nuint __alignment, nuint __size);

		// extern void abort () ;
		[DllImport ("__Internal")]
		static extern void abort ();

		// extern void abort ()  __attribute__((cold));
		[DllImport ("__Internal")]
		static extern void abort ();

		// extern int abs (int)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern int abs (int);

		// extern int abs (int)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern int abs (int);

		// extern int atexit (void (* _Nonnull)(void));
		[DllImport ("__Internal")]
		static extern unsafe int atexit (Action*);

		// extern double atof (const char *);
		[DllImport ("__Internal")]
		static extern unsafe double atof (sbyte*);

		// extern int atoi (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int atoi (sbyte*);

		// extern long atol (const char *);
		[DllImport ("__Internal")]
		static extern unsafe nint atol (sbyte*);

		// extern long long atoll (const char *);
		[DllImport ("__Internal")]
		static extern unsafe long atoll (sbyte*);

		// extern void * bsearch (const void *__key, const void *__base, size_t __nel, size_t __width, int (* _Nonnull)(const void *, const void *) __compar);
		[DllImport ("__Internal")]
		static extern unsafe void* bsearch (void* __key, void* __base, nuint __nel, nuint __width, Func<void*, void*, int>* __compar);

		// extern div_t div (int, int) __attribute__((const));
		[DllImport ("__Internal")]
		static extern div_t div (int, int);

		// extern void exit (int) ;
		[DllImport ("__Internal")]
		static extern void exit (int);

		// extern void exit (int) ;
		[DllImport ("__Internal")]
		static extern void exit (int);

		// extern char * getenv (const char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getenv (sbyte*);

		// extern long labs (long)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern nint labs (nint);

		// extern long labs (long)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern nint labs (nint);

		// extern ldiv_t ldiv (long, long) __attribute__((const));
		[DllImport ("__Internal")]
		static extern ldiv_t ldiv (nint, nint);

		// extern long long llabs (long long)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern long llabs (long);

		// extern long long llabs (long long)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern long llabs (long);

		// extern lldiv_t lldiv (long long, long long);
		[DllImport ("__Internal")]
		static extern lldiv_t lldiv (long, long);

		// extern int mblen (const char *__s, size_t __n);
		[DllImport ("__Internal")]
		static extern unsafe int mblen (sbyte* __s, nuint __n);

		// extern size_t mbstowcs (wchar_t *__restrict, const char *__restrict, size_t);
		[DllImport ("__Internal")]
		static extern unsafe nuint mbstowcs (int*, sbyte*, nuint);

		// extern int mbtowc (wchar_t *__restrict, const char *__restrict, size_t);
		[DllImport ("__Internal")]
		static extern unsafe int mbtowc (int*, sbyte*, nuint);

		// extern void qsort (void *__base, size_t __nel, size_t __width, int (* _Nonnull)(const void *, const void *) __compar);
		[DllImport ("__Internal")]
		static extern unsafe void qsort (void* __base, nuint __nel, nuint __width, Func<void*, void*, int>* __compar);

		// extern int rand () __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern int rand ();

		// extern void srand (unsigned int) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern void srand (uint);

		// extern double strtod (const char *, char **) ;
		[DllImport ("__Internal")]
		static extern unsafe double strtod (sbyte*, sbyte**);

		// extern double strtod (const char *, char **)  asm("_strtod");
		[DllImport ("__Internal")]
		static extern unsafe double strtod (sbyte*, sbyte**);

		// extern float strtof (const char *, char **) ;
		[DllImport ("__Internal")]
		static extern unsafe float strtof (sbyte*, sbyte**);

		// extern float strtof (const char *, char **)  asm("_strtof");
		[DllImport ("__Internal")]
		static extern unsafe float strtof (sbyte*, sbyte**);

		// extern long strtol (const char *, char **, int) ;
		[DllImport ("__Internal")]
		static extern unsafe nint strtol (sbyte*, sbyte**, int);

		// extern long strtol (const char *__str, char **__endptr, int __base) ;
		[DllImport ("__Internal")]
		static extern unsafe nint strtol (sbyte* __str, sbyte** __endptr, int __base);

		// extern long double strtold (const char *, char **) ;
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] strtold (sbyte*, sbyte**);

		// extern long double strtold (const char *, char **) ;
		[DllImport ("__Internal")]
		static extern unsafe [unsupported Builtin: long double] strtold (sbyte*, sbyte**);

		// extern long long strtoll (const char *, char **, int) ;
		[DllImport ("__Internal")]
		static extern unsafe long strtoll (sbyte*, sbyte**, int);

		// extern long long strtoll (const char *__str, char **__endptr, int __base) ;
		[DllImport ("__Internal")]
		static extern unsafe long strtoll (sbyte* __str, sbyte** __endptr, int __base);

		// extern unsigned long strtoul (const char *, char **, int) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strtoul (sbyte*, sbyte**, int);

		// extern unsigned long strtoul (const char *__str, char **__endptr, int __base) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strtoul (sbyte* __str, sbyte** __endptr, int __base);

		// extern unsigned long long strtoull (const char *, char **, int) ;
		[DllImport ("__Internal")]
		static extern unsafe ulong strtoull (sbyte*, sbyte**, int);

		// extern unsigned long long strtoull (const char *__str, char **__endptr, int __base) ;
		[DllImport ("__Internal")]
		static extern unsafe ulong strtoull (sbyte* __str, sbyte** __endptr, int __base);

		// extern int system (const char *) asm("_system") __attribute__((availability(swift, unavailable))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int system (sbyte*);

		// extern size_t wcstombs (char *__restrict, const wchar_t *__restrict, size_t);
		[DllImport ("__Internal")]
		static extern unsafe nuint wcstombs (sbyte*, int*, nuint);

		// extern int wctomb (char *, wchar_t);
		[DllImport ("__Internal")]
		static extern unsafe int wctomb (sbyte*, int);

		// extern void _Exit (int) ;
		[DllImport ("__Internal")]
		static extern void _Exit (int);

		// extern void _Exit (int) ;
		[DllImport ("__Internal")]
		static extern void _Exit (int);

		// extern long a64l (const char *);
		[DllImport ("__Internal")]
		static extern unsafe nint a64l (sbyte*);

		// extern double drand48 ();
		[DllImport ("__Internal")]
		static extern double drand48 ();

		// extern char * ecvt (double, int, int *__restrict, int *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ecvt (double, int, int*, int*);

		// extern double erand48 (unsigned short *);
		[DllImport ("__Internal")]
		static extern double erand48 (ushort[]);

		// extern char * fcvt (double, int, int *__restrict, int *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* fcvt (double, int, int*, int*);

		// extern char * gcvt (double, int, char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* gcvt (double, int, sbyte*);

		// extern int getsubopt (char **, char *const *, char **);
		[DllImport ("__Internal")]
		static extern unsafe int getsubopt (sbyte**, sbyte**, sbyte**);

		// extern int grantpt (int);
		[DllImport ("__Internal")]
		static extern int grantpt (int);

		// extern char * initstate (unsigned int, char *, size_t);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* initstate (uint, sbyte*, nuint);

		// extern long jrand48 (unsigned short *) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern nint jrand48 (ushort[]);

		// extern char * l64a (long);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* l64a (nint);

		// extern void lcong48 (unsigned short *);
		[DllImport ("__Internal")]
		static extern void lcong48 (ushort[]);

		// extern long lrand48 () __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern nint lrand48 ();

		// extern char * mktemp (char *) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of mktemp(3), it is highly recommended that you use mkstemp(3) instead.")));
		[DllImport ("__Internal")]
		static extern unsafe sbyte* mktemp (sbyte*);

		// extern int mkstemp (char *);
		[DllImport ("__Internal")]
		static extern unsafe int mkstemp (sbyte*);

		// extern long mrand48 () __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern nint mrand48 ();

		// extern long nrand48 (unsigned short *) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern nint nrand48 (ushort[]);

		// extern int posix_openpt (int);
		[DllImport ("__Internal")]
		static extern int posix_openpt (int);

		// extern char * ptsname (int);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ptsname (int);

		// extern int ptsname_r (int fildes, char *buffer, size_t buflen) __attribute__((availability(macos, introduced=10.13.4))) __attribute__((availability(ios, introduced=11.3))) __attribute__((availability(tvos, introduced=11.3))) __attribute__((availability(watchos, introduced=4.3)));
		[Watch (4,3), TV (11,3), Mac (10,13,4), iOS (11,3)]
		[DllImport ("__Internal")]
		static extern unsafe int ptsname_r (int fildes, sbyte* buffer, nuint buflen);

		// extern int putenv (char *) asm("_putenv");
		[DllImport ("__Internal")]
		static extern unsafe int putenv (sbyte*);

		// extern long random () __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern nint random ();

		// extern int rand_r (unsigned int *) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe int rand_r (uint*);

		// extern char * realpath (const char *__restrict, char *__restrict) asm("_realpath$DARWIN_EXTSN");
		[DllImport ("__Internal")]
		static extern unsafe sbyte* realpath (sbyte*, sbyte*);

		// extern unsigned short * seed48 (unsigned short *);
		[DllImport ("__Internal")]
		static extern unsafe ushort* seed48 (ushort[]);

		// extern int setenv (const char *__name, const char *__value, int __overwrite) asm("_setenv");
		[DllImport ("__Internal")]
		static extern unsafe int setenv (sbyte* __name, sbyte* __value, int __overwrite);

		// extern void setkey (const char *) asm("_setkey");
		[DllImport ("__Internal")]
		static extern unsafe void setkey (sbyte*);

		// extern char * setstate (const char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* setstate (sbyte*);

		// extern void srand48 (long);
		[DllImport ("__Internal")]
		static extern void srand48 (nint);

		// extern void srandom (unsigned int);
		[DllImport ("__Internal")]
		static extern void srandom (uint);

		// extern int unlockpt (int);
		[DllImport ("__Internal")]
		static extern int unlockpt (int);

		// extern int unsetenv (const char *) asm("_unsetenv");
		[DllImport ("__Internal")]
		static extern unsafe int unsetenv (sbyte*);

		// extern uint32_t arc4random ();
		[DllImport ("__Internal")]
		static extern uint arc4random ();

		// extern void arc4random_addrandom (unsigned char *, int) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(macos, deprecated=10.12))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(ios, deprecated=10.0))) __attribute__((availability(tvos, introduced=2.0))) __attribute__((availability(tvos, deprecated=10.0))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(watchos, deprecated=3.0)));
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "use arc4random_stir")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "use arc4random_stir")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "use arc4random_stir")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "use arc4random_stir")]
		[Watch (1,0), TV (2,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void arc4random_addrandom (byte*, int);

		// extern void arc4random_buf (void *__buf, size_t __nbytes) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe void arc4random_buf (void* __buf, nuint __nbytes);

		// extern void arc4random_stir ();
		[DllImport ("__Internal")]
		static extern void arc4random_stir ();

		// extern uint32_t arc4random_uniform (uint32_t __upper_bound) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern uint arc4random_uniform (uint __upper_bound);

		// extern int atexit_b (void (^ _Nonnull)(void)) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern int atexit_b (Action);

		// extern void * bsearch_b (const void *__key, const void *__base, size_t __nel, size_t __width, __bsearch_noescape int (^)(const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void* bsearch_b (void* __key, void* __base, nuint __nel, nuint __width, Func<void*, void*, int> __compar);

		// extern char * cgetcap (char *, const char *, int);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* cgetcap (sbyte*, sbyte*, int);

		// extern int cgetclose ();
		[DllImport ("__Internal")]
		static extern int cgetclose ();

		// extern int cgetent (char **, char **, const char *);
		[DllImport ("__Internal")]
		static extern unsafe int cgetent (sbyte**, sbyte**, sbyte*);

		// extern int cgetfirst (char **, char **);
		[DllImport ("__Internal")]
		static extern unsafe int cgetfirst (sbyte**, sbyte**);

		// extern int cgetmatch (const char *, const char *);
		[DllImport ("__Internal")]
		static extern unsafe int cgetmatch (sbyte*, sbyte*);

		// extern int cgetnext (char **, char **);
		[DllImport ("__Internal")]
		static extern unsafe int cgetnext (sbyte**, sbyte**);

		// extern int cgetnum (char *, const char *, long *);
		[DllImport ("__Internal")]
		static extern unsafe int cgetnum (sbyte*, sbyte*, nint*);

		// extern int cgetset (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int cgetset (sbyte*);

		// extern int cgetstr (char *, const char *, char **);
		[DllImport ("__Internal")]
		static extern unsafe int cgetstr (sbyte*, sbyte*, sbyte**);

		// extern int cgetustr (char *, const char *, char **);
		[DllImport ("__Internal")]
		static extern unsafe int cgetustr (sbyte*, sbyte*, sbyte**);

		// extern int daemon (int, int) asm("_daemon") __attribute__((availability(ios, introduced=2.0, deprecated=2.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use posix_spawn APIs instead.")]
		[Deprecated (PlatformName.iOS, 2, 0, message: "Use posix_spawn APIs instead.")]
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern int daemon (int, int);

		// extern char * devname (dev_t, mode_t);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* devname (int, ushort);

		// extern char * devname_r (dev_t, mode_t, char *buf, int len);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* devname_r (int, ushort, sbyte* buf, int len);

		// extern char * getbsize (int *, long *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getbsize (int*, nint*);

		// extern int getloadavg (double *, int);
		[DllImport ("__Internal")]
		static extern int getloadavg (double[], int);

		// extern const char * getprogname ();
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getprogname ();

		// extern void setprogname (const char *);
		[DllImport ("__Internal")]
		static extern unsafe void setprogname (sbyte*);

		// extern int heapsort (void *__base, size_t __nel, size_t __width, int (* _Nonnull)(const void *, const void *) __compar);
		[DllImport ("__Internal")]
		static extern unsafe int heapsort (void* __base, nuint __nel, nuint __width, Func<void*, void*, int>* __compar);

		// extern int heapsort_b (void *__base, size_t __nel, size_t __width, __sort_noescape int (^)(const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe int heapsort_b (void* __base, nuint __nel, nuint __width, Func<void*, void*, int> __compar);

		// extern int mergesort (void *__base, size_t __nel, size_t __width, int (* _Nonnull)(const void *, const void *) __compar);
		[DllImport ("__Internal")]
		static extern unsafe int mergesort (void* __base, nuint __nel, nuint __width, Func<void*, void*, int>* __compar);

		// extern int mergesort_b (void *__base, size_t __nel, size_t __width, __sort_noescape int (^)(const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe int mergesort_b (void* __base, nuint __nel, nuint __width, Func<void*, void*, int> __compar);

		// extern void psort (void *__base, size_t __nel, size_t __width, int (* _Nonnull)(const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void psort (void* __base, nuint __nel, nuint __width, Func<void*, void*, int>* __compar);

		// extern void psort_b (void *__base, size_t __nel, size_t __width, __sort_noescape int (^)(const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void psort_b (void* __base, nuint __nel, nuint __width, Func<void*, void*, int> __compar);

		// extern void psort_r (void *__base, size_t __nel, size_t __width, void *, int (* _Nonnull)(void *, const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void psort_r (void* __base, nuint __nel, nuint __width, void*, Func<void*, void*, void*, int>* __compar);

		// extern void qsort_b (void *__base, size_t __nel, size_t __width, __sort_noescape int (^)(const void *, const void *) __compar) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void qsort_b (void* __base, nuint __nel, nuint __width, Func<void*, void*, int> __compar);

		// extern void qsort_r (void *__base, size_t __nel, size_t __width, void *, int (* _Nonnull)(void *, const void *, const void *) __compar);
		[DllImport ("__Internal")]
		static extern unsafe void qsort_r (void* __base, nuint __nel, nuint __width, void*, Func<void*, void*, void*, int>* __compar);

		// extern int radixsort (const unsigned char **__base, int __nel, const unsigned char *__table, unsigned int __endbyte);
		[DllImport ("__Internal")]
		static extern unsafe int radixsort (byte** __base, int __nel, byte* __table, uint __endbyte);

		// extern int rpmatch (const char *) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern unsafe int rpmatch (sbyte*);

		// extern int sradixsort (const unsigned char **__base, int __nel, const unsigned char *__table, unsigned int __endbyte);
		[DllImport ("__Internal")]
		static extern unsafe int sradixsort (byte** __base, int __nel, byte* __table, uint __endbyte);

		// extern void sranddev ();
		[DllImport ("__Internal")]
		static extern void sranddev ();

		// extern void srandomdev ();
		[DllImport ("__Internal")]
		static extern void srandomdev ();

		// extern void * reallocf (void *__ptr, size_t __size) __attribute__((alloc_size(2)));
		[DllImport ("__Internal")]
		static extern unsafe void* reallocf (void* __ptr, nuint __size);

		// extern long long strtonum (const char *__numstr, long long __minval, long long __maxval, const char **__errstrp) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0)));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe long strtonum (sbyte* __numstr, long __minval, long __maxval, sbyte** __errstrp);

		// extern long long strtoq (const char *__str, char **__endptr, int __base);
		[DllImport ("__Internal")]
		static extern unsafe long strtoq (sbyte* __str, sbyte** __endptr, int __base);

		// extern unsigned long long strtouq (const char *__str, char **__endptr, int __base);
		[DllImport ("__Internal")]
		static extern unsafe ulong strtouq (sbyte* __str, sbyte** __endptr, int __base);

		// extern void * memchr (const void *, int, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memchr (void*, int, nuint);

		// extern void * memchr (const void *__s, int __c, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memchr (void* __s, int __c, nuint __n);

		// extern int memcmp (const void *, const void *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe int memcmp (void*, void*, nuint);

		// extern int memcmp (const void *__s1, const void *__s2, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe int memcmp (void* __s1, void* __s2, nuint __n);

		// extern void * memcpy (void *, const void *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memcpy (void*, void*, nuint);

		// extern void * memcpy (void *__dst, const void *__src, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memcpy (void* __dst, void* __src, nuint __n);

		// extern void * memmove (void *, const void *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memmove (void*, void*, nuint);

		// extern void * memmove (void *__dst, const void *__src, size_t __len) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memmove (void* __dst, void* __src, nuint __len);

		// extern void * memset (void *, int, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memset (void*, int, nuint);

		// extern void * memset (void *__b, int __c, size_t __len) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memset (void* __b, int __c, nuint __len);

		// extern char * strcat (char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strcat (sbyte*, sbyte*);

		// extern char * strcat (char *__s1, const char *__s2) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strcat (sbyte* __s1, sbyte* __s2);

		// extern char * strchr (const char *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strchr (sbyte*, int);

		// extern char * strchr (const char *__s, int __c) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strchr (sbyte* __s, int __c);

		// extern int strcmp (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe int strcmp (sbyte*, sbyte*);

		// extern int strcmp (const char *__s1, const char *__s2) ;
		[DllImport ("__Internal")]
		static extern unsafe int strcmp (sbyte* __s1, sbyte* __s2);

		// extern int strcoll (const char *__s1, const char *__s2);
		[DllImport ("__Internal")]
		static extern unsafe int strcoll (sbyte* __s1, sbyte* __s2);

		// extern char * strcpy (char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strcpy (sbyte*, sbyte*);

		// extern char * strcpy (char *__dst, const char *__src) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strcpy (sbyte* __dst, sbyte* __src);

		// extern unsigned long strcspn (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strcspn (sbyte*, sbyte*);

		// extern unsigned long strcspn (const char *__s, const char *__charset) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strcspn (sbyte* __s, sbyte* __charset);

		// extern char * strerror (int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strerror (int);

		// extern char * strerror (int __errnum)  asm("_strerror");
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strerror (int __errnum);

		// extern unsigned long strlen (const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strlen (sbyte*);

		// extern unsigned long strlen (const char *__s) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strlen (sbyte* __s);

		// extern char * strncat (char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strncat (sbyte*, sbyte*, nuint);

		// extern char * strncat (char *__s1, const char *__s2, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strncat (sbyte* __s1, sbyte* __s2, nuint __n);

		// extern int strncmp (const char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe int strncmp (sbyte*, sbyte*, nuint);

		// extern int strncmp (const char *__s1, const char *__s2, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe int strncmp (sbyte* __s1, sbyte* __s2, nuint __n);

		// extern char * strncpy (char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strncpy (sbyte*, sbyte*, nuint);

		// extern char * strncpy (char *__dst, const char *__src, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strncpy (sbyte* __dst, sbyte* __src, nuint __n);

		// extern char * strpbrk (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strpbrk (sbyte*, sbyte*);

		// extern char * strpbrk (const char *__s, const char *__charset) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strpbrk (sbyte* __s, sbyte* __charset);

		// extern char * strrchr (const char *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strrchr (sbyte*, int);

		// extern char * strrchr (const char *__s, int __c) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strrchr (sbyte* __s, int __c);

		// extern unsigned long strspn (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strspn (sbyte*, sbyte*);

		// extern unsigned long strspn (const char *__s, const char *__charset) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strspn (sbyte* __s, sbyte* __charset);

		// extern char * strstr (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strstr (sbyte*, sbyte*);

		// extern char * strstr (const char *__big, const char *__little) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strstr (sbyte* __big, sbyte* __little);

		// extern char * strtok (char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strtok (sbyte*, sbyte*);

		// extern char * strtok (char *__str, const char *__sep) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strtok (sbyte* __str, sbyte* __sep);

		// extern unsigned long strxfrm (char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strxfrm (sbyte*, sbyte*, nuint);

		// extern unsigned long strxfrm (char *__s1, const char *__s2, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strxfrm (sbyte* __s1, sbyte* __s2, nuint __n);

		// extern char * strtok_r (char *__str, const char *__sep, char **__lasts);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strtok_r (sbyte* __str, sbyte* __sep, sbyte** __lasts);

		// extern int strerror_r (int __errnum, char *__strerrbuf, size_t __buflen);
		[DllImport ("__Internal")]
		static extern unsafe int strerror_r (int __errnum, sbyte* __strerrbuf, nuint __buflen);

		// extern char * strdup (const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strdup (sbyte*);

		// extern char * strdup (const char *__s1) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strdup (sbyte* __s1);

		// extern void * memccpy (void *, const void *, int, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memccpy (void*, void*, int, nuint);

		// extern void * memccpy (void *__dst, const void *__src, int __c, size_t __n) ;
		[DllImport ("__Internal")]
		static extern unsafe void* memccpy (void* __dst, void* __src, int __c, nuint __n);

		// extern char * stpcpy (char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* stpcpy (sbyte*, sbyte*);

		// extern char * stpcpy (char *__dst, const char *__src) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* stpcpy (sbyte* __dst, sbyte* __src);

		// extern char * stpncpy (char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* stpncpy (sbyte*, sbyte*, nuint);

		// extern char * stpncpy (char *__dst, const char *__src, size_t __n)  __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* stpncpy (sbyte* __dst, sbyte* __src, nuint __n);

		// extern char * strndup (const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strndup (sbyte*, nuint);

		// extern char * strndup (const char *__s1, size_t __n)  __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strndup (sbyte* __s1, nuint __n);

		// extern size_t strnlen (const char *__s1, size_t __n) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe nuint strnlen (sbyte* __s1, nuint __n);

		// extern char * strsignal (int __sig);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strsignal (int __sig);

		// extern errno_t memset_s (void *__s, rsize_t __smax, int __c, rsize_t __n) __attribute__((availability(ios, introduced=7.0)));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe int memset_s (void* __s, nuint __smax, int __c, nuint __n);

		// extern void * memmem (const void *__big, size_t __big_len, const void *__little, size_t __little_len) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe void* memmem (void* __big, nuint __big_len, void* __little, nuint __little_len);

		// extern void memset_pattern4 (void *__b, const void *__pattern4, size_t __len) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe void memset_pattern4 (void* __b, void* __pattern4, nuint __len);

		// extern void memset_pattern8 (void *__b, const void *__pattern8, size_t __len) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe void memset_pattern8 (void* __b, void* __pattern8, nuint __len);

		// extern void memset_pattern16 (void *__b, const void *__pattern16, size_t __len) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe void memset_pattern16 (void* __b, void* __pattern16, nuint __len);

		// extern char * strcasestr (const char *__big, const char *__little);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strcasestr (sbyte* __big, sbyte* __little);

		// extern char * strnstr (const char *__big, const char *__little, size_t __len);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strnstr (sbyte* __big, sbyte* __little, nuint __len);

		// extern unsigned long strlcat (char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strlcat (sbyte*, sbyte*, nuint);

		// extern unsigned long strlcat (char *__dst, const char *__source, size_t __size) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strlcat (sbyte* __dst, sbyte* __source, nuint __size);

		// extern unsigned long strlcpy (char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strlcpy (sbyte*, sbyte*, nuint);

		// extern unsigned long strlcpy (char *__dst, const char *__source, size_t __size) ;
		[DllImport ("__Internal")]
		static extern unsafe nuint strlcpy (sbyte* __dst, sbyte* __source, nuint __size);

		// extern void strmode (int __mode, char *__bp);
		[DllImport ("__Internal")]
		static extern unsafe void strmode (int __mode, sbyte* __bp);

		// extern char * strsep (char **__stringp, const char *__delim);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strsep (sbyte** __stringp, sbyte* __delim);

		// extern void swab (const void *__restrict, void *__restrict, ssize_t);
		[DllImport ("__Internal")]
		static extern unsafe void swab (void*, void*, nint);

		// extern int timingsafe_bcmp (const void *__b1, const void *__b2, size_t __len) __attribute__((availability(macos, introduced=10.12.1))) __attribute__((availability(ios, introduced=10.1))) __attribute__((availability(tvos, introduced=10.0.1))) __attribute__((availability(watchos, introduced=3.1)));
		[Watch (3,1), TV (10,0,1), Mac (10,12,1), iOS (10,1)]
		[DllImport ("__Internal")]
		static extern unsafe int timingsafe_bcmp (void* __b1, void* __b2, nuint __len);

		// extern int strsignal_r (int __sig, char *__strsignalbuf, size_t __buflen) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0)));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int strsignal_r (int __sig, sbyte* __strsignalbuf, nuint __buflen);

		// extern int bcmp (const void *, const void *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe int bcmp (void*, void*, nuint);

		// extern int bcmp (const void *, const void *, size_t) ;
		[DllImport ("__Internal")]
		static extern unsafe int bcmp (void*, void*, nuint);

		// extern void bcopy (const void *, void *, size_t);
		[DllImport ("__Internal")]
		static extern unsafe void bcopy (void*, void*, nuint);

		// extern void bzero (void *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe void bzero (void*, nuint);

		// extern void bzero (void *, size_t) ;
		[DllImport ("__Internal")]
		static extern unsafe void bzero (void*, nuint);

		// extern char * index (const char *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* index (sbyte*, int);

		// extern char * index (const char *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* index (sbyte*, int);

		// extern char * rindex (const char *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* rindex (sbyte*, int);

		// extern char * rindex (const char *, int) ;
		[DllImport ("__Internal")]
		static extern unsafe sbyte* rindex (sbyte*, int);

		// extern int ffs (int);
		[DllImport ("__Internal")]
		static extern int ffs (int);

		// extern int strcasecmp (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe int strcasecmp (sbyte*, sbyte*);

		// extern int strcasecmp (const char *, const char *) ;
		[DllImport ("__Internal")]
		static extern unsafe int strcasecmp (sbyte*, sbyte*);

		// extern int strncasecmp (const char *, const char *, unsigned long) ;
		[DllImport ("__Internal")]
		static extern unsafe int strncasecmp (sbyte*, sbyte*, nuint);

		// extern int strncasecmp (const char *, const char *, size_t) ;
		[DllImport ("__Internal")]
		static extern unsafe int strncasecmp (sbyte*, sbyte*, nuint);

		// extern int ffsl (long) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern int ffsl (nint);

		// extern int ffsll (long long) __attribute__((availability(ios, introduced=7.0)));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern int ffsll (long);

		// extern int fls (int) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern int fls (int);

		// extern int flsl (long) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern int flsl (nint);

		// extern int flsll (long long) __attribute__((availability(ios, introduced=7.0)));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern int flsll (long);

		// extern char * asctime (const struct tm *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* asctime (tm*);

		// extern clock_t clock () asm("_clock");
		[DllImport ("__Internal")]
		static extern nuint clock ();

		// extern char * ctime (const time_t *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ctime (nint*);

		// extern double difftime (time_t, time_t);
		[DllImport ("__Internal")]
		static extern double difftime (nint, nint);

		// extern struct tm * getdate (const char *);
		[DllImport ("__Internal")]
		static extern unsafe tm* getdate (sbyte*);

		// extern struct tm * gmtime (const time_t *);
		[DllImport ("__Internal")]
		static extern unsafe tm* gmtime (nint*);

		// extern struct tm * localtime (const time_t *);
		[DllImport ("__Internal")]
		static extern unsafe tm* localtime (nint*);

		// extern time_t mktime (struct tm *) asm("_mktime");
		[DllImport ("__Internal")]
		static extern unsafe nint mktime (tm*);

		// extern size_t strftime (char *__restrict, size_t, const char *__restrict, const struct tm *__restrict) asm("_strftime");
		[DllImport ("__Internal")]
		static extern unsafe nuint strftime (sbyte*, nuint, sbyte*, tm*);

		// extern char * strptime (const char *__restrict, const char *__restrict, struct tm *__restrict) asm("_strptime");
		[DllImport ("__Internal")]
		static extern unsafe sbyte* strptime (sbyte*, sbyte*, tm*);

		// extern time_t time (time_t *);
		[DllImport ("__Internal")]
		static extern unsafe nint time (nint*);

		// extern void tzset ();
		[DllImport ("__Internal")]
		static extern void tzset ();

		// extern char * asctime_r (const struct tm *__restrict, char *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* asctime_r (tm*, sbyte*);

		// extern char * ctime_r (const time_t *, char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ctime_r (nint*, sbyte*);

		// extern struct tm * gmtime_r (const time_t *__restrict, struct tm *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe tm* gmtime_r (nint*, tm*);

		// extern struct tm * localtime_r (const time_t *__restrict, struct tm *__restrict);
		[DllImport ("__Internal")]
		static extern unsafe tm* localtime_r (nint*, tm*);

		// extern time_t posix2time (time_t);
		[DllImport ("__Internal")]
		static extern nint posix2time (nint);

		// extern void tzsetwall ();
		[DllImport ("__Internal")]
		static extern void tzsetwall ();

		// extern time_t time2posix (time_t);
		[DllImport ("__Internal")]
		static extern nint time2posix (nint);

		// extern time_t timelocal (struct tm *const);
		[DllImport ("__Internal")]
		static extern unsafe nint timelocal (tm*);

		// extern time_t timegm (struct tm *const);
		[DllImport ("__Internal")]
		static extern unsafe nint timegm (tm*);

		// extern int nanosleep (const struct timespec *__rqtp, struct timespec *__rmtp) asm("_nanosleep");
		[DllImport ("__Internal")]
		static extern unsafe int nanosleep (timespec* __rqtp, timespec* __rmtp);

		// extern int clock_getres (clockid_t __clock_id, struct timespec *__res) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int clock_getres (clockid_t __clock_id, timespec* __res);

		// extern int clock_gettime (clockid_t __clock_id, struct timespec *__tp) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int clock_gettime (clockid_t __clock_id, timespec* __tp);

		// extern __uint64_t clock_gettime_nsec_np (clockid_t __clock_id) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern ulong clock_gettime_nsec_np (clockid_t __clock_id);

		// extern int clock_settime (clockid_t __clock_id, const struct timespec *__tp) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10,12)]
		[DllImport ("__Internal")]
		static extern unsafe int clock_settime (clockid_t __clock_id, timespec* __tp);

		// extern int timespec_get (struct timespec *ts, int base) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern unsafe int timespec_get (timespec* ts, int @base);

		// extern intmax_t imaxabs (intmax_t j) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nint imaxabs (nint j);

		// extern imaxdiv_t imaxdiv (intmax_t __numer, intmax_t __denom) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern imaxdiv_t imaxdiv (nint __numer, nint __denom);

		// extern intmax_t strtoimax (const char *__restrict __nptr, char **__restrict __endptr, int __base) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint strtoimax (sbyte* __nptr, sbyte** __endptr, int __base);

		// extern uintmax_t strtoumax (const char *__restrict __nptr, char **__restrict __endptr, int __base) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nuint strtoumax (sbyte* __nptr, sbyte** __endptr, int __base);

		// extern intmax_t wcstoimax (const wchar_t *__restrict __nptr, wchar_t **__restrict __endptr, int __base) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint wcstoimax (int* __nptr, int** __endptr, int __base);

		// extern uintmax_t wcstoumax (const wchar_t *__restrict __nptr, wchar_t **__restrict __endptr, int __base) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nuint wcstoumax (int* __nptr, int** __endptr, int __base);

		// extern void * _Block_copy (const void *aBlock) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void* _Block_copy (void* aBlock);

		// extern void _Block_release (const void *aBlock) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void _Block_release (void* aBlock);

		// extern void _Block_object_assign (void *, const void *, const int) ;
		[DllImport ("__Internal")]
		static extern unsafe void _Block_object_assign (void*, void*, int);

		// extern void _Block_object_assign (void *, const void *, const int)  __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void _Block_object_assign (void*, void*, int);

		// extern void _Block_object_dispose (const void *, const int) ;
		[DllImport ("__Internal")]
		static extern unsafe void _Block_object_dispose (void*, int);

		// extern void _Block_object_dispose (const void *, const int)  __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe void _Block_object_dispose (void*, int);

		// extern void Debugger () __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern void Debugger ();

		// extern void DebugStr (ConstStr255Param debuggerMsg) __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe void DebugStr (byte* debuggerMsg);

		// extern void SysBreak () __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern void SysBreak ();

		// extern void SysBreakStr (ConstStr255Param debuggerMsg) __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe void SysBreakStr (byte* debuggerMsg);

		// extern void SysBreakFunc (ConstStr255Param debuggerMsg) __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe void SysBreakFunc (byte* debuggerMsg);

		// CFRange CFRangeMake (CFIndex loc, CFIndex len) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern CFRange CFRangeMake (nint loc, nint len);

		// extern CFRange __CFRangeMake (CFIndex loc, CFIndex len);
		[DllImport ("__Internal")]
		static extern CFRange __CFRangeMake (nint loc, nint len);

		// extern CFTypeID CFNullGetTypeID ();
		[DllImport ("__Internal")]
		static extern nuint CFNullGetTypeID ();

		// extern CFTypeID CFAllocatorGetTypeID ();
		[DllImport ("__Internal")]
		static extern nuint CFAllocatorGetTypeID ();

		// extern void CFAllocatorSetDefault (CFAllocatorRef allocator);
		[DllImport ("__Internal")]
		static extern unsafe void CFAllocatorSetDefault (CFAllocatorRef* allocator);

		// extern CFAllocatorRef CFAllocatorGetDefault ();
		[DllImport ("__Internal")]
		static extern unsafe CFAllocatorRef* CFAllocatorGetDefault ();

		// extern CFAllocatorRef CFAllocatorCreate (CFAllocatorRef allocator, CFAllocatorContext *context);
		[DllImport ("__Internal")]
		static extern unsafe CFAllocatorRef* CFAllocatorCreate (CFAllocatorRef* allocator, CFAllocatorContext* context);

		// extern void * CFAllocatorAllocate (CFAllocatorRef allocator, CFIndex size, CFOptionFlags hint);
		[DllImport ("__Internal")]
		static extern unsafe void* CFAllocatorAllocate (CFAllocatorRef* allocator, nint size, nuint hint);

		// extern void * CFAllocatorReallocate (CFAllocatorRef allocator, void *ptr, CFIndex newsize, CFOptionFlags hint);
		[DllImport ("__Internal")]
		static extern unsafe void* CFAllocatorReallocate (CFAllocatorRef* allocator, void* ptr, nint newsize, nuint hint);

		// extern void CFAllocatorDeallocate (CFAllocatorRef allocator, void *ptr);
		[DllImport ("__Internal")]
		static extern unsafe void CFAllocatorDeallocate (CFAllocatorRef* allocator, void* ptr);

		// extern CFIndex CFAllocatorGetPreferredSizeForSize (CFAllocatorRef allocator, CFIndex size, CFOptionFlags hint);
		[DllImport ("__Internal")]
		static extern unsafe nint CFAllocatorGetPreferredSizeForSize (CFAllocatorRef* allocator, nint size, nuint hint);

		// extern void CFAllocatorGetContext (CFAllocatorRef allocator, CFAllocatorContext *context);
		[DllImport ("__Internal")]
		static extern unsafe void CFAllocatorGetContext (CFAllocatorRef* allocator, CFAllocatorContext* context);

		// extern CFTypeID CFGetTypeID (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nuint CFGetTypeID (void* cf);

		// extern CFStringRef CFCopyTypeIDDescription (CFTypeID type_id) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFCopyTypeIDDescription (nuint type_id);

		// extern CFTypeRef CFRetain (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFRetain (void* cf);

		// extern void CFRelease (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRelease (void* cf);

		// extern CFTypeRef CFAutorelease (CFTypeRef arg) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* CFAutorelease (void* arg);

		// extern CFIndex CFGetRetainCount (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFGetRetainCount (void* cf);

		// extern Boolean CFEqual (CFTypeRef cf1, CFTypeRef cf2) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFEqual (void* cf1, void* cf2);

		// extern CFHashCode CFHash (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nuint CFHash (void* cf);

		// extern CFStringRef CFCopyDescription (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFCopyDescription (void* cf);

		// extern CFAllocatorRef CFGetAllocator (CFTypeRef cf) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFAllocatorRef* CFGetAllocator (void* cf);

		// extern CFTypeRef CFMakeCollectable (CFTypeRef cf);
		[DllImport ("__Internal")]
		static extern unsafe void* CFMakeCollectable (void* cf);

		// extern CFTypeID CFArrayGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFArrayGetTypeID ();

		// extern CFArrayRef CFArrayCreate (CFAllocatorRef allocator, const void **values, CFIndex numValues, const CFArrayCallBacks *callBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFArrayCreate (CFAllocatorRef* allocator, void** values, nint numValues, CFArrayCallBacks* callBacks);

		// extern CFArrayRef CFArrayCreateCopy (CFAllocatorRef allocator, CFArrayRef theArray) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFArrayCreateCopy (CFAllocatorRef* allocator, CFArrayRef* theArray);

		// extern CFMutableArrayRef CFArrayCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFArrayCallBacks *callBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableArrayRef* CFArrayCreateMutable (CFAllocatorRef* allocator, nint capacity, CFArrayCallBacks* callBacks);

		// extern CFMutableArrayRef CFArrayCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFArrayRef theArray) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableArrayRef* CFArrayCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFArrayRef* theArray);

		// extern CFIndex CFArrayGetCount (CFArrayRef theArray) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFArrayGetCount (CFArrayRef* theArray);

		// extern CFIndex CFArrayGetCountOfValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFArrayGetCountOfValue (CFArrayRef* theArray, CFRange range, void* value);

		// extern Boolean CFArrayContainsValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFArrayContainsValue (CFArrayRef* theArray, CFRange range, void* value);

		// extern const void * CFArrayGetValueAtIndex (CFArrayRef theArray, CFIndex idx) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFArrayGetValueAtIndex (CFArrayRef* theArray, nint idx);

		// extern void CFArrayGetValues (CFArrayRef theArray, CFRange range, const void **values) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayGetValues (CFArrayRef* theArray, CFRange range, void** values);

		// extern void CFArrayApplyFunction (CFArrayRef theArray, CFRange range, CFArrayApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayApplyFunction (CFArrayRef* theArray, CFRange range, CFArrayApplierFunction* applier, void* context);

		// extern CFIndex CFArrayGetFirstIndexOfValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFArrayGetFirstIndexOfValue (CFArrayRef* theArray, CFRange range, void* value);

		// extern CFIndex CFArrayGetLastIndexOfValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFArrayGetLastIndexOfValue (CFArrayRef* theArray, CFRange range, void* value);

		// extern CFIndex CFArrayBSearchValues (CFArrayRef theArray, CFRange range, const void *value, CFComparatorFunction comparator, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFArrayBSearchValues (CFArrayRef* theArray, CFRange range, void* value, CFComparatorFunction* comparator, void* context);

		// extern void CFArrayAppendValue (CFMutableArrayRef theArray, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayAppendValue (CFMutableArrayRef* theArray, void* value);

		// extern void CFArrayInsertValueAtIndex (CFMutableArrayRef theArray, CFIndex idx, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayInsertValueAtIndex (CFMutableArrayRef* theArray, nint idx, void* value);

		// extern void CFArraySetValueAtIndex (CFMutableArrayRef theArray, CFIndex idx, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArraySetValueAtIndex (CFMutableArrayRef* theArray, nint idx, void* value);

		// extern void CFArrayRemoveValueAtIndex (CFMutableArrayRef theArray, CFIndex idx) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayRemoveValueAtIndex (CFMutableArrayRef* theArray, nint idx);

		// extern void CFArrayRemoveAllValues (CFMutableArrayRef theArray) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayRemoveAllValues (CFMutableArrayRef* theArray);

		// extern void CFArrayReplaceValues (CFMutableArrayRef theArray, CFRange range, const void **newValues, CFIndex newCount) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayReplaceValues (CFMutableArrayRef* theArray, CFRange range, void** newValues, nint newCount);

		// extern void CFArrayExchangeValuesAtIndices (CFMutableArrayRef theArray, CFIndex idx1, CFIndex idx2) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayExchangeValuesAtIndices (CFMutableArrayRef* theArray, nint idx1, nint idx2);

		// extern void CFArraySortValues (CFMutableArrayRef theArray, CFRange range, CFComparatorFunction comparator, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArraySortValues (CFMutableArrayRef* theArray, CFRange range, CFComparatorFunction* comparator, void* context);

		// extern void CFArrayAppendArray (CFMutableArrayRef theArray, CFArrayRef otherArray, CFRange otherRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFArrayAppendArray (CFMutableArrayRef* theArray, CFArrayRef* otherArray, CFRange otherRange);

		// extern CFTypeID CFBagGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFBagGetTypeID ();

		// extern CFBagRef CFBagCreate (CFAllocatorRef allocator, const void **values, CFIndex numValues, const CFBagCallBacks *callBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBagRef* CFBagCreate (CFAllocatorRef* allocator, void** values, nint numValues, CFBagCallBacks* callBacks);

		// extern CFBagRef CFBagCreateCopy (CFAllocatorRef allocator, CFBagRef theBag) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBagRef* CFBagCreateCopy (CFAllocatorRef* allocator, CFBagRef* theBag);

		// extern CFMutableBagRef CFBagCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFBagCallBacks *callBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableBagRef* CFBagCreateMutable (CFAllocatorRef* allocator, nint capacity, CFBagCallBacks* callBacks);

		// extern CFMutableBagRef CFBagCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFBagRef theBag) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableBagRef* CFBagCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFBagRef* theBag);

		// extern CFIndex CFBagGetCount (CFBagRef theBag) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBagGetCount (CFBagRef* theBag);

		// extern CFIndex CFBagGetCountOfValue (CFBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBagGetCountOfValue (CFBagRef* theBag, void* value);

		// extern Boolean CFBagContainsValue (CFBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBagContainsValue (CFBagRef* theBag, void* value);

		// extern const void * CFBagGetValue (CFBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFBagGetValue (CFBagRef* theBag, void* value);

		// extern Boolean CFBagGetValueIfPresent (CFBagRef theBag, const void *candidate, const void **value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBagGetValueIfPresent (CFBagRef* theBag, void* candidate, void** value);

		// extern void CFBagGetValues (CFBagRef theBag, const void **values) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagGetValues (CFBagRef* theBag, void** values);

		// extern void CFBagApplyFunction (CFBagRef theBag, CFBagApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagApplyFunction (CFBagRef* theBag, CFBagApplierFunction* applier, void* context);

		// extern void CFBagAddValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagAddValue (CFMutableBagRef* theBag, void* value);

		// extern void CFBagReplaceValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagReplaceValue (CFMutableBagRef* theBag, void* value);

		// extern void CFBagSetValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagSetValue (CFMutableBagRef* theBag, void* value);

		// extern void CFBagRemoveValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagRemoveValue (CFMutableBagRef* theBag, void* value);

		// extern void CFBagRemoveAllValues (CFMutableBagRef theBag) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBagRemoveAllValues (CFMutableBagRef* theBag);

		// extern CFTypeID CFBinaryHeapGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFBinaryHeapGetTypeID ();

		// extern CFBinaryHeapRef CFBinaryHeapCreate (CFAllocatorRef allocator, CFIndex capacity, const CFBinaryHeapCallBacks *callBacks, const CFBinaryHeapCompareContext *compareContext) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBinaryHeapRef* CFBinaryHeapCreate (CFAllocatorRef* allocator, nint capacity, CFBinaryHeapCallBacks* callBacks, CFBinaryHeapCompareContext* compareContext);

		// extern CFBinaryHeapRef CFBinaryHeapCreateCopy (CFAllocatorRef allocator, CFIndex capacity, CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBinaryHeapRef* CFBinaryHeapCreateCopy (CFAllocatorRef* allocator, nint capacity, CFBinaryHeapRef* heap);

		// extern CFIndex CFBinaryHeapGetCount (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBinaryHeapGetCount (CFBinaryHeapRef* heap);

		// extern CFIndex CFBinaryHeapGetCountOfValue (CFBinaryHeapRef heap, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBinaryHeapGetCountOfValue (CFBinaryHeapRef* heap, void* value);

		// extern Boolean CFBinaryHeapContainsValue (CFBinaryHeapRef heap, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBinaryHeapContainsValue (CFBinaryHeapRef* heap, void* value);

		// extern const void * CFBinaryHeapGetMinimum (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFBinaryHeapGetMinimum (CFBinaryHeapRef* heap);

		// extern Boolean CFBinaryHeapGetMinimumIfPresent (CFBinaryHeapRef heap, const void **value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBinaryHeapGetMinimumIfPresent (CFBinaryHeapRef* heap, void** value);

		// extern void CFBinaryHeapGetValues (CFBinaryHeapRef heap, const void **values) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBinaryHeapGetValues (CFBinaryHeapRef* heap, void** values);

		// extern void CFBinaryHeapApplyFunction (CFBinaryHeapRef heap, CFBinaryHeapApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBinaryHeapApplyFunction (CFBinaryHeapRef* heap, CFBinaryHeapApplierFunction* applier, void* context);

		// extern void CFBinaryHeapAddValue (CFBinaryHeapRef heap, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBinaryHeapAddValue (CFBinaryHeapRef* heap, void* value);

		// extern void CFBinaryHeapRemoveMinimumValue (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBinaryHeapRemoveMinimumValue (CFBinaryHeapRef* heap);

		// extern void CFBinaryHeapRemoveAllValues (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBinaryHeapRemoveAllValues (CFBinaryHeapRef* heap);

		// extern CFTypeID CFBitVectorGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFBitVectorGetTypeID ();

		// extern CFBitVectorRef CFBitVectorCreate (CFAllocatorRef allocator, const UInt8 *bytes, CFIndex numBits) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBitVectorRef* CFBitVectorCreate (CFAllocatorRef* allocator, byte* bytes, nint numBits);

		// extern CFBitVectorRef CFBitVectorCreateCopy (CFAllocatorRef allocator, CFBitVectorRef bv) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBitVectorRef* CFBitVectorCreateCopy (CFAllocatorRef* allocator, CFBitVectorRef* bv);

		// extern CFMutableBitVectorRef CFBitVectorCreateMutable (CFAllocatorRef allocator, CFIndex capacity) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableBitVectorRef* CFBitVectorCreateMutable (CFAllocatorRef* allocator, nint capacity);

		// extern CFMutableBitVectorRef CFBitVectorCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFBitVectorRef bv) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableBitVectorRef* CFBitVectorCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFBitVectorRef* bv);

		// extern CFIndex CFBitVectorGetCount (CFBitVectorRef bv) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBitVectorGetCount (CFBitVectorRef* bv);

		// extern CFIndex CFBitVectorGetCountOfBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBitVectorGetCountOfBit (CFBitVectorRef* bv, CFRange range, uint value);

		// extern Boolean CFBitVectorContainsBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBitVectorContainsBit (CFBitVectorRef* bv, CFRange range, uint value);

		// extern CFBit CFBitVectorGetBitAtIndex (CFBitVectorRef bv, CFIndex idx) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint CFBitVectorGetBitAtIndex (CFBitVectorRef* bv, nint idx);

		// extern void CFBitVectorGetBits (CFBitVectorRef bv, CFRange range, UInt8 *bytes) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorGetBits (CFBitVectorRef* bv, CFRange range, byte* bytes);

		// extern CFIndex CFBitVectorGetFirstIndexOfBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBitVectorGetFirstIndexOfBit (CFBitVectorRef* bv, CFRange range, uint value);

		// extern CFIndex CFBitVectorGetLastIndexOfBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFBitVectorGetLastIndexOfBit (CFBitVectorRef* bv, CFRange range, uint value);

		// extern void CFBitVectorSetCount (CFMutableBitVectorRef bv, CFIndex count) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorSetCount (CFMutableBitVectorRef* bv, nint count);

		// extern void CFBitVectorFlipBitAtIndex (CFMutableBitVectorRef bv, CFIndex idx) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorFlipBitAtIndex (CFMutableBitVectorRef* bv, nint idx);

		// extern void CFBitVectorFlipBits (CFMutableBitVectorRef bv, CFRange range) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorFlipBits (CFMutableBitVectorRef* bv, CFRange range);

		// extern void CFBitVectorSetBitAtIndex (CFMutableBitVectorRef bv, CFIndex idx, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorSetBitAtIndex (CFMutableBitVectorRef* bv, nint idx, uint value);

		// extern void CFBitVectorSetBits (CFMutableBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorSetBits (CFMutableBitVectorRef* bv, CFRange range, uint value);

		// extern void CFBitVectorSetAllBits (CFMutableBitVectorRef bv, CFBit value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBitVectorSetAllBits (CFMutableBitVectorRef* bv, uint value);

		// int32_t OSHostByteOrder ();
		[DllImport ("__Internal")]
		static extern int OSHostByteOrder ();

		// uint16_t _OSReadInt16 (const volatile void *base, uintptr_t byteOffset);
		[DllImport ("__Internal")]
		static extern unsafe ushort _OSReadInt16 (void* @base, UIntPtr byteOffset);

		// uint32_t _OSReadInt32 (const volatile void *base, uintptr_t byteOffset);
		[DllImport ("__Internal")]
		static extern unsafe uint _OSReadInt32 (void* @base, UIntPtr byteOffset);

		// uint64_t _OSReadInt64 (const volatile void *base, uintptr_t byteOffset);
		[DllImport ("__Internal")]
		static extern unsafe ulong _OSReadInt64 (void* @base, UIntPtr byteOffset);

		// void _OSWriteInt16 (volatile void *base, uintptr_t byteOffset, uint16_t data);
		[DllImport ("__Internal")]
		static extern unsafe void _OSWriteInt16 (void* @base, UIntPtr byteOffset, ushort data);

		// void _OSWriteInt32 (volatile void *base, uintptr_t byteOffset, uint32_t data);
		[DllImport ("__Internal")]
		static extern unsafe void _OSWriteInt32 (void* @base, UIntPtr byteOffset, uint data);

		// void _OSWriteInt64 (volatile void *base, uintptr_t byteOffset, uint64_t data);
		[DllImport ("__Internal")]
		static extern unsafe void _OSWriteInt64 (void* @base, UIntPtr byteOffset, ulong data);

		// CFByteOrder CFByteOrderGetCurrent () __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nint CFByteOrderGetCurrent ();

		// uint16_t CFSwapInt16 (uint16_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort CFSwapInt16 (ushort arg);

		// extern int __builtin_constant_p ()  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern int __builtin_constant_p ();

		// uint32_t CFSwapInt32 (uint32_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint CFSwapInt32 (uint arg);

		// uint64_t CFSwapInt64 (uint64_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong CFSwapInt64 (ulong arg);

		// uint16_t CFSwapInt16BigToHost (uint16_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort CFSwapInt16BigToHost (ushort arg);

		// uint32_t CFSwapInt32BigToHost (uint32_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint CFSwapInt32BigToHost (uint arg);

		// uint64_t CFSwapInt64BigToHost (uint64_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong CFSwapInt64BigToHost (ulong arg);

		// uint16_t CFSwapInt16HostToBig (uint16_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort CFSwapInt16HostToBig (ushort arg);

		// uint32_t CFSwapInt32HostToBig (uint32_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint CFSwapInt32HostToBig (uint arg);

		// uint64_t CFSwapInt64HostToBig (uint64_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong CFSwapInt64HostToBig (ulong arg);

		// uint16_t CFSwapInt16LittleToHost (uint16_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort CFSwapInt16LittleToHost (ushort arg);

		// uint32_t CFSwapInt32LittleToHost (uint32_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint CFSwapInt32LittleToHost (uint arg);

		// uint64_t CFSwapInt64LittleToHost (uint64_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong CFSwapInt64LittleToHost (ulong arg);

		// uint16_t CFSwapInt16HostToLittle (uint16_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort CFSwapInt16HostToLittle (ushort arg);

		// uint32_t CFSwapInt32HostToLittle (uint32_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint CFSwapInt32HostToLittle (uint arg);

		// uint64_t CFSwapInt64HostToLittle (uint64_t arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong CFSwapInt64HostToLittle (ulong arg);

		// CFSwappedFloat32 CFConvertFloat32HostToSwapped (Float32 arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern CFSwappedFloat32 CFConvertFloat32HostToSwapped (float arg);

		// Float32 CFConvertFloat32SwappedToHost (CFSwappedFloat32 arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern float CFConvertFloat32SwappedToHost (CFSwappedFloat32 arg);

		// CFSwappedFloat64 CFConvertFloat64HostToSwapped (Float64 arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern CFSwappedFloat64 CFConvertFloat64HostToSwapped (double arg);

		// Float64 CFConvertFloat64SwappedToHost (CFSwappedFloat64 arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern double CFConvertFloat64SwappedToHost (CFSwappedFloat64 arg);

		// CFSwappedFloat32 CFConvertFloatHostToSwapped (float arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern CFSwappedFloat32 CFConvertFloatHostToSwapped (float arg);

		// float CFConvertFloatSwappedToHost (CFSwappedFloat32 arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern float CFConvertFloatSwappedToHost (CFSwappedFloat32 arg);

		// CFSwappedFloat64 CFConvertDoubleHostToSwapped (double arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern CFSwappedFloat64 CFConvertDoubleHostToSwapped (double arg);

		// double CFConvertDoubleSwappedToHost (CFSwappedFloat64 arg) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern double CFConvertDoubleSwappedToHost (CFSwappedFloat64 arg);

		// extern CFTypeID CFDictionaryGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFDictionaryGetTypeID ();

		// extern CFDictionaryRef CFDictionaryCreate (CFAllocatorRef allocator, const void **keys, const void **values, CFIndex numValues, const CFDictionaryKeyCallBacks *keyCallBacks, const CFDictionaryValueCallBacks *valueCallBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFDictionaryCreate (CFAllocatorRef* allocator, void** keys, void** values, nint numValues, CFDictionaryKeyCallBacks* keyCallBacks, CFDictionaryValueCallBacks* valueCallBacks);

		// extern CFDictionaryRef CFDictionaryCreateCopy (CFAllocatorRef allocator, CFDictionaryRef theDict) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFDictionaryCreateCopy (CFAllocatorRef* allocator, CFDictionaryRef* theDict);

		// extern CFMutableDictionaryRef CFDictionaryCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFDictionaryKeyCallBacks *keyCallBacks, const CFDictionaryValueCallBacks *valueCallBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableDictionaryRef* CFDictionaryCreateMutable (CFAllocatorRef* allocator, nint capacity, CFDictionaryKeyCallBacks* keyCallBacks, CFDictionaryValueCallBacks* valueCallBacks);

		// extern CFMutableDictionaryRef CFDictionaryCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFDictionaryRef theDict) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableDictionaryRef* CFDictionaryCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFDictionaryRef* theDict);

		// extern CFIndex CFDictionaryGetCount (CFDictionaryRef theDict) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFDictionaryGetCount (CFDictionaryRef* theDict);

		// extern CFIndex CFDictionaryGetCountOfKey (CFDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFDictionaryGetCountOfKey (CFDictionaryRef* theDict, void* key);

		// extern CFIndex CFDictionaryGetCountOfValue (CFDictionaryRef theDict, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFDictionaryGetCountOfValue (CFDictionaryRef* theDict, void* value);

		// extern Boolean CFDictionaryContainsKey (CFDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFDictionaryContainsKey (CFDictionaryRef* theDict, void* key);

		// extern Boolean CFDictionaryContainsValue (CFDictionaryRef theDict, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFDictionaryContainsValue (CFDictionaryRef* theDict, void* value);

		// extern const void * CFDictionaryGetValue (CFDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFDictionaryGetValue (CFDictionaryRef* theDict, void* key);

		// extern Boolean CFDictionaryGetValueIfPresent (CFDictionaryRef theDict, const void *key, const void **value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFDictionaryGetValueIfPresent (CFDictionaryRef* theDict, void* key, void** value);

		// extern void CFDictionaryGetKeysAndValues (CFDictionaryRef theDict, const void **keys, const void **values) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionaryGetKeysAndValues (CFDictionaryRef* theDict, void** keys, void** values);

		// extern void CFDictionaryApplyFunction (CFDictionaryRef theDict, CFDictionaryApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionaryApplyFunction (CFDictionaryRef* theDict, CFDictionaryApplierFunction* applier, void* context);

		// extern void CFDictionaryAddValue (CFMutableDictionaryRef theDict, const void *key, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionaryAddValue (CFMutableDictionaryRef* theDict, void* key, void* value);

		// extern void CFDictionarySetValue (CFMutableDictionaryRef theDict, const void *key, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionarySetValue (CFMutableDictionaryRef* theDict, void* key, void* value);

		// extern void CFDictionaryReplaceValue (CFMutableDictionaryRef theDict, const void *key, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionaryReplaceValue (CFMutableDictionaryRef* theDict, void* key, void* value);

		// extern void CFDictionaryRemoveValue (CFMutableDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionaryRemoveValue (CFMutableDictionaryRef* theDict, void* key);

		// extern void CFDictionaryRemoveAllValues (CFMutableDictionaryRef theDict) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDictionaryRemoveAllValues (CFMutableDictionaryRef* theDict);

		// extern CFTypeID CFNotificationCenterGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFNotificationCenterGetTypeID ();

		// extern CFNotificationCenterRef CFNotificationCenterGetLocalCenter () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNotificationCenterRef* CFNotificationCenterGetLocalCenter ();

		// extern CFNotificationCenterRef CFNotificationCenterGetDarwinNotifyCenter () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNotificationCenterRef* CFNotificationCenterGetDarwinNotifyCenter ();

		// extern void CFNotificationCenterAddObserver (CFNotificationCenterRef center, const void *observer, CFNotificationCallback callBack, CFStringRef name, const void *object, CFNotificationSuspensionBehavior suspensionBehavior) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNotificationCenterAddObserver (CFNotificationCenterRef* center, void* observer, CFNotificationCallback* callBack, CFStringRef* name, void* @object, CFNotificationSuspensionBehavior suspensionBehavior);

		// extern void CFNotificationCenterRemoveObserver (CFNotificationCenterRef center, const void *observer, CFNotificationName name, const void *object) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNotificationCenterRemoveObserver (CFNotificationCenterRef* center, void* observer, CFNotificationName* name, void* @object);

		// extern void CFNotificationCenterRemoveEveryObserver (CFNotificationCenterRef center, const void *observer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNotificationCenterRemoveEveryObserver (CFNotificationCenterRef* center, void* observer);

		// extern void CFNotificationCenterPostNotification (CFNotificationCenterRef center, CFNotificationName name, const void *object, CFDictionaryRef userInfo, Boolean deliverImmediately) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNotificationCenterPostNotification (CFNotificationCenterRef* center, CFNotificationName* name, void* @object, CFDictionaryRef* userInfo, byte deliverImmediately);

		// extern void CFNotificationCenterPostNotificationWithOptions (CFNotificationCenterRef center, CFNotificationName name, const void *object, CFDictionaryRef userInfo, CFOptionFlags options) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNotificationCenterPostNotificationWithOptions (CFNotificationCenterRef* center, CFNotificationName* name, void* @object, CFDictionaryRef* userInfo, nuint options);

		// extern CFTypeID CFLocaleGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFLocaleGetTypeID ();

		// extern CFLocaleRef CFLocaleGetSystem () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFLocaleGetSystem ();

		// extern CFLocaleRef CFLocaleCopyCurrent () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFLocaleCopyCurrent ();

		// extern CFArrayRef CFLocaleCopyAvailableLocaleIdentifiers () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFLocaleCopyAvailableLocaleIdentifiers ();

		// extern CFArrayRef CFLocaleCopyISOLanguageCodes () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFLocaleCopyISOLanguageCodes ();

		// extern CFArrayRef CFLocaleCopyISOCountryCodes () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFLocaleCopyISOCountryCodes ();

		// extern CFArrayRef CFLocaleCopyISOCurrencyCodes () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFLocaleCopyISOCurrencyCodes ();

		// extern CFArrayRef CFLocaleCopyCommonISOCurrencyCodes () __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFLocaleCopyCommonISOCurrencyCodes ();

		// extern CFArrayRef CFLocaleCopyPreferredLanguages () __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFLocaleCopyPreferredLanguages ();

		// extern CFLocaleIdentifier CFLocaleCreateCanonicalLanguageIdentifierFromString (CFAllocatorRef allocator, CFStringRef localeIdentifier) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleIdentifier* CFLocaleCreateCanonicalLanguageIdentifierFromString (CFAllocatorRef* allocator, CFStringRef* localeIdentifier);

		// extern CFLocaleIdentifier CFLocaleCreateCanonicalLocaleIdentifierFromString (CFAllocatorRef allocator, CFStringRef localeIdentifier) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleIdentifier* CFLocaleCreateCanonicalLocaleIdentifierFromString (CFAllocatorRef* allocator, CFStringRef* localeIdentifier);

		// extern CFLocaleIdentifier CFLocaleCreateCanonicalLocaleIdentifierFromScriptManagerCodes (CFAllocatorRef allocator, LangCode lcode, RegionCode rcode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleIdentifier* CFLocaleCreateCanonicalLocaleIdentifierFromScriptManagerCodes (CFAllocatorRef* allocator, short lcode, short rcode);

		// extern CFLocaleIdentifier CFLocaleCreateLocaleIdentifierFromWindowsLocaleCode (CFAllocatorRef allocator, uint32_t lcid) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleIdentifier* CFLocaleCreateLocaleIdentifierFromWindowsLocaleCode (CFAllocatorRef* allocator, uint lcid);

		// extern uint32_t CFLocaleGetWindowsLocaleCodeFromLocaleIdentifier (CFLocaleIdentifier localeIdentifier) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe uint CFLocaleGetWindowsLocaleCodeFromLocaleIdentifier (CFLocaleIdentifier* localeIdentifier);

		// extern CFLocaleLanguageDirection CFLocaleGetLanguageCharacterDirection (CFStringRef isoLangCode) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleLanguageDirection CFLocaleGetLanguageCharacterDirection (CFStringRef* isoLangCode);

		// extern CFLocaleLanguageDirection CFLocaleGetLanguageLineDirection (CFStringRef isoLangCode) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleLanguageDirection CFLocaleGetLanguageLineDirection (CFStringRef* isoLangCode);

		// extern CFDictionaryRef CFLocaleCreateComponentsFromLocaleIdentifier (CFAllocatorRef allocator, CFLocaleIdentifier localeID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFLocaleCreateComponentsFromLocaleIdentifier (CFAllocatorRef* allocator, CFLocaleIdentifier* localeID);

		// extern CFLocaleIdentifier CFLocaleCreateLocaleIdentifierFromComponents (CFAllocatorRef allocator, CFDictionaryRef dictionary) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleIdentifier* CFLocaleCreateLocaleIdentifierFromComponents (CFAllocatorRef* allocator, CFDictionaryRef* dictionary);

		// extern CFLocaleRef CFLocaleCreate (CFAllocatorRef allocator, CFLocaleIdentifier localeIdentifier) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFLocaleCreate (CFAllocatorRef* allocator, CFLocaleIdentifier* localeIdentifier);

		// extern CFLocaleRef CFLocaleCreateCopy (CFAllocatorRef allocator, CFLocaleRef locale) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFLocaleCreateCopy (CFAllocatorRef* allocator, CFLocaleRef* locale);

		// extern CFLocaleIdentifier CFLocaleGetIdentifier (CFLocaleRef locale) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleIdentifier* CFLocaleGetIdentifier (CFLocaleRef* locale);

		// extern CFTypeRef CFLocaleGetValue (CFLocaleRef locale, CFLocaleKey key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFLocaleGetValue (CFLocaleRef* locale, CFLocaleKey* key);

		// extern CFStringRef CFLocaleCopyDisplayNameForPropertyValue (CFLocaleRef displayLocale, CFLocaleKey key, CFStringRef value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFLocaleCopyDisplayNameForPropertyValue (CFLocaleRef* displayLocale, CFLocaleKey* key, CFStringRef* value);

		// extern CFAbsoluteTime CFAbsoluteTimeGetCurrent () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern double CFAbsoluteTimeGetCurrent ();

		// extern CFTypeID CFDateGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFDateGetTypeID ();

		// extern CFDateRef CFDateCreate (CFAllocatorRef allocator, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDateRef* CFDateCreate (CFAllocatorRef* allocator, double at);

		// extern CFAbsoluteTime CFDateGetAbsoluteTime (CFDateRef theDate) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFDateGetAbsoluteTime (CFDateRef* theDate);

		// extern CFTimeInterval CFDateGetTimeIntervalSinceDate (CFDateRef theDate, CFDateRef otherDate) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFDateGetTimeIntervalSinceDate (CFDateRef* theDate, CFDateRef* otherDate);

		// extern CFComparisonResult CFDateCompare (CFDateRef theDate, CFDateRef otherDate, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFComparisonResult CFDateCompare (CFDateRef* theDate, CFDateRef* otherDate, void* context);

		// extern Boolean CFGregorianDateIsValid (CFGregorianDate gdate, CFOptionFlags unitFlags) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern byte CFGregorianDateIsValid (CFGregorianDate gdate, nuint unitFlags);

		// extern CFAbsoluteTime CFGregorianDateGetAbsoluteTime (CFGregorianDate gdate, CFTimeZoneRef tz) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe double CFGregorianDateGetAbsoluteTime (CFGregorianDate gdate, CFTimeZoneRef* tz);

		// extern CFGregorianDate CFAbsoluteTimeGetGregorianDate (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFGregorianDate CFAbsoluteTimeGetGregorianDate (double at, CFTimeZoneRef* tz);

		// extern CFAbsoluteTime CFAbsoluteTimeAddGregorianUnits (CFAbsoluteTime at, CFTimeZoneRef tz, CFGregorianUnits units) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe double CFAbsoluteTimeAddGregorianUnits (double at, CFTimeZoneRef* tz, CFGregorianUnits units);

		// extern CFGregorianUnits CFAbsoluteTimeGetDifferenceAsGregorianUnits (CFAbsoluteTime at1, CFAbsoluteTime at2, CFTimeZoneRef tz, CFOptionFlags unitFlags) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFGregorianUnits CFAbsoluteTimeGetDifferenceAsGregorianUnits (double at1, double at2, CFTimeZoneRef* tz, nuint unitFlags);

		// extern SInt32 CFAbsoluteTimeGetDayOfWeek (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe int CFAbsoluteTimeGetDayOfWeek (double at, CFTimeZoneRef* tz);

		// extern SInt32 CFAbsoluteTimeGetDayOfYear (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe int CFAbsoluteTimeGetDayOfYear (double at, CFTimeZoneRef* tz);

		// extern SInt32 CFAbsoluteTimeGetWeekOfYear (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFCalendar or NSCalendar API instead")]
		[DllImport ("__Internal")]
		static extern unsafe int CFAbsoluteTimeGetWeekOfYear (double at, CFTimeZoneRef* tz);

		// extern CFTypeID CFDataGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFDataGetTypeID ();

		// extern CFDataRef CFDataCreate (CFAllocatorRef allocator, const UInt8 *bytes, CFIndex length) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFDataCreate (CFAllocatorRef* allocator, byte* bytes, nint length);

		// extern CFDataRef CFDataCreateWithBytesNoCopy (CFAllocatorRef allocator, const UInt8 *bytes, CFIndex length, CFAllocatorRef bytesDeallocator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFDataCreateWithBytesNoCopy (CFAllocatorRef* allocator, byte* bytes, nint length, CFAllocatorRef* bytesDeallocator);

		// extern CFDataRef CFDataCreateCopy (CFAllocatorRef allocator, CFDataRef theData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFDataCreateCopy (CFAllocatorRef* allocator, CFDataRef* theData);

		// extern CFMutableDataRef CFDataCreateMutable (CFAllocatorRef allocator, CFIndex capacity) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableDataRef* CFDataCreateMutable (CFAllocatorRef* allocator, nint capacity);

		// extern CFMutableDataRef CFDataCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFDataRef theData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableDataRef* CFDataCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFDataRef* theData);

		// extern CFIndex CFDataGetLength (CFDataRef theData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFDataGetLength (CFDataRef* theData);

		// extern const UInt8 * CFDataGetBytePtr (CFDataRef theData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte* CFDataGetBytePtr (CFDataRef* theData);

		// extern UInt8 * CFDataGetMutableBytePtr (CFMutableDataRef theData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte* CFDataGetMutableBytePtr (CFMutableDataRef* theData);

		// extern void CFDataGetBytes (CFDataRef theData, CFRange range, UInt8 *buffer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDataGetBytes (CFDataRef* theData, CFRange range, byte* buffer);

		// extern void CFDataSetLength (CFMutableDataRef theData, CFIndex length) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDataSetLength (CFMutableDataRef* theData, nint length);

		// extern void CFDataIncreaseLength (CFMutableDataRef theData, CFIndex extraLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDataIncreaseLength (CFMutableDataRef* theData, nint extraLength);

		// extern void CFDataAppendBytes (CFMutableDataRef theData, const UInt8 *bytes, CFIndex length) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDataAppendBytes (CFMutableDataRef* theData, byte* bytes, nint length);

		// extern void CFDataReplaceBytes (CFMutableDataRef theData, CFRange range, const UInt8 *newBytes, CFIndex newLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDataReplaceBytes (CFMutableDataRef* theData, CFRange range, byte* newBytes, nint newLength);

		// extern void CFDataDeleteBytes (CFMutableDataRef theData, CFRange range) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDataDeleteBytes (CFMutableDataRef* theData, CFRange range);

		// extern CFRange CFDataFind (CFDataRef theData, CFDataRef dataToFind, CFRange searchRange, CFDataSearchFlags compareOptions) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFDataFind (CFDataRef* theData, CFDataRef* dataToFind, CFRange searchRange, CFDataSearchFlags compareOptions);

		// extern CFTypeID CFCharacterSetGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFCharacterSetGetTypeID ();

		// extern CFCharacterSetRef CFCharacterSetGetPredefined (CFCharacterSetPredefinedSet theSetIdentifier) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCharacterSetRef* CFCharacterSetGetPredefined (CFCharacterSetPredefinedSet theSetIdentifier);

		// extern CFCharacterSetRef CFCharacterSetCreateWithCharactersInRange (CFAllocatorRef alloc, CFRange theRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCharacterSetRef* CFCharacterSetCreateWithCharactersInRange (CFAllocatorRef* alloc, CFRange theRange);

		// extern CFCharacterSetRef CFCharacterSetCreateWithCharactersInString (CFAllocatorRef alloc, CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCharacterSetRef* CFCharacterSetCreateWithCharactersInString (CFAllocatorRef* alloc, CFStringRef* theString);

		// extern CFCharacterSetRef CFCharacterSetCreateWithBitmapRepresentation (CFAllocatorRef alloc, CFDataRef theData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCharacterSetRef* CFCharacterSetCreateWithBitmapRepresentation (CFAllocatorRef* alloc, CFDataRef* theData);

		// extern CFCharacterSetRef CFCharacterSetCreateInvertedSet (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCharacterSetRef* CFCharacterSetCreateInvertedSet (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

		// extern Boolean CFCharacterSetIsSupersetOfSet (CFCharacterSetRef theSet, CFCharacterSetRef theOtherset) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCharacterSetIsSupersetOfSet (CFCharacterSetRef* theSet, CFCharacterSetRef* theOtherset);

		// extern Boolean CFCharacterSetHasMemberInPlane (CFCharacterSetRef theSet, CFIndex thePlane) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCharacterSetHasMemberInPlane (CFCharacterSetRef* theSet, nint thePlane);

		// extern CFMutableCharacterSetRef CFCharacterSetCreateMutable (CFAllocatorRef alloc) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableCharacterSetRef* CFCharacterSetCreateMutable (CFAllocatorRef* alloc);

		// extern CFCharacterSetRef CFCharacterSetCreateCopy (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCharacterSetRef* CFCharacterSetCreateCopy (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

		// extern CFMutableCharacterSetRef CFCharacterSetCreateMutableCopy (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableCharacterSetRef* CFCharacterSetCreateMutableCopy (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

		// extern Boolean CFCharacterSetIsCharacterMember (CFCharacterSetRef theSet, UniChar theChar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCharacterSetIsCharacterMember (CFCharacterSetRef* theSet, ushort theChar);

		// extern Boolean CFCharacterSetIsLongCharacterMember (CFCharacterSetRef theSet, UTF32Char theChar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCharacterSetIsLongCharacterMember (CFCharacterSetRef* theSet, uint theChar);

		// extern CFDataRef CFCharacterSetCreateBitmapRepresentation (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFCharacterSetCreateBitmapRepresentation (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

		// extern void CFCharacterSetAddCharactersInRange (CFMutableCharacterSetRef theSet, CFRange theRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetAddCharactersInRange (CFMutableCharacterSetRef* theSet, CFRange theRange);

		// extern void CFCharacterSetRemoveCharactersInRange (CFMutableCharacterSetRef theSet, CFRange theRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetRemoveCharactersInRange (CFMutableCharacterSetRef* theSet, CFRange theRange);

		// extern void CFCharacterSetAddCharactersInString (CFMutableCharacterSetRef theSet, CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetAddCharactersInString (CFMutableCharacterSetRef* theSet, CFStringRef* theString);

		// extern void CFCharacterSetRemoveCharactersInString (CFMutableCharacterSetRef theSet, CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetRemoveCharactersInString (CFMutableCharacterSetRef* theSet, CFStringRef* theString);

		// extern void CFCharacterSetUnion (CFMutableCharacterSetRef theSet, CFCharacterSetRef theOtherSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetUnion (CFMutableCharacterSetRef* theSet, CFCharacterSetRef* theOtherSet);

		// extern void CFCharacterSetIntersect (CFMutableCharacterSetRef theSet, CFCharacterSetRef theOtherSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetIntersect (CFMutableCharacterSetRef* theSet, CFCharacterSetRef* theOtherSet);

		// extern void CFCharacterSetInvert (CFMutableCharacterSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCharacterSetInvert (CFMutableCharacterSetRef* theSet);

		// extern CFTypeID CFErrorGetTypeID () __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint CFErrorGetTypeID ();

		// extern CFErrorRef CFErrorCreate (CFAllocatorRef allocator, CFErrorDomain domain, CFIndex code, CFDictionaryRef userInfo) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFErrorRef* CFErrorCreate (CFAllocatorRef* allocator, CFErrorDomain* domain, nint code, CFDictionaryRef* userInfo);

		// extern CFErrorRef CFErrorCreateWithUserInfoKeysAndValues (CFAllocatorRef allocator, CFErrorDomain domain, CFIndex code, const void *const *userInfoKeys, const void *const *userInfoValues, CFIndex numUserInfoValues) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFErrorRef* CFErrorCreateWithUserInfoKeysAndValues (CFAllocatorRef* allocator, CFErrorDomain* domain, nint code, void** userInfoKeys, void** userInfoValues, nint numUserInfoValues);

		// extern CFErrorDomain CFErrorGetDomain (CFErrorRef err) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFErrorDomain* CFErrorGetDomain (CFErrorRef* err);

		// extern CFIndex CFErrorGetCode (CFErrorRef err) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFErrorGetCode (CFErrorRef* err);

		// extern CFDictionaryRef CFErrorCopyUserInfo (CFErrorRef err) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFErrorCopyUserInfo (CFErrorRef* err);

		// extern CFStringRef CFErrorCopyDescription (CFErrorRef err) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFErrorCopyDescription (CFErrorRef* err);

		// extern CFStringRef CFErrorCopyFailureReason (CFErrorRef err) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFErrorCopyFailureReason (CFErrorRef* err);

		// extern CFStringRef CFErrorCopyRecoverySuggestion (CFErrorRef err) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFErrorCopyRecoverySuggestion (CFErrorRef* err);

		// extern CFTypeID CFStringGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFStringGetTypeID ();

		// extern CFStringRef CFStringCreateWithPascalString (CFAllocatorRef alloc, ConstStr255Param pStr, CFStringEncoding encoding) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithPascalString (CFAllocatorRef* alloc, byte* pStr, uint encoding);

		// extern CFStringRef CFStringCreateWithCString (CFAllocatorRef alloc, const char *cStr, CFStringEncoding encoding) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithCString (CFAllocatorRef* alloc, sbyte* cStr, uint encoding);

		// extern CFStringRef CFStringCreateWithBytes (CFAllocatorRef alloc, const UInt8 *bytes, CFIndex numBytes, CFStringEncoding encoding, Boolean isExternalRepresentation) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithBytes (CFAllocatorRef* alloc, byte* bytes, nint numBytes, uint encoding, byte isExternalRepresentation);

		// extern CFStringRef CFStringCreateWithCharacters (CFAllocatorRef alloc, const UniChar *chars, CFIndex numChars) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithCharacters (CFAllocatorRef* alloc, ushort* chars, nint numChars);

		// extern CFStringRef CFStringCreateWithPascalStringNoCopy (CFAllocatorRef alloc, ConstStr255Param pStr, CFStringEncoding encoding, CFAllocatorRef contentsDeallocator) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithPascalStringNoCopy (CFAllocatorRef* alloc, byte* pStr, uint encoding, CFAllocatorRef* contentsDeallocator);

		// extern CFStringRef CFStringCreateWithCStringNoCopy (CFAllocatorRef alloc, const char *cStr, CFStringEncoding encoding, CFAllocatorRef contentsDeallocator) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithCStringNoCopy (CFAllocatorRef* alloc, sbyte* cStr, uint encoding, CFAllocatorRef* contentsDeallocator);

		// extern CFStringRef CFStringCreateWithBytesNoCopy (CFAllocatorRef alloc, const UInt8 *bytes, CFIndex numBytes, CFStringEncoding encoding, Boolean isExternalRepresentation, CFAllocatorRef contentsDeallocator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithBytesNoCopy (CFAllocatorRef* alloc, byte* bytes, nint numBytes, uint encoding, byte isExternalRepresentation, CFAllocatorRef* contentsDeallocator);

		// extern CFStringRef CFStringCreateWithCharactersNoCopy (CFAllocatorRef alloc, const UniChar *chars, CFIndex numChars, CFAllocatorRef contentsDeallocator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithCharactersNoCopy (CFAllocatorRef* alloc, ushort* chars, nint numChars, CFAllocatorRef* contentsDeallocator);

		// extern CFStringRef CFStringCreateWithSubstring (CFAllocatorRef alloc, CFStringRef str, CFRange range) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithSubstring (CFAllocatorRef* alloc, CFStringRef* str, CFRange range);

		// extern CFStringRef CFStringCreateCopy (CFAllocatorRef alloc, CFStringRef theString) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateCopy (CFAllocatorRef* alloc, CFStringRef* theString);

		// extern CFStringRef CFStringCreateWithFormat (CFAllocatorRef alloc, CFDictionaryRef formatOptions, CFStringRef format, ...) __attribute__((format(CFString, 3, 4))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithFormat (CFAllocatorRef* alloc, CFDictionaryRef* formatOptions, CFStringRef* format, IntPtr varArgs);

		// extern CFStringRef CFStringCreateWithFormatAndArguments (CFAllocatorRef alloc, CFDictionaryRef formatOptions, CFStringRef format, va_list arguments) __attribute__((format(CFString, 3, 0))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithFormatAndArguments (CFAllocatorRef* alloc, CFDictionaryRef* formatOptions, CFStringRef* format, sbyte* arguments);

		// extern CFStringRef CFStringCreateStringWithValidatedFormat (CFAllocatorRef alloc, CFDictionaryRef formatOptions, CFStringRef validFormatSpecifiers, CFStringRef format, CFErrorRef *errorPtr, ...) __attribute__((availability(macos, introduced=13.0))) __attribute__((availability(ios, introduced=16.0))) __attribute__((availability(watchos, introduced=8.0))) __attribute__((availability(tvos, introduced=8.0))) __attribute__((format(CFString, 3, 6))) __attribute__((availability(swift, unavailable))) __attribute__((cf_audited_transfer));
		[Unavailable (PlatformName.Swift)]
		[Watch (8,0), TV (8,0), Mac (13,0), iOS (16,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateStringWithValidatedFormat (CFAllocatorRef* alloc, CFDictionaryRef* formatOptions, CFStringRef* validFormatSpecifiers, CFStringRef* format, CFErrorRef** errorPtr, IntPtr varArgs);

		// extern CFStringRef CFStringCreateStringWithValidatedFormatAndArguments (CFAllocatorRef alloc, CFDictionaryRef formatOptions, CFStringRef validFormatSpecifiers, CFStringRef format, va_list arguments, CFErrorRef *errorPtr) __attribute__((availability(macos, introduced=13.0))) __attribute__((availability(ios, introduced=16.0))) __attribute__((availability(watchos, introduced=8.0))) __attribute__((availability(tvos, introduced=8.0))) __attribute__((format(CFString, 3, 0))) __attribute__((availability(swift, unavailable))) __attribute__((cf_audited_transfer));
		[Unavailable (PlatformName.Swift)]
		[Watch (8,0), TV (8,0), Mac (13,0), iOS (16,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateStringWithValidatedFormatAndArguments (CFAllocatorRef* alloc, CFDictionaryRef* formatOptions, CFStringRef* validFormatSpecifiers, CFStringRef* format, sbyte* arguments, CFErrorRef** errorPtr);

		// extern CFMutableStringRef CFStringCreateMutable (CFAllocatorRef alloc, CFIndex maxLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableStringRef* CFStringCreateMutable (CFAllocatorRef* alloc, nint maxLength);

		// extern CFMutableStringRef CFStringCreateMutableCopy (CFAllocatorRef alloc, CFIndex maxLength, CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableStringRef* CFStringCreateMutableCopy (CFAllocatorRef* alloc, nint maxLength, CFStringRef* theString);

		// extern CFMutableStringRef CFStringCreateMutableWithExternalCharactersNoCopy (CFAllocatorRef alloc, UniChar *chars, CFIndex numChars, CFIndex capacity, CFAllocatorRef externalCharactersAllocator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableStringRef* CFStringCreateMutableWithExternalCharactersNoCopy (CFAllocatorRef* alloc, ushort* chars, nint numChars, nint capacity, CFAllocatorRef* externalCharactersAllocator);

		// extern CFIndex CFStringGetLength (CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFStringGetLength (CFStringRef* theString);

		// extern UniChar CFStringGetCharacterAtIndex (CFStringRef theString, CFIndex idx) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe ushort CFStringGetCharacterAtIndex (CFStringRef* theString, nint idx);

		// extern void CFStringGetCharacters (CFStringRef theString, CFRange range, UniChar *buffer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringGetCharacters (CFStringRef* theString, CFRange range, ushort* buffer);

		// extern Boolean CFStringGetPascalString (CFStringRef theString, StringPtr buffer, CFIndex bufferSize, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringGetPascalString (CFStringRef* theString, byte* buffer, nint bufferSize, uint encoding);

		// extern Boolean CFStringGetCString (CFStringRef theString, char *buffer, CFIndex bufferSize, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringGetCString (CFStringRef* theString, sbyte* buffer, nint bufferSize, uint encoding);

		// extern ConstStringPtr CFStringGetPascalStringPtr (CFStringRef theString, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte* CFStringGetPascalStringPtr (CFStringRef* theString, uint encoding);

		// extern const char * CFStringGetCStringPtr (CFStringRef theString, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe sbyte* CFStringGetCStringPtr (CFStringRef* theString, uint encoding);

		// extern const UniChar * CFStringGetCharactersPtr (CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe ushort* CFStringGetCharactersPtr (CFStringRef* theString);

		// extern CFIndex CFStringGetBytes (CFStringRef theString, CFRange range, CFStringEncoding encoding, UInt8 lossByte, Boolean isExternalRepresentation, UInt8 *buffer, CFIndex maxBufLen, CFIndex *usedBufLen) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFStringGetBytes (CFStringRef* theString, CFRange range, uint encoding, byte lossByte, byte isExternalRepresentation, byte* buffer, nint maxBufLen, nint* usedBufLen);

		// extern CFStringRef CFStringCreateFromExternalRepresentation (CFAllocatorRef alloc, CFDataRef data, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateFromExternalRepresentation (CFAllocatorRef* alloc, CFDataRef* data, uint encoding);

		// extern CFDataRef CFStringCreateExternalRepresentation (CFAllocatorRef alloc, CFStringRef theString, CFStringEncoding encoding, UInt8 lossByte) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFStringCreateExternalRepresentation (CFAllocatorRef* alloc, CFStringRef* theString, uint encoding, byte lossByte);

		// extern CFStringEncoding CFStringGetSmallestEncoding (CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint CFStringGetSmallestEncoding (CFStringRef* theString);

		// extern CFStringEncoding CFStringGetFastestEncoding (CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint CFStringGetFastestEncoding (CFStringRef* theString);

		// extern CFStringEncoding CFStringGetSystemEncoding () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern uint CFStringGetSystemEncoding ();

		// extern CFIndex CFStringGetMaximumSizeForEncoding (CFIndex length, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nint CFStringGetMaximumSizeForEncoding (nint length, uint encoding);

		// extern Boolean CFStringGetFileSystemRepresentation (CFStringRef string, char *buffer, CFIndex maxBufLen) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringGetFileSystemRepresentation (CFStringRef* @string, sbyte* buffer, nint maxBufLen);

		// extern CFIndex CFStringGetMaximumSizeOfFileSystemRepresentation (CFStringRef string) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFStringGetMaximumSizeOfFileSystemRepresentation (CFStringRef* @string);

		// extern CFStringRef CFStringCreateWithFileSystemRepresentation (CFAllocatorRef alloc, const char *buffer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateWithFileSystemRepresentation (CFAllocatorRef* alloc, sbyte* buffer);

		// extern CFComparisonResult CFStringCompareWithOptionsAndLocale (CFStringRef theString1, CFStringRef theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions, CFLocaleRef locale) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFComparisonResult CFStringCompareWithOptionsAndLocale (CFStringRef* theString1, CFStringRef* theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions, CFLocaleRef* locale);

		// extern CFComparisonResult CFStringCompareWithOptions (CFStringRef theString1, CFStringRef theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFComparisonResult CFStringCompareWithOptions (CFStringRef* theString1, CFStringRef* theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions);

		// extern CFComparisonResult CFStringCompare (CFStringRef theString1, CFStringRef theString2, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFComparisonResult CFStringCompare (CFStringRef* theString1, CFStringRef* theString2, CFStringCompareFlags compareOptions);

		// extern Boolean CFStringFindWithOptionsAndLocale (CFStringRef theString, CFStringRef stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFLocaleRef locale, CFRange *result) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringFindWithOptionsAndLocale (CFStringRef* theString, CFStringRef* stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFLocaleRef* locale, CFRange* result);

		// extern Boolean CFStringFindWithOptions (CFStringRef theString, CFStringRef stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange *result) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringFindWithOptions (CFStringRef* theString, CFStringRef* stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange* result);

		// extern CFArrayRef CFStringCreateArrayWithFindResults (CFAllocatorRef alloc, CFStringRef theString, CFStringRef stringToFind, CFRange rangeToSearch, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFStringCreateArrayWithFindResults (CFAllocatorRef* alloc, CFStringRef* theString, CFStringRef* stringToFind, CFRange rangeToSearch, CFStringCompareFlags compareOptions);

		// extern CFRange CFStringFind (CFStringRef theString, CFStringRef stringToFind, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFStringFind (CFStringRef* theString, CFStringRef* stringToFind, CFStringCompareFlags compareOptions);

		// extern Boolean CFStringHasPrefix (CFStringRef theString, CFStringRef prefix) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringHasPrefix (CFStringRef* theString, CFStringRef* prefix);

		// extern Boolean CFStringHasSuffix (CFStringRef theString, CFStringRef suffix) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringHasSuffix (CFStringRef* theString, CFStringRef* suffix);

		// extern CFRange CFStringGetRangeOfComposedCharactersAtIndex (CFStringRef theString, CFIndex theIndex) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFStringGetRangeOfComposedCharactersAtIndex (CFStringRef* theString, nint theIndex);

		// extern Boolean CFStringFindCharacterFromSet (CFStringRef theString, CFCharacterSetRef theSet, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange *result) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringFindCharacterFromSet (CFStringRef* theString, CFCharacterSetRef* theSet, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange* result);

		// extern void CFStringGetLineBounds (CFStringRef theString, CFRange range, CFIndex *lineBeginIndex, CFIndex *lineEndIndex, CFIndex *contentsEndIndex) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringGetLineBounds (CFStringRef* theString, CFRange range, nint* lineBeginIndex, nint* lineEndIndex, nint* contentsEndIndex);

		// extern void CFStringGetParagraphBounds (CFStringRef string, CFRange range, CFIndex *parBeginIndex, CFIndex *parEndIndex, CFIndex *contentsEndIndex) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFStringGetParagraphBounds (CFStringRef* @string, CFRange range, nint* parBeginIndex, nint* parEndIndex, nint* contentsEndIndex);

		// extern CFIndex CFStringGetHyphenationLocationBeforeIndex (CFStringRef string, CFIndex location, CFRange limitRange, CFOptionFlags options, CFLocaleRef locale, UTF32Char *character) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.2))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (4,2)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFStringGetHyphenationLocationBeforeIndex (CFStringRef* @string, nint location, CFRange limitRange, nuint options, CFLocaleRef* locale, uint* character);

		// extern Boolean CFStringIsHyphenationAvailableForLocale (CFLocaleRef locale) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringIsHyphenationAvailableForLocale (CFLocaleRef* locale);

		// extern CFStringRef CFStringCreateByCombiningStrings (CFAllocatorRef alloc, CFArrayRef theArray, CFStringRef separatorString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringCreateByCombiningStrings (CFAllocatorRef* alloc, CFArrayRef* theArray, CFStringRef* separatorString);

		// extern CFArrayRef CFStringCreateArrayBySeparatingStrings (CFAllocatorRef alloc, CFStringRef theString, CFStringRef separatorString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFStringCreateArrayBySeparatingStrings (CFAllocatorRef* alloc, CFStringRef* theString, CFStringRef* separatorString);

		// extern SInt32 CFStringGetIntValue (CFStringRef str) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe int CFStringGetIntValue (CFStringRef* str);

		// extern double CFStringGetDoubleValue (CFStringRef str) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFStringGetDoubleValue (CFStringRef* str);

		// extern void CFStringAppend (CFMutableStringRef theString, CFStringRef appendedString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringAppend (CFMutableStringRef* theString, CFStringRef* appendedString);

		// extern void CFStringAppendCharacters (CFMutableStringRef theString, const UniChar *chars, CFIndex numChars) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringAppendCharacters (CFMutableStringRef* theString, ushort* chars, nint numChars);

		// extern void CFStringAppendPascalString (CFMutableStringRef theString, ConstStr255Param pStr, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringAppendPascalString (CFMutableStringRef* theString, byte* pStr, uint encoding);

		// extern void CFStringAppendCString (CFMutableStringRef theString, const char *cStr, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringAppendCString (CFMutableStringRef* theString, sbyte* cStr, uint encoding);

		// extern void CFStringAppendFormat (CFMutableStringRef theString, CFDictionaryRef formatOptions, CFStringRef format, ...) __attribute__((format(CFString, 3, 4))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringAppendFormat (CFMutableStringRef* theString, CFDictionaryRef* formatOptions, CFStringRef* format, IntPtr varArgs);

		// extern void CFStringAppendFormatAndArguments (CFMutableStringRef theString, CFDictionaryRef formatOptions, CFStringRef format, va_list arguments) __attribute__((format(CFString, 3, 0))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringAppendFormatAndArguments (CFMutableStringRef* theString, CFDictionaryRef* formatOptions, CFStringRef* format, sbyte* arguments);

		// extern void CFStringInsert (CFMutableStringRef str, CFIndex idx, CFStringRef insertedStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringInsert (CFMutableStringRef* str, nint idx, CFStringRef* insertedStr);

		// extern void CFStringDelete (CFMutableStringRef theString, CFRange range) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringDelete (CFMutableStringRef* theString, CFRange range);

		// extern void CFStringReplace (CFMutableStringRef theString, CFRange range, CFStringRef replacement) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringReplace (CFMutableStringRef* theString, CFRange range, CFStringRef* replacement);

		// extern void CFStringReplaceAll (CFMutableStringRef theString, CFStringRef replacement) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringReplaceAll (CFMutableStringRef* theString, CFStringRef* replacement);

		// extern CFIndex CFStringFindAndReplace (CFMutableStringRef theString, CFStringRef stringToFind, CFStringRef replacementString, CFRange rangeToSearch, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFStringFindAndReplace (CFMutableStringRef* theString, CFStringRef* stringToFind, CFStringRef* replacementString, CFRange rangeToSearch, CFStringCompareFlags compareOptions);

		// extern void CFStringSetExternalCharactersNoCopy (CFMutableStringRef theString, UniChar *chars, CFIndex length, CFIndex capacity) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringSetExternalCharactersNoCopy (CFMutableStringRef* theString, ushort* chars, nint length, nint capacity);

		// extern void CFStringPad (CFMutableStringRef theString, CFStringRef padString, CFIndex length, CFIndex indexIntoPad) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringPad (CFMutableStringRef* theString, CFStringRef* padString, nint length, nint indexIntoPad);

		// extern void CFStringTrim (CFMutableStringRef theString, CFStringRef trimString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringTrim (CFMutableStringRef* theString, CFStringRef* trimString);

		// extern void CFStringTrimWhitespace (CFMutableStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringTrimWhitespace (CFMutableStringRef* theString);

		// extern void CFStringLowercase (CFMutableStringRef theString, CFLocaleRef locale) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringLowercase (CFMutableStringRef* theString, CFLocaleRef* locale);

		// extern void CFStringUppercase (CFMutableStringRef theString, CFLocaleRef locale) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringUppercase (CFMutableStringRef* theString, CFLocaleRef* locale);

		// extern void CFStringCapitalize (CFMutableStringRef theString, CFLocaleRef locale) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringCapitalize (CFMutableStringRef* theString, CFLocaleRef* locale);

		// extern void CFStringNormalize (CFMutableStringRef theString, CFStringNormalizationForm theForm) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringNormalize (CFMutableStringRef* theString, CFStringNormalizationForm theForm);

		// extern void CFStringFold (CFMutableStringRef theString, CFStringCompareFlags theFlags, CFLocaleRef theLocale) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFStringFold (CFMutableStringRef* theString, CFStringCompareFlags theFlags, CFLocaleRef* theLocale);

		// extern Boolean CFStringTransform (CFMutableStringRef string, CFRange *range, CFStringRef transform, Boolean reverse) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringTransform (CFMutableStringRef* @string, CFRange* range, CFStringRef* transform, byte reverse);

		// extern Boolean CFStringIsEncodingAvailable (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern byte CFStringIsEncodingAvailable (uint encoding);

		// extern const CFStringEncoding * CFStringGetListOfAvailableEncodings () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint* CFStringGetListOfAvailableEncodings ();

		// extern CFStringRef CFStringGetNameOfEncoding (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringGetNameOfEncoding (uint encoding);

		// extern unsigned long CFStringConvertEncodingToNSStringEncoding (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFStringConvertEncodingToNSStringEncoding (uint encoding);

		// extern CFStringEncoding CFStringConvertNSStringEncodingToEncoding (unsigned long encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern uint CFStringConvertNSStringEncodingToEncoding (nuint encoding);

		// extern UInt32 CFStringConvertEncodingToWindowsCodepage (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern uint CFStringConvertEncodingToWindowsCodepage (uint encoding);

		// extern CFStringEncoding CFStringConvertWindowsCodepageToEncoding (UInt32 codepage) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern uint CFStringConvertWindowsCodepageToEncoding (uint codepage);

		// extern CFStringEncoding CFStringConvertIANACharSetNameToEncoding (CFStringRef theString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint CFStringConvertIANACharSetNameToEncoding (CFStringRef* theString);

		// extern CFStringRef CFStringConvertEncodingToIANACharSetName (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringConvertEncodingToIANACharSetName (uint encoding);

		// extern CFStringEncoding CFStringGetMostCompatibleMacStringEncoding (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern uint CFStringGetMostCompatibleMacStringEncoding (uint encoding);

		// void CFStringInitInlineBuffer (CFStringRef str, CFStringInlineBuffer *buf, CFRange range) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFStringInitInlineBuffer (CFStringRef* str, CFStringInlineBuffer* buf, CFRange range);

		// UniChar CFStringGetCharacterFromInlineBuffer (CFStringInlineBuffer *buf, CFIndex idx) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe ushort CFStringGetCharacterFromInlineBuffer (CFStringInlineBuffer* buf, nint idx);

		// Boolean CFStringIsSurrogateHighCharacter (UniChar character) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern byte CFStringIsSurrogateHighCharacter (ushort character);

		// Boolean CFStringIsSurrogateLowCharacter (UniChar character) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern byte CFStringIsSurrogateLowCharacter (ushort character);

		// UTF32Char CFStringGetLongCharacterForSurrogatePair (UniChar surrogateHigh, UniChar surrogateLow) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern uint CFStringGetLongCharacterForSurrogatePair (ushort surrogateHigh, ushort surrogateLow);

		// Boolean CFStringGetSurrogatePairForLongCharacter (UTF32Char character, UniChar *surrogates) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFStringGetSurrogatePairForLongCharacter (uint character, ushort* surrogates);

		// extern void CFShow (CFTypeRef obj) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFShow (void* obj);

		// extern void CFShowStr (CFStringRef str) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFShowStr (CFStringRef* str);

		// extern CFStringRef __CFStringMakeConstantString (const char *cStr) __attribute__((format_arg(1))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* __CFStringMakeConstantString (sbyte* cStr);

		// extern CFTypeID CFTimeZoneGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFTimeZoneGetTypeID ();

		// extern CFTimeZoneRef CFTimeZoneCopySystem () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTimeZoneRef* CFTimeZoneCopySystem ();

		// extern void CFTimeZoneResetSystem () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern void CFTimeZoneResetSystem ();

		// extern CFTimeZoneRef CFTimeZoneCopyDefault () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTimeZoneRef* CFTimeZoneCopyDefault ();

		// extern void CFTimeZoneSetDefault (CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTimeZoneSetDefault (CFTimeZoneRef* tz);

		// extern CFArrayRef CFTimeZoneCopyKnownNames () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFTimeZoneCopyKnownNames ();

		// extern CFDictionaryRef CFTimeZoneCopyAbbreviationDictionary () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFTimeZoneCopyAbbreviationDictionary ();

		// extern void CFTimeZoneSetAbbreviationDictionary (CFDictionaryRef dict) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTimeZoneSetAbbreviationDictionary (CFDictionaryRef* dict);

		// extern CFTimeZoneRef CFTimeZoneCreate (CFAllocatorRef allocator, CFStringRef name, CFDataRef data) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTimeZoneRef* CFTimeZoneCreate (CFAllocatorRef* allocator, CFStringRef* name, CFDataRef* data);

		// extern CFTimeZoneRef CFTimeZoneCreateWithTimeIntervalFromGMT (CFAllocatorRef allocator, CFTimeInterval ti) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTimeZoneRef* CFTimeZoneCreateWithTimeIntervalFromGMT (CFAllocatorRef* allocator, double ti);

		// extern CFTimeZoneRef CFTimeZoneCreateWithName (CFAllocatorRef allocator, CFStringRef name, Boolean tryAbbrev) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTimeZoneRef* CFTimeZoneCreateWithName (CFAllocatorRef* allocator, CFStringRef* name, byte tryAbbrev);

		// extern CFStringRef CFTimeZoneGetName (CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFTimeZoneGetName (CFTimeZoneRef* tz);

		// extern CFDataRef CFTimeZoneGetData (CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFTimeZoneGetData (CFTimeZoneRef* tz);

		// extern CFTimeInterval CFTimeZoneGetSecondsFromGMT (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFTimeZoneGetSecondsFromGMT (CFTimeZoneRef* tz, double at);

		// extern CFStringRef CFTimeZoneCopyAbbreviation (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFTimeZoneCopyAbbreviation (CFTimeZoneRef* tz, double at);

		// extern Boolean CFTimeZoneIsDaylightSavingTime (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFTimeZoneIsDaylightSavingTime (CFTimeZoneRef* tz, double at);

		// extern CFTimeInterval CFTimeZoneGetDaylightSavingTimeOffset (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe double CFTimeZoneGetDaylightSavingTimeOffset (CFTimeZoneRef* tz, double at);

		// extern CFAbsoluteTime CFTimeZoneGetNextDaylightSavingTimeTransition (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe double CFTimeZoneGetNextDaylightSavingTimeTransition (CFTimeZoneRef* tz, double at);

		// extern CFStringRef CFTimeZoneCopyLocalizedName (CFTimeZoneRef tz, CFTimeZoneNameStyle style, CFLocaleRef locale) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFTimeZoneCopyLocalizedName (CFTimeZoneRef* tz, CFTimeZoneNameStyle style, CFLocaleRef* locale);

		// extern CFTypeID CFCalendarGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFCalendarGetTypeID ();

		// extern CFCalendarRef CFCalendarCopyCurrent () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCalendarRef* CFCalendarCopyCurrent ();

		// extern CFCalendarRef CFCalendarCreateWithIdentifier (CFAllocatorRef allocator, CFCalendarIdentifier identifier) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCalendarRef* CFCalendarCreateWithIdentifier (CFAllocatorRef* allocator, CFCalendarIdentifier* identifier);

		// extern CFCalendarIdentifier CFCalendarGetIdentifier (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFCalendarIdentifier* CFCalendarGetIdentifier (CFCalendarRef* calendar);

		// extern CFLocaleRef CFCalendarCopyLocale (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFCalendarCopyLocale (CFCalendarRef* calendar);

		// extern void CFCalendarSetLocale (CFCalendarRef calendar, CFLocaleRef locale) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCalendarSetLocale (CFCalendarRef* calendar, CFLocaleRef* locale);

		// extern CFTimeZoneRef CFCalendarCopyTimeZone (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTimeZoneRef* CFCalendarCopyTimeZone (CFCalendarRef* calendar);

		// extern void CFCalendarSetTimeZone (CFCalendarRef calendar, CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCalendarSetTimeZone (CFCalendarRef* calendar, CFTimeZoneRef* tz);

		// extern CFIndex CFCalendarGetFirstWeekday (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFCalendarGetFirstWeekday (CFCalendarRef* calendar);

		// extern void CFCalendarSetFirstWeekday (CFCalendarRef calendar, CFIndex wkdy) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCalendarSetFirstWeekday (CFCalendarRef* calendar, nint wkdy);

		// extern CFIndex CFCalendarGetMinimumDaysInFirstWeek (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFCalendarGetMinimumDaysInFirstWeek (CFCalendarRef* calendar);

		// extern void CFCalendarSetMinimumDaysInFirstWeek (CFCalendarRef calendar, CFIndex mwd) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFCalendarSetMinimumDaysInFirstWeek (CFCalendarRef* calendar, nint mwd);

		// extern CFRange CFCalendarGetMinimumRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit unit) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFCalendarGetMinimumRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit unit);

		// extern CFRange CFCalendarGetMaximumRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit unit) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFCalendarGetMaximumRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit unit);

		// extern CFRange CFCalendarGetRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFCalendarGetRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, double at);

		// extern CFIndex CFCalendarGetOrdinalityOfUnit (CFCalendarRef calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFCalendarGetOrdinalityOfUnit (CFCalendarRef* calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, double at);

		// extern Boolean CFCalendarGetTimeRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit unit, CFAbsoluteTime at, CFAbsoluteTime *startp, CFTimeInterval *tip) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFCalendarGetTimeRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit unit, double at, double* startp, double* tip);

		// extern Boolean CFCalendarComposeAbsoluteTime (CFCalendarRef calendar, CFAbsoluteTime *at, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCalendarComposeAbsoluteTime (CFCalendarRef* calendar, double* at, sbyte* componentDesc, IntPtr varArgs);

		// extern Boolean CFCalendarDecomposeAbsoluteTime (CFCalendarRef calendar, CFAbsoluteTime at, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCalendarDecomposeAbsoluteTime (CFCalendarRef* calendar, double at, sbyte* componentDesc, IntPtr varArgs);

		// extern Boolean CFCalendarAddComponents (CFCalendarRef calendar, CFAbsoluteTime *at, CFOptionFlags options, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCalendarAddComponents (CFCalendarRef* calendar, double* at, nuint options, sbyte* componentDesc, IntPtr varArgs);

		// extern Boolean CFCalendarGetComponentDifference (CFCalendarRef calendar, CFAbsoluteTime startingAT, CFAbsoluteTime resultAT, CFOptionFlags options, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFCalendarGetComponentDifference (CFCalendarRef* calendar, double startingAT, double resultAT, nuint options, sbyte* componentDesc, IntPtr varArgs);

		// extern CFStringRef CFDateFormatterCreateDateFormatFromTemplate (CFAllocatorRef allocator, CFStringRef tmplate, CFOptionFlags options, CFLocaleRef locale) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFDateFormatterCreateDateFormatFromTemplate (CFAllocatorRef* allocator, CFStringRef* tmplate, nuint options, CFLocaleRef* locale);

		// extern CFTypeID CFDateFormatterGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFDateFormatterGetTypeID ();

		// extern CFDateFormatterRef CFDateFormatterCreateISO8601Formatter (CFAllocatorRef allocator, CFISO8601DateFormatOptions formatOptions) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDateFormatterRef* CFDateFormatterCreateISO8601Formatter (CFAllocatorRef* allocator, CFISO8601DateFormatOptions formatOptions);

		// extern CFDateFormatterRef CFDateFormatterCreate (CFAllocatorRef allocator, CFLocaleRef locale, CFDateFormatterStyle dateStyle, CFDateFormatterStyle timeStyle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDateFormatterRef* CFDateFormatterCreate (CFAllocatorRef* allocator, CFLocaleRef* locale, CFDateFormatterStyle dateStyle, CFDateFormatterStyle timeStyle);

		// extern CFLocaleRef CFDateFormatterGetLocale (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFDateFormatterGetLocale (CFDateFormatterRef* formatter);

		// extern CFDateFormatterStyle CFDateFormatterGetDateStyle (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDateFormatterStyle CFDateFormatterGetDateStyle (CFDateFormatterRef* formatter);

		// extern CFDateFormatterStyle CFDateFormatterGetTimeStyle (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDateFormatterStyle CFDateFormatterGetTimeStyle (CFDateFormatterRef* formatter);

		// extern CFStringRef CFDateFormatterGetFormat (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFDateFormatterGetFormat (CFDateFormatterRef* formatter);

		// extern void CFDateFormatterSetFormat (CFDateFormatterRef formatter, CFStringRef formatString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDateFormatterSetFormat (CFDateFormatterRef* formatter, CFStringRef* formatString);

		// extern CFStringRef CFDateFormatterCreateStringWithDate (CFAllocatorRef allocator, CFDateFormatterRef formatter, CFDateRef date) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFDateFormatterCreateStringWithDate (CFAllocatorRef* allocator, CFDateFormatterRef* formatter, CFDateRef* date);

		// extern CFStringRef CFDateFormatterCreateStringWithAbsoluteTime (CFAllocatorRef allocator, CFDateFormatterRef formatter, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFDateFormatterCreateStringWithAbsoluteTime (CFAllocatorRef* allocator, CFDateFormatterRef* formatter, double at);

		// extern CFDateRef CFDateFormatterCreateDateFromString (CFAllocatorRef allocator, CFDateFormatterRef formatter, CFStringRef string, CFRange *rangep) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDateRef* CFDateFormatterCreateDateFromString (CFAllocatorRef* allocator, CFDateFormatterRef* formatter, CFStringRef* @string, CFRange* rangep);

		// extern Boolean CFDateFormatterGetAbsoluteTimeFromString (CFDateFormatterRef formatter, CFStringRef string, CFRange *rangep, CFAbsoluteTime *atp) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFDateFormatterGetAbsoluteTimeFromString (CFDateFormatterRef* formatter, CFStringRef* @string, CFRange* rangep, double* atp);

		// extern void CFDateFormatterSetProperty (CFDateFormatterRef formatter, CFStringRef key, CFTypeRef value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFDateFormatterSetProperty (CFDateFormatterRef* formatter, CFStringRef* key, void* value);

		// extern CFTypeRef CFDateFormatterCopyProperty (CFDateFormatterRef formatter, CFDateFormatterKey key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFDateFormatterCopyProperty (CFDateFormatterRef* formatter, CFDateFormatterKey* key);

		// extern CFTypeID CFBooleanGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFBooleanGetTypeID ();

		// extern Boolean CFBooleanGetValue (CFBooleanRef boolean) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBooleanGetValue (CFBooleanRef* boolean);

		// extern CFTypeID CFNumberGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFNumberGetTypeID ();

		// extern CFNumberRef CFNumberCreate (CFAllocatorRef allocator, CFNumberType theType, const void *valuePtr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNumberRef* CFNumberCreate (CFAllocatorRef* allocator, CFNumberType theType, void* valuePtr);

		// extern CFNumberType CFNumberGetType (CFNumberRef number) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNumberType CFNumberGetType (CFNumberRef* number);

		// extern CFIndex CFNumberGetByteSize (CFNumberRef number) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFNumberGetByteSize (CFNumberRef* number);

		// extern Boolean CFNumberIsFloatType (CFNumberRef number) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFNumberIsFloatType (CFNumberRef* number);

		// extern Boolean CFNumberGetValue (CFNumberRef number, CFNumberType theType, void *valuePtr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFNumberGetValue (CFNumberRef* number, CFNumberType theType, void* valuePtr);

		// extern CFComparisonResult CFNumberCompare (CFNumberRef number, CFNumberRef otherNumber, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFComparisonResult CFNumberCompare (CFNumberRef* number, CFNumberRef* otherNumber, void* context);

		// extern CFTypeID CFNumberFormatterGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFNumberFormatterGetTypeID ();

		// extern CFNumberFormatterRef CFNumberFormatterCreate (CFAllocatorRef allocator, CFLocaleRef locale, CFNumberFormatterStyle style) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNumberFormatterRef* CFNumberFormatterCreate (CFAllocatorRef* allocator, CFLocaleRef* locale, CFNumberFormatterStyle style);

		// extern CFLocaleRef CFNumberFormatterGetLocale (CFNumberFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFLocaleRef* CFNumberFormatterGetLocale (CFNumberFormatterRef* formatter);

		// extern CFNumberFormatterStyle CFNumberFormatterGetStyle (CFNumberFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNumberFormatterStyle CFNumberFormatterGetStyle (CFNumberFormatterRef* formatter);

		// extern CFStringRef CFNumberFormatterGetFormat (CFNumberFormatterRef formatter) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFNumberFormatterGetFormat (CFNumberFormatterRef* formatter);

		// extern void CFNumberFormatterSetFormat (CFNumberFormatterRef formatter, CFStringRef formatString) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNumberFormatterSetFormat (CFNumberFormatterRef* formatter, CFStringRef* formatString);

		// extern CFStringRef CFNumberFormatterCreateStringWithNumber (CFAllocatorRef allocator, CFNumberFormatterRef formatter, CFNumberRef number) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFNumberFormatterCreateStringWithNumber (CFAllocatorRef* allocator, CFNumberFormatterRef* formatter, CFNumberRef* number);

		// extern CFStringRef CFNumberFormatterCreateStringWithValue (CFAllocatorRef allocator, CFNumberFormatterRef formatter, CFNumberType numberType, const void *valuePtr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFNumberFormatterCreateStringWithValue (CFAllocatorRef* allocator, CFNumberFormatterRef* formatter, CFNumberType numberType, void* valuePtr);

		// extern CFNumberRef CFNumberFormatterCreateNumberFromString (CFAllocatorRef allocator, CFNumberFormatterRef formatter, CFStringRef string, CFRange *rangep, CFOptionFlags options) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFNumberRef* CFNumberFormatterCreateNumberFromString (CFAllocatorRef* allocator, CFNumberFormatterRef* formatter, CFStringRef* @string, CFRange* rangep, nuint options);

		// extern Boolean CFNumberFormatterGetValueFromString (CFNumberFormatterRef formatter, CFStringRef string, CFRange *rangep, CFNumberType numberType, void *valuePtr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFNumberFormatterGetValueFromString (CFNumberFormatterRef* formatter, CFStringRef* @string, CFRange* rangep, CFNumberType numberType, void* valuePtr);

		// extern void CFNumberFormatterSetProperty (CFNumberFormatterRef formatter, CFNumberFormatterKey key, CFTypeRef value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFNumberFormatterSetProperty (CFNumberFormatterRef* formatter, CFNumberFormatterKey* key, void* value);

		// extern CFTypeRef CFNumberFormatterCopyProperty (CFNumberFormatterRef formatter, CFNumberFormatterKey key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFNumberFormatterCopyProperty (CFNumberFormatterRef* formatter, CFNumberFormatterKey* key);

		// extern Boolean CFNumberFormatterGetDecimalInfoForCurrencyCode (CFStringRef currencyCode, int32_t *defaultFractionDigits, double *roundingIncrement) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFNumberFormatterGetDecimalInfoForCurrencyCode (CFStringRef* currencyCode, int* defaultFractionDigits, double* roundingIncrement);

		// extern CFPropertyListRef _Nullable CFPreferencesCopyAppValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* CFPreferencesCopyAppValue (CFStringRef* key, CFStringRef* applicationID);

		// extern Boolean CFPreferencesGetAppBooleanValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID, Boolean * _Nullable keyExistsAndHasValidFormat) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPreferencesGetAppBooleanValue (CFStringRef* key, CFStringRef* applicationID, [NullAllowed] byte* keyExistsAndHasValidFormat);

		// extern CFIndex CFPreferencesGetAppIntegerValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID, Boolean * _Nullable keyExistsAndHasValidFormat) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFPreferencesGetAppIntegerValue (CFStringRef* key, CFStringRef* applicationID, [NullAllowed] byte* keyExistsAndHasValidFormat);

		// extern void CFPreferencesSetAppValue (CFStringRef _Nonnull key, CFPropertyListRef _Nullable value, CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPreferencesSetAppValue (CFStringRef* key, [NullAllowed] void* value, CFStringRef* applicationID);

		// extern void CFPreferencesAddSuitePreferencesToApp (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull suiteID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPreferencesAddSuitePreferencesToApp (CFStringRef* applicationID, CFStringRef* suiteID);

		// extern void CFPreferencesRemoveSuitePreferencesFromApp (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull suiteID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPreferencesRemoveSuitePreferencesFromApp (CFStringRef* applicationID, CFStringRef* suiteID);

		// extern Boolean CFPreferencesAppSynchronize (CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPreferencesAppSynchronize (CFStringRef* applicationID);

		// extern CFPropertyListRef _Nullable CFPreferencesCopyValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* CFPreferencesCopyValue (CFStringRef* key, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

		// extern CFDictionaryRef _Nonnull CFPreferencesCopyMultiple (CFArrayRef _Nullable keysToFetch, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFPreferencesCopyMultiple ([NullAllowed] CFArrayRef* keysToFetch, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

		// extern void CFPreferencesSetValue (CFStringRef _Nonnull key, CFPropertyListRef _Nullable value, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPreferencesSetValue (CFStringRef* key, [NullAllowed] void* value, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

		// extern void CFPreferencesSetMultiple (CFDictionaryRef _Nullable keysToSet, CFArrayRef _Nullable keysToRemove, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPreferencesSetMultiple ([NullAllowed] CFDictionaryRef* keysToSet, [NullAllowed] CFArrayRef* keysToRemove, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

		// extern Boolean CFPreferencesSynchronize (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPreferencesSynchronize (CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

		// extern CFArrayRef _Nullable CFPreferencesCopyApplicationList (CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Unsupported API")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Unsupported API")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Unsupported API")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Unsupported API")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Unsupported API")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Unsupported API")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Unsupported API")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Unsupported API")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* CFPreferencesCopyApplicationList (CFStringRef* userName, CFStringRef* hostName);

		// extern CFArrayRef _Nullable CFPreferencesCopyKeyList (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* CFPreferencesCopyKeyList (CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

		// extern Boolean CFPreferencesAppValueIsForced (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPreferencesAppValueIsForced (CFStringRef* key, CFStringRef* applicationID);

		// extern CFTypeID CFURLGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFURLGetTypeID ();

		// extern CFURLRef CFURLCreateWithBytes (CFAllocatorRef allocator, const UInt8 *URLBytes, CFIndex length, CFStringEncoding encoding, CFURLRef baseURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateWithBytes (CFAllocatorRef* allocator, byte* URLBytes, nint length, uint encoding, CFURLRef* baseURL);

		// extern CFDataRef CFURLCreateData (CFAllocatorRef allocator, CFURLRef url, CFStringEncoding encoding, Boolean escapeWhitespace) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFURLCreateData (CFAllocatorRef* allocator, CFURLRef* url, uint encoding, byte escapeWhitespace);

		// extern CFURLRef CFURLCreateWithString (CFAllocatorRef allocator, CFStringRef URLString, CFURLRef baseURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateWithString (CFAllocatorRef* allocator, CFStringRef* URLString, CFURLRef* baseURL);

		// extern CFURLRef CFURLCreateAbsoluteURLWithBytes (CFAllocatorRef alloc, const UInt8 *relativeURLBytes, CFIndex length, CFStringEncoding encoding, CFURLRef baseURL, Boolean useCompatibilityMode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateAbsoluteURLWithBytes (CFAllocatorRef* alloc, byte* relativeURLBytes, nint length, uint encoding, CFURLRef* baseURL, byte useCompatibilityMode);

		// extern CFURLRef CFURLCreateWithFileSystemPath (CFAllocatorRef allocator, CFStringRef filePath, CFURLPathStyle pathStyle, Boolean isDirectory) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateWithFileSystemPath (CFAllocatorRef* allocator, CFStringRef* filePath, CFURLPathStyle pathStyle, byte isDirectory);

		// extern CFURLRef CFURLCreateFromFileSystemRepresentation (CFAllocatorRef allocator, const UInt8 *buffer, CFIndex bufLen, Boolean isDirectory) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateFromFileSystemRepresentation (CFAllocatorRef* allocator, byte* buffer, nint bufLen, byte isDirectory);

		// extern CFURLRef CFURLCreateWithFileSystemPathRelativeToBase (CFAllocatorRef allocator, CFStringRef filePath, CFURLPathStyle pathStyle, Boolean isDirectory, CFURLRef baseURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateWithFileSystemPathRelativeToBase (CFAllocatorRef* allocator, CFStringRef* filePath, CFURLPathStyle pathStyle, byte isDirectory, CFURLRef* baseURL);

		// extern CFURLRef CFURLCreateFromFileSystemRepresentationRelativeToBase (CFAllocatorRef allocator, const UInt8 *buffer, CFIndex bufLen, Boolean isDirectory, CFURLRef baseURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateFromFileSystemRepresentationRelativeToBase (CFAllocatorRef* allocator, byte* buffer, nint bufLen, byte isDirectory, CFURLRef* baseURL);

		// extern Boolean CFURLGetFileSystemRepresentation (CFURLRef url, Boolean resolveAgainstBase, UInt8 *buffer, CFIndex maxBufLen) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLGetFileSystemRepresentation (CFURLRef* url, byte resolveAgainstBase, byte* buffer, nint maxBufLen);

		// extern CFURLRef CFURLCopyAbsoluteURL (CFURLRef relativeURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCopyAbsoluteURL (CFURLRef* relativeURL);

		// extern CFStringRef CFURLGetString (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLGetString (CFURLRef* anURL);

		// extern CFURLRef CFURLGetBaseURL (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLGetBaseURL (CFURLRef* anURL);

		// extern Boolean CFURLCanBeDecomposed (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLCanBeDecomposed (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyScheme (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyScheme (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyNetLocation (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyNetLocation (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyPath (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyPath (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyStrictPath (CFURLRef anURL, Boolean *isAbsolute) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyStrictPath (CFURLRef* anURL, byte* isAbsolute);

		// extern CFStringRef CFURLCopyFileSystemPath (CFURLRef anURL, CFURLPathStyle pathStyle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyFileSystemPath (CFURLRef* anURL, CFURLPathStyle pathStyle);

		// extern Boolean CFURLHasDirectoryPath (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLHasDirectoryPath (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyResourceSpecifier (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyResourceSpecifier (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyHostName (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyHostName (CFURLRef* anURL);

		// extern SInt32 CFURLGetPortNumber (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe int CFURLGetPortNumber (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyUserName (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyUserName (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyPassword (CFURLRef anURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyPassword (CFURLRef* anURL);

		// extern CFStringRef CFURLCopyParameterString (CFURLRef anURL, CFStringRef charactersToLeaveEscaped) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=2.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Deprecated (PlatformName.WatchOS, 6, 0, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "The CFURLCopyParameterString function is deprecated. Post deprecation for applications linked with or after the macOS 10.15, and for all iOS, watchOS, and tvOS applications, CFURLCopyParameterString will always return NULL, and the CFURLCopyPath(), CFURLCopyStrictPath(), and CFURLCopyFileSystemPath() functions will return the complete path including the semicolon separator and params component if the URL string contains them.")]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyParameterString (CFURLRef* anURL, CFStringRef* charactersToLeaveEscaped);

		// extern CFStringRef CFURLCopyQueryString (CFURLRef anURL, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyQueryString (CFURLRef* anURL, CFStringRef* charactersToLeaveEscaped);

		// extern CFStringRef CFURLCopyFragment (CFURLRef anURL, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyFragment (CFURLRef* anURL, CFStringRef* charactersToLeaveEscaped);

		// extern CFStringRef CFURLCopyLastPathComponent (CFURLRef url) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyLastPathComponent (CFURLRef* url);

		// extern CFStringRef CFURLCopyPathExtension (CFURLRef url) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCopyPathExtension (CFURLRef* url);

		// extern CFURLRef CFURLCreateCopyAppendingPathComponent (CFAllocatorRef allocator, CFURLRef url, CFStringRef pathComponent, Boolean isDirectory) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateCopyAppendingPathComponent (CFAllocatorRef* allocator, CFURLRef* url, CFStringRef* pathComponent, byte isDirectory);

		// extern CFURLRef CFURLCreateCopyDeletingLastPathComponent (CFAllocatorRef allocator, CFURLRef url) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateCopyDeletingLastPathComponent (CFAllocatorRef* allocator, CFURLRef* url);

		// extern CFURLRef CFURLCreateCopyAppendingPathExtension (CFAllocatorRef allocator, CFURLRef url, CFStringRef extension) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateCopyAppendingPathExtension (CFAllocatorRef* allocator, CFURLRef* url, CFStringRef* extension);

		// extern CFURLRef CFURLCreateCopyDeletingPathExtension (CFAllocatorRef allocator, CFURLRef url) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateCopyDeletingPathExtension (CFAllocatorRef* allocator, CFURLRef* url);

		// extern CFIndex CFURLGetBytes (CFURLRef url, UInt8 *buffer, CFIndex bufferLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFURLGetBytes (CFURLRef* url, byte* buffer, nint bufferLength);

		// extern CFRange CFURLGetByteRangeForComponent (CFURLRef url, CFURLComponentType component, CFRange *rangeIncludingSeparators) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFURLGetByteRangeForComponent (CFURLRef* url, CFURLComponentType component, CFRange* rangeIncludingSeparators);

		// extern CFStringRef CFURLCreateStringByReplacingPercentEscapes (CFAllocatorRef allocator, CFStringRef originalString, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCreateStringByReplacingPercentEscapes (CFAllocatorRef* allocator, CFStringRef* originalString, CFStringRef* charactersToLeaveEscaped);

		// extern CFStringRef CFURLCreateStringByReplacingPercentEscapesUsingEncoding (CFAllocatorRef allocator, CFStringRef origString, CFStringRef charsToLeaveEscaped, CFStringEncoding encoding) __attribute__((availability(macos, introduced=10.0, deprecated=10.11))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCreateStringByReplacingPercentEscapesUsingEncoding (CFAllocatorRef* allocator, CFStringRef* origString, CFStringRef* charsToLeaveEscaped, uint encoding);

		// extern CFStringRef CFURLCreateStringByAddingPercentEscapes (CFAllocatorRef allocator, CFStringRef originalString, CFStringRef charactersToLeaveUnescaped, CFStringRef legalURLCharactersToBeEscaped, CFStringEncoding encoding) __attribute__((availability(macos, introduced=10.0, deprecated=10.11))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFURLCreateStringByAddingPercentEscapes (CFAllocatorRef* allocator, CFStringRef* originalString, CFStringRef* charactersToLeaveUnescaped, CFStringRef* legalURLCharactersToBeEscaped, uint encoding);

		// extern Boolean CFURLIsFileReferenceURL (CFURLRef url) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLIsFileReferenceURL (CFURLRef* url);

		// extern CFURLRef CFURLCreateFileReferenceURL (CFAllocatorRef allocator, CFURLRef url, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateFileReferenceURL (CFAllocatorRef* allocator, CFURLRef* url, CFErrorRef** error);

		// extern CFURLRef CFURLCreateFilePathURL (CFAllocatorRef allocator, CFURLRef url, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateFilePathURL (CFAllocatorRef* allocator, CFURLRef* url, CFErrorRef** error);

		// extern CFURLRef CFURLCreateFromFSRef (CFAllocatorRef allocator, const struct FSRef *fsRef) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Not supported")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Not supported")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateFromFSRef (CFAllocatorRef* allocator, FSRef* fsRef);

		// extern Boolean CFURLGetFSRef (CFURLRef url, struct FSRef *fsRef) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Not supported")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Not supported")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLGetFSRef (CFURLRef* url, FSRef* fsRef);

		// extern Boolean CFURLCopyResourcePropertyForKey (CFURLRef url, CFStringRef key, void *propertyValueTypeRefPtr, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLCopyResourcePropertyForKey (CFURLRef* url, CFStringRef* key, void* propertyValueTypeRefPtr, CFErrorRef** error);

		// extern CFDictionaryRef CFURLCopyResourcePropertiesForKeys (CFURLRef url, CFArrayRef keys, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFURLCopyResourcePropertiesForKeys (CFURLRef* url, CFArrayRef* keys, CFErrorRef** error);

		// extern Boolean CFURLSetResourcePropertyForKey (CFURLRef url, CFStringRef key, CFTypeRef propertyValue, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLSetResourcePropertyForKey (CFURLRef* url, CFStringRef* key, void* propertyValue, CFErrorRef** error);

		// extern Boolean CFURLSetResourcePropertiesForKeys (CFURLRef url, CFDictionaryRef keyedPropertyValues, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLSetResourcePropertiesForKeys (CFURLRef* url, CFDictionaryRef* keyedPropertyValues, CFErrorRef** error);

		// extern void CFURLClearResourcePropertyCacheForKey (CFURLRef url, CFStringRef key) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFURLClearResourcePropertyCacheForKey (CFURLRef* url, CFStringRef* key);

		// extern void CFURLClearResourcePropertyCache (CFURLRef url) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFURLClearResourcePropertyCache (CFURLRef* url);

		// extern void CFURLSetTemporaryResourcePropertyForKey (CFURLRef url, CFStringRef key, CFTypeRef propertyValue) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFURLSetTemporaryResourcePropertyForKey (CFURLRef* url, CFStringRef* key, void* propertyValue);

		// extern Boolean CFURLResourceIsReachable (CFURLRef url, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLResourceIsReachable (CFURLRef* url, CFErrorRef** error);

		// extern CFDataRef CFURLCreateBookmarkData (CFAllocatorRef allocator, CFURLRef url, CFURLBookmarkCreationOptions options, CFArrayRef resourcePropertiesToInclude, CFURLRef relativeToURL, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFURLCreateBookmarkData (CFAllocatorRef* allocator, CFURLRef* url, CFURLBookmarkCreationOptions options, CFArrayRef* resourcePropertiesToInclude, CFURLRef* relativeToURL, CFErrorRef** error);

		// extern CFURLRef CFURLCreateByResolvingBookmarkData (CFAllocatorRef allocator, CFDataRef bookmark, CFURLBookmarkResolutionOptions options, CFURLRef relativeToURL, CFArrayRef resourcePropertiesToInclude, Boolean *isStale, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFURLCreateByResolvingBookmarkData (CFAllocatorRef* allocator, CFDataRef* bookmark, CFURLBookmarkResolutionOptions options, CFURLRef* relativeToURL, CFArrayRef* resourcePropertiesToInclude, byte* isStale, CFErrorRef** error);

		// extern CFDictionaryRef CFURLCreateResourcePropertiesForKeysFromBookmarkData (CFAllocatorRef allocator, CFArrayRef resourcePropertiesToReturn, CFDataRef bookmark) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFURLCreateResourcePropertiesForKeysFromBookmarkData (CFAllocatorRef* allocator, CFArrayRef* resourcePropertiesToReturn, CFDataRef* bookmark);

		// extern CFTypeRef CFURLCreateResourcePropertyForKeyFromBookmarkData (CFAllocatorRef allocator, CFStringRef resourcePropertyKey, CFDataRef bookmark) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* CFURLCreateResourcePropertyForKeyFromBookmarkData (CFAllocatorRef* allocator, CFStringRef* resourcePropertyKey, CFDataRef* bookmark);

		// extern CFDataRef CFURLCreateBookmarkDataFromFile (CFAllocatorRef allocator, CFURLRef fileURL, CFErrorRef *errorRef) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFURLCreateBookmarkDataFromFile (CFAllocatorRef* allocator, CFURLRef* fileURL, CFErrorRef** errorRef);

		// extern Boolean CFURLWriteBookmarkDataToFile (CFDataRef bookmarkRef, CFURLRef fileURL, CFURLBookmarkFileCreationOptions options, CFErrorRef *errorRef) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLWriteBookmarkDataToFile (CFDataRef* bookmarkRef, CFURLRef* fileURL, nuint options, CFErrorRef** errorRef);

		// extern CFDataRef CFURLCreateBookmarkDataFromAliasRecord (CFAllocatorRef allocatorRef, CFDataRef aliasRecordDataRef) __attribute__((availability(macos, introduced=10.6, deprecated=11.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "The Carbon Alias Manager is deprecated. This function should only be used to convert Carbon AliasRecords to bookmark data.")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "The Carbon Alias Manager is deprecated. This function should only be used to convert Carbon AliasRecords to bookmark data.")]
		[NoWatch, NoTV, NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFURLCreateBookmarkDataFromAliasRecord (CFAllocatorRef* allocatorRef, CFDataRef* aliasRecordDataRef);

		// extern Boolean CFURLStartAccessingSecurityScopedResource (CFURLRef url) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLStartAccessingSecurityScopedResource (CFURLRef* url);

		// extern void CFURLStopAccessingSecurityScopedResource (CFURLRef url) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFURLStopAccessingSecurityScopedResource (CFURLRef* url);

		// extern CFTypeID CFRunLoopGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFRunLoopGetTypeID ();

		// extern CFRunLoopRef CFRunLoopGetCurrent () __attribute__((swift_attr("@_unavailableFromAsync(message: "CFRunLoopGetCurrent cannot be used from async contexts.")"))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern CFRunLoop CFRunLoopGetCurrent ();

		// extern CFRunLoopRef CFRunLoopGetMain () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern CFRunLoop CFRunLoopGetMain ();

		// extern CFRunLoopMode CFRunLoopCopyCurrentMode (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopMode* CFRunLoopCopyCurrentMode (CFRunLoop rl);

		// extern CFArrayRef CFRunLoopCopyAllModes (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFRunLoopCopyAllModes (CFRunLoop rl);

		// extern void CFRunLoopAddCommonMode (CFRunLoopRef rl, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopAddCommonMode (CFRunLoop rl, CFRunLoopMode* mode);

		// extern CFAbsoluteTime CFRunLoopGetNextTimerFireDate (CFRunLoopRef rl, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFRunLoopGetNextTimerFireDate (CFRunLoop rl, CFRunLoopMode* mode);

		// extern void CFRunLoopRun () __attribute__((swift_attr("@_unavailableFromAsync(message: "CFRunLoopRun cannot be used from async contexts.")"))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern void CFRunLoopRun ();

		// extern CFRunLoopRunResult CFRunLoopRunInMode (CFRunLoopMode mode, CFTimeInterval seconds, Boolean returnAfterSourceHandled) __attribute__((swift_attr("@_unavailableFromAsync(message: "CFRunLoopRunInMode cannot be used from async contexts.")"))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopRunResult CFRunLoopRunInMode (CFRunLoopMode* mode, double seconds, byte returnAfterSourceHandled);

		// extern Boolean CFRunLoopIsWaiting (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern byte CFRunLoopIsWaiting (CFRunLoop rl);

		// extern void CFRunLoopWakeUp (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern void CFRunLoopWakeUp (CFRunLoop rl);

		// extern void CFRunLoopStop (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern void CFRunLoopStop (CFRunLoop rl);

		// extern void CFRunLoopPerformBlock (CFRunLoopRef rl, CFTypeRef mode, void (^block)()) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopPerformBlock (CFRunLoop rl, void* mode, Action block);

		// extern Boolean CFRunLoopContainsSource (CFRunLoopRef rl, CFRunLoopSourceRef source, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopContainsSource (CFRunLoop rl, CFRunLoopSourceRef* source, CFRunLoopMode* mode);

		// extern void CFRunLoopAddSource (CFRunLoopRef rl, CFRunLoopSourceRef source, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopAddSource (CFRunLoop rl, CFRunLoopSourceRef* source, CFRunLoopMode* mode);

		// extern void CFRunLoopRemoveSource (CFRunLoopRef rl, CFRunLoopSourceRef source, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopRemoveSource (CFRunLoop rl, CFRunLoopSourceRef* source, CFRunLoopMode* mode);

		// extern Boolean CFRunLoopContainsObserver (CFRunLoopRef rl, CFRunLoopObserverRef observer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopContainsObserver (CFRunLoop rl, CFRunLoopObserverRef* observer, CFRunLoopMode* mode);

		// extern void CFRunLoopAddObserver (CFRunLoopRef rl, CFRunLoopObserverRef observer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopAddObserver (CFRunLoop rl, CFRunLoopObserverRef* observer, CFRunLoopMode* mode);

		// extern void CFRunLoopRemoveObserver (CFRunLoopRef rl, CFRunLoopObserverRef observer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopRemoveObserver (CFRunLoop rl, CFRunLoopObserverRef* observer, CFRunLoopMode* mode);

		// extern Boolean CFRunLoopContainsTimer (CFRunLoopRef rl, CFRunLoopTimerRef timer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopContainsTimer (CFRunLoop rl, CFRunLoopTimerRef* timer, CFRunLoopMode* mode);

		// extern void CFRunLoopAddTimer (CFRunLoopRef rl, CFRunLoopTimerRef timer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopAddTimer (CFRunLoop rl, CFRunLoopTimerRef* timer, CFRunLoopMode* mode);

		// extern void CFRunLoopRemoveTimer (CFRunLoopRef rl, CFRunLoopTimerRef timer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopRemoveTimer (CFRunLoop rl, CFRunLoopTimerRef* timer, CFRunLoopMode* mode);

		// extern CFTypeID CFRunLoopSourceGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFRunLoopSourceGetTypeID ();

		// extern CFRunLoopSourceRef CFRunLoopSourceCreate (CFAllocatorRef allocator, CFIndex order, CFRunLoopSourceContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFRunLoopSourceCreate (CFAllocatorRef* allocator, nint order, CFRunLoopSourceContext* context);

		// extern CFIndex CFRunLoopSourceGetOrder (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFRunLoopSourceGetOrder (CFRunLoopSourceRef* source);

		// extern void CFRunLoopSourceInvalidate (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopSourceInvalidate (CFRunLoopSourceRef* source);

		// extern Boolean CFRunLoopSourceIsValid (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopSourceIsValid (CFRunLoopSourceRef* source);

		// extern void CFRunLoopSourceGetContext (CFRunLoopSourceRef source, CFRunLoopSourceContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopSourceGetContext (CFRunLoopSourceRef* source, CFRunLoopSourceContext* context);

		// extern void CFRunLoopSourceSignal (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopSourceSignal (CFRunLoopSourceRef* source);

		// extern CFTypeID CFRunLoopObserverGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFRunLoopObserverGetTypeID ();

		// extern CFRunLoopObserverRef CFRunLoopObserverCreate (CFAllocatorRef allocator, CFOptionFlags activities, Boolean repeats, CFIndex order, CFRunLoopObserverCallBack callout, CFRunLoopObserverContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopObserverRef* CFRunLoopObserverCreate (CFAllocatorRef* allocator, nuint activities, byte repeats, nint order, CFRunLoopObserverCallBack* callout, CFRunLoopObserverContext* context);

		// extern CFRunLoopObserverRef CFRunLoopObserverCreateWithHandler (CFAllocatorRef allocator, CFOptionFlags activities, Boolean repeats, CFIndex order, void (^block)(CFRunLoopObserverRef, CFRunLoopActivity)) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopObserverRef* CFRunLoopObserverCreateWithHandler (CFAllocatorRef* allocator, nuint activities, byte repeats, nint order, Action<CoreFoundation.CFRunLoopObserverRef*, CFRunLoopActivity> block);

		// extern CFOptionFlags CFRunLoopObserverGetActivities (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nuint CFRunLoopObserverGetActivities (CFRunLoopObserverRef* observer);

		// extern Boolean CFRunLoopObserverDoesRepeat (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopObserverDoesRepeat (CFRunLoopObserverRef* observer);

		// extern CFIndex CFRunLoopObserverGetOrder (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFRunLoopObserverGetOrder (CFRunLoopObserverRef* observer);

		// extern void CFRunLoopObserverInvalidate (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopObserverInvalidate (CFRunLoopObserverRef* observer);

		// extern Boolean CFRunLoopObserverIsValid (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopObserverIsValid (CFRunLoopObserverRef* observer);

		// extern void CFRunLoopObserverGetContext (CFRunLoopObserverRef observer, CFRunLoopObserverContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopObserverGetContext (CFRunLoopObserverRef* observer, CFRunLoopObserverContext* context);

		// extern CFTypeID CFRunLoopTimerGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFRunLoopTimerGetTypeID ();

		// extern CFRunLoopTimerRef CFRunLoopTimerCreate (CFAllocatorRef allocator, CFAbsoluteTime fireDate, CFTimeInterval interval, CFOptionFlags flags, CFIndex order, CFRunLoopTimerCallBack callout, CFRunLoopTimerContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopTimerRef* CFRunLoopTimerCreate (CFAllocatorRef* allocator, double fireDate, double interval, nuint flags, nint order, CFRunLoopTimerCallBack* callout, CFRunLoopTimerContext* context);

		// extern CFRunLoopTimerRef CFRunLoopTimerCreateWithHandler (CFAllocatorRef allocator, CFAbsoluteTime fireDate, CFTimeInterval interval, CFOptionFlags flags, CFIndex order, void (^block)(CFRunLoopTimerRef)) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopTimerRef* CFRunLoopTimerCreateWithHandler (CFAllocatorRef* allocator, double fireDate, double interval, nuint flags, nint order, Action<CoreFoundation.CFRunLoopTimerRef*> block);

		// extern CFAbsoluteTime CFRunLoopTimerGetNextFireDate (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFRunLoopTimerGetNextFireDate (CFRunLoopTimerRef* timer);

		// extern void CFRunLoopTimerSetNextFireDate (CFRunLoopTimerRef timer, CFAbsoluteTime fireDate) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopTimerSetNextFireDate (CFRunLoopTimerRef* timer, double fireDate);

		// extern CFTimeInterval CFRunLoopTimerGetInterval (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe double CFRunLoopTimerGetInterval (CFRunLoopTimerRef* timer);

		// extern Boolean CFRunLoopTimerDoesRepeat (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopTimerDoesRepeat (CFRunLoopTimerRef* timer);

		// extern CFIndex CFRunLoopTimerGetOrder (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFRunLoopTimerGetOrder (CFRunLoopTimerRef* timer);

		// extern void CFRunLoopTimerInvalidate (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopTimerInvalidate (CFRunLoopTimerRef* timer);

		// extern Boolean CFRunLoopTimerIsValid (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFRunLoopTimerIsValid (CFRunLoopTimerRef* timer);

		// extern void CFRunLoopTimerGetContext (CFRunLoopTimerRef timer, CFRunLoopTimerContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopTimerGetContext (CFRunLoopTimerRef* timer, CFRunLoopTimerContext* context);

		// extern CFTimeInterval CFRunLoopTimerGetTolerance (CFRunLoopTimerRef timer) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe double CFRunLoopTimerGetTolerance (CFRunLoopTimerRef* timer);

		// extern void CFRunLoopTimerSetTolerance (CFRunLoopTimerRef timer, CFTimeInterval tolerance) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFRunLoopTimerSetTolerance (CFRunLoopTimerRef* timer, double tolerance);

		// extern CFTypeID CFSocketGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFSocketGetTypeID ();

		// extern CFSocketRef CFSocketCreate (CFAllocatorRef allocator, SInt32 protocolFamily, SInt32 socketType, SInt32 protocol, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketRef* CFSocketCreate (CFAllocatorRef* allocator, int protocolFamily, int socketType, int protocol, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context);

		// extern CFSocketRef CFSocketCreateWithNative (CFAllocatorRef allocator, CFSocketNativeHandle sock, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketRef* CFSocketCreateWithNative (CFAllocatorRef* allocator, int sock, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context);

		// extern CFSocketRef CFSocketCreateWithSocketSignature (CFAllocatorRef allocator, const CFSocketSignature *signature, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketRef* CFSocketCreateWithSocketSignature (CFAllocatorRef* allocator, CFSocketSignature* signature, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context);

		// extern CFSocketRef CFSocketCreateConnectedToSocketSignature (CFAllocatorRef allocator, const CFSocketSignature *signature, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context, CFTimeInterval timeout) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketRef* CFSocketCreateConnectedToSocketSignature (CFAllocatorRef* allocator, CFSocketSignature* signature, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context, double timeout);

		// extern CFSocketError CFSocketSetAddress (CFSocketRef s, CFDataRef address) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketSetAddress (CFSocketRef* s, CFDataRef* address);

		// extern CFSocketError CFSocketConnectToAddress (CFSocketRef s, CFDataRef address, CFTimeInterval timeout) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketConnectToAddress (CFSocketRef* s, CFDataRef* address, double timeout);

		// extern void CFSocketInvalidate (CFSocketRef s) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSocketInvalidate (CFSocketRef* s);

		// extern Boolean CFSocketIsValid (CFSocketRef s) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFSocketIsValid (CFSocketRef* s);

		// extern CFDataRef CFSocketCopyAddress (CFSocketRef s) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFSocketCopyAddress (CFSocketRef* s);

		// extern CFDataRef CFSocketCopyPeerAddress (CFSocketRef s) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFSocketCopyPeerAddress (CFSocketRef* s);

		// extern void CFSocketGetContext (CFSocketRef s, CFSocketContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSocketGetContext (CFSocketRef* s, CFSocketContext* context);

		// extern CFSocketNativeHandle CFSocketGetNative (CFSocketRef s) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe int CFSocketGetNative (CFSocketRef* s);

		// extern CFRunLoopSourceRef CFSocketCreateRunLoopSource (CFAllocatorRef allocator, CFSocketRef s, CFIndex order) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFSocketCreateRunLoopSource (CFAllocatorRef* allocator, CFSocketRef* s, nint order);

		// extern CFOptionFlags CFSocketGetSocketFlags (CFSocketRef s) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nuint CFSocketGetSocketFlags (CFSocketRef* s);

		// extern void CFSocketSetSocketFlags (CFSocketRef s, CFOptionFlags flags) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSocketSetSocketFlags (CFSocketRef* s, nuint flags);

		// extern void CFSocketDisableCallBacks (CFSocketRef s, CFOptionFlags callBackTypes) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSocketDisableCallBacks (CFSocketRef* s, nuint callBackTypes);

		// extern void CFSocketEnableCallBacks (CFSocketRef s, CFOptionFlags callBackTypes) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSocketEnableCallBacks (CFSocketRef* s, nuint callBackTypes);

		// extern CFSocketError CFSocketSendData (CFSocketRef s, CFDataRef address, CFDataRef data, CFTimeInterval timeout) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketSendData (CFSocketRef* s, CFDataRef* address, CFDataRef* data, double timeout);

		// extern CFSocketError CFSocketRegisterValue (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, CFPropertyListRef value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketRegisterValue (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, void* value);

		// extern CFSocketError CFSocketCopyRegisteredValue (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, CFPropertyListRef *value, CFDataRef *nameServerAddress) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketCopyRegisteredValue (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, void** value, CFDataRef** nameServerAddress);

		// extern CFSocketError CFSocketRegisterSocketSignature (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, const CFSocketSignature *signature) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketRegisterSocketSignature (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, CFSocketSignature* signature);

		// extern CFSocketError CFSocketCopyRegisteredSocketSignature (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, CFSocketSignature *signature, CFDataRef *nameServerAddress) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketCopyRegisteredSocketSignature (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, CFSocketSignature* signature, CFDataRef** nameServerAddress);

		// extern CFSocketError CFSocketUnregister (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSocketError CFSocketUnregister (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name);

		// extern void CFSocketSetDefaultNameRegistryPortNumber (UInt16 port) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern void CFSocketSetDefaultNameRegistryPortNumber (ushort port);

		// extern UInt16 CFSocketGetDefaultNameRegistryPortNumber () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern ushort CFSocketGetDefaultNameRegistryPortNumber ();

		// extern int getattrlistbulk (int, void *, void *, size_t, uint64_t) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int getattrlistbulk (int, void*, void*, nuint, ulong);

		// extern int getattrlistat (int, const char *, void *, void *, size_t, unsigned long) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int getattrlistat (int, sbyte*, void*, void*, nuint, nuint);

		// extern int setattrlistat (int, const char *, void *, void *, size_t, uint32_t) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe int setattrlistat (int, sbyte*, void*, void*, nuint, uint);

		// extern ssize_t freadlink (int, char *__restrict, size_t) __attribute__((availability(macos, introduced=13.0))) __attribute__((availability(ios, introduced=16.0))) __attribute__((availability(tvos, introduced=16.0))) __attribute__((availability(watchos, introduced=9.0)));
		[Watch (9,0), TV (16,0), Mac (13,0), iOS (16,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint freadlink (int, sbyte*, nuint);

		// extern int faccessat (int, const char *, int, int) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int faccessat (int, sbyte*, int, int);

		// extern int fchownat (int, const char *, uid_t, gid_t, int) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int fchownat (int, sbyte*, uint, uint, int);

		// extern int linkat (int, const char *, int, const char *, int) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int linkat (int, sbyte*, int, sbyte*, int);

		// extern ssize_t readlinkat (int, const char *, char *, size_t) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint readlinkat (int, sbyte*, sbyte*, nuint);

		// extern int symlinkat (const char *, int, const char *) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int symlinkat (sbyte*, int, sbyte*);

		// extern int unlinkat (int, const char *, int) __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int unlinkat (int, sbyte*, int);

		// extern void _exit (int) ;
		[DllImport ("__Internal")]
		static extern void _exit (int);

		// extern void _exit (int) ;
		[DllImport ("__Internal")]
		static extern void _exit (int);

		// extern int access (const char *, int);
		[DllImport ("__Internal")]
		static extern unsafe int access (sbyte*, int);

		// extern unsigned int alarm (unsigned int);
		[DllImport ("__Internal")]
		static extern uint alarm (uint);

		// extern int chdir (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int chdir (sbyte*);

		// extern int chown (const char *, uid_t, gid_t);
		[DllImport ("__Internal")]
		static extern unsafe int chown (sbyte*, uint, uint);

		// extern int close (int) asm("_close");
		[DllImport ("__Internal")]
		static extern int close (int);

		// extern int dup (int);
		[DllImport ("__Internal")]
		static extern int dup (int);

		// extern int dup2 (int, int);
		[DllImport ("__Internal")]
		static extern int dup2 (int, int);

		// extern int execl (const char *__path, const char *__arg0, ...) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execl (sbyte* __path, sbyte* __arg0, IntPtr varArgs);

		// extern int execle (const char *__path, const char *__arg0, ...) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execle (sbyte* __path, sbyte* __arg0, IntPtr varArgs);

		// extern int execlp (const char *__file, const char *__arg0, ...) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execlp (sbyte* __file, sbyte* __arg0, IntPtr varArgs);

		// extern int execv (const char *__path, char *const *__argv) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execv (sbyte* __path, sbyte** __argv);

		// extern int execve (const char *__file, char *const *__argv, char *const *__envp) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execve (sbyte* __file, sbyte** __argv, sbyte** __envp);

		// extern int execvp (const char *__file, char *const *__argv) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execvp (sbyte* __file, sbyte** __argv);

		// extern pid_t fork () __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern int fork ();

		// extern long fpathconf (int, int);
		[DllImport ("__Internal")]
		static extern nint fpathconf (int, int);

		// extern char * getcwd (char *, size_t);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getcwd (sbyte*, nuint);

		// extern gid_t getegid ();
		[DllImport ("__Internal")]
		static extern uint getegid ();

		// extern uid_t geteuid ();
		[DllImport ("__Internal")]
		static extern uint geteuid ();

		// extern gid_t getgid ();
		[DllImport ("__Internal")]
		static extern uint getgid ();

		// extern int getgroups (int, gid_t *);
		[DllImport ("__Internal")]
		static extern int getgroups (int, uint[]);

		// extern char * getlogin ();
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getlogin ();

		// extern pid_t getpgrp ();
		[DllImport ("__Internal")]
		static extern int getpgrp ();

		// extern pid_t getpid ();
		[DllImport ("__Internal")]
		static extern int getpid ();

		// extern pid_t getppid ();
		[DllImport ("__Internal")]
		static extern int getppid ();

		// extern uid_t getuid ();
		[DllImport ("__Internal")]
		static extern uint getuid ();

		// extern int isatty (int);
		[DllImport ("__Internal")]
		static extern int isatty (int);

		// extern int link (const char *, const char *);
		[DllImport ("__Internal")]
		static extern unsafe int link (sbyte*, sbyte*);

		// extern off_t lseek (int, off_t, int);
		[DllImport ("__Internal")]
		static extern long lseek (int, long, int);

		// extern long pathconf (const char *, int);
		[DllImport ("__Internal")]
		static extern unsafe nint pathconf (sbyte*, int);

		// extern int pause () asm("_pause");
		[DllImport ("__Internal")]
		static extern int pause ();

		// extern int pipe (int *);
		[DllImport ("__Internal")]
		static extern int pipe (int[]);

		// extern ssize_t read (int, void *, size_t) asm("_read");
		[DllImport ("__Internal")]
		static extern unsafe nint read (int, void*, nuint);

		// extern int rmdir (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int rmdir (sbyte*);

		// extern int setgid (gid_t);
		[DllImport ("__Internal")]
		static extern int setgid (uint);

		// extern int setpgid (pid_t, pid_t);
		[DllImport ("__Internal")]
		static extern int setpgid (int, int);

		// extern pid_t setsid ();
		[DllImport ("__Internal")]
		static extern int setsid ();

		// extern int setuid (uid_t);
		[DllImport ("__Internal")]
		static extern int setuid (uint);

		// extern unsigned int sleep (unsigned int) asm("_sleep");
		[DllImport ("__Internal")]
		static extern uint sleep (uint);

		// extern long sysconf (int);
		[DllImport ("__Internal")]
		static extern nint sysconf (int);

		// extern pid_t tcgetpgrp (int);
		[DllImport ("__Internal")]
		static extern int tcgetpgrp (int);

		// extern int tcsetpgrp (int, pid_t);
		[DllImport ("__Internal")]
		static extern int tcsetpgrp (int, int);

		// extern char * ttyname (int);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* ttyname (int);

		// extern int ttyname_r (int, char *, size_t) asm("_ttyname_r");
		[DllImport ("__Internal")]
		static extern unsafe int ttyname_r (int, sbyte*, nuint);

		// extern int unlink (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int unlink (sbyte*);

		// extern ssize_t write (int __fd, const void *__buf, size_t __nbyte) asm("_write");
		[DllImport ("__Internal")]
		static extern unsafe nint write (int __fd, void* __buf, nuint __nbyte);

		// extern size_t confstr (int, char *, size_t) asm("_confstr");
		[DllImport ("__Internal")]
		static extern unsafe nuint confstr (int, sbyte*, nuint);

		// extern int getopt (int, char *const *, const char *) asm("_getopt");
		[DllImport ("__Internal")]
		static extern unsafe int getopt (int, sbyte*[], sbyte*);

		// extern void * brk (const void *) __attribute__((deprecated(""))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe void* brk (void*);

		// extern int chroot (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int chroot (sbyte*);

		// extern char * crypt (const char *, const char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* crypt (sbyte*, sbyte*);

		// extern void encrypt (char *, int) asm("_encrypt");
		[DllImport ("__Internal")]
		static extern unsafe void encrypt (sbyte*, int);

		// extern int fchdir (int);
		[DllImport ("__Internal")]
		static extern int fchdir (int);

		// extern long gethostid ();
		[DllImport ("__Internal")]
		static extern nint gethostid ();

		// extern pid_t getpgid (pid_t);
		[DllImport ("__Internal")]
		static extern int getpgid (int);

		// extern pid_t getsid (pid_t);
		[DllImport ("__Internal")]
		static extern int getsid (int);

		// extern int getdtablesize ();
		[DllImport ("__Internal")]
		static extern int getdtablesize ();

		// extern int getpagesize () __attribute__((const));
		[DllImport ("__Internal")]
		static extern int getpagesize ();

		// extern char * getpass (const char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getpass (sbyte*);

		// extern char * getwd (char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getwd (sbyte*);

		// extern int lchown (const char *, uid_t, gid_t) asm("_lchown");
		[DllImport ("__Internal")]
		static extern unsafe int lchown (sbyte*, uint, uint);

		// extern int lockf (int, int, off_t) asm("_lockf");
		[DllImport ("__Internal")]
		static extern int lockf (int, int, long);

		// extern int nice (int) asm("_nice");
		[DllImport ("__Internal")]
		static extern int nice (int);

		// extern ssize_t pread (int __fd, void *__buf, size_t __nbyte, off_t __offset) asm("_pread");
		[DllImport ("__Internal")]
		static extern unsafe nint pread (int __fd, void* __buf, nuint __nbyte, long __offset);

		// extern ssize_t pwrite (int __fd, const void *__buf, size_t __nbyte, off_t __offset) asm("_pwrite");
		[DllImport ("__Internal")]
		static extern unsafe nint pwrite (int __fd, void* __buf, nuint __nbyte, long __offset);

		// extern void * sbrk (int) __attribute__((deprecated(""))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe void* sbrk (int);

		// extern pid_t setpgrp () asm("_setpgrp");
		[DllImport ("__Internal")]
		static extern int setpgrp ();

		// extern int setregid (gid_t, gid_t) asm("_setregid");
		[DllImport ("__Internal")]
		static extern int setregid (uint, uint);

		// extern int setreuid (uid_t, uid_t) asm("_setreuid");
		[DllImport ("__Internal")]
		static extern int setreuid (uint, uint);

		// extern void swab (const void *__restrict, void *__restrict, ssize_t);
		[DllImport ("__Internal")]
		static extern unsafe void swab (void*, void*, nint);

		// extern void sync ();
		[DllImport ("__Internal")]
		static extern void sync ();

		// extern int truncate (const char *, off_t);
		[DllImport ("__Internal")]
		static extern unsafe int truncate (sbyte*, long);

		// extern useconds_t ualarm (useconds_t, useconds_t);
		[DllImport ("__Internal")]
		static extern uint ualarm (uint, uint);

		// extern int usleep (useconds_t) asm("_usleep");
		[DllImport ("__Internal")]
		static extern int usleep (uint);

		// extern int vfork ()  __attribute__((returns_twice));
		[DllImport ("__Internal")]
		static extern int vfork ();

		// extern int vfork ()  __attribute__((returns_twice)) __attribute__((deprecated("Use posix_spawn or fork"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern int vfork ();

		// extern int fsync (int) asm("_fsync");
		[DllImport ("__Internal")]
		static extern int fsync (int);

		// extern int ftruncate (int, off_t);
		[DllImport ("__Internal")]
		static extern int ftruncate (int, long);

		// extern int getlogin_r (char *, size_t);
		[DllImport ("__Internal")]
		static extern unsafe int getlogin_r (sbyte*, nuint);

		// extern int fchown (int, uid_t, gid_t);
		[DllImport ("__Internal")]
		static extern int fchown (int, uint, uint);

		// extern int gethostname (char *, size_t);
		[DllImport ("__Internal")]
		static extern unsafe int gethostname (sbyte*, nuint);

		// extern ssize_t readlink (const char *__restrict, char *__restrict, size_t);
		[DllImport ("__Internal")]
		static extern unsafe nint readlink (sbyte*, sbyte*, nuint);

		// extern int setegid (gid_t);
		[DllImport ("__Internal")]
		static extern int setegid (uint);

		// extern int seteuid (uid_t);
		[DllImport ("__Internal")]
		static extern int seteuid (uint);

		// extern int symlink (const char *, const char *);
		[DllImport ("__Internal")]
		static extern unsafe int symlink (sbyte*, sbyte*);

		// extern int pselect (int, fd_set *__restrict, fd_set *__restrict, fd_set *__restrict, const struct timespec *__restrict, const sigset_t *__restrict) asm("_pselect");
		[DllImport ("__Internal")]
		static extern unsafe int pselect (int, fd_set*, fd_set*, fd_set*, timespec*, uint*);

		// extern int select (int, fd_set *__restrict, fd_set *__restrict, fd_set *__restrict, struct timeval *__restrict) asm("_select");
		[DllImport ("__Internal")]
		static extern unsafe int select (int, fd_set*, fd_set*, fd_set*, timeval*);

		// extern void _Exit (int) ;
		[DllImport ("__Internal")]
		static extern void _Exit (int);

		// extern int accessx_np (const struct accessx_descriptor *, size_t, int *, uid_t);
		[DllImport ("__Internal")]
		static extern unsafe int accessx_np (accessx_descriptor*, nuint, int*, uint);

		// extern int acct (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int acct (sbyte*);

		// extern int add_profil (char *, size_t, unsigned long, unsigned int) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int add_profil (sbyte*, nuint, nuint, uint);

		// extern void endusershell ();
		[DllImport ("__Internal")]
		static extern void endusershell ();

		// extern int execvP (const char *__file, const char *__searchpath, char *const *__argv) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int execvP (sbyte* __file, sbyte* __searchpath, sbyte** __argv);

		// extern char * fflagstostr (unsigned long);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* fflagstostr (nuint);

		// extern int getdomainname (char *, int);
		[DllImport ("__Internal")]
		static extern unsafe int getdomainname (sbyte*, int);

		// extern int getgrouplist (const char *, int, int *, int *);
		[DllImport ("__Internal")]
		static extern unsafe int getgrouplist (sbyte*, int, int*, int*);

		// extern int gethostuuid (unsigned char *, const struct timespec *) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10,5)]
		[DllImport ("__Internal")]
		static extern unsafe int gethostuuid (byte[], timespec*);

		// extern mode_t getmode (const void *, mode_t);
		[DllImport ("__Internal")]
		static extern unsafe ushort getmode (void*, ushort);

		// extern int getpeereid (int, uid_t *, gid_t *);
		[DllImport ("__Internal")]
		static extern unsafe int getpeereid (int, uint*, uint*);

		// extern int getsgroups_np (int *, unsigned char *);
		[DllImport ("__Internal")]
		static extern unsafe int getsgroups_np (int*, byte[]);

		// extern char * getusershell ();
		[DllImport ("__Internal")]
		static extern unsafe sbyte* getusershell ();

		// extern int getwgroups_np (int *, unsigned char *);
		[DllImport ("__Internal")]
		static extern unsafe int getwgroups_np (int*, byte[]);

		// extern int initgroups (const char *, int);
		[DllImport ("__Internal")]
		static extern unsafe int initgroups (sbyte*, int);

		// extern int issetugid ();
		[DllImport ("__Internal")]
		static extern int issetugid ();

		// extern char * mkdtemp (char *);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* mkdtemp (sbyte*);

		// extern int mknod (const char *, mode_t, dev_t);
		[DllImport ("__Internal")]
		static extern unsafe int mknod (sbyte*, ushort, int);

		// extern int mkpath_np (const char *path, mode_t omode) __attribute__((availability(ios, introduced=5.0)));
		[iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkpath_np (sbyte* path, ushort omode);

		// extern int mkpathat_np (int dfd, const char *path, mode_t omode) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkpathat_np (int dfd, sbyte* path, ushort omode);

		// extern int mkstemp (char *);
		[DllImport ("__Internal")]
		static extern unsafe int mkstemp (sbyte*);

		// extern int mkstemps (char *, int);
		[DllImport ("__Internal")]
		static extern unsafe int mkstemps (sbyte*, int);

		// extern char * mktemp (char *) __attribute__((deprecated("This function is provided for compatibility reasons only.  Due to security concerns inherent in the design of mktemp(3), it is highly recommended that you use mkstemp(3) instead.")));
		[DllImport ("__Internal")]
		static extern unsafe sbyte* mktemp (sbyte*);

		// extern int mkostemp (char *path, int oflags) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkostemp (sbyte* path, int oflags);

		// extern int mkostemps (char *path, int slen, int oflags) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkostemps (sbyte* path, int slen, int oflags);

		// extern int mkstemp_dprotected_np (char *path, int dpclass, int dpflags) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3,0), TV (10,0), NoMac, iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkstemp_dprotected_np (sbyte* path, int dpclass, int dpflags);

		// extern char * mkdtempat_np (int dfd, char *path) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* mkdtempat_np (int dfd, sbyte* path);

		// extern int mkstempsat_np (int dfd, char *path, int slen) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkstempsat_np (int dfd, sbyte* path, int slen);

		// extern int mkostempsat_np (int dfd, char *path, int slen, int oflags) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe int mkostempsat_np (int dfd, sbyte* path, int slen, int oflags);

		// extern int nfssvc (int, void *);
		[DllImport ("__Internal")]
		static extern unsafe int nfssvc (int, void*);

		// extern int profil (char *, size_t, unsigned long, unsigned int);
		[DllImport ("__Internal")]
		static extern unsafe int profil (sbyte*, nuint, nuint, uint);

		// extern int pthread_setugid_np (uid_t, gid_t) __attribute__((deprecated("Use of per-thread security contexts is error-prone and discouraged.")));
		[DllImport ("__Internal")]
		static extern int pthread_setugid_np (uint, uint);

		// extern int pthread_getugid_np (uid_t *, gid_t *);
		[DllImport ("__Internal")]
		static extern unsafe int pthread_getugid_np (uint*, uint*);

		// extern int reboot (int);
		[DllImport ("__Internal")]
		static extern int reboot (int);

		// extern int revoke (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int revoke (sbyte*);

		// extern int rcmd (char **, int, const char *, const char *, const char *, int *) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int rcmd (sbyte**, int, sbyte*, sbyte*, sbyte*, int*);

		// extern int rcmd_af (char **, int, const char *, const char *, const char *, int *, int) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int rcmd_af (sbyte**, int, sbyte*, sbyte*, sbyte*, int*, int);

		// extern int rresvport (int *) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int rresvport (int*);

		// extern int rresvport_af (int *, int) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int rresvport_af (int*, int);

		// extern int iruserok (unsigned long, int, const char *, const char *) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int iruserok (nuint, int, sbyte*, sbyte*);

		// extern int iruserok_sa (const void *, int, int, const char *, const char *) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int iruserok_sa (void*, int, int, sbyte*, sbyte*);

		// extern int ruserok (const char *, int, const char *, const char *) __attribute__((deprecated("")));
		[DllImport ("__Internal")]
		static extern unsafe int ruserok (sbyte*, int, sbyte*, sbyte*);

		// extern int setdomainname (const char *, int);
		[DllImport ("__Internal")]
		static extern unsafe int setdomainname (sbyte*, int);

		// extern int setgroups (int, const gid_t *);
		[DllImport ("__Internal")]
		static extern unsafe int setgroups (int, uint*);

		// extern void sethostid (long);
		[DllImport ("__Internal")]
		static extern void sethostid (nint);

		// extern int sethostname (const char *, int);
		[DllImport ("__Internal")]
		static extern unsafe int sethostname (sbyte*, int);

		// extern void setkey (const char *) asm("_setkey");
		[DllImport ("__Internal")]
		static extern unsafe void setkey (sbyte*);

		// extern int setlogin (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int setlogin (sbyte*);

		// extern void * setmode (const char *) asm("_setmode");
		[DllImport ("__Internal")]
		static extern unsafe void* setmode (sbyte*);

		// extern int setrgid (gid_t);
		[DllImport ("__Internal")]
		static extern int setrgid (uint);

		// extern int setruid (uid_t);
		[DllImport ("__Internal")]
		static extern int setruid (uint);

		// extern int setsgroups_np (int, const unsigned char *);
		[DllImport ("__Internal")]
		static extern int setsgroups_np (int, byte[]);

		// extern void setusershell ();
		[DllImport ("__Internal")]
		static extern void setusershell ();

		// extern int setwgroups_np (int, const unsigned char *);
		[DllImport ("__Internal")]
		static extern int setwgroups_np (int, byte[]);

		// extern int strtofflags (char **, unsigned long *, unsigned long *);
		[DllImport ("__Internal")]
		static extern unsafe int strtofflags (sbyte**, nuint*, nuint*);

		// extern int swapon (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int swapon (sbyte*);

		// extern int ttyslot ();
		[DllImport ("__Internal")]
		static extern int ttyslot ();

		// extern int undelete (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int undelete (sbyte*);

		// extern int unwhiteout (const char *);
		[DllImport ("__Internal")]
		static extern unsafe int unwhiteout (sbyte*);

		// extern void * valloc (size_t) __attribute__((alloc_size(1)));
		[DllImport ("__Internal")]
		static extern unsafe void* valloc (nuint);

		// extern int syscall (int, ...) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, deprecated=10.0))) __attribute__((availability(macos, deprecated=10.12)));
		[Deprecated (PlatformName.iOS, 10, 0, message: "syscall(2) is unsupported; please switch to a supported interface. For SYS_kdebug_trace use kdebug_signpost().")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "syscall(2) is unsupported; please switch to a supported interface. For SYS_kdebug_trace use kdebug_signpost().")]
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern int syscall (int, IntPtr varArgs);

		// extern int getsubopt (char **, char *const *, char **);
		[DllImport ("__Internal")]
		static extern unsafe int getsubopt (sbyte**, sbyte**, sbyte**);

		// extern int fgetattrlist (int, void *, void *, size_t, unsigned int) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe int fgetattrlist (int, void*, void*, nuint, uint);

		// extern int fsetattrlist (int, void *, void *, size_t, unsigned int) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe int fsetattrlist (int, void*, void*, nuint, uint);

		// extern int getattrlist (const char *, void *, void *, size_t, unsigned int) asm("_getattrlist");
		[DllImport ("__Internal")]
		static extern unsafe int getattrlist (sbyte*, void*, void*, nuint, uint);

		// extern int setattrlist (const char *, void *, void *, size_t, unsigned int) asm("_setattrlist");
		[DllImport ("__Internal")]
		static extern unsafe int setattrlist (sbyte*, void*, void*, nuint, uint);

		// extern int exchangedata (const char *, const char *, unsigned int) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int exchangedata (sbyte*, sbyte*, uint);

		// extern int getdirentriesattr (int, void *, void *, size_t, unsigned int *, unsigned int *, unsigned int *, unsigned int) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int getdirentriesattr (int, void*, void*, nuint, uint*, uint*, uint*, uint);

		// extern int searchfs (const char *, struct fssearchblock *, unsigned long *, unsigned int, unsigned int, struct searchstate *) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int searchfs (sbyte*, fssearchblock*, nuint*, uint, uint, searchstate*);

		// extern int fsctl (const char *, unsigned long, void *, unsigned int);
		[DllImport ("__Internal")]
		static extern unsafe int fsctl (sbyte*, nuint, void*, uint);

		// extern int ffsctl (int, unsigned long, void *, unsigned int) __attribute__((availability(ios, introduced=3.0)));
		[iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe int ffsctl (int, nuint, void*, uint);

		// extern int fsync_volume_np (int, int) __attribute__((availability(ios, introduced=6.0)));
		[iOS (6,0)]
		[DllImport ("__Internal")]
		static extern int fsync_volume_np (int, int);

		// extern int sync_volume_np (const char *, int) __attribute__((availability(ios, introduced=6.0)));
		[iOS (6,0)]
		[DllImport ("__Internal")]
		static extern unsafe int sync_volume_np (sbyte*, int);

		// extern int open (const char *, int, ...) asm("_open");
		[DllImport ("__Internal")]
		static extern unsafe int open (sbyte*, int, IntPtr varArgs);

		// extern int openat (int, const char *, int, ...) asm("_openat") __attribute__((availability(ios, introduced=8.0)));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe int openat (int, sbyte*, int, IntPtr varArgs);

		// extern int creat (const char *, mode_t) asm("_creat");
		[DllImport ("__Internal")]
		static extern unsafe int creat (sbyte*, ushort);

		// extern int fcntl (int, int, ...) asm("_fcntl");
		[DllImport ("__Internal")]
		static extern int fcntl (int, int, IntPtr varArgs);

		// extern int openx_np (const char *, int, filesec_t);
		[DllImport ("__Internal")]
		static extern unsafe int openx_np (sbyte*, int, filesec_t*);

		// extern int open_dprotected_np (const char *, int, int, int, ...);
		[DllImport ("__Internal")]
		static extern unsafe int open_dprotected_np (sbyte*, int, int, int, IntPtr varArgs);

		// extern int openat_dprotected_np (int, const char *, int, int, int, ...);
		[DllImport ("__Internal")]
		static extern unsafe int openat_dprotected_np (int, sbyte*, int, int, int, IntPtr varArgs);

		// extern int openat_authenticated_np (int, const char *, int, int);
		[DllImport ("__Internal")]
		static extern unsafe int openat_authenticated_np (int, sbyte*, int, int);

		// extern int flock (int, int);
		[DllImport ("__Internal")]
		static extern int flock (int, int);

		// extern filesec_t filesec_init ();
		[DllImport ("__Internal")]
		static extern unsafe filesec_t* filesec_init ();

		// extern filesec_t filesec_dup (filesec_t);
		[DllImport ("__Internal")]
		static extern unsafe filesec_t* filesec_dup (filesec_t*);

		// extern void filesec_free (filesec_t);
		[DllImport ("__Internal")]
		static extern unsafe void filesec_free (filesec_t*);

		// extern int filesec_get_property (filesec_t, filesec_property_t, void *);
		[DllImport ("__Internal")]
		static extern unsafe int filesec_get_property (filesec_t*, filesec_property_t, void*);

		// extern int filesec_query_property (filesec_t, filesec_property_t, int *);
		[DllImport ("__Internal")]
		static extern unsafe int filesec_query_property (filesec_t*, filesec_property_t, int*);

		// extern int filesec_set_property (filesec_t, filesec_property_t, const void *);
		[DllImport ("__Internal")]
		static extern unsafe int filesec_set_property (filesec_t*, filesec_property_t, void*);

		// extern int filesec_unset_property (filesec_t, filesec_property_t) __attribute__((availability(ios, introduced=3.2)));
		[iOS (3,2)]
		[DllImport ("__Internal")]
		static extern unsafe int filesec_unset_property (filesec_t*, filesec_property_t);

		// extern const char * _Nonnull sel_getName (SEL _Nonnull sel) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* sel_getName (Selector sel);

		// extern SEL _Nonnull sel_registerName (const char * _Nonnull str) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe Selector sel_registerName (sbyte* str);

		// extern const char * _Nonnull object_getClassName (id _Nullable obj) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* object_getClassName ([NullAllowed] NSObject obj);

		// extern void * _Nullable object_getIndexedIvars (id _Nullable obj) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* object_getIndexedIvars ([NullAllowed] NSObject obj);

		// extern BOOL sel_isMapped (SEL _Nonnull sel) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern bool sel_isMapped (Selector sel);

		// extern SEL _Nonnull sel_getUid (const char * _Nonnull str) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=1.0)));
		[Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe Selector sel_getUid (sbyte* str);

		// extern void * os_retain (void *object) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* os_retain (void* @object);

		// extern void os_release (void *object) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe void os_release (void* @object);

		// extern int os_workgroup_copy_port (os_workgroup_t _Nonnull wg, mach_port_t * _Nonnull mach_port_out) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((warn_unused_result("")));
		[NoWatch, NoTV, NoiOS, Mac (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_copy_port (OS_os_workgroup wg, uint* mach_port_out);

		// extern os_workgroup_t _Nullable os_workgroup_create_with_port (const char * _Nullable name, mach_port_t mach_port) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((swift_name("WorkGroup.init(__name:port:)"))) __attribute__((visibility("default"))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[NoWatch, NoTV, NoiOS, Mac (11,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe OS_os_workgroup os_workgroup_create_with_port ([NullAllowed] sbyte* name, uint mach_port);

		// extern os_workgroup_t _Nullable os_workgroup_create_with_workgroup (const char * _Nullable name, os_workgroup_t _Nonnull wg) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe OS_os_workgroup os_workgroup_create_with_workgroup ([NullAllowed] sbyte* name, OS_os_workgroup wg);

		// extern int os_workgroup_join (os_workgroup_t _Nonnull wg, os_workgroup_join_token_t _Nonnull token_out) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((warn_unused_result("")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_join (OS_os_workgroup wg, os_workgroup_join_token_t* token_out);

		// extern void os_workgroup_leave (os_workgroup_t _Nonnull wg, os_workgroup_join_token_t _Nonnull token) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe void os_workgroup_leave (OS_os_workgroup wg, os_workgroup_join_token_t* token);

		// extern int os_workgroup_set_working_arena (os_workgroup_t _Nonnull wg, void * _Nullable arena, uint32_t max_workers, os_workgroup_working_arena_destructor_t _Nonnull destructor) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((warn_unused_result("")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_set_working_arena (OS_os_workgroup wg, [NullAllowed] void* arena, uint max_workers, os_workgroup_working_arena_destructor_t* destructor);

		// extern void * _Nullable os_workgroup_get_working_arena (os_workgroup_t _Nonnull wg, os_workgroup_index * _Nullable index_out) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* os_workgroup_get_working_arena (OS_os_workgroup wg, [NullAllowed] uint* index_out);

		// extern void os_workgroup_cancel (os_workgroup_t _Nonnull wg) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern void os_workgroup_cancel (OS_os_workgroup wg);

		// extern _Bool os_workgroup_testcancel (os_workgroup_t _Nonnull wg) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern bool os_workgroup_testcancel (OS_os_workgroup wg);

		// extern int os_workgroup_max_parallel_threads (os_workgroup_t _Nonnull wg, os_workgroup_mpt_attr_t _Nullable attr) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_max_parallel_threads (OS_os_workgroup wg, [NullAllowed] os_workgroup_mpt_attr_t* attr);

		// extern int os_workgroup_interval_start (os_workgroup_interval_t _Nonnull wg, uint64_t start, uint64_t deadline, os_workgroup_interval_data_t _Nullable data) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((warn_unused_result("")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_interval_start (OS_os_workgroup_interval wg, ulong start, ulong deadline, [NullAllowed] os_workgroup_interval_data_t* data);

		// extern int os_workgroup_interval_update (os_workgroup_interval_t _Nonnull wg, uint64_t deadline, os_workgroup_interval_data_t _Nullable data) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((warn_unused_result("")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_interval_update (OS_os_workgroup_interval wg, ulong deadline, [NullAllowed] os_workgroup_interval_data_t* data);

		// extern int os_workgroup_interval_finish (os_workgroup_interval_t _Nonnull wg, os_workgroup_interval_data_t _Nullable data) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((swift_private)) __attribute__((visibility("default"))) __attribute__((warn_unused_result("")));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern unsafe int os_workgroup_interval_finish (OS_os_workgroup_interval wg, [NullAllowed] os_workgroup_interval_data_t* data);

		// extern os_workgroup_parallel_t _Nullable os_workgroup_parallel_create (const char * _Nullable name, os_workgroup_attr_t _Nullable attr) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((visibility("default"))) __attribute__((ns_returns_retained)) __attribute__((swift_name("WorkGroupParallel.init(__name:attr:)"))) __attribute__((ns_returns_retained));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe OS_os_workgroup_parallel os_workgroup_parallel_create ([NullAllowed] sbyte* name, [NullAllowed] os_workgroup_attr_t* attr);

		// extern dispatch_time_t dispatch_time (dispatch_time_t when, int64_t delta) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern ulong dispatch_time (ulong when, long delta);

		// extern dispatch_time_t dispatch_walltime (const struct timespec * _Nullable when, int64_t delta) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe ulong dispatch_walltime ([NullAllowed] timespec* when, long delta);

		// extern qos_class_t qos_class_self () __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0)));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern qos_class_t qos_class_self ();

		// extern qos_class_t qos_class_main () __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0)));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern qos_class_t qos_class_main ();

		// void _dispatch_object_validate (dispatch_object_t _Nonnull object) __attribute__((always_inline)) __attribute__((nonnull)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern void _dispatch_object_validate (DispatchObject @object);

		// extern void dispatch_retain (dispatch_object_t _Nonnull object) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow)) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_retain (DispatchObject @object);

		// extern void dispatch_release (dispatch_object_t _Nonnull object) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow)) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_release (DispatchObject @object);

		// extern void * _Nullable dispatch_get_context (dispatch_object_t _Nonnull object) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((pure)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* dispatch_get_context (DispatchObject @object);

		// extern void dispatch_set_context (dispatch_object_t _Nonnull object, void * _Nullable context) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_set_context (DispatchObject @object, [NullAllowed] void* context);

		// extern void dispatch_set_finalizer_f (dispatch_object_t _Nonnull object, dispatch_function_t _Nullable finalizer) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_set_finalizer_f (DispatchObject @object, [NullAllowed] dispatch_function_t* finalizer);

		// extern void dispatch_activate (dispatch_object_t _Nonnull object) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_activate (DispatchObject @object);

		// extern void dispatch_suspend (dispatch_object_t _Nonnull object) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_suspend (DispatchObject @object);

		// extern void dispatch_resume (dispatch_object_t _Nonnull object) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_resume (DispatchObject @object);

		// extern void dispatch_set_qos_class_floor (dispatch_object_t _Nonnull object, dispatch_qos_class_t qos_class, int relative_priority) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nothrow));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_set_qos_class_floor (DispatchObject @object, dispatch_qos_class_t qos_class, int relative_priority);

		// extern void dispatch_debug (dispatch_object_t _Nonnull object, const char * _Nonnull message, ...) __attribute__((availability(macos, introduced=10.6, deprecated=10.9))) __attribute__((availability(ios, introduced=4.0, deprecated=6.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((nothrow)) __attribute__((cold)) __attribute__((format(printf, 2, 3)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "unsupported interface")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "unsupported interface")]
		[Introduced (PlatformName.iOS, 4, 0, message: "unsupported interface")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "unsupported interface")]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_debug (DispatchObject @object, sbyte* message, IntPtr varArgs);

		// extern void dispatch_debugv (dispatch_object_t _Nonnull object, const char * _Nonnull message, va_list ap) __attribute__((availability(macos, introduced=10.6, deprecated=10.9))) __attribute__((availability(ios, introduced=4.0, deprecated=6.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((nothrow)) __attribute__((cold)) __attribute__((format(printf, 2, 0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "unsupported interface")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "unsupported interface")]
		[Introduced (PlatformName.iOS, 4, 0, message: "unsupported interface")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "unsupported interface")]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_debugv (DispatchObject @object, sbyte* message, sbyte* ap);

		// extern void dispatch_async (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_async (DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_async_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_async_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_sync (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_sync (DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_sync_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_sync_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_async_and_wait (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_async_and_wait (DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_async_and_wait_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_async_and_wait_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_apply (size_t iterations, dispatch_queue_t _Nullable queue, void (^ _Nonnull)(size_t) block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_apply (nuint iterations, [NullAllowed] DispatchQueue queue, Action<nuint> block);

		// extern void dispatch_apply_f (size_t iterations, dispatch_queue_t _Nullable queue, void * _Nullable context, void (* _Nonnull)(void * _Nullable, size_t) work) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(4))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_apply_f (nuint iterations, [NullAllowed] DispatchQueue queue, [NullAllowed] void* context, Action<void*, nuint>* work);

		// extern dispatch_queue_t _Nonnull dispatch_get_current_queue () __attribute__((availability(macos, introduced=10.6, deprecated=10.9))) __attribute__((availability(ios, introduced=4.0, deprecated=6.0))) __attribute__((visibility("default"))) __attribute__((pure)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "unsupported interface")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "unsupported interface")]
		[Introduced (PlatformName.iOS, 4, 0, message: "unsupported interface")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "unsupported interface")]
		[DllImport ("__Internal")]
		static extern DispatchQueue dispatch_get_current_queue ();

		// dispatch_queue_main_t _Nonnull dispatch_get_main_queue () __attribute__((always_inline)) __attribute__((const)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern OS_dispatch_queue_main dispatch_get_main_queue ();

		// extern dispatch_queue_global_t _Nonnull dispatch_get_global_queue (intptr_t identifier, uintptr_t flags) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((const)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_queue_global dispatch_get_global_queue (IntPtr identifier, UIntPtr flags);

		// extern dispatch_queue_attr_t _Nonnull dispatch_queue_attr_make_initially_inactive (dispatch_queue_attr_t _Nullable attr) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_queue_attr dispatch_queue_attr_make_initially_inactive ([NullAllowed] OS_dispatch_queue_attr attr);

		// extern dispatch_queue_attr_t _Nonnull dispatch_queue_attr_make_with_autorelease_frequency (dispatch_queue_attr_t _Nullable attr, dispatch_autorelease_frequency_t frequency) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_queue_attr dispatch_queue_attr_make_with_autorelease_frequency ([NullAllowed] OS_dispatch_queue_attr attr, dispatch_autorelease_frequency_t frequency);

		// extern dispatch_queue_attr_t _Nonnull dispatch_queue_attr_make_with_qos_class (dispatch_queue_attr_t _Nullable attr, dispatch_qos_class_t qos_class, int relative_priority) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_queue_attr dispatch_queue_attr_make_with_qos_class ([NullAllowed] OS_dispatch_queue_attr attr, dispatch_qos_class_t qos_class, int relative_priority);

		// extern dispatch_queue_t _Nonnull dispatch_queue_create_with_target (const char * _Nullable label, dispatch_queue_attr_t _Nullable attr, dispatch_queue_t _Nullable target) asm("_dispatch_queue_create_with_target$V2") __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchQueue dispatch_queue_create_with_target ([NullAllowed] sbyte* label, [NullAllowed] OS_dispatch_queue_attr attr, [NullAllowed] DispatchQueue target);

		// extern dispatch_queue_t _Nonnull dispatch_queue_create (const char * _Nullable label, dispatch_queue_attr_t _Nullable attr) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchQueue dispatch_queue_create ([NullAllowed] sbyte* label, [NullAllowed] OS_dispatch_queue_attr attr);

		// extern const char * _Nonnull dispatch_queue_get_label (dispatch_queue_t _Nullable queue) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((pure)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe sbyte* dispatch_queue_get_label ([NullAllowed] DispatchQueue queue);

		// extern dispatch_qos_class_t dispatch_queue_get_qos_class (dispatch_queue_t _Nonnull queue, int * _Nullable relative_priority_ptr) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((warn_unused_result(""))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe dispatch_qos_class_t dispatch_queue_get_qos_class (DispatchQueue queue, [NullAllowed] int* relative_priority_ptr);

		// extern void dispatch_set_target_queue (dispatch_object_t _Nonnull object, dispatch_queue_t _Nullable queue) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_set_target_queue (DispatchObject @object, [NullAllowed] DispatchQueue queue);

		// extern void dispatch_main () __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_main ();

		// extern void dispatch_after (dispatch_time_t when, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_after (ulong when, DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_after_f (dispatch_time_t when, dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((nonnull(4))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_after_f (ulong when, DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_barrier_async (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern void dispatch_barrier_async (DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_barrier_async_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_barrier_async_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_barrier_sync (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern void dispatch_barrier_sync (DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_barrier_sync_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_barrier_sync_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_barrier_async_and_wait (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_barrier_async_and_wait (DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_barrier_async_and_wait_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_barrier_async_and_wait_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_queue_set_specific (dispatch_queue_t _Nonnull queue, const void * _Nonnull key, void * _Nullable context, dispatch_function_t _Nullable destructor) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_queue_set_specific (DispatchQueue queue, void* key, [NullAllowed] void* context, [NullAllowed] dispatch_function_t* destructor);

		// extern void * _Nullable dispatch_queue_get_specific (dispatch_queue_t _Nonnull queue, const void * _Nonnull key) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((pure)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* dispatch_queue_get_specific (DispatchQueue queue, void* key);

		// extern void * _Nullable dispatch_get_specific (const void * _Nonnull key) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((pure)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* dispatch_get_specific (void* key);

		// extern void dispatch_assert_queue (dispatch_queue_t _Nonnull queue) asm("_dispatch_assert_queue$V2") __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_assert_queue (DispatchQueue queue);

		// extern void dispatch_assert_queue_barrier (dispatch_queue_t _Nonnull queue) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_assert_queue_barrier (DispatchQueue queue);

		// extern void dispatch_assert_queue_not (dispatch_queue_t _Nonnull queue) asm("_dispatch_assert_queue_not$V2") __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1)));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_assert_queue_not (DispatchQueue queue);

		// extern dispatch_block_t _Nonnull dispatch_block_create (dispatch_block_flags_t flags, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern dispatch_block_t dispatch_block_create (dispatch_block_flags_t flags, dispatch_block_t block);

		// extern dispatch_block_t _Nonnull dispatch_block_create_with_qos_class (dispatch_block_flags_t flags, dispatch_qos_class_t qos_class, int relative_priority, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull(4))) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern dispatch_block_t dispatch_block_create_with_qos_class (dispatch_block_flags_t flags, dispatch_qos_class_t qos_class, int relative_priority, dispatch_block_t block);

		// extern void dispatch_block_perform (dispatch_block_flags_t flags, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_block_perform (dispatch_block_flags_t flags, dispatch_block_t block);

		// extern intptr_t dispatch_block_wait (dispatch_block_t _Nonnull block, dispatch_time_t timeout) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern IntPtr dispatch_block_wait (dispatch_block_t block, ulong timeout);

		// extern void dispatch_block_notify (dispatch_block_t _Nonnull block, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull notification_block) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_block_notify (dispatch_block_t block, DispatchQueue queue, dispatch_block_t notification_block);

		// extern void dispatch_block_cancel (dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_block_cancel (dispatch_block_t block);

		// extern intptr_t dispatch_block_testcancel (dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern IntPtr dispatch_block_testcancel (dispatch_block_t block);

		// extern mach_msg_return_t mach_msg_overwrite (mach_msg_header_t *msg, mach_msg_option_t option, mach_msg_size_t send_size, mach_msg_size_t rcv_size, mach_port_name_t rcv_name, mach_msg_timeout_t timeout, mach_port_name_t notify, mach_msg_header_t *rcv_msg, mach_msg_size_t rcv_limit) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int mach_msg_overwrite (mach_msg_header_t* msg, int option, uint send_size, uint rcv_size, uint rcv_name, uint timeout, uint notify, mach_msg_header_t* rcv_msg, uint rcv_limit);

		// extern mach_msg_return_t mach_msg (mach_msg_header_t *msg, mach_msg_option_t option, mach_msg_size_t send_size, mach_msg_size_t rcv_size, mach_port_name_t rcv_name, mach_msg_timeout_t timeout, mach_port_name_t notify) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe int mach_msg (mach_msg_header_t* msg, int option, uint send_size, uint rcv_size, uint rcv_name, uint timeout, uint notify);

		// extern kern_return_t mach_voucher_deallocate (mach_port_name_t voucher) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern int mach_voucher_deallocate (uint voucher);

		// extern dispatch_source_t _Nonnull dispatch_source_create (dispatch_source_type_t _Nonnull type, uintptr_t handle, uintptr_t mask, dispatch_queue_t _Nullable queue) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe OS_dispatch_source dispatch_source_create (dispatch_source_type_t* type, UIntPtr handle, UIntPtr mask, [NullAllowed] DispatchQueue queue);

		// extern void dispatch_source_set_event_handler (dispatch_source_t _Nonnull source, dispatch_block_t _Nullable handler) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_source_set_event_handler (OS_dispatch_source source, [NullAllowed] dispatch_block_t handler);

		// extern void dispatch_source_set_event_handler_f (dispatch_source_t _Nonnull source, dispatch_function_t _Nullable handler) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_source_set_event_handler_f (OS_dispatch_source source, [NullAllowed] dispatch_function_t* handler);

		// extern void dispatch_source_set_cancel_handler (dispatch_source_t _Nonnull source, dispatch_block_t _Nullable handler) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_source_set_cancel_handler (OS_dispatch_source source, [NullAllowed] dispatch_block_t handler);

		// extern void dispatch_source_set_cancel_handler_f (dispatch_source_t _Nonnull source, dispatch_function_t _Nullable handler) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_source_set_cancel_handler_f (OS_dispatch_source source, [NullAllowed] dispatch_function_t* handler);

		// extern void dispatch_source_cancel (dispatch_source_t _Nonnull source) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_source_cancel (OS_dispatch_source source);

		// extern intptr_t dispatch_source_testcancel (dispatch_source_t _Nonnull source) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern IntPtr dispatch_source_testcancel (OS_dispatch_source source);

		// extern uintptr_t dispatch_source_get_handle (dispatch_source_t _Nonnull source) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern UIntPtr dispatch_source_get_handle (OS_dispatch_source source);

		// extern uintptr_t dispatch_source_get_mask (dispatch_source_t _Nonnull source) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern UIntPtr dispatch_source_get_mask (OS_dispatch_source source);

		// extern uintptr_t dispatch_source_get_data (dispatch_source_t _Nonnull source) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((warn_unused_result(""))) __attribute__((pure)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern UIntPtr dispatch_source_get_data (OS_dispatch_source source);

		// extern void dispatch_source_merge_data (dispatch_source_t _Nonnull source, uintptr_t value) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_source_merge_data (OS_dispatch_source source, UIntPtr value);

		// extern void dispatch_source_set_timer (dispatch_source_t _Nonnull source, dispatch_time_t start, uint64_t interval, uint64_t leeway) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_source_set_timer (OS_dispatch_source source, ulong start, ulong interval, ulong leeway);

		// extern void dispatch_source_set_registration_handler (dispatch_source_t _Nonnull source, dispatch_block_t _Nullable handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern void dispatch_source_set_registration_handler (OS_dispatch_source source, [NullAllowed] dispatch_block_t handler);

		// extern void dispatch_source_set_registration_handler_f (dispatch_source_t _Nonnull source, dispatch_function_t _Nullable handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_source_set_registration_handler_f (OS_dispatch_source source, [NullAllowed] dispatch_function_t* handler);

		// extern dispatch_group_t _Nonnull dispatch_group_create () __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern DispatchGroup dispatch_group_create ();

		// extern void dispatch_group_async (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_group_async (DispatchGroup group, DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_group_async_f (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(2))) __attribute__((nonnull(4))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_group_async_f (DispatchGroup group, DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern intptr_t dispatch_group_wait (dispatch_group_t _Nonnull group, dispatch_time_t timeout) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern IntPtr dispatch_group_wait (DispatchGroup group, ulong timeout);

		// extern void dispatch_group_notify (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_group_notify (DispatchGroup group, DispatchQueue queue, dispatch_block_t block);

		// extern void dispatch_group_notify_f (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(2))) __attribute__((nonnull(4))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_group_notify_f (DispatchGroup group, DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

		// extern void dispatch_group_enter (dispatch_group_t _Nonnull group) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_group_enter (DispatchGroup group);

		// extern void dispatch_group_leave (dispatch_group_t _Nonnull group) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_group_leave (DispatchGroup group);

		// extern dispatch_semaphore_t _Nonnull dispatch_semaphore_create (intptr_t value) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_semaphore dispatch_semaphore_create (IntPtr value);

		// extern intptr_t dispatch_semaphore_wait (dispatch_semaphore_t _Nonnull dsema, dispatch_time_t timeout) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern IntPtr dispatch_semaphore_wait (OS_dispatch_semaphore dsema, ulong timeout);

		// extern intptr_t dispatch_semaphore_signal (dispatch_semaphore_t _Nonnull dsema) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern IntPtr dispatch_semaphore_signal (OS_dispatch_semaphore dsema);

		// extern void dispatch_once (dispatch_once_t * _Nonnull predicate, dispatch_block_t _Nonnull block) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_once (IntPtr* predicate, dispatch_block_t block);

		// void _dispatch_once (dispatch_once_t * _Nonnull predicate, dispatch_block_t _Nonnull block) __attribute__((always_inline)) __attribute__((nonnull)) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe void _dispatch_once (IntPtr* predicate, dispatch_block_t block);

		// extern long __builtin_expect (long, long)  __attribute__((nothrow)) __attribute__((const));
		[DllImport ("__Internal")]
		static extern nint __builtin_expect (nint, nint);

		// extern void __builtin_assume (_Bool)  __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern void __builtin_assume (bool);

		// extern void dispatch_once_f (dispatch_once_t * _Nonnull predicate, void * _Nullable context, dispatch_function_t _Nonnull function) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void dispatch_once_f (IntPtr* predicate, [NullAllowed] void* context, dispatch_function_t* function);

		// void _dispatch_once_f (dispatch_once_t * _Nonnull predicate, void * _Nullable context, dispatch_function_t _Nonnull function) __attribute__((always_inline)) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nothrow));
		[DllImport ("__Internal")]
		static extern unsafe void _dispatch_once_f (IntPtr* predicate, [NullAllowed] void* context, dispatch_function_t* function);

		// extern dispatch_data_t _Nonnull dispatch_data_create (const void * _Nonnull buffer, size_t size, dispatch_queue_t _Nullable queue, dispatch_block_t _Nullable destructor) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchData dispatch_data_create (void* buffer, nuint size, [NullAllowed] DispatchQueue queue, [NullAllowed] dispatch_block_t destructor);

		// extern size_t dispatch_data_get_size (dispatch_data_t _Nonnull data) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((pure)) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern nuint dispatch_data_get_size (DispatchData data);

		// extern dispatch_data_t _Nonnull dispatch_data_create_map (dispatch_data_t _Nonnull data, const void * _Nullable * _Nullable buffer_ptr, size_t * _Nullable size_ptr) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchData dispatch_data_create_map (DispatchData data, [NullAllowed] void** buffer_ptr, [NullAllowed] nuint* size_ptr);

		// extern dispatch_data_t _Nonnull dispatch_data_create_concat (dispatch_data_t _Nonnull data1, dispatch_data_t _Nonnull data2) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern DispatchData dispatch_data_create_concat (DispatchData data1, DispatchData data2);

		// extern dispatch_data_t _Nonnull dispatch_data_create_subrange (dispatch_data_t _Nonnull data, size_t offset, size_t length) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern DispatchData dispatch_data_create_subrange (DispatchData data, nuint offset, nuint length);

		// extern _Bool dispatch_data_apply (dispatch_data_t _Nonnull data, dispatch_data_applier_t _Nonnull applier) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern bool dispatch_data_apply (DispatchData data, dispatch_data_applier_t applier);

		// extern dispatch_data_t _Nonnull dispatch_data_copy_region (dispatch_data_t _Nonnull data, size_t location, size_t * _Nonnull offset_ptr) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchData dispatch_data_copy_region (DispatchData data, nuint location, nuint* offset_ptr);

		// extern void dispatch_read (dispatch_fd_t fd, size_t length, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(dispatch_data_t _Nonnull, int) handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(3))) __attribute__((nonnull(4))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_read (int fd, nuint length, DispatchQueue queue, Action<DispatchData, int> handler);

		// extern void dispatch_write (dispatch_fd_t fd, dispatch_data_t _Nonnull data, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(dispatch_data_t _Nullable, int) handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((nonnull(3))) __attribute__((nonnull(4))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_write (int fd, DispatchData data, DispatchQueue queue, Action<DispatchData, int> handler);

		// extern dispatch_io_t _Nonnull dispatch_io_create (dispatch_io_type_t type, dispatch_fd_t fd, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(int) cleanup_handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_io dispatch_io_create (nuint type, int fd, DispatchQueue queue, Action<int> cleanup_handler);

		// extern dispatch_io_t _Nonnull dispatch_io_create_with_path (dispatch_io_type_t type, const char * _Nonnull path, int oflag, mode_t mode, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(int) cleanup_handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe OS_dispatch_io dispatch_io_create_with_path (nuint type, sbyte* path, int oflag, ushort mode, DispatchQueue queue, Action<int> cleanup_handler);

		// extern dispatch_io_t _Nonnull dispatch_io_create_with_io (dispatch_io_type_t type, dispatch_io_t _Nonnull io, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(int) cleanup_handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(2))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern OS_dispatch_io dispatch_io_create_with_io (nuint type, OS_dispatch_io io, DispatchQueue queue, Action<int> cleanup_handler);

		// extern void dispatch_io_read (dispatch_io_t _Nonnull channel, off_t offset, size_t length, dispatch_queue_t _Nonnull queue, dispatch_io_handler_t _Nonnull io_handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(4))) __attribute__((nonnull(5))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_read (OS_dispatch_io channel, long offset, nuint length, DispatchQueue queue, dispatch_io_handler_t io_handler);

		// extern void dispatch_io_write (dispatch_io_t _Nonnull channel, off_t offset, dispatch_data_t _Nonnull data, dispatch_queue_t _Nonnull queue, dispatch_io_handler_t _Nonnull io_handler) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nonnull(3))) __attribute__((nonnull(4))) __attribute__((nonnull(5))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_write (OS_dispatch_io channel, long offset, DispatchData data, DispatchQueue queue, dispatch_io_handler_t io_handler);

		// extern void dispatch_io_close (dispatch_io_t _Nonnull channel, dispatch_io_close_flags_t flags) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_close (OS_dispatch_io channel, nuint flags);

		// extern void dispatch_io_barrier (dispatch_io_t _Nonnull channel, dispatch_block_t _Nonnull barrier) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_barrier (OS_dispatch_io channel, dispatch_block_t barrier);

		// extern dispatch_fd_t dispatch_io_get_descriptor (dispatch_io_t _Nonnull channel) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((warn_unused_result(""))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern int dispatch_io_get_descriptor (OS_dispatch_io channel);

		// extern void dispatch_io_set_high_water (dispatch_io_t _Nonnull channel, size_t high_water) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_set_high_water (OS_dispatch_io channel, nuint high_water);

		// extern void dispatch_io_set_low_water (dispatch_io_t _Nonnull channel, size_t low_water) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_set_low_water (OS_dispatch_io channel, nuint low_water);

		// extern void dispatch_io_set_interval (dispatch_io_t _Nonnull channel, uint64_t interval, dispatch_io_interval_flags_t flags) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull(1))) __attribute__((nothrow));
		[Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_io_set_interval (OS_dispatch_io channel, ulong interval, nuint flags);

		// extern dispatch_workloop_t _Nonnull dispatch_workloop_create (const char * _Nullable label) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe OS_dispatch_workloop dispatch_workloop_create ([NullAllowed] sbyte* label);

		// extern dispatch_workloop_t _Nonnull dispatch_workloop_create_inactive (const char * _Nullable label) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((malloc)) __attribute__((ns_returns_retained)) __attribute__((warn_unused_result(""))) __attribute__((nothrow)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe OS_dispatch_workloop dispatch_workloop_create_inactive ([NullAllowed] sbyte* label);

		// extern void dispatch_workloop_set_autorelease_frequency (dispatch_workloop_t _Nonnull workloop, dispatch_autorelease_frequency_t frequency) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_workloop_set_autorelease_frequency (OS_dispatch_workloop workloop, dispatch_autorelease_frequency_t frequency);

		// extern void dispatch_workloop_set_os_workgroup (dispatch_workloop_t _Nonnull workloop, os_workgroup_t _Nonnull workgroup) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((visibility("default"))) __attribute__((nonnull)) __attribute__((nothrow));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		static extern void dispatch_workloop_set_os_workgroup (OS_dispatch_workloop workloop, OS_os_workgroup workgroup);

		// extern CFTypeID CFReadStreamGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFReadStreamGetTypeID ();

		// extern CFTypeID CFWriteStreamGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFWriteStreamGetTypeID ();

		// extern CFReadStreamRef _Null_unspecified CFReadStreamCreateWithBytesNoCopy (CFAllocatorRef _Null_unspecified alloc, const UInt8 * _Null_unspecified bytes, CFIndex length, CFAllocatorRef _Null_unspecified bytesDeallocator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFReadStreamRef* CFReadStreamCreateWithBytesNoCopy (CFAllocatorRef* alloc, byte* bytes, nint length, CFAllocatorRef* bytesDeallocator);

		// extern CFWriteStreamRef _Null_unspecified CFWriteStreamCreateWithBuffer (CFAllocatorRef _Null_unspecified alloc, UInt8 * _Null_unspecified buffer, CFIndex bufferCapacity) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithBuffer (CFAllocatorRef* alloc, byte* buffer, nint bufferCapacity);

		// extern CFWriteStreamRef _Null_unspecified CFWriteStreamCreateWithAllocatedBuffers (CFAllocatorRef _Null_unspecified alloc, CFAllocatorRef _Null_unspecified bufferAllocator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithAllocatedBuffers (CFAllocatorRef* alloc, CFAllocatorRef* bufferAllocator);

		// extern CFReadStreamRef _Null_unspecified CFReadStreamCreateWithFile (CFAllocatorRef _Null_unspecified alloc, CFURLRef _Null_unspecified fileURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFReadStreamRef* CFReadStreamCreateWithFile (CFAllocatorRef* alloc, CFURLRef* fileURL);

		// extern CFWriteStreamRef _Null_unspecified CFWriteStreamCreateWithFile (CFAllocatorRef _Null_unspecified alloc, CFURLRef _Null_unspecified fileURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithFile (CFAllocatorRef* alloc, CFURLRef* fileURL);

		// extern void CFStreamCreateBoundPair (CFAllocatorRef _Null_unspecified alloc, CFReadStreamRef  _Null_unspecified * _Null_unspecified readStream, CFWriteStreamRef  _Null_unspecified * _Null_unspecified writeStream, CFIndex transferBufferSize);
		[DllImport ("__Internal")]
		static extern unsafe void CFStreamCreateBoundPair (CFAllocatorRef* alloc, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream, nint transferBufferSize);

		// extern void CFStreamCreatePairWithSocket (CFAllocatorRef _Null_unspecified alloc, CFSocketNativeHandle sock, CFReadStreamRef  _Null_unspecified * _Null_unspecified readStream, CFWriteStreamRef  _Null_unspecified * _Null_unspecified writeStream) __attribute__((availability(macos, introduced=10.1, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 1, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFStreamCreatePairWithSocket (CFAllocatorRef* alloc, int sock, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream);

		// extern void CFStreamCreatePairWithSocketToHost (CFAllocatorRef _Null_unspecified alloc, CFStringRef _Null_unspecified host, UInt32 port, CFReadStreamRef  _Null_unspecified * _Null_unspecified readStream, CFWriteStreamRef  _Null_unspecified * _Null_unspecified writeStream) __attribute__((availability(macos, introduced=10.1, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 1, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFStreamCreatePairWithSocketToHost (CFAllocatorRef* alloc, CFStringRef* host, uint port, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream);

		// extern void CFStreamCreatePairWithPeerSocketSignature (CFAllocatorRef _Null_unspecified alloc, const CFSocketSignature * _Null_unspecified signature, CFReadStreamRef  _Null_unspecified * _Null_unspecified readStream, CFWriteStreamRef  _Null_unspecified * _Null_unspecified writeStream) __attribute__((availability(macos, introduced=10.1, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 1, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_connection_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_connection_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFStreamCreatePairWithPeerSocketSignature (CFAllocatorRef* alloc, CFSocketSignature* signature, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream);

		// extern CFStreamStatus CFReadStreamGetStatus (CFReadStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStreamStatus CFReadStreamGetStatus (CFReadStreamRef* stream);

		// extern CFStreamStatus CFWriteStreamGetStatus (CFWriteStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStreamStatus CFWriteStreamGetStatus (CFWriteStreamRef* stream);

		// extern CFErrorRef _Null_unspecified CFReadStreamCopyError (CFReadStreamRef _Null_unspecified stream) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFErrorRef* CFReadStreamCopyError (CFReadStreamRef* stream);

		// extern CFErrorRef _Null_unspecified CFWriteStreamCopyError (CFWriteStreamRef _Null_unspecified stream) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFErrorRef* CFWriteStreamCopyError (CFWriteStreamRef* stream);

		// extern Boolean CFReadStreamOpen (CFReadStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFReadStreamOpen (CFReadStreamRef* stream);

		// extern Boolean CFWriteStreamOpen (CFWriteStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFWriteStreamOpen (CFWriteStreamRef* stream);

		// extern void CFReadStreamClose (CFReadStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFReadStreamClose (CFReadStreamRef* stream);

		// extern void CFWriteStreamClose (CFWriteStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFWriteStreamClose (CFWriteStreamRef* stream);

		// extern Boolean CFReadStreamHasBytesAvailable (CFReadStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFReadStreamHasBytesAvailable (CFReadStreamRef* stream);

		// extern CFIndex CFReadStreamRead (CFReadStreamRef _Null_unspecified stream, UInt8 * _Null_unspecified buffer, CFIndex bufferLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFReadStreamRead (CFReadStreamRef* stream, byte* buffer, nint bufferLength);

		// extern const UInt8 * _Null_unspecified CFReadStreamGetBuffer (CFReadStreamRef _Null_unspecified stream, CFIndex maxBytesToRead, CFIndex * _Null_unspecified numBytesRead) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte* CFReadStreamGetBuffer (CFReadStreamRef* stream, nint maxBytesToRead, nint* numBytesRead);

		// extern Boolean CFWriteStreamCanAcceptBytes (CFWriteStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFWriteStreamCanAcceptBytes (CFWriteStreamRef* stream);

		// extern CFIndex CFWriteStreamWrite (CFWriteStreamRef _Null_unspecified stream, const UInt8 * _Null_unspecified buffer, CFIndex bufferLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFWriteStreamWrite (CFWriteStreamRef* stream, byte* buffer, nint bufferLength);

		// extern CFTypeRef _Null_unspecified CFReadStreamCopyProperty (CFReadStreamRef _Null_unspecified stream, CFStreamPropertyKey _Null_unspecified propertyName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFReadStreamCopyProperty (CFReadStreamRef* stream, CFStreamPropertyKey* propertyName);

		// extern CFTypeRef _Null_unspecified CFWriteStreamCopyProperty (CFWriteStreamRef _Null_unspecified stream, CFStreamPropertyKey _Null_unspecified propertyName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFWriteStreamCopyProperty (CFWriteStreamRef* stream, CFStreamPropertyKey* propertyName);

		// extern Boolean CFReadStreamSetProperty (CFReadStreamRef _Null_unspecified stream, CFStreamPropertyKey _Null_unspecified propertyName, CFTypeRef _Null_unspecified propertyValue) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFReadStreamSetProperty (CFReadStreamRef* stream, CFStreamPropertyKey* propertyName, void* propertyValue);

		// extern Boolean CFWriteStreamSetProperty (CFWriteStreamRef _Null_unspecified stream, CFStreamPropertyKey _Null_unspecified propertyName, CFTypeRef _Null_unspecified propertyValue) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFWriteStreamSetProperty (CFWriteStreamRef* stream, CFStreamPropertyKey* propertyName, void* propertyValue);

		// extern Boolean CFReadStreamSetClient (CFReadStreamRef _Null_unspecified stream, CFOptionFlags streamEvents, CFReadStreamClientCallBack _Null_unspecified clientCB, CFStreamClientContext * _Null_unspecified clientContext) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFReadStreamSetClient (CFReadStreamRef* stream, nuint streamEvents, CFReadStreamClientCallBack* clientCB, CFStreamClientContext* clientContext);

		// extern Boolean CFWriteStreamSetClient (CFWriteStreamRef _Null_unspecified stream, CFOptionFlags streamEvents, CFWriteStreamClientCallBack _Null_unspecified clientCB, CFStreamClientContext * _Null_unspecified clientContext) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFWriteStreamSetClient (CFWriteStreamRef* stream, nuint streamEvents, CFWriteStreamClientCallBack* clientCB, CFStreamClientContext* clientContext);

		// extern void CFReadStreamScheduleWithRunLoop (CFReadStreamRef _Null_unspecified stream, CFRunLoopRef _Null_unspecified runLoop, CFRunLoopMode _Null_unspecified runLoopMode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFReadStreamScheduleWithRunLoop (CFReadStreamRef* stream, CFRunLoop runLoop, CFRunLoopMode* runLoopMode);

		// extern void CFWriteStreamScheduleWithRunLoop (CFWriteStreamRef _Null_unspecified stream, CFRunLoopRef _Null_unspecified runLoop, CFRunLoopMode _Null_unspecified runLoopMode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFWriteStreamScheduleWithRunLoop (CFWriteStreamRef* stream, CFRunLoop runLoop, CFRunLoopMode* runLoopMode);

		// extern void CFReadStreamUnscheduleFromRunLoop (CFReadStreamRef _Null_unspecified stream, CFRunLoopRef _Null_unspecified runLoop, CFRunLoopMode _Null_unspecified runLoopMode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFReadStreamUnscheduleFromRunLoop (CFReadStreamRef* stream, CFRunLoop runLoop, CFRunLoopMode* runLoopMode);

		// extern void CFWriteStreamUnscheduleFromRunLoop (CFWriteStreamRef _Null_unspecified stream, CFRunLoopRef _Null_unspecified runLoop, CFRunLoopMode _Null_unspecified runLoopMode) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFWriteStreamUnscheduleFromRunLoop (CFWriteStreamRef* stream, CFRunLoop runLoop, CFRunLoopMode* runLoopMode);

		// extern void CFReadStreamSetDispatchQueue (CFReadStreamRef _Null_unspecified stream, dispatch_queue_t _Null_unspecified q) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFReadStreamSetDispatchQueue (CFReadStreamRef* stream, DispatchQueue q);

		// extern void CFWriteStreamSetDispatchQueue (CFWriteStreamRef _Null_unspecified stream, dispatch_queue_t _Null_unspecified q) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFWriteStreamSetDispatchQueue (CFWriteStreamRef* stream, DispatchQueue q);

		// extern dispatch_queue_t _Null_unspecified CFReadStreamCopyDispatchQueue (CFReadStreamRef _Null_unspecified stream) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchQueue CFReadStreamCopyDispatchQueue (CFReadStreamRef* stream);

		// extern dispatch_queue_t _Null_unspecified CFWriteStreamCopyDispatchQueue (CFWriteStreamRef _Null_unspecified stream) __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe DispatchQueue CFWriteStreamCopyDispatchQueue (CFWriteStreamRef* stream);

		// extern CFStreamError CFReadStreamGetError (CFReadStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStreamError CFReadStreamGetError (CFReadStreamRef* stream);

		// extern CFStreamError CFWriteStreamGetError (CFWriteStreamRef _Null_unspecified stream) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStreamError CFWriteStreamGetError (CFWriteStreamRef* stream);

		// extern CFPropertyListRef CFPropertyListCreateFromXMLData (CFAllocatorRef allocator, CFDataRef xmlData, CFOptionFlags mutabilityOption, CFStringRef *errorString) __attribute__((availability(macos, introduced=10.0, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListCreateWithData instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithData instead.")]
		[DllImport ("__Internal")]
		static extern unsafe void* CFPropertyListCreateFromXMLData (CFAllocatorRef* allocator, CFDataRef* xmlData, nuint mutabilityOption, CFStringRef** errorString);

		// extern CFDataRef CFPropertyListCreateXMLData (CFAllocatorRef allocator, CFPropertyListRef propertyList) __attribute__((availability(macos, introduced=10.0, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFPropertyListCreateData instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListCreateData instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListCreateData instead.")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListCreateData instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateData instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateData instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateData instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateData instead.")]
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFPropertyListCreateXMLData (CFAllocatorRef* allocator, void* propertyList);

		// extern CFPropertyListRef CFPropertyListCreateDeepCopy (CFAllocatorRef allocator, CFPropertyListRef propertyList, CFOptionFlags mutabilityOption) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFPropertyListCreateDeepCopy (CFAllocatorRef* allocator, void* propertyList, nuint mutabilityOption);

		// extern Boolean CFPropertyListIsValid (CFPropertyListRef plist, CFPropertyListFormat format) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPropertyListIsValid (void* plist, CFPropertyListFormat format);

		// extern CFIndex CFPropertyListWriteToStream (CFPropertyListRef propertyList, CFWriteStreamRef stream, CFPropertyListFormat format, CFStringRef *errorString) __attribute__((availability(macos, introduced=10.2, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use CFPropertyListWrite instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListWrite instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListWrite instead.")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListWrite instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListWrite instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListWrite instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListWrite instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListWrite instead.")]
		[DllImport ("__Internal")]
		static extern unsafe nint CFPropertyListWriteToStream (void* propertyList, CFWriteStreamRef* stream, CFPropertyListFormat format, CFStringRef** errorString);

		// extern CFPropertyListRef CFPropertyListCreateFromStream (CFAllocatorRef allocator, CFReadStreamRef stream, CFIndex streamLength, CFOptionFlags mutabilityOption, CFPropertyListFormat *format, CFStringRef *errorString) __attribute__((availability(macos, introduced=10.2, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use CFPropertyListCreateWithStream instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListCreateWithStream instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListCreateWithStream instead.")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListCreateWithStream instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithStream instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithStream instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithStream instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithStream instead.")]
		[DllImport ("__Internal")]
		static extern unsafe void* CFPropertyListCreateFromStream (CFAllocatorRef* allocator, CFReadStreamRef* stream, nint streamLength, nuint mutabilityOption, CFPropertyListFormat* format, CFStringRef** errorString);

		// extern CFPropertyListRef CFPropertyListCreateWithData (CFAllocatorRef allocator, CFDataRef data, CFOptionFlags options, CFPropertyListFormat *format, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* CFPropertyListCreateWithData (CFAllocatorRef* allocator, CFDataRef* data, nuint options, CFPropertyListFormat* format, CFErrorRef** error);

		// extern CFPropertyListRef CFPropertyListCreateWithStream (CFAllocatorRef allocator, CFReadStreamRef stream, CFIndex streamLength, CFOptionFlags options, CFPropertyListFormat *format, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* CFPropertyListCreateWithStream (CFAllocatorRef* allocator, CFReadStreamRef* stream, nint streamLength, nuint options, CFPropertyListFormat* format, CFErrorRef** error);

		// extern CFIndex CFPropertyListWrite (CFPropertyListRef propertyList, CFWriteStreamRef stream, CFPropertyListFormat format, CFOptionFlags options, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFPropertyListWrite (void* propertyList, CFWriteStreamRef* stream, CFPropertyListFormat format, nuint options, CFErrorRef** error);

		// extern CFDataRef CFPropertyListCreateData (CFAllocatorRef allocator, CFPropertyListRef propertyList, CFPropertyListFormat format, CFOptionFlags options, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* CFPropertyListCreateData (CFAllocatorRef* allocator, void* propertyList, CFPropertyListFormat format, nuint options, CFErrorRef** error);

		// extern CFTypeID CFSetGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFSetGetTypeID ();

		// extern CFSetRef CFSetCreate (CFAllocatorRef allocator, const void **values, CFIndex numValues, const CFSetCallBacks *callBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSetRef* CFSetCreate (CFAllocatorRef* allocator, void** values, nint numValues, CFSetCallBacks* callBacks);

		// extern CFSetRef CFSetCreateCopy (CFAllocatorRef allocator, CFSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFSetRef* CFSetCreateCopy (CFAllocatorRef* allocator, CFSetRef* theSet);

		// extern CFMutableSetRef CFSetCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFSetCallBacks *callBacks) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableSetRef* CFSetCreateMutable (CFAllocatorRef* allocator, nint capacity, CFSetCallBacks* callBacks);

		// extern CFMutableSetRef CFSetCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableSetRef* CFSetCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFSetRef* theSet);

		// extern CFIndex CFSetGetCount (CFSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFSetGetCount (CFSetRef* theSet);

		// extern CFIndex CFSetGetCountOfValue (CFSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFSetGetCountOfValue (CFSetRef* theSet, void* value);

		// extern Boolean CFSetContainsValue (CFSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFSetContainsValue (CFSetRef* theSet, void* value);

		// extern const void * CFSetGetValue (CFSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFSetGetValue (CFSetRef* theSet, void* value);

		// extern Boolean CFSetGetValueIfPresent (CFSetRef theSet, const void *candidate, const void **value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFSetGetValueIfPresent (CFSetRef* theSet, void* candidate, void** value);

		// extern void CFSetGetValues (CFSetRef theSet, const void **values) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetGetValues (CFSetRef* theSet, void** values);

		// extern void CFSetApplyFunction (CFSetRef theSet, CFSetApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetApplyFunction (CFSetRef* theSet, CFSetApplierFunction* applier, void* context);

		// extern void CFSetAddValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetAddValue (CFMutableSetRef* theSet, void* value);

		// extern void CFSetReplaceValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetReplaceValue (CFMutableSetRef* theSet, void* value);

		// extern void CFSetSetValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetSetValue (CFMutableSetRef* theSet, void* value);

		// extern void CFSetRemoveValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetRemoveValue (CFMutableSetRef* theSet, void* value);

		// extern void CFSetRemoveAllValues (CFMutableSetRef theSet) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFSetRemoveAllValues (CFMutableSetRef* theSet);

		// extern CFTypeID CFTreeGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFTreeGetTypeID ();

		// extern CFTreeRef CFTreeCreate (CFAllocatorRef allocator, const CFTreeContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTreeRef* CFTreeCreate (CFAllocatorRef* allocator, CFTreeContext* context);

		// extern CFTreeRef CFTreeGetParent (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTreeRef* CFTreeGetParent (CFTreeRef* tree);

		// extern CFTreeRef CFTreeGetNextSibling (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTreeRef* CFTreeGetNextSibling (CFTreeRef* tree);

		// extern CFTreeRef CFTreeGetFirstChild (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTreeRef* CFTreeGetFirstChild (CFTreeRef* tree);

		// extern void CFTreeGetContext (CFTreeRef tree, CFTreeContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeGetContext (CFTreeRef* tree, CFTreeContext* context);

		// extern CFIndex CFTreeGetChildCount (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFTreeGetChildCount (CFTreeRef* tree);

		// extern CFTreeRef CFTreeGetChildAtIndex (CFTreeRef tree, CFIndex idx) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTreeRef* CFTreeGetChildAtIndex (CFTreeRef* tree, nint idx);

		// extern void CFTreeGetChildren (CFTreeRef tree, CFTreeRef *children) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeGetChildren (CFTreeRef* tree, CFTreeRef** children);

		// extern void CFTreeApplyFunctionToChildren (CFTreeRef tree, CFTreeApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeApplyFunctionToChildren (CFTreeRef* tree, CFTreeApplierFunction* applier, void* context);

		// extern CFTreeRef CFTreeFindRoot (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFTreeRef* CFTreeFindRoot (CFTreeRef* tree);

		// extern void CFTreeSetContext (CFTreeRef tree, const CFTreeContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeSetContext (CFTreeRef* tree, CFTreeContext* context);

		// extern void CFTreePrependChild (CFTreeRef tree, CFTreeRef newChild) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreePrependChild (CFTreeRef* tree, CFTreeRef* newChild);

		// extern void CFTreeAppendChild (CFTreeRef tree, CFTreeRef newChild) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeAppendChild (CFTreeRef* tree, CFTreeRef* newChild);

		// extern void CFTreeInsertSibling (CFTreeRef tree, CFTreeRef newSibling) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeInsertSibling (CFTreeRef* tree, CFTreeRef* newSibling);

		// extern void CFTreeRemove (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeRemove (CFTreeRef* tree);

		// extern void CFTreeRemoveAllChildren (CFTreeRef tree) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeRemoveAllChildren (CFTreeRef* tree);

		// extern void CFTreeSortChildren (CFTreeRef tree, CFComparatorFunction comparator, void *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFTreeSortChildren (CFTreeRef* tree, CFComparatorFunction* comparator, void* context);

		// extern Boolean CFURLCreateDataAndPropertiesFromResource (CFAllocatorRef alloc, CFURLRef url, CFDataRef *resourceData, CFDictionaryRef *properties, CFArrayRef desiredProperties, SInt32 *errorCode) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLCreateDataAndPropertiesFromResource (CFAllocatorRef* alloc, CFURLRef* url, CFDataRef** resourceData, CFDictionaryRef** properties, CFArrayRef* desiredProperties, int* errorCode);

		// extern Boolean CFURLWriteDataAndPropertiesToResource (CFURLRef url, CFDataRef dataToWrite, CFDictionaryRef propertiesToWrite, SInt32 *errorCode) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLWriteDataAndPropertiesToResource (CFURLRef* url, CFDataRef* dataToWrite, CFDictionaryRef* propertiesToWrite, int* errorCode);

		// extern Boolean CFURLDestroyResource (CFURLRef url, SInt32 *errorCode) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLDestroyResource (CFURLRef* url, int* errorCode);

		// extern CFTypeRef CFURLCreatePropertyFromResource (CFAllocatorRef alloc, CFURLRef url, CFStringRef property, SInt32 *errorCode) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
		[DllImport ("__Internal")]
		static extern unsafe void* CFURLCreatePropertyFromResource (CFAllocatorRef* alloc, CFURLRef* url, CFStringRef* property, int* errorCode);

		// extern CFTypeID CFUUIDGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFUUIDGetTypeID ();

		// extern CFUUIDRef CFUUIDCreate (CFAllocatorRef alloc) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFUUIDRef* CFUUIDCreate (CFAllocatorRef* alloc);

		// extern CFUUIDRef CFUUIDCreateWithBytes (CFAllocatorRef alloc, UInt8 byte0, UInt8 byte1, UInt8 byte2, UInt8 byte3, UInt8 byte4, UInt8 byte5, UInt8 byte6, UInt8 byte7, UInt8 byte8, UInt8 byte9, UInt8 byte10, UInt8 byte11, UInt8 byte12, UInt8 byte13, UInt8 byte14, UInt8 byte15) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFUUIDRef* CFUUIDCreateWithBytes (CFAllocatorRef* alloc, byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8, byte byte9, byte byte10, byte byte11, byte byte12, byte byte13, byte byte14, byte byte15);

		// extern CFUUIDRef CFUUIDCreateFromString (CFAllocatorRef alloc, CFStringRef uuidStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFUUIDRef* CFUUIDCreateFromString (CFAllocatorRef* alloc, CFStringRef* uuidStr);

		// extern CFStringRef CFUUIDCreateString (CFAllocatorRef alloc, CFUUIDRef uuid) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFUUIDCreateString (CFAllocatorRef* alloc, CFUUIDRef* uuid);

		// extern CFUUIDRef CFUUIDGetConstantUUIDWithBytes (CFAllocatorRef alloc, UInt8 byte0, UInt8 byte1, UInt8 byte2, UInt8 byte3, UInt8 byte4, UInt8 byte5, UInt8 byte6, UInt8 byte7, UInt8 byte8, UInt8 byte9, UInt8 byte10, UInt8 byte11, UInt8 byte12, UInt8 byte13, UInt8 byte14, UInt8 byte15) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFUUIDRef* CFUUIDGetConstantUUIDWithBytes (CFAllocatorRef* alloc, byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8, byte byte9, byte byte10, byte byte11, byte byte12, byte byte13, byte byte14, byte byte15);

		// extern CFUUIDBytes CFUUIDGetUUIDBytes (CFUUIDRef uuid) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFUUIDBytes CFUUIDGetUUIDBytes (CFUUIDRef* uuid);

		// extern CFUUIDRef CFUUIDCreateFromUUIDBytes (CFAllocatorRef alloc, CFUUIDBytes bytes) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFUUIDRef* CFUUIDCreateFromUUIDBytes (CFAllocatorRef* alloc, CFUUIDBytes bytes);

		// extern CFURLRef CFCopyHomeDirectoryURL () __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), NoMac, iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFCopyHomeDirectoryURL ();

		// extern CFBundleRef CFBundleGetMainBundle () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBundleRef* CFBundleGetMainBundle ();

		// extern CFBundleRef CFBundleGetBundleWithIdentifier (CFStringRef bundleID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBundleRef* CFBundleGetBundleWithIdentifier (CFStringRef* bundleID);

		// extern CFArrayRef CFBundleGetAllBundles () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleGetAllBundles ();

		// extern CFTypeID CFBundleGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFBundleGetTypeID ();

		// extern CFBundleRef CFBundleCreate (CFAllocatorRef allocator, CFURLRef bundleURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBundleRef* CFBundleCreate (CFAllocatorRef* allocator, CFURLRef* bundleURL);

		// extern CFArrayRef CFBundleCreateBundlesFromDirectory (CFAllocatorRef allocator, CFURLRef directoryURL, CFStringRef bundleType) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCreateBundlesFromDirectory (CFAllocatorRef* allocator, CFURLRef* directoryURL, CFStringRef* bundleType);

		// extern CFURLRef CFBundleCopyBundleURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyBundleURL (CFBundleRef* bundle);

		// extern CFTypeRef CFBundleGetValueForInfoDictionaryKey (CFBundleRef bundle, CFStringRef key) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFBundleGetValueForInfoDictionaryKey (CFBundleRef* bundle, CFStringRef* key);

		// extern CFDictionaryRef CFBundleGetInfoDictionary (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFBundleGetInfoDictionary (CFBundleRef* bundle);

		// extern CFDictionaryRef CFBundleGetLocalInfoDictionary (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFBundleGetLocalInfoDictionary (CFBundleRef* bundle);

		// extern void CFBundleGetPackageInfo (CFBundleRef bundle, UInt32 *packageType, UInt32 *packageCreator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBundleGetPackageInfo (CFBundleRef* bundle, uint* packageType, uint* packageCreator);

		// extern CFStringRef CFBundleGetIdentifier (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFBundleGetIdentifier (CFBundleRef* bundle);

		// extern UInt32 CFBundleGetVersionNumber (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint CFBundleGetVersionNumber (CFBundleRef* bundle);

		// extern CFStringRef CFBundleGetDevelopmentRegion (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFBundleGetDevelopmentRegion (CFBundleRef* bundle);

		// extern CFURLRef CFBundleCopySupportFilesDirectoryURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopySupportFilesDirectoryURL (CFBundleRef* bundle);

		// extern CFURLRef CFBundleCopyResourcesDirectoryURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyResourcesDirectoryURL (CFBundleRef* bundle);

		// extern CFURLRef CFBundleCopyPrivateFrameworksURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyPrivateFrameworksURL (CFBundleRef* bundle);

		// extern CFURLRef CFBundleCopySharedFrameworksURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopySharedFrameworksURL (CFBundleRef* bundle);

		// extern CFURLRef CFBundleCopySharedSupportURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopySharedSupportURL (CFBundleRef* bundle);

		// extern CFURLRef CFBundleCopyBuiltInPlugInsURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyBuiltInPlugInsURL (CFBundleRef* bundle);

		// extern CFDictionaryRef CFBundleCopyInfoDictionaryInDirectory (CFURLRef bundleURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFBundleCopyInfoDictionaryInDirectory (CFURLRef* bundleURL);

		// extern Boolean CFBundleGetPackageInfoInDirectory (CFURLRef url, UInt32 *packageType, UInt32 *packageCreator) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundleGetPackageInfoInDirectory (CFURLRef* url, uint* packageType, uint* packageCreator);

		// extern CFURLRef CFBundleCopyResourceURL (CFBundleRef bundle, CFStringRef resourceName, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyResourceURL (CFBundleRef* bundle, CFStringRef* resourceName, CFStringRef* resourceType, CFStringRef* subDirName);

		// extern CFArrayRef CFBundleCopyResourceURLsOfType (CFBundleRef bundle, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyResourceURLsOfType (CFBundleRef* bundle, CFStringRef* resourceType, CFStringRef* subDirName);

		// extern CFStringRef CFBundleCopyLocalizedString (CFBundleRef bundle, CFStringRef key, CFStringRef value, CFStringRef tableName) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFBundleCopyLocalizedString (CFBundleRef* bundle, CFStringRef* key, CFStringRef* value, CFStringRef* tableName);

		// extern CFURLRef CFBundleCopyResourceURLInDirectory (CFURLRef bundleURL, CFStringRef resourceName, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyResourceURLInDirectory (CFURLRef* bundleURL, CFStringRef* resourceName, CFStringRef* resourceType, CFStringRef* subDirName);

		// extern CFArrayRef CFBundleCopyResourceURLsOfTypeInDirectory (CFURLRef bundleURL, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyResourceURLsOfTypeInDirectory (CFURLRef* bundleURL, CFStringRef* resourceType, CFStringRef* subDirName);

		// extern CFArrayRef CFBundleCopyBundleLocalizations (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyBundleLocalizations (CFBundleRef* bundle);

		// extern CFArrayRef CFBundleCopyPreferredLocalizationsFromArray (CFArrayRef locArray) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyPreferredLocalizationsFromArray (CFArrayRef* locArray);

		// extern CFArrayRef CFBundleCopyLocalizationsForPreferences (CFArrayRef locArray, CFArrayRef prefArray) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyLocalizationsForPreferences (CFArrayRef* locArray, CFArrayRef* prefArray);

		// extern CFURLRef CFBundleCopyResourceURLForLocalization (CFBundleRef bundle, CFStringRef resourceName, CFStringRef resourceType, CFStringRef subDirName, CFStringRef localizationName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyResourceURLForLocalization (CFBundleRef* bundle, CFStringRef* resourceName, CFStringRef* resourceType, CFStringRef* subDirName, CFStringRef* localizationName);

		// extern CFArrayRef CFBundleCopyResourceURLsOfTypeForLocalization (CFBundleRef bundle, CFStringRef resourceType, CFStringRef subDirName, CFStringRef localizationName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyResourceURLsOfTypeForLocalization (CFBundleRef* bundle, CFStringRef* resourceType, CFStringRef* subDirName, CFStringRef* localizationName);

		// extern CFDictionaryRef CFBundleCopyInfoDictionaryForURL (CFURLRef url) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFBundleCopyInfoDictionaryForURL (CFURLRef* url);

		// extern CFArrayRef CFBundleCopyLocalizationsForURL (CFURLRef url) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyLocalizationsForURL (CFURLRef* url);

		// extern CFArrayRef CFBundleCopyExecutableArchitecturesForURL (CFURLRef url) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyExecutableArchitecturesForURL (CFURLRef* url);

		// extern CFURLRef CFBundleCopyExecutableURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyExecutableURL (CFBundleRef* bundle);

		// extern CFArrayRef CFBundleCopyExecutableArchitectures (CFBundleRef bundle) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFBundleCopyExecutableArchitectures (CFBundleRef* bundle);

		// extern Boolean CFBundlePreflightExecutable (CFBundleRef bundle, CFErrorRef *error) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundlePreflightExecutable (CFBundleRef* bundle, CFErrorRef** error);

		// extern Boolean CFBundleLoadExecutableAndReturnError (CFBundleRef bundle, CFErrorRef *error) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundleLoadExecutableAndReturnError (CFBundleRef* bundle, CFErrorRef** error);

		// extern Boolean CFBundleLoadExecutable (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundleLoadExecutable (CFBundleRef* bundle);

		// extern Boolean CFBundleIsExecutableLoaded (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundleIsExecutableLoaded (CFBundleRef* bundle);

		// extern void CFBundleUnloadExecutable (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBundleUnloadExecutable (CFBundleRef* bundle);

		// extern void * CFBundleGetFunctionPointerForName (CFBundleRef bundle, CFStringRef functionName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFBundleGetFunctionPointerForName (CFBundleRef* bundle, CFStringRef* functionName);

		// extern void CFBundleGetFunctionPointersForNames (CFBundleRef bundle, CFArrayRef functionNames, void **ftbl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBundleGetFunctionPointersForNames (CFBundleRef* bundle, CFArrayRef* functionNames, void*[] ftbl);

		// extern void * CFBundleGetDataPointerForName (CFBundleRef bundle, CFStringRef symbolName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFBundleGetDataPointerForName (CFBundleRef* bundle, CFStringRef* symbolName);

		// extern void CFBundleGetDataPointersForNames (CFBundleRef bundle, CFArrayRef symbolNames, void **stbl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFBundleGetDataPointersForNames (CFBundleRef* bundle, CFArrayRef* symbolNames, void*[] stbl);

		// extern CFURLRef CFBundleCopyAuxiliaryExecutableURL (CFBundleRef bundle, CFStringRef executableName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFURLRef* CFBundleCopyAuxiliaryExecutableURL (CFBundleRef* bundle, CFStringRef* executableName);

		// extern Boolean CFBundleIsExecutableLoadable (CFBundleRef bundle) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundleIsExecutableLoadable (CFBundleRef* bundle);

		// extern Boolean CFBundleIsExecutableLoadableForURL (CFURLRef url) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (11,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFBundleIsExecutableLoadableForURL (CFURLRef* url);

		// extern Boolean CFBundleIsArchitectureLoadable (cpu_type_t arch) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (11,0)]
		[DllImport ("__Internal")]
		static extern byte CFBundleIsArchitectureLoadable (int arch);

		// extern CFPlugInRef CFBundleGetPlugIn (CFBundleRef bundle) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFPlugInRef* CFBundleGetPlugIn (CFBundleRef* bundle);

		// extern CFBundleRefNum CFBundleOpenBundleResourceMap (CFBundleRef bundle) __attribute__((availability(macos, introduced=10.0, deprecated=10.15))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "The Carbon Resource Manager is deprecated. This should only be used to access Resource Manager-style resources in old bundles.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "The Carbon Resource Manager is deprecated. This should only be used to access Resource Manager-style resources in old bundles.")]
		[NoWatch, NoTV, NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe int CFBundleOpenBundleResourceMap (CFBundleRef* bundle);

		// extern SInt32 CFBundleOpenBundleResourceFiles (CFBundleRef bundle, CFBundleRefNum *refNum, CFBundleRefNum *localizedRefNum) __attribute__((availability(macos, introduced=10.0, deprecated=10.15))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "The Carbon Resource Manager is deprecated. This should only be used to access Resource Manager-style resources in old bundles.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "The Carbon Resource Manager is deprecated. This should only be used to access Resource Manager-style resources in old bundles.")]
		[NoWatch, NoTV, NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe int CFBundleOpenBundleResourceFiles (CFBundleRef* bundle, int* refNum, int* localizedRefNum);

		// extern void CFBundleCloseBundleResourceMap (CFBundleRef bundle, CFBundleRefNum refNum) __attribute__((availability(macos, introduced=10.0, deprecated=10.15))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "The Carbon Resource Manager is deprecated. This should only be used to access Resource Manager-style resources in old bundles.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "The Carbon Resource Manager is deprecated. This should only be used to access Resource Manager-style resources in old bundles.")]
		[NoWatch, NoTV, NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe void CFBundleCloseBundleResourceMap (CFBundleRef* bundle, int refNum);

		// extern CFTypeID CFMessagePortGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFMessagePortGetTypeID ();

		// extern CFMessagePortRef CFMessagePortCreateLocal (CFAllocatorRef allocator, CFStringRef name, CFMessagePortCallBack callout, CFMessagePortContext *context, Boolean *shouldFreeInfo) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMessagePortRef* CFMessagePortCreateLocal (CFAllocatorRef* allocator, CFStringRef* name, CFMessagePortCallBack* callout, CFMessagePortContext* context, byte* shouldFreeInfo);

		// extern CFMessagePortRef CFMessagePortCreateRemote (CFAllocatorRef allocator, CFStringRef name) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMessagePortRef* CFMessagePortCreateRemote (CFAllocatorRef* allocator, CFStringRef* name);

		// extern Boolean CFMessagePortIsRemote (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFMessagePortIsRemote (CFMessagePortRef* ms);

		// extern CFStringRef CFMessagePortGetName (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFMessagePortGetName (CFMessagePortRef* ms);

		// extern Boolean CFMessagePortSetName (CFMessagePortRef ms, CFStringRef newName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFMessagePortSetName (CFMessagePortRef* ms, CFStringRef* newName);

		// extern void CFMessagePortGetContext (CFMessagePortRef ms, CFMessagePortContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFMessagePortGetContext (CFMessagePortRef* ms, CFMessagePortContext* context);

		// extern void CFMessagePortInvalidate (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFMessagePortInvalidate (CFMessagePortRef* ms);

		// extern Boolean CFMessagePortIsValid (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFMessagePortIsValid (CFMessagePortRef* ms);

		// extern CFMessagePortInvalidationCallBack CFMessagePortGetInvalidationCallBack (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMessagePortInvalidationCallBack* CFMessagePortGetInvalidationCallBack (CFMessagePortRef* ms);

		// extern void CFMessagePortSetInvalidationCallBack (CFMessagePortRef ms, CFMessagePortInvalidationCallBack callout) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFMessagePortSetInvalidationCallBack (CFMessagePortRef* ms, CFMessagePortInvalidationCallBack* callout);

		// extern SInt32 CFMessagePortSendRequest (CFMessagePortRef remote, SInt32 msgid, CFDataRef data, CFTimeInterval sendTimeout, CFTimeInterval rcvTimeout, CFStringRef replyMode, CFDataRef *returnData) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe int CFMessagePortSendRequest (CFMessagePortRef* remote, int msgid, CFDataRef* data, double sendTimeout, double rcvTimeout, CFStringRef* replyMode, CFDataRef** returnData);

		// extern CFRunLoopSourceRef CFMessagePortCreateRunLoopSource (CFAllocatorRef allocator, CFMessagePortRef local, CFIndex order) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFMessagePortCreateRunLoopSource (CFAllocatorRef* allocator, CFMessagePortRef* local, nint order);

		// extern void CFMessagePortSetDispatchQueue (CFMessagePortRef ms, dispatch_queue_t queue) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFMessagePortSetDispatchQueue (CFMessagePortRef* ms, DispatchQueue queue);

		// extern CFTypeID CFPlugInGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFPlugInGetTypeID ();

		// extern CFPlugInRef CFPlugInCreate (CFAllocatorRef allocator, CFURLRef plugInURL) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFPlugInRef* CFPlugInCreate (CFAllocatorRef* allocator, CFURLRef* plugInURL);

		// extern CFBundleRef CFPlugInGetBundle (CFPlugInRef plugIn) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFBundleRef* CFPlugInGetBundle (CFPlugInRef* plugIn);

		// extern void CFPlugInSetLoadOnDemand (CFPlugInRef plugIn, Boolean flag) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPlugInSetLoadOnDemand (CFPlugInRef* plugIn, byte flag);

		// extern Boolean CFPlugInIsLoadOnDemand (CFPlugInRef plugIn) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInIsLoadOnDemand (CFPlugInRef* plugIn);

		// extern CFArrayRef CFPlugInFindFactoriesForPlugInType (CFUUIDRef typeUUID) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFPlugInFindFactoriesForPlugInType (CFUUIDRef* typeUUID);

		// extern CFArrayRef CFPlugInFindFactoriesForPlugInTypeInPlugIn (CFUUIDRef typeUUID, CFPlugInRef plugIn) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFPlugInFindFactoriesForPlugInTypeInPlugIn (CFUUIDRef* typeUUID, CFPlugInRef* plugIn);

		// extern void * CFPlugInInstanceCreate (CFAllocatorRef allocator, CFUUIDRef factoryUUID, CFUUIDRef typeUUID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFPlugInInstanceCreate (CFAllocatorRef* allocator, CFUUIDRef* factoryUUID, CFUUIDRef* typeUUID);

		// extern Boolean CFPlugInRegisterFactoryFunction (CFUUIDRef factoryUUID, CFPlugInFactoryFunction func) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInRegisterFactoryFunction (CFUUIDRef* factoryUUID, CFPlugInFactoryFunction* func);

		// extern Boolean CFPlugInRegisterFactoryFunctionByName (CFUUIDRef factoryUUID, CFPlugInRef plugIn, CFStringRef functionName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInRegisterFactoryFunctionByName (CFUUIDRef* factoryUUID, CFPlugInRef* plugIn, CFStringRef* functionName);

		// extern Boolean CFPlugInUnregisterFactory (CFUUIDRef factoryUUID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInUnregisterFactory (CFUUIDRef* factoryUUID);

		// extern Boolean CFPlugInRegisterPlugInType (CFUUIDRef factoryUUID, CFUUIDRef typeUUID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInRegisterPlugInType (CFUUIDRef* factoryUUID, CFUUIDRef* typeUUID);

		// extern Boolean CFPlugInUnregisterPlugInType (CFUUIDRef factoryUUID, CFUUIDRef typeUUID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInUnregisterPlugInType (CFUUIDRef* factoryUUID, CFUUIDRef* typeUUID);

		// extern void CFPlugInAddInstanceForFactory (CFUUIDRef factoryID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPlugInAddInstanceForFactory (CFUUIDRef* factoryID);

		// extern void CFPlugInRemoveInstanceForFactory (CFUUIDRef factoryID) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFPlugInRemoveInstanceForFactory (CFUUIDRef* factoryID);

		// extern Boolean CFPlugInInstanceGetInterfaceFunctionTable (CFPlugInInstanceRef instance, CFStringRef interfaceName, void **ftbl) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFPlugInInstanceGetInterfaceFunctionTable (CFPlugInInstanceRef* instance, CFStringRef* interfaceName, void** ftbl);

		// extern CFStringRef CFPlugInInstanceGetFactoryName (CFPlugInInstanceRef instance) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFPlugInInstanceGetFactoryName (CFPlugInInstanceRef* instance);

		// extern void * CFPlugInInstanceGetInstanceData (CFPlugInInstanceRef instance) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFPlugInInstanceGetInstanceData (CFPlugInInstanceRef* instance);

		// extern CFTypeID CFPlugInInstanceGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFPlugInInstanceGetTypeID ();

		// extern CFPlugInInstanceRef CFPlugInInstanceCreateWithInstanceDataSize (CFAllocatorRef allocator, CFIndex instanceDataSize, CFPlugInInstanceDeallocateInstanceDataFunction deallocateInstanceFunction, CFStringRef factoryName, CFPlugInInstanceGetInterfaceFunction getInterfaceFunction) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFPlugInInstanceRef* CFPlugInInstanceCreateWithInstanceDataSize (CFAllocatorRef* allocator, nint instanceDataSize, CFPlugInInstanceDeallocateInstanceDataFunction* deallocateInstanceFunction, CFStringRef* factoryName, CFPlugInInstanceGetInterfaceFunction* getInterfaceFunction);

		// extern CFTypeID CFMachPortGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFMachPortGetTypeID ();

		// extern CFMachPortRef CFMachPortCreate (CFAllocatorRef allocator, CFMachPortCallBack callout, CFMachPortContext *context, Boolean *shouldFreeInfo) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMachPortRef* CFMachPortCreate (CFAllocatorRef* allocator, CFMachPortCallBack* callout, CFMachPortContext* context, byte* shouldFreeInfo);

		// extern CFMachPortRef CFMachPortCreateWithPort (CFAllocatorRef allocator, mach_port_t portNum, CFMachPortCallBack callout, CFMachPortContext *context, Boolean *shouldFreeInfo) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMachPortRef* CFMachPortCreateWithPort (CFAllocatorRef* allocator, uint portNum, CFMachPortCallBack* callout, CFMachPortContext* context, byte* shouldFreeInfo);

		// extern mach_port_t CFMachPortGetPort (CFMachPortRef port) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe uint CFMachPortGetPort (CFMachPortRef* port);

		// extern void CFMachPortGetContext (CFMachPortRef port, CFMachPortContext *context) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFMachPortGetContext (CFMachPortRef* port, CFMachPortContext* context);

		// extern void CFMachPortInvalidate (CFMachPortRef port) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFMachPortInvalidate (CFMachPortRef* port);

		// extern Boolean CFMachPortIsValid (CFMachPortRef port) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe byte CFMachPortIsValid (CFMachPortRef* port);

		// extern CFMachPortInvalidationCallBack CFMachPortGetInvalidationCallBack (CFMachPortRef port) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMachPortInvalidationCallBack* CFMachPortGetInvalidationCallBack (CFMachPortRef* port);

		// extern void CFMachPortSetInvalidationCallBack (CFMachPortRef port, CFMachPortInvalidationCallBack callout) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFMachPortSetInvalidationCallBack (CFMachPortRef* port, CFMachPortInvalidationCallBack* callout);

		// extern CFRunLoopSourceRef CFMachPortCreateRunLoopSource (CFAllocatorRef allocator, CFMachPortRef port, CFIndex order) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFMachPortCreateRunLoopSource (CFAllocatorRef* allocator, CFMachPortRef* port, nint order);

		// extern CFTypeID CFAttributedStringGetTypeID () __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern nuint CFAttributedStringGetTypeID ();

		// extern CFAttributedStringRef CFAttributedStringCreate (CFAllocatorRef alloc, CFStringRef str, CFDictionaryRef attributes) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFAttributedStringRef* CFAttributedStringCreate (CFAllocatorRef* alloc, CFStringRef* str, CFDictionaryRef* attributes);

		// extern CFAttributedStringRef CFAttributedStringCreateWithSubstring (CFAllocatorRef alloc, CFAttributedStringRef aStr, CFRange range) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFAttributedStringRef* CFAttributedStringCreateWithSubstring (CFAllocatorRef* alloc, CFAttributedStringRef* aStr, CFRange range);

		// extern CFAttributedStringRef CFAttributedStringCreateCopy (CFAllocatorRef alloc, CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFAttributedStringRef* CFAttributedStringCreateCopy (CFAllocatorRef* alloc, CFAttributedStringRef* aStr);

		// extern CFStringRef CFAttributedStringGetString (CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFAttributedStringGetString (CFAttributedStringRef* aStr);

		// extern CFIndex CFAttributedStringGetLength (CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe nint CFAttributedStringGetLength (CFAttributedStringRef* aStr);

		// extern CFDictionaryRef CFAttributedStringGetAttributes (CFAttributedStringRef aStr, CFIndex loc, CFRange *effectiveRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFAttributedStringGetAttributes (CFAttributedStringRef* aStr, nint loc, CFRange* effectiveRange);

		// extern CFTypeRef CFAttributedStringGetAttribute (CFAttributedStringRef aStr, CFIndex loc, CFStringRef attrName, CFRange *effectiveRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFAttributedStringGetAttribute (CFAttributedStringRef* aStr, nint loc, CFStringRef* attrName, CFRange* effectiveRange);

		// extern CFDictionaryRef CFAttributedStringGetAttributesAndLongestEffectiveRange (CFAttributedStringRef aStr, CFIndex loc, CFRange inRange, CFRange *longestEffectiveRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFAttributedStringGetAttributesAndLongestEffectiveRange (CFAttributedStringRef* aStr, nint loc, CFRange inRange, CFRange* longestEffectiveRange);

		// extern CFTypeRef CFAttributedStringGetAttributeAndLongestEffectiveRange (CFAttributedStringRef aStr, CFIndex loc, CFStringRef attrName, CFRange inRange, CFRange *longestEffectiveRange) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void* CFAttributedStringGetAttributeAndLongestEffectiveRange (CFAttributedStringRef* aStr, nint loc, CFStringRef* attrName, CFRange inRange, CFRange* longestEffectiveRange);

		// extern CFMutableAttributedStringRef CFAttributedStringCreateMutableCopy (CFAllocatorRef alloc, CFIndex maxLength, CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableAttributedStringRef* CFAttributedStringCreateMutableCopy (CFAllocatorRef* alloc, nint maxLength, CFAttributedStringRef* aStr);

		// extern CFMutableAttributedStringRef CFAttributedStringCreateMutable (CFAllocatorRef alloc, CFIndex maxLength) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableAttributedStringRef* CFAttributedStringCreateMutable (CFAllocatorRef* alloc, nint maxLength);

		// extern void CFAttributedStringReplaceString (CFMutableAttributedStringRef aStr, CFRange range, CFStringRef replacement) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringReplaceString (CFMutableAttributedStringRef* aStr, CFRange range, CFStringRef* replacement);

		// extern CFMutableStringRef CFAttributedStringGetMutableString (CFMutableAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe CFMutableStringRef* CFAttributedStringGetMutableString (CFMutableAttributedStringRef* aStr);

		// extern void CFAttributedStringSetAttributes (CFMutableAttributedStringRef aStr, CFRange range, CFDictionaryRef replacement, Boolean clearOtherAttributes) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringSetAttributes (CFMutableAttributedStringRef* aStr, CFRange range, CFDictionaryRef* replacement, byte clearOtherAttributes);

		// extern void CFAttributedStringSetAttribute (CFMutableAttributedStringRef aStr, CFRange range, CFStringRef attrName, CFTypeRef value) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringSetAttribute (CFMutableAttributedStringRef* aStr, CFRange range, CFStringRef* attrName, void* value);

		// extern void CFAttributedStringRemoveAttribute (CFMutableAttributedStringRef aStr, CFRange range, CFStringRef attrName) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringRemoveAttribute (CFMutableAttributedStringRef* aStr, CFRange range, CFStringRef* attrName);

		// extern void CFAttributedStringReplaceAttributedString (CFMutableAttributedStringRef aStr, CFRange range, CFAttributedStringRef replacement) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringReplaceAttributedString (CFMutableAttributedStringRef* aStr, CFRange range, CFAttributedStringRef* replacement);

		// extern void CFAttributedStringBeginEditing (CFMutableAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringBeginEditing (CFMutableAttributedStringRef* aStr);

		// extern void CFAttributedStringEndEditing (CFMutableAttributedStringRef aStr) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		static extern unsafe void CFAttributedStringEndEditing (CFMutableAttributedStringRef* aStr);

		// extern CFTypeID CFURLEnumeratorGetTypeID () __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern nuint CFURLEnumeratorGetTypeID ();

		// extern CFURLEnumeratorRef CFURLEnumeratorCreateForDirectoryURL (CFAllocatorRef alloc, CFURLRef directoryURL, CFURLEnumeratorOptions option, CFArrayRef propertyKeys) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLEnumeratorRef* CFURLEnumeratorCreateForDirectoryURL (CFAllocatorRef* alloc, CFURLRef* directoryURL, CFURLEnumeratorOptions option, CFArrayRef* propertyKeys);

		// extern CFURLEnumeratorRef CFURLEnumeratorCreateForMountedVolumes (CFAllocatorRef alloc, CFURLEnumeratorOptions option, CFArrayRef propertyKeys) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLEnumeratorRef* CFURLEnumeratorCreateForMountedVolumes (CFAllocatorRef* alloc, CFURLEnumeratorOptions option, CFArrayRef* propertyKeys);

		// extern CFURLEnumeratorResult CFURLEnumeratorGetNextURL (CFURLEnumeratorRef enumerator, CFURLRef *url, CFErrorRef *error) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFURLEnumeratorResult CFURLEnumeratorGetNextURL (CFURLEnumeratorRef* enumerator, CFURLRef** url, CFErrorRef** error);

		// extern void CFURLEnumeratorSkipDescendents (CFURLEnumeratorRef enumerator) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFURLEnumeratorSkipDescendents (CFURLEnumeratorRef* enumerator);

		// extern CFIndex CFURLEnumeratorGetDescendentLevel (CFURLEnumeratorRef enumerator) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFURLEnumeratorGetDescendentLevel (CFURLEnumeratorRef* enumerator);

		// extern Boolean CFURLEnumeratorGetSourceDidChange (CFURLEnumeratorRef enumerator) __attribute__((availability(macos, introduced=10.6, deprecated=10.7))) __attribute__((availability(ios, introduced=4.0, deprecated=5.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use File System Events API instead")]
		[Deprecated (PlatformName.MacOSX, 10, 7, message: "Use File System Events API instead")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use File System Events API instead")]
		[Deprecated (PlatformName.iOS, 5, 0, message: "Use File System Events API instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use File System Events API instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use File System Events API instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use File System Events API instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use File System Events API instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFURLEnumeratorGetSourceDidChange (CFURLEnumeratorRef* enumerator);

		// extern acl_t acl_dup (acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_dup (acl_t* acl);

		// extern int acl_free (void *obj_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_free (void* obj_p);

		// extern acl_t acl_init (int count);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_init (int count);

		// extern int acl_copy_entry (acl_entry_t dest_d, acl_entry_t src_d);
		[DllImport ("__Internal")]
		static extern unsafe int acl_copy_entry (acl_entry_t* dest_d, acl_entry_t* src_d);

		// extern int acl_create_entry (acl_t *acl_p, acl_entry_t *entry_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_create_entry (acl_t** acl_p, acl_entry_t** entry_p);

		// extern int acl_create_entry_np (acl_t *acl_p, acl_entry_t *entry_p, int entry_index);
		[DllImport ("__Internal")]
		static extern unsafe int acl_create_entry_np (acl_t** acl_p, acl_entry_t** entry_p, int entry_index);

		// extern int acl_delete_entry (acl_t acl, acl_entry_t entry_d);
		[DllImport ("__Internal")]
		static extern unsafe int acl_delete_entry (acl_t* acl, acl_entry_t* entry_d);

		// extern int acl_get_entry (acl_t acl, int entry_id, acl_entry_t *entry_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_entry (acl_t* acl, int entry_id, acl_entry_t** entry_p);

		// extern int acl_valid (acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_valid (acl_t* acl);

		// extern int acl_valid_fd_np (int fd, acl_type_t type, acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_valid_fd_np (int fd, acl_type_t type, acl_t* acl);

		// extern int acl_valid_file_np (const char *path, acl_type_t type, acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_valid_file_np (sbyte* path, acl_type_t type, acl_t* acl);

		// extern int acl_valid_link_np (const char *path, acl_type_t type, acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_valid_link_np (sbyte* path, acl_type_t type, acl_t* acl);

		// extern int acl_add_perm (acl_permset_t permset_d, acl_perm_t perm);
		[DllImport ("__Internal")]
		static extern unsafe int acl_add_perm (acl_permset_t* permset_d, acl_perm_t perm);

		// extern int acl_calc_mask (acl_t *acl_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_calc_mask (acl_t** acl_p);

		// extern int acl_clear_perms (acl_permset_t permset_d);
		[DllImport ("__Internal")]
		static extern unsafe int acl_clear_perms (acl_permset_t* permset_d);

		// extern int acl_delete_perm (acl_permset_t permset_d, acl_perm_t perm);
		[DllImport ("__Internal")]
		static extern unsafe int acl_delete_perm (acl_permset_t* permset_d, acl_perm_t perm);

		// extern int acl_get_perm_np (acl_permset_t permset_d, acl_perm_t perm);
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_perm_np (acl_permset_t* permset_d, acl_perm_t perm);

		// extern int acl_get_permset (acl_entry_t entry_d, acl_permset_t *permset_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_permset (acl_entry_t* entry_d, acl_permset_t** permset_p);

		// extern int acl_set_permset (acl_entry_t entry_d, acl_permset_t permset_d);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_permset (acl_entry_t* entry_d, acl_permset_t* permset_d);

		// extern int acl_maximal_permset_mask_np (acl_permset_mask_t *mask_p) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe int acl_maximal_permset_mask_np (ulong* mask_p);

		// extern int acl_get_permset_mask_np (acl_entry_t entry_d, acl_permset_mask_t *mask_p) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_permset_mask_np (acl_entry_t* entry_d, ulong* mask_p);

		// extern int acl_set_permset_mask_np (acl_entry_t entry_d, acl_permset_mask_t mask) __attribute__((availability(ios, introduced=4.3)));
		[iOS (4,3)]
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_permset_mask_np (acl_entry_t* entry_d, ulong mask);

		// extern int acl_add_flag_np (acl_flagset_t flagset_d, acl_flag_t flag);
		[DllImport ("__Internal")]
		static extern unsafe int acl_add_flag_np (acl_flagset_t* flagset_d, acl_flag_t flag);

		// extern int acl_clear_flags_np (acl_flagset_t flagset_d);
		[DllImport ("__Internal")]
		static extern unsafe int acl_clear_flags_np (acl_flagset_t* flagset_d);

		// extern int acl_delete_flag_np (acl_flagset_t flagset_d, acl_flag_t flag);
		[DllImport ("__Internal")]
		static extern unsafe int acl_delete_flag_np (acl_flagset_t* flagset_d, acl_flag_t flag);

		// extern int acl_get_flag_np (acl_flagset_t flagset_d, acl_flag_t flag);
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_flag_np (acl_flagset_t* flagset_d, acl_flag_t flag);

		// extern int acl_get_flagset_np (void *obj_p, acl_flagset_t *flagset_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_flagset_np (void* obj_p, acl_flagset_t** flagset_p);

		// extern int acl_set_flagset_np (void *obj_p, acl_flagset_t flagset_d);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_flagset_np (void* obj_p, acl_flagset_t* flagset_d);

		// extern void * acl_get_qualifier (acl_entry_t entry_d);
		[DllImport ("__Internal")]
		static extern unsafe void* acl_get_qualifier (acl_entry_t* entry_d);

		// extern int acl_get_tag_type (acl_entry_t entry_d, acl_tag_t *tag_type_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_get_tag_type (acl_entry_t* entry_d, acl_tag_t* tag_type_p);

		// extern int acl_set_qualifier (acl_entry_t entry_d, const void *tag_qualifier_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_qualifier (acl_entry_t* entry_d, void* tag_qualifier_p);

		// extern int acl_set_tag_type (acl_entry_t entry_d, acl_tag_t tag_type);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_tag_type (acl_entry_t* entry_d, acl_tag_t tag_type);

		// extern int acl_delete_def_file (const char *path_p);
		[DllImport ("__Internal")]
		static extern unsafe int acl_delete_def_file (sbyte* path_p);

		// extern acl_t acl_get_fd (int fd);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_get_fd (int fd);

		// extern acl_t acl_get_fd_np (int fd, acl_type_t type);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_get_fd_np (int fd, acl_type_t type);

		// extern acl_t acl_get_file (const char *path_p, acl_type_t type);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_get_file (sbyte* path_p, acl_type_t type);

		// extern acl_t acl_get_link_np (const char *path_p, acl_type_t type);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_get_link_np (sbyte* path_p, acl_type_t type);

		// extern int acl_set_fd (int fd, acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_fd (int fd, acl_t* acl);

		// extern int acl_set_fd_np (int fd, acl_t acl, acl_type_t acl_type);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_fd_np (int fd, acl_t* acl, acl_type_t acl_type);

		// extern int acl_set_file (const char *path_p, acl_type_t type, acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_file (sbyte* path_p, acl_type_t type, acl_t* acl);

		// extern int acl_set_link_np (const char *path_p, acl_type_t type, acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe int acl_set_link_np (sbyte* path_p, acl_type_t type, acl_t* acl);

		// extern ssize_t acl_copy_ext (void *buf_p, acl_t acl, ssize_t size);
		[DllImport ("__Internal")]
		static extern unsafe nint acl_copy_ext (void* buf_p, acl_t* acl, nint size);

		// extern ssize_t acl_copy_ext_native (void *buf_p, acl_t acl, ssize_t size);
		[DllImport ("__Internal")]
		static extern unsafe nint acl_copy_ext_native (void* buf_p, acl_t* acl, nint size);

		// extern acl_t acl_copy_int (const void *buf_p);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_copy_int (void* buf_p);

		// extern acl_t acl_copy_int_native (const void *buf_p);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_copy_int_native (void* buf_p);

		// extern acl_t acl_from_text (const char *buf_p);
		[DllImport ("__Internal")]
		static extern unsafe acl_t* acl_from_text (sbyte* buf_p);

		// extern ssize_t acl_size (acl_t acl);
		[DllImport ("__Internal")]
		static extern unsafe nint acl_size (acl_t* acl);

		// extern char * acl_to_text (acl_t acl, ssize_t *len_p);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* acl_to_text (acl_t* acl, nint* len_p);

		// extern CFTypeID CFFileSecurityGetTypeID () __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern nuint CFFileSecurityGetTypeID ();

		// extern CFFileSecurityRef CFFileSecurityCreate (CFAllocatorRef allocator) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFFileSecurityRef* CFFileSecurityCreate (CFAllocatorRef* allocator);

		// extern CFFileSecurityRef CFFileSecurityCreateCopy (CFAllocatorRef allocator, CFFileSecurityRef fileSec) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFFileSecurityRef* CFFileSecurityCreateCopy (CFAllocatorRef* allocator, CFFileSecurityRef* fileSec);

		// extern Boolean CFFileSecurityCopyOwnerUUID (CFFileSecurityRef fileSec, CFUUIDRef *ownerUUID) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityCopyOwnerUUID (CFFileSecurityRef* fileSec, CFUUIDRef** ownerUUID);

		// extern Boolean CFFileSecuritySetOwnerUUID (CFFileSecurityRef fileSec, CFUUIDRef ownerUUID) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecuritySetOwnerUUID (CFFileSecurityRef* fileSec, CFUUIDRef* ownerUUID);

		// extern Boolean CFFileSecurityCopyGroupUUID (CFFileSecurityRef fileSec, CFUUIDRef *groupUUID) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityCopyGroupUUID (CFFileSecurityRef* fileSec, CFUUIDRef** groupUUID);

		// extern Boolean CFFileSecuritySetGroupUUID (CFFileSecurityRef fileSec, CFUUIDRef groupUUID) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecuritySetGroupUUID (CFFileSecurityRef* fileSec, CFUUIDRef* groupUUID);

		// extern Boolean CFFileSecurityCopyAccessControlList (CFFileSecurityRef fileSec, acl_t *accessControlList) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityCopyAccessControlList (CFFileSecurityRef* fileSec, acl_t** accessControlList);

		// extern Boolean CFFileSecuritySetAccessControlList (CFFileSecurityRef fileSec, acl_t accessControlList) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecuritySetAccessControlList (CFFileSecurityRef* fileSec, acl_t* accessControlList);

		// extern Boolean CFFileSecurityGetOwner (CFFileSecurityRef fileSec, uid_t *owner) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityGetOwner (CFFileSecurityRef* fileSec, uint* owner);

		// extern Boolean CFFileSecuritySetOwner (CFFileSecurityRef fileSec, uid_t owner) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecuritySetOwner (CFFileSecurityRef* fileSec, uint owner);

		// extern Boolean CFFileSecurityGetGroup (CFFileSecurityRef fileSec, gid_t *group) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityGetGroup (CFFileSecurityRef* fileSec, uint* group);

		// extern Boolean CFFileSecuritySetGroup (CFFileSecurityRef fileSec, gid_t group) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecuritySetGroup (CFFileSecurityRef* fileSec, uint group);

		// extern Boolean CFFileSecurityGetMode (CFFileSecurityRef fileSec, mode_t *mode) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityGetMode (CFFileSecurityRef* fileSec, ushort* mode);

		// extern Boolean CFFileSecuritySetMode (CFFileSecurityRef fileSec, mode_t mode) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecuritySetMode (CFFileSecurityRef* fileSec, ushort mode);

		// extern Boolean CFFileSecurityClearProperties (CFFileSecurityRef fileSec, CFFileSecurityClearOptions clearPropertyMask) __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=6.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,8), iOS (6,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileSecurityClearProperties (CFFileSecurityRef* fileSec, CFFileSecurityClearOptions clearPropertyMask);

		// extern CFStringRef CFStringTokenizerCopyBestStringLanguage (CFStringRef string, CFRange range) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFStringTokenizerCopyBestStringLanguage (CFStringRef* @string, CFRange range);

		// extern CFTypeID CFStringTokenizerGetTypeID () __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern nuint CFStringTokenizerGetTypeID ();

		// extern CFStringTokenizerRef CFStringTokenizerCreate (CFAllocatorRef alloc, CFStringRef string, CFRange range, CFOptionFlags options, CFLocaleRef locale) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringTokenizerRef* CFStringTokenizerCreate (CFAllocatorRef* alloc, CFStringRef* @string, CFRange range, nuint options, CFLocaleRef* locale);

		// extern void CFStringTokenizerSetString (CFStringTokenizerRef tokenizer, CFStringRef string, CFRange range) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFStringTokenizerSetString (CFStringTokenizerRef* tokenizer, CFStringRef* @string, CFRange range);

		// extern CFStringTokenizerTokenType CFStringTokenizerGoToTokenAtIndex (CFStringTokenizerRef tokenizer, CFIndex index) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringTokenizerTokenType CFStringTokenizerGoToTokenAtIndex (CFStringTokenizerRef* tokenizer, nint index);

		// extern CFStringTokenizerTokenType CFStringTokenizerAdvanceToNextToken (CFStringTokenizerRef tokenizer) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringTokenizerTokenType CFStringTokenizerAdvanceToNextToken (CFStringTokenizerRef* tokenizer);

		// extern CFRange CFStringTokenizerGetCurrentTokenRange (CFStringTokenizerRef tokenizer) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRange CFStringTokenizerGetCurrentTokenRange (CFStringTokenizerRef* tokenizer);

		// extern CFTypeRef CFStringTokenizerCopyCurrentTokenAttribute (CFStringTokenizerRef tokenizer, CFOptionFlags attribute) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe void* CFStringTokenizerCopyCurrentTokenAttribute (CFStringTokenizerRef* tokenizer, nuint attribute);

		// extern CFIndex CFStringTokenizerGetCurrentSubTokens (CFStringTokenizerRef tokenizer, CFRange *ranges, CFIndex maxRangeLength, CFMutableArrayRef derivedSubTokens) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFStringTokenizerGetCurrentSubTokens (CFStringTokenizerRef* tokenizer, CFRange* ranges, nint maxRangeLength, CFMutableArrayRef* derivedSubTokens);

		// extern CFTypeID CFFileDescriptorGetTypeID () __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint CFFileDescriptorGetTypeID ();

		// extern CFFileDescriptorRef CFFileDescriptorCreate (CFAllocatorRef allocator, CFFileDescriptorNativeDescriptor fd, Boolean closeOnInvalidate, CFFileDescriptorCallBack callout, const CFFileDescriptorContext *context) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFFileDescriptorRef* CFFileDescriptorCreate (CFAllocatorRef* allocator, int fd, byte closeOnInvalidate, CFFileDescriptorCallBack* callout, CFFileDescriptorContext* context);

		// extern CFFileDescriptorNativeDescriptor CFFileDescriptorGetNativeDescriptor (CFFileDescriptorRef f) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int CFFileDescriptorGetNativeDescriptor (CFFileDescriptorRef* f);

		// extern void CFFileDescriptorGetContext (CFFileDescriptorRef f, CFFileDescriptorContext *context) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFFileDescriptorGetContext (CFFileDescriptorRef* f, CFFileDescriptorContext* context);

		// extern void CFFileDescriptorEnableCallBacks (CFFileDescriptorRef f, CFOptionFlags callBackTypes) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFFileDescriptorEnableCallBacks (CFFileDescriptorRef* f, nuint callBackTypes);

		// extern void CFFileDescriptorDisableCallBacks (CFFileDescriptorRef f, CFOptionFlags callBackTypes) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFFileDescriptorDisableCallBacks (CFFileDescriptorRef* f, nuint callBackTypes);

		// extern void CFFileDescriptorInvalidate (CFFileDescriptorRef f) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFFileDescriptorInvalidate (CFFileDescriptorRef* f);

		// extern Boolean CFFileDescriptorIsValid (CFFileDescriptorRef f) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFFileDescriptorIsValid (CFFileDescriptorRef* f);

		// extern CFRunLoopSourceRef CFFileDescriptorCreateRunLoopSource (CFAllocatorRef allocator, CFFileDescriptorRef f, CFIndex order) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((cf_audited_transfer));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFFileDescriptorCreateRunLoopSource (CFAllocatorRef* allocator, CFFileDescriptorRef* f, nint order);

		// extern CFTypeID CFUserNotificationGetTypeID () __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern nuint CFUserNotificationGetTypeID ();

		// extern CFUserNotificationRef CFUserNotificationCreate (CFAllocatorRef allocator, CFTimeInterval timeout, CFOptionFlags flags, SInt32 *error, CFDictionaryRef dictionary) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFUserNotificationRef* CFUserNotificationCreate (CFAllocatorRef* allocator, double timeout, nuint flags, int* error, CFDictionaryRef* dictionary);

		// extern SInt32 CFUserNotificationReceiveResponse (CFUserNotificationRef userNotification, CFTimeInterval timeout, CFOptionFlags *responseFlags) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int CFUserNotificationReceiveResponse (CFUserNotificationRef* userNotification, double timeout, nuint* responseFlags);

		// extern CFStringRef CFUserNotificationGetResponseValue (CFUserNotificationRef userNotification, CFStringRef key, CFIndex idx) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFUserNotificationGetResponseValue (CFUserNotificationRef* userNotification, CFStringRef* key, nint idx);

		// extern CFDictionaryRef CFUserNotificationGetResponseDictionary (CFUserNotificationRef userNotification) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDictionaryRef* CFUserNotificationGetResponseDictionary (CFUserNotificationRef* userNotification);

		// extern SInt32 CFUserNotificationUpdate (CFUserNotificationRef userNotification, CFTimeInterval timeout, CFOptionFlags flags, CFDictionaryRef dictionary) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int CFUserNotificationUpdate (CFUserNotificationRef* userNotification, double timeout, nuint flags, CFDictionaryRef* dictionary);

		// extern SInt32 CFUserNotificationCancel (CFUserNotificationRef userNotification) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int CFUserNotificationCancel (CFUserNotificationRef* userNotification);

		// extern CFRunLoopSourceRef CFUserNotificationCreateRunLoopSource (CFAllocatorRef allocator, CFUserNotificationRef userNotification, CFUserNotificationCallBack callout, CFIndex order) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFUserNotificationCreateRunLoopSource (CFAllocatorRef* allocator, CFUserNotificationRef* userNotification, CFUserNotificationCallBack* callout, nint order);

		// extern SInt32 CFUserNotificationDisplayNotice (CFTimeInterval timeout, CFOptionFlags flags, CFURLRef iconURL, CFURLRef soundURL, CFURLRef localizationURL, CFStringRef alertHeader, CFStringRef alertMessage, CFStringRef defaultButtonTitle) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int CFUserNotificationDisplayNotice (double timeout, nuint flags, CFURLRef* iconURL, CFURLRef* soundURL, CFURLRef* localizationURL, CFStringRef* alertHeader, CFStringRef* alertMessage, CFStringRef* defaultButtonTitle);

		// extern SInt32 CFUserNotificationDisplayAlert (CFTimeInterval timeout, CFOptionFlags flags, CFURLRef iconURL, CFURLRef soundURL, CFURLRef localizationURL, CFStringRef alertHeader, CFStringRef alertMessage, CFStringRef defaultButtonTitle, CFStringRef alternateButtonTitle, CFStringRef otherButtonTitle, CFOptionFlags *responseFlags) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe int CFUserNotificationDisplayAlert (double timeout, nuint flags, CFURLRef* iconURL, CFURLRef* soundURL, CFURLRef* localizationURL, CFStringRef* alertHeader, CFStringRef* alertMessage, CFStringRef* defaultButtonTitle, CFStringRef* alternateButtonTitle, CFStringRef* otherButtonTitle, nuint* responseFlags);

		// CFOptionFlags CFUserNotificationCheckBoxChecked (CFIndex i) __attribute__((always_inline)) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern nuint CFUserNotificationCheckBoxChecked (nint i);

		// CFOptionFlags CFUserNotificationSecureTextField (CFIndex i) __attribute__((always_inline)) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern nuint CFUserNotificationSecureTextField (nint i);

		// CFOptionFlags CFUserNotificationPopUpSelection (CFIndex n) __attribute__((always_inline)) __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, NoiOS, Mac (10,0)]
		[DllImport ("__Internal")]
		static extern nuint CFUserNotificationPopUpSelection (nint n);

		// extern NSString * _Nonnull NSStringFromSelector (SEL _Nonnull aSelector);
		[DllImport ("__Internal")]
		static extern NSString NSStringFromSelector (Selector aSelector);

		// extern SEL _Nonnull NSSelectorFromString (NSString * _Nonnull aSelectorName);
		[DllImport ("__Internal")]
		static extern Selector NSSelectorFromString (NSString aSelectorName);

		// extern NSString * _Nonnull NSStringFromClass (Class _Nonnull aClass);
		[DllImport ("__Internal")]
		static extern NSString NSStringFromClass (Class aClass);

		// extern Class _Nullable NSClassFromString (NSString * _Nonnull aClassName);
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern Class NSClassFromString (NSString aClassName);

		// extern NSString * _Nonnull NSStringFromProtocol (Protocol * _Nonnull proto) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern NSString NSStringFromProtocol (Protocol proto);

		// extern Protocol * _Nullable NSProtocolFromString (NSString * _Nonnull namestr) __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern Protocol NSProtocolFromString (NSString namestr);

		// extern const char * _Nonnull NSGetSizeAndAlignment (const char * _Nonnull typePtr, NSUInteger * _Nullable sizep, NSUInteger * _Nullable alignp);
		[DllImport ("__Internal")]
		static extern unsafe sbyte* NSGetSizeAndAlignment (sbyte* typePtr, [NullAllowed] nuint* sizep, [NullAllowed] nuint* alignp);

		// extern void NSLog (id, ...)  __attribute__((format(NSString, 1, 2)));
		[DllImport ("__Internal")]
		static extern void NSLog (NSObject, IntPtr varArgs);

		// extern void NSLog (NSString * _Nonnull format, ...)  __attribute__((format(NSString, 1, 2))) __attribute__((not_tail_called));
		[DllImport ("__Internal")]
		static extern void NSLog (NSString format, IntPtr varArgs);

		// extern void NSLogv (id, __builtin_va_list)  __attribute__((format(NSString, 1, 0)));
		[DllImport ("__Internal")]
		static extern unsafe void NSLogv (NSObject, sbyte*);

		// extern void NSLogv (NSString * _Nonnull format, va_list args)  __attribute__((format(NSString, 1, 0))) __attribute__((not_tail_called));
		[DllImport ("__Internal")]
		static extern unsafe void NSLogv (NSString format, sbyte* args);

		// extern NSZone * _Nonnull NSDefaultMallocZone () __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe NSZone* NSDefaultMallocZone ();

		// extern NSZone * _Nonnull NSCreateZone (NSUInteger startSize, NSUInteger granularity, BOOL canFree) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe NSZone* NSCreateZone (nuint startSize, nuint granularity, bool canFree);

		// extern void NSRecycleZone (NSZone * _Nonnull zone) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe void NSRecycleZone (NSZone* zone);

		// extern void NSSetZoneName (NSZone * _Nullable zone, NSString * _Nonnull name) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe void NSSetZoneName ([NullAllowed] NSZone* zone, NSString name);

		// extern NSString * _Nonnull NSZoneName (NSZone * _Nullable zone) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe NSString NSZoneName ([NullAllowed] NSZone* zone);

		// extern NSZone * _Nullable NSZoneFromPointer (void * _Nonnull ptr) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe NSZone* NSZoneFromPointer (void* ptr);

		// extern void * _Nonnull NSZoneMalloc (NSZone * _Nullable zone, NSUInteger size) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe void* NSZoneMalloc ([NullAllowed] NSZone* zone, nuint size);

		// extern void * _Nonnull NSZoneCalloc (NSZone * _Nullable zone, NSUInteger numElems, NSUInteger byteSize) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe void* NSZoneCalloc ([NullAllowed] NSZone* zone, nuint numElems, nuint byteSize);

		// extern void * _Nonnull NSZoneRealloc (NSZone * _Nullable zone, void * _Nullable ptr, NSUInteger size) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe void* NSZoneRealloc ([NullAllowed] NSZone* zone, [NullAllowed] void* ptr, nuint size);

		// extern void NSZoneFree (NSZone * _Nullable zone, void * _Nonnull ptr) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		static extern unsafe void NSZoneFree ([NullAllowed] NSZone* zone, void* ptr);

		// id _Nullable NSMakeCollectable (CF_CONSUMED CFTypeRef cf) __attribute__((always_inline)) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained)) __attribute__((availability(swift, unavailable)));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe NSObject NSMakeCollectable (void* cf);

		// id _Nullable NSMakeCollectable (CF_CONSUMED CFTypeRef cf) __attribute__((availability(swift, unavailable))) __attribute__((always_inline)) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Unavailable (PlatformName.Swift)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe NSObject NSMakeCollectable (void* cf);

		// extern NSUInteger NSPageSize ();
		[DllImport ("__Internal")]
		static extern nuint NSPageSize ();

		// extern NSUInteger NSLogPageSize ();
		[DllImport ("__Internal")]
		static extern nuint NSLogPageSize ();

		// extern NSUInteger NSRoundUpToMultipleOfPageSize (NSUInteger bytes);
		[DllImport ("__Internal")]
		static extern nuint NSRoundUpToMultipleOfPageSize (nuint bytes);

		// extern NSUInteger NSRoundDownToMultipleOfPageSize (NSUInteger bytes);
		[DllImport ("__Internal")]
		static extern nuint NSRoundDownToMultipleOfPageSize (nuint bytes);

		// extern void * _Nonnull NSAllocateMemoryPages (NSUInteger bytes);
		[DllImport ("__Internal")]
		static extern unsafe void* NSAllocateMemoryPages (nuint bytes);

		// extern void NSDeallocateMemoryPages (void * _Nonnull ptr, NSUInteger bytes);
		[DllImport ("__Internal")]
		static extern unsafe void NSDeallocateMemoryPages (void* ptr, nuint bytes);

		// extern void NSCopyMemoryPages (const void * _Nonnull source, void * _Nonnull dest, NSUInteger bytes);
		[DllImport ("__Internal")]
		static extern unsafe void NSCopyMemoryPages (void* source, void* dest, nuint bytes);

		// extern NSUInteger NSRealMemoryAvailable () __attribute__((availability(macos, introduced=10.0, deprecated=10.8))) __attribute__((availability(ios, introduced=2.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSProcessInfo instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSProcessInfo instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSProcessInfo instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSProcessInfo instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSProcessInfo instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSProcessInfo instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSProcessInfo instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSProcessInfo instead")]
		[DllImport ("__Internal")]
		static extern nuint NSRealMemoryAvailable ();

		// extern id _Nonnull NSAllocateObject (Class _Nonnull aClass, NSUInteger extraBytes, NSZone * _Nullable zone);
		[DllImport ("__Internal")]
		static extern unsafe NSObject NSAllocateObject (Class aClass, nuint extraBytes, [NullAllowed] NSZone* zone);

		// extern void NSDeallocateObject (id _Nonnull object);
		[DllImport ("__Internal")]
		static extern void NSDeallocateObject (NSObject @object);

		// extern id _Nonnull NSCopyObject (id _Nonnull object, NSUInteger extraBytes, NSZone * _Nullable zone) __attribute__((availability(macos, introduced=10.0, deprecated=10.8))) __attribute__((availability(ios, introduced=2.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Not supported")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Not supported")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[DllImport ("__Internal")]
		static extern unsafe NSObject NSCopyObject (NSObject @object, nuint extraBytes, [NullAllowed] NSZone* zone);

		// extern BOOL NSShouldRetainWithZone (id _Nonnull anObject, NSZone * _Nullable requestedZone);
		[DllImport ("__Internal")]
		static extern unsafe bool NSShouldRetainWithZone (NSObject anObject, [NullAllowed] NSZone* requestedZone);

		// extern void NSIncrementExtraRefCount (id _Nonnull object);
		[DllImport ("__Internal")]
		static extern void NSIncrementExtraRefCount (NSObject @object);

		// extern BOOL NSDecrementExtraRefCountWasZero (id _Nonnull object);
		[DllImport ("__Internal")]
		static extern bool NSDecrementExtraRefCountWasZero (NSObject @object);

		// extern NSUInteger NSExtraRefCount (id _Nonnull object);
		[DllImport ("__Internal")]
		static extern nuint NSExtraRefCount (NSObject @object);

		// CFTypeRef _Nullable CFBridgingRetain (id _Nullable X) __attribute__((always_inline)) __attribute__((cf_returns_retained));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* CFBridgingRetain ([NullAllowed] NSObject X);

		// id _Nullable CFBridgingRelease (CFTypeRef _Nullable X) __attribute__((always_inline)) __attribute__((ns_returns_retained));
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe NSObject CFBridgingRelease ([NullAllowed] void* X);

		// NSRange NSMakeRange (NSUInteger loc, NSUInteger len) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSRange NSMakeRange (nuint loc, nuint len);

		// NSUInteger NSMaxRange (NSRange range) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nuint NSMaxRange (NSRange range);

		// BOOL NSLocationInRange (NSUInteger loc, NSRange range) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern bool NSLocationInRange (nuint loc, NSRange range);

		// BOOL NSEqualRanges (NSRange range1, NSRange range2) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern bool NSEqualRanges (NSRange range1, NSRange range2);

		// extern NSRange NSUnionRange (NSRange range1, NSRange range2);
		[DllImport ("__Internal")]
		static extern NSRange NSUnionRange (NSRange range1, NSRange range2);

		// extern NSRange NSIntersectionRange (NSRange range1, NSRange range2);
		[DllImport ("__Internal")]
		static extern NSRange NSIntersectionRange (NSRange range1, NSRange range2);

		// extern NSString * _Nonnull NSStringFromRange (NSRange range);
		[DllImport ("__Internal")]
		static extern NSString NSStringFromRange (NSRange range);

		// extern NSRange NSRangeFromString (NSString * _Nonnull aString);
		[DllImport ("__Internal")]
		static extern NSRange NSRangeFromString (NSString aString);

		// long NSHostByteOrder () __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nint NSHostByteOrder ();

		// unsigned short NSSwapShort (unsigned short inv) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort NSSwapShort (ushort inv);

		// unsigned int NSSwapInt (unsigned int inv) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint NSSwapInt (uint inv);

		// unsigned long NSSwapLong (unsigned long inv) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nuint NSSwapLong (nuint inv);

		// unsigned long long NSSwapLongLong (unsigned long long inv) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong NSSwapLongLong (ulong inv);

		// unsigned short NSSwapBigShortToHost (unsigned short x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort NSSwapBigShortToHost (ushort x);

		// unsigned int NSSwapBigIntToHost (unsigned int x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint NSSwapBigIntToHost (uint x);

		// unsigned long NSSwapBigLongToHost (unsigned long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nuint NSSwapBigLongToHost (nuint x);

		// unsigned long long NSSwapBigLongLongToHost (unsigned long long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong NSSwapBigLongLongToHost (ulong x);

		// unsigned short NSSwapHostShortToBig (unsigned short x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort NSSwapHostShortToBig (ushort x);

		// unsigned int NSSwapHostIntToBig (unsigned int x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint NSSwapHostIntToBig (uint x);

		// unsigned long NSSwapHostLongToBig (unsigned long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nuint NSSwapHostLongToBig (nuint x);

		// unsigned long long NSSwapHostLongLongToBig (unsigned long long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong NSSwapHostLongLongToBig (ulong x);

		// unsigned short NSSwapLittleShortToHost (unsigned short x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort NSSwapLittleShortToHost (ushort x);

		// unsigned int NSSwapLittleIntToHost (unsigned int x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint NSSwapLittleIntToHost (uint x);

		// unsigned long NSSwapLittleLongToHost (unsigned long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nuint NSSwapLittleLongToHost (nuint x);

		// unsigned long long NSSwapLittleLongLongToHost (unsigned long long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong NSSwapLittleLongLongToHost (ulong x);

		// unsigned short NSSwapHostShortToLittle (unsigned short x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ushort NSSwapHostShortToLittle (ushort x);

		// unsigned int NSSwapHostIntToLittle (unsigned int x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern uint NSSwapHostIntToLittle (uint x);

		// unsigned long NSSwapHostLongToLittle (unsigned long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern nuint NSSwapHostLongToLittle (nuint x);

		// unsigned long long NSSwapHostLongLongToLittle (unsigned long long x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern ulong NSSwapHostLongLongToLittle (ulong x);

		// NSSwappedFloat NSConvertHostFloatToSwapped (float x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedFloat NSConvertHostFloatToSwapped (float x);

		// float NSConvertSwappedFloatToHost (NSSwappedFloat x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern float NSConvertSwappedFloatToHost (NSSwappedFloat x);

		// NSSwappedDouble NSConvertHostDoubleToSwapped (double x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedDouble NSConvertHostDoubleToSwapped (double x);

		// double NSConvertSwappedDoubleToHost (NSSwappedDouble x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern double NSConvertSwappedDoubleToHost (NSSwappedDouble x);

		// NSSwappedFloat NSSwapFloat (NSSwappedFloat x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedFloat NSSwapFloat (NSSwappedFloat x);

		// NSSwappedDouble NSSwapDouble (NSSwappedDouble x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedDouble NSSwapDouble (NSSwappedDouble x);

		// double NSSwapBigDoubleToHost (NSSwappedDouble x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern double NSSwapBigDoubleToHost (NSSwappedDouble x);

		// float NSSwapBigFloatToHost (NSSwappedFloat x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern float NSSwapBigFloatToHost (NSSwappedFloat x);

		// NSSwappedDouble NSSwapHostDoubleToBig (double x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedDouble NSSwapHostDoubleToBig (double x);

		// NSSwappedFloat NSSwapHostFloatToBig (float x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedFloat NSSwapHostFloatToBig (float x);

		// double NSSwapLittleDoubleToHost (NSSwappedDouble x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern double NSSwapLittleDoubleToHost (NSSwappedDouble x);

		// float NSSwapLittleFloatToHost (NSSwappedFloat x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern float NSSwapLittleFloatToHost (NSSwappedFloat x);

		// NSSwappedDouble NSSwapHostDoubleToLittle (double x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedDouble NSSwapHostDoubleToLittle (double x);

		// NSSwappedFloat NSSwapHostFloatToLittle (float x) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern NSSwappedFloat NSSwapHostFloatToLittle (float x);

		// BOOL NSDecimalIsNotANumber (const NSDecimal * _Nonnull dcm) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe bool NSDecimalIsNotANumber (NSDecimal* dcm);

		// extern void NSDecimalCopy (NSDecimal * _Nonnull destination, const NSDecimal * _Nonnull source);
		[DllImport ("__Internal")]
		static extern unsafe void NSDecimalCopy (NSDecimal* destination, NSDecimal* source);

		// extern void NSDecimalCompact (NSDecimal * _Nonnull number);
		[DllImport ("__Internal")]
		static extern unsafe void NSDecimalCompact (NSDecimal* number);

		// extern NSComparisonResult NSDecimalCompare (const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand);
		[DllImport ("__Internal")]
		static extern unsafe NSComparisonResult NSDecimalCompare (NSDecimal* leftOperand, NSDecimal* rightOperand);

		// extern void NSDecimalRound (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull number, NSInteger scale, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe void NSDecimalRound (NSDecimal* result, NSDecimal* number, nint scale, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalNormalize (NSDecimal * _Nonnull number1, NSDecimal * _Nonnull number2, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalNormalize (NSDecimal* number1, NSDecimal* number2, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalAdd (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalAdd (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalSubtract (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalSubtract (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalMultiply (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalMultiply (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalDivide (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalDivide (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalPower (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull number, NSUInteger power, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalPower (NSDecimal* result, NSDecimal* number, nuint power, NSRoundingMode roundingMode);

		// extern NSCalculationError NSDecimalMultiplyByPowerOf10 (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull number, short power, NSRoundingMode roundingMode);
		[DllImport ("__Internal")]
		static extern unsafe NSCalculationError NSDecimalMultiplyByPowerOf10 (NSDecimal* result, NSDecimal* number, short power, NSRoundingMode roundingMode);

		// extern NSString * _Nonnull NSDecimalString (const NSDecimal * _Nonnull dcm, id _Nullable locale);
		[DllImport ("__Internal")]
		static extern unsafe NSString NSDecimalString (NSDecimal* dcm, [NullAllowed] NSObject locale);

		// extern NSUncaughtExceptionHandler * _Nullable NSGetUncaughtExceptionHandler ();
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe NSUncaughtExceptionHandler* NSGetUncaughtExceptionHandler ();

		// extern void NSSetUncaughtExceptionHandler (NSUncaughtExceptionHandler * _Nullable);
		[DllImport ("__Internal")]
		static extern unsafe void NSSetUncaughtExceptionHandler ([NullAllowed] NSUncaughtExceptionHandler*);

		// extern NSString * _Nonnull NSUserName ();
		[DllImport ("__Internal")]
		static extern NSString NSUserName ();

		// extern NSString * _Nonnull NSFullUserName ();
		[DllImport ("__Internal")]
		static extern NSString NSFullUserName ();

		// extern NSString * _Nonnull NSHomeDirectory ();
		[DllImport ("__Internal")]
		static extern NSString NSHomeDirectory ();

		// extern NSString * _Nullable NSHomeDirectoryForUser (NSString * _Nullable userName);
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern NSString NSHomeDirectoryForUser ([NullAllowed] NSString userName);

		// extern NSString * _Nonnull NSTemporaryDirectory ();
		[DllImport ("__Internal")]
		static extern NSString NSTemporaryDirectory ();

		// extern NSString * _Nonnull NSOpenStepRootDirectory ();
		[DllImport ("__Internal")]
		static extern NSString NSOpenStepRootDirectory ();

		// extern NSArray<NSString *> * _Nonnull NSSearchPathForDirectoriesInDomains (NSSearchPathDirectory directory, NSSearchPathDomainMask domainMask, BOOL expandTilde);
		[DllImport ("__Internal")]
		static extern NSString[] NSSearchPathForDirectoriesInDomains (NSSearchPathDirectory directory, NSSearchPathDomainMask domainMask, bool expandTilde);

		// extern void NSFreeHashTable (NSHashTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern void NSFreeHashTable (NSHashTable table);

		// extern void NSResetHashTable (NSHashTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern void NSResetHashTable (NSHashTable table);

		// extern BOOL NSCompareHashTables (NSHashTable * _Nonnull table1, NSHashTable * _Nonnull table2);
		[DllImport ("__Internal")]
		static extern bool NSCompareHashTables (NSHashTable table1, NSHashTable table2);

		// extern NSHashTable * _Nonnull NSCopyHashTableWithZone (NSHashTable * _Nonnull table, NSZone * _Nullable zone);
		[DllImport ("__Internal")]
		static extern unsafe NSHashTable NSCopyHashTableWithZone (NSHashTable table, [NullAllowed] NSZone* zone);

		// extern void * _Nonnull NSHashGet (NSHashTable * _Nonnull table, const void * _Nullable pointer);
		[DllImport ("__Internal")]
		static extern unsafe void* NSHashGet (NSHashTable table, [NullAllowed] void* pointer);

		// extern void NSHashInsert (NSHashTable * _Nonnull table, const void * _Nullable pointer);
		[DllImport ("__Internal")]
		static extern unsafe void NSHashInsert (NSHashTable table, [NullAllowed] void* pointer);

		// extern void NSHashInsertKnownAbsent (NSHashTable * _Nonnull table, const void * _Nullable pointer);
		[DllImport ("__Internal")]
		static extern unsafe void NSHashInsertKnownAbsent (NSHashTable table, [NullAllowed] void* pointer);

		// extern void * _Nullable NSHashInsertIfAbsent (NSHashTable * _Nonnull table, const void * _Nullable pointer);
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* NSHashInsertIfAbsent (NSHashTable table, [NullAllowed] void* pointer);

		// extern void NSHashRemove (NSHashTable * _Nonnull table, const void * _Nullable pointer);
		[DllImport ("__Internal")]
		static extern unsafe void NSHashRemove (NSHashTable table, [NullAllowed] void* pointer);

		// extern NSHashEnumerator NSEnumerateHashTable (NSHashTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSHashEnumerator NSEnumerateHashTable (NSHashTable table);

		// extern void * _Nullable NSNextHashEnumeratorItem (NSHashEnumerator * _Nonnull enumerator);
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* NSNextHashEnumeratorItem (NSHashEnumerator* enumerator);

		// extern void NSEndHashTableEnumeration (NSHashEnumerator * _Nonnull enumerator);
		[DllImport ("__Internal")]
		static extern unsafe void NSEndHashTableEnumeration (NSHashEnumerator* enumerator);

		// extern NSUInteger NSCountHashTable (NSHashTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern nuint NSCountHashTable (NSHashTable table);

		// extern NSString * _Nonnull NSStringFromHashTable (NSHashTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSString NSStringFromHashTable (NSHashTable table);

		// extern NSArray * _Nonnull NSAllHashTableObjects (NSHashTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSObject[] NSAllHashTableObjects (NSHashTable table);

		// extern NSHashTable * _Nonnull NSCreateHashTableWithZone (NSHashTableCallBacks callBacks, NSUInteger capacity, NSZone * _Nullable zone);
		[DllImport ("__Internal")]
		static extern unsafe NSHashTable NSCreateHashTableWithZone (NSHashTableCallBacks callBacks, nuint capacity, [NullAllowed] NSZone* zone);

		// extern NSHashTable * _Nonnull NSCreateHashTable (NSHashTableCallBacks callBacks, NSUInteger capacity);
		[DllImport ("__Internal")]
		static extern NSHashTable NSCreateHashTable (NSHashTableCallBacks callBacks, nuint capacity);

		// extern void NSFreeMapTable (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern void NSFreeMapTable (NSMapTable table);

		// extern void NSResetMapTable (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern void NSResetMapTable (NSMapTable table);

		// extern BOOL NSCompareMapTables (NSMapTable * _Nonnull table1, NSMapTable * _Nonnull table2);
		[DllImport ("__Internal")]
		static extern bool NSCompareMapTables (NSMapTable table1, NSMapTable table2);

		// extern NSMapTable * _Nonnull NSCopyMapTableWithZone (NSMapTable * _Nonnull table, NSZone * _Nullable zone) __attribute__((ns_returns_retained));
		[DllImport ("__Internal")]
		static extern unsafe NSMapTable NSCopyMapTableWithZone (NSMapTable table, [NullAllowed] NSZone* zone);

		// extern BOOL NSMapMember (NSMapTable * _Nonnull table, const void * _Nonnull key, void * _Nullable * _Nullable originalKey, void * _Nullable * _Nullable value);
		[DllImport ("__Internal")]
		static extern unsafe bool NSMapMember (NSMapTable table, void* key, [NullAllowed] void** originalKey, [NullAllowed] void** value);

		// extern void * _Nullable NSMapGet (NSMapTable * _Nonnull table, const void * _Nullable key);
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* NSMapGet (NSMapTable table, [NullAllowed] void* key);

		// extern void NSMapInsert (NSMapTable * _Nonnull table, const void * _Nullable key, const void * _Nullable value);
		[DllImport ("__Internal")]
		static extern unsafe void NSMapInsert (NSMapTable table, [NullAllowed] void* key, [NullAllowed] void* value);

		// extern void NSMapInsertKnownAbsent (NSMapTable * _Nonnull table, const void * _Nullable key, const void * _Nullable value);
		[DllImport ("__Internal")]
		static extern unsafe void NSMapInsertKnownAbsent (NSMapTable table, [NullAllowed] void* key, [NullAllowed] void* value);

		// extern void * _Nullable NSMapInsertIfAbsent (NSMapTable * _Nonnull table, const void * _Nullable key, const void * _Nullable value);
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe void* NSMapInsertIfAbsent (NSMapTable table, [NullAllowed] void* key, [NullAllowed] void* value);

		// extern void NSMapRemove (NSMapTable * _Nonnull table, const void * _Nullable key);
		[DllImport ("__Internal")]
		static extern unsafe void NSMapRemove (NSMapTable table, [NullAllowed] void* key);

		// extern NSMapEnumerator NSEnumerateMapTable (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSMapEnumerator NSEnumerateMapTable (NSMapTable table);

		// extern BOOL NSNextMapEnumeratorPair (NSMapEnumerator * _Nonnull enumerator, void * _Nullable * _Nullable key, void * _Nullable * _Nullable value);
		[DllImport ("__Internal")]
		static extern unsafe bool NSNextMapEnumeratorPair (NSMapEnumerator* enumerator, [NullAllowed] void** key, [NullAllowed] void** value);

		// extern void NSEndMapTableEnumeration (NSMapEnumerator * _Nonnull enumerator);
		[DllImport ("__Internal")]
		static extern unsafe void NSEndMapTableEnumeration (NSMapEnumerator* enumerator);

		// extern NSUInteger NSCountMapTable (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern nuint NSCountMapTable (NSMapTable table);

		// extern NSString * _Nonnull NSStringFromMapTable (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSString NSStringFromMapTable (NSMapTable table);

		// extern NSArray * _Nonnull NSAllMapTableKeys (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSObject[] NSAllMapTableKeys (NSMapTable table);

		// extern NSArray * _Nonnull NSAllMapTableValues (NSMapTable * _Nonnull table);
		[DllImport ("__Internal")]
		static extern NSObject[] NSAllMapTableValues (NSMapTable table);

		// extern NSMapTable * _Nonnull NSCreateMapTableWithZone (NSMapTableKeyCallBacks keyCallBacks, NSMapTableValueCallBacks valueCallBacks, NSUInteger capacity, NSZone * _Nullable zone) __attribute__((ns_returns_retained));
		[DllImport ("__Internal")]
		static extern unsafe NSMapTable NSCreateMapTableWithZone (NSMapTableKeyCallBacks keyCallBacks, NSMapTableValueCallBacks valueCallBacks, nuint capacity, [NullAllowed] NSZone* zone);

		// extern NSMapTable * _Nonnull NSCreateMapTable (NSMapTableKeyCallBacks keyCallBacks, NSMapTableValueCallBacks valueCallBacks, NSUInteger capacity) __attribute__((ns_returns_retained));
		[DllImport ("__Internal")]
		static extern NSMapTable NSCreateMapTable (NSMapTableKeyCallBacks keyCallBacks, NSMapTableValueCallBacks valueCallBacks, nuint capacity);

		// extern CFStringRef _Nullable SecCopyErrorMessageString (OSStatus status, void * _Nullable reserved) __attribute__((availability(ios, introduced=11.3))) __attribute__((cf_audited_transfer));
		[iOS (11,3)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* SecCopyErrorMessageString (int status, [NullAllowed] void* reserved);

		// extern CFTypeID SecCertificateGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint SecCertificateGetTypeID ();

		// extern SecCertificateRef _Nullable SecCertificateCreateWithData (CFAllocatorRef _Nullable allocator, CFDataRef _Nonnull data) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecCertificateRef* SecCertificateCreateWithData ([NullAllowed] CFAllocatorRef* allocator, CFDataRef* data);

		// extern CFDataRef _Nonnull SecCertificateCopyData (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFDataRef* SecCertificateCopyData (SecCertificateRef* certificate);

		// extern CFStringRef _Nullable SecCertificateCopySubjectSummary (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* SecCertificateCopySubjectSummary (SecCertificateRef* certificate);

		// extern OSStatus SecCertificateCopyCommonName (SecCertificateRef _Nonnull certificate, CF_RETURNS_RETAINED CFStringRef  _Nullable *commonName) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
		[iOS (10,3)]
		[DllImport ("__Internal")]
		static extern unsafe int SecCertificateCopyCommonName (SecCertificateRef* certificate, [NullAllowed] CFStringRef** commonName);

		// extern OSStatus SecCertificateCopyEmailAddresses (SecCertificateRef _Nonnull certificate, CF_RETURNS_RETAINED CFArrayRef  _Nullable *emailAddresses) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
		[iOS (10,3)]
		[DllImport ("__Internal")]
		static extern unsafe int SecCertificateCopyEmailAddresses (SecCertificateRef* certificate, [NullAllowed] CFArrayRef** emailAddresses);

		// extern CFDataRef _Nullable SecCertificateCopyNormalizedIssuerSequence (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
		[iOS (10,3)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecCertificateCopyNormalizedIssuerSequence (SecCertificateRef* certificate);

		// extern CFDataRef _Nullable SecCertificateCopyNormalizedSubjectSequence (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
		[iOS (10,3)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecCertificateCopyNormalizedSubjectSequence (SecCertificateRef* certificate);

		// extern CF_RETURNS_RETAINED SecKeyRef SecCertificateCopyKey (SecCertificateRef _Nonnull certificate) __attribute__((cf_returns_retained)) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((cf_audited_transfer));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe SecKeyRef* SecCertificateCopyKey (SecCertificateRef* certificate);

		// extern SecKeyRef _Nullable SecCertificateCopyPublicKey (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3, deprecated=12.0))) __attribute__((availability(macos, unavailable))) __attribute__((availability(maccatalyst, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 10, 3)]
		[Deprecated (PlatformName.iOS, 12, 0)]
		[NoMacCatalyst, NoMac]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecKeyRef* SecCertificateCopyPublicKey (SecCertificateRef* certificate);

		// extern CFDataRef _Nullable SecCertificateCopySerialNumberData (SecCertificateRef _Nonnull certificate, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((cf_audited_transfer));
		[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecCertificateCopySerialNumberData (SecCertificateRef* certificate, [NullAllowed] CFErrorRef** error);

		// extern CFDataRef _Nullable SecCertificateCopySerialNumber (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3, deprecated=11.0))) __attribute__((availability(macos, unavailable))) __attribute__((availability(maccatalyst, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 10, 3)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[NoMacCatalyst, NoMac]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecCertificateCopySerialNumber (SecCertificateRef* certificate);

		// extern CFTypeID SecIdentityGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint SecIdentityGetTypeID ();

		// extern OSStatus SecIdentityCopyCertificate (SecIdentityRef _Nonnull identityRef, CF_RETURNS_RETAINED SecCertificateRef  _Nullable *certificateRef) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecIdentityCopyCertificate (SecIdentity identityRef, [NullAllowed] SecCertificateRef** certificateRef);

		// extern OSStatus SecIdentityCopyPrivateKey (SecIdentityRef _Nonnull identityRef, CF_RETURNS_RETAINED SecKeyRef  _Nullable *privateKeyRef) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecIdentityCopyPrivateKey (SecIdentity identityRef, [NullAllowed] SecKeyRef** privateKeyRef);

		// extern CFTypeID SecAccessControlGetTypeID () __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
		[iOS (8,0)]
		[DllImport ("__Internal")]
		static extern nuint SecAccessControlGetTypeID ();

		// extern SecAccessControlRef _Nullable SecAccessControlCreateWithFlags (CFAllocatorRef _Nullable allocator, CFTypeRef _Nonnull protection, SecAccessControlCreateFlags flags, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
		[Mac (10,10), iOS (8,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecAccessControl SecAccessControlCreateWithFlags ([NullAllowed] CFAllocatorRef* allocator, void* protection, SecAccessControlCreateFlags flags, [NullAllowed] CFErrorRef** error);

		// extern OSStatus SecItemCopyMatching (CFDictionaryRef _Nonnull query, CF_RETURNS_RETAINED CFTypeRef  _Nullable *result) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[Mac (10,6), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecItemCopyMatching (CFDictionaryRef* query, [NullAllowed] void** result);

		// extern OSStatus SecItemAdd (CFDictionaryRef _Nonnull attributes, CF_RETURNS_RETAINED CFTypeRef  _Nullable *result) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[Mac (10,6), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecItemAdd (CFDictionaryRef* attributes, [NullAllowed] void** result);

		// extern OSStatus SecItemUpdate (CFDictionaryRef _Nonnull query, CFDictionaryRef _Nonnull attributesToUpdate) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[Mac (10,6), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecItemUpdate (CFDictionaryRef* query, CFDictionaryRef* attributesToUpdate);

		// extern OSStatus SecItemDelete (CFDictionaryRef _Nonnull query) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[Mac (10,6), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecItemDelete (CFDictionaryRef* query);

		// extern CFTypeID SecKeyGetTypeID () __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=4.0))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((cf_audited_transfer));
		[Watch (1,0), TV (4,0), Mac (10,3), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint SecKeyGetTypeID ();

		// extern OSStatus SecKeyGeneratePair (CFDictionaryRef _Nonnull parameters, CF_RETURNS_RETAINED SecKeyRef  _Nullable *publicKey, CF_RETURNS_RETAINED SecKeyRef  _Nullable *privateKey) __attribute__((availability(macos, introduced=10.7, deprecated=12.0))) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(tvos, introduced=4.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use SecKeyCreateRandomKey")]
		[Deprecated (PlatformName.MacOSX, 12, 0, message: "Use SecKeyCreateRandomKey")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use SecKeyCreateRandomKey")]
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use SecKeyCreateRandomKey")]
		[Introduced (PlatformName.TvOS, 4, 0, message: "Use SecKeyCreateRandomKey")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use SecKeyCreateRandomKey")]
		[Introduced (PlatformName.WatchOS, 1, 0, message: "Use SecKeyCreateRandomKey")]
		[Deprecated (PlatformName.WatchOS, 8, 0, message: "Use SecKeyCreateRandomKey")]
		[DllImport ("__Internal")]
		static extern unsafe int SecKeyGeneratePair (CFDictionaryRef* parameters, [NullAllowed] SecKeyRef** publicKey, [NullAllowed] SecKeyRef** privateKey);

		// extern OSStatus SecKeyRawSign (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull dataToSign, size_t dataToSignLen, uint8_t * _Nonnull sig, size_t * _Nonnull sigLen) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(tvos, introduced=4.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use SecKeyCreateSignature")]
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use SecKeyCreateSignature")]
		[Introduced (PlatformName.TvOS, 4, 0, message: "Use SecKeyCreateSignature")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use SecKeyCreateSignature")]
		[Introduced (PlatformName.WatchOS, 1, 0, message: "Use SecKeyCreateSignature")]
		[Deprecated (PlatformName.WatchOS, 8, 0, message: "Use SecKeyCreateSignature")]
		[DllImport ("__Internal")]
		static extern unsafe int SecKeyRawSign (SecKeyRef* key, SecPadding padding, byte* dataToSign, nuint dataToSignLen, byte* sig, nuint* sigLen);

		// extern OSStatus SecKeyRawVerify (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull signedData, size_t signedDataLen, const uint8_t * _Nonnull sig, size_t sigLen) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(tvos, introduced=4.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use SecKeyVerifySignature")]
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use SecKeyVerifySignature")]
		[Introduced (PlatformName.TvOS, 4, 0, message: "Use SecKeyVerifySignature")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use SecKeyVerifySignature")]
		[Introduced (PlatformName.WatchOS, 1, 0, message: "Use SecKeyVerifySignature")]
		[Deprecated (PlatformName.WatchOS, 8, 0, message: "Use SecKeyVerifySignature")]
		[DllImport ("__Internal")]
		static extern unsafe int SecKeyRawVerify (SecKeyRef* key, SecPadding padding, byte* signedData, nuint signedDataLen, byte* sig, nuint sigLen);

		// extern OSStatus SecKeyEncrypt (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull plainText, size_t plainTextLen, uint8_t * _Nonnull cipherText, size_t * _Nonnull cipherTextLen) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(tvos, introduced=4.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use SecKeyCreateEncryptedData")]
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use SecKeyCreateEncryptedData")]
		[Introduced (PlatformName.TvOS, 4, 0, message: "Use SecKeyCreateEncryptedData")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use SecKeyCreateEncryptedData")]
		[Introduced (PlatformName.WatchOS, 1, 0, message: "Use SecKeyCreateEncryptedData")]
		[Deprecated (PlatformName.WatchOS, 8, 0, message: "Use SecKeyCreateEncryptedData")]
		[DllImport ("__Internal")]
		static extern unsafe int SecKeyEncrypt (SecKeyRef* key, SecPadding padding, byte* plainText, nuint plainTextLen, byte* cipherText, nuint* cipherTextLen);

		// extern OSStatus SecKeyDecrypt (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull cipherText, size_t cipherTextLen, uint8_t * _Nonnull plainText, size_t * _Nonnull plainTextLen) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(tvos, introduced=4.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use SecKeyCreateDecryptedData")]
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use SecKeyCreateDecryptedData")]
		[Introduced (PlatformName.TvOS, 4, 0, message: "Use SecKeyCreateDecryptedData")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use SecKeyCreateDecryptedData")]
		[Introduced (PlatformName.WatchOS, 1, 0, message: "Use SecKeyCreateDecryptedData")]
		[Deprecated (PlatformName.WatchOS, 8, 0, message: "Use SecKeyCreateDecryptedData")]
		[DllImport ("__Internal")]
		static extern unsafe int SecKeyDecrypt (SecKeyRef* key, SecPadding padding, byte* cipherText, nuint cipherTextLen, byte* plainText, nuint* plainTextLen);

		// extern SecKeyRef _Nullable SecKeyCreateRandomKey (CFDictionaryRef _Nonnull parameters, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecKeyRef* SecKeyCreateRandomKey (CFDictionaryRef* parameters, [NullAllowed] CFErrorRef** error);

		// extern SecKeyRef _Nullable SecKeyCreateWithData (CFDataRef _Nonnull keyData, CFDictionaryRef _Nonnull attributes, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecKeyRef* SecKeyCreateWithData (CFDataRef* keyData, CFDictionaryRef* attributes, [NullAllowed] CFErrorRef** error);

		// extern size_t SecKeyGetBlockSize (SecKeyRef _Nonnull key) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(tvos, introduced=4.0))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((cf_audited_transfer));
		[Watch (1,0), TV (4,0), Mac (10,6), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nuint SecKeyGetBlockSize (SecKeyRef* key);

		// extern CFDataRef _Nullable SecKeyCopyExternalRepresentation (SecKeyRef _Nonnull key, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecKeyCopyExternalRepresentation (SecKeyRef* key, [NullAllowed] CFErrorRef** error);

		// extern CFDictionaryRef _Nullable SecKeyCopyAttributes (SecKeyRef _Nonnull key) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDictionaryRef* SecKeyCopyAttributes (SecKeyRef* key);

		// extern SecKeyRef _Nullable SecKeyCopyPublicKey (SecKeyRef _Nonnull key) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecKeyRef* SecKeyCopyPublicKey (SecKeyRef* key);

		// extern CFDataRef _Nullable SecKeyCreateSignature (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull dataToSign, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecKeyCreateSignature (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* dataToSign, [NullAllowed] CFErrorRef** error);

		// extern Boolean SecKeyVerifySignature (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull signedData, CFDataRef _Nonnull signature, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte SecKeyVerifySignature (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* signedData, CFDataRef* signature, [NullAllowed] CFErrorRef** error);

		// extern CFDataRef _Nullable SecKeyCreateEncryptedData (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull plaintext, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecKeyCreateEncryptedData (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* plaintext, [NullAllowed] CFErrorRef** error);

		// extern CFDataRef _Nullable SecKeyCreateDecryptedData (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull ciphertext, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecKeyCreateDecryptedData (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* ciphertext, [NullAllowed] CFErrorRef** error);

		// extern CFDataRef _Nullable SecKeyCopyKeyExchangeResult (SecKeyRef _Nonnull privateKey, SecKeyAlgorithm _Nonnull algorithm, SecKeyRef _Nonnull publicKey, CFDictionaryRef _Nonnull parameters, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecKeyCopyKeyExchangeResult (SecKeyRef* privateKey, SecKeyAlgorithm* algorithm, SecKeyRef* publicKey, CFDictionaryRef* parameters, [NullAllowed] CFErrorRef** error);

		// extern Boolean SecKeyIsAlgorithmSupported (SecKeyRef _Nonnull key, SecKeyOperationType operation, SecKeyAlgorithm _Nonnull algorithm) __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((cf_audited_transfer));
		[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte SecKeyIsAlgorithmSupported (SecKeyRef* key, SecKeyOperationType operation, SecKeyAlgorithm* algorithm);

		// extern CFTypeID SecPolicyGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint SecPolicyGetTypeID ();

		// extern CFDictionaryRef _Nullable SecPolicyCopyProperties (SecPolicyRef _Nonnull policyRef) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDictionaryRef* SecPolicyCopyProperties (SecPolicyRef* policyRef);

		// extern SecPolicyRef _Nonnull SecPolicyCreateBasicX509 () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe SecPolicyRef* SecPolicyCreateBasicX509 ();

		// extern SecPolicyRef _Nonnull SecPolicyCreateSSL (Boolean server, CFStringRef _Nullable hostname) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe SecPolicyRef* SecPolicyCreateSSL (byte server, [NullAllowed] CFStringRef* hostname);

		// extern SecPolicyRef _Nullable SecPolicyCreateRevocation (CFOptionFlags revocationFlags) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecPolicyRef* SecPolicyCreateRevocation (nuint revocationFlags);

		// extern SecPolicyRef _Nullable SecPolicyCreateWithProperties (CFTypeRef _Nonnull policyIdentifier, CFDictionaryRef _Nullable properties) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecPolicyRef* SecPolicyCreateWithProperties (void* policyIdentifier, [NullAllowed] CFDictionaryRef* properties);

		// extern int SecRandomCopyBytes (SecRandomRef _Nullable rnd, size_t count, void * _Nonnull bytes) __attribute__((warn_unused_result(""))) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecRandomCopyBytes ([NullAllowed] SecRandomRef* rnd, nuint count, void* bytes);

		// extern OSStatus SecPKCS12Import (CFDataRef _Nonnull pkcs12_data, CFDictionaryRef _Nonnull options, CF_RETURNS_RETAINED CFArrayRef  _Nullable *items) __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[Mac (10,6), iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecPKCS12Import (CFDataRef* pkcs12_data, CFDictionaryRef* options, [NullAllowed] CFArrayRef** items);

		// extern CFTypeID SecTrustGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint SecTrustGetTypeID ();

		// extern OSStatus SecTrustCreateWithCertificates (CFTypeRef _Nonnull certificates, CFTypeRef _Nullable policies, CF_RETURNS_RETAINED SecTrustRef  _Nullable *trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustCreateWithCertificates (void* certificates, [NullAllowed] void* policies, SecTrust* trust);

		// extern OSStatus SecTrustSetPolicies (SecTrustRef _Nonnull trust, CFTypeRef _Nonnull policies) __attribute__((availability(ios, introduced=6.0))) __attribute__((cf_audited_transfer));
		[iOS (6,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustSetPolicies (SecTrust trust, void* policies);

		// extern OSStatus SecTrustCopyPolicies (SecTrustRef _Nonnull trust, CF_RETURNS_RETAINED CFArrayRef  _Nullable *policies) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustCopyPolicies (SecTrust trust, [NullAllowed] CFArrayRef** policies);

		// extern OSStatus SecTrustSetNetworkFetchAllowed (SecTrustRef _Nonnull trust, Boolean allowFetch) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern int SecTrustSetNetworkFetchAllowed (SecTrust trust, byte allowFetch);

		// extern OSStatus SecTrustGetNetworkFetchAllowed (SecTrustRef _Nonnull trust, Boolean * _Nonnull allowFetch) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustGetNetworkFetchAllowed (SecTrust trust, byte* allowFetch);

		// extern OSStatus SecTrustSetAnchorCertificates (SecTrustRef _Nonnull trust, CFArrayRef _Nullable anchorCertificates) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustSetAnchorCertificates (SecTrust trust, [NullAllowed] CFArrayRef* anchorCertificates);

		// extern OSStatus SecTrustSetAnchorCertificatesOnly (SecTrustRef _Nonnull trust, Boolean anchorCertificatesOnly) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern int SecTrustSetAnchorCertificatesOnly (SecTrust trust, byte anchorCertificatesOnly);

		// extern OSStatus SecTrustCopyCustomAnchorCertificates (SecTrustRef _Nonnull trust, CF_RETURNS_RETAINED CFArrayRef  _Nullable *anchors) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustCopyCustomAnchorCertificates (SecTrust trust, [NullAllowed] CFArrayRef** anchors);

		// extern OSStatus SecTrustSetVerifyDate (SecTrustRef _Nonnull trust, CFDateRef _Nonnull verifyDate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustSetVerifyDate (SecTrust trust, CFDateRef* verifyDate);

		// extern CFAbsoluteTime SecTrustGetVerifyTime (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern double SecTrustGetVerifyTime (SecTrust trust);

		// extern OSStatus SecTrustEvaluate (SecTrustRef _Nonnull trust, SecTrustResultType * _Nonnull result) __attribute__((availability(macos, introduced=10.3, deprecated=10.15))) __attribute__((availability(ios, introduced=2.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=2.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 3)]
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Introduced (PlatformName.WatchOS, 1, 0)]
		[Deprecated (PlatformName.WatchOS, 6, 0)]
		[Introduced (PlatformName.TvOS, 2, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustEvaluate (SecTrust trust, SecTrustResultType* result);

		// extern OSStatus SecTrustEvaluateAsync (SecTrustRef _Nonnull trust, dispatch_queue_t _Nullable queue, SecTrustCallback _Nonnull result) __attribute__((availability(macos, introduced=10.7, deprecated=10.15))) __attribute__((availability(ios, introduced=7.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=7.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 7)]
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Introduced (PlatformName.iOS, 7, 0)]
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Introduced (PlatformName.WatchOS, 1, 0)]
		[Deprecated (PlatformName.WatchOS, 6, 0)]
		[Introduced (PlatformName.TvOS, 7, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[DllImport ("__Internal")]
		static extern int SecTrustEvaluateAsync (SecTrust trust, [NullAllowed] DispatchQueue queue, SecTrustCallback result);

		// extern _Bool SecTrustEvaluateWithError (SecTrustRef _Nonnull trust, CF_RETURNS_RETAINED CFErrorRef  _Nullable *error) __attribute__((warn_unused_result(""))) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((cf_audited_transfer));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe bool SecTrustEvaluateWithError (SecTrust trust, [NullAllowed] CFErrorRef** error);

		// extern OSStatus SecTrustEvaluateAsyncWithError (SecTrustRef _Nonnull trust, dispatch_queue_t _Nonnull queue, SecTrustWithErrorCallback _Nonnull result) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((cf_audited_transfer));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern int SecTrustEvaluateAsyncWithError (SecTrust trust, DispatchQueue queue, SecTrustWithErrorCallback result);

		// extern OSStatus SecTrustGetTrustResult (SecTrustRef _Nonnull trust, SecTrustResultType * _Nonnull result) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustGetTrustResult (SecTrust trust, SecTrustResultType* result);

		// extern SecKeyRef _Nullable SecTrustCopyPublicKey (SecTrustRef _Nonnull trust) __attribute__((availability(macos, introduced=10.7, deprecated=11.0))) __attribute__((availability(ios, introduced=2.0, deprecated=14.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=7.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=14.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 7)]
		[Deprecated (PlatformName.MacOSX, 11, 0)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 14, 0)]
		[Introduced (PlatformName.WatchOS, 1, 0)]
		[Deprecated (PlatformName.WatchOS, 7, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 14, 0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecKeyRef* SecTrustCopyPublicKey (SecTrust trust);

		// extern SecKeyRef _Nullable SecTrustCopyKey (SecTrustRef _Nonnull trust) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((cf_audited_transfer));
		[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecKeyRef* SecTrustCopyKey (SecTrust trust);

		// extern CFIndex SecTrustGetCertificateCount (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nint SecTrustGetCertificateCount (SecTrust trust);

		// extern SecCertificateRef _Nullable SecTrustGetCertificateAtIndex (SecTrustRef _Nonnull trust, CFIndex ix) __attribute__((availability(macos, introduced=10.7, deprecated=12.0))) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=15.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 7)]
		[Deprecated (PlatformName.MacOSX, 12, 0)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 15, 0)]
		[Introduced (PlatformName.WatchOS, 1, 0)]
		[Deprecated (PlatformName.WatchOS, 8, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 15, 0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecCertificateRef* SecTrustGetCertificateAtIndex (SecTrust trust, nint ix);

		// extern CFDataRef _Nullable SecTrustCopyExceptions (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
		[iOS (4,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* SecTrustCopyExceptions (SecTrust trust);

		// extern _Bool SecTrustSetExceptions (SecTrustRef _Nonnull trust, CFDataRef _Nullable exceptions) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
		[iOS (4,0)]
		[DllImport ("__Internal")]
		static extern unsafe bool SecTrustSetExceptions (SecTrust trust, [NullAllowed] CFDataRef* exceptions);

		// extern CFArrayRef _Nullable SecTrustCopyProperties (SecTrustRef _Nonnull trust) __attribute__((availability(macos, introduced=10.7, deprecated=12.0))) __attribute__((availability(ios, introduced=2.0, deprecated=15.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=8.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=15.0))) __attribute__((availability(maccatalyst, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 7)]
		[Deprecated (PlatformName.MacOSX, 12, 0)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 15, 0)]
		[Introduced (PlatformName.WatchOS, 1, 0)]
		[Deprecated (PlatformName.WatchOS, 8, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 15, 0)]
		[NoMacCatalyst]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* SecTrustCopyProperties (SecTrust trust);

		// extern CFDictionaryRef _Nullable SecTrustCopyResult (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDictionaryRef* SecTrustCopyResult (SecTrust trust);

		// extern OSStatus SecTrustSetOCSPResponse (SecTrustRef _Nonnull trust, CFTypeRef _Nullable responseData) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
		[iOS (7,0)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustSetOCSPResponse (SecTrust trust, [NullAllowed] void* responseData);

		// extern OSStatus SecTrustSetSignedCertificateTimestamps (SecTrustRef _Nonnull trust, CFArrayRef _Nullable sctArray) __attribute__((availability(macos, introduced=10.14.2))) __attribute__((availability(ios, introduced=12.1.1))) __attribute__((availability(tvos, introduced=12.1.1))) __attribute__((availability(watchos, introduced=5.1.1))) __attribute__((cf_audited_transfer));
		[Watch (5,1,1), TV (12,1,1), Mac (10,14,2), iOS (12,1,1)]
		[DllImport ("__Internal")]
		static extern unsafe int SecTrustSetSignedCertificateTimestamps (SecTrust trust, [NullAllowed] CFArrayRef* sctArray);

		// extern CF_RETURNS_RETAINED CFArrayRef SecTrustCopyCertificateChain (SecTrustRef _Nonnull trust) __attribute__((cf_returns_retained)) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(ios, introduced=15.0))) __attribute__((availability(tvos, introduced=15.0))) __attribute__((availability(watchos, introduced=8.0))) __attribute__((cf_audited_transfer));
		[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* SecTrustCopyCertificateChain (SecTrust trust);

		// extern void SecAddSharedWebCredential (CFStringRef _Nonnull fqdn, CFStringRef _Nonnull account, CFStringRef _Nullable password, void (^ _Nonnull)(CFErrorRef _Nullable) completionHandler) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(maccatalyst, introduced=14.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, MacCatalyst (14,0), Mac (11,0), iOS (8,0)]
		[DllImport ("__Internal")]
		static extern unsafe void SecAddSharedWebCredential (CFStringRef* fqdn, CFStringRef* account, [NullAllowed] CFStringRef* password, Action<CoreFoundation.CFErrorRef*> completionHandler);

		// extern void SecRequestSharedWebCredential (CFStringRef _Nullable fqdn, CFStringRef _Nullable account, void (^ _Nonnull)(CFArrayRef _Nullable, CFErrorRef _Nullable) completionHandler) __attribute__((availability(ios, introduced=8.0, deprecated=14.0))) __attribute__((availability(maccatalyst, introduced=14.0, deprecated=14.0))) __attribute__((availability(macos, introduced=11.0, deprecated=11.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.iOS, 8, 0, message: "Use ASAuthorizationController to make an ASAuthorizationPasswordRequest (AuthenticationServices framework)")]
		[Deprecated (PlatformName.iOS, 14, 0, message: "Use ASAuthorizationController to make an ASAuthorizationPasswordRequest (AuthenticationServices framework)")]
		[Introduced (PlatformName.MacCatalyst, 14, 0, message: "Use ASAuthorizationController to make an ASAuthorizationPasswordRequest (AuthenticationServices framework)")]
		[Deprecated (PlatformName.MacCatalyst, 14, 0, message: "Use ASAuthorizationController to make an ASAuthorizationPasswordRequest (AuthenticationServices framework)")]
		[Introduced (PlatformName.MacOSX, 11, 0, message: "Use ASAuthorizationController to make an ASAuthorizationPasswordRequest (AuthenticationServices framework)")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "Use ASAuthorizationController to make an ASAuthorizationPasswordRequest (AuthenticationServices framework)")]
		[NoWatch, NoTV]
		[DllImport ("__Internal")]
		static extern unsafe void SecRequestSharedWebCredential ([NullAllowed] CFStringRef* fqdn, [NullAllowed] CFStringRef* account, Action<CoreFoundation.CFArrayRef*, CoreFoundation.CFErrorRef*> completionHandler);

		// extern CFStringRef _Nullable SecCreateSharedWebCredentialPassword () __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(maccatalyst, introduced=14.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((cf_audited_transfer));
		[NoWatch, NoTV, MacCatalyst (14,0), Mac (11,0), iOS (8,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* SecCreateSharedWebCredentialPassword ();

		// extern void * sec_retain (void *obj) __attribute__((visibility("default")));
		[DllImport ("__Internal")]
		static extern unsafe void* sec_retain (void* obj);

		// extern void sec_release (void *obj) __attribute__((visibility("default")));
		[DllImport ("__Internal")]
		static extern unsafe void sec_release (void* obj);

		// extern sec_trust_t _Nullable sec_trust_create (SecTrustRef _Nonnull trust) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern SecTrust2 sec_trust_create (SecTrust trust);

		// extern SecTrustRef _Nonnull sec_trust_copy_ref (sec_trust_t _Nonnull trust) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern SecTrust sec_trust_copy_ref (SecTrust2 trust);

		// extern sec_identity_t _Nullable sec_identity_create (SecIdentityRef _Nonnull identity) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern SecIdentity2 sec_identity_create (SecIdentity identity);

		// extern sec_identity_t _Nullable sec_identity_create_with_certificates (SecIdentityRef _Nonnull identity, CFArrayRef _Nonnull certificates) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SecIdentity2 sec_identity_create_with_certificates (SecIdentity identity, CFArrayRef* certificates);

		// extern _Bool sec_identity_access_certificates (sec_identity_t _Nonnull identity, void (^ _Nonnull)(sec_certificate_t _Nonnull) handler) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern bool sec_identity_access_certificates (SecIdentity2 identity, Action<OS_sec_certificate> handler);

		// extern SecIdentityRef _Nullable sec_identity_copy_ref (sec_identity_t _Nonnull identity) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern SecIdentity sec_identity_copy_ref (SecIdentity2 identity);

		// extern CFArrayRef _Nullable sec_identity_copy_certificates_ref (sec_identity_t _Nonnull identity) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* sec_identity_copy_certificates_ref (SecIdentity2 identity);

		// extern sec_certificate_t _Nullable sec_certificate_create (SecCertificateRef _Nonnull certificate) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe OS_sec_certificate sec_certificate_create (SecCertificateRef* certificate);

		// extern SecCertificateRef _Nonnull sec_certificate_copy_ref (sec_certificate_t _Nonnull certificate) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe SecCertificateRef* sec_certificate_copy_ref (OS_sec_certificate certificate);

		// extern const char * _Nullable sec_protocol_metadata_get_negotiated_protocol (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe sbyte* sec_protocol_metadata_get_negotiated_protocol (SecProtocolMetadata metadata);

		// extern dispatch_data_t _Nullable sec_protocol_metadata_copy_peer_public_key (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern DispatchData sec_protocol_metadata_copy_peer_public_key (SecProtocolMetadata metadata);

		// extern tls_protocol_version_t sec_protocol_metadata_get_negotiated_tls_protocol_version (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern tls_protocol_version_t sec_protocol_metadata_get_negotiated_tls_protocol_version (SecProtocolMetadata metadata);

		// extern SSLProtocol sec_protocol_metadata_get_negotiated_protocol_version (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14)]
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Introduced (PlatformName.iOS, 12, 0)]
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Introduced (PlatformName.WatchOS, 5, 0)]
		[Deprecated (PlatformName.WatchOS, 6, 0)]
		[Introduced (PlatformName.TvOS, 12, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[DllImport ("__Internal")]
		static extern SSLProtocol sec_protocol_metadata_get_negotiated_protocol_version (SecProtocolMetadata metadata);

		// extern tls_ciphersuite_t sec_protocol_metadata_get_negotiated_tls_ciphersuite (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern tls_ciphersuite_t sec_protocol_metadata_get_negotiated_tls_ciphersuite (SecProtocolMetadata metadata);

		// extern SSLCipherSuite sec_protocol_metadata_get_negotiated_ciphersuite (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0))) __attribute__((availability(maccatalyst, introduced=13.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14)]
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Introduced (PlatformName.iOS, 12, 0)]
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Introduced (PlatformName.WatchOS, 5, 0)]
		[Deprecated (PlatformName.WatchOS, 6, 0)]
		[Introduced (PlatformName.TvOS, 12, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[Introduced (PlatformName.MacCatalyst, 13, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 0)]
		[DllImport ("__Internal")]
		static extern ushort sec_protocol_metadata_get_negotiated_ciphersuite (SecProtocolMetadata metadata);

		// extern _Bool sec_protocol_metadata_get_early_data_accepted (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_get_early_data_accepted (SecProtocolMetadata metadata);

		// extern _Bool sec_protocol_metadata_access_peer_certificate_chain (sec_protocol_metadata_t _Nonnull metadata, void (^ _Nonnull)(sec_certificate_t _Nonnull) handler) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_access_peer_certificate_chain (SecProtocolMetadata metadata, Action<OS_sec_certificate> handler);

		// extern _Bool sec_protocol_metadata_access_ocsp_response (sec_protocol_metadata_t _Nonnull metadata, void (^ _Nonnull)(dispatch_data_t _Nonnull) handler) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_access_ocsp_response (SecProtocolMetadata metadata, Action<DispatchData> handler);

		// extern _Bool sec_protocol_metadata_access_supported_signature_algorithms (sec_protocol_metadata_t _Nonnull metadata, void (^ _Nonnull)(uint16_t) handler) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_access_supported_signature_algorithms (SecProtocolMetadata metadata, Action<ushort> handler);

		// extern _Bool sec_protocol_metadata_access_distinguished_names (sec_protocol_metadata_t _Nonnull metadata, void (^ _Nonnull)(dispatch_data_t _Nonnull) handler) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_access_distinguished_names (SecProtocolMetadata metadata, Action<DispatchData> handler);

		// extern _Bool sec_protocol_metadata_access_pre_shared_keys (sec_protocol_metadata_t _Nonnull metadata, void (^ _Nonnull)(dispatch_data_t _Nonnull, dispatch_data_t _Nonnull) handler) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_access_pre_shared_keys (SecProtocolMetadata metadata, Action<DispatchData, DispatchData> handler);

		// extern const char * _Nullable sec_protocol_metadata_get_server_name (sec_protocol_metadata_t _Nonnull metadata) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe sbyte* sec_protocol_metadata_get_server_name (SecProtocolMetadata metadata);

		// extern _Bool sec_protocol_metadata_peers_are_equal (sec_protocol_metadata_t _Nonnull metadataA, sec_protocol_metadata_t _Nonnull metadataB) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_peers_are_equal (SecProtocolMetadata metadataA, SecProtocolMetadata metadataB);

		// extern _Bool sec_protocol_metadata_challenge_parameters_are_equal (sec_protocol_metadata_t _Nonnull metadataA, sec_protocol_metadata_t _Nonnull metadataB) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_metadata_challenge_parameters_are_equal (SecProtocolMetadata metadataA, SecProtocolMetadata metadataB);

		// extern dispatch_data_t _Nullable sec_protocol_metadata_create_secret (sec_protocol_metadata_t _Nonnull metadata, size_t label_len, const char * _Nonnull label, size_t exporter_length) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe DispatchData sec_protocol_metadata_create_secret (SecProtocolMetadata metadata, nuint label_len, sbyte* label, nuint exporter_length);

		// extern dispatch_data_t _Nullable sec_protocol_metadata_create_secret_with_context (sec_protocol_metadata_t _Nonnull metadata, size_t label_len, const char * _Nonnull label, size_t context_len, const uint8_t * _Nonnull context, size_t exporter_length) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((ns_returns_retained)) __attribute__((ns_returns_retained));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe DispatchData sec_protocol_metadata_create_secret_with_context (SecProtocolMetadata metadata, nuint label_len, sbyte* label, nuint context_len, byte* context, nuint exporter_length);

		// extern _Bool sec_protocol_options_are_equal (sec_protocol_options_t _Nonnull optionsA, sec_protocol_options_t _Nonnull optionsB) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_options_are_equal (SecProtocolOptions optionsA, SecProtocolOptions optionsB);

		// extern void sec_protocol_options_set_local_identity (sec_protocol_options_t _Nonnull options, sec_identity_t _Nonnull identity) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_local_identity (SecProtocolOptions options, SecIdentity2 identity);

		// extern void sec_protocol_options_append_tls_ciphersuite (sec_protocol_options_t _Nonnull options, tls_ciphersuite_t ciphersuite) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_append_tls_ciphersuite (SecProtocolOptions options, tls_ciphersuite_t ciphersuite);

		// extern void sec_protocol_options_add_tls_ciphersuite (sec_protocol_options_t _Nonnull options, SSLCipherSuite ciphersuite) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0))) __attribute__((availability(maccatalyst, introduced=13.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Introduced (PlatformName.iOS, 12, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Introduced (PlatformName.WatchOS, 5, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Deprecated (PlatformName.WatchOS, 6, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Introduced (PlatformName.TvOS, 12, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Introduced (PlatformName.MacCatalyst, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[Deprecated (PlatformName.MacCatalyst, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite")]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_add_tls_ciphersuite (SecProtocolOptions options, ushort ciphersuite);

		// extern void sec_protocol_options_append_tls_ciphersuite_group (sec_protocol_options_t _Nonnull options, tls_ciphersuite_group_t group) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_append_tls_ciphersuite_group (SecProtocolOptions options, tls_ciphersuite_group_t group);

		// extern void sec_protocol_options_add_tls_ciphersuite_group (sec_protocol_options_t _Nonnull options, SSLCiphersuiteGroup group) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0))) __attribute__((availability(maccatalyst, introduced=13.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Introduced (PlatformName.iOS, 12, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Introduced (PlatformName.WatchOS, 5, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Deprecated (PlatformName.WatchOS, 6, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Introduced (PlatformName.TvOS, 12, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Introduced (PlatformName.MacCatalyst, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[Deprecated (PlatformName.MacCatalyst, 13, 0, message: "Use sec_protocol_options_append_tls_ciphersuite_group")]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_add_tls_ciphersuite_group (SecProtocolOptions options, SSLCiphersuiteGroup group);

		// extern void sec_protocol_options_set_tls_min_version (sec_protocol_options_t _Nonnull options, SSLProtocol version) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0))) __attribute__((availability(maccatalyst, introduced=13.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14)]
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Introduced (PlatformName.iOS, 12, 0)]
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Introduced (PlatformName.WatchOS, 5, 0)]
		[Deprecated (PlatformName.WatchOS, 6, 0)]
		[Introduced (PlatformName.TvOS, 12, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[Introduced (PlatformName.MacCatalyst, 13, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_min_version (SecProtocolOptions options, SSLProtocol version);

		// extern void sec_protocol_options_set_min_tls_protocol_version (sec_protocol_options_t _Nonnull options, tls_protocol_version_t version) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_min_tls_protocol_version (SecProtocolOptions options, tls_protocol_version_t version);

		// extern tls_protocol_version_t sec_protocol_options_get_default_min_tls_protocol_version () __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern tls_protocol_version_t sec_protocol_options_get_default_min_tls_protocol_version ();

		// extern tls_protocol_version_t sec_protocol_options_get_default_min_dtls_protocol_version () __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern tls_protocol_version_t sec_protocol_options_get_default_min_dtls_protocol_version ();

		// extern void sec_protocol_options_set_tls_max_version (sec_protocol_options_t _Nonnull options, SSLProtocol version) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0))) __attribute__((availability(maccatalyst, introduced=13.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14)]
		[Deprecated (PlatformName.MacOSX, 10, 15)]
		[Introduced (PlatformName.iOS, 12, 0)]
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Introduced (PlatformName.WatchOS, 5, 0)]
		[Deprecated (PlatformName.WatchOS, 6, 0)]
		[Introduced (PlatformName.TvOS, 12, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[Introduced (PlatformName.MacCatalyst, 13, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_max_version (SecProtocolOptions options, SSLProtocol version);

		// extern void sec_protocol_options_set_max_tls_protocol_version (sec_protocol_options_t _Nonnull options, tls_protocol_version_t version) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_max_tls_protocol_version (SecProtocolOptions options, tls_protocol_version_t version);

		// extern tls_protocol_version_t sec_protocol_options_get_default_max_tls_protocol_version () __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern tls_protocol_version_t sec_protocol_options_get_default_max_tls_protocol_version ();

		// extern tls_protocol_version_t sec_protocol_options_get_default_max_dtls_protocol_version () __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern tls_protocol_version_t sec_protocol_options_get_default_max_dtls_protocol_version ();

		// extern _Bool sec_protocol_options_get_enable_encrypted_client_hello (sec_protocol_options_t _Nonnull options) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoMac, NoiOS]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_options_get_enable_encrypted_client_hello (SecProtocolOptions options);

		// extern _Bool sec_protocol_options_get_quic_use_legacy_codepoint (sec_protocol_options_t _Nonnull options) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoMac, NoiOS]
		[DllImport ("__Internal")]
		static extern bool sec_protocol_options_get_quic_use_legacy_codepoint (SecProtocolOptions options);

		// extern void sec_protocol_options_add_tls_application_protocol (sec_protocol_options_t _Nonnull options, const char * _Nonnull application_protocol) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe void sec_protocol_options_add_tls_application_protocol (SecProtocolOptions options, sbyte* application_protocol);

		// extern void sec_protocol_options_set_tls_server_name (sec_protocol_options_t _Nonnull options, const char * _Nonnull server_name) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern unsafe void sec_protocol_options_set_tls_server_name (SecProtocolOptions options, sbyte* server_name);

		// extern void sec_protocol_options_set_tls_diffie_hellman_parameters (sec_protocol_options_t _Nonnull options, dispatch_data_t _Nonnull params) __attribute__((availability(macos, introduced=10.14, deprecated=10.15))) __attribute__((availability(ios, introduced=12.0, deprecated=13.0))) __attribute__((availability(watchos, introduced=5.0, deprecated=6.0))) __attribute__((availability(tvos, introduced=12.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 14, message: "DHE ciphersuites are no longer supported")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "DHE ciphersuites are no longer supported")]
		[Introduced (PlatformName.iOS, 12, 0, message: "DHE ciphersuites are no longer supported")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "DHE ciphersuites are no longer supported")]
		[Introduced (PlatformName.WatchOS, 5, 0, message: "DHE ciphersuites are no longer supported")]
		[Deprecated (PlatformName.WatchOS, 6, 0, message: "DHE ciphersuites are no longer supported")]
		[Introduced (PlatformName.TvOS, 12, 0, message: "DHE ciphersuites are no longer supported")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "DHE ciphersuites are no longer supported")]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_diffie_hellman_parameters (SecProtocolOptions options, DispatchData @params);

		// extern void sec_protocol_options_add_pre_shared_key (sec_protocol_options_t _Nonnull options, dispatch_data_t _Nonnull psk, dispatch_data_t _Nonnull psk_identity) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_add_pre_shared_key (SecProtocolOptions options, DispatchData psk, DispatchData psk_identity);

		// extern void sec_protocol_options_set_tls_pre_shared_key_identity_hint (sec_protocol_options_t _Nonnull options, dispatch_data_t _Nonnull psk_identity_hint) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_pre_shared_key_identity_hint (SecProtocolOptions options, DispatchData psk_identity_hint);

		// extern void sec_protocol_options_set_pre_shared_key_selection_block (sec_protocol_options_t _Nonnull options, sec_protocol_pre_shared_key_selection_t _Nonnull psk_selection_block, dispatch_queue_t _Nonnull psk_selection_queue) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_pre_shared_key_selection_block (SecProtocolOptions options, sec_protocol_pre_shared_key_selection_t psk_selection_block, DispatchQueue psk_selection_queue);

		// extern void sec_protocol_options_set_tls_tickets_enabled (sec_protocol_options_t _Nonnull options, _Bool tickets_enabled) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_tickets_enabled (SecProtocolOptions options, bool tickets_enabled);

		// extern void sec_protocol_options_set_tls_is_fallback_attempt (sec_protocol_options_t _Nonnull options, _Bool is_fallback_attempt) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_is_fallback_attempt (SecProtocolOptions options, bool is_fallback_attempt);

		// extern void sec_protocol_options_set_tls_resumption_enabled (sec_protocol_options_t _Nonnull options, _Bool resumption_enabled) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_resumption_enabled (SecProtocolOptions options, bool resumption_enabled);

		// extern void sec_protocol_options_set_tls_false_start_enabled (sec_protocol_options_t _Nonnull options, _Bool false_start_enabled) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_false_start_enabled (SecProtocolOptions options, bool false_start_enabled);

		// extern void sec_protocol_options_set_tls_ocsp_enabled (sec_protocol_options_t _Nonnull options, _Bool ocsp_enabled) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_ocsp_enabled (SecProtocolOptions options, bool ocsp_enabled);

		// extern void sec_protocol_options_set_tls_sct_enabled (sec_protocol_options_t _Nonnull options, _Bool sct_enabled) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_sct_enabled (SecProtocolOptions options, bool sct_enabled);

		// extern void sec_protocol_options_set_tls_renegotiation_enabled (sec_protocol_options_t _Nonnull options, _Bool renegotiation_enabled) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_tls_renegotiation_enabled (SecProtocolOptions options, bool renegotiation_enabled);

		// extern void sec_protocol_options_set_peer_authentication_required (sec_protocol_options_t _Nonnull options, _Bool peer_authentication_required) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_peer_authentication_required (SecProtocolOptions options, bool peer_authentication_required);

		// extern void sec_protocol_options_set_peer_authentication_optional (sec_protocol_options_t _Nonnull options, _Bool peer_authentication_optional) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoMac, NoiOS]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_peer_authentication_optional (SecProtocolOptions options, bool peer_authentication_optional);

		// extern void sec_protocol_options_set_enable_encrypted_client_hello (sec_protocol_options_t _Nonnull options, _Bool enable_encrypted_client_hello) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoMac, NoiOS]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_enable_encrypted_client_hello (SecProtocolOptions options, bool enable_encrypted_client_hello);

		// extern void sec_protocol_options_set_quic_use_legacy_codepoint (sec_protocol_options_t _Nonnull options, _Bool quic_use_legacy_codepoint) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoMac, NoiOS]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_quic_use_legacy_codepoint (SecProtocolOptions options, bool quic_use_legacy_codepoint);

		// extern void sec_protocol_options_set_key_update_block (sec_protocol_options_t _Nonnull options, sec_protocol_key_update_t _Nonnull key_update_block, dispatch_queue_t _Nonnull key_update_queue) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_key_update_block (SecProtocolOptions options, sec_protocol_key_update_t key_update_block, DispatchQueue key_update_queue);

		// extern void sec_protocol_options_set_challenge_block (sec_protocol_options_t _Nonnull options, sec_protocol_challenge_t _Nonnull challenge_block, dispatch_queue_t _Nonnull challenge_queue) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_challenge_block (SecProtocolOptions options, sec_protocol_challenge_t challenge_block, DispatchQueue challenge_queue);

		// extern void sec_protocol_options_set_verify_block (sec_protocol_options_t _Nonnull options, sec_protocol_verify_t _Nonnull verify_block, dispatch_queue_t _Nonnull verify_block_queue) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5,0), TV (12,0), Mac (10,14), iOS (12,0)]
		[DllImport ("__Internal")]
		static extern void sec_protocol_options_set_verify_block (SecProtocolOptions options, sec_protocol_verify_t verify_block, DispatchQueue verify_block_queue);

		// extern CFTypeID CFHostGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern nuint CFHostGetTypeID ();

		// extern CFHostRef _Nonnull CFHostCreateWithName (CFAllocatorRef _Nullable allocator, CFStringRef _Nonnull hostname) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe CFHostRef* CFHostCreateWithName ([NullAllowed] CFAllocatorRef* allocator, CFStringRef* hostname);

		// extern CFHostRef _Nonnull CFHostCreateWithAddress (CFAllocatorRef _Nullable allocator, CFDataRef _Nonnull addr) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe CFHostRef* CFHostCreateWithAddress ([NullAllowed] CFAllocatorRef* allocator, CFDataRef* addr);

		// extern CFHostRef _Nonnull CFHostCreateCopy (CFAllocatorRef _Nullable alloc, CFHostRef _Nonnull host) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe CFHostRef* CFHostCreateCopy ([NullAllowed] CFAllocatorRef* alloc, CFHostRef* host);

		// extern Boolean CFHostStartInfoResolution (CFHostRef _Nonnull theHost, CFHostInfoType info, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHostStartInfoResolution (CFHostRef* theHost, CFHostInfoType info, [NullAllowed] CFStreamError* error);

		// extern CFArrayRef _Nullable CFHostGetAddressing (CFHostRef _Nonnull theHost, Boolean * _Nullable hasBeenResolved) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* CFHostGetAddressing (CFHostRef* theHost, [NullAllowed] byte* hasBeenResolved);

		// extern CFArrayRef _Nullable CFHostGetNames (CFHostRef _Nonnull theHost, Boolean * _Nullable hasBeenResolved) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* CFHostGetNames (CFHostRef* theHost, [NullAllowed] byte* hasBeenResolved);

		// extern CFDataRef _Nullable CFHostGetReachability (CFHostRef _Nonnull theHost, Boolean * _Nullable hasBeenResolved) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* CFHostGetReachability (CFHostRef* theHost, [NullAllowed] byte* hasBeenResolved);

		// extern void CFHostCancelInfoResolution (CFHostRef _Nonnull theHost, CFHostInfoType info) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe void CFHostCancelInfoResolution (CFHostRef* theHost, CFHostInfoType info);

		// extern Boolean CFHostSetClient (CFHostRef _Nonnull theHost, CFHostClientCallBack _Nullable clientCB, CFHostClientContext * _Nullable clientContext) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHostSetClient (CFHostRef* theHost, [NullAllowed] CFHostClientCallBack* clientCB, [NullAllowed] CFHostClientContext* clientContext);

		// extern void CFHostScheduleWithRunLoop (CFHostRef _Nonnull theHost, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe void CFHostScheduleWithRunLoop (CFHostRef* theHost, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern void CFHostUnscheduleFromRunLoop (CFHostRef _Nonnull theHost, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead, see deprecation notice in <CFNetwork/CFHost.h>")]
		[DllImport ("__Internal")]
		static extern unsafe void CFHostUnscheduleFromRunLoop (CFHostRef* theHost, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern CFTypeID CFNetServiceGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern nuint CFNetServiceGetTypeID ();

		// extern CFTypeID CFNetServiceMonitorGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern nuint CFNetServiceMonitorGetTypeID ();

		// extern CFTypeID CFNetServiceBrowserGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern nuint CFNetServiceBrowserGetTypeID ();

		// extern CFNetServiceRef _Nonnull CFNetServiceCreate (CFAllocatorRef _Nullable alloc, CFStringRef _Nonnull domain, CFStringRef _Nonnull serviceType, CFStringRef _Nonnull name, SInt32 port) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFNetServiceRef* CFNetServiceCreate ([NullAllowed] CFAllocatorRef* alloc, CFStringRef* domain, CFStringRef* serviceType, CFStringRef* name, int port);

		// extern CFNetServiceRef _Nonnull CFNetServiceCreateCopy (CFAllocatorRef _Nullable alloc, CFNetServiceRef _Nonnull service) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFNetServiceRef* CFNetServiceCreateCopy ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceRef* service);

		// extern CFStringRef _Nonnull CFNetServiceGetDomain (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFNetServiceGetDomain (CFNetServiceRef* theService);

		// extern CFStringRef _Nonnull CFNetServiceGetType (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFNetServiceGetType (CFNetServiceRef* theService);

		// extern CFStringRef _Nonnull CFNetServiceGetName (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFNetServiceGetName (CFNetServiceRef* theService);

		// extern Boolean CFNetServiceRegisterWithOptions (CFNetServiceRef _Nonnull theService, CFOptionFlags options, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceRegisterWithOptions (CFNetServiceRef* theService, nuint options, [NullAllowed] CFStreamError* error);

		// extern Boolean CFNetServiceResolveWithTimeout (CFNetServiceRef _Nonnull theService, CFTimeInterval timeout, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceResolveWithTimeout (CFNetServiceRef* theService, double timeout, [NullAllowed] CFStreamError* error);

		// extern void CFNetServiceCancel (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceCancel (CFNetServiceRef* theService);

		// extern CFStringRef _Nullable CFNetServiceGetTargetHost (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* CFNetServiceGetTargetHost (CFNetServiceRef* theService);

		// extern SInt32 CFNetServiceGetPortNumber (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.5, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 5, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe int CFNetServiceGetPortNumber (CFNetServiceRef* theService);

		// extern CFArrayRef _Nullable CFNetServiceGetAddressing (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* CFNetServiceGetAddressing (CFNetServiceRef* theService);

		// extern CFDataRef _Nullable CFNetServiceGetTXTData (CFNetServiceRef _Nonnull theService) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* CFNetServiceGetTXTData (CFNetServiceRef* theService);

		// extern Boolean CFNetServiceSetTXTData (CFNetServiceRef _Nonnull theService, CFDataRef _Nonnull txtRecord) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceSetTXTData (CFNetServiceRef* theService, CFDataRef* txtRecord);

		// extern CFDictionaryRef _Nullable CFNetServiceCreateDictionaryWithTXTData (CFAllocatorRef _Nullable alloc, CFDataRef _Nonnull txtRecord) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDictionaryRef* CFNetServiceCreateDictionaryWithTXTData ([NullAllowed] CFAllocatorRef* alloc, CFDataRef* txtRecord);

		// extern CFDataRef _Nullable CFNetServiceCreateTXTDataWithDictionary (CFAllocatorRef _Nullable alloc, CFDictionaryRef _Nonnull keyValuePairs) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* CFNetServiceCreateTXTDataWithDictionary ([NullAllowed] CFAllocatorRef* alloc, CFDictionaryRef* keyValuePairs);

		// extern Boolean CFNetServiceSetClient (CFNetServiceRef _Nonnull theService, CFNetServiceClientCallBack _Nullable clientCB, CFNetServiceClientContext * _Nullable clientContext) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceSetClient (CFNetServiceRef* theService, [NullAllowed] CFNetServiceClientCallBack* clientCB, [NullAllowed] CFNetServiceClientContext* clientContext);

		// extern void CFNetServiceScheduleWithRunLoop (CFNetServiceRef _Nonnull theService, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceScheduleWithRunLoop (CFNetServiceRef* theService, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern void CFNetServiceUnscheduleFromRunLoop (CFNetServiceRef _Nonnull theService, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceUnscheduleFromRunLoop (CFNetServiceRef* theService, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern CFNetServiceMonitorRef _Nonnull CFNetServiceMonitorCreate (CFAllocatorRef _Nullable alloc, CFNetServiceRef _Nonnull theService, CFNetServiceMonitorClientCallBack _Nonnull clientCB, CFNetServiceClientContext * _Nonnull clientContext) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFNetServiceMonitorRef* CFNetServiceMonitorCreate ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceRef* theService, CFNetServiceMonitorClientCallBack* clientCB, CFNetServiceClientContext* clientContext);

		// extern void CFNetServiceMonitorInvalidate (CFNetServiceMonitorRef _Nonnull monitor) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceMonitorInvalidate (CFNetServiceMonitorRef* monitor);

		// extern Boolean CFNetServiceMonitorStart (CFNetServiceMonitorRef _Nonnull monitor, CFNetServiceMonitorType recordType, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceMonitorStart (CFNetServiceMonitorRef* monitor, CFNetServiceMonitorType recordType, [NullAllowed] CFStreamError* error);

		// extern void CFNetServiceMonitorStop (CFNetServiceMonitorRef _Nonnull monitor, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceMonitorStop (CFNetServiceMonitorRef* monitor, [NullAllowed] CFStreamError* error);

		// extern void CFNetServiceMonitorScheduleWithRunLoop (CFNetServiceMonitorRef _Nonnull monitor, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceMonitorScheduleWithRunLoop (CFNetServiceMonitorRef* monitor, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern void CFNetServiceMonitorUnscheduleFromRunLoop (CFNetServiceMonitorRef _Nonnull monitor, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.4, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceMonitorUnscheduleFromRunLoop (CFNetServiceMonitorRef* monitor, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern CFNetServiceBrowserRef _Nonnull CFNetServiceBrowserCreate (CFAllocatorRef _Nullable alloc, CFNetServiceBrowserClientCallBack _Nonnull clientCB, CFNetServiceClientContext * _Nonnull clientContext) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe CFNetServiceBrowserRef* CFNetServiceBrowserCreate ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceBrowserClientCallBack* clientCB, CFNetServiceClientContext* clientContext);

		// extern void CFNetServiceBrowserInvalidate (CFNetServiceBrowserRef _Nonnull browser) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceBrowserInvalidate (CFNetServiceBrowserRef* browser);

		// extern Boolean CFNetServiceBrowserSearchForDomains (CFNetServiceBrowserRef _Nonnull browser, Boolean registrationDomains, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceBrowserSearchForDomains (CFNetServiceBrowserRef* browser, byte registrationDomains, [NullAllowed] CFStreamError* error);

		// extern Boolean CFNetServiceBrowserSearchForServices (CFNetServiceBrowserRef _Nonnull browser, CFStringRef _Nonnull domain, CFStringRef _Nonnull serviceType, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceBrowserSearchForServices (CFNetServiceBrowserRef* browser, CFStringRef* domain, CFStringRef* serviceType, [NullAllowed] CFStreamError* error);

		// extern void CFNetServiceBrowserStopSearch (CFNetServiceBrowserRef _Nonnull browser, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceBrowserStopSearch (CFNetServiceBrowserRef* browser, [NullAllowed] CFStreamError* error);

		// extern void CFNetServiceBrowserScheduleWithRunLoop (CFNetServiceBrowserRef _Nonnull browser, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceBrowserScheduleWithRunLoop (CFNetServiceBrowserRef* browser, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern void CFNetServiceBrowserUnscheduleFromRunLoop (CFNetServiceBrowserRef _Nonnull browser, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.2, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use nw_browser_t or nw_listener_t in Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetServiceBrowserUnscheduleFromRunLoop (CFNetServiceBrowserRef* browser, CFRunLoop runLoop, CFStringRef* runLoopMode);

		// extern Boolean CFNetServiceRegister (CFNetServiceRef _Nonnull theService, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceRegister (CFNetServiceRef* theService, [NullAllowed] CFStreamError* error);

		// extern Boolean CFNetServiceResolve (CFNetServiceRef _Nonnull theService, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[DllImport ("__Internal")]
		static extern unsafe byte CFNetServiceResolve (CFNetServiceRef* theService, [NullAllowed] CFStreamError* error);

		// SInt32 CFSocketStreamSOCKSGetErrorSubdomain (const CFStreamError * _Nonnull error) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe int CFSocketStreamSOCKSGetErrorSubdomain (CFStreamError* error);

		// SInt32 CFSocketStreamSOCKSGetError (const CFStreamError * _Nonnull error) __attribute__((always_inline));
		[DllImport ("__Internal")]
		static extern unsafe int CFSocketStreamSOCKSGetError (CFStreamError* error);

		// extern void CFStreamCreatePairWithSocketToCFHost (CFAllocatorRef _Nullable alloc, CFHostRef _Nonnull host, SInt32 port, CFReadStreamRef  _Nullable * _Nullable readStream, CFWriteStreamRef  _Nullable * _Nullable writeStream) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFStreamCreatePairWithSocketToCFHost ([NullAllowed] CFAllocatorRef* alloc, CFHostRef* host, int port, [NullAllowed] CFReadStreamRef** readStream, [NullAllowed] CFWriteStreamRef** writeStream);

		// extern void CFStreamCreatePairWithSocketToNetService (CFAllocatorRef _Nullable alloc, CFNetServiceRef _Nonnull service, CFReadStreamRef  _Nullable * _Nullable readStream, CFWriteStreamRef  _Nullable * _Nullable writeStream) __attribute__((visibility("default"))) __attribute__((availability(macos, introduced=10.3, deprecated=100000))) __attribute__((availability(ios, introduced=2.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "Use Network framework instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use Network framework instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use Network framework instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use Network framework instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use Network framework instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use Network framework instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use Network framework instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use Network framework instead")]
		[DllImport ("__Internal")]
		static extern unsafe void CFStreamCreatePairWithSocketToNetService ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceRef* service, [NullAllowed] CFReadStreamRef** readStream, [NullAllowed] CFWriteStreamRef** writeStream);

		// extern CFReadStreamRef _Nonnull CFReadStreamCreateWithFTPURL (CFAllocatorRef _Nullable alloc, CFURLRef _Nonnull ftpURL) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[DllImport ("__Internal")]
		static extern unsafe CFReadStreamRef* CFReadStreamCreateWithFTPURL ([NullAllowed] CFAllocatorRef* alloc, CFURLRef* ftpURL);

		// extern CFIndex CFFTPCreateParsedResourceListing (CFAllocatorRef _Nullable alloc, const UInt8 * _Nonnull buffer, CFIndex bufferLength, CFDictionaryRef  _Nullable * _Nullable parsed) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[DllImport ("__Internal")]
		static extern unsafe nint CFFTPCreateParsedResourceListing ([NullAllowed] CFAllocatorRef* alloc, byte* buffer, nint bufferLength, [NullAllowed] CFDictionaryRef** parsed);

		// extern CFWriteStreamRef _Nonnull CFWriteStreamCreateWithFTPURL (CFAllocatorRef _Nullable alloc, CFURLRef _Nonnull ftpURL) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[DllImport ("__Internal")]
		static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithFTPURL ([NullAllowed] CFAllocatorRef* alloc, CFURLRef* ftpURL);

		// extern CFTypeID CFHTTPMessageGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint CFHTTPMessageGetTypeID ();

		// extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateRequest (CFAllocatorRef _Nullable alloc, CFStringRef _Nonnull requestMethod, CFURLRef _Nonnull url, CFStringRef _Nonnull httpVersion) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateRequest ([NullAllowed] CFAllocatorRef* alloc, CFStringRef* requestMethod, CFURLRef* url, CFStringRef* httpVersion);

		// extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateResponse (CFAllocatorRef _Nullable alloc, CFIndex statusCode, CFStringRef _Nullable statusDescription, CFStringRef _Nonnull httpVersion) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateResponse ([NullAllowed] CFAllocatorRef* alloc, nint statusCode, [NullAllowed] CFStringRef* statusDescription, CFStringRef* httpVersion);

		// extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateEmpty (CFAllocatorRef _Nullable alloc, Boolean isRequest) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateEmpty ([NullAllowed] CFAllocatorRef* alloc, byte isRequest);

		// extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateCopy (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateCopy ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* message);

		// extern Boolean CFHTTPMessageIsRequest (CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPMessageIsRequest (CFHTTPMessageRef* message);

		// extern CFStringRef _Nonnull CFHTTPMessageCopyVersion (CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFHTTPMessageCopyVersion (CFHTTPMessageRef* message);

		// extern CFDataRef _Nullable CFHTTPMessageCopyBody (CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* CFHTTPMessageCopyBody (CFHTTPMessageRef* message);

		// extern void CFHTTPMessageSetBody (CFHTTPMessageRef _Nonnull message, CFDataRef _Nonnull bodyData) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFHTTPMessageSetBody (CFHTTPMessageRef* message, CFDataRef* bodyData);

		// extern CFStringRef _Nullable CFHTTPMessageCopyHeaderFieldValue (CFHTTPMessageRef _Nonnull message, CFStringRef _Nonnull headerField) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* CFHTTPMessageCopyHeaderFieldValue (CFHTTPMessageRef* message, CFStringRef* headerField);

		// extern CFDictionaryRef _Nullable CFHTTPMessageCopyAllHeaderFields (CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDictionaryRef* CFHTTPMessageCopyAllHeaderFields (CFHTTPMessageRef* message);

		// extern void CFHTTPMessageSetHeaderFieldValue (CFHTTPMessageRef _Nonnull message, CFStringRef _Nonnull headerField, CFStringRef _Nullable value) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFHTTPMessageSetHeaderFieldValue (CFHTTPMessageRef* message, CFStringRef* headerField, [NullAllowed] CFStringRef* value);

		// extern Boolean CFHTTPMessageAppendBytes (CFHTTPMessageRef _Nonnull message, const UInt8 * _Nonnull newBytes, CFIndex numBytes) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPMessageAppendBytes (CFHTTPMessageRef* message, byte* newBytes, nint numBytes);

		// extern Boolean CFHTTPMessageIsHeaderComplete (CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPMessageIsHeaderComplete (CFHTTPMessageRef* message);

		// extern CFDataRef _Nullable CFHTTPMessageCopySerializedMessage (CFHTTPMessageRef _Nonnull message) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDataRef* CFHTTPMessageCopySerializedMessage (CFHTTPMessageRef* message);

		// extern CFURLRef _Nullable CFHTTPMessageCopyRequestURL (CFHTTPMessageRef _Nonnull request) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFURLRef* CFHTTPMessageCopyRequestURL (CFHTTPMessageRef* request);

		// extern CFStringRef _Nullable CFHTTPMessageCopyRequestMethod (CFHTTPMessageRef _Nonnull request) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* CFHTTPMessageCopyRequestMethod (CFHTTPMessageRef* request);

		// extern Boolean CFHTTPMessageAddAuthentication (CFHTTPMessageRef _Nonnull request, CFHTTPMessageRef _Nullable authenticationFailureResponse, CFStringRef _Nonnull username, CFStringRef _Nonnull password, CFStringRef _Nullable authenticationScheme, Boolean forProxy) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPMessageAddAuthentication (CFHTTPMessageRef* request, [NullAllowed] CFHTTPMessageRef* authenticationFailureResponse, CFStringRef* username, CFStringRef* password, [NullAllowed] CFStringRef* authenticationScheme, byte forProxy);

		// extern CFIndex CFHTTPMessageGetResponseStatusCode (CFHTTPMessageRef _Nonnull response) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFHTTPMessageGetResponseStatusCode (CFHTTPMessageRef* response);

		// extern CFStringRef _Nullable CFHTTPMessageCopyResponseStatusLine (CFHTTPMessageRef _Nonnull response) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFStringRef* CFHTTPMessageCopyResponseStatusLine (CFHTTPMessageRef* response);

		// extern CFReadStreamRef _Nonnull CFReadStreamCreateForHTTPRequest (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull request) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[DllImport ("__Internal")]
		static extern unsafe CFReadStreamRef* CFReadStreamCreateForHTTPRequest ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* request);

		// extern CFReadStreamRef _Nonnull CFReadStreamCreateForStreamedHTTPRequest (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull requestHeaders, CFReadStreamRef _Nonnull requestBody) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[DllImport ("__Internal")]
		static extern unsafe CFReadStreamRef* CFReadStreamCreateForStreamedHTTPRequest ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* requestHeaders, CFReadStreamRef* requestBody);

		// extern CFTypeID CFHTTPAuthenticationGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern nuint CFHTTPAuthenticationGetTypeID ();

		// extern CFHTTPAuthenticationRef _Nonnull CFHTTPAuthenticationCreateFromResponse (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull response) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFHTTPAuthenticationRef* CFHTTPAuthenticationCreateFromResponse ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* response);

		// extern Boolean CFHTTPAuthenticationIsValid (CFHTTPAuthenticationRef _Nonnull auth, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPAuthenticationIsValid (CFHTTPAuthenticationRef* auth, [NullAllowed] CFStreamError* error);

		// extern Boolean CFHTTPAuthenticationAppliesToRequest (CFHTTPAuthenticationRef _Nonnull auth, CFHTTPMessageRef _Nonnull request) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPAuthenticationAppliesToRequest (CFHTTPAuthenticationRef* auth, CFHTTPMessageRef* request);

		// extern Boolean CFHTTPAuthenticationRequiresOrderedRequests (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPAuthenticationRequiresOrderedRequests (CFHTTPAuthenticationRef* auth);

		// extern Boolean CFHTTPMessageApplyCredentials (CFHTTPMessageRef _Nonnull request, CFHTTPAuthenticationRef _Nonnull auth, CFStringRef _Nullable username, CFStringRef _Nullable password, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPMessageApplyCredentials (CFHTTPMessageRef* request, CFHTTPAuthenticationRef* auth, [NullAllowed] CFStringRef* username, [NullAllowed] CFStringRef* password, [NullAllowed] CFStreamError* error);

		// extern Boolean CFHTTPMessageApplyCredentialDictionary (CFHTTPMessageRef _Nonnull request, CFHTTPAuthenticationRef _Nonnull auth, CFDictionaryRef _Nonnull dict, CFStreamError * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPMessageApplyCredentialDictionary (CFHTTPMessageRef* request, CFHTTPAuthenticationRef* auth, CFDictionaryRef* dict, [NullAllowed] CFStreamError* error);

		// extern CFStringRef _Nonnull CFHTTPAuthenticationCopyRealm (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFHTTPAuthenticationCopyRealm (CFHTTPAuthenticationRef* auth);

		// extern CFArrayRef _Nonnull CFHTTPAuthenticationCopyDomains (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFHTTPAuthenticationCopyDomains (CFHTTPAuthenticationRef* auth);

		// extern CFStringRef _Nonnull CFHTTPAuthenticationCopyMethod (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFStringRef* CFHTTPAuthenticationCopyMethod (CFHTTPAuthenticationRef* auth);

		// extern Boolean CFHTTPAuthenticationRequiresUserNameAndPassword (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPAuthenticationRequiresUserNameAndPassword (CFHTTPAuthenticationRef* auth);

		// extern Boolean CFHTTPAuthenticationRequiresAccountDomain (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe byte CFHTTPAuthenticationRequiresAccountDomain (CFHTTPAuthenticationRef* auth);

		// extern CFNetDiagnosticRef _Nonnull CFNetDiagnosticCreateWithStreams (CFAllocatorRef _Nullable alloc, CFReadStreamRef _Nullable readStream, CFWriteStreamRef _Nullable writeStream) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=11.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[DllImport ("__Internal")]
		static extern unsafe CFNetDiagnosticRef* CFNetDiagnosticCreateWithStreams ([NullAllowed] CFAllocatorRef* alloc, [NullAllowed] CFReadStreamRef* readStream, [NullAllowed] CFWriteStreamRef* writeStream);

		// extern CFNetDiagnosticRef _Nonnull CFNetDiagnosticCreateWithURL (CFAllocatorRef _Nonnull alloc, CFURLRef _Nonnull url) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=11.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[DllImport ("__Internal")]
		static extern unsafe CFNetDiagnosticRef* CFNetDiagnosticCreateWithURL (CFAllocatorRef* alloc, CFURLRef* url);

		// extern void CFNetDiagnosticSetName (CFNetDiagnosticRef _Nonnull details, CFStringRef _Nonnull name) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=11.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[DllImport ("__Internal")]
		static extern unsafe void CFNetDiagnosticSetName (CFNetDiagnosticRef* details, CFStringRef* name);

		// extern CFNetDiagnosticStatus CFNetDiagnosticDiagnoseProblemInteractively (CFNetDiagnosticRef _Nonnull details) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=11.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFNetDiagnosticDiagnoseProblemInteractively (CFNetDiagnosticRef* details);

		// extern CFNetDiagnosticStatus CFNetDiagnosticCopyNetworkStatusPassively (CFNetDiagnosticRef _Nonnull details, CFStringRef  _Nullable * _Nullable description) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0, deprecated=11.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[DllImport ("__Internal")]
		static extern unsafe nint CFNetDiagnosticCopyNetworkStatusPassively (CFNetDiagnosticRef* details, [NullAllowed] CFStringRef** description);

		// extern CFDictionaryRef _Nullable CFNetworkCopySystemProxySettings () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFDictionaryRef* CFNetworkCopySystemProxySettings ();

		// extern CFArrayRef _Nonnull CFNetworkCopyProxiesForURL (CFURLRef _Nonnull url, CFDictionaryRef _Nonnull proxySettings) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFArrayRef* CFNetworkCopyProxiesForURL (CFURLRef* url, CFDictionaryRef* proxySettings);

		// extern CFArrayRef _Nullable CFNetworkCopyProxiesForAutoConfigurationScript (CFStringRef _Nonnull proxyAutoConfigurationScript, CFURLRef _Nonnull targetURL, CFErrorRef  _Nullable * _Nullable error) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe CFArrayRef* CFNetworkCopyProxiesForAutoConfigurationScript (CFStringRef* proxyAutoConfigurationScript, CFURLRef* targetURL, [NullAllowed] CFErrorRef** error);

		// extern CFRunLoopSourceRef _Nonnull CFNetworkExecuteProxyAutoConfigurationScript (CFStringRef _Nonnull proxyAutoConfigurationScript, CFURLRef _Nonnull targetURL, CFProxyAutoConfigurationResultCallback _Nonnull cb, CFStreamClientContext * _Nonnull clientContext) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFNetworkExecuteProxyAutoConfigurationScript (CFStringRef* proxyAutoConfigurationScript, CFURLRef* targetURL, CFProxyAutoConfigurationResultCallback* cb, CFStreamClientContext* clientContext);

		// extern CFRunLoopSourceRef _Nonnull CFNetworkExecuteProxyAutoConfigurationURL (CFURLRef _Nonnull proxyAutoConfigURL, CFURLRef _Nonnull targetURL, CFProxyAutoConfigurationResultCallback _Nonnull cb, CFStreamClientContext * _Nonnull clientContext) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
		[iOS (2,0)]
		[DllImport ("__Internal")]
		static extern unsafe CFRunLoopSourceRef* CFNetworkExecuteProxyAutoConfigurationURL (CFURLRef* proxyAutoConfigURL, CFURLRef* targetURL, CFProxyAutoConfigurationResultCallback* cb, CFStreamClientContext* clientContext);

		// extern int audit (const void *, int) __attribute__((availability(macos, introduced=10.4, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "audit is deprecated")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "audit is deprecated")]
		[DllImport ("__Internal")]
		static extern unsafe int audit (void*, int);

		// extern int auditon (int, void *, int) __attribute__((availability(macos, introduced=10.4, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "audit is deprecated")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "audit is deprecated")]
		[DllImport ("__Internal")]
		static extern unsafe int auditon (int, void*, int);

		// extern int auditctl (const char *) __attribute__((availability(macos, introduced=10.4, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "audit is deprecated")]
		[Deprecated (PlatformName.MacOSX, 11, 0, message: "audit is deprecated")]
		[DllImport ("__Internal")]
		static extern unsafe int auditctl (sbyte*);

		// extern int getauid (au_id_t *);
		[DllImport ("__Internal")]
		static extern unsafe int getauid (uint*);

		// extern int setauid (const au_id_t *);
		[DllImport ("__Internal")]
		static extern unsafe int setauid (uint*);

		// extern int getaudit_addr (struct auditinfo_addr *, int);
		[DllImport ("__Internal")]
		static extern unsafe int getaudit_addr (auditinfo_addr*, int);

		// extern int setaudit_addr (const struct auditinfo_addr *, int);
		[DllImport ("__Internal")]
		static extern unsafe int setaudit_addr (auditinfo_addr*, int);

		// extern int getaudit (struct auditinfo *) __attribute__((availability(ios, introduced=2.0, deprecated=6.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 6, 0)]
		[DllImport ("__Internal")]
		static extern unsafe int getaudit (auditinfo*);

		// extern int setaudit (const struct auditinfo *) __attribute__((availability(ios, introduced=2.0, deprecated=6.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 6, 0)]
		[DllImport ("__Internal")]
		static extern unsafe int setaudit (auditinfo*);

		// extern mach_port_name_t audit_session_self ();
		[DllImport ("__Internal")]
		static extern uint audit_session_self ();

		// extern au_asid_t audit_session_join (mach_port_name_t port);
		[DllImport ("__Internal")]
		static extern int audit_session_join (uint port);

		// extern int audit_session_port (au_asid_t asid, mach_port_name_t *portname);
		[DllImport ("__Internal")]
		static extern unsafe int audit_session_port (int asid, uint* portname);

		// extern CFTypeID SSLContextGetTypeID () __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern nuint SSLContextGetTypeID ();

		// extern SSLContextRef _Nullable SSLCreateContext (CFAllocatorRef _Nullable alloc, SSLProtocolSide protocolSide, SSLConnectionType connectionType) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		[return: NullAllowed]
		static extern unsafe SSLContextRef* SSLCreateContext ([NullAllowed] CFAllocatorRef* alloc, SSLProtocolSide protocolSide, SSLConnectionType connectionType);

		// extern OSStatus SSLGetSessionState (SSLContextRef _Nonnull context, SSLSessionState * _Nonnull state) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetSessionState (SSLContextRef* context, SSLSessionState* state);

		// extern OSStatus SSLSetSessionOption (SSLContextRef _Nonnull context, SSLSessionOption option, Boolean value) __attribute__((availability(macos, introduced=10.6, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetSessionOption (SSLContextRef* context, SSLSessionOption option, byte value);

		// extern OSStatus SSLGetSessionOption (SSLContextRef _Nonnull context, SSLSessionOption option, Boolean * _Nonnull value) __attribute__((availability(macos, introduced=10.6, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetSessionOption (SSLContextRef* context, SSLSessionOption option, byte* value);

		// extern OSStatus SSLSetIOFuncs (SSLContextRef _Nonnull context, SSLReadFunc _Nonnull readFunc, SSLWriteFunc _Nonnull writeFunc) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetIOFuncs (SSLContextRef* context, SSLReadFunc* readFunc, SSLWriteFunc* writeFunc);

		// extern OSStatus SSLSetSessionConfig (SSLContextRef _Nonnull context, CFStringRef _Nonnull config) __attribute__((availability(macos, introduced=10.12, deprecated=10.15))) __attribute__((availability(ios, introduced=10.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 12, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 10, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetSessionConfig (SSLContextRef* context, CFStringRef* config);

		// extern OSStatus SSLSetProtocolVersionMin (SSLContextRef _Nonnull context, SSLProtocol minVersion) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetProtocolVersionMin (SSLContextRef* context, SSLProtocol minVersion);

		// extern OSStatus SSLGetProtocolVersionMin (SSLContextRef _Nonnull context, SSLProtocol * _Nonnull minVersion) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetProtocolVersionMin (SSLContextRef* context, SSLProtocol* minVersion);

		// extern OSStatus SSLSetProtocolVersionMax (SSLContextRef _Nonnull context, SSLProtocol maxVersion) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetProtocolVersionMax (SSLContextRef* context, SSLProtocol maxVersion);

		// extern OSStatus SSLGetProtocolVersionMax (SSLContextRef _Nonnull context, SSLProtocol * _Nonnull maxVersion) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetProtocolVersionMax (SSLContextRef* context, SSLProtocol* maxVersion);

		// extern OSStatus SSLSetCertificate (SSLContextRef _Nonnull context, CFArrayRef _Nullable certRefs) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetCertificate (SSLContextRef* context, [NullAllowed] CFArrayRef* certRefs);

		// extern OSStatus SSLSetConnection (SSLContextRef _Nonnull context, SSLConnectionRef _Nullable connection) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetConnection (SSLContextRef* context, [NullAllowed] void* connection);

		// extern OSStatus SSLGetConnection (SSLContextRef _Nonnull context, CF_RETURNS_NOT_RETAINED SSLConnectionRef  _Nullable *connection) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetConnection (SSLContextRef* context, [NullAllowed] void** connection);

		// extern OSStatus SSLSetPeerDomainName (SSLContextRef _Nonnull context, const char * _Nullable peerName, size_t peerNameLen) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetPeerDomainName (SSLContextRef* context, [NullAllowed] sbyte* peerName, nuint peerNameLen);

		// extern OSStatus SSLGetPeerDomainNameLength (SSLContextRef _Nonnull context, size_t * _Nonnull peerNameLen) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetPeerDomainNameLength (SSLContextRef* context, nuint* peerNameLen);

		// extern OSStatus SSLGetPeerDomainName (SSLContextRef _Nonnull context, char * _Nonnull peerName, size_t * _Nonnull peerNameLen) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetPeerDomainName (SSLContextRef* context, sbyte* peerName, nuint* peerNameLen);

		// extern OSStatus SSLCopyRequestedPeerNameLength (SSLContextRef _Nonnull ctx, size_t * _Nonnull peerNameLen) __attribute__((availability(macos, introduced=10.11, deprecated=10.15))) __attribute__((availability(ios, introduced=9.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 11, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 9, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLCopyRequestedPeerNameLength (SSLContextRef* ctx, nuint* peerNameLen);

		// extern OSStatus SSLCopyRequestedPeerName (SSLContextRef _Nonnull context, char * _Nonnull peerName, size_t * _Nonnull peerNameLen) __attribute__((availability(macos, introduced=10.11, deprecated=10.15))) __attribute__((availability(ios, introduced=9.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 11, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 9, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLCopyRequestedPeerName (SSLContextRef* context, sbyte* peerName, nuint* peerNameLen);

		// extern OSStatus SSLSetDatagramHelloCookie (SSLContextRef _Nonnull dtlsContext, const void * _Nullable cookie, size_t cookieLen) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetDatagramHelloCookie (SSLContextRef* dtlsContext, [NullAllowed] void* cookie, nuint cookieLen);

		// extern OSStatus SSLSetMaxDatagramRecordSize (SSLContextRef _Nonnull dtlsContext, size_t maxSize) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetMaxDatagramRecordSize (SSLContextRef* dtlsContext, nuint maxSize);

		// extern OSStatus SSLGetMaxDatagramRecordSize (SSLContextRef _Nonnull dtlsContext, size_t * _Nonnull maxSize) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetMaxDatagramRecordSize (SSLContextRef* dtlsContext, nuint* maxSize);

		// extern OSStatus SSLGetNegotiatedProtocolVersion (SSLContextRef _Nonnull context, SSLProtocol * _Nonnull protocol) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetNegotiatedProtocolVersion (SSLContextRef* context, SSLProtocol* protocol);

		// extern OSStatus SSLGetNumberSupportedCiphers (SSLContextRef _Nonnull context, size_t * _Nonnull numCiphers) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetNumberSupportedCiphers (SSLContextRef* context, nuint* numCiphers);

		// extern OSStatus SSLGetSupportedCiphers (SSLContextRef _Nonnull context, SSLCipherSuite * _Nonnull ciphers, size_t * _Nonnull numCiphers) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetSupportedCiphers (SSLContextRef* context, ushort* ciphers, nuint* numCiphers);

		// extern OSStatus SSLGetNumberEnabledCiphers (SSLContextRef _Nonnull context, size_t * _Nonnull numCiphers) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetNumberEnabledCiphers (SSLContextRef* context, nuint* numCiphers);

		// extern OSStatus SSLSetEnabledCiphers (SSLContextRef _Nonnull context, const SSLCipherSuite * _Nonnull ciphers, size_t numCiphers) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetEnabledCiphers (SSLContextRef* context, ushort* ciphers, nuint numCiphers);

		// extern OSStatus SSLGetEnabledCiphers (SSLContextRef _Nonnull context, SSLCipherSuite * _Nonnull ciphers, size_t * _Nonnull numCiphers) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetEnabledCiphers (SSLContextRef* context, ushort* ciphers, nuint* numCiphers);

		// extern OSStatus SSLSetSessionTicketsEnabled (SSLContextRef _Nonnull context, Boolean enabled) __attribute__((availability(macos, introduced=10.13, deprecated=10.15))) __attribute__((availability(ios, introduced=11.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetSessionTicketsEnabled (SSLContextRef* context, byte enabled);

		// extern OSStatus SSLCopyPeerTrust (SSLContextRef _Nonnull context, CF_RETURNS_RETAINED SecTrustRef  _Nullable *trust) __attribute__((availability(macos, introduced=10.6, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLCopyPeerTrust (SSLContextRef* context, SecTrust* trust);

		// extern OSStatus SSLSetPeerID (SSLContextRef _Nonnull context, const void * _Nullable peerID, size_t peerIDLen) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetPeerID (SSLContextRef* context, [NullAllowed] void* peerID, nuint peerIDLen);

		// extern OSStatus SSLGetPeerID (SSLContextRef _Nonnull context, const void * _Nullable * _Nonnull peerID, size_t * _Nonnull peerIDLen) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetPeerID (SSLContextRef* context, [NullAllowed] void** peerID, nuint* peerIDLen);

		// extern OSStatus SSLGetNegotiatedCipher (SSLContextRef _Nonnull context, SSLCipherSuite * _Nonnull cipherSuite) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetNegotiatedCipher (SSLContextRef* context, ushort* cipherSuite);

		// extern OSStatus SSLSetALPNProtocols (SSLContextRef _Nonnull context, CFArrayRef _Nonnull protocols) __attribute__((availability(macos, introduced=10.13, deprecated=10.15))) __attribute__((availability(ios, introduced=11.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetALPNProtocols (SSLContextRef* context, CFArrayRef* protocols);

		// extern OSStatus SSLCopyALPNProtocols (SSLContextRef _Nonnull context, CFArrayRef  _Nullable * _Nonnull protocols) __attribute__((availability(macos, introduced=10.13, deprecated=10.15))) __attribute__((availability(ios, introduced=11.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLCopyALPNProtocols (SSLContextRef* context, [NullAllowed] CFArrayRef** protocols);

		// extern OSStatus SSLSetOCSPResponse (SSLContextRef _Nonnull context, CFDataRef _Nonnull response) __attribute__((availability(macos, introduced=10.13, deprecated=10.15))) __attribute__((availability(ios, introduced=11.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetOCSPResponse (SSLContextRef* context, CFDataRef* response);

		// extern OSStatus SSLSetEncryptionCertificate (SSLContextRef _Nonnull context, CFArrayRef _Nonnull certRefs) __attribute__((availability(macos, introduced=10.2, deprecated=10.11))) __attribute__((availability(ios, introduced=5.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetEncryptionCertificate (SSLContextRef* context, CFArrayRef* certRefs);

		// extern OSStatus SSLSetClientSideAuthenticate (SSLContextRef _Nonnull context, SSLAuthenticate auth) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetClientSideAuthenticate (SSLContextRef* context, SSLAuthenticate auth);

		// extern OSStatus SSLAddDistinguishedName (SSLContextRef _Nonnull context, const void * _Nullable derDN, size_t derDNLen) __attribute__((availability(macos, introduced=10.4, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 4, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLAddDistinguishedName (SSLContextRef* context, [NullAllowed] void* derDN, nuint derDNLen);

		// extern OSStatus SSLCopyDistinguishedNames (SSLContextRef _Nonnull context, CF_RETURNS_RETAINED CFArrayRef  _Nullable *names) __attribute__((availability(macos, introduced=10.5, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 5, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLCopyDistinguishedNames (SSLContextRef* context, [NullAllowed] CFArrayRef** names);

		// extern OSStatus SSLGetClientCertificateState (SSLContextRef _Nonnull context, SSLClientCertificateState * _Nonnull clientState) __attribute__((availability(macos, introduced=10.3, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 3, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetClientCertificateState (SSLContextRef* context, SSLClientCertificateState* clientState);

		// extern OSStatus SSLHandshake (SSLContextRef _Nonnull context) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLHandshake (SSLContextRef* context);

		// extern OSStatus SSLReHandshake (SSLContextRef _Nonnull context) __attribute__((availability(macos, introduced=10.12, deprecated=10.15))) __attribute__((availability(ios, introduced=10.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 12, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 10, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLReHandshake (SSLContextRef* context);

		// extern OSStatus SSLWrite (SSLContextRef _Nonnull context, const void * _Nullable data, size_t dataLength, size_t * _Nonnull processed) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLWrite (SSLContextRef* context, [NullAllowed] void* data, nuint dataLength, nuint* processed);

		// extern OSStatus SSLRead (SSLContextRef _Nonnull context, void * _Nonnull data, size_t dataLength, size_t * _Nonnull processed) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLRead (SSLContextRef* context, void* data, nuint dataLength, nuint* processed);

		// extern OSStatus SSLGetBufferedReadSize (SSLContextRef _Nonnull context, size_t * _Nonnull bufferSize) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetBufferedReadSize (SSLContextRef* context, nuint* bufferSize);

		// extern OSStatus SSLGetDatagramWriteSize (SSLContextRef _Nonnull dtlsContext, size_t * _Nonnull bufSize) __attribute__((availability(macos, introduced=10.8, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 8, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLGetDatagramWriteSize (SSLContextRef* dtlsContext, nuint* bufSize);

		// extern OSStatus SSLClose (SSLContextRef _Nonnull context) __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLClose (SSLContextRef* context);

		// extern OSStatus SSLSetError (SSLContextRef _Nonnull context, OSStatus status) __attribute__((availability(macos, introduced=10.13, deprecated=10.15))) __attribute__((availability(ios, introduced=11.0, deprecated=13.0))) __attribute__((cf_audited_transfer));
		[Introduced (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[DllImport ("__Internal")]
		static extern unsafe int SSLSetError (SSLContextRef* context, int status);

		// extern void uuid_clear (unsigned char *uu);
		[DllImport ("__Internal")]
		static extern void uuid_clear (byte[] uu);

		// extern int uuid_compare (const unsigned char *uu1, const unsigned char *uu2);
		[DllImport ("__Internal")]
		static extern int uuid_compare (byte[] uu1, byte[] uu2);

		// extern void uuid_copy (unsigned char *dst, const unsigned char *src);
		[DllImport ("__Internal")]
		static extern void uuid_copy (byte[] dst, byte[] src);

		// extern void uuid_generate (unsigned char *out);
		[DllImport ("__Internal")]
		static extern void uuid_generate (byte[] @out);

		// extern void uuid_generate_random (unsigned char *out);
		[DllImport ("__Internal")]
		static extern void uuid_generate_random (byte[] @out);

		// extern void uuid_generate_time (unsigned char *out);
		[DllImport ("__Internal")]
		static extern void uuid_generate_time (byte[] @out);

		// extern int uuid_is_null (const unsigned char *uu);
		[DllImport ("__Internal")]
		static extern int uuid_is_null (byte[] uu);

		// extern int uuid_parse (const char *in, unsigned char *uu);
		[DllImport ("__Internal")]
		static extern int uuid_parse (sbyte[] @in, byte[] uu);

		// extern void uuid_unparse (const unsigned char *uu, char *out);
		[DllImport ("__Internal")]
		static extern void uuid_unparse (byte[] uu, sbyte[] @out);

		// extern void uuid_unparse_lower (const unsigned char *uu, char *out);
		[DllImport ("__Internal")]
		static extern void uuid_unparse_lower (byte[] uu, sbyte[] @out);

		// extern void uuid_unparse_upper (const unsigned char *uu, char *out);
		[DllImport ("__Internal")]
		static extern void uuid_unparse_upper (byte[] uu, sbyte[] @out);
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _OSUnalignedU16
	{
		public ushort __val;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _OSUnalignedU32
	{
		public uint __val;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _OSUnalignedU64
	{
		public ulong __val;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fd_set
	{
		public int[] fds_bits;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _RuneEntry
	{
		public int __min;

		public int __max;

		public int __map;

		public unsafe uint* __types;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _RuneRange
	{
		public int __nranges;

		public unsafe _RuneEntry* __ranges;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _RuneCharClass
	{
		public sbyte[] __name;

		public uint __mask;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct _RuneLocale
	{
		public sbyte[] __magic;

		public sbyte[] __encoding;

		public unsafe Func<sbyte*, nuint, sbyte**, int>* __sgetrune;

		public unsafe Func<int, sbyte*, nuint, sbyte**, int>* __sputrune;

		public int __invalid_rune;

		public uint[] __runetype;

		public int[] __maplower;

		public int[] __mapupper;

		public _RuneRange __runetype_ext;

		public _RuneRange __maplower_ext;

		public _RuneRange __mapupper_ext;

		public unsafe void* __variable;

		public int __variable_len;

		public int __ncharclasses;

		public unsafe _RuneCharClass* __charclasses;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct lconv
	{
		public unsafe sbyte* decimal_point;

		public unsafe sbyte* thousands_sep;

		public unsafe sbyte* grouping;

		public unsafe sbyte* int_curr_symbol;

		public unsafe sbyte* currency_symbol;

		public unsafe sbyte* mon_decimal_point;

		public unsafe sbyte* mon_thousands_sep;

		public unsafe sbyte* mon_grouping;

		public unsafe sbyte* positive_sign;

		public unsafe sbyte* negative_sign;

		public sbyte int_frac_digits;

		public sbyte frac_digits;

		public sbyte p_cs_precedes;

		public sbyte p_sep_by_space;

		public sbyte n_cs_precedes;

		public sbyte n_sep_by_space;

		public sbyte p_sign_posn;

		public sbyte n_sign_posn;

		public sbyte int_p_cs_precedes;

		public sbyte int_n_cs_precedes;

		public sbyte int_p_sep_by_space;

		public sbyte int_n_sep_by_space;

		public sbyte int_p_sign_posn;

		public sbyte int_n_sign_posn;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct 
	{
		[FieldOffset (0)]
		public float __f;

		[FieldOffset (0)]
		public uint __u;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct 
	{
		[FieldOffset (0)]
		public double __f;

		[FieldOffset (0)]
		public ulong __u;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct 
	{
		[FieldOffset (0)]
		public [unsupported Builtin: long double] __f;

		[FieldOffset (0)]
		public ulong __u;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __float2
	{
		public float __sinval;

		public float __cosval;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __double2
	{
		public double __sinval;

		public double __cosval;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct exception
	{
		public int type;

		public unsafe sbyte* name;

		public double arg1;

		public double arg2;

		public double retval;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_exception_state
	{
		public uint __exception;

		public uint __fsr;

		public uint __far;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_exception_state64
	{
		public ulong __far;

		public uint __esr;

		public uint __exception;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_thread_state
	{
		public uint[] __r;

		public uint __sp;

		public uint __lr;

		public uint __pc;

		public uint __cpsr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_thread_state64
	{
		public ulong[] __x;

		public ulong __fp;

		public ulong __lr;

		public ulong __sp;

		public ulong __pc;

		public uint __cpsr;

		public uint __pad;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_vfp_state
	{
		public uint[] __r;

		public uint __fpscr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_neon_state64
	{
		public [unsupported Builtin: unsigned __int128][] __v;

		public uint __fpsr;

		public uint __fpcr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_neon_state
	{
		public [unsupported Builtin: unsigned __int128][] __v;

		public uint __fpsr;

		public uint __fpcr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __arm_pagein_state
	{
		public int __pagein_error;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __arm_legacy_debug_state
	{
		public uint[] __bvr;

		public uint[] __bcr;

		public uint[] __wvr;

		public uint[] __wcr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_debug_state32
	{
		public uint[] __bvr;

		public uint[] __bcr;

		public uint[] __wvr;

		public uint[] __wcr;

		public ulong __mdscr_el1;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_debug_state64
	{
		public ulong[] __bvr;

		public ulong[] __bcr;

		public ulong[] __wvr;

		public ulong[] __wcr;

		public ulong __mdscr_el1;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_arm_cpmu_state64
	{
		public ulong[] __ctrs;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_mcontext32
	{
		public __darwin_arm_exception_state __es;

		public __darwin_arm_thread_state __ss;

		public __darwin_arm_vfp_state __fs;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __darwin_mcontext64
	{
		public __darwin_arm_exception_state64 __es;

		public __darwin_arm_thread_state64 __ss;

		public __darwin_arm_neon_state64 __ns;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct stack_t
	{
		public unsafe void* ss_sp;

		public nuint ss_size;

		public int ss_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ucontext_t
	{
		public int uc_onstack;

		public uint uc_sigmask;

		public __darwin_sigaltstack uc_stack;

		public unsafe __darwin_ucontext* uc_link;

		public nuint uc_mcsize;

		public unsafe __darwin_mcontext64* uc_mcontext;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct sigval
	{
		[FieldOffset (0)]
		public int sival_int;

		[FieldOffset (0)]
		public unsafe void* sival_ptr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct sigevent
	{
		public int sigev_notify;

		public int sigev_signo;

		public sigval sigev_value;

		public unsafe Action<sigval>* sigev_notify_function;

		public unsafe pthread_attr_t* sigev_notify_attributes;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct siginfo_t
	{
		public int si_signo;

		public int si_errno;

		public int si_code;

		public int si_pid;

		public uint si_uid;

		public int si_status;

		public unsafe void* si_addr;

		public sigval si_value;

		public nint si_band;

		public nuint[] __pad;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct __sigaction_u
	{
		[FieldOffset (0)]
		public unsafe Action<int>* __sa_handler;

		[FieldOffset (0)]
		public unsafe Action<int, __siginfo*, void*>* __sa_sigaction;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __sigaction
	{
		public __sigaction_u __sigaction_u;

		public unsafe Action<void*, int, int, siginfo_t*, void*>* sa_tramp;

		public uint sa_mask;

		public int sa_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct sigaction
	{
		public __sigaction_u __sigaction_u;

		public uint sa_mask;

		public int sa_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct sigvec
	{
		public unsafe Action<int>* sv_handler;

		public int sv_mask;

		public int sv_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct sigstack
	{
		public unsafe sbyte* ss_sp;

		public int ss_onstack;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct __sbuf
	{
		public unsafe byte* _base;

		public int _size;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct FILE
	{
		public unsafe byte* _p;

		public int _r;

		public int _w;

		public short _flags;

		public short _file;

		public __sbuf _bf;

		public int _lbfsize;

		public unsafe void* _cookie;

		public unsafe Func<void*, int>* _close;

		public unsafe Func<void*, sbyte*, int, int>* _read;

		public unsafe Func<void*, long, int, long>* _seek;

		public unsafe Func<void*, sbyte*, int, int>* _write;

		public __sbuf _ub;

		public unsafe __sFILEX* _extra;

		public int _ur;

		public byte[] _ubuf;

		public byte[] _nbuf;

		public __sbuf _lb;

		public int _blksize;

		public long _offset;
	}

	public enum idtype_t : uint
	{
		All,
		Pid,
		Pgid
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct timeval
	{
		public nint tv_sec;

		public int tv_usec;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage
	{
		public timeval ru_utime;

		public timeval ru_stime;

		public nint ru_maxrss;

		public nint ru_ixrss;

		public nint ru_idrss;

		public nint ru_isrss;

		public nint ru_minflt;

		public nint ru_majflt;

		public nint ru_nswap;

		public nint ru_inblock;

		public nint ru_oublock;

		public nint ru_msgsnd;

		public nint ru_msgrcv;

		public nint ru_nsignals;

		public nint ru_nvcsw;

		public nint ru_nivcsw;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_v0
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_v1
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;

		public ulong ri_child_user_time;

		public ulong ri_child_system_time;

		public ulong ri_child_pkg_idle_wkups;

		public ulong ri_child_interrupt_wkups;

		public ulong ri_child_pageins;

		public ulong ri_child_elapsed_abstime;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_v2
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;

		public ulong ri_child_user_time;

		public ulong ri_child_system_time;

		public ulong ri_child_pkg_idle_wkups;

		public ulong ri_child_interrupt_wkups;

		public ulong ri_child_pageins;

		public ulong ri_child_elapsed_abstime;

		public ulong ri_diskio_bytesread;

		public ulong ri_diskio_byteswritten;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_v3
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;

		public ulong ri_child_user_time;

		public ulong ri_child_system_time;

		public ulong ri_child_pkg_idle_wkups;

		public ulong ri_child_interrupt_wkups;

		public ulong ri_child_pageins;

		public ulong ri_child_elapsed_abstime;

		public ulong ri_diskio_bytesread;

		public ulong ri_diskio_byteswritten;

		public ulong ri_cpu_time_qos_default;

		public ulong ri_cpu_time_qos_maintenance;

		public ulong ri_cpu_time_qos_background;

		public ulong ri_cpu_time_qos_utility;

		public ulong ri_cpu_time_qos_legacy;

		public ulong ri_cpu_time_qos_user_initiated;

		public ulong ri_cpu_time_qos_user_interactive;

		public ulong ri_billed_system_time;

		public ulong ri_serviced_system_time;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_v4
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;

		public ulong ri_child_user_time;

		public ulong ri_child_system_time;

		public ulong ri_child_pkg_idle_wkups;

		public ulong ri_child_interrupt_wkups;

		public ulong ri_child_pageins;

		public ulong ri_child_elapsed_abstime;

		public ulong ri_diskio_bytesread;

		public ulong ri_diskio_byteswritten;

		public ulong ri_cpu_time_qos_default;

		public ulong ri_cpu_time_qos_maintenance;

		public ulong ri_cpu_time_qos_background;

		public ulong ri_cpu_time_qos_utility;

		public ulong ri_cpu_time_qos_legacy;

		public ulong ri_cpu_time_qos_user_initiated;

		public ulong ri_cpu_time_qos_user_interactive;

		public ulong ri_billed_system_time;

		public ulong ri_serviced_system_time;

		public ulong ri_logical_writes;

		public ulong ri_lifetime_max_phys_footprint;

		public ulong ri_instructions;

		public ulong ri_cycles;

		public ulong ri_billed_energy;

		public ulong ri_serviced_energy;

		public ulong ri_interval_max_phys_footprint;

		public ulong ri_runnable_time;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_v5
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;

		public ulong ri_child_user_time;

		public ulong ri_child_system_time;

		public ulong ri_child_pkg_idle_wkups;

		public ulong ri_child_interrupt_wkups;

		public ulong ri_child_pageins;

		public ulong ri_child_elapsed_abstime;

		public ulong ri_diskio_bytesread;

		public ulong ri_diskio_byteswritten;

		public ulong ri_cpu_time_qos_default;

		public ulong ri_cpu_time_qos_maintenance;

		public ulong ri_cpu_time_qos_background;

		public ulong ri_cpu_time_qos_utility;

		public ulong ri_cpu_time_qos_legacy;

		public ulong ri_cpu_time_qos_user_initiated;

		public ulong ri_cpu_time_qos_user_interactive;

		public ulong ri_billed_system_time;

		public ulong ri_serviced_system_time;

		public ulong ri_logical_writes;

		public ulong ri_lifetime_max_phys_footprint;

		public ulong ri_instructions;

		public ulong ri_cycles;

		public ulong ri_billed_energy;

		public ulong ri_serviced_energy;

		public ulong ri_interval_max_phys_footprint;

		public ulong ri_runnable_time;

		public ulong ri_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rusage_info_current
	{
		public byte[] ri_uuid;

		public ulong ri_user_time;

		public ulong ri_system_time;

		public ulong ri_pkg_idle_wkups;

		public ulong ri_interrupt_wkups;

		public ulong ri_pageins;

		public ulong ri_wired_size;

		public ulong ri_resident_size;

		public ulong ri_phys_footprint;

		public ulong ri_proc_start_abstime;

		public ulong ri_proc_exit_abstime;

		public ulong ri_child_user_time;

		public ulong ri_child_system_time;

		public ulong ri_child_pkg_idle_wkups;

		public ulong ri_child_interrupt_wkups;

		public ulong ri_child_pageins;

		public ulong ri_child_elapsed_abstime;

		public ulong ri_diskio_bytesread;

		public ulong ri_diskio_byteswritten;

		public ulong ri_cpu_time_qos_default;

		public ulong ri_cpu_time_qos_maintenance;

		public ulong ri_cpu_time_qos_background;

		public ulong ri_cpu_time_qos_utility;

		public ulong ri_cpu_time_qos_legacy;

		public ulong ri_cpu_time_qos_user_initiated;

		public ulong ri_cpu_time_qos_user_interactive;

		public ulong ri_billed_system_time;

		public ulong ri_serviced_system_time;

		public ulong ri_logical_writes;

		public ulong ri_lifetime_max_phys_footprint;

		public ulong ri_instructions;

		public ulong ri_cycles;

		public ulong ri_billed_energy;

		public ulong ri_serviced_energy;

		public ulong ri_interval_max_phys_footprint;

		public ulong ri_runnable_time;

		public ulong ri_flags;

		public ulong ri_user_ptime;

		public ulong ri_system_ptime;

		public ulong ri_pinstructions;

		public ulong ri_pcycles;

		public ulong ri_energy_nj;

		public ulong ri_penergy_nj;

		public ulong[] ri_reserved;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct rlimit
	{
		public ulong rlim_cur;

		public ulong rlim_max;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct proc_rlimit_control_wakeupmon
	{
		public uint wm_flags;

		public int wm_rate;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct wait
	{
		[FieldOffset (0)]
		public int w_status;

		[StructLayout (LayoutKind.Sequential)]
		public struct W_T
		{
			public uint w_Termsig;

			public uint w_Coredump;

			public uint w_Retcode;

			public uint w_Filler;
		}


		[FieldOffset (0)]
		public W_T w_T;

		[StructLayout (LayoutKind.Sequential)]
		public struct W_S
		{
			public uint w_Stopval;

			public uint w_Stopsig;

			public uint w_Filler;
		}


		[FieldOffset (0)]
		public W_S w_S;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct div_t
	{
		public int quot;

		public int rem;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ldiv_t
	{
		public nint quot;

		public nint rem;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct lldiv_t
	{
		public long quot;

		public long rem;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct timespec
	{
		public nint tv_sec;

		public nint tv_nsec;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct tm
	{
		public int tm_sec;

		public int tm_min;

		public int tm_hour;

		public int tm_mday;

		public int tm_mon;

		public int tm_year;

		public int tm_wday;

		public int tm_yday;

		public int tm_isdst;

		public nint tm_gmtoff;

		public unsafe sbyte* tm_zone;
	}

	public enum clockid_t : uint
	{
		Realtime = 0,
		Monotonic = 6,
		MonotonicRaw = 4,
		MonotonicRawApprox = 5,
		UptimeRaw = 8,
		UptimeRawApprox = 9,
		ProcessCputimeId = 12,
		ThreadCputimeId = 16
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct imaxdiv_t
	{
		public nint quot;

		public nint rem;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CompTimeValue
	{
		public uint lo;

		public int hi;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct AbsoluteTime
	{
		public uint lo;

		public uint hi;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct extended80
	{
		public short exp;

		public ushort[] man;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct extended96
	{
		public short[] exp;

		public ushort[] man;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Float32Point
	{
		public float x;

		public float y;
	}

	public enum  : uint
	{
		noErr = 0
	}

	public enum  : uint
	{
		NilOptions = 0
	}

	public enum  : uint
	{
		VariableLengthArray = 1
	}

	public enum  : uint
	{
		UnknownType = 1061109567
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ProcessSerialNumber
	{
		public uint highLongOfPSN;

		public uint lowLongOfPSN;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Point
	{
		public short v;

		public short h;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct Rect
	{
		public short top;

		public short left;

		public short bottom;

		public short right;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct FixedPoint
	{
		public int x;

		public int y;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct FixedRect
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public enum  : uint
	{
		normal = 0,
		bold = 1,
		italic = 2,
		underline = 4,
		outline = 8,
		shadow = 16,
		condense = 32,
		extend = 64
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct TimeRecord
	{
		public CompTimeValue value;

		public int scale;

		public unsafe TimeBase* @base;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NumVersion
	{
		public byte nonRelRev;

		public byte stage;

		public byte minorAndBugRev;

		public byte majorRev;
	}

	public enum  : uint
	{
		developStage = 32,
		alphaStage = 64,
		betaStage = 96,
		finalStage = 128
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct NumVersionVariant
	{
		[FieldOffset (0)]
		public NumVersion parts;

		[FieldOffset (0)]
		public uint whole;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct VersRec
	{
		public NumVersion numericVersion;

		public short countryCode;

		public byte[] shortVersion;

		public byte[] reserved;
	}

	[Native]
	public enum CFComparisonResult : long
	{
		LessThan = -1,
		EqualTo = 0,
		GreaterThan = 1
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFRange
	{
		public nint location;

		public nint length;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFAllocatorContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe CFAllocatorRetainCallBack* retain;

		public unsafe CFAllocatorReleaseCallBack* release;

		public unsafe CFAllocatorCopyDescriptionCallBack* copyDescription;

		public unsafe CFAllocatorAllocateCallBack* allocate;

		public unsafe CFAllocatorReallocateCallBack* reallocate;

		public unsafe CFAllocatorDeallocateCallBack* deallocate;

		public unsafe CFAllocatorPreferredSizeCallBack* preferredSize;
	}

	public enum ptrauth_key : uint
	{
		asia = 0,
		asib = 1,
		asda = 2,
		asdb = 3,
		process_independent_code = asia,
		process_dependent_code = asib,
		process_independent_data = asda,
		process_dependent_data = asdb,
		function_pointer = process_independent_code,
		return_address = process_dependent_code,
		frame_pointer = process_dependent_data,
		block_function = asia,
		cxx_vtable_pointer = asda
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFArrayCallBacks
	{
		public nint version;

		public unsafe CFArrayRetainCallBack* retain;

		public unsafe CFArrayReleaseCallBack* release;

		public unsafe CFArrayCopyDescriptionCallBack* copyDescription;

		public unsafe CFArrayEqualCallBack* equal;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFBagCallBacks
	{
		public nint version;

		public unsafe CFBagRetainCallBack* retain;

		public unsafe CFBagReleaseCallBack* release;

		public unsafe CFBagCopyDescriptionCallBack* copyDescription;

		public unsafe CFBagEqualCallBack* equal;

		public unsafe CFBagHashCallBack* hash;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFBinaryHeapCompareContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFBinaryHeapCallBacks
	{
		public nint version;

		public unsafe Func<CoreFoundation.CFAllocatorRef*, void*, void*>* retain;

		public unsafe Action<CoreFoundation.CFAllocatorRef*, void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;

		public unsafe Func<void*, void*, void*, CFComparisonResult>* compare;
	}

	public enum Os : uint
	{
		UnknownByteOrder,
		LittleEndian,
		BigEndian
	}

	public enum __CFByteOrder : uint
	{
		Unknown,
		LittleEndian,
		BigEndian
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFSwappedFloat32
	{
		public uint v;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFSwappedFloat64
	{
		public ulong v;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public float v;

		[FieldOffset (0)]
		public CFSwappedFloat32 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public float v;

		[FieldOffset (0)]
		public CFSwappedFloat32 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public double v;

		[FieldOffset (0)]
		public CFSwappedFloat64 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public double v;

		[FieldOffset (0)]
		public CFSwappedFloat64 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public float v;

		[FieldOffset (0)]
		public CFSwappedFloat32 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public float v;

		[FieldOffset (0)]
		public CFSwappedFloat32 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public double v;

		[FieldOffset (0)]
		public CFSwappedFloat64 sv;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct CFSwap
	{
		[FieldOffset (0)]
		public double v;

		[FieldOffset (0)]
		public CFSwappedFloat64 sv;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFDictionaryKeyCallBacks
	{
		public nint version;

		public unsafe CFDictionaryRetainCallBack* retain;

		public unsafe CFDictionaryReleaseCallBack* release;

		public unsafe CFDictionaryCopyDescriptionCallBack* copyDescription;

		public unsafe CFDictionaryEqualCallBack* equal;

		public unsafe CFDictionaryHashCallBack* hash;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFDictionaryValueCallBacks
	{
		public nint version;

		public unsafe CFDictionaryRetainCallBack* retain;

		public unsafe CFDictionaryReleaseCallBack* release;

		public unsafe CFDictionaryCopyDescriptionCallBack* copyDescription;

		public unsafe CFDictionaryEqualCallBack* equal;
	}

	[Native]
	public enum CFNotificationSuspensionBehavior : long
	{
		Drop = 1,
		Coalesce = 2,
		Hold = 3,
		DeliverImmediately = 4
	}

	[Native]
	public enum kCFNotification : ulong
	{
		DeliverImmediately = (1uL << 0),
		PostToAllSessions = (1uL << 1)
	}

	[Native]
	public enum CFLocaleLanguageDirection : long
	{
		Unknown = 0,
		LeftToRight = 1,
		RightToLeft = 2,
		TopToBottom = 3,
		BottomToTop = 4
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFGregorianDate
	{
		public int year;

		public sbyte month;

		public sbyte day;

		public sbyte hour;

		public sbyte minute;

		public double second;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFGregorianUnits
	{
		public int years;

		public int months;

		public int days;

		public int hours;

		public int minutes;

		public double seconds;
	}

	[Flags]
	[Native]
	public enum CFGregorianUnitFlags : ulong
	{
		UnitsYears = (1uL << 0),
		UnitsMonths = (1uL << 1),
		UnitsDays = (1uL << 2),
		UnitsHours = (1uL << 3),
		UnitsMinutes = (1uL << 4),
		UnitsSeconds = (1uL << 5),
		AllUnits = 0xffffff
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum CFDataSearchFlags : ulong
	{
		Backwards = 1uL << 0,
		Anchored = 1uL << 1
	}

	[Native]
	public enum CFCharacterSetPredefinedSet : long
	{
		Control = 1,
		Whitespace,
		WhitespaceAndNewline,
		DecimalDigit,
		Letter,
		LowercaseLetter,
		UppercaseLetter,
		NonBase,
		Decomposable,
		AlphaNumeric,
		Punctuation,
		CapitalizedLetter = 13,
		Symbol = 14,
		Newline = 15,
		Illegal = 12
	}

	public enum CFStringBuiltInEncodings : uint
	{
		MacRoman = 0,
		WindowsLatin1 = 1280,
		ISOLatin1 = 513,
		NextStepLatin = 2817,
		Ascii = 1536,
		Unicode = 256,
		Utf8 = 134217984,
		NonLossyASCII = 3071,
		Utf16 = 256,
		Utf16be = 268435712,
		Utf16le = 335544576,
		Utf32 = 201326848,
		Utf32be = 402653440,
		Utf32le = 469762304
	}

	[Flags]
	[Native]
	public enum CFStringCompareFlags : ulong
	{
		CaseInsensitive = 0x1,
		Backwards = 0x4,
		Anchored = 0x8,
		Nonliteral = 0x10,
		Localized = 0x20,
		Numerically = 0x40,
		DiacriticInsensitive = 0x80,
		WidthInsensitive = 0x100,
		ForcedOrdering = 0x200
	}

	[Native]
	public enum CFStringNormalizationForm : long
	{
		D = 0,
		Kd,
		C,
		Kc
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFStringInlineBuffer
	{
		public ushort[] buffer;

		public unsafe CFStringRef* theString;

		public unsafe ushort* directUniCharBuffer;

		public unsafe sbyte* directCStringBuffer;

		public CFRange rangeToBuffer;

		public nint bufferedRangeStart;

		public nint bufferedRangeEnd;
	}

	[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
	[Native]
	public enum CFTimeZoneNameStyle : long
	{
		Standard,
		ShortStandard,
		DaylightSaving,
		ShortDaylightSaving,
		Generic,
		ShortGeneric
	}

	[Flags]
	[Native]
	public enum CFCalendarUnit : ulong
	{
		Era = (1uL << 1),
		Year = (1uL << 2),
		Month = (1uL << 3),
		Day = (1uL << 4),
		Hour = (1uL << 5),
		Minute = (1uL << 6),
		Second = (1uL << 7),
		Week = (1uL << 8),
		Weekday = (1uL << 9),
		WeekdayOrdinal = (1uL << 10),
		Quarter = (1uL << 11),
		WeekOfMonth = (1uL << 12),
		WeekOfYear = (1uL << 13),
		YearForWeekOfYear = (1uL << 14)
	}

	[Native]
	public enum  : ulong
	{
		CFCalendarComponentsWrap = (1uL << 0)
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CGPoint
	{
		public nfloat x;

		public nfloat y;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CGSize
	{
		public nfloat width;

		public nfloat height;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CGVector
	{
		public nfloat dx;

		public nfloat dy;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CGRect
	{
		public CGPoint origin;

		public CGSize size;
	}

	public enum CGRectEdge : uint
	{
		inXEdge,
		inYEdge,
		axXEdge,
		axYEdge
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CGAffineTransform
	{
		public nfloat a;

		public nfloat b;

		public nfloat c;

		public nfloat d;

		public nfloat tx;

		public nfloat ty;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CGAffineTransformComponents
	{
		public CGSize scale;

		public nfloat horizontalShear;

		public nfloat rotation;

		public CGVector translation;
	}

	[Native]
	public enum CFDateFormatterStyle : long
	{
		NoStyle = 0,
		ShortStyle = 1,
		MediumStyle = 2,
		LongStyle = 3,
		FullStyle = 4
	}

	[Flags]
	[Native]
	public enum CFISO8601DateFormatOptions : ulong
	{
		Year = (1uL << 0),
		Month = (1uL << 1),
		WeekOfYear = (1uL << 2),
		Day = (1uL << 4),
		Time = (1uL << 5),
		TimeZone = (1uL << 6),
		SpaceBetweenDateAndTime = (1uL << 7),
		DashSeparatorInDate = (1uL << 8),
		ColonSeparatorInTime = (1uL << 9),
		ColonSeparatorInTimeZone = (1uL << 10),
		FractionalSeconds = (1uL << 11),
		FullDate = Year | Month | Day | DashSeparatorInDate,
		FullTime = Time | ColonSeparatorInTime | TimeZone | ColonSeparatorInTimeZone,
		InternetDateTime = FullDate | FullTime
	}

	[Native]
	public enum CFNumberType : long
	{
		SInt8Type = 1,
		SInt16Type = 2,
		SInt32Type = 3,
		SInt64Type = 4,
		Float32Type = 5,
		Float64Type = 6,
		CharType = 7,
		ShortType = 8,
		IntType = 9,
		LongType = 10,
		LongLongType = 11,
		FloatType = 12,
		DoubleType = 13,
		CFIndexType = 14,
		NSIntegerType = 15,
		CGFloatType = 16,
		MaxType = 16
	}

	[Native]
	public enum CFNumberFormatterStyle : long
	{
		NoStyle = 0,
		DecimalStyle = 1,
		CurrencyStyle = 2,
		PercentStyle = 3,
		ScientificStyle = 4,
		SpellOutStyle = 5,
		OrdinalStyle = 6,
		CurrencyISOCodeStyle = 8,
		CurrencyPluralStyle = 9,
		CurrencyAccountingStyle = 10
	}

	[Flags]
	[Native]
	public enum CFNumberFormatterOptionFlags : ulong
	{
		CFNumberFormatterParseIntegersOnly = 0x1
	}

	[Native]
	public enum CFNumberFormatterRoundingMode : long
	{
		Ceiling = 0,
		Floor = 1,
		Down = 2,
		Up = 3,
		HalfEven = 4,
		HalfDown = 5,
		HalfUp = 6
	}

	[Native]
	public enum CFNumberFormatterPadPosition : long
	{
		BeforePrefix = 0,
		AfterPrefix = 1,
		BeforeSuffix = 2,
		AfterSuffix = 3
	}

	[Native]
	public enum CFURLPathStyle : long
	{
		POSIXPathStyle = 0,
		HFSPathStyle,
		WindowsPathStyle
	}

	[Native]
	public enum CFURLComponentType : long
	{
		Scheme = 1,
		NetLocation = 2,
		Path = 3,
		ResourceSpecifier = 4,
		User = 5,
		Password = 6,
		UserInfo = 7,
		Host = 8,
		Port = 9,
		ParameterString = 10,
		Query = 11,
		Fragment = 12
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum CFURLBookmarkCreationOptions : ulong
	{
		MinimalBookmarkMask = (1uL << 9),
		SuitableForBookmarkFile = (1uL << 10),
		WithSecurityScope = (1uL << 11),
		SecurityScopeAllowOnlyReadAccess = (1uL << 12),
		WithoutImplicitSecurityScope = (1uL << 29),
		PreferFileIDResolutionMask = (1uL << 8)
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum CFURLBookmarkResolutionOptions : ulong
	{
		URLBookmarkResolutionWithoutUIMask = (1uL << 8),
		URLBookmarkResolutionWithoutMountingMask = (1uL << 9),
		URLBookmarkResolutionWithSecurityScope = (1uL << 10),
		URLBookmarkResolutionWithoutImplicitStartAccessing = (1uL << 15),
		BookmarkResolutionWithoutUIMask = URLBookmarkResolutionWithoutUIMask,
		BookmarkResolutionWithoutMountingMask = URLBookmarkResolutionWithoutMountingMask
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_port_status_t
	{
		public uint mps_pset;

		public uint mps_seqno;

		public uint mps_mscount;

		public uint mps_qlimit;

		public uint mps_msgcount;

		public uint mps_sorights;

		public int mps_srights;

		public int mps_pdrequest;

		public int mps_nsrequest;

		public uint mps_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_port_limits_t
	{
		public uint mpl_qlimit;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_port_info_ext_t
	{
		public mach_port_status_t mpie_status;

		public uint mpie_boost_cnt;

		public uint[] reserved;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_port_guard_info_t
	{
		public ulong mpgi_guard;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_port_qos_t
	{
		public uint name;

		public uint prealloc;

		public int pad1;

		public uint len;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_service_port_info_data_t
	{
		public sbyte[] mspi_string_name;

		public byte mspi_domain_type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_port_options_t
	{
		public uint flags;

		public mach_port_limits_t mpl;

		[StructLayout (LayoutKind.Explicit)]
		public struct _
		{
			[FieldOffset (0)]
			public ulong[] reserved;

			[FieldOffset (0)]
			public uint work_interval_port;

			[FieldOffset (0)]
			public unsafe mach_service_port_info_t* service_port_info;

			[FieldOffset (0)]
			public uint service_port_name;
		}


		public _ ;
	}

	public enum mach_port_guard_exception_codes : uint
	{
		Destroy = 1,
		ModRefs = 2,
		InvalidOptions = 3,
		SetContext = 4,
		ThreadSetState = 5,
		Unguarded = 1 << 3,
		IncorrectGuard = 1 << 4,
		Immovable = 1 << 5,
		StrictReply = 1 << 6,
		MsgFiltered = 1 << 7,
		InvalidRight = 1 << 8,
		InvalidName = 1 << 9,
		InvalidValue = 1 << 10,
		InvalidArgument = 1 << 11,
		RightExists = 1 << 12,
		KernNoSpace = 1 << 13,
		KernFailure = 1 << 14,
		KernResource = 1 << 15,
		SendInvalidReply = 1 << 16,
		SendInvalidVoucher = 1 << 17,
		SendInvalidRight = 1 << 18,
		RcvInvalidName = 1 << 19,
		RcvGuardedDesc = 1 << 20,
		ModRefsNonFatal = 1 << 21,
		ImmovableNonFatal = 1 << 22,
		RequireReplyPortSemantics = 1 << 23
	}

	public enum CFRunLoopRunResult
	{
		Finished = 1,
		Stopped = 2,
		TimedOut = 3,
		HandledSource = 4
	}

	[Flags]
	[Native]
	public enum CFRunLoopActivity : ulong
	{
		Entry = (1uL << 0),
		BeforeTimers = (1uL << 1),
		BeforeSources = (1uL << 2),
		BeforeWaiting = (1uL << 5),
		AfterWaiting = (1uL << 6),
		Exit = (1uL << 7),
		AllActivities = 0xfffffff
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFRunLoopSourceContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;

		public unsafe Func<void*, void*, byte>* equal;

		public unsafe Func<void*, nuint>* hash;

		public unsafe Action<void*, CFRunLoop, CoreFoundation.CFRunLoopMode*>* schedule;

		public unsafe Action<void*, CFRunLoop, CoreFoundation.CFRunLoopMode*>* cancel;

		public unsafe Action<void*>* perform;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFRunLoopSourceContext1
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;

		public unsafe Func<void*, void*, byte>* equal;

		public unsafe Func<void*, nuint>* hash;

		public unsafe Func<void*, uint>* getPort;

		public unsafe Func<void*, nint, CoreFoundation.CFAllocatorRef*, void*, void*>* perform;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFRunLoopObserverContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFRunLoopTimerContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[Native]
	public enum CFSocketError : long
	{
		Success = 0,
		Error = -1,
		Timeout = -2
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFSocketSignature
	{
		public int protocolFamily;

		public int socketType;

		public int protocol;

		public unsafe CFDataRef* address;
	}

	[Flags]
	[Native]
	public enum CFSocketCallBackType : ulong
	{
		NoCallBack = 0x0,
		ReadCallBack = 0x1,
		AcceptCallBack = 0x2,
		DataCallBack = 0x3,
		ConnectCallBack = 0x4,
		WriteCallBack = 0x8
	}

	[Native]
	public enum kCFSocket : ulong
	{
		AutomaticallyReenableReadCallBack = 1,
		AutomaticallyReenableAcceptCallBack = 2,
		AutomaticallyReenableDataCallBack = 3,
		AutomaticallyReenableWriteCallBack = 8,
		LeaveErrors = 64,
		CloseOnInvalidate = 128
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFSocketContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct accessx_descriptor
	{
		public uint ad_name_offset;

		public int ad_flags;

		public int[] ad_pad;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct flock
	{
		public long l_start;

		public long l_len;

		public int l_pid;

		public short l_type;

		public short l_whence;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct flocktimeout
	{
		public flock fl;

		public timespec timeout;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct radvisory
	{
		public long ra_offset;

		public int ra_count;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fsignatures_t
	{
		public long fs_file_start;

		public unsafe void* fs_blob_start;

		public nuint fs_blob_size;

		public nuint fs_fsignatures_size;

		public sbyte[] fs_cdhash;

		public int fs_hash_type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fsupplement_t
	{
		public long fs_file_start;

		public long fs_blob_start;

		public nuint fs_blob_size;

		public int fs_orig_fd;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fchecklv_t
	{
		public long lv_file_start;

		public nuint lv_error_message_size;

		public unsafe void* lv_error_message;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fgetsigsinfo_t
	{
		public long fg_file_start;

		public int fg_info_request;

		public int fg_sig_is_platform;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fstore_t
	{
		public uint fst_flags;

		public int fst_posmode;

		public long fst_offset;

		public long fst_length;

		public long fst_bytesalloc;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fpunchhole_t
	{
		public uint fp_flags;

		public uint reserved;

		public long fp_offset;

		public long fp_length;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ftrimactivefile_t
	{
		public long fta_offset;

		public long fta_length;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct fspecread_t
	{
		public uint fsr_flags;

		public uint reserved;

		public long fsr_offset;

		public long fsr_length;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct log2phys
	{
		public uint l2p_flags;

		public long l2p_contigbytes;

		public long l2p_devoffset;
	}

	public enum filesec_property_t : uint
	{
		Owner = 1,
		Group = 2,
		Uuid = 3,
		Mode = 4,
		Acl = 5,
		Grpuuid = 6,
		AclRaw = 100,
		AclAllocsize = 101
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct objc_object
	{
		public Class isa;
	}

	public enum os_clockid_t : uint
	{
		OsClockMachAbsoluteTime = 32
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct os_workgroup_attr_s
	{
		public uint sig;

		public sbyte[] opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct os_workgroup_interval_data_s
	{
		public uint sig;

		public sbyte[] opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct os_workgroup_join_token_s
	{
		public uint sig;

		public sbyte[] opaque;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct time_value_t
	{
		public int seconds;

		public int microseconds;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_timespec_t
	{
		public uint tv_sec;

		public int tv_nsec;
	}

	[Native]
	public enum  : ulong
	{
		DispatchWalltimeNow = ~1
	}

	public enum dispatch_qos_class_t : uint
	{
		UserInteractive = 33,
		UserInitiated = 25,
		Default = 21,
		Utility = 17,
		Background = 9,
		Unspecified = 0
	}

	[Native]
	public enum dispatch_autorelease_frequency_t : ulong
	{
		Inherit = 0,
		WorkItem = 1,
		Never = 2
	}

	[Flags]
	[Native]
	public enum dispatch_block_flags_t : ulong
	{
		Barrier = 0x1,
		Detached = 0x2,
		AssignCurrent = 0x4,
		NoQosClass = 0x8,
		InheritQosClass = 0x10,
		EnforceQosClass = 0x20
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_type_descriptor_t
	{
		public uint pad1;

		public uint pad2;

		public uint pad3;

		public uint type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_port_descriptor_t
	{
		public uint name;

		public uint pad1;

		public uint pad2;

		public uint disposition;

		public uint type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_ool_descriptor32_t
	{
		public uint address;

		public uint size;

		public int deallocate;

		public uint copy;

		public uint pad1;

		public uint type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_ool_descriptor64_t
	{
		public ulong address;

		public int deallocate;

		public uint copy;

		public uint pad1;

		public uint type;

		public uint size;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_ool_descriptor_t
	{
		public unsafe void* address;

		public int deallocate;

		public uint copy;

		public uint pad1;

		public uint type;

		public uint size;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_ool_ports_descriptor32_t
	{
		public uint address;

		public uint count;

		public int deallocate;

		public uint copy;

		public uint disposition;

		public uint type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_ool_ports_descriptor64_t
	{
		public ulong address;

		public int deallocate;

		public uint copy;

		public uint disposition;

		public uint type;

		public uint count;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_ool_ports_descriptor_t
	{
		public unsafe void* address;

		public int deallocate;

		public uint copy;

		public uint disposition;

		public uint type;

		public uint count;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_guarded_port_descriptor32_t
	{
		public uint context;

		public uint name;

		public uint flags;

		public uint disposition;

		public uint type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_guarded_port_descriptor64_t
	{
		public ulong context;

		public uint flags;

		public uint disposition;

		public uint type;

		public uint name;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_guarded_port_descriptor_t
	{
		public UIntPtr context;

		public uint flags;

		public uint disposition;

		public uint type;

		public uint name;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct mach_msg_descriptor_t
	{
		[FieldOffset (0)]
		public mach_msg_port_descriptor_t port;

		[FieldOffset (0)]
		public mach_msg_ool_descriptor_t out_of_line;

		[FieldOffset (0)]
		public mach_msg_ool_ports_descriptor_t ool_ports;

		[FieldOffset (0)]
		public mach_msg_type_descriptor_t type;

		[FieldOffset (0)]
		public mach_msg_guarded_port_descriptor_t guarded_port;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_body_t
	{
		public uint msgh_descriptor_count;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_header_t
	{
		public uint msgh_bits;

		public uint msgh_size;

		public uint msgh_remote_port;

		public uint msgh_local_port;

		public uint msgh_voucher_port;

		public int msgh_id;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_base_t
	{
		public mach_msg_header_t header;

		public mach_msg_body_t body;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_trailer_t
	{
		public uint msgh_trailer_type;

		public uint msgh_trailer_size;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_seqno_trailer_t
	{
		public uint msgh_trailer_type;

		public uint msgh_trailer_size;

		public uint msgh_seqno;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct security_token_t
	{
		public uint[] val;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_format_0_trailer_t
	{
		public uint msgh_trailer_type;

		public uint msgh_trailer_size;

		public uint msgh_seqno;

		public security_token_t msgh_sender;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct audit_token_t
	{
		public uint[] val;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_audit_trailer_t
	{
		public uint msgh_trailer_type;

		public uint msgh_trailer_size;

		public uint msgh_seqno;

		public security_token_t msgh_sender;

		public audit_token_t msgh_audit;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_context_trailer_t
	{
		public uint msgh_trailer_type;

		public uint msgh_trailer_size;

		public uint msgh_seqno;

		public security_token_t msgh_sender;

		public audit_token_t msgh_audit;

		public UIntPtr msgh_context;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct msg_labels_t
	{
		public uint sender;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_max_trailer_t
	{
		public uint msgh_trailer_type;

		public uint msgh_trailer_size;

		public uint msgh_seqno;

		public security_token_t msgh_sender;

		public audit_token_t msgh_audit;

		public UIntPtr msgh_context;

		public int msgh_ad;

		public msg_labels_t msgh_labels;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_empty_send_t
	{
		public mach_msg_header_t header;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct mach_msg_empty_rcv_t
	{
		public mach_msg_header_t header;

		public mach_msg_trailer_t trailer;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct mach_msg_empty_t
	{
		[FieldOffset (0)]
		public mach_msg_empty_send_t send;

		[FieldOffset (0)]
		public mach_msg_empty_rcv_t rcv;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFStreamError
	{
		public nint domain;

		public int error;
	}

	[Native]
	public enum CFStreamStatus : long
	{
		NotOpen = 0,
		Opening,
		Open,
		Reading,
		Writing,
		AtEnd,
		Closed,
		Error
	}

	[Flags]
	[Native]
	public enum CFStreamEventType : ulong
	{
		None = 0x0,
		OpenCompleted = 0x1,
		HasBytesAvailable = 0x2,
		CanAcceptBytes = 0x4,
		ErrorOccurred = 0x8,
		EndEncountered = 0x10
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFStreamClientContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[Native]
	public enum CFStreamErrorDomain : long
	{
		Custom = -1,
		Posix = 1,
		MacOSStatus
	}

	[Flags]
	[Native]
	public enum CFPropertyListMutabilityOptions : ulong
	{
		Immutable = 0x0,
		MutableContainers = 1uL << 0,
		MutableContainersAndLeaves = 1uL << 1
	}

	[Native]
	public enum CFPropertyListFormat : long
	{
		OpenStepFormat = 1,
		XMLFormat_v1_0 = 100,
		BinaryFormat_v1_0 = 200
	}

	[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
	[Native]
	public enum kCFPropertyList : long
	{
		ReadCorruptError = 3840,
		ReadUnknownVersionError = 3841,
		ReadStreamError = 3842,
		WriteStreamError = 3851
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFSetCallBacks
	{
		public nint version;

		public unsafe CFSetRetainCallBack* retain;

		public unsafe CFSetReleaseCallBack* release;

		public unsafe CFSetCopyDescriptionCallBack* copyDescription;

		public unsafe CFSetEqualCallBack* equal;

		public unsafe CFSetHashCallBack* hash;
	}

	[Native]
	public enum CFStringEncodings : long
	{
		MacJapanese = 1,
		MacChineseTrad = 2,
		MacKorean = 3,
		MacArabic = 4,
		MacHebrew = 5,
		MacGreek = 6,
		MacCyrillic = 7,
		MacDevanagari = 9,
		MacGurmukhi = 10,
		MacGujarati = 11,
		MacOriya = 12,
		MacBengali = 13,
		MacTamil = 14,
		MacTelugu = 15,
		MacKannada = 16,
		MacMalayalam = 17,
		MacSinhalese = 18,
		MacBurmese = 19,
		MacKhmer = 20,
		MacThai = 21,
		MacLaotian = 22,
		MacGeorgian = 23,
		MacArmenian = 24,
		MacChineseSimp = 25,
		MacTibetan = 26,
		MacMongolian = 27,
		MacEthiopic = 28,
		MacCentralEurRoman = 29,
		MacVietnamese = 30,
		MacExtArabic = 31,
		MacSymbol = 33,
		MacDingbats = 34,
		MacTurkish = 35,
		MacCroatian = 36,
		MacIcelandic = 37,
		MacRomanian = 38,
		MacCeltic = 39,
		MacGaelic = 40,
		MacFarsi = 140,
		MacUkrainian = 152,
		MacInuit = 236,
		MacVT100 = 252,
		MacHFS = 255,
		ISOLatin2 = 514,
		ISOLatin3 = 515,
		ISOLatin4 = 516,
		ISOLatinCyrillic = 517,
		ISOLatinArabic = 518,
		ISOLatinGreek = 519,
		ISOLatinHebrew = 520,
		ISOLatin5 = 521,
		ISOLatin6 = 522,
		ISOLatinThai = 523,
		ISOLatin7 = 525,
		ISOLatin8 = 526,
		ISOLatin9 = 527,
		ISOLatin10 = 528,
		DOSLatinUS = 1024,
		DOSGreek = 1029,
		DOSBalticRim = 1030,
		DOSLatin1 = 1040,
		DOSGreek1 = 1041,
		DOSLatin2 = 1042,
		DOSCyrillic = 1043,
		DOSTurkish = 1044,
		DOSPortuguese = 1045,
		DOSIcelandic = 1046,
		DOSHebrew = 1047,
		DOSCanadianFrench = 1048,
		DOSArabic = 1049,
		DOSNordic = 1050,
		DOSRussian = 1051,
		DOSGreek2 = 1052,
		DOSThai = 1053,
		DOSJapanese = 1056,
		DOSChineseSimplif = 1057,
		DOSKorean = 1058,
		DOSChineseTrad = 1059,
		WindowsLatin2 = 1281,
		WindowsCyrillic = 1282,
		WindowsGreek = 1283,
		WindowsLatin5 = 1284,
		WindowsHebrew = 1285,
		WindowsArabic = 1286,
		WindowsBalticRim = 1287,
		WindowsVietnamese = 1288,
		WindowsKoreanJohab = 1296,
		Ansel = 1537,
		JisX020176 = 1568,
		JisX020883 = 1569,
		JisX020890 = 1570,
		JisX021290 = 1571,
		JisC622678 = 1572,
		ShiftJIS_X0213 = 1576,
		ShiftJIS_X0213_MenKuTen = 1577,
		Gb231280 = 1584,
		Gbk95 = 1585,
		Gb180302000 = 1586,
		Ksc560187 = 1600,
		KSC_5601_92_Johab = 1601,
		Cns1164392P1 = 1617,
		Cns1164392P2 = 1618,
		Cns1164392P3 = 1619,
		Iso2022Jp = 2080,
		Iso2022Jp2 = 2081,
		Iso2022Jp1 = 2082,
		Iso2022Jp3 = 2083,
		Iso2022Cn = 2096,
		Iso2022CnExt = 2097,
		Iso2022Kr = 2112,
		EucJp = 2336,
		EucCn = 2352,
		EucTw = 2353,
		EucKr = 2368,
		ShiftJIS = 2561,
		Koi8R = 2562,
		Big5 = 2563,
		MacRomanLatin1 = 2564,
		HzGb2312 = 2565,
		Big5_HKSCS_1999 = 2566,
		Viscii = 2567,
		Koi8U = 2568,
		Big5_E = 2569,
		NextStepJapanese = 2818,
		EbcdicUs = 3073,
		EbcdicCp037 = 3074,
		Utf7 = 67109120,
		Utf7Imap = 2576,
		ShiftJIS_X0213_00 = 1576
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFTreeContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe CFTreeRetainCallBack* retain;

		public unsafe CFTreeReleaseCallBack* release;

		public unsafe CFTreeCopyDescriptionCallBack* copyDescription;
	}

	[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFError codes instead")]
	[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFError codes instead")]
	[Introduced (PlatformName.iOS, 2, 0, message: "Use CFError codes instead")]
	[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFError codes instead")]
	[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFError codes instead")]
	[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFError codes instead")]
	[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFError codes instead")]
	[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFError codes instead")]
	[Native]
	public enum CFURLError : long
	{
		UnknownError = -10,
		UnknownSchemeError = -11,
		ResourceNotFoundError = -12,
		ResourceAccessViolationError = -13,
		RemoteHostUnavailableError = -14,
		ImproperArgumentsError = -15,
		UnknownPropertyKeyError = -16,
		PropertyKeyUnavailableError = -17,
		TimeoutError = -18
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFUUIDBytes
	{
		public byte byte0;

		public byte byte1;

		public byte byte2;

		public byte byte3;

		public byte byte4;

		public byte byte5;

		public byte byte6;

		public byte byte7;

		public byte byte8;

		public byte byte9;

		public byte byte10;

		public byte byte11;

		public byte byte12;

		public byte byte13;

		public byte byte14;

		public byte byte15;
	}

	[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
	public enum kCFBundleExecutableArchitecture : uint
	{
		I386 = 7,
		Ppc = 18,
		X8664 = 16777223,
		Ppc64 = 16777234,
		Arm64 = 16777228
	}

	public enum kCFMessagePort
	{
		Success = 0,
		SendTimeout = -1,
		ReceiveTimeout = -2,
		IsInvalid = -3,
		TransportError = -4,
		BecameInvalidError = -5
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFMessagePortContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFMachPortContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[Flags]
	[Native]
	public enum CFURLEnumeratorOptions : ulong
	{
		DefaultBehavior = 0x0,
		DescendRecursively = 1uL << 0,
		SkipInvisibles = 1uL << 1,
		GenerateFileReferenceURLs = 1uL << 2,
		SkipPackageContents = 1uL << 3,
		IncludeDirectoriesPreOrder = 1uL << 4,
		IncludeDirectoriesPostOrder = 1uL << 5,
		GenerateRelativePathURLs = 1uL << 6
	}

	[Native]
	public enum CFURLEnumeratorResult : long
	{
		Success = 1,
		End = 2,
		Error = 3,
		DirectoryPostOrderSuccess = 4
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct guid_t
	{
		[FieldOffset (0)]
		public byte[] g_guid;

		[FieldOffset (0)]
		public uint[] g_guid_asint;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct ntsid_t
	{
		public byte sid_kind;

		public byte sid_authcount;

		public byte[] sid_authority;

		public uint[] sid_authorities;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct kauth_identity_extlookup
	{
		public uint el_seqno;

		public uint el_result;

		public uint el_flags;

		public int el_info_pid;

		public ulong el_extend;

		public uint el_info_reserved_1;

		public uint el_uid;

		public guid_t el_uguid;

		public uint el_uguid_valid;

		public ntsid_t el_usid;

		public uint el_usid_valid;

		public uint el_gid;

		public guid_t el_gguid;

		public uint el_gguid_valid;

		public ntsid_t el_gsid;

		public uint el_gsid_valid;

		public uint el_member_valid;

		public uint el_sup_grp_cnt;

		public uint[] el_sup_groups;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct kauth_cache_sizes
	{
		public uint kcs_group_size;

		public uint kcs_id_size;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct kauth_ace
	{
		public guid_t ace_applicable;

		public uint ace_flags;

		public uint ace_rights;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct kauth_acl
	{
		public uint acl_entrycount;

		public uint acl_flags;

		public kauth_ace[] acl_ace;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct kauth_filesec
	{
		public uint fsec_magic;

		public guid_t fsec_owner;

		public guid_t fsec_group;

		public kauth_acl fsec_acl;
	}

	public enum acl_perm_t : uint
	{
		ReadData = (1 << 1),
		ListDirectory = (1 << 1),
		WriteData = (1 << 2),
		AddFile = (1 << 2),
		Execute = (1 << 3),
		Search = (1 << 3),
		Delete = (1 << 4),
		AppendData = (1 << 5),
		AddSubdirectory = (1 << 5),
		DeleteChild = (1 << 6),
		ReadAttributes = (1 << 7),
		WriteAttributes = (1 << 8),
		ReadExtattributes = (1 << 9),
		WriteExtattributes = (1 << 10),
		ReadSecurity = (1 << 11),
		WriteSecurity = (1 << 12),
		ChangeOwner = (1 << 13),
		Synchronize = (1 << 20)
	}

	public enum acl_tag_t : uint
	{
		UndefinedTag = 0,
		ExtendedAllow = 1,
		ExtendedDeny = 2
	}

	public enum acl_type_t : uint
	{
		Extended = 256,
		Access = 0,
		Default = 1,
		Afs = 2,
		Coda = 3,
		Ntfs = 4,
		Nwfs = 5
	}

	public enum acl_entry_id_t
	{
		FirstEntry = 0,
		NextEntry = -1,
		LastEntry = -2
	}

	public enum acl_flag_t : uint
	{
		FlagDeferInherit = (1 << 0),
		FlagNoInherit = (1 << 17),
		EntryInherited = (1 << 4),
		EntryFileInherit = (1 << 5),
		EntryDirectoryInherit = (1 << 6),
		EntryLimitInherit = (1 << 7),
		EntryOnlyInherit = (1 << 8)
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x8), iOS (0x6,0x0)]
	[Native]
	public enum CFFileSecurityClearOptions : ulong
	{
		Owner = 1uL << 0,
		Group = 1uL << 1,
		Mode = 1uL << 2,
		OwnerUUID = 1uL << 3,
		GroupUUID = 1uL << 4,
		AccessControlList = 1uL << 5
	}

	[Native]
	public enum kCFStringTokenizer : ulong
	{
		UnitWord = 0,
		UnitSentence = 1,
		UnitParagraph = 2,
		UnitLineBreak = 3,
		UnitWordBoundary = 4,
		AttributeLatinTranscription = 1uL << 16,
		AttributeLanguage = 1uL << 17
	}

	[Flags]
	[Native]
	public enum CFStringTokenizerTokenType : ulong
	{
		None = 0x0,
		Normal = 1uL << 0,
		HasSubTokensMask = 1uL << 1,
		HasDerivedSubTokensMask = 1uL << 2,
		HasHasNumbersMask = 1uL << 3,
		HasNonLettersMask = 1uL << 4,
		IsCJWordMask = 1uL << 5
	}

	[Native]
	public enum kCFFileDescriptor : ulong
	{
		ReadCallBack = 1uL << 0,
		WriteCallBack = 1uL << 1
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFFileDescriptorContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe Func<void*, void*>* retain;

		public unsafe Action<void*>* release;

		public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
	}

	[Native]
	public enum kCFUserNotification : ulong
	{
		StopAlertLevel = 0,
		NoteAlertLevel = 1,
		CautionAlertLevel = 2,
		PlainAlertLevel = 3
	}

	[Native]
	public enum kCFUserNotification : ulong
	{
		DefaultResponse = 0,
		AlternateResponse = 1,
		OtherResponse = 2,
		CancelResponse = 3
	}

	[Native]
	public enum kCFUserNotification : ulong
	{
		NoDefaultButtonFlag = (1uL << 5),
		UseRadioButtonsFlag = (1uL << 6)
	}

	[Native]
	public enum NSComparisonResult : long
	{
		Ascending = -1,
		Same,
		Descending
	}

	[Flags]
	[Native]
	public enum NSEnumerationOptions : ulong
	{
		Concurrent = (1uL << 0),
		Reverse = (1uL << 1)
	}

	[Flags]
	[Native]
	public enum NSSortOptions : ulong
	{
		Concurrent = (1uL << 0),
		Stable = (1uL << 4)
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSQualityOfService : long
	{
		UserInteractive = 33,
		UserInitiated = 25,
		Utility = 17,
		Background = 9,
		Default = -1
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSFastEnumerationState
	{
		public nuint state;

		public unsafe NSObject* itemsPtr;

		public unsafe nuint* mutationsPtr;

		public nuint[] extra;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSRange
	{
		public nuint location;

		public nuint length;
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSCollectionChangeType : long
	{
		Insert,
		Remove
	}

	[Watch (0x6,0x0), TV (0xd,0x0), Flags, Mac (0xa,0xf), iOS (0xd,0x0)]
	[Native]
	public enum NSOrderedCollectionDifferenceCalculationOptions : ulong
	{
		OmitInsertedObjects = (1uL << 0),
		OmitRemovedObjects = (1uL << 1),
		InferMoves = (1uL << 2)
	}

	[Flags]
	[Native]
	public enum NSBinarySearchingOptions : ulong
	{
		FirstEqual = (1uL << 8),
		LastEqual = (1uL << 9),
		InsertionIndex = (1uL << 10)
	}

	[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
	[Native]
	public enum NSItemProviderRepresentationVisibility : long
	{
		All = 0,
		Team = 1,
		Group = 2,
		OwnProcess = 3
	}

	[Watch (0x4,0x0), TV (0xb,0x0), Flags, Mac (0xa,0xd), iOS (0xb,0x0)]
	[Native]
	public enum NSItemProviderFileOptions : long
	{
		NSItemProviderFileOptionOpenInPlace = 0x1
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSItemProviderErrorCode : long
	{
		UnknownError = -1,
		ItemUnavailableError = -1000,
		UnexpectedValueClassError = -1100,
		UnavailableCoercionError = -1200
	}

	[Flags]
	[Native]
	public enum NSStringCompareOptions : ulong
	{
		CaseInsensitiveSearch = 0x1,
		LiteralSearch = 0x2,
		BackwardsSearch = 0x4,
		AnchoredSearch = 0x8,
		NumericSearch = 0x40,
		DiacriticInsensitiveSearch = 0x80,
		WidthInsensitiveSearch = 0x100,
		ForcedOrderingSearch = 0x200,
		RegularExpressionSearch = 0x400
	}

	[Native]
	public enum Ns : ulong
	{
		ASCIIStringEncoding = 1,
		NEXTSTEPStringEncoding = 2,
		JapaneseEUCStringEncoding = 3,
		UTF8StringEncoding = 4,
		ISOLatin1StringEncoding = 5,
		SymbolStringEncoding = 6,
		NonLossyASCIIStringEncoding = 7,
		ShiftJISStringEncoding = 8,
		ISOLatin2StringEncoding = 9,
		UnicodeStringEncoding = 10,
		WindowsCP1251StringEncoding = 11,
		WindowsCP1252StringEncoding = 12,
		WindowsCP1253StringEncoding = 13,
		WindowsCP1254StringEncoding = 14,
		WindowsCP1250StringEncoding = 15,
		ISO2022JPStringEncoding = 21,
		MacOSRomanStringEncoding = 30,
		UTF16StringEncoding = UnicodeStringEncoding,
		UTF16BigEndianStringEncoding = 2415919360L,
		UTF16LittleEndianStringEncoding = 2483028224L,
		UTF32StringEncoding = 2348810496L,
		UTF32BigEndianStringEncoding = 2550137088L,
		UTF32LittleEndianStringEncoding = 2617245952L
	}

	[Flags]
	[Native]
	public enum NSStringEncodingConversionOptions : ulong
	{
		AllowLossy = 0x1,
		ExternalRepresentation = 0x2
	}

	[Flags]
	[Native]
	public enum NSStringEnumerationOptions : ulong
	{
		ByLines = 0x0,
		ByParagraphs = 0x1,
		ByComposedCharacterSequences = 0x2,
		ByWords = 0x3,
		BySentences = 0x4,
		ByCaretPositions = 0x5,
		ByDeletionClusters = 0x6,
		Reverse = 1uL << 8,
		SubstringNotRequired = 1uL << 9,
		Localized = 1uL << 10
	}

	[Native]
	public enum  : ulong
	{
		NSProprietaryStringEncoding = 65536
	}

	public enum NSBundleExecutableArchitecture : uint
	{
		I386 = 7,
		Ppc = 18,
		X8664 = 16777223,
		Ppc64 = 16777234,
		Arm64 = 16777228
	}

	public enum Ns : uint
	{
		UnknownByteOrder = CFByteOrderUnknown,
		LittleEndian = CFByteOrderLittleEndian,
		BigEndian = CFByteOrderBigEndian
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSSwappedFloat
	{
		public uint v;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSSwappedDouble
	{
		public ulong v;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct fconv
	{
		[FieldOffset (0)]
		public float number;

		[FieldOffset (0)]
		public NSSwappedFloat sf;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct fconv
	{
		[FieldOffset (0)]
		public float number;

		[FieldOffset (0)]
		public NSSwappedFloat sf;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct dconv
	{
		[FieldOffset (0)]
		public double number;

		[FieldOffset (0)]
		public NSSwappedDouble sd;
	}

	[StructLayout (LayoutKind.Explicit)]
	public struct dconv
	{
		[FieldOffset (0)]
		public double number;

		[FieldOffset (0)]
		public NSSwappedDouble sd;
	}

	[Flags]
	[Native]
	public enum NSCalendarUnit : ulong
	{
		CalendarUnitEra = kCFCalendarUnitEra,
		CalendarUnitYear = kCFCalendarUnitYear,
		CalendarUnitMonth = kCFCalendarUnitMonth,
		CalendarUnitDay = kCFCalendarUnitDay,
		CalendarUnitHour = kCFCalendarUnitHour,
		CalendarUnitMinute = kCFCalendarUnitMinute,
		CalendarUnitSecond = kCFCalendarUnitSecond,
		CalendarUnitWeekday = kCFCalendarUnitWeekday,
		CalendarUnitWeekdayOrdinal = kCFCalendarUnitWeekdayOrdinal,
		CalendarUnitQuarter = kCFCalendarUnitQuarter,
		CalendarUnitWeekOfMonth = kCFCalendarUnitWeekOfMonth,
		CalendarUnitWeekOfYear = kCFCalendarUnitWeekOfYear,
		CalendarUnitYearForWeekOfYear = kCFCalendarUnitYearForWeekOfYear,
		CalendarUnitNanosecond = (1uL << 15),
		CalendarUnitCalendar = (1uL << 20),
		CalendarUnitTimeZone = (1uL << 21),
		EraCalendarUnit = CalendarUnitEra,
		YearCalendarUnit = CalendarUnitYear,
		MonthCalendarUnit = CalendarUnitMonth,
		DayCalendarUnit = CalendarUnitDay,
		HourCalendarUnit = CalendarUnitHour,
		MinuteCalendarUnit = CalendarUnitMinute,
		SecondCalendarUnit = CalendarUnitSecond,
		WeekCalendarUnit = kCFCalendarUnitWeek,
		WeekdayCalendarUnit = CalendarUnitWeekday,
		WeekdayOrdinalCalendarUnit = CalendarUnitWeekdayOrdinal,
		QuarterCalendarUnit = CalendarUnitQuarter,
		WeekOfMonthCalendarUnit = CalendarUnitWeekOfMonth,
		WeekOfYearCalendarUnit = CalendarUnitWeekOfYear,
		YearForWeekOfYearCalendarUnit = CalendarUnitYearForWeekOfYear,
		CalendarCalendarUnit = CalendarUnitCalendar,
		TimeZoneCalendarUnit = CalendarUnitTimeZone
	}

	[Flags]
	[Native]
	public enum NSCalendarOptions : ulong
	{
		WrapComponents = (1uL << 0),
		MatchStrictly = (1uL << 1),
		SearchBackwards = (1uL << 2),
		MatchPreviousTimePreservingSmallerUnits = (1uL << 8),
		MatchNextTimePreservingSmallerUnits = (1uL << 9),
		MatchNextTime = (1uL << 10),
		MatchFirst = (1uL << 12),
		MatchLast = (1uL << 13)
	}

	public enum  : uint
	{
		NSWrapCalendarComponents = NSCalendarWrapComponents
	}

	[Native]
	public enum Ns : long
	{
		DateComponentUndefined = 9223372036854775807L,
		UndefinedDateComponent = DateComponentUndefined
	}

	public enum  : uint
	{
		NSOpenStepUnicodeReservedBase = 62464
	}

	[Watch (2,0), TV (9,0), Mac (10,11), iOS (9,0)]
	[Native]
	public enum NSDecodingFailurePolicy : long
	{
		RaiseException,
		SetErrorAndReturn
	}

	[Flags]
	[Native]
	public enum NSDataReadingOptions : ulong
	{
		DataReadingMappedIfSafe = 1uL << 0,
		DataReadingUncached = 1uL << 1,
		DataReadingMappedAlways = 1uL << 3,
		DataReadingMapped = DataReadingMappedIfSafe,
		MappedRead = DataReadingMapped,
		UncachedRead = DataReadingUncached
	}

	[Flags]
	[Native]
	public enum NSDataWritingOptions : ulong
	{
		DataWritingAtomic = 1uL << 0,
		DataWritingWithoutOverwriting = 1uL << 1,
		DataWritingFileProtectionNone = 0x10000000,
		DataWritingFileProtectionComplete = 0x20000000,
		DataWritingFileProtectionCompleteUnlessOpen = 0x30000000,
		DataWritingFileProtectionCompleteUntilFirstUserAuthentication = 0x40000000,
		DataWritingFileProtectionMask = 0xf0000000L,
		AtomicWrite = DataWritingAtomic
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSDataSearchOptions : ulong
	{
		Backwards = 1uL << 0,
		Anchored = 1uL << 1
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x9), iOS (0x7,0x0)]
	[Native]
	public enum NSDataBase64EncodingOptions : ulong
	{
		NSDataBase64Encoding64CharacterLineLength = 1uL << 0,
		NSDataBase64Encoding76CharacterLineLength = 1uL << 1,
		EndLineWithCarriageReturn = 1uL << 4,
		EndLineWithLineFeed = 1uL << 5
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x9), iOS (0x7,0x0)]
	[Native]
	public enum NSDataBase64DecodingOptions : ulong
	{
		NSDataBase64DecodingIgnoreUnknownCharacters = 1uL << 0
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSDataCompressionAlgorithm : long
	{
		Lzfse = 0,
		Lz4,
		Lzma,
		Zlib
	}

	[Flags]
	[Native]
	public enum NSAttributedStringEnumerationOptions : ulong
	{
		Reverse = (1uL << 1),
		LongestEffectiveRangeNotRequired = (1uL << 20)
	}

	[Watch (0x8,0x0), TV (0xf,0x0), Flags, Mac (0xc,0x0), iOS (0xf,0x0)]
	[Native]
	public enum NSInlinePresentationIntent : ulong
	{
		Emphasized = 1uL << 0,
		StronglyEmphasized = 1uL << 1,
		Code = 1uL << 2,
		Strikethrough = 1uL << 5,
		SoftBreak = 1uL << 6,
		LineBreak = 1uL << 7,
		InlineHTML = 1uL << 8,
		BlockHTML = 1uL << 9
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSAttributedStringMarkdownParsingFailurePolicy : long
	{
		Error = 0,
		PartiallyParsedIfPossible = 1
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSAttributedStringMarkdownInterpretedSyntax : long
	{
		Full = 0,
		InlineOnly = 1,
		InlineOnlyPreservingWhitespace = 2
	}

	[Flags]
	[Native]
	public enum NSAttributedStringFormattingOptions : ulong
	{
		InsertArgumentAttributesWithoutMerging = 1uL << 0,
		ApplyReplacementIndexAttribute = 1uL << 1
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSPresentationIntentKind : long
	{
		Paragraph,
		Header,
		OrderedList,
		UnorderedList,
		ListItem,
		CodeBlock,
		BlockQuote,
		ThematicBreak,
		Table,
		TableHeaderRow,
		TableRow,
		TableCell
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSPresentationIntentTableColumnAlignment : long
	{
		Left,
		Center,
		Right
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSFormattingContext : long
	{
		Unknown = 0,
		Dynamic = 1,
		Standalone = 2,
		ListItem = 3,
		BeginningOfSentence = 4,
		MiddleOfSentence = 5
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSFormattingUnitStyle : long
	{
		Short = 1,
		Medium,
		Long
	}

	[Native]
	public enum NSDateFormatterStyle : ulong
	{
		NoStyle = kCFDateFormatterNoStyle,
		ShortStyle = kCFDateFormatterShortStyle,
		MediumStyle = kCFDateFormatterMediumStyle,
		LongStyle = kCFDateFormatterLongStyle,
		FullStyle = kCFDateFormatterFullStyle
	}

	[Native]
	public enum NSDateFormatterBehavior : ulong
	{
		Default = 0,
		NSDateFormatterBehavior10_4 = 1040
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSDateIntervalFormatterStyle : ulong
	{
		NoStyle = 0,
		ShortStyle = 1,
		MediumStyle = 2,
		LongStyle = 3,
		FullStyle = 4
	}

	[Flags]
	[Native]
	public enum NSISO8601DateFormatOptions : ulong
	{
		Year = kCFISO8601DateFormatWithYear,
		Month = kCFISO8601DateFormatWithMonth,
		WeekOfYear = kCFISO8601DateFormatWithWeekOfYear,
		Day = kCFISO8601DateFormatWithDay,
		Time = kCFISO8601DateFormatWithTime,
		TimeZone = kCFISO8601DateFormatWithTimeZone,
		SpaceBetweenDateAndTime = kCFISO8601DateFormatWithSpaceBetweenDateAndTime,
		DashSeparatorInDate = kCFISO8601DateFormatWithDashSeparatorInDate,
		ColonSeparatorInTime = kCFISO8601DateFormatWithColonSeparatorInTime,
		ColonSeparatorInTimeZone = kCFISO8601DateFormatWithColonSeparatorInTimeZone,
		FractionalSeconds = kCFISO8601DateFormatWithFractionalSeconds,
		FullDate = kCFISO8601DateFormatWithFullDate,
		FullTime = kCFISO8601DateFormatWithFullTime,
		InternetDateTime = kCFISO8601DateFormatWithInternetDateTime
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSMassFormatterUnit : long
	{
		Gram = 11,
		Kilogram = 14,
		Ounce = (6L << 8) + 1,
		Pound = (6L << 8) + 2,
		Stone = (6L << 8) + 3
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSLengthFormatterUnit : long
	{
		Millimeter = 8,
		Centimeter = 9,
		Meter = 11,
		Kilometer = 14,
		Inch = (5L << 8) + 1,
		Foot = (5L << 8) + 2,
		Yard = (5L << 8) + 3,
		Mile = (5L << 8) + 4
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSEnergyFormatterUnit : long
	{
		Joule = 11,
		Kilojoule = 14,
		Calorie = (7L << 8) + 1,
		Kilocalorie = (7L << 8) + 2
	}

	[Native]
	public enum NSNumberFormatterBehavior : ulong
	{
		Default = 0,
		NSNumberFormatterBehavior10_4 = 1040
	}

	[Native]
	public enum NSNumberFormatterStyle : ulong
	{
		NoStyle = kCFNumberFormatterNoStyle,
		DecimalStyle = kCFNumberFormatterDecimalStyle,
		CurrencyStyle = kCFNumberFormatterCurrencyStyle,
		PercentStyle = kCFNumberFormatterPercentStyle,
		ScientificStyle = kCFNumberFormatterScientificStyle,
		SpellOutStyle = kCFNumberFormatterSpellOutStyle,
		OrdinalStyle = kCFNumberFormatterOrdinalStyle,
		CurrencyISOCodeStyle = kCFNumberFormatterCurrencyISOCodeStyle,
		CurrencyPluralStyle = kCFNumberFormatterCurrencyPluralStyle,
		CurrencyAccountingStyle = kCFNumberFormatterCurrencyAccountingStyle
	}

	[Native]
	public enum NSNumberFormatterPadPosition : ulong
	{
		BeforePrefix = kCFNumberFormatterPadBeforePrefix,
		AfterPrefix = kCFNumberFormatterPadAfterPrefix,
		BeforeSuffix = kCFNumberFormatterPadBeforeSuffix,
		AfterSuffix = kCFNumberFormatterPadAfterSuffix
	}

	[Native]
	public enum NSNumberFormatterRoundingMode : ulong
	{
		Ceiling = kCFNumberFormatterRoundCeiling,
		Floor = kCFNumberFormatterRoundFloor,
		Down = kCFNumberFormatterRoundDown,
		Up = kCFNumberFormatterRoundUp,
		HalfEven = kCFNumberFormatterRoundHalfEven,
		HalfDown = kCFNumberFormatterRoundHalfDown,
		HalfUp = kCFNumberFormatterRoundHalfUp
	}

	[Native]
	public enum NSLocaleLanguageDirection : ulong
	{
		Unknown = kCFLocaleLanguageDirectionUnknown,
		LeftToRight = kCFLocaleLanguageDirectionLeftToRight,
		RightToLeft = kCFLocaleLanguageDirectionRightToLeft,
		TopToBottom = kCFLocaleLanguageDirectionTopToBottom,
		BottomToTop = kCFLocaleLanguageDirectionBottomToTop
	}

	[Watch (0x3,0x0), TV (0xa,0x0), Flags, Mac (0xa,0xc), iOS (0xa,0x0)]
	[Native]
	public enum NSMeasurementFormatterUnitOptions : ulong
	{
		ProvidedUnit = (1uL << 0),
		NaturalScale = (1uL << 1),
		TemperatureWithoutUnit = (1uL << 2)
	}

	[Watch (2,0), TV (9,0), Mac (10,11), iOS (9,0)]
	[Native]
	public enum NSPersonNameComponentsFormatterStyle : long
	{
		Default = 0,
		Short,
		Medium,
		Long,
		Abbreviated
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0xb), iOS (0x9,0x0)]
	[Native]
	public enum NSPersonNameComponentsFormatterOptions : ulong
	{
		NSPersonNameComponentsFormatterPhonetic = (1uL << 1)
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSRelativeDateTimeFormatterStyle : long
	{
		umeric = 0,
		amed
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSRelativeDateTimeFormatterUnitsStyle : long
	{
		Full = 0,
		SpellOut,
		Short,
		Abbreviated
	}

	[Native]
	public enum NSRoundingMode : ulong
	{
		Plain,
		Down,
		Up,
		Bankers
	}

	[Native]
	public enum NSCalculationError : ulong
	{
		NoError = 0,
		LossOfPrecision,
		Underflow,
		Overflow,
		DivideByZero
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSDecimal
	{
		public int _exponent;

		public uint _length;

		public uint _isNegative;

		public uint _isCompact;

		public uint _reserved;

		public ushort[] _mantissa;
	}

	[Native]
	public enum NSSearchPathDirectory : ulong
	{
		ApplicationDirectory = 1,
		DemoApplicationDirectory,
		DeveloperApplicationDirectory,
		AdminApplicationDirectory,
		LibraryDirectory,
		DeveloperDirectory,
		UserDirectory,
		DocumentationDirectory,
		DocumentDirectory,
		CoreServiceDirectory,
		AutosavedInformationDirectory = 11,
		DesktopDirectory = 12,
		CachesDirectory = 13,
		ApplicationSupportDirectory = 14,
		DownloadsDirectory = 15,
		InputMethodsDirectory = 16,
		MoviesDirectory = 17,
		MusicDirectory = 18,
		PicturesDirectory = 19,
		PrinterDescriptionDirectory = 20,
		SharedPublicDirectory = 21,
		PreferencePanesDirectory = 22,
		ApplicationScriptsDirectory = 23,
		ItemReplacementDirectory = 99,
		AllApplicationsDirectory = 100,
		AllLibrariesDirectory = 101,
		TrashDirectory = 102
	}

	[Flags]
	[Native]
	public enum NSSearchPathDomainMask : ulong
	{
		UserDomainMask = 0x1,
		LocalDomainMask = 0x2,
		NetworkDomainMask = 0x4,
		SystemDomainMask = 0x8,
		AllDomainsMask = 0xffff
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSURLBookmarkCreationOptions : ulong
	{
		PreferFileIDResolution = (1uL << 8),
		MinimalBookmark = (1uL << 9),
		SuitableForBookmarkFile = (1uL << 10),
		WithSecurityScope = (1uL << 11),
		SecurityScopeAllowOnlyReadAccess = (1uL << 12),
		WithoutImplicitSecurityScope = (1uL << 29)
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSURLBookmarkResolutionOptions : ulong
	{
		outUI = (1uL << 8),
		outMounting = (1uL << 9),
		SecurityScope = (1uL << 10),
		outImplicitStartAccessing = (1uL << 15)
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSVolumeEnumerationOptions : ulong
	{
		SkipHiddenVolumes = 1uL << 1,
		ProduceFileReferenceURLs = 1uL << 2
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSDirectoryEnumerationOptions : ulong
	{
		SkipsSubdirectoryDescendants = 1uL << 0,
		SkipsPackageDescendants = 1uL << 1,
		SkipsHiddenFiles = 1uL << 2,
		IncludesDirectoriesPostOrder = 1uL << 3,
		ProducesRelativePathURLs = 1uL << 4
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSFileManagerItemReplacementOptions : ulong
	{
		UsingNewMetadataOnly = 1uL << 0,
		WithoutDeletingBackupItem = 1uL << 1
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
	[Native]
	public enum NSURLRelationship : long
	{
		Contains,
		Same,
		Other
	}

	[Flags, NoWatch, NoTV, NoiOS, Mac (0xa,0xb)]
	[Native]
	public enum NSFileManagerUnmountOptions : ulong
	{
		AllPartitionsAndEjectDisk = 1uL << 0,
		WithoutUI = 1uL << 1
	}

	[Flags]
	[Native]
	public enum NSPointerFunctionsOptions : ulong
	{
		StrongMemory = (0uL << 0),
		ZeroingWeakMemory = (1uL << 0),
		OpaqueMemory = (2uL << 0),
		MallocMemory = (3uL << 0),
		MachVirtualMemory = (4uL << 0),
		WeakMemory = (5uL << 0),
		ObjectPersonality = (0uL << 8),
		OpaquePersonality = (1uL << 8),
		ObjectPointerPersonality = (2uL << 8),
		CStringPersonality = (3uL << 8),
		StructPersonality = (4uL << 8),
		IntegerPersonality = (5uL << 8),
		CopyIn = (1uL << 16)
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSHashEnumerator
	{
		public nuint _pi;

		public nuint _si;

		public unsafe void* _bs;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSHashTableCallBacks
	{
		public unsafe Func<NSHashTable, void*, nuint>* hash;

		public unsafe Func<NSHashTable, void*, void*, bool>* isEqual;

		public unsafe Action<NSHashTable, void*>* retain;

		public unsafe Action<NSHashTable, void*>* release;

		public unsafe Func<NSHashTable, void*, NSString>* describe;
	}

	[Native]
	public enum NSHTTPCookieAcceptPolicy : ulong
	{
		Always,
		Never,
		OnlyFromMainDocumentDomain
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x7), iOS (0x5,0x0)]
	[Native]
	public enum NSJSONReadingOptions : ulong
	{
		MutableContainers = (1uL << 0),
		MutableLeaves = (1uL << 1),
		FragmentsAllowed = (1uL << 2),
		JSON5Allowed = (1uL << 3),
		TopLevelDictionaryAssumed = (1uL << 4),
		AllowFragments = FragmentsAllowed
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x7), iOS (0x5,0x0)]
	[Native]
	public enum NSJSONWritingOptions : ulong
	{
		PrettyPrinted = (1uL << 0),
		SortedKeys = (1uL << 1),
		FragmentsAllowed = (1uL << 2),
		WithoutEscapingSlashes = (1uL << 3)
	}

	[Flags]
	[Native]
	public enum NSKeyValueObservingOptions : ulong
	{
		New = 0x1,
		Old = 0x2,
		Initial = 0x4,
		Prior = 0x8
	}

	[Native]
	public enum NSKeyValueChange : ulong
	{
		Setting = 1,
		Insertion = 2,
		Removal = 3,
		Replacement = 4
	}

	[Native]
	public enum NSKeyValueSetMutationKind : ulong
	{
		UnionSetMutation = 1,
		MinusSetMutation = 2,
		IntersectSetMutation = 3,
		SetSetMutation = 4
	}

	[Flags]
	[Native]
	public enum NSPropertyListReadOptions : ulong
	{
		Immutable = kCFPropertyListImmutable,
		MutableContainers = kCFPropertyListMutableContainers,
		MutableContainersAndLeaves = kCFPropertyListMutableContainersAndLeaves
	}

	[Native]
	public enum NSPropertyListFormat : ulong
	{
		OpenStepFormat = kCFPropertyListOpenStepFormat,
		XMLFormat_v1_0 = kCFPropertyListXMLFormat_v1_0,
		BinaryFormat_v1_0 = kCFPropertyListBinaryFormat_v1_0
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSMapEnumerator
	{
		public nuint _pi;

		public nuint _si;

		public unsafe void* _bs;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSMapTableKeyCallBacks
	{
		public unsafe Func<NSMapTable, void*, nuint>* hash;

		public unsafe Func<NSMapTable, void*, void*, bool>* isEqual;

		public unsafe Action<NSMapTable, void*>* retain;

		public unsafe Action<NSMapTable, void*>* release;

		public unsafe Func<NSMapTable, void*, NSString>* describe;

		public unsafe void* notAKeyMarker;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSMapTableValueCallBacks
	{
		public unsafe Action<NSMapTable, void*>* retain;

		public unsafe Action<NSMapTable, void*>* release;

		public unsafe Func<NSMapTable, void*, NSString>* describe;
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSGrammaticalGender : long
	{
		NotSet = 0,
		Feminine,
		Masculine,
		Neuter
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSGrammaticalPartOfSpeech : long
	{
		NotSet = 0,
		Determiner,
		Pronoun,
		Letter,
		Adverb,
		Particle,
		Adjective,
		Adposition,
		Verb,
		Noun,
		Conjunction,
		Numeral,
		Interjection,
		Preposition,
		Abbreviation
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSGrammaticalNumber : long
	{
		NotSet = 0,
		Singular,
		Zero,
		Plural,
		PluralTwo,
		PluralFew,
		PluralMany
	}

	[Native]
	public enum NSPostingStyle : ulong
	{
		WhenIdle = 1,
		Asap = 2,
		Now = 3
	}

	[Flags]
	[Native]
	public enum NSNotificationCoalescing : ulong
	{
		NoCoalescing = 0x0,
		CoalescingOnName = 0x1,
		CoalescingOnSender = 0x2
	}

	[Native]
	public enum NSOperationQueuePriority : long
	{
		VeryLow = -8,
		Low = -4,
		Normal = 0,
		High = 4,
		VeryHigh = 8
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x5), iOS (0x2,0x0)]
	[Native]
	public enum NSMachPortOptions : ulong
	{
		None = 0x0,
		SendRight = (1uL << 0),
		ReceiveRight = (1uL << 1)
	}

	[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
	[Deprecated (PlatformName.MacOSX, 10, 10, message: "Not supported")]
	[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
	[Deprecated (PlatformName.iOS, 8, 0, message: "Not supported")]
	[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
	[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
	[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
	[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
	public enum Ns : uint
	{
		WindowsNTOperatingSystem = 1,
		Windows95OperatingSystem,
		SolarisOperatingSystem,
		HPUXOperatingSystem,
		MACHOperatingSystem,
		SunOSOperatingSystem,
		OSF1OperatingSystem
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct NSOperatingSystemVersion
	{
		public nint majorVersion;

		public nint minorVersion;

		public nint patchVersion;
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x9), iOS (0x7,0x0)]
	public enum NSActivityOptions : ulong
	{
		IdleDisplaySleepDisabled = (1uL << 40),
		IdleSystemSleepDisabled = (1uL << 20),
		SuddenTerminationDisabled = (1uL << 14),
		AutomaticTerminationDisabled = (1uL << 15),
		AnimationTrackingEnabled = (1uL << 45),
		TrackingEnabled = (1uL << 46),
		UserInitiated = (0xffffff | IdleSystemSleepDisabled),
		UserInitiatedAllowingIdleSystemSleep = (UserInitiated & ~IdleSystemSleepDisabled),
		Background = 0xff,
		LatencyCritical = 0xff00000000L,
		UserInteractive = (UserInitiated | LatencyCritical)
	}

	[Watch (4,0), TV (11,0), Mac (10,10,3), iOS (11,0)]
	[Native]
	public enum NSProcessInfoThermalState : long
	{
		Nominal,
		Fair,
		Serious,
		Critical
	}

	[Flags]
	public enum NSTextCheckingType : ulong
	{
		Orthography = 1uL << 0,
		Spelling = 1uL << 1,
		Grammar = 1uL << 2,
		Date = 1uL << 3,
		Address = 1uL << 4,
		Link = 1uL << 5,
		Quote = 1uL << 6,
		Dash = 1uL << 7,
		Replacement = 1uL << 8,
		Correction = 1uL << 9,
		RegularExpression = 1uL << 10,
		PhoneNumber = 1uL << 11,
		TransitInformation = 1uL << 12
	}

	public enum NSTextCheckingAll : ulong
	{
		SystemTypes = 4294967295L,
		CustomTypes = 4294967295uL << 32,
		Types = (SystemTypes | CustomTypes)
	}

	[Flags]
	[Native]
	public enum NSRegularExpressionOptions : ulong
	{
		CaseInsensitive = 1uL << 0,
		AllowCommentsAndWhitespace = 1uL << 1,
		IgnoreMetacharacters = 1uL << 2,
		DotMatchesLineSeparators = 1uL << 3,
		AnchorsMatchLines = 1uL << 4,
		UseUnixLineSeparators = 1uL << 5,
		UseUnicodeWordBoundaries = 1uL << 6
	}

	[Flags]
	[Native]
	public enum NSMatchingOptions : ulong
	{
		ReportProgress = 1uL << 0,
		ReportCompletion = 1uL << 1,
		Anchored = 1uL << 2,
		WithTransparentBounds = 1uL << 3,
		WithoutAnchoringBounds = 1uL << 4
	}

	[Flags]
	[Native]
	public enum NSMatchingFlags : ulong
	{
		Progress = 1uL << 0,
		Completed = 1uL << 1,
		HitEnd = 1uL << 2,
		RequiredEnd = 1uL << 3,
		InternalError = 1uL << 4
	}

	[Native]
	public enum NSStreamStatus : ulong
	{
		NotOpen = 0,
		Opening = 1,
		Open = 2,
		Reading = 3,
		Writing = 4,
		AtEnd = 5,
		Closed = 6,
		Error = 7
	}

	[Flags]
	[Native]
	public enum NSStreamEvent : ulong
	{
		None = 0x0,
		OpenCompleted = 1uL << 0,
		HasBytesAvailable = 1uL << 1,
		HasSpaceAvailable = 1uL << 2,
		ErrorOccurred = 1uL << 3,
		EndEncountered = 1uL << 4
	}

	[Native]
	public enum NSTimeZoneNameStyle : long
	{
		Standard,
		ShortStandard,
		DaylightSaving,
		ShortDaylightSaving,
		Generic,
		ShortGeneric
	}

	[Native]
	public enum NSURLCacheStoragePolicy : ulong
	{
		Allowed,
		AllowedInMemoryOnly,
		NotAllowed
	}

	[NoWatch, NoTV, NoMacCatalyst, NoiOS]
	[StructLayout (LayoutKind.Sequential)]
	public struct SecKeychainAttribute
	{
		public uint tag;

		public uint length;

		public unsafe void* data;
	}

	[NoWatch, NoTV, NoMacCatalyst, NoiOS]
	[StructLayout (LayoutKind.Sequential)]
	public struct SecKeychainAttributeList
	{
		public uint count;

		public unsafe SecKeychainAttribute* attr;
	}

	[NoWatch, NoTV, NoMacCatalyst, NoiOS]
	[StructLayout (LayoutKind.Sequential)]
	public struct SecKeychainAttributeInfo
	{
		public uint count;

		public unsafe uint* tag;

		public unsafe uint* format;
	}

	public enum errSec
	{
		Success = 0,
		Unimplemented = -4,
		DiskFull = -34,
		DskFull = DiskFull,
		Io = -36,
		OpWr = -49,
		Param = -50,
		WrPerm = -61,
		Allocate = -108,
		UserCanceled = -128,
		BadReq = -909,
		InternalComponent = -2070,
		CoreFoundationUnknown = -4960,
		MissingEntitlement = -34018,
		RestrictedAPI = -34020,
		NotAvailable = -25291,
		ReadOnly = -25292,
		AuthFailed = -25293,
		NoSuchKeychain = -25294,
		InvalidKeychain = -25295,
		DuplicateKeychain = -25296,
		DuplicateCallback = -25297,
		InvalidCallback = -25298,
		DuplicateItem = -25299,
		ItemNotFound = -25300,
		BufferTooSmall = -25301,
		DataTooLarge = -25302,
		NoSuchAttr = -25303,
		InvalidItemRef = -25304,
		InvalidSearchRef = -25305,
		NoSuchClass = -25306,
		NoDefaultKeychain = -25307,
		InteractionNotAllowed = -25308,
		ReadOnlyAttr = -25309,
		WrongSecVersion = -25310,
		KeySizeNotAllowed = -25311,
		NoStorageModule = -25312,
		NoCertificateModule = -25313,
		NoPolicyModule = -25314,
		InteractionRequired = -25315,
		DataNotAvailable = -25316,
		DataNotModifiable = -25317,
		CreateChainFailed = -25318,
		InvalidPrefsDomain = -25319,
		InDarkWake = -25320,
		ACLNotSimple = -25240,
		PolicyNotFound = -25241,
		InvalidTrustSetting = -25242,
		NoAccessForItem = -25243,
		InvalidOwnerEdit = -25244,
		TrustNotAvailable = -25245,
		UnsupportedFormat = -25256,
		UnknownFormat = -25257,
		KeyIsSensitive = -25258,
		MultiplePrivKeys = -25259,
		PassphraseRequired = -25260,
		InvalidPasswordRef = -25261,
		InvalidTrustSettings = -25262,
		NoTrustSettings = -25263,
		Pkcs12VerifyFailure = -25264,
		NotSigner = -26267,
		Decode = -26275,
		ServiceNotAvailable = -67585,
		InsufficientClientID = -67586,
		DeviceReset = -67587,
		DeviceFailed = -67588,
		AppleAddAppACLSubject = -67589,
		ApplePublicKeyIncomplete = -67590,
		AppleSignatureMismatch = -67591,
		AppleInvalidKeyStartDate = -67592,
		AppleInvalidKeyEndDate = -67593,
		ConversionError = -67594,
		AppleSSLv2Rollback = -67595,
		QuotaExceeded = -67596,
		FileTooBig = -67597,
		InvalidDatabaseBlob = -67598,
		InvalidKeyBlob = -67599,
		IncompatibleDatabaseBlob = -67600,
		IncompatibleKeyBlob = -67601,
		HostNameMismatch = -67602,
		UnknownCriticalExtensionFlag = -67603,
		NoBasicConstraints = -67604,
		NoBasicConstraintsCA = -67605,
		InvalidAuthorityKeyID = -67606,
		InvalidSubjectKeyID = -67607,
		InvalidKeyUsageForPolicy = -67608,
		InvalidExtendedKeyUsage = -67609,
		InvalidIDLinkage = -67610,
		PathLengthConstraintExceeded = -67611,
		InvalidRoot = -67612,
		CRLExpired = -67613,
		CRLNotValidYet = -67614,
		CRLNotFound = -67615,
		CRLServerDown = -67616,
		CRLBadURI = -67617,
		UnknownCertExtension = -67618,
		UnknownCRLExtension = -67619,
		CRLNotTrusted = -67620,
		CRLPolicyFailed = -67621,
		IDPFailure = -67622,
		SMIMEEmailAddressesNotFound = -67623,
		SMIMEBadExtendedKeyUsage = -67624,
		SMIMEBadKeyUsage = -67625,
		SMIMEKeyUsageNotCritical = -67626,
		SMIMENoEmailAddress = -67627,
		SMIMESubjAltNameNotCritical = -67628,
		SSLBadExtendedKeyUsage = -67629,
		OCSPBadResponse = -67630,
		OCSPBadRequest = -67631,
		OCSPUnavailable = -67632,
		OCSPStatusUnrecognized = -67633,
		EndOfData = -67634,
		IncompleteCertRevocationCheck = -67635,
		NetworkFailure = -67636,
		OCSPNotTrustedToAnchor = -67637,
		RecordModified = -67638,
		OCSPSignatureError = -67639,
		OCSPNoSigner = -67640,
		OCSPResponderMalformedReq = -67641,
		OCSPResponderInternalError = -67642,
		OCSPResponderTryLater = -67643,
		OCSPResponderSignatureRequired = -67644,
		OCSPResponderUnauthorized = -67645,
		OCSPResponseNonceMismatch = -67646,
		CodeSigningBadCertChainLength = -67647,
		CodeSigningNoBasicConstraints = -67648,
		CodeSigningBadPathLengthConstraint = -67649,
		CodeSigningNoExtendedKeyUsage = -67650,
		CodeSigningDevelopment = -67651,
		ResourceSignBadCertChainLength = -67652,
		ResourceSignBadExtKeyUsage = -67653,
		TrustSettingDeny = -67654,
		InvalidSubjectName = -67655,
		UnknownQualifiedCertStatement = -67656,
		MobileMeRequestQueued = -67657,
		MobileMeRequestRedirected = -67658,
		MobileMeServerError = -67659,
		MobileMeServerNotAvailable = -67660,
		MobileMeServerAlreadyExists = -67661,
		MobileMeServerServiceErr = -67662,
		MobileMeRequestAlreadyPending = -67663,
		MobileMeNoRequestPending = -67664,
		MobileMeCSRVerifyFailure = -67665,
		MobileMeFailedConsistencyCheck = -67666,
		NotInitialized = -67667,
		InvalidHandleUsage = -67668,
		PVCReferentNotFound = -67669,
		FunctionIntegrityFail = -67670,
		InternalError = -67671,
		MemoryError = -67672,
		InvalidData = -67673,
		MDSError = -67674,
		InvalidPointer = -67675,
		SelfCheckFailed = -67676,
		FunctionFailed = -67677,
		ModuleManifestVerifyFailed = -67678,
		InvalidGUID = -67679,
		InvalidHandle = -67680,
		InvalidDBList = -67681,
		InvalidPassthroughID = -67682,
		InvalidNetworkAddress = -67683,
		CRLAlreadySigned = -67684,
		InvalidNumberOfFields = -67685,
		VerificationFailure = -67686,
		UnknownTag = -67687,
		InvalidSignature = -67688,
		InvalidName = -67689,
		InvalidCertificateRef = -67690,
		InvalidCertificateGroup = -67691,
		TagNotFound = -67692,
		InvalidQuery = -67693,
		InvalidValue = -67694,
		CallbackFailed = -67695,
		ACLDeleteFailed = -67696,
		ACLReplaceFailed = -67697,
		ACLAddFailed = -67698,
		ACLChangeFailed = -67699,
		InvalidAccessCredentials = -67700,
		InvalidRecord = -67701,
		InvalidACL = -67702,
		InvalidSampleValue = -67703,
		IncompatibleVersion = -67704,
		PrivilegeNotGranted = -67705,
		InvalidScope = -67706,
		PVCAlreadyConfigured = -67707,
		InvalidPVC = -67708,
		EMMLoadFailed = -67709,
		EMMUnloadFailed = -67710,
		AddinLoadFailed = -67711,
		InvalidKeyRef = -67712,
		InvalidKeyHierarchy = -67713,
		AddinUnloadFailed = -67714,
		LibraryReferenceNotFound = -67715,
		InvalidAddinFunctionTable = -67716,
		InvalidServiceMask = -67717,
		ModuleNotLoaded = -67718,
		InvalidSubServiceID = -67719,
		AttributeNotInContext = -67720,
		ModuleManagerInitializeFailed = -67721,
		ModuleManagerNotFound = -67722,
		EventNotificationCallbackNotFound = -67723,
		InputLengthError = -67724,
		OutputLengthError = -67725,
		PrivilegeNotSupported = -67726,
		DeviceError = -67727,
		AttachHandleBusy = -67728,
		NotLoggedIn = -67729,
		AlgorithmMismatch = -67730,
		KeyUsageIncorrect = -67731,
		KeyBlobTypeIncorrect = -67732,
		KeyHeaderInconsistent = -67733,
		UnsupportedKeyFormat = -67734,
		UnsupportedKeySize = -67735,
		InvalidKeyUsageMask = -67736,
		UnsupportedKeyUsageMask = -67737,
		InvalidKeyAttributeMask = -67738,
		UnsupportedKeyAttributeMask = -67739,
		InvalidKeyLabel = -67740,
		UnsupportedKeyLabel = -67741,
		InvalidKeyFormat = -67742,
		UnsupportedVectorOfBuffers = -67743,
		InvalidInputVector = -67744,
		InvalidOutputVector = -67745,
		InvalidContext = -67746,
		InvalidAlgorithm = -67747,
		InvalidAttributeKey = -67748,
		MissingAttributeKey = -67749,
		InvalidAttributeInitVector = -67750,
		MissingAttributeInitVector = -67751,
		InvalidAttributeSalt = -67752,
		MissingAttributeSalt = -67753,
		InvalidAttributePadding = -67754,
		MissingAttributePadding = -67755,
		InvalidAttributeRandom = -67756,
		MissingAttributeRandom = -67757,
		InvalidAttributeSeed = -67758,
		MissingAttributeSeed = -67759,
		InvalidAttributePassphrase = -67760,
		MissingAttributePassphrase = -67761,
		InvalidAttributeKeyLength = -67762,
		MissingAttributeKeyLength = -67763,
		InvalidAttributeBlockSize = -67764,
		MissingAttributeBlockSize = -67765,
		InvalidAttributeOutputSize = -67766,
		MissingAttributeOutputSize = -67767,
		InvalidAttributeRounds = -67768,
		MissingAttributeRounds = -67769,
		InvalidAlgorithmParms = -67770,
		MissingAlgorithmParms = -67771,
		InvalidAttributeLabel = -67772,
		MissingAttributeLabel = -67773,
		InvalidAttributeKeyType = -67774,
		MissingAttributeKeyType = -67775,
		InvalidAttributeMode = -67776,
		MissingAttributeMode = -67777,
		InvalidAttributeEffectiveBits = -67778,
		MissingAttributeEffectiveBits = -67779,
		InvalidAttributeStartDate = -67780,
		MissingAttributeStartDate = -67781,
		InvalidAttributeEndDate = -67782,
		MissingAttributeEndDate = -67783,
		InvalidAttributeVersion = -67784,
		MissingAttributeVersion = -67785,
		InvalidAttributePrime = -67786,
		MissingAttributePrime = -67787,
		InvalidAttributeBase = -67788,
		MissingAttributeBase = -67789,
		InvalidAttributeSubprime = -67790,
		MissingAttributeSubprime = -67791,
		InvalidAttributeIterationCount = -67792,
		MissingAttributeIterationCount = -67793,
		InvalidAttributeDLDBHandle = -67794,
		MissingAttributeDLDBHandle = -67795,
		InvalidAttributeAccessCredentials = -67796,
		MissingAttributeAccessCredentials = -67797,
		InvalidAttributePublicKeyFormat = -67798,
		MissingAttributePublicKeyFormat = -67799,
		InvalidAttributePrivateKeyFormat = -67800,
		MissingAttributePrivateKeyFormat = -67801,
		InvalidAttributeSymmetricKeyFormat = -67802,
		MissingAttributeSymmetricKeyFormat = -67803,
		InvalidAttributeWrappedKeyFormat = -67804,
		MissingAttributeWrappedKeyFormat = -67805,
		StagedOperationInProgress = -67806,
		StagedOperationNotStarted = -67807,
		VerifyFailed = -67808,
		QuerySizeUnknown = -67809,
		BlockSizeMismatch = -67810,
		PublicKeyInconsistent = -67811,
		DeviceVerifyFailed = -67812,
		InvalidLoginName = -67813,
		AlreadyLoggedIn = -67814,
		InvalidDigestAlgorithm = -67815,
		InvalidCRLGroup = -67816,
		CertificateCannotOperate = -67817,
		CertificateExpired = -67818,
		CertificateNotValidYet = -67819,
		CertificateRevoked = -67820,
		CertificateSuspended = -67821,
		InsufficientCredentials = -67822,
		InvalidAction = -67823,
		InvalidAuthority = -67824,
		VerifyActionFailed = -67825,
		InvalidCertAuthority = -67826,
		InvalidCRLAuthority = -67827,
		InvaldCRLAuthority = InvalidCRLAuthority,
		InvalidCRLEncoding = -67828,
		InvalidCRLType = -67829,
		InvalidCRL = -67830,
		InvalidFormType = -67831,
		InvalidID = -67832,
		InvalidIdentifier = -67833,
		InvalidIndex = -67834,
		InvalidPolicyIdentifiers = -67835,
		InvalidTimeString = -67836,
		InvalidReason = -67837,
		InvalidRequestInputs = -67838,
		InvalidResponseVector = -67839,
		InvalidStopOnPolicy = -67840,
		InvalidTuple = -67841,
		MultipleValuesUnsupported = -67842,
		NotTrusted = -67843,
		NoDefaultAuthority = -67844,
		RejectedForm = -67845,
		RequestLost = -67846,
		RequestRejected = -67847,
		UnsupportedAddressType = -67848,
		UnsupportedService = -67849,
		InvalidTupleGroup = -67850,
		InvalidBaseACLs = -67851,
		InvalidTupleCredentials = -67852,
		InvalidTupleCredendtials = InvalidTupleCredentials,
		InvalidEncoding = -67853,
		InvalidValidityPeriod = -67854,
		InvalidRequestor = -67855,
		RequestDescriptor = -67856,
		InvalidBundleInfo = -67857,
		InvalidCRLIndex = -67858,
		NoFieldValues = -67859,
		UnsupportedFieldFormat = -67860,
		UnsupportedIndexInfo = -67861,
		UnsupportedLocality = -67862,
		UnsupportedNumAttributes = -67863,
		UnsupportedNumIndexes = -67864,
		UnsupportedNumRecordTypes = -67865,
		FieldSpecifiedMultiple = -67866,
		IncompatibleFieldFormat = -67867,
		InvalidParsingModule = -67868,
		DatabaseLocked = -67869,
		DatastoreIsOpen = -67870,
		MissingValue = -67871,
		UnsupportedQueryLimits = -67872,
		UnsupportedNumSelectionPreds = -67873,
		UnsupportedOperator = -67874,
		InvalidDBLocation = -67875,
		InvalidAccessRequest = -67876,
		InvalidIndexInfo = -67877,
		InvalidNewOwner = -67878,
		InvalidModifyMode = -67879,
		MissingRequiredExtension = -67880,
		ExtendedKeyUsageNotCritical = -67881,
		TimestampMissing = -67882,
		TimestampInvalid = -67883,
		TimestampNotTrusted = -67884,
		TimestampServiceNotAvailable = -67885,
		TimestampBadAlg = -67886,
		TimestampBadRequest = -67887,
		TimestampBadDataFormat = -67888,
		TimestampTimeNotAvailable = -67889,
		TimestampUnacceptedPolicy = -67890,
		TimestampUnacceptedExtension = -67891,
		TimestampAddInfoNotAvailable = -67892,
		TimestampSystemFailure = -67893,
		SigningTimeMissing = -67894,
		TimestampRejection = -67895,
		TimestampWaiting = -67896,
		TimestampRevocationWarning = -67897,
		TimestampRevocationNotification = -67898,
		CertificatePolicyNotAllowed = -67899,
		CertificateNameNotAllowed = -67900,
		CertificateValidityPeriodTooLong = -67901,
		CertificateIsCA = -67902,
		CertificateDuplicateExtension = -67903
	}

	public enum errSSL
	{
		Protocol = -9800,
		Negotiation = -9801,
		FatalAlert = -9802,
		WouldBlock = -9803,
		SessionNotFound = -9804,
		ClosedGraceful = -9805,
		ClosedAbort = -9806,
		XCertChainInvalid = -9807,
		BadCert = -9808,
		Crypto = -9809,
		Internal = -9810,
		ModuleAttach = -9811,
		UnknownRootCert = -9812,
		NoRootCert = -9813,
		CertExpired = -9814,
		CertNotYetValid = -9815,
		ClosedNoNotify = -9816,
		BufferOverflow = -9817,
		BadCipherSuite = -9818,
		PeerUnexpectedMsg = -9819,
		PeerBadRecordMac = -9820,
		PeerDecryptionFail = -9821,
		PeerRecordOverflow = -9822,
		PeerDecompressFail = -9823,
		PeerHandshakeFail = -9824,
		PeerBadCert = -9825,
		PeerUnsupportedCert = -9826,
		PeerCertRevoked = -9827,
		PeerCertExpired = -9828,
		PeerCertUnknown = -9829,
		IllegalParam = -9830,
		PeerUnknownCA = -9831,
		PeerAccessDenied = -9832,
		PeerDecodeError = -9833,
		PeerDecryptError = -9834,
		PeerExportRestriction = -9835,
		PeerProtocolVersion = -9836,
		PeerInsufficientSecurity = -9837,
		PeerInternalError = -9838,
		PeerUserCancelled = -9839,
		PeerNoRenegotiation = -9840,
		PeerAuthCompleted = -9841,
		ClientCertRequested = -9842,
		HostNameMismatch = -9843,
		ConnectionRefused = -9844,
		DecryptionFail = -9845,
		BadRecordMac = -9846,
		RecordOverflow = -9847,
		BadConfiguration = -9848,
		UnexpectedRecord = -9849,
		WeakPeerEphemeralDHKey = -9850,
		ClientHelloReceived = -9851,
		TransportReset = -9852,
		NetworkTimeout = -9853,
		ConfigurationFailed = -9854,
		UnsupportedExtension = -9855,
		UnexpectedMessage = -9856,
		DecompressFail = -9857,
		HandshakeFail = -9858,
		DecodeError = -9859,
		InappropriateFallback = -9860,
		MissingExtension = -9861,
		BadCertificateStatusResponse = -9862,
		CertificateRequired = -9863,
		UnknownPSKIdentity = -9864,
		UnrecognizedName = -9865,
		ATSViolation = -9880,
		ATSMinimumVersionViolation = -9881,
		ATSCiphersuiteViolation = -9882,
		ATSMinimumKeySizeViolation = -9883,
		ATSLeafCertificateHashAlgorithmViolation = -9884,
		ATSCertificateHashAlgorithmViolation = -9885,
		ATSCertificateTrustViolation = -9886,
		EarlyDataRejected = -9890
	}

	[Flags, iOS (0x8,0x0)]
	[Native]
	public enum SecAccessControlCreateFlags : ulong
	{
		UserPresence = 1uL << 0,
		BiometryAny = 1uL << 1,
		TouchIDAny = 1uL << 1,
		BiometryCurrentSet = 1uL << 3,
		TouchIDCurrentSet = 1uL << 3,
		DevicePasscode = 1uL << 4,
		Watch = 1uL << 5,
		Or = 1uL << 14,
		And = 1uL << 15,
		PrivateKeyUsage = 1uL << 30,
		ApplicationPassword = 1uL << 31
	}

	[Introduced (PlatformName.MacOSX, 0xa, 0x6, message: "Replaced with SecKeyAlgorithm")]
	[Deprecated (PlatformName.MacOSX, 0xc, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Introduced (PlatformName.iOS, 0x2, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Deprecated (PlatformName.iOS, 0xf, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Introduced (PlatformName.TvOS, 0x4, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Deprecated (PlatformName.TvOS, 0xf, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Introduced (PlatformName.WatchOS, 0x1, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Deprecated (PlatformName.WatchOS, 0x8, 0x0, message: "Replaced with SecKeyAlgorithm")]
	[Flags]
	public enum SecPadding : uint
	{
		None = 0x0,
		Pkcs1 = 0x1,
		Oaep = 0x2,
		SigRaw = 0x4000,
		Pkcs1md2 = 0x8000,
		Pkcs1md5 = 0x8001,
		Pkcs1sha1 = 0x8002,
		Pkcs1sha224 = 0x8003,
		Pkcs1sha256 = 0x8004,
		Pkcs1sha384 = 0x8005,
		Pkcs1sha512 = 0x8006
	}

	[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
	[Native]
	public enum SecKeyOperationType : long
	{
		Sign = 0,
		Verify = 1,
		Encrypt = 2,
		Decrypt = 3,
		KeyExchange = 4
	}

	[Native]
	public enum kSecRevocation : ulong
	{
		OCSPMethod = (1uL << 0),
		CRLMethod = (1uL << 1),
		PreferCRL = (1uL << 2),
		RequirePositiveResponse = (1uL << 3),
		NetworkAccessDisabled = (1uL << 4),
		UseAnyAvailableMethod = (OCSPMethod | CRLMethod)
	}

	public enum SecTrustResultType : uint
	{
		Invalid = 0,
		Proceed = 1,
		Confirm = 2,
		Deny = 3,
		Unspecified = 4,
		RecoverableTrustFailure = 5,
		FatalTrustFailure = 6,
		OtherError = 7
	}

	public enum  : ushort
	{
		SslNullWithNullNull = 0,
		SslRsaWithNullMd5 = 1,
		SslRsaWithNullSha = 2,
		SslRsaExportWithRc440Md5 = 3,
		SslRsaWithRc4128Md5 = 4,
		SslRsaWithRc4128Sha = 5,
		SslRsaExportWithRc2Cbc40Md5 = 6,
		SslRsaWithIdeaCbcSha = 7,
		SslRsaExportWithDes40CbcSha = 8,
		SslRsaWithDesCbcSha = 9,
		SslRsaWith3desEdeCbcSha = 10,
		SslDhDssExportWithDes40CbcSha = 11,
		SslDhDssWithDesCbcSha = 12,
		SslDhDssWith3desEdeCbcSha = 13,
		SslDhRsaExportWithDes40CbcSha = 14,
		SslDhRsaWithDesCbcSha = 15,
		SslDhRsaWith3desEdeCbcSha = 16,
		SslDheDssExportWithDes40CbcSha = 17,
		SslDheDssWithDesCbcSha = 18,
		SslDheDssWith3desEdeCbcSha = 19,
		SslDheRsaExportWithDes40CbcSha = 20,
		SslDheRsaWithDesCbcSha = 21,
		SslDheRsaWith3desEdeCbcSha = 22,
		SSL_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
		SSL_DH_anon_WITH_RC4_128_MD5 = 24,
		SSL_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
		SSL_DH_anon_WITH_DES_CBC_SHA = 26,
		SSL_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
		SslFortezzaDmsWithNullSha = 28,
		SslFortezzaDmsWithFortezzaCbcSha = 29,
		TlsRsaWithAes128CbcSha = 47,
		TlsDhDssWithAes128CbcSha = 48,
		TlsDhRsaWithAes128CbcSha = 49,
		TlsDheDssWithAes128CbcSha = 50,
		TlsDheRsaWithAes128CbcSha = 51,
		TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
		TlsRsaWithAes256CbcSha = 53,
		TlsDhDssWithAes256CbcSha = 54,
		TlsDhRsaWithAes256CbcSha = 55,
		TlsDheDssWithAes256CbcSha = 56,
		TlsDheRsaWithAes256CbcSha = 57,
		TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
		TlsEcdhEcdsaWithNullSha = 49153,
		TlsEcdhEcdsaWithRc4128Sha = 49154,
		TlsEcdhEcdsaWith3desEdeCbcSha = 49155,
		TlsEcdhEcdsaWithAes128CbcSha = 49156,
		TlsEcdhEcdsaWithAes256CbcSha = 49157,
		TlsEcdheEcdsaWithNullSha = 49158,
		TlsEcdheEcdsaWithRc4128Sha = 49159,
		TlsEcdheEcdsaWith3desEdeCbcSha = 49160,
		TlsEcdheEcdsaWithAes128CbcSha = 49161,
		TlsEcdheEcdsaWithAes256CbcSha = 49162,
		TlsEcdhRsaWithNullSha = 49163,
		TlsEcdhRsaWithRc4128Sha = 49164,
		TlsEcdhRsaWith3desEdeCbcSha = 49165,
		TlsEcdhRsaWithAes128CbcSha = 49166,
		TlsEcdhRsaWithAes256CbcSha = 49167,
		TlsEcdheRsaWithNullSha = 49168,
		TlsEcdheRsaWithRc4128Sha = 49169,
		TlsEcdheRsaWith3desEdeCbcSha = 49170,
		TlsEcdheRsaWithAes128CbcSha = 49171,
		TlsEcdheRsaWithAes256CbcSha = 49172,
		TLS_ECDH_anon_WITH_NULL_SHA = 49173,
		TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
		TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
		TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
		TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
		TlsEcdhePskWithAes128CbcSha = 49205,
		TlsEcdhePskWithAes256CbcSha = 49206,
		TlsPskWithChacha20Poly1305Sha256 = 52395,
		TlsNullWithNullNull = 0,
		TlsRsaWithNullMd5 = 1,
		TlsRsaWithNullSha = 2,
		TlsRsaWithRc4128Md5 = 4,
		TlsRsaWithRc4128Sha = 5,
		TlsRsaWith3desEdeCbcSha = 10,
		TlsRsaWithNullSha256 = 59,
		TlsRsaWithAes128CbcSha256 = 60,
		TlsRsaWithAes256CbcSha256 = 61,
		TlsDhDssWith3desEdeCbcSha = 13,
		TlsDhRsaWith3desEdeCbcSha = 16,
		TlsDheDssWith3desEdeCbcSha = 19,
		TlsDheRsaWith3desEdeCbcSha = 22,
		TlsDhDssWithAes128CbcSha256 = 62,
		TlsDhRsaWithAes128CbcSha256 = 63,
		TlsDheDssWithAes128CbcSha256 = 64,
		TlsDheRsaWithAes128CbcSha256 = 103,
		TlsDhDssWithAes256CbcSha256 = 104,
		TlsDhRsaWithAes256CbcSha256 = 105,
		TlsDheDssWithAes256CbcSha256 = 106,
		TlsDheRsaWithAes256CbcSha256 = 107,
		TLS_DH_anon_WITH_RC4_128_MD5 = 24,
		TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
		TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
		TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
		TlsPskWithRc4128Sha = 138,
		TlsPskWith3desEdeCbcSha = 139,
		TlsPskWithAes128CbcSha = 140,
		TlsPskWithAes256CbcSha = 141,
		TlsDhePskWithRc4128Sha = 142,
		TlsDhePskWith3desEdeCbcSha = 143,
		TlsDhePskWithAes128CbcSha = 144,
		TlsDhePskWithAes256CbcSha = 145,
		TlsRsaPskWithRc4128Sha = 146,
		TlsRsaPskWith3desEdeCbcSha = 147,
		TlsRsaPskWithAes128CbcSha = 148,
		TlsRsaPskWithAes256CbcSha = 149,
		TlsPskWithNullSha = 44,
		TlsDhePskWithNullSha = 45,
		TlsRsaPskWithNullSha = 46,
		TlsRsaWithAes128GcmSha256 = 156,
		TlsRsaWithAes256GcmSha384 = 157,
		TlsDheRsaWithAes128GcmSha256 = 158,
		TlsDheRsaWithAes256GcmSha384 = 159,
		TlsDhRsaWithAes128GcmSha256 = 160,
		TlsDhRsaWithAes256GcmSha384 = 161,
		TlsDheDssWithAes128GcmSha256 = 162,
		TlsDheDssWithAes256GcmSha384 = 163,
		TlsDhDssWithAes128GcmSha256 = 164,
		TlsDhDssWithAes256GcmSha384 = 165,
		TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
		TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
		TlsPskWithAes128GcmSha256 = 168,
		TlsPskWithAes256GcmSha384 = 169,
		TlsDhePskWithAes128GcmSha256 = 170,
		TlsDhePskWithAes256GcmSha384 = 171,
		TlsRsaPskWithAes128GcmSha256 = 172,
		TlsRsaPskWithAes256GcmSha384 = 173,
		TlsPskWithAes128CbcSha256 = 174,
		TlsPskWithAes256CbcSha384 = 175,
		TlsPskWithNullSha256 = 176,
		TlsPskWithNullSha384 = 177,
		TlsDhePskWithAes128CbcSha256 = 178,
		TlsDhePskWithAes256CbcSha384 = 179,
		TlsDhePskWithNullSha256 = 180,
		TlsDhePskWithNullSha384 = 181,
		TlsRsaPskWithAes128CbcSha256 = 182,
		TlsRsaPskWithAes256CbcSha384 = 183,
		TlsRsaPskWithNullSha256 = 184,
		TlsRsaPskWithNullSha384 = 185,
		TlsAes128GcmSha256 = 4865,
		TlsAes256GcmSha384 = 4866,
		TlsChacha20Poly1305Sha256 = 4867,
		TlsAes128CcmSha256 = 4868,
		TlsAes128Ccm8Sha256 = 4869,
		TlsEcdheEcdsaWithAes128CbcSha256 = 49187,
		TlsEcdheEcdsaWithAes256CbcSha384 = 49188,
		TlsEcdhEcdsaWithAes128CbcSha256 = 49189,
		TlsEcdhEcdsaWithAes256CbcSha384 = 49190,
		TlsEcdheRsaWithAes128CbcSha256 = 49191,
		TlsEcdheRsaWithAes256CbcSha384 = 49192,
		TlsEcdhRsaWithAes128CbcSha256 = 49193,
		TlsEcdhRsaWithAes256CbcSha384 = 49194,
		TlsEcdheEcdsaWithAes128GcmSha256 = 49195,
		TlsEcdheEcdsaWithAes256GcmSha384 = 49196,
		TlsEcdhEcdsaWithAes128GcmSha256 = 49197,
		TlsEcdhEcdsaWithAes256GcmSha384 = 49198,
		TlsEcdheRsaWithAes128GcmSha256 = 49199,
		TlsEcdheRsaWithAes256GcmSha384 = 49200,
		TlsEcdhRsaWithAes128GcmSha256 = 49201,
		TlsEcdhRsaWithAes256GcmSha384 = 49202,
		TlsEcdheRsaWithChacha20Poly1305Sha256 = 52392,
		TlsEcdheEcdsaWithChacha20Poly1305Sha256 = 52393,
		TlsEmptyRenegotiationInfoScsv = 255,
		SslRsaWithRc2CbcMd5 = 65408,
		SslRsaWithIdeaCbcMd5 = 65409,
		SslRsaWithDesCbcMd5 = 65410,
		SslRsaWith3desEdeCbcMd5 = 65411,
		SslNoSuchCiphersuite = 65535
	}

	public enum SSLCiphersuiteGroup
	{
		Default,
		Compatibility,
		Legacy,
		Ats,
		ATSCompatibility
	}

	public enum tls_protocol_version_t : ushort
	{
		TLSv10 = 769,
		TLSv11 = 770,
		TLSv12 = 771,
		TLSv13 = 772,
		DTLSv10 = 65279,
		DTLSv12 = 65277
	}

	public enum tls_ciphersuite_t : ushort
	{
		RsaWith3desEdeCbcSha = 10,
		RsaWithAes128CbcSha = 47,
		RsaWithAes256CbcSha = 53,
		RsaWithAes128GcmSha256 = 156,
		RsaWithAes256GcmSha384 = 157,
		RsaWithAes128CbcSha256 = 60,
		RsaWithAes256CbcSha256 = 61,
		EcdheEcdsaWith3desEdeCbcSha = 49160,
		EcdheEcdsaWithAes128CbcSha = 49161,
		EcdheEcdsaWithAes256CbcSha = 49162,
		EcdheRsaWith3desEdeCbcSha = 49170,
		EcdheRsaWithAes128CbcSha = 49171,
		EcdheRsaWithAes256CbcSha = 49172,
		EcdheEcdsaWithAes128CbcSha256 = 49187,
		EcdheEcdsaWithAes256CbcSha384 = 49188,
		EcdheRsaWithAes128CbcSha256 = 49191,
		EcdheRsaWithAes256CbcSha384 = 49192,
		EcdheEcdsaWithAes128GcmSha256 = 49195,
		EcdheEcdsaWithAes256GcmSha384 = 49196,
		EcdheRsaWithAes128GcmSha256 = 49199,
		EcdheRsaWithAes256GcmSha384 = 49200,
		EcdheRsaWithChacha20Poly1305Sha256 = 52392,
		EcdheEcdsaWithChacha20Poly1305Sha256 = 52393,
		Aes128GcmSha256 = 4865,
		Aes256GcmSha384 = 4866,
		Chacha20Poly1305Sha256 = 4867
	}

	public enum tls_ciphersuite_group_t : ushort
	{
		@default,
		compatibility,
		legacy,
		ats,
		ats_compatibility
	}

	public enum SSLProtocol
	{
		SSLProtocolUnknown = 0,
		TLSProtocol1 = 4,
		TLSProtocol11 = 7,
		TLSProtocol12 = 8,
		DTLSProtocol1 = 9,
		TLSProtocol13 = 10,
		DTLSProtocol12 = 11,
		TLSProtocolMaxSupported = 999,
		SSLProtocol2 = 1,
		SSLProtocol3 = 2,
		SSLProtocol3Only = 3,
		TLSProtocol1Only = 5,
		SSLProtocolAll = 6
	}

	[Native]
	public enum NSURLCredentialPersistence : ulong
	{
		None,
		ForSession,
		Permanent,
		Synchronizable
	}

	public enum CFNetworkErrors
	{
		HostErrorHostNotFound = 1,
		HostErrorUnknown = 2,
		SOCKSErrorUnknownClientVersion = 100,
		SOCKSErrorUnsupportedServerVersion = 101,
		SOCKS4ErrorRequestFailed = 110,
		SOCKS4ErrorIdentdFailed = 111,
		SOCKS4ErrorIdConflict = 112,
		SOCKS4ErrorUnknownStatusCode = 113,
		SOCKS5ErrorBadState = 120,
		SOCKS5ErrorBadResponseAddr = 121,
		SOCKS5ErrorBadCredentials = 122,
		SOCKS5ErrorUnsupportedNegotiationMethod = 123,
		SOCKS5ErrorNoAcceptableMethod = 124,
		FTPErrorUnexpectedStatusCode = 200,
		ErrorHTTPAuthenticationTypeUnsupported = 300,
		ErrorHTTPBadCredentials = 301,
		ErrorHTTPConnectionLost = 302,
		ErrorHTTPParseFailure = 303,
		ErrorHTTPRedirectionLoopDetected = 304,
		ErrorHTTPBadURL = 305,
		ErrorHTTPProxyConnectionFailure = 306,
		ErrorHTTPBadProxyCredentials = 307,
		ErrorPACFileError = 308,
		ErrorPACFileAuth = 309,
		ErrorHTTPSProxyConnectionFailure = 310,
		StreamErrorHTTPSProxyFailureUnexpectedResponseToCONNECTMethod = 311,
		URLErrorBackgroundSessionInUseByAnotherProcess = -996,
		URLErrorBackgroundSessionWasDisconnected = -997,
		URLErrorUnknown = -998,
		URLErrorCancelled = -999,
		URLErrorBadURL = -1000,
		URLErrorTimedOut = -1001,
		URLErrorUnsupportedURL = -1002,
		URLErrorCannotFindHost = -1003,
		URLErrorCannotConnectToHost = -1004,
		URLErrorNetworkConnectionLost = -1005,
		URLErrorDNSLookupFailed = -1006,
		URLErrorHTTPTooManyRedirects = -1007,
		URLErrorResourceUnavailable = -1008,
		URLErrorNotConnectedToInternet = -1009,
		URLErrorRedirectToNonExistentLocation = -1010,
		URLErrorBadServerResponse = -1011,
		URLErrorUserCancelledAuthentication = -1012,
		URLErrorUserAuthenticationRequired = -1013,
		URLErrorZeroByteResource = -1014,
		URLErrorCannotDecodeRawData = -1015,
		URLErrorCannotDecodeContentData = -1016,
		URLErrorCannotParseResponse = -1017,
		URLErrorInternationalRoamingOff = -1018,
		URLErrorCallIsActive = -1019,
		URLErrorDataNotAllowed = -1020,
		URLErrorRequestBodyStreamExhausted = -1021,
		URLErrorAppTransportSecurityRequiresSecureConnection = -1022,
		URLErrorFileDoesNotExist = -1100,
		URLErrorFileIsDirectory = -1101,
		URLErrorNoPermissionsToReadFile = -1102,
		URLErrorDataLengthExceedsMaximum = -1103,
		URLErrorFileOutsideSafeArea = -1104,
		URLErrorSecureConnectionFailed = -1200,
		URLErrorServerCertificateHasBadDate = -1201,
		URLErrorServerCertificateUntrusted = -1202,
		URLErrorServerCertificateHasUnknownRoot = -1203,
		URLErrorServerCertificateNotYetValid = -1204,
		URLErrorClientCertificateRejected = -1205,
		URLErrorClientCertificateRequired = -1206,
		URLErrorCannotLoadFromNetwork = -2000,
		URLErrorCannotCreateFile = -3000,
		URLErrorCannotOpenFile = -3001,
		URLErrorCannotCloseFile = -3002,
		URLErrorCannotWriteToFile = -3003,
		URLErrorCannotRemoveFile = -3004,
		URLErrorCannotMoveFile = -3005,
		URLErrorDownloadDecodingFailedMidStream = -3006,
		URLErrorDownloadDecodingFailedToComplete = -3007,
		HTTPCookieCannotParseCookieFile = -4000,
		NetServiceErrorUnknown = -72000,
		NetServiceErrorCollision = -72001,
		NetServiceErrorNotFound = -72002,
		NetServiceErrorInProgress = -72003,
		NetServiceErrorBadArgument = -72004,
		NetServiceErrorCancel = -72005,
		NetServiceErrorInvalid = -72006,
		NetServiceErrorTimeout = -72007,
		NetServiceErrorDNSServiceFailure = -73000
	}

	public enum CFHostInfoType
	{
		Addresses = 0,
		Names = 1,
		Reachability = 2
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFHostClientContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe CFAllocatorRetainCallBack* retain;

		public unsafe CFAllocatorReleaseCallBack* release;

		public unsafe CFAllocatorCopyDescriptionCallBack* copyDescription;
	}

	public enum CFNetServicesError
	{
		Unknown = -72000,
		Collision = -72001,
		NotFound = -72002,
		InProgress = -72003,
		BadArgument = -72004,
		Cancel = -72005,
		Invalid = -72006,
		Timeout = -72007,
		MissingRequiredConfiguration = -72008
	}

	public enum CFNetServiceMonitorType
	{
		CFNetServiceMonitorTXT = 1
	}

	[Flags]
	[Native]
	public enum CFNetServiceRegisterFlags : ulong
	{
		CFNetServiceFlagNoAutoRename = 0x1
	}

	[Flags]
	[Native]
	public enum CFNetServiceBrowserFlags : ulong
	{
		MoreComing = 0x1,
		IsDomain = 0x2,
		IsDefault = 0x4,
		IsRegistrationDomain = 0x4,
		Remove = 0x8
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CFNetServiceClientContext
	{
		public nint version;

		public unsafe void* info;

		public unsafe CFAllocatorRetainCallBack* retain;

		public unsafe CFAllocatorReleaseCallBack* release;

		public unsafe CFAllocatorCopyDescriptionCallBack* copyDescription;
	}

	public enum kCFStreamErrorSOCKS : uint
	{
		SubDomainNone = 0,
		SubDomainVersionCode = 1,
		kCFStreamErrorSOCKS4SubDomainResponse = 2,
		kCFStreamErrorSOCKS5SubDomainUserPass = 3,
		kCFStreamErrorSOCKS5SubDomainMethod = 4,
		kCFStreamErrorSOCKS5SubDomainResponse = 5
	}

	public enum kCFStreamErrorSOCKS : uint
	{
		kCFStreamErrorSOCKS5BadResponseAddr = 1,
		kCFStreamErrorSOCKS5BadState = 2,
		UnknownClientVersion = 3
	}

	public enum kCFStreamErrorSOCKS4 : uint
	{
		RequestFailed = 91,
		IdentdFailed = 92,
		IdConflict = 93
	}

	public enum  : uint
	{
		SOCKS5NoAcceptableMethod = 255
	}

	public enum CFStreamErrorHTTP
	{
		ParseFailure = -1,
		RedirectionLoop = -2,
		BadURL = -3
	}

	public enum CFStreamErrorHTTPAuthentication
	{
		TypeUnsupported = -1000,
		BadUserName = -1001,
		BadPassword = -1002
	}

	[Introduced (PlatformName.iOS, 2, 0)]
	[Deprecated (PlatformName.iOS, 11, 0)]
	public enum CFNetDiagnosticStatusValues
	{
		NoErr = 0,
		Err = -66560,
		ConnectionUp = -66559,
		ConnectionIndeterminate = -66558,
		ConnectionDown = -66557
	}

	[Watch (2,0), TV (9,0), Mac (10,10), iOS (7,0)]
	[Native]
	public enum NSURLErrorCancelledReason : long
	{
		UserForceQuitApplication = 0,
		BackgroundUpdatesDisabled = 1,
		InsufficientSystemResources = 2
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSURLErrorNetworkUnavailableReason : long
	{
		Cellular = 0,
		Expensive = 1,
		Constrained = 2
	}

	[Native]
	public enum NSURLError : long
	{
		Unknown = -1,
		Cancelled = -999,
		BadURL = -1000,
		TimedOut = -1001,
		UnsupportedURL = -1002,
		CannotFindHost = -1003,
		CannotConnectToHost = -1004,
		NetworkConnectionLost = -1005,
		DNSLookupFailed = -1006,
		HTTPTooManyRedirects = -1007,
		ResourceUnavailable = -1008,
		NotConnectedToInternet = -1009,
		RedirectToNonExistentLocation = -1010,
		BadServerResponse = -1011,
		UserCancelledAuthentication = -1012,
		UserAuthenticationRequired = -1013,
		ZeroByteResource = -1014,
		CannotDecodeRawData = -1015,
		CannotDecodeContentData = -1016,
		CannotParseResponse = -1017,
		AppTransportSecurityRequiresSecureConnection = -1022,
		FileDoesNotExist = -1100,
		FileIsDirectory = -1101,
		NoPermissionsToReadFile = -1102,
		DataLengthExceedsMaximum = -1103,
		FileOutsideSafeArea = -1104,
		SecureConnectionFailed = -1200,
		ServerCertificateHasBadDate = -1201,
		ServerCertificateUntrusted = -1202,
		ServerCertificateHasUnknownRoot = -1203,
		ServerCertificateNotYetValid = -1204,
		ClientCertificateRejected = -1205,
		ClientCertificateRequired = -1206,
		CannotLoadFromNetwork = -2000,
		CannotCreateFile = -3000,
		CannotOpenFile = -3001,
		CannotCloseFile = -3002,
		CannotWriteToFile = -3003,
		CannotRemoveFile = -3004,
		CannotMoveFile = -3005,
		DownloadDecodingFailedMidStream = -3006,
		DownloadDecodingFailedToComplete = -3007,
		InternationalRoamingOff = -1018,
		CallIsActive = -1019,
		DataNotAllowed = -1020,
		RequestBodyStreamExhausted = -1021,
		BackgroundSessionRequiresSharedContainer = -995,
		BackgroundSessionInUseByAnotherProcess = -996,
		BackgroundSessionWasDisconnected = -997
	}

	[Native]
	public enum NSURLRequestCachePolicy : ulong
	{
		UseProtocolCachePolicy = 0,
		ReloadIgnoringLocalCacheData = 1,
		ReloadIgnoringLocalAndRemoteCacheData = 4,
		ReloadIgnoringCacheData = ReloadIgnoringLocalCacheData,
		ReturnCacheDataElseLoad = 2,
		ReturnCacheDataDontLoad = 3,
		ReloadRevalidatingCacheData = 5
	}

	[Native]
	public enum NSURLRequestNetworkServiceType : ulong
	{
		Default = 0,
		VoIP = 1,
		Video = 2,
		Background = 3,
		Voice = 4,
		ResponsiveData = 6,
		AVStreaming = 8,
		ResponsiveAV = 9,
		CallSignaling = 11
	}

	[Watch (8,0), TV (15,0), Mac (12,0), iOS (15,0)]
	[Native]
	public enum NSURLRequestAttribution : ulong
	{
		Developer = 0,
		User = 1
	}

	[Native]
	public enum NSXMLParserExternalEntityResolvingPolicy : ulong
	{
		Never = 0,
		NoNetwork,
		SameOriginOnly,
		Always
	}

	[Native]
	public enum NSXMLParserError : long
	{
		InternalError = 1,
		OutOfMemoryError = 2,
		DocumentStartError = 3,
		EmptyDocumentError = 4,
		PrematureDocumentEndError = 5,
		InvalidHexCharacterRefError = 6,
		InvalidDecimalCharacterRefError = 7,
		InvalidCharacterRefError = 8,
		InvalidCharacterError = 9,
		CharacterRefAtEOFError = 10,
		CharacterRefInPrologError = 11,
		CharacterRefInEpilogError = 12,
		CharacterRefInDTDError = 13,
		EntityRefAtEOFError = 14,
		EntityRefInPrologError = 15,
		EntityRefInEpilogError = 16,
		EntityRefInDTDError = 17,
		ParsedEntityRefAtEOFError = 18,
		ParsedEntityRefInPrologError = 19,
		ParsedEntityRefInEpilogError = 20,
		ParsedEntityRefInInternalSubsetError = 21,
		EntityReferenceWithoutNameError = 22,
		EntityReferenceMissingSemiError = 23,
		ParsedEntityRefNoNameError = 24,
		ParsedEntityRefMissingSemiError = 25,
		UndeclaredEntityError = 26,
		UnparsedEntityError = 28,
		EntityIsExternalError = 29,
		EntityIsParameterError = 30,
		UnknownEncodingError = 31,
		EncodingNotSupportedError = 32,
		StringNotStartedError = 33,
		StringNotClosedError = 34,
		NamespaceDeclarationError = 35,
		EntityNotStartedError = 36,
		EntityNotFinishedError = 37,
		LessThanSymbolInAttributeError = 38,
		AttributeNotStartedError = 39,
		AttributeNotFinishedError = 40,
		AttributeHasNoValueError = 41,
		AttributeRedefinedError = 42,
		LiteralNotStartedError = 43,
		LiteralNotFinishedError = 44,
		CommentNotFinishedError = 45,
		ProcessingInstructionNotStartedError = 46,
		ProcessingInstructionNotFinishedError = 47,
		NotationNotStartedError = 48,
		NotationNotFinishedError = 49,
		AttributeListNotStartedError = 50,
		AttributeListNotFinishedError = 51,
		MixedContentDeclNotStartedError = 52,
		MixedContentDeclNotFinishedError = 53,
		ElementContentDeclNotStartedError = 54,
		ElementContentDeclNotFinishedError = 55,
		XMLDeclNotStartedError = 56,
		XMLDeclNotFinishedError = 57,
		ConditionalSectionNotStartedError = 58,
		ConditionalSectionNotFinishedError = 59,
		ExternalSubsetNotFinishedError = 60,
		DOCTYPEDeclNotFinishedError = 61,
		MisplacedCDATAEndStringError = 62,
		CDATANotFinishedError = 63,
		MisplacedXMLDeclarationError = 64,
		SpaceRequiredError = 65,
		SeparatorRequiredError = 66,
		NMTOKENRequiredError = 67,
		NAMERequiredError = 68,
		PCDATARequiredError = 69,
		URIRequiredError = 70,
		PublicIdentifierRequiredError = 71,
		LTRequiredError = 72,
		GTRequiredError = 73,
		LTSlashRequiredError = 74,
		EqualExpectedError = 75,
		TagNameMismatchError = 76,
		UnfinishedTagError = 77,
		StandaloneValueError = 78,
		InvalidEncodingNameError = 79,
		CommentContainsDoubleHyphenError = 80,
		InvalidEncodingError = 81,
		ExternalStandaloneEntityError = 82,
		InvalidConditionalSectionError = 83,
		EntityValueRequiredError = 84,
		NotWellBalancedError = 85,
		ExtraContentError = 86,
		InvalidCharacterInEntityError = 87,
		ParsedEntityRefInInternalError = 88,
		EntityRefLoopError = 89,
		EntityBoundaryError = 90,
		InvalidURIError = 91,
		URIFragmentError = 92,
		NoDTDError = 94,
		DelegateAbortedParseError = 512
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_tid_t
	{
		public int port;

		public uint machine;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_tid_addr_t
	{
		public int at_port;

		public uint at_type;

		public uint[] at_addr;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_mask_t
	{
		public uint am_success;

		public uint am_failure;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct auditinfo_t
	{
		public uint ai_auid;

		public au_mask_t ai_mask;

		public au_tid_t ai_termid;

		public int ai_asid;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct auditinfo_addr_t
	{
		public uint ai_auid;

		public au_mask_t ai_mask;

		public au_tid_addr_t ai_termid;

		public int ai_asid;

		public ulong ai_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct auditpinfo_t
	{
		public int ap_pid;

		public uint ap_auid;

		public au_mask_t ap_mask;

		public au_tid_t ap_termid;

		public int ap_asid;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct auditpinfo_addr_t
	{
		public int ap_pid;

		public uint ap_auid;

		public au_mask_t ap_mask;

		public au_tid_addr_t ap_termid;

		public int ap_asid;

		public ulong ap_flags;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_session_t
	{
		public unsafe auditinfo_addr_t* as_aia_p;

		public au_mask_t as_mask;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_expire_after_t
	{
		public nint age;

		public nuint size;

		public byte op_type;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_qctrl_t
	{
		public int aq_hiwater;

		public int aq_lowater;

		public int aq_bufsz;

		public int aq_delay;

		public int aq_minfree;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_stat_t
	{
		public uint as_version;

		public uint as_numevent;

		public int as_generated;

		public int as_nonattrib;

		public int as_kernel;

		public int as_audit;

		public int as_auditctl;

		public int as_enqueue;

		public int as_written;

		public int as_wblocked;

		public int as_rblocked;

		public int as_dropped;

		public int as_totalsize;

		public uint as_memused;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_fstat_t
	{
		public ulong af_filesz;

		public ulong af_currsz;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct au_evclass_map_t
	{
		public ushort ec_number;

		public uint ec_class;
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x8), iOS (0x6,0x0)]
	[Native]
	public enum NSXPCConnectionOptions : ulong
	{
		NSXPCConnectionPrivileged = (1uL << 12)
	}

	[Native]
	public enum Ns : long
	{
		FileNoSuchFileError = 4,
		FileLockingError = 255,
		FileReadUnknownError = 256,
		FileReadNoPermissionError = 257,
		FileReadInvalidFileNameError = 258,
		FileReadCorruptFileError = 259,
		FileReadNoSuchFileError = 260,
		FileReadInapplicableStringEncodingError = 261,
		FileReadUnsupportedSchemeError = 262,
		FileReadTooLargeError = 263,
		FileReadUnknownStringEncodingError = 264,
		FileWriteUnknownError = 512,
		FileWriteNoPermissionError = 513,
		FileWriteInvalidFileNameError = 514,
		FileWriteFileExistsError = 516,
		FileWriteInapplicableStringEncodingError = 517,
		FileWriteUnsupportedSchemeError = 518,
		FileWriteOutOfSpaceError = 640,
		FileWriteVolumeReadOnlyError = 642,
		FileManagerUnmountUnknownError = 768,
		FileManagerUnmountBusyError = 769,
		KeyValueValidationError = 1024,
		FormattingError = 2048,
		UserCancelledError = 3072,
		FeatureUnsupportedError = 3328,
		ExecutableNotLoadableError = 3584,
		ExecutableArchitectureMismatchError = 3585,
		ExecutableRuntimeMismatchError = 3586,
		ExecutableLoadError = 3587,
		ExecutableLinkError = 3588,
		FileErrorMinimum = 0,
		FileErrorMaximum = 1023,
		ValidationErrorMinimum = 1024,
		ValidationErrorMaximum = 2047,
		ExecutableErrorMinimum = 3584,
		ExecutableErrorMaximum = 3839,
		FormattingErrorMinimum = 2048,
		FormattingErrorMaximum = 2559,
		PropertyListReadCorruptError = 3840,
		PropertyListReadUnknownVersionError = 3841,
		PropertyListReadStreamError = 3842,
		PropertyListWriteStreamError = 3851,
		PropertyListWriteInvalidError = 3852,
		PropertyListErrorMinimum = 3840,
		PropertyListErrorMaximum = 4095,
		XPCConnectionInterrupted = 4097,
		XPCConnectionInvalid = 4099,
		XPCConnectionReplyInvalid = 4101,
		XPCConnectionCodeSigningRequirementFailure = 4102,
		XPCConnectionErrorMinimum = 4096,
		XPCConnectionErrorMaximum = 4224,
		UbiquitousFileUnavailableError = 4353,
		UbiquitousFileNotUploadedDueToQuotaError = 4354,
		UbiquitousFileUbiquityServerNotAvailable = 4355,
		UbiquitousFileErrorMinimum = 4352,
		UbiquitousFileErrorMaximum = 4607,
		UserActivityHandoffFailedError = 4608,
		UserActivityConnectionUnavailableError = 4609,
		UserActivityRemoteApplicationTimedOutError = 4610,
		UserActivityHandoffUserInfoTooLargeError = 4611,
		UserActivityErrorMinimum = 4608,
		UserActivityErrorMaximum = 4863,
		CoderReadCorruptError = 4864,
		CoderValueNotFoundError = 4865,
		CoderInvalidValueError = 4866,
		CoderErrorMinimum = 4864,
		CoderErrorMaximum = 4991,
		BundleErrorMinimum = 4992,
		BundleErrorMaximum = 5119,
		BundleOnDemandResourceOutOfSpaceError = 4992,
		BundleOnDemandResourceExceededMaximumSizeError = 4993,
		BundleOnDemandResourceInvalidTagError = 4994,
		CloudSharingNetworkFailureError = 5120,
		CloudSharingQuotaExceededError = 5121,
		CloudSharingTooManyParticipantsError = 5122,
		CloudSharingConflictError = 5123,
		CloudSharingNoPermissionError = 5124,
		CloudSharingOtherError = 5375,
		CloudSharingErrorMinimum = 5120,
		CloudSharingErrorMaximum = 5375,
		CompressionFailedError = 5376,
		DecompressionFailedError = 5377,
		CompressionErrorMinimum = 5376,
		CompressionErrorMaximum = 5503
	}

	[Flags]
	[Native]
	public enum NSByteCountFormatterUnits : ulong
	{
		Default = 0x0,
		Bytes = 1uL << 0,
		Kb = 1uL << 1,
		Mb = 1uL << 2,
		Gb = 1uL << 3,
		Tb = 1uL << 4,
		Pb = 1uL << 5,
		Eb = 1uL << 6,
		Zb = 1uL << 7,
		YBOrHigher = 255uL << 8,
		All = 0xffff
	}

	[Native]
	public enum NSByteCountFormatterCountStyle : long
	{
		File = 0,
		Memory = 1,
		Decimal = 2,
		Binary = 3
	}

	[Flags]
	[Native]
	public enum NSComparisonPredicateOptions : ulong
	{
		CaseInsensitivePredicateOption = 0x1,
		DiacriticInsensitivePredicateOption = 0x2,
		NormalizedPredicateOption = 0x4
	}

	[Native]
	public enum NSComparisonPredicateModifier : ulong
	{
		DirectPredicateModifier = 0,
		AllPredicateModifier,
		AnyPredicateModifier
	}

	[Native]
	public enum NSPredicateOperatorType : ulong
	{
		LessThanPredicateOperatorType = 0,
		LessThanOrEqualToPredicateOperatorType,
		GreaterThanPredicateOperatorType,
		GreaterThanOrEqualToPredicateOperatorType,
		EqualToPredicateOperatorType,
		NotEqualToPredicateOperatorType,
		MatchesPredicateOperatorType,
		LikePredicateOperatorType,
		BeginsWithPredicateOperatorType,
		EndsWithPredicateOperatorType,
		InPredicateOperatorType,
		CustomSelectorPredicateOperatorType,
		ContainsPredicateOperatorType = 99,
		BetweenPredicateOperatorType
	}

	[Native]
	public enum NSCompoundPredicateType : ulong
	{
		NotPredicateType = 0,
		AndPredicateType,
		OrPredicateType
	}

	[Native]
	public enum NSDateComponentsFormatterUnitsStyle : long
	{
		Positional = 0,
		Abbreviated,
		Short,
		Full,
		SpellOut,
		Brief
	}

	[Flags]
	[Native]
	public enum NSDateComponentsFormatterZeroFormattingBehavior : ulong
	{
		None = (0x0),
		Default = (1uL << 0),
		DropLeading = (1uL << 1),
		DropMiddle = (1uL << 2),
		DropTrailing = (1uL << 3),
		DropAll = (DropLeading | DropMiddle | DropTrailing),
		Pad = (1uL << 16)
	}

	[Native]
	public enum NSExpressionType : ulong
	{
		ConstantValueExpressionType = 0,
		EvaluatedObjectExpressionType,
		VariableExpressionType,
		KeyPathExpressionType,
		FunctionExpressionType,
		UnionSetExpressionType,
		IntersectSetExpressionType,
		MinusSetExpressionType,
		SubqueryExpressionType = 13,
		AggregateExpressionType = 14,
		AnyKeyExpressionType = 15,
		BlockExpressionType = 19,
		ConditionalExpressionType = 20
	}

	[Flags]
	[Native]
	public enum NSFileCoordinatorReadingOptions : ulong
	{
		WithoutChanges = 1uL << 0,
		ResolvesSymbolicLink = 1uL << 1,
		ImmediatelyAvailableMetadataOnly = 1uL << 2,
		ForUploading = 1uL << 3
	}

	[Flags]
	[Native]
	public enum NSFileCoordinatorWritingOptions : ulong
	{
		ForDeleting = 1uL << 0,
		ForMoving = 1uL << 1,
		ForMerging = 1uL << 2,
		ForReplacing = 1uL << 3,
		ContentIndependentMetadataOnly = 1uL << 4
	}

	[Flags]
	[Native]
	public enum NSFileVersionAddingOptions : ulong
	{
		NSFileVersionAddingByMoving = 1uL << 0
	}

	[Flags]
	[Native]
	public enum NSFileVersionReplacingOptions : ulong
	{
		NSFileVersionReplacingByMoving = 1uL << 0
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSFileWrapperReadingOptions : ulong
	{
		Immediate = 1uL << 0,
		WithoutMapping = 1uL << 1
	}

	[Watch (0x2,0x0), TV (0x9,0x0), Flags, Mac (0xa,0x6), iOS (0x4,0x0)]
	[Native]
	public enum NSFileWrapperWritingOptions : ulong
	{
		Atomic = 1uL << 0,
		WithNameUpdating = 1uL << 1
	}

	[Native]
	public enum NSLinguisticTaggerUnit : long
	{
		Word,
		Sentence,
		Paragraph,
		Document
	}

	[Flags]
	[Native]
	public enum NSLinguisticTaggerOptions : ulong
	{
		OmitWords = 1uL << 0,
		OmitPunctuation = 1uL << 1,
		OmitWhitespace = 1uL << 2,
		OmitOther = 1uL << 3,
		JoinNames = 1uL << 4
	}

	[Native]
	public enum NSNetServicesError : long
	{
		UnknownError = -72000,
		CollisionError = -72001,
		NotFoundError = -72002,
		ActivityInProgress = -72003,
		BadArgumentError = -72004,
		CancelledError = -72005,
		InvalidError = -72006,
		TimeoutError = -72007,
		MissingRequiredConfigurationError = -72008
	}

	[Flags]
	[Native]
	public enum NSNetServiceOptions : ulong
	{
		NoAutoRename = 1uL << 0,
		ListenForConnections = 1uL << 1
	}

	[Native]
	public enum NSUbiquitousKeyValueStore : long
	{
		ServerChange,
		InitialSyncChange,
		QuotaViolationChange,
		AccountChange
	}

	public enum SSLSessionOption
	{
		BreakOnServerAuth = 0,
		BreakOnCertRequested = 1,
		BreakOnClientAuth = 2,
		FalseStart = 3,
		SendOneByteRecord = 4,
		AllowServerIdentityChange = 5,
		Fallback = 6,
		BreakOnClientHello = 7,
		AllowRenegotiation = 8,
		EnableSessionTickets = 9
	}

	public enum SSLSessionState
	{
		Idle,
		Handshake,
		Connected,
		Closed,
		Aborted
	}

	public enum SSLClientCertificateState
	{
		None,
		Requested,
		Sent,
		Rejected
	}

	public enum SSLProtocolSide
	{
		ServerSide,
		ClientSide
	}

	public enum SSLConnectionType
	{
		StreamType,
		DatagramType
	}

	public enum SSLAuthenticate
	{
		NeverAuthenticate,
		AlwaysAuthenticate,
		TryAuthenticate
	}

	[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
	[Native]
	public enum NSURLSessionTaskState : long
	{
		Running = 0,
		Suspended = 1,
		Canceling = 2,
		Completed = 3
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSURLSessionWebSocketMessageType : long
	{
		Data = 0,
		String = 1
	}

	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[Native]
	public enum NSURLSessionWebSocketCloseCode : long
	{
		Invalid = 0,
		NormalClosure = 1000,
		GoingAway = 1001,
		ProtocolError = 1002,
		UnsupportedData = 1003,
		NoStatusReceived = 1005,
		AbnormalClosure = 1006,
		InvalidFramePayloadData = 1007,
		PolicyViolation = 1008,
		MessageTooBig = 1009,
		MandatoryExtensionMissing = 1010,
		InternalServerError = 1011,
		TLSHandshakeFailure = 1015
	}

	[NoWatch, NoTV, NoMac, iOS (11,0)]
	[Native]
	public enum NSURLSessionMultipathServiceType : long
	{
		None = 0,
		Handover = 1,
		Interactive = 2,
		Aggregate = 3
	}

	[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
	[Native]
	public enum NSURLSessionDelayedRequestDisposition : long
	{
		ContinueLoading = 0,
		UseNewRequest = 1,
		Cancel = 2
	}

	[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
	[Native]
	public enum NSURLSessionAuthChallengeDisposition : long
	{
		UseCredential = 0,
		PerformDefaultHandling = 1,
		CancelAuthenticationChallenge = 2,
		RejectProtectionSpace = 3
	}

	[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
	[Native]
	public enum NSURLSessionResponseDisposition : long
	{
		Cancel = 0,
		Allow = 1,
		BecomeDownload = 2,
		BecomeStream = 3
	}

	[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
	[Native]
	public enum NSURLSessionTaskMetricsResourceFetchType : long
	{
		Unknown,
		NetworkLoad,
		ServerPush,
		LocalCache
	}

	[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
	[Native]
	public enum NSURLSessionTaskMetricsDomainResolutionProtocol : long
	{
		Unknown,
		Udp,
		Tcp,
		Tls,
		Https
	}
}
