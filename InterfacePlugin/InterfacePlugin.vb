Option Strict On
Option Explicit On

Imports Interface_PluginAPI
Imports System.IO.Ports

Public Class InterfacePlugin
    Implements IPlugin_Interface
    Private _SavePath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\SimTools\GameEngine\"
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///        SimTools Interface Plugin - Edit the Settings below to provide support for your favorite Interface!                        ///
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////
    '///         Per Interface Settings - Change for Each Interface           ///
    '////////////////////////////////////////////////////////////////////////////
    Private Const _PluginAuthorsName As String = "yobuddy" 'Authors Name Here
    Public Const _InterfaceName As String = "Serial" 'Full Name of the Interface (Don't use the word 'Interface' in the name please)
    Public Const _Requires_Restart As Boolean = False 'Does this plugin require a restart with New / Removed settings
    '/////////////////////////////////////////////////////////////////////////////
    '///     What Interfaces SimTools will make this Plugin Available for      ///
    '/////////////////////////////////////////////////////////////////////////////
    Private Const _Enable_Interface1 As Boolean = True
    Private Const _Enable_Interface2 As Boolean = True
    Private Const _Enable_Interface3 As Boolean = True
    Private Const _Enable_Interface4 As Boolean = True
    Private Const _Enable_Interface5 As Boolean = True
    Private Const _Enable_Interface6 As Boolean = True
    '///////////////////////////////////////////////////////////////////////////////
    '///    The Interface Settings Structure - Edit the Elements as Needed       ///
    '///////////////////////////////////////////////////////////////////////////////
    Structure InterfaceAssignments
        Public _ComPort As String
        Public _BitsPerSec As Integer
        Public _DataBits As Integer
        Public _ParityBits As String
        Public _StopBits As String
        Public _OutputBits As String
        Public _OutputType As String
        Public _StartupOutput As String
        Public _HWStartMS As Integer
        Public _InterfaceOutput As String
        Public _ShutdownOutput As String
        Public _HWStopMS As Integer
        Public _OutPutRateMS As Integer '(Required - Do Not Change) - this is the 'OutputRate' var that is returned to SimTools
    End Structure

    '///////////////////////////////////////////////////////////////////////////////
    '///                     Edit these 6 Subroutines Below                      ///
    '///////////////////////////////////////////////////////////////////////////////
    'Used by GameEngine when the program starts up.
    Private Sub StartUp()
        'all startup commands here

        'Load the Output Char's - used to get the CHAR's for 0 thru 255 - makes output faster
        LoadAsciiCodes()

        'Load Com Ports
        SetSerialPortNames()
    End Sub

    'Used by GameEngine when the program is shutting down / switching plugins.
    Public Sub ShutDown() Implements Interface_PluginAPI.IPlugin_Interface.ShutDown
        'all shutdown / cleanup commands here      
    End Sub

    'Used by GameEngine (after startup above for all 6 interfaces) (all 6 interfaces can Initialize at the same time).
    Public Sub Initialize()
        'If Needed Initialize - Interface here (centering routine - mainly used for optical systems)       
    End Sub

    'Used by GameEngine when the Game Starts.    
    Public Function GameStart() As Boolean
        Try
            'Fix Output Strings - <ascii codes from number> - get ascii numbers
            StartupOutput = ReplaceWithAsciiCode(MyForm._InterfaceSettings._StartupOutput)
            InterfaceOutput = ReplaceWithAsciiCode(MyForm._InterfaceSettings._InterfaceOutput)
            ShutdownOutput = ReplaceWithAsciiCode(MyForm._InterfaceSettings._ShutdownOutput)

            'COM Port Assignments - set assignments to the com port
            Interface1_ComWorker.PortName = MyForm._InterfaceSettings._ComPort
            Interface1_ComWorker.BaudRate = CStr(MyForm._InterfaceSettings._BitsPerSec)
            Interface1_ComWorker.DataBits = CStr(MyForm._InterfaceSettings._DataBits)
            Interface1_ComWorker.Parity = MyForm._InterfaceSettings._ParityBits
            Interface1_ComWorker.StopBits = MyForm._InterfaceSettings._StopBits

            'See if it opens
            If Interface1_ComWorker.OpenPort = True Then
                'Startup
                bytCommand = Text.Encoding.Default.GetBytes(StartupOutput)
                If StartupOutput <> "" Then
                    Interface1_ComWorker.WriteData(StartupOutput)
                End If
                Threading.Thread.Sleep(MyForm._InterfaceSettings._HWStartMS)

                'pause for external app to get data
                System.Threading.Thread.Sleep(100)

                'Set Output Types Needed to speed up GameSend
                OutputBits = MyForm._InterfaceSettings._OutputBits
                OutputType = MyForm._InterfaceSettings._OutputType

                'Set Output String
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Used by GameEngine to send values to the Interface.
    Public Sub Game_SendValues(Axis1a As Double, Axis2a As Double, Axis3a As Double, Axis4a As Double, Axis5a As Double, Axis6a As Double, Axis1b As Double, Axis2b As Double, Axis3b As Double, Axis4b As Double, Axis5b As Double, Axis6b As Double) Implements Interface_PluginAPI.IPlugin_Interface.Game_SendValues
        Final_Output = InterfaceOutput
        If Final_Output.Contains("<Axis1a>") = True Then
            Dim FinalOut As String = GetOutPut(Axis1a, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis1a>", FinalOut)
        End If
        If Final_Output.Contains("<Axis2a>") = True Then
            Dim FinalOut As String = GetOutPut(Axis2a, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis2a>", FinalOut)
        End If
        If Final_Output.Contains("<Axis3a>") = True Then
            Dim FinalOut As String = GetOutPut(Axis3a, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis3a>", FinalOut)
        End If
        If Final_Output.Contains("<Axis4a>") = True Then
            Dim FinalOut As String = GetOutPut(Axis4a, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis4a>", FinalOut)
        End If
        If Final_Output.Contains("<Axis5a>") = True Then
            Dim FinalOut As String = GetOutPut(Axis5a, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis5a>", FinalOut)
        End If
        If Final_Output.Contains("<Axis6a>") = True Then
            Dim FinalOut As String = GetOutPut(Axis6a, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis6a>", FinalOut)
        End If
        If Final_Output.Contains("<Axis1b>") = True Then
            Dim FinalOut As String = GetOutPut(Axis1b, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis1b>", FinalOut)
        End If
        If Final_Output.Contains("<Axis2b>") = True Then
            Dim FinalOut As String = GetOutPut(Axis2b, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis2b>", FinalOut)
        End If
        If Final_Output.Contains("<Axis3b>") = True Then
            Dim FinalOut As String = GetOutPut(Axis3b, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis3b>", FinalOut)
        End If
        If Final_Output.Contains("<Axis4b>") = True Then
            Dim FinalOut As String = GetOutPut(Axis4b, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis4b>", FinalOut)
        End If
        If Final_Output.Contains("<Axis5b>") = True Then
            Dim FinalOut As String = GetOutPut(Axis5b, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis5b>", FinalOut)
        End If
        If Final_Output.Contains("<Axis6b>") = True Then
            Dim FinalOut As String = GetOutPut(Axis6b, OutputBits, OutputType)
            Final_Output = Final_Output.Replace("<Axis6b>", FinalOut)
        End If

        'Send Output
        'Output & Chr(13)
        Interface1_ComWorker.WriteData(Final_Output)
    End Sub

    'Used by GameEngine when the Game Stops.
    Public Sub GameStop()
        'Shutdown
        Threading.Thread.Sleep(MyForm._InterfaceSettings._HWStopMS)
        bytCommand = Text.Encoding.Default.GetBytes(ShutdownOutput)
        If ShutdownOutput <> "" Then
            Interface1_ComWorker.WriteData(ShutdownOutput)
        End If
        Interface1_ComWorker.ClosePort()
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///                                                 PLACE EXTRA NEEDED CODE/FUNCTIONS HERE                                                     ///
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#Region "Extra Code Needed for this interface"
    Private Interface1_ComWorker As New ComWorker
    Private OutputBits As String = ""
    Private OutputType As String = ""
    Private Final_Output As String = ""
    Private StartupOutput As String
    Private InterfaceOutput As String
    Private ShutdownOutput As String
    Private bytCommand As Byte()

    'Set Serial Port Names to drop down box
    Public Sub SetSerialPortNames()
        ' Get a list of serial port names. 
        Dim ports As String() = System.IO.Ports.SerialPort.GetPortNames()
        ' Display each port name to the console. 
        Dim port As String
        For Each port In ports
            MyForm.cb_ComPort.Items.Add(port)
        Next port
    End Sub

    'Replaces output strings in a < # > with a chr - example <63> = ?
    Public Function ReplaceWithAsciiCode(ByVal InputString As String) As String
        If InputString = "-" Or InputString = "" Then
            Return InputString
        End If
        For x = 0 To 255
            Dim SearchString As String = ("<" & x.ToString & ">").ToString
            If InputString.Contains(SearchString) Then
                Dim ReplaceString As String = (Chr(x)).ToString
                InputString = InputString.Replace(SearchString, ReplaceString)
            End If
        Next
        Return InputString
    End Function

    'Chr ouput characters
    Private AsciiCodes As New ArrayList
    Private enc As Text.Encoding = System.Text.Encoding.GetEncoding(1252) 'force USA mode to get all char's needed NEW
    'load CHR codes for faster output
    Private Sub LoadAsciiCodes()
        AsciiCodes.Clear()
        For x = 0 To 255
            'AsciiCodes.Add(Chr(x)) Old Way
            AsciiCodes.Add(enc.GetString(New Byte() {CByte(x)})) 'NEW
        Next
    End Sub

    'Returns the final output scaled to BitsNeeded and with Type
    Private Function GetOutPut(ByVal InputPercent As Double, ByVal BitsNeeded As String, ByVal Type As String) As String
        Dim OutPut As Double = 0
        Dim FinalOutput As String = ""
        Dim slope As Double = 0
        'Dim output_start As Double = -5
        'Dim output_end As Double = 5
        Dim output_start As Double = 0
        Dim output_end As Double = 10

        Dim input_start As Double = -1
        Dim input_end As Double = 1
        'Bits
        Select Case BitsNeeded
            Case "0"
                'Out the value
                slope = (output_end - output_start) / (input_end - input_start)
                OutPut = output_start + slope * (InputPercent - input_start)
            Case "7"
                'Positives are one higher - then we add the bottom amount
                '64 + 63 = 127 7bit
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 64) + 63
                ElseIf InputPercent < 0 Then
                    OutPut = 63 - (InputPercent * -63)
                Else
                    'middle
                    OutPut = 63
                End If
            Case "8"
                'Positives are one higher - then we add the bottom amount
                '128 + 127 = 255 8bit
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 128) + 127
                ElseIf InputPercent < 0 Then
                    OutPut = 127 - (InputPercent * -127)
                Else
                    'middle
                    OutPut = 127
                End If
            Case "9"
                '511
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 256) + 255
                ElseIf InputPercent < 0 Then
                    OutPut = 255 - (InputPercent * -255)
                Else
                    OutPut = 255
                End If
            Case "10"
                '1023
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 512) + 511
                ElseIf InputPercent < 0 Then
                    OutPut = 511 - (InputPercent * -511)
                Else
                    OutPut = 511
                End If
            Case "11"
                '2047
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 1024) + 1023
                ElseIf InputPercent < 0 Then
                    OutPut = 1023 - (InputPercent * -1023)
                Else
                    OutPut = 1023
                End If
            Case "12"
                '4095
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 2048) + 2047
                ElseIf InputPercent < 0 Then
                    OutPut = 2047 - (InputPercent * -2047)
                Else
                    OutPut = 2047
                End If
            Case "13"
                '8191
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 4096) + 4095
                ElseIf InputPercent < 0 Then
                    OutPut = 4095 - (InputPercent * -4095)
                Else
                    OutPut = 4095
                End If
            Case "14"
                '16283
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 8142) + 8141
                ElseIf InputPercent < 0 Then
                    OutPut = 8141 - (InputPercent * -8141)
                Else
                    OutPut = 8141
                End If
            Case "15"
                '32767
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 16384) + 16383
                ElseIf InputPercent < 0 Then
                    OutPut = 16383 - (InputPercent * -16383)
                Else
                    OutPut = 16383
                End If
            Case "16"
                '65535
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 32768) + 32767
                ElseIf InputPercent < 0 Then
                    OutPut = 32767 - (InputPercent * -32767)
                Else
                    OutPut = 32767
                End If
            Case "17"
                '131071
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 65536) + 65535
                ElseIf InputPercent < 0 Then
                    OutPut = 65535 - (InputPercent * -65535)
                Else
                    OutPut = 65535
                End If
            Case "18"
                '262143
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 131072) + 131071
                ElseIf InputPercent < 0 Then
                    OutPut = 131071 - (InputPercent * -131071)
                Else
                    OutPut = 131071
                End If
            Case "19"
                '524287
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 262144) + 262143
                ElseIf InputPercent < 0 Then
                    OutPut = 262143 - (InputPercent * -262143)
                Else
                    OutPut = 262143
                End If
            Case "20"
                '1048575
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 524288) + 524287
                ElseIf InputPercent < 0 Then
                    OutPut = 524287 - (InputPercent * -524287)
                Else
                    OutPut = 524287
                End If
            Case "21"
                '2097151
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 1048576) + 1048575
                ElseIf InputPercent < 0 Then
                    OutPut = 1048575 - (InputPercent * -1048575)
                Else
                    OutPut = 1048575
                End If
            Case "22"
                '4194303
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 2097152) + 2097151
                ElseIf InputPercent < 0 Then
                    OutPut = 2097151 - (InputPercent * -2097151)
                Else
                    OutPut = 2097151
                End If
            Case "23"
                '8388607
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 4194304) + 4194303
                ElseIf InputPercent < 0 Then
                    OutPut = 4194303 - (InputPercent * -4194303)
                Else
                    OutPut = 4194303
                End If
            Case "24"
                '16777215
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 8388608) + 8388607
                ElseIf InputPercent < 0 Then
                    OutPut = 8388607 - (InputPercent * -8388607)
                Else
                    OutPut = 8388607
                End If
            Case "25"
                '33554431
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 16777216) + 16777215
                ElseIf InputPercent < 0 Then
                    OutPut = 16777215 - (InputPercent * -16777215)
                Else
                    OutPut = 16777215
                End If
            Case "26"
                '67108863
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 33554432) + 33554431
                ElseIf InputPercent < 0 Then
                    OutPut = 33554431 - (InputPercent * -33554431)
                Else
                    OutPut = 33554431
                End If
            Case "27"
                '134217727
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 67108864) + 67108863
                ElseIf InputPercent < 0 Then
                    OutPut = 67108863 - (InputPercent * -67108863)
                Else
                    OutPut = 67108863
                End If
            Case "28"
                '268435455
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 134217728) + 134217727
                ElseIf InputPercent < 0 Then
                    OutPut = 134217727 - (InputPercent * -134217727)
                Else
                    OutPut = 134217727
                End If
            Case "29"
                '536870911
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 268435456) + 268435455
                ElseIf InputPercent < 0 Then
                    OutPut = 268435455 - (InputPercent * -268435455)
                Else
                    OutPut = 268435455
                End If
            Case "30"
                '1073741823
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 536870912) + 536870911
                ElseIf InputPercent < 0 Then
                    OutPut = 536870911 - (InputPercent * -536870911)
                Else
                    OutPut = 536870911
                End If
            Case "31"
                '2147483647
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 1073741824) + 1073741823
                ElseIf InputPercent < 0 Then
                    OutPut = 1073741823 - (InputPercent * -1073741823)
                Else
                    OutPut = 1073741823
                End If
            Case "32"
                '4294967295
                If InputPercent > 0 Then
                    OutPut = (InputPercent * 2147483648) + 2147483647
                ElseIf InputPercent < 0 Then
                    OutPut = 2147483647 - (InputPercent * -2147483647)
                Else
                    OutPut = 2147483647
                End If
        End Select

        'Convert to an integer
        OutPut = Math.Round(OutPut, 2)

        'Type
        Select Case Type
            Case "Binary"
                FinalOutput = GetChr(OutPut)
                'output same number of char's always
                If CInt(BitsNeeded) > 8 Then
                    If FinalOutput.Length = 1 Then
                        FinalOutput = CStr(AsciiCodes(0)) & FinalOutput
                    End If
                End If
                If CInt(BitsNeeded) > 16 Then
                    If FinalOutput.Length = 2 Then
                        FinalOutput = CStr(AsciiCodes(0)) & FinalOutput
                    End If
                End If
                If CInt(BitsNeeded) > 24 Then
                    If FinalOutput.Length = 3 Then
                        FinalOutput = CStr(AsciiCodes(0)) & FinalOutput
                    End If
                End If
            Case "Hex"
                FinalOutput = GetHex(OutPut)
            Case "Decimal"
                FinalOutput = CStr(OutPut)
        End Select
        Return FinalOutput
    End Function

    'Returns output HEX value
    Private Function GetHex(ByVal HexCode As Double) As String
        Return CStr(Conversion.Hex(HexCode))
    End Function

    'Returns output Chr value
    Private Function GetChr(ByVal CharCode As Double) As String
        Dim ChrStringOut As String = ""
        If CharCode > 16777215 Then
            Dim Multiplierx1 As Double = CharCode / 16777216
            If Multiplierx1 > 255 Then
                Multiplierx1 = 255
            End If
            Dim IntegralPart As Double = Math.Truncate(Multiplierx1)
            Try
                CharCode = CharCode - (IntegralPart * 16777216)
            Catch ex As Exception
                CharCode = 0
            End Try
            ChrStringOut = (AsciiCodes(CInt(IntegralPart))).ToString
        End If
        If CharCode > 65535 Then
            Dim Multiplierx1 As Double = CharCode / 65536
            If Multiplierx1 > 255 Then
                Multiplierx1 = 255
            End If
            Dim IntegralPart As Double = Math.Truncate(Multiplierx1)
            Try
                CharCode = CharCode - (CDbl(IntegralPart) * 65536)
            Catch ex As Exception
                CharCode = 0
            End Try
            ChrStringOut = ChrStringOut & (AsciiCodes(CInt(IntegralPart))).ToString
        End If
        If CharCode > 255 Then
            Dim Multiplierx1 As Double = CharCode / 256.0
            If Multiplierx1 > 255 Then
                Multiplierx1 = 255
            End If
            Dim IntegralPart As Double = Math.Truncate(Multiplierx1)
            Try
                CharCode = CharCode - (CDbl(IntegralPart) * 256)
            Catch ex As Exception
                CharCode = 0
            End Try
            ChrStringOut = ChrStringOut & (AsciiCodes(CInt(IntegralPart))).ToString
        End If
        ChrStringOut = ChrStringOut & (AsciiCodes(CInt(CharCode))).ToString
        Return ChrStringOut
    End Function
#End Region

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///                                                        DO NOT EDIT BELOW HERE!!!                                                           ///
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#Region "SimTools Required Functions - Do Not Change"
    Private MyForm As New UserControl_Settings() 'Our Settings Form for this interface
    Private GameStarted_ProperSettings As Boolean = False 'Only start if there is proper settings

    'initilize startup
    Public Sub MyInitialize() Implements Interface_PluginAPI.IPlugin_Interface.Initialize
        'run the Initialize routine above
        Initialize()

        'Set the HasInitialized flag to True
        MyForm._HasInitialized = True
    End Sub

    'game start
    Public Function Game_Start() As Boolean Implements Interface_PluginAPI.IPlugin_Interface.GameStart
        'Only startup if there is a settings file AND we are not already running.
        Dim FinalPath As String = _SavePath & "Interface" & MyForm._InterfaceNumber & "\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_InterfaceAssignments" & MyForm._InterfaceNumber & ".cfg"
        If System.IO.File.Exists(FinalPath) = True And GameStarted_ProperSettings = False Then
            GameStarted_ProperSettings = True
            Return GameStart()
        End If
        'could not start
        Return False
    End Function

    'game end
    Public Sub Game_End() Implements Interface_PluginAPI.IPlugin_Interface.GameEnd
        'Stop Engine if it has been started
        If GameStarted_ProperSettings = True Then
            GameStarted_ProperSettings = False
            GameStop()
            'pause for external app/Interface to recieve the data
            System.Threading.Thread.Sleep(100)
        End If
    End Sub

    'set what interface number
    Public WriteOnly Property InterfaceNumber As Integer Implements Interface_PluginAPI.IPlugin_Interface.WhatInterface
        Set(value As Integer)
            MyForm._InterfaceNumber = value
        End Set
    End Property

    'gets the window and loads settings if found
    Public Function GetSettingsWindow() As Object Implements Interface_PluginAPI.IPlugin_Interface.GetSettingsWindow
        'current path
        Dim FinalPath As String = _SavePath & "Interface" & MyForm._InterfaceNumber & "\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_InterfaceAssignments" & MyForm._InterfaceNumber & ".cfg"
        'Run Startup Commands Above
        StartUp()
        'see if there are any saved settings
        If IO.File.Exists(FinalPath) Then
            MyForm.LoadSavedSettings(FinalPath)
        Else
            ResetSettingsWindow()
        End If

        Return (MyForm) 'return groupbox
    End Function

    'Clear_AxisAssignments form
    Public Sub ResetSettingsWindow() Implements Interface_PluginAPI.IPlugin_Interface.ResetSettingsWindow
        'clear the form
        MyForm.ClearSettingsWindow()
        'load structure
        MyForm.LoadStrutureFromForm() 'required - do not edit
        'Reset the save button
        MyForm.CheckSaveButton() 'required - do not edit
    End Sub

    'Save a preset
    Public Sub SavePreset(Name As String) Implements Interface_PluginAPI.IPlugin_Interface.SavePreset
        MyForm.SaveThisPreset(Name)
    End Sub

    'Load a preset
    Public Sub LoadPreset(ProName As String) Implements Interface_PluginAPI.IPlugin_Interface.LoadPreset
        MyForm.Load_Preset(ProName)
    End Sub

    'what axis assignments enable for
    Public ReadOnly Property Enable_Interface1 As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Enable_Interface1
        Get
            Return _Enable_Interface1
        End Get
    End Property

    Public ReadOnly Property Enable_Interface2 As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Enable_Interface2
        Get
            Return _Enable_Interface2
        End Get
    End Property

    Public ReadOnly Property Enable_Interface3 As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Enable_Interface3
        Get
            Return _Enable_Interface3
        End Get
    End Property

    Public ReadOnly Property Enable_Interface4 As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Enable_Interface4
        Get
            Return _Enable_Interface4
        End Get
    End Property

    Public ReadOnly Property Enable_Interface5 As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Enable_Interface5
        Get
            Return _Enable_Interface5
        End Get
    End Property

    Public ReadOnly Property Enable_Interface6 As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Enable_Interface6
        Get
            Return _Enable_Interface6
        End Get
    End Property

    'get name
    Public ReadOnly Property InterfaceName As String Implements Interface_PluginAPI.IPlugin_Interface.InterfaceName
        Get
            Return _InterfaceName
        End Get
    End Property

    'get author
    Public ReadOnly Property PluginAuthorsName As String Implements Interface_PluginAPI.IPlugin_Interface.PluginAuthorsName
        Get
            Return _PluginAuthorsName
        End Get
    End Property

    'requires restart?
    Public ReadOnly Property Requires_Restart As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Requires_Restart
        Get
            Return _Requires_Restart
        End Get
    End Property

    'Has Initialized?
    Public ReadOnly Property Has_Initialized As Boolean Implements Interface_PluginAPI.IPlugin_Interface.Has_Initialized
        Get
            Return MyForm._HasInitialized
        End Get
    End Property

    'output rate
    Public ReadOnly Property OutPutRate As Integer Implements Interface_PluginAPI.IPlugin_Interface.OutputRate
        Get
            Return MyForm._InterfaceSettings._OutPutRateMS
        End Get
    End Property
#End Region
End Class

'My COM Port object
#Region "    ComWorker"
Public Class ComWorker
    Public Event MsgRecieved(msg As String)

#Region "Manager Variables"
    'property
    Private _baudRate As String = "115200"
    Private _parity As String = "None"
    Private _stopBits As String = "1"
    Private _dataBits As String = "8"
    Private _portName As String = "4123"

    'global
    Private comPort As New SerialPort()
    Private write As Boolean = True
#End Region

#Region "Manager Properties"
    'BaudRate
    Public Property BaudRate() As String
        Get
            Return _baudRate
        End Get
        Set(ByVal value As String)
            _baudRate = value
        End Set
    End Property

    'Parity
    Public Property Parity() As String
        Get
            Return _parity
        End Get
        Set(ByVal value As String)
            _parity = value
        End Set
    End Property

    'StopBits
    Public Property StopBits() As String
        Get
            Return _stopBits
        End Get
        Set(ByVal value As String)
            _stopBits = value
        End Set
    End Property

    'DataBits
    Public Property DataBits() As String
        Get
            Return _dataBits
        End Get
        Set(ByVal value As String)
            _dataBits = value
        End Set
    End Property

    'PortName
    Public Property PortName() As String
        Get
            Return _portName
        End Get
        Set(ByVal value As String)
            _portName = value
        End Set
    End Property
#End Region

#Region "OpenPort"
    Public Function OpenPort() As Boolean
        Try
            'check if the port is open
            If comPort.IsOpen = True Then
                comPort.Close()
            End If
            'SerialPort Object Properties
            'ComPort
            comPort.BaudRate = Integer.Parse(_baudRate)
            'DataBits
            comPort.DataBits = Integer.Parse(_dataBits)
            'StopBits
            comPort.StopBits = DirectCast([Enum].Parse(GetType(StopBits), _stopBits), StopBits)
            'Parity
            comPort.Parity = DirectCast([Enum].Parse(GetType(Parity), _parity), Parity)
            'PortName
            comPort.PortName = _portName
            'open port             
            comPort.Open()
            'display message
            'RaiseEvent MsgRecieved("Port opened at " + DateTime.Now + "" + Environment.NewLine + "")
            'if opened return true
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "ClosePort "
    Public Sub ClosePort()
        If comPort.IsOpen Then
            'RaiseEvent MsgRecieved("Port closed at " + DateTime.Now + "" + Environment.NewLine + "")
            comPort.Close()
        End If
    End Sub
#End Region

#Region "WriteData"
    Public Function WriteData(ByVal msg As String) As Boolean
        comPort.Encoding = Text.Encoding.Default
        'port is open?
        If Not (comPort.IsOpen = True) Then
            comPort.Open()
        End If
        Try
            'send message
            comPort.Write(msg)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "ReceivedData"
    Public Sub comPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Try
            Dim msg As String = comPort.ReadExisting()
            'return the data
            RaiseEvent MsgRecieved(msg)
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
#End Region



