/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class NatPunchthroughDebugInterface : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NatPunchthroughDebugInterface(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NatPunchthroughDebugInterface obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatPunchthroughDebugInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NatPunchthroughDebugInterface(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public NatPunchthroughDebugInterface() : this(RakNetPINVOKE.new_NatPunchthroughDebugInterface(), true) {
    SwigDirectorConnect();
  }

  public virtual void OnClientMessage(string msg) {
    RakNetPINVOKE.NatPunchthroughDebugInterface_OnClientMessage(swigCPtr, msg);
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnClientMessage", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateNatPunchthroughDebugInterface_0(SwigDirectorOnClientMessage);
    RakNetPINVOKE.NatPunchthroughDebugInterface_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(NatPunchthroughDebugInterface));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnClientMessage(string msg) {
    OnClientMessage(msg);
  }

  public delegate void SwigDelegateNatPunchthroughDebugInterface_0(string msg);

  private SwigDelegateNatPunchthroughDebugInterface_0 swigDelegate0;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(string) };
}

}
