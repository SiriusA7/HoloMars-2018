//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace MixedRealityToolkit.Sharing {

public class SessionManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SessionManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SessionManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SessionManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_SessionManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void AddListener(SessionManagerListener newListener) {
    SharingClientPINVOKE.SessionManager_AddListener(swigCPtr, SessionManagerListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(SessionManagerListener oldListener) {
    SharingClientPINVOKE.SessionManager_RemoveListener(swigCPtr, SessionManagerListener.getCPtr(oldListener));
  }

  public virtual bool CreateSession(XString sessionName) {
    bool ret = SharingClientPINVOKE.SessionManager_CreateSession__SWIG_0(swigCPtr, XString.getCPtr(sessionName));
    return ret;
  }

  public virtual bool CreateSession(XString sessionName, SessionType type) {
    bool ret = SharingClientPINVOKE.SessionManager_CreateSession__SWIG_1(swigCPtr, XString.getCPtr(sessionName), (int)type);
    return ret;
  }

  public virtual int GetSessionCount() {
    int ret = SharingClientPINVOKE.SessionManager_GetSessionCount(swigCPtr);
    return ret;
  }

  public virtual Session GetSession(int index) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.SessionManager_GetSession(swigCPtr, index);
    Session ret = (cPtr == global::System.IntPtr.Zero) ? null : new Session(cPtr, true);
    return ret; 
  }

  public virtual Session GetCurrentSession() {
    global::System.IntPtr cPtr = SharingClientPINVOKE.SessionManager_GetCurrentSession(swigCPtr);
    Session ret = (cPtr == global::System.IntPtr.Zero) ? null : new Session(cPtr, true);
    return ret; 
  }

  public virtual User GetCurrentUser() {
    global::System.IntPtr cPtr = SharingClientPINVOKE.SessionManager_GetCurrentUser(swigCPtr);
    User ret = (cPtr == global::System.IntPtr.Zero) ? null : new User(cPtr, true);
    return ret; 
  }

  public virtual bool IsServerConnected() {
    bool ret = SharingClientPINVOKE.SessionManager_IsServerConnected(swigCPtr);
    return ret;
  }

}

}
