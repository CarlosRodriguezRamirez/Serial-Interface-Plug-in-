Option Strict On
Option Explicit On

Imports System.IO
Imports System.Xml.Serialization

Public Class UserControl_Settings
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///                 Edit the Subroutines below to provide support for your favorite Interface!                        ///
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Game Engine uses this to (Load the Form from the Structure)
    Private Sub LoadFormFromStructure()
        'Load Form from Structure

        'Interface Unpluged Reload Fix
        If cb_ComPort.Items.Contains(_InterfaceSettings._ComPort.ToString) = False Then
            cb_ComPort.Items.Add(_InterfaceSettings._ComPort.ToString)
            MsgBox("The interface connected to " & _InterfaceSettings._ComPort.ToString & " is not detected!" & vbCrLf & "", MsgBoxStyle.Exclamation)
        End If

        cb_ComPort.SelectedItem = _InterfaceSettings._ComPort.ToString

        If _InterfaceSettings._BitsPerSec = 0 Then
            cb_BPS.SelectedItem = "-"
        Else
            cb_BPS.SelectedItem = _InterfaceSettings._BitsPerSec.ToString
        End If
        If _InterfaceSettings._DataBits = 0 Then
            cb_DateBits.SelectedItem = "-"
        Else
            cb_DateBits.SelectedItem = _InterfaceSettings._DataBits.ToString
        End If
        cb_Parity.SelectedItem = _InterfaceSettings._ParityBits.ToString
        cb_StopBits.SelectedItem = _InterfaceSettings._StopBits.ToString

        If _InterfaceSettings._OutputBits = "0" Then
            cb_OutputBits.SelectedItem = "-"
        Else
            cb_OutputBits.SelectedItem = _InterfaceSettings._OutputBits.ToString
        End If
        If _InterfaceSettings._OutputType = "Binary" Then
            rad_Binary.Checked = True
        ElseIf _InterfaceSettings._OutputType = "Decimal" Then
            rad_Decimal.Checked = True
        ElseIf _InterfaceSettings._OutputType = "Hex" Then
            rad_Hex.Checked = True
        End If
        If _InterfaceSettings._HWStartMS = 0 Then
            cb_StartMS.SelectedItem = "-"
        Else
            cb_StartMS.SelectedItem = _InterfaceSettings._HWStartMS.ToString
        End If
        If _InterfaceSettings._HWStopMS = 0 Then
            cb_StopMS.SelectedItem = "-"
        Else
            cb_StopMS.SelectedItem = _InterfaceSettings._HWStopMS.ToString
        End If
        If _InterfaceSettings._OutPutRateMS = 0 Then
            cb_PacketRate.SelectedItem = "-"
        Else
            cb_PacketRate.SelectedItem = _InterfaceSettings._OutPutRateMS.ToString
        End If
        txt_StartUpOutput.Text = _InterfaceSettings._StartupOutput.ToString
        txt_InterfaceOutput.Text = _InterfaceSettings._InterfaceOutput.ToString
        txt_ShutDownOutput.Text = _InterfaceSettings._ShutdownOutput.ToString
    End Sub

    'Game Engine uses this to (Load the Structure from the Form)
    Public Sub LoadStrutureFromForm()
        'Load Structure from Form
        _InterfaceSettings._ComPort = cb_ComPort.Text
        If cb_BPS.Text = "-" Then
            _InterfaceSettings._BitsPerSec = 0
        Else
            _InterfaceSettings._BitsPerSec = CInt(cb_BPS.Text)
        End If
        If cb_DateBits.Text = "-" Then
            _InterfaceSettings._DataBits = 0
        Else
            _InterfaceSettings._DataBits = CInt(cb_DateBits.Text)
        End If
        _InterfaceSettings._ParityBits = cb_Parity.Text
        _InterfaceSettings._StopBits = cb_StopBits.Text
        If cb_OutputBits.Text = "-" Then
            _InterfaceSettings._OutputBits = "0"
        Else
            _InterfaceSettings._OutputBits = cb_OutputBits.Text
        End If
        If rad_Binary.Checked = True Then
            _InterfaceSettings._OutputType = "Binary"
        ElseIf rad_Decimal.Checked = True Then
            _InterfaceSettings._OutputType = "Decimal"
        Else
            _InterfaceSettings._OutputType = "Hex"
        End If
        _InterfaceSettings._StartupOutput = txt_StartUpOutput.Text
        If cb_StartMS.Text = "-" Then
            _InterfaceSettings._HWStartMS = 0
        Else
            _InterfaceSettings._HWStartMS = CInt(cb_StartMS.Text)
        End If
        _InterfaceSettings._InterfaceOutput = txt_InterfaceOutput.Text
        If cb_PacketRate.Text = "-" Then
            _InterfaceSettings._OutPutRateMS = 0
        Else
            _InterfaceSettings._OutPutRateMS = CInt(cb_PacketRate.Text)
        End If
        _InterfaceSettings._ShutdownOutput = txt_ShutDownOutput.Text
        If cb_StopMS.Text = "-" Then
            _InterfaceSettings._HWStopMS = 0
        Else
            _InterfaceSettings._HWStopMS = CInt(cb_StopMS.Text)
        End If
    End Sub

     'Game Engine uses this to (Clear the Form)
    Public Sub ClearSettingsWindow()
        cb_ComPort.SelectedItem = "-"
        cb_BPS.SelectedItem = "-"
        cb_DateBits.SelectedItem = "-"
        cb_Parity.SelectedItem = "-"
        cb_StopBits.SelectedItem = "-"
        cb_OutputBits.SelectedItem = "-"
        rad_Binary.Checked = True
        cb_StartMS.SelectedItem = "-"
        cb_PacketRate.SelectedItem = "-"
        cb_StopMS.SelectedItem = "-"
        txt_StartUpOutput.Text = ""
        txt_InterfaceOutput.Text = ""
        txt_ShutDownOutput.Text = ""
    End Sub

    'Your form uses this to determine when the form has enough info to enable the 'Save' button
    Public Sub CheckSaveButton()
        Try
            If cb_ComPort.SelectedItem.ToString <> "-" And cb_BPS.SelectedItem.ToString <> "-" And cb_DateBits.SelectedItem.ToString <> "-" And cb_Parity.SelectedItem.ToString <> "-" And cb_StopBits.SelectedItem.ToString <> "-" And cb_OutputBits.SelectedItem.ToString <> "-" And cb_PacketRate.SelectedItem.ToString <> "-" And txt_InterfaceOutput.Text <> "" Then
                btn_Save.Enabled = True
            Else
                btn_Save.Enabled = False
            End If
        Catch ex As Exception
            btn_Save.Enabled = False
        End Try
    End Sub

    '///////////////////////////////////////////////////////////////////////////////
    '///              User Controls for the Plugins Settings Form                ///
    '///////////////////////////////////////////////////////////////////////////////
    Private Sub cb_ComPort_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_ComPort.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub cb_BPS_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_BPS.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub cb_DateBits_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_DateBits.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub cb_Parity_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_Parity.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub cb_StopBits_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_StopBits.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub cb_OutputBits_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_OutputBits.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub cb_PacketRate_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cb_PacketRate.SelectionChangeCommitted
        CheckSaveButton()
    End Sub

    Private Sub txt_InterfaceOutput_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_InterfaceOutput.TextChanged
        CheckSaveButton()
    End Sub


    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///                                                        DO NOT EDIT BELOW HERE!!!                                                           ///
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#Region "No Change Needed - works for all plugins!"
    'Our Settings Structure - used to hold all editable user settings (no change needed)
    Public _InterfaceSettings As New InterfacePlugin.InterfaceAssignments
    Public _InterfaceNumber As Integer 'SimTools sets this when it loads the dll
    Public _HasInitialized As Boolean = False 'SimTools sets this when it loads the dll  

    'default save location - (no change needed)
    Private _SavePath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\SimTools\GameEngine\"

    'Write the interface settings to a file
    Private Sub Save_InterfaceAssignments(FileName As String)
        LoadStrutureFromForm()

        'Write file
        Dim objWriter As New System.IO.StreamWriter(FileName, False)
        objWriter.WriteLine(SerializeInterfaceAssignments())
        objWriter.Close()
    End Sub

    'Create Preset folder when loaded
    Private Sub UserControl_Settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'create preset folder if it does not exist
        Dim FileName As String = _SavePath & "InterfacePresets\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_Presets"
        If System.IO.Directory.Exists(FileName) = False Then
            System.IO.Directory.CreateDirectory(FileName)
        End If

        'create Interface Plugin folder if it does not exist
        FileName = _SavePath & "Interface" & _InterfaceNumber & "\" & InterfacePlugin._InterfaceName.Replace(" ", "")
        If System.IO.Directory.Exists(FileName) = False Then
            System.IO.Directory.CreateDirectory(FileName)
        End If
    End Sub

    'Save a new/edited Preset
    Public Sub SaveThisPreset(Name As String)
        Dim FileName As String = _SavePath & "InterfacePresets\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_Presets\" & Name & "_" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_InterfaceAssignments.pre"
        Save_InterfaceAssignments(FileName)
    End Sub

    'Serialize to string
    Private Function SerializeInterfaceAssignments() As String
        Dim string_writer As New StringWriter
        Dim SerializedOutput As String
        Dim xml_serializer As New XmlSerializer(GetType(InterfacePlugin.InterfaceAssignments))
        xml_serializer.Serialize(string_writer, _InterfaceSettings)
        SerializedOutput = string_writer.ToString()
        string_writer.Close()
        Return SerializedOutput
    End Function

    'De-Serialize from string
    Private Function DeSerializeInterfaceAssignments(InputString As String) As Object
        Dim xml_serializer As New XmlSerializer(GetType(InterfacePlugin.InterfaceAssignments))
        Dim string_reader As New StringReader(InputString)
        Dim DeserializedOutput As InterfacePlugin.InterfaceAssignments = DirectCast(xml_serializer.Deserialize(string_reader), InterfacePlugin.InterfaceAssignments)
        string_reader.Close()
        Return DeserializedOutput
    End Function

    'Save Settings
    Private Sub btn_Save_InterfaceSettings_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click
        'File Path
        Dim File_SavePath As String = _SavePath & "Interface" & _InterfaceNumber & "\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_InterfaceAssignments" & _InterfaceNumber & ".cfg"

        'see if we are changing or adding new settings
        Dim NewSettings As Boolean = True
        If File.Exists(File_SavePath) Then
            NewSettings = False
        End If

        'delete all settings found (should only be one) but this way it deletes all files from dir
        Dim MyPath As String = (_SavePath & "Interface" & _InterfaceNumber & "\" & InterfacePlugin._InterfaceName.Replace(" ", ""))
        If Directory.Exists(MyPath) Then
            'Delete all files from the Directory
            For Each filepath As String In Directory.GetFiles(MyPath)
                File.Delete(filepath)
            Next
        End If

        'Save New Settings
        Save_InterfaceAssignments(File_SavePath)

        'Load New Saved Settings to structure
        Dim objReader As New System.IO.StreamReader(File_SavePath)
        Dim SerializedString As String = objReader.ReadToEnd()
        objReader.Close()
        _InterfaceSettings = CType(DeSerializeInterfaceAssignments(SerializedString), InterfacePlugin.InterfaceAssignments) 'Structure Loaded Here

        'Check for Forced Restart before run
        If InterfacePlugin._Requires_Restart = True And _HasInitialized = False And NewSettings = True Then
            MsgBox("Settings Saved" & vbCrLf & "This Interface Requires GameEngine be Restarted" & vbCrLf & "Please Restart GameEngine", MsgBoxStyle.Information, "Interface Settings")
        Else
            MsgBox("Settings Saved", MsgBoxStyle.Information, "Interface Settings")
        End If
    End Sub

    'Load saved settings
    Public Sub LoadSavedSettings(ByVal FilePath As String)
        If System.IO.File.Exists(FilePath) = True Then
            Try
                Dim objReader As New System.IO.StreamReader(FilePath)
                Dim SerializedString As String = objReader.ReadToEnd()
                objReader.Close()
                _InterfaceSettings = CType(DeSerializeInterfaceAssignments(SerializedString), InterfacePlugin.InterfaceAssignments) 'Structure Loaded Here
                LoadFormFromStructure()
            Catch ex As Exception
                'clear the form
                ClearSettingsWindow()
                'load structure
                LoadStrutureFromForm() 'required - do not edit
                'delete bad file
                System.IO.File.Delete(FilePath)
            End Try
        End If

        'Reset the save button
        CheckSaveButton() 'required - do not edit
    End Sub

    'Load a preset file
    Public Sub Load_Preset(ProfileName As String)
        Dim FileName As String = _SavePath & "InterfacePresets\" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_Presets\" & ProfileName & "_" & InterfacePlugin._InterfaceName.Replace(" ", "") & "_InterfaceAssignments.pre"
        If System.IO.File.Exists(FileName) = True Then
            Try
                Dim objReader As New System.IO.StreamReader(FileName)
                Dim SerializedString As String = objReader.ReadToEnd()
                objReader.Close()
                _InterfaceSettings = CType(DeSerializeInterfaceAssignments(SerializedString), InterfacePlugin.InterfaceAssignments) 'Structure Loaded Here
                LoadFormFromStructure()
                MsgBox(ProfileName & " Interface Preset Loaded!" & vbCrLf & "Remember to Click [Save] when finished.", MsgBoxStyle.Information, "Interface Preset")
            Catch ex As Exception
                'clear the form
                ClearSettingsWindow()
                'load structure
                LoadStrutureFromForm()
                'delete bad file
                System.IO.File.Delete(FileName)
                MsgBox(ProfileName & " Is a Invalid Interface Preset File!" & vbCrLf & "Bad or Corrupt file has been Deleted!", MsgBoxStyle.Critical, "Interface Preset")
            End Try
        End If

        'Reset the save button
        CheckSaveButton() 'required - do not edit
    End Sub
#End Region
End Class
