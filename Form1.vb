Imports System.Text

Public Class Form1

    Private _pdcx As DSIPDCXLib.DsiPDCX

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SetupForm()
        Me.InstantiatePDCX()
    End Sub

    Private Sub btnInitialize_Click(sender As System.Object, e As System.EventArgs) Handles btnInitialize.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "Setup")
        requestDictionary.Add("TranCode", "SecureDeviceInit")
        requestDictionary.Add("PadType", Me.cmbPadTypes.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Admin").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtNETePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub lnkPDCXDownload_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPDCXDownload.LinkClicked
        Dim dsiPDCXWebSite As ProcessStartInfo = New ProcessStartInfo("http://www.datacapepay.com/dsipdcx.htm")
        Process.Start(dsiPDCXWebSite)
    End Sub

    Private Sub btnCreditSale_Click(sender As System.Object, e As System.EventArgs) Handles btnCreditSale.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "Credit")
        requestDictionary.Add("TranCode", "Sale")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("Frequency", "OneTime")
        requestDictionary.Add("RecordNo", "RecordNumberRequested")
        requestDictionary.Add("PartialAuth", "Allow")
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtNETePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnCreditRefund_Click(sender As System.Object, e As System.EventArgs) Handles btnCreditRefund.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "Credit")
        requestDictionary.Add("TranCode", "Return")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("Frequency", "OneTime")
        requestDictionary.Add("RecordNo", "RecordNumberRequested")
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value)
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtNETePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnDebitSale_Click(sender As System.Object, e As System.EventArgs) Handles btnDebitSale.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "Debit")
        requestDictionary.Add("TranCode", "Sale")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtNETePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnDebitRefund_Click(sender As System.Object, e As System.EventArgs) Handles btnDebitRefund.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "Debit")
        requestDictionary.Add("TranCode", "Return")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtNETePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnGiftCardBalance_Click(sender As System.Object, e As System.EventArgs) Handles btnGiftCardBalance.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "PrePaid")
        requestDictionary.Add("TranCode", "Balance")
        requestDictionary.Add("IpPort", "9100")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", 0.0)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtGIFTePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnGiftCardAddVale_Click(sender As System.Object, e As System.EventArgs) Handles btnGiftCardAddVale.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "PrePaid")
        requestDictionary.Add("TranCode", "Reload")
        requestDictionary.Add("IpPort", "9100")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", Me.nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtGIFTePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnGiftCardSale_Click(sender As System.Object, e As System.EventArgs) Handles btnGiftCardSale.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "PrePaid")
        requestDictionary.Add("TranCode", "Sale")
        requestDictionary.Add("IpPort", "9100")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", Me.nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtGIFTePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnGiftCardRefund_Click(sender As System.Object, e As System.EventArgs) Handles btnGiftCardRefund.Click

        Cursor.Current = Cursors.WaitCursor
        Dim requestDictionary As New Dictionary(Of String, Object)()

        requestDictionary.Add("TranType", "PrePaid")
        requestDictionary.Add("TranCode", "Return")
        requestDictionary.Add("IpPort", "9100")
        requestDictionary.Add("MerchantID", Me.GetMerchantID())
        requestDictionary.Add("InvoiceNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("RefNo", Me.txtInvoiceNo.Text)
        requestDictionary.Add("SecureDevice", Me.cmbSecureDevices.Text)
        requestDictionary.Add("ComPort", Me.nudComPort.Value.ToString())
        Dim amountDictionary As New Dictionary(Of String, Object)
        amountDictionary.Add("Purchase", Me.nudPurchase.Value)
        requestDictionary.Add("Amount", amountDictionary)
        Dim accountDictionary As New Dictionary(Of String, Object)
        accountDictionary.Add("AcctNo", Me.GetAcctNo())
        requestDictionary.Add("Account", accountDictionary)
        requestDictionary.Add("OperatorID", Me.txtOperatorID.Text)
        requestDictionary.Add("Memo", Me.txtMemo.Text)

        Dim xmlRequest As String = XMLHelper.BuildXMLRequest(requestDictionary, "Transaction").ToString()
        Dim xmlResponse As String = Me.ProcessTransaction(xmlRequest, Me.txtGIFTePayHostList.Text)

        Me.BuildParsedResponse(xmlResponse)
        Cursor.Current = Cursors.Default


    End Sub

    Private Sub SetupForm()
        Me.txtNETePayHostList.Text = Config.NETePayHostList
        Me.txtGIFTePayHostList.Text = Config.GIFTePayHostList
        Me.chkShowDialogs.Checked = False
        Me.chkKeyedTransaction.Checked = False
        Me.nudConnectTimeout.Value = 5
        Me.nudRepsonseTimeout.Value = 60
        Me.cmbMerchantIDs.DataSource = Config.MerchantIDList
        Me.cmbSecureDevices.DataSource = Config.SecureDeviceList
        Me.cmbPadTypes.DataSource = Config.PadTypeList
        Me.nudComPort.Value = 0
        Me.nudPurchase.Value = 1.25
        Me.txtInvoiceNo.Text = "123456"
        Me.txtOperatorID.Text = "123ABC"
        Me.txtMemo.Text = "Alenxandria Computers Prototype"
    End Sub

    Private Sub InstantiatePDCX()
        Try
            _pdcx = New DSIPDCXLib.DsiPDCX()
        Catch ex As Exception
            Dim message As String = "Failed to instantiate PDCX control with Message: " + ex.Message
            MessageBox.Show(message, "Failed to instantiate PDCX control", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Function GetMerchantID() As String
        Dim merchantID As String = Me.cmbMerchantIDs.Text

        If String.IsNullOrEmpty(merchantID) = False _
            AndAlso merchantID.Contains(" ") Then
            merchantID = merchantID.Substring(0, merchantID.IndexOf(" "))
        End If

        Return merchantID
    End Function

    Private Function GetAcctNo() As String
        Dim acctNo As String = "SecureDevice"

        If Me.chkKeyedTransaction.Checked Then
            acctNo = "Prompt"
        End If

        Return acctNo
    End Function

    Private Function ProcessTransaction(request As String, hostList As String) As String

        Try

            Me.rtbParsedResponse.Clear()
            Dim processControl As Short = CShort(If(Me.chkShowDialogs.Checked, 0, 1))
            _pdcx.ServerIPConfig(hostList, processControl)
            _pdcx.SetConnectTimeout(CShort(Me.nudConnectTimeout.Value))
            _pdcx.SetResponseTimeout(CShort(Me.nudRepsonseTimeout.Value))
            Return _pdcx.ProcessTransaction(request, processControl, String.Empty, String.Empty)

        Catch ex As Exception

            Dim sb As New StringBuilder()
            sb.AppendLine("Exception thrown submitting request!")
            sb.AppendLine("")
            sb.AppendLine(ex.ToString())
            MessageBox.Show(sb.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return String.Empty

    End Function

    Private Sub BuildParsedResponse(response As String)
        Me.rtbParsedResponse.Clear()
        Me.rtbParsedResponse.ForeColor = Color.Red

        If (String.IsNullOrEmpty(response) = False) Then
            Dim responseDictionary As Dictionary(Of String, String) = XMLHelper.ParseXMLResponse(response)

            If (responseDictionary.ContainsKey("CmdStatus") _
                AndAlso (responseDictionary("CmdStatus") = "Approved" Or responseDictionary("CmdStatus") = "Success")) Then

                Me.rtbParsedResponse.ForeColor = Color.DarkGreen

            End If

            Dim sb As StringBuilder = New StringBuilder()

            For Each kvp As KeyValuePair(Of String, String) In responseDictionary
                sb.AppendFormat("{0}: {1}{2}", kvp.Key, kvp.Value, Environment.NewLine)
            Next

            Me.rtbParsedResponse.Text = sb.ToString()

        End If

    End Sub

End Class
