Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Configuration
Imports System.Linq

Public NotInheritable Class Config
    Private Sub New()
    End Sub
    Private Shared _delimiter As Char() = New Char() {"|"c}
    Private Shared _NETePayHostList As String
    Private Shared _GIFTePayHostList As String
    Private Shared _MerchantIDList As String
    Private Shared _SecureDeviceList As String
    Private Shared _PadTypeList As String

    Public Shared ReadOnly Property NETePayHostList() As String
        Get
            Return _NETePayHostList
        End Get
    End Property

    Public Shared ReadOnly Property GIFTePayHostList() As String
        Get
            Return _GIFTePayHostList
        End Get
    End Property

    Public Shared ReadOnly Property MerchantIDList() As List(Of String)
        Get
            Return _MerchantIDList.Split(_delimiter).ToList()
        End Get
    End Property

    Public Shared ReadOnly Property SecureDeviceList() As List(Of String)
        Get
            Return _SecureDeviceList.Split(_delimiter).ToList()
        End Get
    End Property

    Public Shared ReadOnly Property PadTypeList() As List(Of String)
        Get
            Return _PadTypeList.Split(_delimiter).ToList()
        End Get
    End Property

    Shared Sub New()
        Dim appSettings As NameValueCollection = ConfigurationManager.AppSettings
        _NETePayHostList = appSettings("NETePayHostList")
        _GIFTePayHostList = appSettings("GIFTePayHostList")
        _MerchantIDList = appSettings("MerchantIDList")
        _SecureDeviceList = appSettings("SecureDeviceList")
        _PadTypeList = appSettings("PadTypeList")
    End Sub
End Class
