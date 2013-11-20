<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGiftCardRefund = New System.Windows.Forms.Button()
        Me.btnGiftCardSale = New System.Windows.Forms.Button()
        Me.btnGiftCardBalance = New System.Windows.Forms.Button()
        Me.btnGiftCardAddVale = New System.Windows.Forms.Button()
        Me.btnCreditRefund = New System.Windows.Forms.Button()
        Me.btnDebitRefund = New System.Windows.Forms.Button()
        Me.btnDebitSale = New System.Windows.Forms.Button()
        Me.btnCreditSale = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbMerchantIDs = New System.Windows.Forms.ComboBox()
        Me.btnInitialize = New System.Windows.Forms.Button()
        Me.lblSecureDevice = New System.Windows.Forms.Label()
        Me.cmbSecureDevices = New System.Windows.Forms.ComboBox()
        Me.chkKeyedTransaction = New System.Windows.Forms.CheckBox()
        Me.chkShowDialogs = New System.Windows.Forms.CheckBox()
        Me.lblPadType = New System.Windows.Forms.Label()
        Me.nudRepsonseTimeout = New System.Windows.Forms.NumericUpDown()
        Me.cmbPadTypes = New System.Windows.Forms.ComboBox()
        Me.lblResponseTimeout = New System.Windows.Forms.Label()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.txtNETePayHostList = New System.Windows.Forms.TextBox()
        Me.nudComPort = New System.Windows.Forms.NumericUpDown()
        Me.lblGIFTePayHostList = New System.Windows.Forms.Label()
        Me.nudConnectTimeout = New System.Windows.Forms.NumericUpDown()
        Me.lblNETePayHostList = New System.Windows.Forms.Label()
        Me.txtGIFTePayHostList = New System.Windows.Forms.TextBox()
        Me.lblConnectTimeout = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo = New System.Windows.Forms.Button()
        Me.lblMemo = New System.Windows.Forms.Label()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.lblPurchase = New System.Windows.Forms.Label()
        Me.nudPurchase = New System.Windows.Forms.NumericUpDown()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblOperatorID = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.txtOperatorID = New System.Windows.Forms.TextBox()
        Me.lblDownloadAndInstall = New System.Windows.Forms.Label()
        Me.lnkPDCXDownload = New System.Windows.Forms.LinkLabel()
        Me.lblPrerequisite = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbParsedResponse = New System.Windows.Forms.RichTextBox()
        Me.lblParsedResponse = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        CType(Me.nudRepsonseTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConnectTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGiftCardRefund
        '
        Me.btnGiftCardRefund.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGiftCardRefund.FlatAppearance.BorderSize = 0
        Me.btnGiftCardRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiftCardRefund.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftCardRefund.ForeColor = System.Drawing.Color.White
        Me.btnGiftCardRefund.Image = CType(resources.GetObject("btnGiftCardRefund.Image"), System.Drawing.Image)
        Me.btnGiftCardRefund.Location = New System.Drawing.Point(620, 58)
        Me.btnGiftCardRefund.Name = "btnGiftCardRefund"
        Me.btnGiftCardRefund.Size = New System.Drawing.Size(71, 60)
        Me.btnGiftCardRefund.TabIndex = 305
        Me.btnGiftCardRefund.Text = "Gift Card Refund"
        Me.btnGiftCardRefund.UseVisualStyleBackColor = True
        '
        'btnGiftCardSale
        '
        Me.btnGiftCardSale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGiftCardSale.FlatAppearance.BorderSize = 0
        Me.btnGiftCardSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiftCardSale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftCardSale.ForeColor = System.Drawing.Color.White
        Me.btnGiftCardSale.Image = CType(resources.GetObject("btnGiftCardSale.Image"), System.Drawing.Image)
        Me.btnGiftCardSale.Location = New System.Drawing.Point(543, 58)
        Me.btnGiftCardSale.Name = "btnGiftCardSale"
        Me.btnGiftCardSale.Size = New System.Drawing.Size(71, 60)
        Me.btnGiftCardSale.TabIndex = 304
        Me.btnGiftCardSale.Text = "Gift Card Sale"
        Me.btnGiftCardSale.UseVisualStyleBackColor = True
        '
        'btnGiftCardBalance
        '
        Me.btnGiftCardBalance.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGiftCardBalance.FlatAppearance.BorderSize = 0
        Me.btnGiftCardBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiftCardBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftCardBalance.ForeColor = System.Drawing.Color.White
        Me.btnGiftCardBalance.Image = CType(resources.GetObject("btnGiftCardBalance.Image"), System.Drawing.Image)
        Me.btnGiftCardBalance.Location = New System.Drawing.Point(364, 58)
        Me.btnGiftCardBalance.Name = "btnGiftCardBalance"
        Me.btnGiftCardBalance.Size = New System.Drawing.Size(71, 60)
        Me.btnGiftCardBalance.TabIndex = 303
        Me.btnGiftCardBalance.Text = "Gift Card Balance"
        Me.btnGiftCardBalance.UseVisualStyleBackColor = True
        '
        'btnGiftCardAddVale
        '
        Me.btnGiftCardAddVale.BackgroundImage = CType(resources.GetObject("btnGiftCardAddVale.BackgroundImage"), System.Drawing.Image)
        Me.btnGiftCardAddVale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGiftCardAddVale.FlatAppearance.BorderSize = 0
        Me.btnGiftCardAddVale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiftCardAddVale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftCardAddVale.ForeColor = System.Drawing.Color.White
        Me.btnGiftCardAddVale.Image = CType(resources.GetObject("btnGiftCardAddVale.Image"), System.Drawing.Image)
        Me.btnGiftCardAddVale.Location = New System.Drawing.Point(441, 58)
        Me.btnGiftCardAddVale.Name = "btnGiftCardAddVale"
        Me.btnGiftCardAddVale.Size = New System.Drawing.Size(71, 60)
        Me.btnGiftCardAddVale.TabIndex = 302
        Me.btnGiftCardAddVale.Text = "Gift Card Add Value "
        Me.btnGiftCardAddVale.UseVisualStyleBackColor = True
        '
        'btnCreditRefund
        '
        Me.btnCreditRefund.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCreditRefund.FlatAppearance.BorderSize = 0
        Me.btnCreditRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreditRefund.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditRefund.ForeColor = System.Drawing.Color.White
        Me.btnCreditRefund.Image = CType(resources.GetObject("btnCreditRefund.Image"), System.Drawing.Image)
        Me.btnCreditRefund.Location = New System.Drawing.Point(90, 58)
        Me.btnCreditRefund.Name = "btnCreditRefund"
        Me.btnCreditRefund.Size = New System.Drawing.Size(71, 60)
        Me.btnCreditRefund.TabIndex = 301
        Me.btnCreditRefund.Text = "Credit Refund"
        Me.btnCreditRefund.UseVisualStyleBackColor = True
        '
        'btnDebitRefund
        '
        Me.btnDebitRefund.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebitRefund.FlatAppearance.BorderSize = 0
        Me.btnDebitRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebitRefund.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebitRefund.ForeColor = System.Drawing.Color.White
        Me.btnDebitRefund.Image = CType(resources.GetObject("btnDebitRefund.Image"), System.Drawing.Image)
        Me.btnDebitRefund.Location = New System.Drawing.Point(262, 58)
        Me.btnDebitRefund.Name = "btnDebitRefund"
        Me.btnDebitRefund.Size = New System.Drawing.Size(71, 60)
        Me.btnDebitRefund.TabIndex = 300
        Me.btnDebitRefund.Text = "Debit Refund"
        Me.btnDebitRefund.UseVisualStyleBackColor = True
        '
        'btnDebitSale
        '
        Me.btnDebitSale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebitSale.FlatAppearance.BorderSize = 0
        Me.btnDebitSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebitSale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebitSale.ForeColor = System.Drawing.Color.White
        Me.btnDebitSale.Image = CType(resources.GetObject("btnDebitSale.Image"), System.Drawing.Image)
        Me.btnDebitSale.Location = New System.Drawing.Point(185, 58)
        Me.btnDebitSale.Name = "btnDebitSale"
        Me.btnDebitSale.Size = New System.Drawing.Size(71, 60)
        Me.btnDebitSale.TabIndex = 299
        Me.btnDebitSale.Text = "Debit  Sale"
        Me.btnDebitSale.UseVisualStyleBackColor = True
        '
        'btnCreditSale
        '
        Me.btnCreditSale.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCreditSale.FlatAppearance.BorderSize = 0
        Me.btnCreditSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreditSale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditSale.ForeColor = System.Drawing.Color.White
        Me.btnCreditSale.Image = CType(resources.GetObject("btnCreditSale.Image"), System.Drawing.Image)
        Me.btnCreditSale.Location = New System.Drawing.Point(9, 58)
        Me.btnCreditSale.Name = "btnCreditSale"
        Me.btnCreditSale.Size = New System.Drawing.Size(71, 60)
        Me.btnCreditSale.TabIndex = 298
        Me.btnCreditSale.Text = "Credit Sale"
        Me.btnCreditSale.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.cmbMerchantIDs)
        Me.groupBox2.Controls.Add(Me.btnInitialize)
        Me.groupBox2.Controls.Add(Me.lblSecureDevice)
        Me.groupBox2.Controls.Add(Me.cmbSecureDevices)
        Me.groupBox2.Controls.Add(Me.chkKeyedTransaction)
        Me.groupBox2.Controls.Add(Me.chkShowDialogs)
        Me.groupBox2.Controls.Add(Me.lblPadType)
        Me.groupBox2.Controls.Add(Me.nudRepsonseTimeout)
        Me.groupBox2.Controls.Add(Me.cmbPadTypes)
        Me.groupBox2.Controls.Add(Me.lblResponseTimeout)
        Me.groupBox2.Controls.Add(Me.lblComPort)
        Me.groupBox2.Controls.Add(Me.txtNETePayHostList)
        Me.groupBox2.Controls.Add(Me.nudComPort)
        Me.groupBox2.Controls.Add(Me.lblGIFTePayHostList)
        Me.groupBox2.Controls.Add(Me.nudConnectTimeout)
        Me.groupBox2.Controls.Add(Me.lblNETePayHostList)
        Me.groupBox2.Controls.Add(Me.txtGIFTePayHostList)
        Me.groupBox2.Controls.Add(Me.lblConnectTimeout)
        Me.groupBox2.Location = New System.Drawing.Point(12, 91)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(725, 143)
        Me.groupBox2.TabIndex = 307
        Me.groupBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(418, 54)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(69, 13)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Merchant  ID"
        '
        'cmbMerchantIDs
        '
        Me.cmbMerchantIDs.DropDownWidth = 150
        Me.cmbMerchantIDs.FormattingEnabled = True
        Me.cmbMerchantIDs.Location = New System.Drawing.Point(418, 70)
        Me.cmbMerchantIDs.Name = "cmbMerchantIDs"
        Me.cmbMerchantIDs.Size = New System.Drawing.Size(200, 21)
        Me.cmbMerchantIDs.TabIndex = 25
        '
        'btnInitialize
        '
        Me.btnInitialize.Location = New System.Drawing.Point(625, 108)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(94, 23)
        Me.btnInitialize.TabIndex = 2
        Me.btnInitialize.Text = "Initialize"
        Me.btnInitialize.UseVisualStyleBackColor = True
        '
        'lblSecureDevice
        '
        Me.lblSecureDevice.AutoSize = True
        Me.lblSecureDevice.Location = New System.Drawing.Point(6, 94)
        Me.lblSecureDevice.Name = "lblSecureDevice"
        Me.lblSecureDevice.Size = New System.Drawing.Size(78, 13)
        Me.lblSecureDevice.TabIndex = 0
        Me.lblSecureDevice.Text = "Secure Device"
        '
        'cmbSecureDevices
        '
        Me.cmbSecureDevices.DropDownWidth = 150
        Me.cmbSecureDevices.FormattingEnabled = True
        Me.cmbSecureDevices.Location = New System.Drawing.Point(6, 110)
        Me.cmbSecureDevices.Name = "cmbSecureDevices"
        Me.cmbSecureDevices.Size = New System.Drawing.Size(200, 21)
        Me.cmbSecureDevices.TabIndex = 1
        '
        'chkKeyedTransaction
        '
        Me.chkKeyedTransaction.AutoSize = True
        Me.chkKeyedTransaction.Location = New System.Drawing.Point(518, 35)
        Me.chkKeyedTransaction.Name = "chkKeyedTransaction"
        Me.chkKeyedTransaction.Size = New System.Drawing.Size(115, 17)
        Me.chkKeyedTransaction.TabIndex = 23
        Me.chkKeyedTransaction.Text = "Keyed Transaction"
        Me.chkKeyedTransaction.UseVisualStyleBackColor = True
        '
        'chkShowDialogs
        '
        Me.chkShowDialogs.AutoSize = True
        Me.chkShowDialogs.Location = New System.Drawing.Point(421, 34)
        Me.chkShowDialogs.Name = "chkShowDialogs"
        Me.chkShowDialogs.Size = New System.Drawing.Size(91, 17)
        Me.chkShowDialogs.TabIndex = 14
        Me.chkShowDialogs.Text = "Show Dialogs"
        Me.chkShowDialogs.UseVisualStyleBackColor = True
        '
        'lblPadType
        '
        Me.lblPadType.AutoSize = True
        Me.lblPadType.Location = New System.Drawing.Point(212, 94)
        Me.lblPadType.Name = "lblPadType"
        Me.lblPadType.Size = New System.Drawing.Size(53, 13)
        Me.lblPadType.TabIndex = 3
        Me.lblPadType.Text = "Pad Type"
        '
        'nudRepsonseTimeout
        '
        Me.nudRepsonseTimeout.Location = New System.Drawing.Point(212, 71)
        Me.nudRepsonseTimeout.Maximum = New Decimal(New Integer() {3900, 0, 0, 0})
        Me.nudRepsonseTimeout.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudRepsonseTimeout.Name = "nudRepsonseTimeout"
        Me.nudRepsonseTimeout.Size = New System.Drawing.Size(200, 20)
        Me.nudRepsonseTimeout.TabIndex = 13
        Me.nudRepsonseTimeout.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'cmbPadTypes
        '
        Me.cmbPadTypes.DropDownWidth = 150
        Me.cmbPadTypes.FormattingEnabled = True
        Me.cmbPadTypes.Location = New System.Drawing.Point(212, 110)
        Me.cmbPadTypes.Name = "cmbPadTypes"
        Me.cmbPadTypes.Size = New System.Drawing.Size(200, 21)
        Me.cmbPadTypes.TabIndex = 4
        '
        'lblResponseTimeout
        '
        Me.lblResponseTimeout.AutoSize = True
        Me.lblResponseTimeout.Location = New System.Drawing.Point(212, 55)
        Me.lblResponseTimeout.Name = "lblResponseTimeout"
        Me.lblResponseTimeout.Size = New System.Drawing.Size(96, 13)
        Me.lblResponseTimeout.TabIndex = 12
        Me.lblResponseTimeout.Text = "Response Timeout"
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(418, 94)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(50, 13)
        Me.lblComPort.TabIndex = 5
        Me.lblComPort.Text = "Com Port"
        '
        'txtNETePayHostList
        '
        Me.txtNETePayHostList.Location = New System.Drawing.Point(6, 32)
        Me.txtNETePayHostList.Name = "txtNETePayHostList"
        Me.txtNETePayHostList.Size = New System.Drawing.Size(200, 20)
        Me.txtNETePayHostList.TabIndex = 17
        '
        'nudComPort
        '
        Me.nudComPort.Location = New System.Drawing.Point(418, 110)
        Me.nudComPort.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudComPort.Name = "nudComPort"
        Me.nudComPort.Size = New System.Drawing.Size(200, 20)
        Me.nudComPort.TabIndex = 6
        '
        'lblGIFTePayHostList
        '
        Me.lblGIFTePayHostList.AutoSize = True
        Me.lblGIFTePayHostList.Location = New System.Drawing.Point(213, 16)
        Me.lblGIFTePayHostList.Name = "lblGIFTePayHostList"
        Me.lblGIFTePayHostList.Size = New System.Drawing.Size(99, 13)
        Me.lblGIFTePayHostList.TabIndex = 19
        Me.lblGIFTePayHostList.Text = "GIFTePay Host List"
        '
        'nudConnectTimeout
        '
        Me.nudConnectTimeout.Location = New System.Drawing.Point(6, 71)
        Me.nudConnectTimeout.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudConnectTimeout.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudConnectTimeout.Name = "nudConnectTimeout"
        Me.nudConnectTimeout.Size = New System.Drawing.Size(200, 20)
        Me.nudConnectTimeout.TabIndex = 11
        Me.nudConnectTimeout.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblNETePayHostList
        '
        Me.lblNETePayHostList.AutoSize = True
        Me.lblNETePayHostList.Location = New System.Drawing.Point(6, 16)
        Me.lblNETePayHostList.Name = "lblNETePayHostList"
        Me.lblNETePayHostList.Size = New System.Drawing.Size(97, 13)
        Me.lblNETePayHostList.TabIndex = 16
        Me.lblNETePayHostList.Text = "NETePay Host List"
        '
        'txtGIFTePayHostList
        '
        Me.txtGIFTePayHostList.Location = New System.Drawing.Point(212, 32)
        Me.txtGIFTePayHostList.Name = "txtGIFTePayHostList"
        Me.txtGIFTePayHostList.Size = New System.Drawing.Size(200, 20)
        Me.txtGIFTePayHostList.TabIndex = 18
        '
        'lblConnectTimeout
        '
        Me.lblConnectTimeout.AutoSize = True
        Me.lblConnectTimeout.Location = New System.Drawing.Point(6, 55)
        Me.lblConnectTimeout.Name = "lblConnectTimeout"
        Me.lblConnectTimeout.Size = New System.Drawing.Size(88, 13)
        Me.lblConnectTimeout.TabIndex = 10
        Me.lblConnectTimeout.Text = "Connect Timeout"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCreditSaleThenCreditVoidSaleByRecordNo)
        Me.GroupBox1.Controls.Add(Me.lblMemo)
        Me.GroupBox1.Controls.Add(Me.txtMemo)
        Me.GroupBox1.Controls.Add(Me.lblPurchase)
        Me.GroupBox1.Controls.Add(Me.btnGiftCardRefund)
        Me.GroupBox1.Controls.Add(Me.btnGiftCardSale)
        Me.GroupBox1.Controls.Add(Me.nudPurchase)
        Me.GroupBox1.Controls.Add(Me.btnGiftCardBalance)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.btnGiftCardAddVale)
        Me.GroupBox1.Controls.Add(Me.lblOperatorID)
        Me.GroupBox1.Controls.Add(Me.lblInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.txtOperatorID)
        Me.GroupBox1.Controls.Add(Me.btnDebitRefund)
        Me.GroupBox1.Controls.Add(Me.btnCreditRefund)
        Me.GroupBox1.Controls.Add(Me.btnCreditSale)
        Me.GroupBox1.Controls.Add(Me.btnDebitSale)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 184)
        Me.GroupBox1.TabIndex = 308
        Me.GroupBox1.TabStop = False
        '
        'btnCreditSaleThenCreditVoidSaleByRecordNo
        '
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo.Location = New System.Drawing.Point(9, 124)
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo.Name = "btnCreditSaleThenCreditVoidSaleByRecordNo"
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo.Size = New System.Drawing.Size(152, 54)
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo.TabIndex = 307
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo.Text = "Credit Sale" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Credit VoidSaleByRecordNo"
        Me.btnCreditSaleThenCreditVoidSaleByRecordNo.UseVisualStyleBackColor = True
        '
        'lblMemo
        '
        Me.lblMemo.AutoSize = True
        Me.lblMemo.Location = New System.Drawing.Point(540, 16)
        Me.lblMemo.Name = "lblMemo"
        Me.lblMemo.Size = New System.Drawing.Size(36, 13)
        Me.lblMemo.TabIndex = 306
        Me.lblMemo.Text = "Memo"
        '
        'txtMemo
        '
        Me.txtMemo.Location = New System.Drawing.Point(543, 32)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(173, 20)
        Me.txtMemo.TabIndex = 28
        '
        'lblPurchase
        '
        Me.lblPurchase.AutoSize = True
        Me.lblPurchase.Location = New System.Drawing.Point(3, 16)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(52, 13)
        Me.lblPurchase.TabIndex = 26
        Me.lblPurchase.Text = "Purchase"
        '
        'nudPurchase
        '
        Me.nudPurchase.DecimalPlaces = 2
        Me.nudPurchase.Location = New System.Drawing.Point(6, 32)
        Me.nudPurchase.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPurchase.Name = "nudPurchase"
        Me.nudPurchase.Size = New System.Drawing.Size(173, 20)
        Me.nudPurchase.TabIndex = 27
        Me.nudPurchase.Value = New Decimal(New Integer() {125, 0, 0, 131072})
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(185, 32)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(173, 20)
        Me.txtInvoiceNo.TabIndex = 17
        '
        'lblOperatorID
        '
        Me.lblOperatorID.AutoSize = True
        Me.lblOperatorID.Location = New System.Drawing.Point(361, 16)
        Me.lblOperatorID.Name = "lblOperatorID"
        Me.lblOperatorID.Size = New System.Drawing.Size(59, 13)
        Me.lblOperatorID.TabIndex = 19
        Me.lblOperatorID.Text = "OperatorID"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(182, 16)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(56, 13)
        Me.lblInvoiceNo.TabIndex = 16
        Me.lblInvoiceNo.Text = "InvoiceNo"
        '
        'txtOperatorID
        '
        Me.txtOperatorID.Location = New System.Drawing.Point(364, 32)
        Me.txtOperatorID.Name = "txtOperatorID"
        Me.txtOperatorID.Size = New System.Drawing.Size(173, 20)
        Me.txtOperatorID.TabIndex = 18
        '
        'lblDownloadAndInstall
        '
        Me.lblDownloadAndInstall.AutoSize = True
        Me.lblDownloadAndInstall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloadAndInstall.Location = New System.Drawing.Point(8, 29)
        Me.lblDownloadAndInstall.Name = "lblDownloadAndInstall"
        Me.lblDownloadAndInstall.Size = New System.Drawing.Size(342, 20)
        Me.lblDownloadAndInstall.TabIndex = 309
        Me.lblDownloadAndInstall.Text = "Download and Install dsiPDCX Active X Control"
        '
        'lnkPDCXDownload
        '
        Me.lnkPDCXDownload.AutoSize = True
        Me.lnkPDCXDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkPDCXDownload.Location = New System.Drawing.Point(356, 29)
        Me.lnkPDCXDownload.Name = "lnkPDCXDownload"
        Me.lnkPDCXDownload.Size = New System.Drawing.Size(300, 20)
        Me.lnkPDCXDownload.TabIndex = 310
        Me.lnkPDCXDownload.TabStop = True
        Me.lnkPDCXDownload.Text = "http://www.datacapepay.com/dsipdcx.htm"
        '
        'lblPrerequisite
        '
        Me.lblPrerequisite.AutoSize = True
        Me.lblPrerequisite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrerequisite.Location = New System.Drawing.Point(8, 9)
        Me.lblPrerequisite.Name = "lblPrerequisite"
        Me.lblPrerequisite.Size = New System.Drawing.Size(105, 20)
        Me.lblPrerequisite.TabIndex = 311
        Me.lblPrerequisite.Text = "Prerequisite"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(503, 20)
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "Step 1: Initialize Payment Device Once on Application Startup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(457, 20)
        Me.Label3.TabIndex = 313
        Me.Label3.Text = "Step 2: Process Payment with dsiPDCX Active X Control"
        '
        'rtbParsedResponse
        '
        Me.rtbParsedResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbParsedResponse.Location = New System.Drawing.Point(743, 32)
        Me.rtbParsedResponse.Name = "rtbParsedResponse"
        Me.rtbParsedResponse.Size = New System.Drawing.Size(197, 372)
        Me.rtbParsedResponse.TabIndex = 314
        Me.rtbParsedResponse.Text = ""
        Me.rtbParsedResponse.WordWrap = False
        '
        'lblParsedResponse
        '
        Me.lblParsedResponse.AutoSize = True
        Me.lblParsedResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParsedResponse.Location = New System.Drawing.Point(739, 9)
        Me.lblParsedResponse.Name = "lblParsedResponse"
        Me.lblParsedResponse.Size = New System.Drawing.Size(151, 20)
        Me.lblParsedResponse.TabIndex = 315
        Me.lblParsedResponse.Text = "Parsed Response"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(952, 474)
        Me.Controls.Add(Me.lblParsedResponse)
        Me.Controls.Add(Me.rtbParsedResponse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPrerequisite)
        Me.Controls.Add(Me.lnkPDCXDownload)
        Me.Controls.Add(Me.lblDownloadAndInstall)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Mercury PDCX Prototype for Alexandria Computers"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.nudRepsonseTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConnectTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGiftCardRefund As System.Windows.Forms.Button
    Friend WithEvents btnGiftCardSale As System.Windows.Forms.Button
    Friend WithEvents btnGiftCardBalance As System.Windows.Forms.Button
    Friend WithEvents btnGiftCardAddVale As System.Windows.Forms.Button
    Friend WithEvents btnCreditRefund As System.Windows.Forms.Button
    Friend WithEvents btnDebitRefund As System.Windows.Forms.Button
    Friend WithEvents btnDebitSale As System.Windows.Forms.Button
    Friend WithEvents btnCreditSale As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmbMerchantIDs As System.Windows.Forms.ComboBox
    Private WithEvents btnInitialize As System.Windows.Forms.Button
    Private WithEvents lblSecureDevice As System.Windows.Forms.Label
    Private WithEvents cmbSecureDevices As System.Windows.Forms.ComboBox
    Private WithEvents chkKeyedTransaction As System.Windows.Forms.CheckBox
    Private WithEvents chkShowDialogs As System.Windows.Forms.CheckBox
    Private WithEvents lblPadType As System.Windows.Forms.Label
    Private WithEvents nudRepsonseTimeout As System.Windows.Forms.NumericUpDown
    Private WithEvents cmbPadTypes As System.Windows.Forms.ComboBox
    Private WithEvents lblResponseTimeout As System.Windows.Forms.Label
    Private WithEvents lblComPort As System.Windows.Forms.Label
    Private WithEvents txtNETePayHostList As System.Windows.Forms.TextBox
    Private WithEvents nudComPort As System.Windows.Forms.NumericUpDown
    Private WithEvents lblGIFTePayHostList As System.Windows.Forms.Label
    Private WithEvents nudConnectTimeout As System.Windows.Forms.NumericUpDown
    Private WithEvents lblNETePayHostList As System.Windows.Forms.Label
    Private WithEvents txtGIFTePayHostList As System.Windows.Forms.TextBox
    Private WithEvents lblConnectTimeout As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblMemo As System.Windows.Forms.Label
    Private WithEvents txtMemo As System.Windows.Forms.TextBox
    Private WithEvents lblPurchase As System.Windows.Forms.Label
    Private WithEvents nudPurchase As System.Windows.Forms.NumericUpDown
    Private WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Private WithEvents lblOperatorID As System.Windows.Forms.Label
    Private WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Private WithEvents txtOperatorID As System.Windows.Forms.TextBox
    Friend WithEvents lblDownloadAndInstall As System.Windows.Forms.Label
    Friend WithEvents lnkPDCXDownload As System.Windows.Forms.LinkLabel
    Friend WithEvents lblPrerequisite As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbParsedResponse As System.Windows.Forms.RichTextBox
    Friend WithEvents lblParsedResponse As System.Windows.Forms.Label
    Friend WithEvents btnCreditSaleThenCreditVoidSaleByRecordNo As System.Windows.Forms.Button

End Class
