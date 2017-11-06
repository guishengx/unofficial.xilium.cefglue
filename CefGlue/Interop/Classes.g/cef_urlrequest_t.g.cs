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
    internal unsafe struct cef_urlrequest_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _get_request;
        internal IntPtr _get_client;
        internal IntPtr _get_request_status;
        internal IntPtr _get_request_error;
        internal IntPtr _get_response;
        internal IntPtr _cancel;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_urlrequest_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_urlrequest_t* create(cef_request_t* request, cef_urlrequest_client_t* client, cef_request_context_t* request_context);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_request_t* get_request_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_urlrequest_client_t* get_client_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefUrlRequestStatus get_request_status_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefErrorCode get_request_error_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_response_t* get_response_delegate(cef_urlrequest_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void cancel_delegate(cef_urlrequest_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_urlrequest_t* self)
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
        
        public static int release(cef_urlrequest_t* self)
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
        
        public static int has_one_ref(cef_urlrequest_t* self)
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
        
        // GetRequest
        private static IntPtr _p3;
        private static get_request_delegate _d3;
        
        public static cef_request_t* get_request(cef_urlrequest_t* self)
        {
            get_request_delegate d;
            var p = self->_get_request;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (get_request_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_request_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetClient
        private static IntPtr _p4;
        private static get_client_delegate _d4;
        
        public static cef_urlrequest_client_t* get_client(cef_urlrequest_t* self)
        {
            get_client_delegate d;
            var p = self->_get_client;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_client_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_client_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // GetRequestStatus
        private static IntPtr _p5;
        private static get_request_status_delegate _d5;
        
        public static CefUrlRequestStatus get_request_status(cef_urlrequest_t* self)
        {
            get_request_status_delegate d;
            var p = self->_get_request_status;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (get_request_status_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_request_status_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetRequestError
        private static IntPtr _p6;
        private static get_request_error_delegate _d6;
        
        public static CefErrorCode get_request_error(cef_urlrequest_t* self)
        {
            get_request_error_delegate d;
            var p = self->_get_request_error;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_request_error_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_request_error_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetResponse
        private static IntPtr _p7;
        private static get_response_delegate _d7;
        
        public static cef_response_t* get_response(cef_urlrequest_t* self)
        {
            get_response_delegate d;
            var p = self->_get_response;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_response_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_response_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // Cancel
        private static IntPtr _p8;
        private static cancel_delegate _d8;
        
        public static void cancel(cef_urlrequest_t* self)
        {
            cancel_delegate d;
            var p = self->_cancel;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (cancel_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(cancel_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            d(self);
        }
        
    }
}
