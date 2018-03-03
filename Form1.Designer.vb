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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RecentRoms = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Emustart = New System.Windows.Forms.Button()
        Me.emukill = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.livesearchbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IsoName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pathcopy = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.showlog = New System.Windows.Forms.CheckBox()
        Me.allowoneemu = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.firstbootmode = New System.Windows.Forms.CheckBox()
        Me.allowbootfromcd = New System.Windows.Forms.CheckBox()
        Me.bootcdpanel = New System.Windows.Forms.Panel()
        Me.cddrives = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.bootcdpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(691, 432)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RecentRoms)
        Me.TabPage1.Controls.Add(Me.Emustart)
        Me.TabPage1.Controls.Add(Me.emukill)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.livesearchbox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(683, 406)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rom List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RecentRoms
        '
        Me.RecentRoms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecentRoms.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RecentRoms.Location = New System.Drawing.Point(410, 357)
        Me.RecentRoms.Name = "RecentRoms"
        Me.RecentRoms.Size = New System.Drawing.Size(84, 23)
        Me.RecentRoms.TabIndex = 10
        Me.RecentRoms.Text = "Recent..."
        Me.RecentRoms.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Emustart
        '
        Me.Emustart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emustart.Location = New System.Drawing.Point(500, 357)
        Me.Emustart.Name = "Emustart"
        Me.Emustart.Size = New System.Drawing.Size(96, 23)
        Me.Emustart.TabIndex = 9
        Me.Emustart.Text = "Start Emulator"
        Me.Emustart.UseVisualStyleBackColor = True
        '
        'emukill
        '
        Me.emukill.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emukill.Location = New System.Drawing.Point(602, 357)
        Me.emukill.Name = "emukill"
        Me.emukill.Size = New System.Drawing.Size(75, 23)
        Me.emukill.TabIndex = 9
        Me.emukill.Text = "Kill Emulator"
        Me.emukill.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(251, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Search Rom Folder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'livesearchbox
        '
        Me.livesearchbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.livesearchbox.Location = New System.Drawing.Point(109, 359)
        Me.livesearchbox.Name = "livesearchbox"
        Me.livesearchbox.Size = New System.Drawing.Size(136, 20)
        Me.livesearchbox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search ROMS List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsoName, Me.Pathcopy})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(677, 346)
        Me.DataGridView1.TabIndex = 0
        '
        'IsoName
        '
        Me.IsoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IsoName.HeaderText = "Iso Name"
        Me.IsoName.Name = "IsoName"
        Me.IsoName.ReadOnly = True
        Me.IsoName.Width = 77
        '
        'Pathcopy
        '
        Me.Pathcopy.HeaderText = ""
        Me.Pathcopy.Name = "Pathcopy"
        Me.Pathcopy.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bootcdpanel)
        Me.TabPage2.Controls.Add(Me.allowbootfromcd)
        Me.TabPage2.Controls.Add(Me.firstbootmode)
        Me.TabPage2.Controls.Add(Me.showlog)
        Me.TabPage2.Controls.Add(Me.allowoneemu)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(683, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Setting"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'showlog
        '
        Me.showlog.AutoSize = True
        Me.showlog.Location = New System.Drawing.Point(20, 171)
        Me.showlog.Name = "showlog"
        Me.showlog.Size = New System.Drawing.Size(115, 17)
        Me.showlog.TabIndex = 5
        Me.showlog.Text = "Show Log Console"
        Me.showlog.UseVisualStyleBackColor = True
        '
        'allowoneemu
        '
        Me.allowoneemu.AutoSize = True
        Me.allowoneemu.Checked = True
        Me.allowoneemu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.allowoneemu.Location = New System.Drawing.Point(20, 123)
        Me.allowoneemu.Name = "allowoneemu"
        Me.allowoneemu.Size = New System.Drawing.Size(185, 17)
        Me.allowoneemu.TabIndex = 5
        Me.allowoneemu.Text = "Allow Only One Emulator at a time"
        Me.allowoneemu.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(104, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 30)
        Me.Panel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse...."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(104, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 30)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fast", "Full"})
        Me.ComboBox1.Location = New System.Drawing.Point(104, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bios Start Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pcsx2 Exe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PS2 Rom folder"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 410)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(691, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'firstbootmode
        '
        Me.firstbootmode.AutoSize = True
        Me.firstbootmode.Location = New System.Drawing.Point(20, 146)
        Me.firstbootmode.Name = "firstbootmode"
        Me.firstbootmode.Size = New System.Drawing.Size(129, 17)
        Me.firstbootmode.TabIndex = 6
        Me.firstbootmode.Text = "Run in first boot mode"
        Me.firstbootmode.UseVisualStyleBackColor = True
        '
        'allowbootfromcd
        '
        Me.allowbootfromcd.AutoSize = True
        Me.allowbootfromcd.Enabled = False
        Me.allowbootfromcd.Location = New System.Drawing.Point(20, 194)
        Me.allowbootfromcd.Name = "allowbootfromcd"
        Me.allowbootfromcd.Size = New System.Drawing.Size(92, 17)
        Me.allowbootfromcd.TabIndex = 7
        Me.allowbootfromcd.Text = "Boot From CD"
        Me.allowbootfromcd.UseVisualStyleBackColor = True
        '
        'bootcdpanel
        '
        Me.bootcdpanel.Controls.Add(Me.cddrives)
        Me.bootcdpanel.Enabled = False
        Me.bootcdpanel.Location = New System.Drawing.Point(141, 185)
        Me.bootcdpanel.Name = "bootcdpanel"
        Me.bootcdpanel.Size = New System.Drawing.Size(116, 26)
        Me.bootcdpanel.TabIndex = 8
        '
        'cddrives
        '
        Me.cddrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cddrives.FormattingEnabled = True
        Me.cddrives.Location = New System.Drawing.Point(3, 2)
        Me.cddrives.Name = "cddrives"
        Me.cddrives.Size = New System.Drawing.Size(104, 21)
        Me.cddrives.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 432)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Pcsx2 Launch Helper"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.bootcdpanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents allowoneemu As CheckBox
    Friend WithEvents showlog As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents livesearchbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents emukill As Button
    Friend WithEvents Emustart As Button
    Friend WithEvents RecentRoms As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents IsoName As DataGridViewTextBoxColumn
    Friend WithEvents Pathcopy As DataGridViewButtonColumn
    Friend WithEvents firstbootmode As CheckBox
    Friend WithEvents bootcdpanel As Panel
    Friend WithEvents allowbootfromcd As CheckBox
    Friend WithEvents cddrives As ComboBox
End Class
