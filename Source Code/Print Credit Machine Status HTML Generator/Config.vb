Imports Microsoft.Win32

Public Class Config
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Config))
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(200, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "OK"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(280, 224)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 184)
        Me.Panel1.TabIndex = 9
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox7.Controls.Add(Me.TextBox6)
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(224, 120)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(108, 46)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Shift Filename"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Location = New System.Drawing.Point(8, 16)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(92, 20)
        Me.TextBox6.TabIndex = 0
        Me.TextBox6.Text = "CurrentShift.rec"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(112, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 46)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status Filename"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(8, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "CurrentStatus.dat"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(98, 46)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monitor Interval"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Location = New System.Drawing.Point(8, 16)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(82, 20)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(324, 46)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "File to Create"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(260, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 16)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "BROWSE"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(8, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "C:\inetpub\wwwroot\index.htm"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 46)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folder to Monitor"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 16)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BROWSE"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(8, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "C:\PVU_Records"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Firebrick
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Configuration Options"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Default Values"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the required folder below:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(253, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Page 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Location = New System.Drawing.Point(8, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 184)
        Me.Panel2.TabIndex = 21
        Me.Panel2.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CheckBox2)
        Me.GroupBox8.Controls.Add(Me.CheckBox3)
        Me.GroupBox8.Controls.Add(Me.CheckBox1)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(164, 64)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(168, 80)
        Me.GroupBox8.TabIndex = 24
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Display Options"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(8, 36)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(158, 16)
        Me.CheckBox2.TabIndex = 25
        Me.CheckBox2.Text = "Transaction Log Summary"
        '
        'CheckBox3
        '
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(8, 52)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(131, 16)
        Me.CheckBox3.TabIndex = 26
        Me.CheckBox3.Text = "Current Shift Details"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(8, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 16)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Status File Contents"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(112, 46)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Log Year"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(8, 16)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(96, 20)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(324, 46)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Logs Database"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Firebrick
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(260, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 16)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "BROWSE"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(8, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(248, 20)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Goldenrod
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(302, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Page 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "mdb"
        Me.OpenFileDialog1.Filter = "MS Access files|*.mdb|All files|*.*"
        Me.OpenFileDialog1.Title = "Select Logs Database"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "BUILD 20060213.3"
        '
        'Config
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(362, 256)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(368, 288)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(368, 288)
        Me.Name = "Config"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration Options"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public foldertomonitor As String
    Public interval As String
    Public filetocreate As String
    Public statusfilename As String
    Public databasefilename As String
    Public logyear As String
    Public shiftfilename As String
    Public display1 As String 'Status File Contents
    Public display2 As String 'Transaction Log Summary
    Public display3 As String 'Current Shift Details

    

    Public Event ConfigUpdate()

    Private Sub Error_Handler(ByVal message As String)
        Try
            Dim Display_Message1 As New Display_Message(message)
            Display_Message1.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred in Print Credit Machine Status HTML Generator's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Public Sub Load_Registry_Values()
        Try


            Dim configflag As Boolean
            configflag = False
            Dim str As String
            Dim keyflag1 As Boolean = False
            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim keys() As String = oReg.GetSubKeyNames()
            System.Array.Sort(keys)

            For Each str In keys
                If str.Equals("Software\Print Credit Machine Status HTML Generator") = True Then
                    keyflag1 = True
                    Exit For
                End If
            Next str

            If keyflag1 = False Then
                oReg.CreateSubKey("Software\Print Credit Machine Status HTML Generator")
            End If

            keyflag1 = False

            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\Print Credit Machine Status HTML Generator", True)

            str = oKey.GetValue("filetocreate")
            If Not IsNothing(str) And Not (str = "") Then
                filetocreate = str
            Else
                configflag = True
                oKey.SetValue("filetocreate", "C:\inetpub\wwwroot\index.htm")
                filetocreate = "C:\inetpub\wwwroot\index.htm"
            End If

            str = oKey.GetValue("interval")
            If Not IsNothing(str) And Not (str = "") Then
                interval = str
            Else
                configflag = True
                oKey.SetValue("interval", "30")
                interval = "10"
            End If

            str = oKey.GetValue("foldertomonitor")
            If Not IsNothing(str) And Not (str = "") Then
                foldertomonitor = str
            Else
                configflag = True
                oKey.SetValue("foldertomonitor", "C:\PVU_Records")
                foldertomonitor = "C:\PVU_Records"
            End If

            str = oKey.GetValue("statusfilename")
            If Not IsNothing(str) And Not (str = "") Then
                statusfilename = str
            Else
                configflag = True
                oKey.SetValue("statusfilename", "CurrentStatus.dat")
                statusfilename = "CurrentStatus.dat"
            End If

            str = oKey.GetValue("databasefilename")
            If Not IsNothing(str) And Not (str = "") Then
                databasefilename = str
            Else
                configflag = True
                oKey.SetValue("databasefilename", "C:\" & Year(Now()).ToString & ".mdb")
                databasefilename = "C:\" & Year(Now()).ToString & ".mdb"
            End If

            str = oKey.GetValue("logyear")
            If Not IsNothing(str) And Not (str = "") Then
                logyear = str
            Else
                configflag = True
                oKey.SetValue("logyear", Year(Now()).ToString)
                logyear = Year(Now()).ToString
            End If

            str = oKey.GetValue("shiftfilename")
            If Not IsNothing(str) And Not (str = "") Then
                shiftfilename = str
            Else
                configflag = True
                oKey.SetValue("shiftfilename", "CurrentShift.rec")
                shiftfilename = "CurrentShift.rec"
            End If

            str = oKey.GetValue("display1")
            If Not IsNothing(str) And Not (str = "") Then
                display1 = str
            Else
                configflag = True
                oKey.SetValue("display1", "checked")
                display1 = "checked"
            End If

            str = oKey.GetValue("display2")
            If Not IsNothing(str) And Not (str = "") Then
                display2 = str
            Else
                configflag = True
                oKey.SetValue("display2", "checked")
                display2 = "checked"
            End If

            str = oKey.GetValue("display3")
            If Not IsNothing(str) And Not (str = "") Then
                display3 = str
            Else
                configflag = True
                oKey.SetValue("display3", "checked")
                display3 = "checked"
            End If

            If configflag = True Then
                Dim cform As New Config
                Dim result As DialogResult
                result = cform.ShowDialog()
                If result = DialogResult.OK Then
                    Load_Registry_Values()
                End If
                cform.Dispose()
            End If

            oKey.Close()
            oReg.Close()

            TextBox1.Text = foldertomonitor
            TextBox2.Text = filetocreate
            NumericUpDown1.Value = Integer.Parse(interval)
            TextBox3.Text = statusfilename
            TextBox4.Text = databasefilename
            TextBox5.Text = logyear
            TextBox6.Text = shiftfilename
            If display1.Equals("checked") Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            If display2.Equals("checked") Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If display3.Equals("checked") Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading required registry values. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub default_values()
        Try
            filetocreate = "C:\inetpub\wwwroot\index.htm"
            interval = "30"
            foldertomonitor = "C:\PVU_Records"
            statusfilename = "CurrentStatus.dat"
            databasefilename = "C:\" & Year(Now()).ToString & ".mdb"
            logyear = Year(Now()).ToString
            shiftfilename = "CurrentShift.rec"
            display1 = "checked"
            display2 = "checked"
            display3 = "checked"

            TextBox1.Text = foldertomonitor
            TextBox2.Text = filetocreate
            NumericUpDown1.Value = Integer.Parse(interval)
            TextBox3.Text = statusfilename
            TextBox4.Text = databasefilename
            TextBox5.Text = logyear
            TextBox6.Text = shiftfilename
            If display1.Equals("checked") Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            If display2.Equals("checked") Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If display3.Equals("checked") Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading default registry values. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Save_Registry_Values()
        Try
            If TextBox1.Text.EndsWith("\") = False Then
                TextBox1.Text = TextBox1.Text & "\"
            End If


            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim oKey As RegistryKey = oReg.OpenSubKey("Software\Print Credit Machine Status HTML Generator", True)

            oKey.SetValue("foldertomonitor", TextBox1.Text)
            oKey.SetValue("filetocreate", TextBox2.Text)
            oKey.SetValue("interval", NumericUpDown1.Value.ToString())
            oKey.SetValue("statusfilename", TextBox3.Text)
            oKey.SetValue("databasefilename", TextBox4.Text)
            oKey.SetValue("logyear", TextBox5.Text)
            oKey.SetValue("shiftfilename", TextBox6.Text)
            If CheckBox1.Checked = True Then
                oKey.SetValue("display1", "checked")
            Else
                oKey.SetValue("display1", "unchecked")
            End If
            If CheckBox2.Checked = True Then
                oKey.SetValue("display2", "checked")
            Else
                oKey.SetValue("display2", "unchecked")
            End If
            If CheckBox3.Checked = True Then
                oKey.SetValue("display3", "checked")
            Else
                oKey.SetValue("display3", "unchecked")
            End If

            oKey.Close()
            oReg.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while saving required registry values. The program will attempt to recover shortly.")
        End Try
    End Sub


    Private Sub Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TextBox5.Text = Year(Now()).ToString
            TextBox4.Text = "C:\" & Year(Now()).ToString & ".mdb"
            Load_Registry_Values()

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while opening the config screen. The program will attempt to recover shortly.")
        End Try
    End Sub











    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Save_Registry_Values()
            RaiseEvent ConfigUpdate()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing the config screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Try
            default_values()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while setting up the default configuration. The program will attempt to recover shortly.")
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim result As DialogResult
            result = (FolderBrowserDialog1.ShowDialog())
            If result = DialogResult.OK Then
                TextBox1.Text = FolderBrowserDialog1.SelectedPath
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while launching the folder browser dialog. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim result As DialogResult
            result = (FolderBrowserDialog1.ShowDialog())
            If result = DialogResult.OK Then

                Dim fn As String
                fn = InputBox("Enter the file name of the listing you want to create", "Enter filename", "filelist.htm")
                If IsNothing(fn) = False And Not fn = "" Then
                    TextBox2.Text = FolderBrowserDialog1.SelectedPath & "\" & fn
                End If
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while launching the folder browser dialog. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Try
            Label1.BackColor = Color.DarkGoldenrod
            Label2.BackColor = Color.Goldenrod
            Panel2.Hide()
            Panel1.Show()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while switching between Config panels. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Try
            Label2.BackColor = Color.DarkGoldenrod
            Label1.BackColor = Color.Goldenrod
            Panel1.Hide()
            Panel2.Show()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while switching between Config panels. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim result As DialogResult
            result = OpenFileDialog1.ShowDialog()
            If result = DialogResult.OK Then
                TextBox4.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while browsing for the Logs Database. The program will attempt to recover shortly.")
        End Try
    End Sub
End Class
