Imports System.ComponentModel

Public Class Form1
    Dim ps2folder As IO.DirectoryInfo = Nothing
    Dim pcx2exe As IO.FileInfo = Nothing
    Dim Settingsblock As SettingsSaver = Nothing
    Dim allowclose As Boolean = False
    Dim recentplays As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Settingsblock = SettingsSaver.LoadControlFile(My.Application.Info.DirectoryPath & "\settings.xqf")
        ComboBox1.SelectedIndex = 1

        For Each itm As IO.DriveInfo In My.Computer.FileSystem.Drives
            If itm.DriveType = IO.DriveType.CDRom Then
                cddrives.Items.Add(itm.Name)
            End If
        Next


        If Settingsblock Is Nothing Then
            Settingsblock = New SettingsSaver

        End If
        If cddrives.Items.Count > 0 Then
            cddrives.SelectedIndex = 0
        Else
            allowbootfromcd.Checked = False
            allowbootfromcd.Enabled = False
        End If

        Settingsblock.AddControl(New Control() {TextBox1, TextBox2, ComboBox1, allowoneemu, showlog, firstbootmode, allowbootfromcd, cddrives})
        Settingsblock.LoadSaveState()

        Dim vx As Object = Settingsblock.getErrattaObject("recentplays")

        If vx IsNot Nothing Then

            If vx.GetType = GetType(ArrayList) Then
                recentplays = vx
            End If

        End If

        populateDatagrid(searchIsos(ps2folder))


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If sender.text Is Nothing Then
            Exit Sub
        End If
        Try
            ps2folder = New IO.DirectoryInfo(sender.text)
            If Not ps2folder.Exists Then
                ps2folder = Nothing
                sender.text = Nothing
            End If
        Catch ex As Exception
            ps2folder = Nothing
            sender.text = Nothing
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If sender.text Is Nothing Then
            Exit Sub
        End If
        Try
            pcx2exe = New IO.FileInfo(sender.text)
            If Not pcx2exe.Exists Then
                pcx2exe = Nothing
                sender.text = Nothing
            End If
        Catch ex As Exception
            pcx2exe = Nothing
            sender.text = Nothing
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Dim senderbutton As Button = sender
        Dim ctextbox As TextBox = senderbutton.Parent.Controls(senderbutton.Name.Replace("Button", "TextBox"))

        Select Case sender.name
            Case "Button1"
                Using scs As New FolderBrowserDialog
                    scs.Description = "PS2 rom folder"
                    scs.ShowNewFolderButton = False
                    If scs.ShowDialog = DialogResult.OK Then
                        ctextbox.Text = scs.SelectedPath
                    End If
                End Using
            Case "Button2"
                Using scs As New OpenFileDialog
                    scs.DefaultExt = "exe"
                    scs.Filter = "*.exe|*.exe"
                    scs.FilterIndex = 1
                    scs.Title = "Get PCSX2.exe"
                    If scs.ShowDialog = DialogResult.OK Then
                        ctextbox.Text = scs.FileName
                    End If
                End Using
        End Select
    End Sub


    Function searchIsos(path As IO.DirectoryInfo) As ArrayList

        If path Is Nothing Then
            Return New ArrayList
        End If

        Dim scs As New ArrayList
        searchIsos(path, scs)
        Return scs
    End Function

    Sub searchIsos(path As IO.DirectoryInfo, ByRef holdingcontainer As ArrayList)
        For Each itm As IO.FileInfo In path.GetFiles("*.bin")
            holdingcontainer.Add(itm)
        Next
        For Each itm As IO.FileInfo In path.GetFiles("*.iso")
            holdingcontainer.Add(itm)
        Next
        For Each itm As IO.DirectoryInfo In path.GetDirectories
            searchIsos(itm, holdingcontainer)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ps2folder IsNot Nothing Then
            If ps2folder.Exists Then

                populateDatagrid(searchIsos(ps2folder))
            End If
        End If
    End Sub


    Sub populateDatagrid(data As ArrayList)
        DataGridView1.Rows.Clear()
        For Each itm As IO.FileInfo In data
            Dim stas As New DataGridViewRow
            stas.Tag = itm


            Dim c1 As New DataGridViewTextBoxCell
            c1.Value = itm.Name.Replace(itm.Extension, "")
            Dim c2 As New DataGridViewButtonCell
            c2.Value = "Copy"
            Dim c3 As New DataGridViewButtonCell
            c3.Value = "Launch"
            Dim c4 As New DataGridViewButtonCell
            c4.Value = "Quit"

            stas.Cells.AddRange(New DataGridViewCell() {c1, c3})
            DataGridView1.Rows.Add(stas)
        Next
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cs As DataGridViewCell = sender.item(e.ColumnIndex, e.RowIndex)
        If Equals(cs.GetType, GetType(DataGridViewButtonCell)) Then
            Dim dxs As IO.FileInfo = sender.rows(e.RowIndex).tag
            If cs.Value = "Copy" Then
                Clipboard.SetText("""" & dxs.FullName & """")
            End If
            If cs.Value = "Launch" Then
                If Not dxs.Exists Then
                    MessageBox.Show("Rom does not exist" & vbCrLf & dxs.Directory.FullName)
                    Exit Sub
                End If
                If pcx2exe IsNot Nothing Then
                    If pcx2exe.Exists Then
                        startemuwithrom(pcx2exe, dxs, "", ComboBox1.SelectedIndex, showlog.Checked, firstbootmode.Checked, Not allowoneemu.Checked)
                        recentplays.Add(dxs)
                    End If
                End If
            End If
            If cs.Value = "Quit" Then
                killotheremuinstances()
            End If
        End If
    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If e.Button = MouseButtons.Right Then
            Dim dxs As IO.FileInfo = sender.rows(e.RowIndex).tag
            If dxs.Exists Then
                Process.Start("""" & dxs.Directory.FullName & """")
            Else
                MessageBox.Show("Directory does not exist" & vbCrLf & dxs.Directory.FullName)
            End If



        End If
    End Sub
    Sub killotheremuinstances()
        While Process.GetProcessesByName("pcsx2").Count > 0
            For Each proc As Process In Process.GetProcessesByName("pcsx2")
                Try
                    If proc.Responding Then
                        proc.CloseMainWindow()
                    Else
                        proc.Kill()
                    End If

                Catch ex As Exception

                End Try

            Next
        End While
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Settingsblock.SetSaveState()
        Settingsblock.addErrattaObject("recentplays", recentplays)
        Settingsblock.SaveControlFile(My.Application.Info.DirectoryPath & "\settings.xqf", True)

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.F5 Then
            populateDatagrid(searchIsos(ps2folder))
        End If
    End Sub

    Private Sub SearchRows(regexpattern As String)
        Try


            Dim srx As New Text.RegularExpressions.Regex(regexpattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            For Each crow As DataGridViewRow In DataGridView1.Rows
                crow.Visible = srx.IsMatch(crow.Cells(0).Value)
            Next
        Catch ex As Exception
            Dim srx As New Text.RegularExpressions.Regex(".", System.Text.RegularExpressions.RegexOptions.IgnoreCase)

            For Each crow As DataGridViewRow In DataGridView1.Rows
                crow.Visible = srx.IsMatch(crow.Cells(0).Value)
            Next
        End Try

    End Sub

    Private Sub emukill_Click(sender As Object, e As EventArgs) Handles emukill.Click
        killotheremuinstances()
    End Sub

    Private Sub Emustart_Click(sender As Object, e As EventArgs) Handles Emustart.Click
        If pcx2exe IsNot Nothing Then
            If pcx2exe.Exists Then
                If allowbootfromcd.Checked Then
                    startemuwithrom(pcx2exe, Nothing, cddrives.SelectedItem, ComboBox1.SelectedIndex, showlog.Checked, firstbootmode.Checked, Not allowoneemu.Checked)
                Else
                    startemuwithrom(pcx2exe, Nothing, "", ComboBox1.SelectedIndex, showlog.Checked, firstbootmode.Checked, Not allowoneemu.Checked)
                End If

            End If
        End If
    End Sub

    Private Sub livesearchbox_TextChanged(sender As Object, e As EventArgs) Handles livesearchbox.TextChanged
        If sender.text = "" Or sender.text Is Nothing Then
            SearchRows(".")
        Else
            SearchRows(sender.text)
        End If

    End Sub

    Private Sub RecentRoms_Click(sender As Object, e As EventArgs) Handles RecentRoms.Click
        If recentplays.Count = 0 Then
            Exit Sub
        ElseIf recentplays.Count >= 10 Then
            recentplays.RemoveRange(0, recentplays.Count - 10)
        End If



        Dim scx As Button = sender
            scx.ContextMenuStrip.Items.Clear()
            Dim i As Integer = recentplays.Count - 1
            While i >= 0
                Dim xrx As IO.FileInfo = recentplays(i)
            Dim scs As New ToolStripMenuItem(xrx.Name.Replace(xrx.Extension, ""))
            If Not xrx.Exists Then
                recentplays.RemoveAt(i)
                Continue While
            End If
            AddHandler scs.MouseUp, AddressOf runrecent

            scs.Tag = xrx
                scx.ContextMenuStrip.Items.Add(scs)

                i -= 1
            End While

            scx.ContextMenuStrip.Show(sender, New Point(2, sender.height))



    End Sub

    Public Sub runrecent(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then

            If pcx2exe IsNot Nothing Then
                If pcx2exe.Exists Then
                    startemuwithrom(pcx2exe, sender.tag, "", Boolean.Parse(ComboBox1.SelectedIndex), showlog.Checked, firstbootmode.Checked, Not allowoneemu.Checked)

                End If
            End If
        Else
            Dim csx As ToolStripItem = sender
            csx.Owner.Items.Remove(csx)
            recentplays.Remove(csx.Tag)

        End If

    End Sub

    Sub startemuwithrom(exefile As IO.FileInfo, rom As IO.FileInfo, cdrompath As String, fullboot As Boolean, showconsole As Boolean, firstbootwiz As Boolean, morethanoneemu As Boolean)
        If Not exefile.Exists Then
            MessageBox.Show("Emulatior Does not exist" & vbCrLf & exefile.FullName)
        End If
        If rom IsNot Nothing Then
            If Not rom.Exists Then
                MessageBox.Show("Rom Does not exist" & vbCrLf & rom.FullName)
                Exit Sub
            End If

        End If
        If exefile.Exists Then
            Dim sc As New Process
            sc.StartInfo.FileName = exefile.FullName

            If rom IsNot Nothing Then
                sc.StartInfo.Arguments &= """" & rom.FullName & """"
            Else
                If cdrompath <> "" Then
                    sc.StartInfo.Arguments &= " --usecd"
                End If

            End If


            sc.StartInfo.Arguments &= " --portable"

            If fullboot Then
                sc.StartInfo.Arguments &= " --fullboot"
            End If

            If showconsole Then
                sc.StartInfo.Arguments &= " --console"
            End If

            If firstbootwiz Then
                sc.StartInfo.Arguments &= " --forcewiz"
            End If

            If Not morethanoneemu Then
                killotheremuinstances()
            End If
            sc.Start()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles allowbootfromcd.CheckedChanged
        bootcdpanel.Enabled = sender.checked
    End Sub
End Class

<Serializable> Public Class SettingsSaver

    Public Property MonitorControls As SortedList = New SortedList
    Public Property Settings As SortedList = New SortedList

    Public Sub addErrattaObject(errattakey As String, ByRef obj As Object)
        If Not Settings.ContainsKey("Erratta") Then
            Settings.Add("Erratta", New SortedList)
        End If

        If Settings("Erratta").containsKey(errattakey) Then
            Settings("Erratta")(errattakey) = obj
        Else
            Settings("Erratta").add(errattakey, obj)
        End If
    End Sub

    Function getErrattaObject(errattakey As String) As Object
        If Settings.ContainsKey("Erratta") Then
            If Settings("Erratta").containsKey(errattakey) Then
                Return Settings("Erratta")(errattakey)
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If

    End Function

    Public ReadOnly Property HasStateSaved As Boolean
        Get
            If Settings.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Sub AddControl(watchcontrol As Control)
        Dim cxr As New ArrayList
        cxr.Add(watchcontrol)
        AddControl(cxr)
    End Sub

    Public Sub AddControl(watchcontrol As Control())
        Dim cxr As New ArrayList
        cxr.AddRange(watchcontrol)
        AddControl(cxr)
    End Sub

    Public Sub AddControl(watchcontrol As ArrayList)
        For Each itm As Control In watchcontrol
            If Not MonitorControls.ContainsKey(itm.Name) Then
                MonitorControls.Add(itm.Name, itm)
            End If
        Next
    End Sub

    Public Sub ClearSaveState()
        Settings.Clear()
    End Sub

    Public Sub ClearWatchControls()
        MonitorControls.Clear()
    End Sub

    Public Sub ClearWatchAndState()
        ClearSaveState()
        ClearWatchControls()
    End Sub

    Public Sub SetSaveState()
        ClearSaveState()

        For Each itm As String In MonitorControls.GetKeyList
            Dim currentcontrol As Control = MonitorControls(itm)
            Select Case currentcontrol.GetType
                Case GetType(TextBox)
                    Dim xb As TextBox = currentcontrol
                    Settings.Add(xb.Name, xb.Text)
                Case GetType(CheckBox)
                    Dim xb As CheckBox = currentcontrol
                    Settings.Add(xb.Name, xb.Checked)
                Case GetType(ComboBox)
                    Dim xb As ComboBox = currentcontrol
                    Settings.Add(xb.Name, xb.SelectedIndex)
            End Select
        Next

    End Sub

    Public Sub LoadSaveState()
        For Each itm As String In Settings.GetKeyList
            If Not MonitorControls.ContainsKey(itm) Then
                Continue For
            End If
            Dim currentcontrol As Control = MonitorControls(itm)
            Select Case currentcontrol.GetType
                Case GetType(TextBox)
                    Dim xb As TextBox = currentcontrol
                    xb.Text = Settings(itm)

                Case GetType(CheckBox)
                    Dim xb As CheckBox = currentcontrol
                    xb.Checked = Boolean.Parse(Settings(itm))

                Case GetType(ComboBox)
                    Dim xb As ComboBox = currentcontrol
                    Try
                        xb.SelectedIndex = Integer.Parse(Settings(itm))
                    Catch ex As Exception
                        xb.SelectedIndex = 0
                    End Try

            End Select
        Next
    End Sub
    Public Sub SaveControlFile(path As String, overwrite As Boolean)
        If IO.File.Exists(path) And Not overwrite Then
            Exit Sub
        End If
        Dim cfb As IO.FileStream = Nothing

        Try


            cfb = IO.File.Create(path)

            Dim scsa As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

            scsa.Serialize(cfb, Settings)


        Catch ex As Exception

        End Try

        If cfb IsNot Nothing Then
            cfb.Close()
            cfb.Dispose()
        End If
    End Sub

    Public Shared Function LoadControlFile(path As String) As SettingsSaver
        Dim stx As SettingsSaver = Nothing
        If IO.File.Exists(path) Then


            Dim cfb As IO.FileStream = Nothing

            Try


                cfb = IO.File.Open(path, IO.FileMode.Open)

                Dim scsa As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
                Dim dsx As SortedList = scsa.Deserialize(cfb)
                stx = New SettingsSaver

                stx.Settings = dsx


            Catch ex As Exception

            End Try

            If cfb IsNot Nothing Then
                cfb.Close()
                cfb.Dispose()
            End If

        End If
        Return stx
    End Function


End Class