<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_Settings))
        Me.grb_UniversalSerialOutput1 = New System.Windows.Forms.GroupBox()
        Me.rad_Hex = New System.Windows.Forms.RadioButton()
        Me.rad_Decimal = New System.Windows.Forms.RadioButton()
        Me.rad_Binary = New System.Windows.Forms.RadioButton()
        Me.cb_OutputBits = New System.Windows.Forms.ComboBox()
        Me.txt_InterfaceOutput = New System.Windows.Forms.TextBox()
        Me.txt_ShutDownOutput = New System.Windows.Forms.TextBox()
        Me.txt_StartUpOutput = New System.Windows.Forms.TextBox()
        Me.cb_StopMS = New System.Windows.Forms.ComboBox()
        Me.cb_StartMS = New System.Windows.Forms.ComboBox()
        Me.cb_PacketRate = New System.Windows.Forms.ComboBox()
        Me.cb_StopBits = New System.Windows.Forms.ComboBox()
        Me.cb_Parity = New System.Windows.Forms.ComboBox()
        Me.cb_DateBits = New System.Windows.Forms.ComboBox()
        Me.cb_BPS = New System.Windows.Forms.ComboBox()
        Me.cb_ComPort = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.grb_UniversalSerialOutput1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_UniversalSerialOutput1
        '
        Me.grb_UniversalSerialOutput1.BackColor = System.Drawing.Color.Transparent
        Me.grb_UniversalSerialOutput1.BackgroundImage = CType(resources.GetObject("grb_UniversalSerialOutput1.BackgroundImage"), System.Drawing.Image)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.rad_Hex)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.rad_Decimal)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.rad_Binary)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_OutputBits)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.txt_InterfaceOutput)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.txt_ShutDownOutput)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.txt_StartUpOutput)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_StopMS)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_StartMS)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_PacketRate)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_StopBits)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_Parity)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_DateBits)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_BPS)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.cb_ComPort)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label20)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label19)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label18)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.btn_Save)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label17)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label16)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label60)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label53)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label52)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label51)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label50)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label48)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label49)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label46)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label47)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label44)
        Me.grb_UniversalSerialOutput1.Controls.Add(Me.Label45)
        Me.grb_UniversalSerialOutput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.grb_UniversalSerialOutput1.ForeColor = System.Drawing.SystemColors.Control
        Me.grb_UniversalSerialOutput1.Location = New System.Drawing.Point(0, 0)
        Me.grb_UniversalSerialOutput1.Name = "grb_UniversalSerialOutput1"
        Me.grb_UniversalSerialOutput1.Size = New System.Drawing.Size(523, 235)
        Me.grb_UniversalSerialOutput1.TabIndex = 300
        Me.grb_UniversalSerialOutput1.TabStop = False
        Me.grb_UniversalSerialOutput1.Text = "Serial Output"
        '
        'rad_Hex
        '
        Me.rad_Hex.AutoSize = True
        Me.rad_Hex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rad_Hex.Location = New System.Drawing.Point(462, 100)
        Me.rad_Hex.Name = "rad_Hex"
        Me.rad_Hex.Size = New System.Drawing.Size(44, 17)
        Me.rad_Hex.TabIndex = 253
        Me.rad_Hex.Text = "Hex"
        Me.rad_Hex.UseVisualStyleBackColor = True
        '
        'rad_Decimal
        '
        Me.rad_Decimal.AutoSize = True
        Me.rad_Decimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rad_Decimal.Location = New System.Drawing.Point(396, 100)
        Me.rad_Decimal.Name = "rad_Decimal"
        Me.rad_Decimal.Size = New System.Drawing.Size(63, 17)
        Me.rad_Decimal.TabIndex = 252
        Me.rad_Decimal.Text = "Decimal"
        Me.rad_Decimal.UseVisualStyleBackColor = True
        '
        'rad_Binary
        '
        Me.rad_Binary.AutoSize = True
        Me.rad_Binary.Checked = True
        Me.rad_Binary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rad_Binary.Location = New System.Drawing.Point(341, 100)
        Me.rad_Binary.Name = "rad_Binary"
        Me.rad_Binary.Size = New System.Drawing.Size(54, 17)
        Me.rad_Binary.TabIndex = 251
        Me.rad_Binary.TabStop = True
        Me.rad_Binary.Text = "Binary"
        Me.rad_Binary.UseVisualStyleBackColor = True
        '
        'cb_OutputBits
        '
        Me.cb_OutputBits.BackColor = System.Drawing.SystemColors.Window
        Me.cb_OutputBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_OutputBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_OutputBits.FormattingEnabled = True
        Me.cb_OutputBits.Items.AddRange(New Object() {"-", "0", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32"})
        Me.cb_OutputBits.Location = New System.Drawing.Point(187, 97)
        Me.cb_OutputBits.MaxDropDownItems = 25
        Me.cb_OutputBits.Name = "cb_OutputBits"
        Me.cb_OutputBits.Size = New System.Drawing.Size(64, 21)
        Me.cb_OutputBits.TabIndex = 248
        Me.cb_OutputBits.TabStop = False
        '
        'txt_InterfaceOutput
        '
        Me.txt_InterfaceOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txt_InterfaceOutput.Location = New System.Drawing.Point(110, 172)
        Me.txt_InterfaceOutput.Name = "txt_InterfaceOutput"
        Me.txt_InterfaceOutput.Size = New System.Drawing.Size(251, 20)
        Me.txt_InterfaceOutput.TabIndex = 262
        Me.txt_InterfaceOutput.TabStop = False
        '
        'txt_ShutDownOutput
        '
        Me.txt_ShutDownOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txt_ShutDownOutput.Location = New System.Drawing.Point(110, 201)
        Me.txt_ShutDownOutput.Name = "txt_ShutDownOutput"
        Me.txt_ShutDownOutput.Size = New System.Drawing.Size(251, 20)
        Me.txt_ShutDownOutput.TabIndex = 261
        Me.txt_ShutDownOutput.TabStop = False
        '
        'txt_StartUpOutput
        '
        Me.txt_StartUpOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txt_StartUpOutput.Location = New System.Drawing.Point(110, 143)
        Me.txt_StartUpOutput.Name = "txt_StartUpOutput"
        Me.txt_StartUpOutput.Size = New System.Drawing.Size(251, 20)
        Me.txt_StartUpOutput.TabIndex = 260
        Me.txt_StartUpOutput.TabStop = False
        '
        'cb_StopMS
        '
        Me.cb_StopMS.BackColor = System.Drawing.SystemColors.Window
        Me.cb_StopMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_StopMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_StopMS.FormattingEnabled = True
        Me.cb_StopMS.IntegralHeight = False
        Me.cb_StopMS.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "100", "250", "500", "1000", "1800", "2600", "3400", "4200", "5000"})
        Me.cb_StopMS.Location = New System.Drawing.Point(370, 201)
        Me.cb_StopMS.MaxDropDownItems = 10
        Me.cb_StopMS.Name = "cb_StopMS"
        Me.cb_StopMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cb_StopMS.Size = New System.Drawing.Size(47, 21)
        Me.cb_StopMS.TabIndex = 257
        Me.cb_StopMS.TabStop = False
        '
        'cb_StartMS
        '
        Me.cb_StartMS.BackColor = System.Drawing.SystemColors.Window
        Me.cb_StartMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_StartMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_StartMS.FormattingEnabled = True
        Me.cb_StartMS.IntegralHeight = False
        Me.cb_StartMS.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "100", "250", "500", "1000", "1800", "2600", "3400", "4200", "5000"})
        Me.cb_StartMS.Location = New System.Drawing.Point(370, 142)
        Me.cb_StartMS.MaxDropDownItems = 10
        Me.cb_StartMS.Name = "cb_StartMS"
        Me.cb_StartMS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cb_StartMS.Size = New System.Drawing.Size(47, 21)
        Me.cb_StartMS.TabIndex = 254
        Me.cb_StartMS.TabStop = False
        '
        'cb_PacketRate
        '
        Me.cb_PacketRate.BackColor = System.Drawing.SystemColors.Window
        Me.cb_PacketRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_PacketRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_PacketRate.FormattingEnabled = True
        Me.cb_PacketRate.IntegralHeight = False
        Me.cb_PacketRate.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.cb_PacketRate.Location = New System.Drawing.Point(370, 172)
        Me.cb_PacketRate.MaxDropDownItems = 10
        Me.cb_PacketRate.Name = "cb_PacketRate"
        Me.cb_PacketRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cb_PacketRate.Size = New System.Drawing.Size(47, 21)
        Me.cb_PacketRate.TabIndex = 245
        Me.cb_PacketRate.TabStop = False
        '
        'cb_StopBits
        '
        Me.cb_StopBits.BackColor = System.Drawing.SystemColors.Window
        Me.cb_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_StopBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_StopBits.FormattingEnabled = True
        Me.cb_StopBits.Items.AddRange(New Object() {"-", "1", "1.5 ", "2"})
        Me.cb_StopBits.Location = New System.Drawing.Point(424, 52)
        Me.cb_StopBits.MaxDropDownItems = 25
        Me.cb_StopBits.Name = "cb_StopBits"
        Me.cb_StopBits.Size = New System.Drawing.Size(85, 21)
        Me.cb_StopBits.TabIndex = 250
        Me.cb_StopBits.TabStop = False
        '
        'cb_Parity
        '
        Me.cb_Parity.AutoCompleteCustomSource.AddRange(New String() {"Even", "Odd", "None", "Mark", "Space"})
        Me.cb_Parity.BackColor = System.Drawing.SystemColors.Window
        Me.cb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Parity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_Parity.FormattingEnabled = True
        Me.cb_Parity.Items.AddRange(New Object() {"-", "Even", "Odd", "None", "Mark", "Space"})
        Me.cb_Parity.Location = New System.Drawing.Point(331, 52)
        Me.cb_Parity.MaxDropDownItems = 25
        Me.cb_Parity.Name = "cb_Parity"
        Me.cb_Parity.Size = New System.Drawing.Size(85, 21)
        Me.cb_Parity.TabIndex = 249
        Me.cb_Parity.TabStop = False
        '
        'cb_DateBits
        '
        Me.cb_DateBits.AutoCompleteCustomSource.AddRange(New String() {"4", "5", "6", "7", "8"})
        Me.cb_DateBits.BackColor = System.Drawing.SystemColors.Window
        Me.cb_DateBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_DateBits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_DateBits.FormattingEnabled = True
        Me.cb_DateBits.Items.AddRange(New Object() {"-", "7", "8"})
        Me.cb_DateBits.Location = New System.Drawing.Point(272, 52)
        Me.cb_DateBits.MaxDropDownItems = 25
        Me.cb_DateBits.Name = "cb_DateBits"
        Me.cb_DateBits.Size = New System.Drawing.Size(51, 21)
        Me.cb_DateBits.TabIndex = 244
        Me.cb_DateBits.TabStop = False
        '
        'cb_BPS
        '
        Me.cb_BPS.BackColor = System.Drawing.SystemColors.Window
        Me.cb_BPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_BPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_BPS.FormattingEnabled = True
        Me.cb_BPS.Items.AddRange(New Object() {"-", "9600", "14400", "19200", "28800", "31250", "38400", "57600", "115200", "230400", "250000", "460800", "500000", "921600"})
        Me.cb_BPS.Location = New System.Drawing.Point(186, 52)
        Me.cb_BPS.MaxDropDownItems = 25
        Me.cb_BPS.Name = "cb_BPS"
        Me.cb_BPS.Size = New System.Drawing.Size(78, 21)
        Me.cb_BPS.TabIndex = 243
        Me.cb_BPS.TabStop = False
        '
        'cb_ComPort
        '
        Me.cb_ComPort.BackColor = System.Drawing.SystemColors.Window
        Me.cb_ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ComPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cb_ComPort.FormattingEnabled = True
        Me.cb_ComPort.Items.AddRange(New Object() {"-"})
        Me.cb_ComPort.Location = New System.Drawing.Point(107, 52)
        Me.cb_ComPort.MaxDropDownItems = 25
        Me.cb_ComPort.Name = "cb_ComPort"
        Me.cb_ComPort.Size = New System.Drawing.Size(71, 21)
        Me.cb_ComPort.TabIndex = 242
        Me.cb_ComPort.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(442, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 271
        Me.Label20.Text = "Stop Bits"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(357, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 270
        Me.Label19.Text = "Parity"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(272, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 269
        Me.Label18.Text = "Data Bits"
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.Black
        Me.btn_Save.Location = New System.Drawing.Point(12, 31)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(60, 35)
        Me.btn_Save.TabIndex = 156
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(196, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 268
        Me.Label17.Text = "BitsPerSec"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(119, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 267
        Me.Label16.Text = "ComPort"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(264, 102)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(72, 13)
        Me.Label60.TabIndex = 266
        Me.Label60.Text = "Output - Type"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(87, 102)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(95, 13)
        Me.Label53.TabIndex = 265
        Me.Label53.Text = "Output - Bit Range"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(9, 204)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(96, 13)
        Me.Label52.TabIndex = 264
        Me.Label52.Text = "Shutdown - Output"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(9, 175)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(90, 13)
        Me.Label51.TabIndex = 263
        Me.Label51.Text = "Interface - Output"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(9, 146)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(82, 13)
        Me.Label50.TabIndex = 158
        Me.Label50.Text = "Startup - Output"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(418, 205)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(20, 13)
        Me.Label48.TabIndex = 259
        Me.Label48.Text = "ms"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(446, 205)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(51, 13)
        Me.Label49.TabIndex = 258
        Me.Label49.Text = "HW Stop"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(418, 146)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(20, 13)
        Me.Label46.TabIndex = 256
        Me.Label46.Text = "ms"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(446, 146)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(51, 13)
        Me.Label47.TabIndex = 255
        Me.Label47.Text = "HW Start"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(418, 176)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(20, 13)
        Me.Label44.TabIndex = 247
        Me.Label44.Text = "ms"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(446, 176)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(65, 13)
        Me.Label45.TabIndex = 246
        Me.Label45.Text = "Output Rate"
        '
        'UserControl_Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.grb_UniversalSerialOutput1)
        Me.Name = "UserControl_Settings"
        Me.Size = New System.Drawing.Size(523, 235)
        Me.grb_UniversalSerialOutput1.ResumeLayout(False)
        Me.grb_UniversalSerialOutput1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_UniversalSerialOutput1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_InterfaceOutput As System.Windows.Forms.TextBox
    Friend WithEvents txt_ShutDownOutput As System.Windows.Forms.TextBox
    Friend WithEvents txt_StartUpOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cb_StopMS As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cb_StartMS As System.Windows.Forms.ComboBox
    Friend WithEvents rad_Hex As System.Windows.Forms.RadioButton
    Friend WithEvents rad_Decimal As System.Windows.Forms.RadioButton
    Friend WithEvents rad_Binary As System.Windows.Forms.RadioButton
    Friend WithEvents cb_StopBits As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Parity As System.Windows.Forms.ComboBox
    Friend WithEvents cb_OutputBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cb_PacketRate As System.Windows.Forms.ComboBox
    Friend WithEvents cb_DateBits As System.Windows.Forms.ComboBox
    Friend WithEvents cb_BPS As System.Windows.Forms.ComboBox
    Friend WithEvents cb_ComPort As System.Windows.Forms.ComboBox

End Class
