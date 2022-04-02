//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Grapeshot {

public abstract class ApplicationRate : Rate {
  /** DO NOT REMOVE THE FOLLOWING COMMENT **/
  /** THIS HAS BEEN SWIG CORRECTED: JJDKFJSIIIIDKJ **/
  private global::System.Runtime.InteropServices.GCHandle _swigDelegateHandle3;
  private global::System.Runtime.InteropServices.GCHandle _swigDelegateHandle2;
  private global::System.Runtime.InteropServices.GCHandle _swigDelegateHandle1;
  private global::System.Runtime.InteropServices.GCHandle _swigDelegateHandle0;
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ApplicationRate(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GrapeshotApplicationRatePINVOKE.ApplicationRate_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ApplicationRate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ApplicationRate() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          GrapeshotApplicationRatePINVOKE.delete_ApplicationRate(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
      _swigDelegateHandle0.Free();
      _swigDelegateHandle1.Free();
      _swigDelegateHandle2.Free();
      _swigDelegateHandle3.Free();
    }
  }

  public override RateTicket claimTicket(ror.schema.upload.UploadChunkRequest chunkRequest) {
var chunkRequest_table = FlatBuffers.TableUtils.GetTable(chunkRequest);var chunkRequest_length = chunkRequest_table.bb.Length;var chunkRequest_pos = chunkRequest_table.bb_pos;var chunkRequest_seg = chunkRequest_table.bb.ToArraySegment(chunkRequest_pos, chunkRequest_length - chunkRequest_pos);var chunkRequest_managed_array = chunkRequest_seg.Array;var chunkRequest_managed_handle = System.Runtime.InteropServices.GCHandle.Alloc(chunkRequest_managed_array, System.Runtime.InteropServices.GCHandleType.Pinned);var chunkRequest_buffer_ptr = chunkRequest_managed_handle.AddrOfPinnedObject();System.IntPtr chunkRequest_fb_ptr;unsafe {    var chunkRequest_buffer_unsafe_ptr = (byte*) chunkRequest_buffer_ptr.ToPointer();    chunkRequest_fb_ptr = (System.IntPtr) (chunkRequest_buffer_unsafe_ptr + chunkRequest_pos);}var chunkRequest_intermediate = new FBIntermediateBuffer();chunkRequest_intermediate.ptr = chunkRequest_fb_ptr;
    try {
      global::System.IntPtr cPtr = GrapeshotApplicationRatePINVOKE.ApplicationRate_claimTicket(swigCPtr, chunkRequest_intermediate);
      RateTicket ret = (cPtr == global::System.IntPtr.Zero) ? null : new RateTicket(cPtr, true);
      if (GrapeshotApplicationRatePINVOKE.SWIGPendingException.Pending) throw GrapeshotApplicationRatePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
chunkRequest_managed_handle.Free();
    }
  }

  public virtual void applicationClaimTicket(ror.schema.upload.UploadChunkRequest chunkRequest, RateTicketReturn rateTicketReturn) {
var chunkRequest_table = FlatBuffers.TableUtils.GetTable(chunkRequest);var chunkRequest_length = chunkRequest_table.bb.Length;var chunkRequest_pos = chunkRequest_table.bb_pos;var chunkRequest_seg = chunkRequest_table.bb.ToArraySegment(chunkRequest_pos, chunkRequest_length - chunkRequest_pos);var chunkRequest_managed_array = chunkRequest_seg.Array;var chunkRequest_managed_handle = System.Runtime.InteropServices.GCHandle.Alloc(chunkRequest_managed_array, System.Runtime.InteropServices.GCHandleType.Pinned);var chunkRequest_buffer_ptr = chunkRequest_managed_handle.AddrOfPinnedObject();System.IntPtr chunkRequest_fb_ptr;unsafe {    var chunkRequest_buffer_unsafe_ptr = (byte*) chunkRequest_buffer_ptr.ToPointer();    chunkRequest_fb_ptr = (System.IntPtr) (chunkRequest_buffer_unsafe_ptr + chunkRequest_pos);}var chunkRequest_intermediate = new FBIntermediateBuffer();chunkRequest_intermediate.ptr = chunkRequest_fb_ptr;
    try {
      if (SwigDerivedClassHasMethod("applicationClaimTicket", swigMethodTypes2)) GrapeshotApplicationRatePINVOKE.ApplicationRate_applicationClaimTicketSwigExplicitApplicationRate(swigCPtr, chunkRequest_intermediate, RateTicketReturn.getCPtr(rateTicketReturn)); else GrapeshotApplicationRatePINVOKE.ApplicationRate_applicationClaimTicket(swigCPtr, chunkRequest_intermediate, RateTicketReturn.getCPtr(rateTicketReturn));
      if (GrapeshotApplicationRatePINVOKE.SWIGPendingException.Pending) throw GrapeshotApplicationRatePINVOKE.SWIGPendingException.Retrieve();
    } finally {
chunkRequest_managed_handle.Free();
    }
  }

  public override RateTicket tryClaimTicket(ror.schema.upload.UploadChunkRequest chunkRequest) {
var chunkRequest_table = FlatBuffers.TableUtils.GetTable(chunkRequest);var chunkRequest_length = chunkRequest_table.bb.Length;var chunkRequest_pos = chunkRequest_table.bb_pos;var chunkRequest_seg = chunkRequest_table.bb.ToArraySegment(chunkRequest_pos, chunkRequest_length - chunkRequest_pos);var chunkRequest_managed_array = chunkRequest_seg.Array;var chunkRequest_managed_handle = System.Runtime.InteropServices.GCHandle.Alloc(chunkRequest_managed_array, System.Runtime.InteropServices.GCHandleType.Pinned);var chunkRequest_buffer_ptr = chunkRequest_managed_handle.AddrOfPinnedObject();System.IntPtr chunkRequest_fb_ptr;unsafe {    var chunkRequest_buffer_unsafe_ptr = (byte*) chunkRequest_buffer_ptr.ToPointer();    chunkRequest_fb_ptr = (System.IntPtr) (chunkRequest_buffer_unsafe_ptr + chunkRequest_pos);}var chunkRequest_intermediate = new FBIntermediateBuffer();chunkRequest_intermediate.ptr = chunkRequest_fb_ptr;
    try {
      global::System.IntPtr cPtr = GrapeshotApplicationRatePINVOKE.ApplicationRate_tryClaimTicket(swigCPtr, chunkRequest_intermediate);
      RateTicket ret = (cPtr == global::System.IntPtr.Zero) ? null : new RateTicket(cPtr, true);
      if (GrapeshotApplicationRatePINVOKE.SWIGPendingException.Pending) throw GrapeshotApplicationRatePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
chunkRequest_managed_handle.Free();
    }
  }

  public virtual void applicationTryClaimTicket(ror.schema.upload.UploadChunkRequest chunkRequest, RateTicketReturn rateTicketReturn) {
var chunkRequest_table = FlatBuffers.TableUtils.GetTable(chunkRequest);var chunkRequest_length = chunkRequest_table.bb.Length;var chunkRequest_pos = chunkRequest_table.bb_pos;var chunkRequest_seg = chunkRequest_table.bb.ToArraySegment(chunkRequest_pos, chunkRequest_length - chunkRequest_pos);var chunkRequest_managed_array = chunkRequest_seg.Array;var chunkRequest_managed_handle = System.Runtime.InteropServices.GCHandle.Alloc(chunkRequest_managed_array, System.Runtime.InteropServices.GCHandleType.Pinned);var chunkRequest_buffer_ptr = chunkRequest_managed_handle.AddrOfPinnedObject();System.IntPtr chunkRequest_fb_ptr;unsafe {    var chunkRequest_buffer_unsafe_ptr = (byte*) chunkRequest_buffer_ptr.ToPointer();    chunkRequest_fb_ptr = (System.IntPtr) (chunkRequest_buffer_unsafe_ptr + chunkRequest_pos);}var chunkRequest_intermediate = new FBIntermediateBuffer();chunkRequest_intermediate.ptr = chunkRequest_fb_ptr;
    try {
      if (SwigDerivedClassHasMethod("applicationTryClaimTicket", swigMethodTypes3)) GrapeshotApplicationRatePINVOKE.ApplicationRate_applicationTryClaimTicketSwigExplicitApplicationRate(swigCPtr, chunkRequest_intermediate, RateTicketReturn.getCPtr(rateTicketReturn)); else GrapeshotApplicationRatePINVOKE.ApplicationRate_applicationTryClaimTicket(swigCPtr, chunkRequest_intermediate, RateTicketReturn.getCPtr(rateTicketReturn));
      if (GrapeshotApplicationRatePINVOKE.SWIGPendingException.Pending) throw GrapeshotApplicationRatePINVOKE.SWIGPendingException.Retrieve();
    } finally {
chunkRequest_managed_handle.Free();
    }
  }

  public override bool areFreeTickets() {
    bool ret = (SwigDerivedClassHasMethod("areFreeTickets", swigMethodTypes1) ? GrapeshotApplicationRatePINVOKE.ApplicationRate_areFreeTicketsSwigExplicitApplicationRate(swigCPtr) : GrapeshotApplicationRatePINVOKE.ApplicationRate_areFreeTickets(swigCPtr));
    if (GrapeshotApplicationRatePINVOKE.SWIGPendingException.Pending) throw GrapeshotApplicationRatePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void process() {
    if (SwigDerivedClassHasMethod("process", swigMethodTypes0)) GrapeshotApplicationRatePINVOKE.ApplicationRate_processSwigExplicitApplicationRate(swigCPtr); else GrapeshotApplicationRatePINVOKE.ApplicationRate_process(swigCPtr);
    if (GrapeshotApplicationRatePINVOKE.SWIGPendingException.Pending) throw GrapeshotApplicationRatePINVOKE.SWIGPendingException.Retrieve();
  }

  public ApplicationRate() : this(GrapeshotApplicationRatePINVOKE.new_ApplicationRate(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    global::System.IntPtr swigDelegate0gcHandlePtr = global::System.IntPtr.Zero;
    if (SwigDerivedClassHasMethod("process", swigMethodTypes0)) {
      swigDelegate0 = new SwigDelegateApplicationRate_0(SwigDirectorprocess);
      swigDelegate0dispatcher = new SwigDelegateApplicationRate_0_Dispatcher(SwigDirectorprocess_Dispatcher);
      
      global::System.Runtime.InteropServices.GCHandle swigDelegate0gcHandle = global::System.Runtime.InteropServices.GCHandle.Alloc(swigDelegate0, global::System.Runtime.InteropServices.GCHandleType.Normal);
      _swigDelegateHandle0 = swigDelegate0gcHandle;
      swigDelegate0gcHandlePtr = global::System.Runtime.InteropServices.GCHandle.ToIntPtr(swigDelegate0gcHandle);
    }
    global::System.IntPtr swigDelegate1gcHandlePtr = global::System.IntPtr.Zero;
    if (SwigDerivedClassHasMethod("areFreeTickets", swigMethodTypes1)) {
      swigDelegate1 = new SwigDelegateApplicationRate_1(SwigDirectorareFreeTickets);
      swigDelegate1dispatcher = new SwigDelegateApplicationRate_1_Dispatcher(SwigDirectorareFreeTickets_Dispatcher);
      
      global::System.Runtime.InteropServices.GCHandle swigDelegate1gcHandle = global::System.Runtime.InteropServices.GCHandle.Alloc(swigDelegate1, global::System.Runtime.InteropServices.GCHandleType.Normal);
      _swigDelegateHandle1 = swigDelegate1gcHandle;
      swigDelegate1gcHandlePtr = global::System.Runtime.InteropServices.GCHandle.ToIntPtr(swigDelegate1gcHandle);
    }
    global::System.IntPtr swigDelegate2gcHandlePtr = global::System.IntPtr.Zero;
    if (SwigDerivedClassHasMethod("applicationClaimTicket", swigMethodTypes2)) {
      swigDelegate2 = new SwigDelegateApplicationRate_2(SwigDirectorapplicationClaimTicket);
      swigDelegate2dispatcher = new SwigDelegateApplicationRate_2_Dispatcher(SwigDirectorapplicationClaimTicket_Dispatcher);
      
      global::System.Runtime.InteropServices.GCHandle swigDelegate2gcHandle = global::System.Runtime.InteropServices.GCHandle.Alloc(swigDelegate2, global::System.Runtime.InteropServices.GCHandleType.Normal);
      _swigDelegateHandle2 = swigDelegate2gcHandle;
      swigDelegate2gcHandlePtr = global::System.Runtime.InteropServices.GCHandle.ToIntPtr(swigDelegate2gcHandle);
    }
    global::System.IntPtr swigDelegate3gcHandlePtr = global::System.IntPtr.Zero;
    if (SwigDerivedClassHasMethod("applicationTryClaimTicket", swigMethodTypes3)) {
      swigDelegate3 = new SwigDelegateApplicationRate_3(SwigDirectorapplicationTryClaimTicket);
      swigDelegate3dispatcher = new SwigDelegateApplicationRate_3_Dispatcher(SwigDirectorapplicationTryClaimTicket_Dispatcher);
      
      global::System.Runtime.InteropServices.GCHandle swigDelegate3gcHandle = global::System.Runtime.InteropServices.GCHandle.Alloc(swigDelegate3, global::System.Runtime.InteropServices.GCHandleType.Normal);
      _swigDelegateHandle3 = swigDelegate3gcHandle;
      swigDelegate3gcHandlePtr = global::System.Runtime.InteropServices.GCHandle.ToIntPtr(swigDelegate3gcHandle);
    }
    GrapeshotApplicationRatePINVOKE.ApplicationRate_director_connect(swigCPtr, swigDelegate0dispatcher, swigDelegate0gcHandlePtr, swigDelegate1dispatcher, swigDelegate1gcHandlePtr, swigDelegate2dispatcher, swigDelegate2gcHandlePtr, swigDelegate3dispatcher, swigDelegate3gcHandlePtr);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ApplicationRate));
    return hasDerivedMethod;
  }

  private void SwigDirectorprocess() {
    process();
  }

  [GrapeshotApplicationRatePINVOKE.MonoPInvokeCallback(typeof(SwigDelegateApplicationRate_0_Dispatcher))]
  private static void SwigDirectorprocess_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_0_Handle) {
    global::System.Runtime.InteropServices.GCHandle gcHandle = global::System.Runtime.InteropServices.GCHandle.FromIntPtr(swigDelegateApplicationRate_0_Handle);
    SwigDelegateApplicationRate_0 delegateSwigDelegateApplicationRate_0 = (SwigDelegateApplicationRate_0) gcHandle.Target;
delegateSwigDelegateApplicationRate_0();
  }

  private bool SwigDirectorareFreeTickets() {
    return areFreeTickets();
  }

  [GrapeshotApplicationRatePINVOKE.MonoPInvokeCallback(typeof(SwigDelegateApplicationRate_1_Dispatcher))]
  private static bool SwigDirectorareFreeTickets_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_1_Handle) {
    global::System.Runtime.InteropServices.GCHandle gcHandle = global::System.Runtime.InteropServices.GCHandle.FromIntPtr(swigDelegateApplicationRate_1_Handle);
    SwigDelegateApplicationRate_1 delegateSwigDelegateApplicationRate_1 = (SwigDelegateApplicationRate_1) gcHandle.Target;
    return delegateSwigDelegateApplicationRate_1();
  }

  private void SwigDirectorapplicationClaimTicket(FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn) {
var chunkRequest_buffer = new byte[chunkRequest.size];UnityEngine.Assertions.Assert.AreNotEqual(chunkRequest.size, (ulong) 0);System.Runtime.InteropServices.Marshal.Copy(chunkRequest.ptr, chunkRequest_buffer, 0, (int) chunkRequest.size);var chunkRequest_bb = new FlatBuffers.ByteBuffer(chunkRequest_buffer);var chunkRequest_fb = new ror.schema.upload.UploadChunkRequest();chunkRequest_fb.__assign(chunkRequest_bb.GetInt(chunkRequest_bb.Position) + chunkRequest_bb.Position, chunkRequest_bb);
    applicationClaimTicket(chunkRequest_fb, new RateTicketReturn(rateTicketReturn, false));
  }

  [GrapeshotApplicationRatePINVOKE.MonoPInvokeCallback(typeof(SwigDelegateApplicationRate_2_Dispatcher))]
  private static void SwigDirectorapplicationClaimTicket_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_2_Handle, FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn) {
var chunkRequest_buffer = new byte[chunkRequest.size];UnityEngine.Assertions.Assert.AreNotEqual(chunkRequest.size, (ulong) 0);System.Runtime.InteropServices.Marshal.Copy(chunkRequest.ptr, chunkRequest_buffer, 0, (int) chunkRequest.size);var chunkRequest_bb = new FlatBuffers.ByteBuffer(chunkRequest_buffer);var chunkRequest_fb = new ror.schema.upload.UploadChunkRequest();chunkRequest_fb.__assign(chunkRequest_bb.GetInt(chunkRequest_bb.Position) + chunkRequest_bb.Position, chunkRequest_bb);
    global::System.Runtime.InteropServices.GCHandle gcHandle = global::System.Runtime.InteropServices.GCHandle.FromIntPtr(swigDelegateApplicationRate_2_Handle);
    SwigDelegateApplicationRate_2 delegateSwigDelegateApplicationRate_2 = (SwigDelegateApplicationRate_2) gcHandle.Target;
delegateSwigDelegateApplicationRate_2(chunkRequest, rateTicketReturn);
  }

  private void SwigDirectorapplicationTryClaimTicket(FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn) {
var chunkRequest_buffer = new byte[chunkRequest.size];UnityEngine.Assertions.Assert.AreNotEqual(chunkRequest.size, (ulong) 0);System.Runtime.InteropServices.Marshal.Copy(chunkRequest.ptr, chunkRequest_buffer, 0, (int) chunkRequest.size);var chunkRequest_bb = new FlatBuffers.ByteBuffer(chunkRequest_buffer);var chunkRequest_fb = new ror.schema.upload.UploadChunkRequest();chunkRequest_fb.__assign(chunkRequest_bb.GetInt(chunkRequest_bb.Position) + chunkRequest_bb.Position, chunkRequest_bb);
    applicationTryClaimTicket(chunkRequest_fb, new RateTicketReturn(rateTicketReturn, false));
  }

  [GrapeshotApplicationRatePINVOKE.MonoPInvokeCallback(typeof(SwigDelegateApplicationRate_3_Dispatcher))]
  private static void SwigDirectorapplicationTryClaimTicket_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_3_Handle, FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn) {
var chunkRequest_buffer = new byte[chunkRequest.size];UnityEngine.Assertions.Assert.AreNotEqual(chunkRequest.size, (ulong) 0);System.Runtime.InteropServices.Marshal.Copy(chunkRequest.ptr, chunkRequest_buffer, 0, (int) chunkRequest.size);var chunkRequest_bb = new FlatBuffers.ByteBuffer(chunkRequest_buffer);var chunkRequest_fb = new ror.schema.upload.UploadChunkRequest();chunkRequest_fb.__assign(chunkRequest_bb.GetInt(chunkRequest_bb.Position) + chunkRequest_bb.Position, chunkRequest_bb);
    global::System.Runtime.InteropServices.GCHandle gcHandle = global::System.Runtime.InteropServices.GCHandle.FromIntPtr(swigDelegateApplicationRate_3_Handle);
    SwigDelegateApplicationRate_3 delegateSwigDelegateApplicationRate_3 = (SwigDelegateApplicationRate_3) gcHandle.Target;
delegateSwigDelegateApplicationRate_3(chunkRequest, rateTicketReturn);
  }

  public delegate void SwigDelegateApplicationRate_0();
  public delegate bool SwigDelegateApplicationRate_1();
  public delegate void SwigDelegateApplicationRate_2(FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn);
  public delegate void SwigDelegateApplicationRate_3(FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn);

  private SwigDelegateApplicationRate_0 swigDelegate0;
  private SwigDelegateApplicationRate_1 swigDelegate1;
  private SwigDelegateApplicationRate_2 swigDelegate2;
  private SwigDelegateApplicationRate_3 swigDelegate3;

  public delegate void SwigDelegateApplicationRate_0_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_0_Handle);
  public delegate bool SwigDelegateApplicationRate_1_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_1_Handle);
  public delegate void SwigDelegateApplicationRate_2_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_2_Handle, FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn);
  public delegate void SwigDelegateApplicationRate_3_Dispatcher(global::System.IntPtr swigDelegateApplicationRate_3_Handle, FBIntermediateBuffer chunkRequest, global::System.IntPtr rateTicketReturn);

  private SwigDelegateApplicationRate_0_Dispatcher swigDelegate0dispatcher;
  private SwigDelegateApplicationRate_1_Dispatcher swigDelegate1dispatcher;
  private SwigDelegateApplicationRate_2_Dispatcher swigDelegate2dispatcher;
  private SwigDelegateApplicationRate_3_Dispatcher swigDelegate3dispatcher;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(ror.schema.upload.UploadChunkRequest), typeof(RateTicketReturn) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(ror.schema.upload.UploadChunkRequest), typeof(RateTicketReturn) };
}

}
