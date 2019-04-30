Imports System.Web.Http
Imports OtpNet

Public Class App
    Inherits System.Web.HttpApplication
    Protected B As BlockMasterBlockChain
    Public Shared mailer As Mailer
    Public Sub New()
    End Sub

    Protected Sub Application_Start()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        mailer = New Mailer(My.Settings.dbConnectionString)
        Try
            B = New BlockMasterBlockChain(My.Settings.dbConnectionString)
        Catch ex As Exception
        End Try

    End Sub

    Protected Sub Application_End()
    End Sub


    'Application_Start
    'Application_Init
    'Application_Disposed
    'Application_Error
    'Application_End
    'Application_BeginRequest
    'Application_EndRequest
    'Application_PreRequestHandlerExecute
    'Application_PostRequestHandlerExecute
    'Application_PreSendRequestHeaders
    'Application_PreSendRequestContent
    'Application_AcquireRequestState
    'Application_ReleaseRequestState
    'Application_AuthenticateRequest
    'Application_AuthorizeRequest
    'Session_Start
    'Session_End


End Class

