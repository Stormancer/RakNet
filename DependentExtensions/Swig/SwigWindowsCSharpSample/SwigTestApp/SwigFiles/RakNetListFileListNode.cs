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

public class RakNetListFileListNode : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListFileListNode(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetListFileListNode obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListFileListNode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakNetListFileListNode(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    public FileListNode this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListFileListNode() : this(RakNetPINVOKE.new_RakNetListFileListNode__SWIG_0(), true) {
  }

  public RakNetListFileListNode(RakNetListFileListNode original_copy) : this(RakNetPINVOKE.new_RakNetListFileListNode__SWIG_1(RakNetListFileListNode.getCPtr(original_copy)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListFileListNode CopyData(RakNetListFileListNode original_copy) {
    RakNetListFileListNode ret = new RakNetListFileListNode(RakNetPINVOKE.RakNetListFileListNode_CopyData(swigCPtr, RakNetListFileListNode.getCPtr(original_copy)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FileListNode Get(uint position) {
    FileListNode ret = new FileListNode(RakNetPINVOKE.RakNetListFileListNode_Get(swigCPtr, position), false);
    return ret;
  }

  public void Push(FileListNode input, string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Push(swigCPtr, FileListNode.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public FileListNode Pop() {
    FileListNode ret = new FileListNode(RakNetPINVOKE.RakNetListFileListNode_Pop(swigCPtr), false);
    return ret;
  }

  public void Insert(FileListNode input, uint position, string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Insert__SWIG_0(swigCPtr, FileListNode.getCPtr(input), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(FileListNode input, string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Insert__SWIG_1(swigCPtr, FileListNode.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(FileListNode input, FileListNode filler, uint position, string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Replace__SWIG_0(swigCPtr, FileListNode.getCPtr(input), FileListNode.getCPtr(filler), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(FileListNode input) {
    RakNetPINVOKE.RakNetListFileListNode_Replace__SWIG_1(swigCPtr, FileListNode.getCPtr(input));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAtIndex(uint position) {
    RakNetPINVOKE.RakNetListFileListNode_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    RakNetPINVOKE.RakNetListFileListNode_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    RakNetPINVOKE.RakNetListFileListNode_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    RakNetPINVOKE.RakNetListFileListNode_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint Size() {
    uint ret = RakNetPINVOKE.RakNetListFileListNode_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    RakNetPINVOKE.RakNetListFileListNode_Compress(swigCPtr, file, line);
  }

}

}
