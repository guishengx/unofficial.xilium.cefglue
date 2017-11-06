//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_navigation_entry_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _is_valid;
        internal IntPtr _get_url;
        internal IntPtr _get_display_url;
        internal IntPtr _get_original_url;
        internal IntPtr _get_title;
        internal IntPtr _get_transition_type;
        internal IntPtr _has_post_data;
        internal IntPtr _get_completion_time;
        internal IntPtr _get_http_status_code;
        internal IntPtr _get_sslstatus;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_valid_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_url_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_display_url_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_original_url_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_title_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefTransitionType get_transition_type_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_post_data_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_time_t get_completion_time_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_http_status_code_delegate(cef_navigation_entry_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_sslstatus_t* get_sslstatus_delegate(cef_navigation_entry_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_navigation_entry_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_navigation_entry_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_navigation_entry_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // IsValid
        private static IntPtr _p3;
        private static is_valid_delegate _d3;
        
        public static int is_valid(cef_navigation_entry_t* self)
        {
            is_valid_delegate d;
            var p = self->_is_valid;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_valid_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_valid_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetURL
        private static IntPtr _p4;
        private static get_url_delegate _d4;
        
        public static cef_string_userfree* get_url(cef_navigation_entry_t* self)
        {
            get_url_delegate d;
            var p = self->_get_url;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_url_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // GetDisplayURL
        private static IntPtr _p5;
        private static get_display_url_delegate _d5;
        
        public static cef_string_userfree* get_display_url(cef_navigation_entry_t* self)
        {
            get_display_url_delegate d;
            var p = self->_get_display_url;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (get_display_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_display_url_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetOriginalURL
        private static IntPtr _p6;
        private static get_original_url_delegate _d6;
        
        public static cef_string_userfree* get_original_url(cef_navigation_entry_t* self)
        {
            get_original_url_delegate d;
            var p = self->_get_original_url;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_original_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_original_url_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetTitle
        private static IntPtr _p7;
        private static get_title_delegate _d7;
        
        public static cef_string_userfree* get_title(cef_navigation_entry_t* self)
        {
            get_title_delegate d;
            var p = self->_get_title;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_title_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_title_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetTransitionType
        private static IntPtr _p8;
        private static get_transition_type_delegate _d8;
        
        public static CefTransitionType get_transition_type(cef_navigation_entry_t* self)
        {
            get_transition_type_delegate d;
            var p = self->_get_transition_type;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_transition_type_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_transition_type_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // HasPostData
        private static IntPtr _p9;
        private static has_post_data_delegate _d9;
        
        public static int has_post_data(cef_navigation_entry_t* self)
        {
            has_post_data_delegate d;
            var p = self->_has_post_data;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (has_post_data_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_post_data_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // GetCompletionTime
        private static IntPtr _pa;
        private static get_completion_time_delegate _da;
        
        public static cef_time_t get_completion_time(cef_navigation_entry_t* self)
        {
            get_completion_time_delegate d;
            var p = self->_get_completion_time;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_completion_time_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_completion_time_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self);
        }
        
        // GetHttpStatusCode
        private static IntPtr _pb;
        private static get_http_status_code_delegate _db;
        
        public static int get_http_status_code(cef_navigation_entry_t* self)
        {
            get_http_status_code_delegate d;
            var p = self->_get_http_status_code;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_http_status_code_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_http_status_code_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // GetSSLStatus
        private static IntPtr _pc;
        private static get_sslstatus_delegate _dc;
        
        public static cef_sslstatus_t* get_sslstatus(cef_navigation_entry_t* self)
        {
            get_sslstatus_delegate d;
            var p = self->_get_sslstatus;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (get_sslstatus_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_sslstatus_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            return d(self);
        }
        
    }
}
