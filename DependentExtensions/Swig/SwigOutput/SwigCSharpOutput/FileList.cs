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

public class FileList : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileList(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FileList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FileList(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static FileList GetInstance() {
    IntPtr cPtr = RakNetPINVOKE.FileList_GetInstance();
    FileList ret = (cPtr == IntPtr.Zero) ? null : new FileList(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(FileList i) {
    RakNetPINVOKE.FileList_DestroyInstance(FileList.getCPtr(i));
  }

  public FileList() : this(RakNetPINVOKE.new_FileList(), true) {
  }

  public void AddFilesFromDirectory(string applicationDirectory, string subDirectory, bool writeHash, bool writeData, bool recursive, FileListNodeContext context) {
    RakNetPINVOKE.FileList_AddFilesFromDirectory(swigCPtr, applicationDirectory, subDirectory, writeHash, writeData, recursive, FileListNodeContext.getCPtr(context));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    RakNetPINVOKE.FileList_Clear(swigCPtr);
  }

  public void Serialize(BitStream outBitStream) {
    RakNetPINVOKE.FileList_Serialize(swigCPtr, BitStream.getCPtr(outBitStream));
  }

  public bool Deserialize(BitStream inBitStream) {
    bool ret = RakNetPINVOKE.FileList_Deserialize(swigCPtr, BitStream.getCPtr(inBitStream));
    return ret;
  }

  public void ListMissingOrChangedFiles(string applicationDirectory, FileList missingOrChangedFiles, bool alwaysWriteHash, bool neverWriteHash) {
    RakNetPINVOKE.FileList_ListMissingOrChangedFiles(swigCPtr, applicationDirectory, FileList.getCPtr(missingOrChangedFiles), alwaysWriteHash, neverWriteHash);
  }

  public void GetDeltaToCurrent(FileList input, FileList output, string dirSubset, string remoteSubdir) {
    RakNetPINVOKE.FileList_GetDeltaToCurrent(swigCPtr, FileList.getCPtr(input), FileList.getCPtr(output), dirSubset, remoteSubdir);
  }

  public void PopulateDataFromDisk(string applicationDirectory, bool writeFileData, bool writeFileHash, bool removeUnknownFiles) {
    RakNetPINVOKE.FileList_PopulateDataFromDisk(swigCPtr, applicationDirectory, writeFileData, writeFileHash, removeUnknownFiles);
  }

  public void FlagFilesAsReferences() {
    RakNetPINVOKE.FileList_FlagFilesAsReferences(swigCPtr);
  }

  public void WriteDataToDisk(string applicationDirectory) {
    RakNetPINVOKE.FileList_WriteDataToDisk(swigCPtr, applicationDirectory);
  }

  public void AddFile(string filepath, string filename, FileListNodeContext context) {
    RakNetPINVOKE.FileList_AddFile__SWIG_0(swigCPtr, filepath, filename, FileListNodeContext.getCPtr(context));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DeleteFiles(string applicationDirectory) {
    RakNetPINVOKE.FileList_DeleteFiles(swigCPtr, applicationDirectory);
  }

  public void AddCallback(FileListProgress cb) {
    RakNetPINVOKE.FileList_AddCallback(swigCPtr, FileListProgress.getCPtr(cb));
  }

  public void RemoveCallback(FileListProgress cb) {
    RakNetPINVOKE.FileList_RemoveCallback(swigCPtr, FileListProgress.getCPtr(cb));
  }

  public void ClearCallbacks() {
    RakNetPINVOKE.FileList_ClearCallbacks(swigCPtr);
  }

  public RakNetListFileListNode fileList {
    set {
      RakNetPINVOKE.FileList_fileList_set(swigCPtr, RakNetListFileListNode.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.FileList_fileList_get(swigCPtr);
      RakNetListFileListNode ret = (cPtr == IntPtr.Zero) ? null : new RakNetListFileListNode(cPtr, false);
      return ret;
    } 
  }

  public static bool FixEndingSlash(string str) {
    bool ret = RakNetPINVOKE.FileList_FixEndingSlash(str);
    return ret;
  }

  public void AddFile(string filename, string fullPathToFile, byte[] inByteArray, uint dataLength, uint fileLength, FileListNodeContext context, bool isAReference) {
    RakNetPINVOKE.FileList_AddFile__SWIG_1(swigCPtr, filename, fullPathToFile, inByteArray, dataLength, fileLength, FileListNodeContext.getCPtr(context), isAReference);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddFile(string filename, string fullPathToFile, byte[] inByteArray, uint dataLength, uint fileLength, FileListNodeContext context) {
    RakNetPINVOKE.FileList_AddFile__SWIG_2(swigCPtr, filename, fullPathToFile, inByteArray, dataLength, fileLength, FileListNodeContext.getCPtr(context));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
