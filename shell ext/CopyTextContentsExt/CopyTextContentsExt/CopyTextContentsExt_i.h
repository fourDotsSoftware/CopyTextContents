

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0500 */
/* at Fri Apr 20 13:09:53 2012
 */
/* Compiler settings for .\CopyTextContentsExt.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __CopyTextContentsExt_i_h__
#define __CopyTextContentsExt_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __ICopyTextContentsShellExt_FWD_DEFINED__
#define __ICopyTextContentsShellExt_FWD_DEFINED__
typedef interface ICopyTextContentsShellExt ICopyTextContentsShellExt;
#endif 	/* __ICopyTextContentsShellExt_FWD_DEFINED__ */


#ifndef __CopyTextContentsShellExt_FWD_DEFINED__
#define __CopyTextContentsShellExt_FWD_DEFINED__

#ifdef __cplusplus
typedef class CopyTextContentsShellExt CopyTextContentsShellExt;
#else
typedef struct CopyTextContentsShellExt CopyTextContentsShellExt;
#endif /* __cplusplus */

#endif 	/* __CopyTextContentsShellExt_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __ICopyTextContentsShellExt_INTERFACE_DEFINED__
#define __ICopyTextContentsShellExt_INTERFACE_DEFINED__

/* interface ICopyTextContentsShellExt */
/* [unique][helpstring][uuid][object] */ 


EXTERN_C const IID IID_ICopyTextContentsShellExt;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("B6464AA1-28BB-42a9-B67B-59A8E5AE27C0")
    ICopyTextContentsShellExt : public IUnknown
    {
    public:
    };
    
#else 	/* C style interface */

    typedef struct ICopyTextContentsShellExtVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            ICopyTextContentsShellExt * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            ICopyTextContentsShellExt * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            ICopyTextContentsShellExt * This);
        
        END_INTERFACE
    } ICopyTextContentsShellExtVtbl;

    interface ICopyTextContentsShellExt
    {
        CONST_VTBL struct ICopyTextContentsShellExtVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define ICopyTextContentsShellExt_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define ICopyTextContentsShellExt_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define ICopyTextContentsShellExt_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __ICopyTextContentsShellExt_INTERFACE_DEFINED__ */



#ifndef __CopyTextContentsExtLib_LIBRARY_DEFINED__
#define __CopyTextContentsExtLib_LIBRARY_DEFINED__

/* library CopyTextContentsExtLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_CopyTextContentsExtLib;

EXTERN_C const CLSID CLSID_CopyTextContentsShellExt;

#ifdef __cplusplus

class DECLSPEC_UUID("AA6347ED-CD79-40f0-88EB-BA54125B9E81")
CopyTextContentsShellExt;
#endif
#endif /* __CopyTextContentsExtLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


