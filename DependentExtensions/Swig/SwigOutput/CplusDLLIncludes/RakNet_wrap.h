/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 * 
 * This file is not intended to be easily readable and contains a number of 
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG 
 * interface file instead. 
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_RakNet_WRAP_H_
#define SWIG_RakNet_WRAP_H_

class SwigDirector_NetworkIDObject : public RakNet::NetworkIDObject, public Swig::Director {

public:
    SwigDirector_NetworkIDObject();
    virtual ~SwigDirector_NetworkIDObject();
    virtual void SetNetworkIDManager(RakNet::NetworkIDManager *manager);
    virtual RakNet::NetworkIDManager *GetNetworkIDManager() const;
    virtual RakNet::NetworkID GetNetworkID();
    virtual void SetNetworkID(RakNet::NetworkID id);
    virtual void SetParent(void *_parent);
    virtual void *GetParent() const;

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef void * (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef unsigned long long (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(unsigned long long);
    void swig_connect_director(SWIG_Callback0_t callbackSetNetworkIDManagerOrig, SWIG_Callback1_t callbackGetNetworkIDManager, SWIG_Callback2_t callbackGetNetworkID, SWIG_Callback3_t callbackSetNetworkID);

private:
    SWIG_Callback0_t swig_callbackSetNetworkIDManagerOrig;
    SWIG_Callback1_t swig_callbackGetNetworkIDManager;
    SWIG_Callback2_t swig_callbackGetNetworkID;
    SWIG_Callback3_t swig_callbackSetNetworkID;
    void swig_init_callbacks();
};

struct SwigDirector_NatPunchthroughDebugInterface : public RakNet::NatPunchthroughDebugInterface, public Swig::Director {

public:
    SwigDirector_NatPunchthroughDebugInterface();
    virtual ~SwigDirector_NatPunchthroughDebugInterface();
    virtual void OnClientMessage(char const *msg);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(char *);
    void swig_connect_director(SWIG_Callback0_t callbackOnClientMessage);

private:
    SWIG_Callback0_t swig_callbackOnClientMessage;
    void swig_init_callbacks();
};

struct SwigDirector_UDPProxyClientResultHandler : public RakNet::UDPProxyClientResultHandler, public Swig::Director {

public:
    SwigDirector_UDPProxyClientResultHandler();
    virtual ~SwigDirector_UDPProxyClientResultHandler();
    virtual void OnForwardingSuccess(char const *proxyIPAddress, unsigned short proxyPort, RakNet::SystemAddress proxyCoordinator, RakNet::SystemAddress sourceAddress, RakNet::SystemAddress targetAddress, RakNet::RakNetGUID targetGuid, RakNet::UDPProxyClient *proxyClientPlugin);
    virtual void OnForwardingNotification(char const *proxyIPAddress, unsigned short proxyPort, RakNet::SystemAddress proxyCoordinator, RakNet::SystemAddress sourceAddress, RakNet::SystemAddress targetAddress, RakNet::RakNetGUID targetGuid, RakNet::UDPProxyClient *proxyClientPlugin);
    virtual void OnNoServersOnline(RakNet::SystemAddress proxyCoordinator, RakNet::SystemAddress sourceAddress, RakNet::SystemAddress targetAddress, RakNet::RakNetGUID targetGuid, RakNet::UDPProxyClient *proxyClientPlugin);
    virtual void OnRecipientNotConnected(RakNet::SystemAddress proxyCoordinator, RakNet::SystemAddress sourceAddress, RakNet::SystemAddress targetAddress, RakNet::RakNetGUID targetGuid, RakNet::UDPProxyClient *proxyClientPlugin);
    virtual void OnAllServersBusy(RakNet::SystemAddress proxyCoordinator, RakNet::SystemAddress sourceAddress, RakNet::SystemAddress targetAddress, RakNet::RakNetGUID targetGuid, RakNet::UDPProxyClient *proxyClientPlugin);
    virtual void OnForwardingInProgress(char const *proxyIPAddress, unsigned short proxyPort, RakNet::SystemAddress proxyCoordinator, RakNet::SystemAddress sourceAddress, RakNet::SystemAddress targetAddress, RakNet::RakNetGUID targetGuid, RakNet::UDPProxyClient *proxyClientPlugin);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(char *, unsigned short, void *, void *, void *, void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(char *, unsigned short, void *, void *, void *, void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(void *, void *, void *, void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(void *, void *, void *, void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)(void *, void *, void *, void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback5_t)(char *, unsigned short, void *, void *, void *, void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackOnForwardingSuccess, SWIG_Callback1_t callbackOnForwardingNotification, SWIG_Callback2_t callbackOnNoServersOnline, SWIG_Callback3_t callbackOnRecipientNotConnected, SWIG_Callback4_t callbackOnAllServersBusy, SWIG_Callback5_t callbackOnForwardingInProgress);

private:
    SWIG_Callback0_t swig_callbackOnForwardingSuccess;
    SWIG_Callback1_t swig_callbackOnForwardingNotification;
    SWIG_Callback2_t swig_callbackOnNoServersOnline;
    SWIG_Callback3_t swig_callbackOnRecipientNotConnected;
    SWIG_Callback4_t swig_callbackOnAllServersBusy;
    SWIG_Callback5_t swig_callbackOnForwardingInProgress;
    void swig_init_callbacks();
};

struct SwigDirector_UDPProxyServerResultHandler : public RakNet::UDPProxyServerResultHandler, public Swig::Director {

public:
    SwigDirector_UDPProxyServerResultHandler();
    virtual ~SwigDirector_UDPProxyServerResultHandler();
    virtual void OnLoginSuccess(RakNet::RakString usedPassword, RakNet::UDPProxyServer *proxyServerPlugin);
    virtual void OnAlreadyLoggedIn(RakNet::RakString usedPassword, RakNet::UDPProxyServer *proxyServerPlugin);
    virtual void OnNoPasswordSet(RakNet::RakString usedPassword, RakNet::UDPProxyServer *proxyServerPlugin);
    virtual void OnWrongPassword(RakNet::RakString usedPassword, RakNet::UDPProxyServer *proxyServerPlugin);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackOnLoginSuccess, SWIG_Callback1_t callbackOnAlreadyLoggedIn, SWIG_Callback2_t callbackOnNoPasswordSet, SWIG_Callback3_t callbackOnWrongPassword);

private:
    SWIG_Callback0_t swig_callbackOnLoginSuccess;
    SWIG_Callback1_t swig_callbackOnAlreadyLoggedIn;
    SWIG_Callback2_t swig_callbackOnNoPasswordSet;
    SWIG_Callback3_t swig_callbackOnWrongPassword;
    void swig_init_callbacks();
};

class SwigDirector_FileListTransferCBInterface : public RakNet::FileListTransferCBInterface, public Swig::Director {

public:
    SwigDirector_FileListTransferCBInterface();
    virtual ~SwigDirector_FileListTransferCBInterface();
    virtual bool OnFile(OnFileStruct *onFileStruct);
    virtual void OnFileProgress(FileProgressStruct *fps);
    virtual bool Update();
    virtual bool OnDownloadComplete(DownloadCompleteStruct *dcs);
    virtual void OnDereference();

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)();
    void swig_connect_director(SWIG_Callback0_t callbackOnFile, SWIG_Callback1_t callbackOnFileProgress, SWIG_Callback2_t callbackUpdate, SWIG_Callback3_t callbackOnDownloadComplete, SWIG_Callback4_t callbackOnDereference);

private:
    SWIG_Callback0_t swig_callbackOnFile;
    SWIG_Callback1_t swig_callbackOnFileProgress;
    SWIG_Callback2_t swig_callbackUpdate;
    SWIG_Callback3_t swig_callbackOnDownloadComplete;
    SWIG_Callback4_t swig_callbackOnDereference;
    void swig_init_callbacks();
};


#endif
