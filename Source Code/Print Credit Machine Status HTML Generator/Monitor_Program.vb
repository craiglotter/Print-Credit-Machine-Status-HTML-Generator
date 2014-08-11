Imports Microsoft.Win32
Imports System.IO
Imports System.Xml


Public Class Monitor_Program
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Monitor_Program))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(8, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 121)
        Me.Panel1.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.254!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(136, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 14)
        Me.Label14.TabIndex = 37
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label13
        '
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.254!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(8, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 14)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "<Click here to view listing>"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label12.Location = New System.Drawing.Point(144, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 16)
        Me.Label12.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label11.Location = New System.Drawing.Point(144, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 16)
        Me.Label11.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label10.Location = New System.Drawing.Point(144, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 16)
        Me.Label10.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(16, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 26)
        Me.Label7.TabIndex = 32
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Last Listing:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "No. Pages Generated:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Program Launched:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(224, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Monitoring"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(200, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(184, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(168, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(152, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(136, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 32)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Firebrick
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Status  Monitor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Goldenrod
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(202, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(136, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Config"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenu = Me.ContextMenu1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Print Credit Machine Status HTML Generator"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Display Monitor Screen"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Exit Application"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.254!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Khaki
        Me.Label15.Location = New System.Drawing.Point(224, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 14)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Force Generation"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Monitor_Program
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(322, 160)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Monitor_Program"
        Me.ShowInTaskbar = False
        Me.Text = "PCM Status HTML Generator"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private current_light As Integer = 0
    Private current_colour As Integer = 0

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

    Private process_directory As String = Application.StartupPath & "\Processing\"

    Private CashBoxLevel As Long = 0

    Private BusyWorking As Boolean = False

    Private WithEvents cform As Config



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



            Timer1.Stop()
            Timer1.Interval = interval * 60 * 1000
            Label7.Text = "Next Check: " & Format(Now().AddMinutes(Double.Parse(interval)), "yyyy/MM/dd HH:mm:ss")
            Timer1.Start()

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading required registry values. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub mConfigUpdate() Handles cform.ConfigUpdate
        Try
            Load_Registry_Values()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while implementing Configuration changes. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub run_green_lights()
        Try
            Label1.ForeColor = Color.LimeGreen
            Label1.Text = "Monitoring"

            current_light = current_light - 1
            If current_light < 1 Then
                current_light = 5
            End If
            current_colour = 0
            PictureBox1.Image = ImageList1.Images(1)
            PictureBox2.Image = ImageList1.Images(1)
            PictureBox3.Image = ImageList1.Images(1)
            PictureBox4.Image = ImageList1.Images(1)
            PictureBox5.Image = ImageList1.Images(1)

            Select Case current_light
                Case 0

                    PictureBox1.Image = ImageList1.Images(0)
                Case 1

                    PictureBox2.Image = ImageList1.Images(0)
                Case 2

                    PictureBox3.Image = ImageList1.Images(0)
                Case 3

                    PictureBox4.Image = ImageList1.Images(0)
                Case 4

                    PictureBox5.Image = ImageList1.Images(0)
                Case 5

                    PictureBox1.Image = ImageList1.Images(0)
            End Select

            current_light = current_light + 1
            If current_light > 5 Then
                current_light = 1
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while changing status light colour. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub run_orange_lights()
        Try
            Label1.ForeColor = Color.DarkOrange
            Label1.Text = "Working"

            current_light = current_light - 1
            If current_light < 1 Then
                current_light = 5
            End If
            current_colour = 1
            PictureBox1.Image = ImageList1.Images(3)
            PictureBox2.Image = ImageList1.Images(3)
            PictureBox3.Image = ImageList1.Images(3)
            PictureBox4.Image = ImageList1.Images(3)
            PictureBox5.Image = ImageList1.Images(3)
            Select Case current_light
                Case 0
                    PictureBox1.Image = ImageList1.Images(2)
                Case 1
                    PictureBox2.Image = ImageList1.Images(2)
                Case 2
                    PictureBox3.Image = ImageList1.Images(2)
                Case 3
                    PictureBox4.Image = ImageList1.Images(2)
                Case 4
                    PictureBox5.Image = ImageList1.Images(2)
                Case 5
                    PictureBox1.Image = ImageList1.Images(2)
            End Select

            current_light = current_light + 1
            If current_light > 5 Then
                current_light = 1
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while changing status light colour. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub run_lights()
        Try
            If current_colour = 1 Then
                Select Case current_light
                    Case 0
                        PictureBox5.Image = ImageList1.Images(3)
                        PictureBox1.Image = ImageList1.Images(2)
                    Case 1
                        PictureBox1.Image = ImageList1.Images(3)
                        PictureBox2.Image = ImageList1.Images(2)
                    Case 2
                        PictureBox2.Image = ImageList1.Images(3)
                        PictureBox3.Image = ImageList1.Images(2)
                    Case 3
                        PictureBox3.Image = ImageList1.Images(3)
                        PictureBox4.Image = ImageList1.Images(2)
                    Case 4
                        PictureBox4.Image = ImageList1.Images(3)
                        PictureBox5.Image = ImageList1.Images(2)
                    Case 5
                        PictureBox5.Image = ImageList1.Images(3)
                        PictureBox1.Image = ImageList1.Images(2)
                End Select
            Else
                Select Case current_light
                    Case 0
                        PictureBox5.Image = ImageList1.Images(1)
                        PictureBox1.Image = ImageList1.Images(0)
                    Case 1
                        PictureBox1.Image = ImageList1.Images(1)
                        PictureBox2.Image = ImageList1.Images(0)
                    Case 2
                        PictureBox2.Image = ImageList1.Images(1)
                        PictureBox3.Image = ImageList1.Images(0)
                    Case 3
                        PictureBox3.Image = ImageList1.Images(1)
                        PictureBox4.Image = ImageList1.Images(0)
                    Case 4
                        PictureBox4.Image = ImageList1.Images(1)
                        PictureBox5.Image = ImageList1.Images(0)
                    Case 5
                        PictureBox5.Image = ImageList1.Images(1)
                        PictureBox1.Image = ImageList1.Images(0)
                End Select

            End If

            current_light = current_light + 1
            If current_light > 5 Then
                current_light = 1
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            run_lights()
            Label8.Text = Format(Now(), "yyyy/MM/dd HH:mm:ss")
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the status light strip. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Monitor_Program_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label8.Text = Format(Now(), "yyyy/MM/dd HH:mm:ss")
            Label10.Text = Format(Now(), "yyyy/MM/dd HH:mm:ss")
            Label11.Text = "0"
            Load_Registry_Values()
            Timer1.Start()
            Timer2.Start()


        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the monitoring screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub monitor_program_closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            NotifyIcon1.Dispose()
            Application.Exit()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing the Monitoring screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub CodeExecute()
        Timer1.Stop()
        run_orange_lights()
        BusyWorking = True
        Try



            Try
                Write_Head()
                Write_1st_Half()
                If display2.Equals("checked") Then
                    'Write_Open_Table()
                    read_database_status(False, True)
                    'Write_Mid_Table()
                    read_database_status(True, False)
                    'Write_Close_Table()
                End If
                If display1.Equals("checked") Then
                    read_machine_status()
                Else
                    read_machine_status(False)
                End If
                If display1.Equals("checked") And display2.Equals("checked") And display3.Equals("checked") Then
                    Write_Middle()
                End If
                If display3.Equals("checked") Then
                    read_currentshift_status()
                End If
                Write_2nd_Half()
                Write_Tail()
                Label11.Text = Long.Parse(Label11.Text) + 1
                If Not Label11.Text = "0" Then
                    Label13.Enabled = True
                End If
                Label12.Text = Format(Now(), "yyyy/MM/dd HH:mm:ss")
            Catch ex As Exception
                Error_Handler("An """ & ex.Message & """ error occurred. The program will attempt to recover shortly.")
            End Try

          
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred. The program will attempt to recover shortly.")
        End Try
        BusyWorking = False
        Label7.Text = "Next Check: " & Format(Now().AddMinutes(Double.Parse(interval)), "yyyy/MM/dd HH:mm:ss")
        run_green_lights()

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If BusyWorking = False Then
            CodeExecute()
        End If

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Try
            Dim cform As New Config
            Dim result As DialogResult
            result = cform.ShowDialog()
            If result = DialogResult.OK Then
                Load_Registry_Values()
            End If
            cform.Dispose()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while loading the configuration screen. The program will attempt to recover shortly.")
        End Try
    End Sub



    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Try
            NotifyIcon1.Dispose()
            Application.Exit()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while closing Print Credit Machine Status HTML Generator. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub show_application()
        Try
            Me.Opacity = 1

            Me.BringToFront()
            Me.Refresh()
            Me.WindowState = FormWindowState.Normal

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while trying to display the main screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub NotifyIcon1_dblclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        show_application()
    End Sub
    Private Sub NotifyIcon1_snglclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        show_application()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        show_application()
    End Sub

    Private Sub monitor_program_resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try

            If Me.WindowState = FormWindowState.Minimized Then
                NotifyIcon1.Visible = True
                Me.Opacity = 0
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while trying to display the main screen. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        Try
            If File.Exists(filetocreate) = True Then
                System.Diagnostics.Process.Start(filetocreate)
            Else
                Error_Handler("The file """ & filetocreate & """ containing the last generated status reading can not be located.")
            End If

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while opening the generated status reading. The program will attempt to recover shortly.")
        End Try
    End Sub



    Private Sub read_database_status(ByVal present As Boolean, ByVal writetitle As Boolean)
        Dim Conn As Data.OleDb.OleDbConnection
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            If writetitle = True Then
                objStreamWriter.WriteLine("<h2>Transaction Log Summary</h2>")
            End If

            Dim localdatabasefilename As String
            localdatabasefilename = databasefilename
            Dim locallogyear As String
            locallogyear = logyear
            If present = False Then
                Try
                    If IsNumeric(locallogyear) = True Then
                        locallogyear = (CInt(locallogyear) - 1).ToString
                    End If
                    localdatabasefilename = localdatabasefilename.Replace(logyear, locallogyear)
                Catch ex As Exception
                    localdatabasefilename = databasefilename
                    locallogyear = logyear
                End Try
            End If

            If File.Exists(localdatabasefilename) = True And Not localdatabasefilename = "" Then
                Try
                    Conn = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & localdatabasefilename & ";")
                    Conn.Open()
                    Dim SQL As String
                    SQL = "Select tAmount from Transaction_Log where TDate_Inputted like ""%" & locallogyear & "%"""
                    Dim recset As Data.OleDb.OleDbCommand = New Data.OleDb.OleDbCommand(SQL, Conn)
                    Dim recreader As Data.OleDb.OleDbDataReader
                    recreader = recset.ExecuteReader(CommandBehavior.Default)
                    objStreamWriter.WriteLine("<p>")
                    Dim total_transactions As Long = 0
                    Dim total_value As Long = 0
                    Dim display_total_value As Double
                    While recreader.Read()
                        'objStreamWriter.WriteLine("" & recreader.GetString(0).ToString & "<br>")
                        total_transactions = total_transactions + 1
                        total_value = total_value + Long.Parse(recreader.GetString(0).ToString)
                    End While
                    display_total_value = Double.Parse(total_value) / 100
                    objStreamWriter.WriteLine("Year: " & locallogyear & "<br>")
                    objStreamWriter.WriteLine("Total Transactions: " & total_transactions & "<br>")
                    objStreamWriter.WriteLine("Total Value: R" & display_total_value & "<br>")
                    objStreamWriter.WriteLine("</p>")
                    recreader.Close()
                    recset.Dispose()
                    Conn.Close()
                    Conn.Dispose()
                Catch ex As Exception
                    Conn.Close()
                    Error_Handler("An """ & ex.Message & """ error occurred while reading the database status. The program will attempt to recover shortly.")
                    objStreamWriter.WriteLine("<p>Error in reading Transaction Log Database.</p>")
                End Try
            Else
                objStreamWriter.WriteLine("<p>Unable to locate Transaction Log Database.</p>")
            End If
            objStreamWriter.Close()

        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while reading the database status. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub read_currentshift_status()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("<h2>Current Shift Details</h2>")
            If File.Exists(foldertomonitor & shiftfilename) Then
                If Not File.GetAttributes(foldertomonitor & shiftfilename) = FileAttributes.ReadOnly Then
                    If File.Exists(process_directory & shiftfilename) = True Then
                        File.Delete(process_directory & shiftfilename)
                    End If

                    File.Move(foldertomonitor & shiftfilename, process_directory & shiftfilename)


                    Dim ProcID As Integer
                    ProcID = Shell("""" & Application.StartupPath & "\CurrentShift XML Generator.exe"" """ & process_directory & shiftfilename & """ """ & process_directory & "processshift.xml""", AppWinStyle.Hide, True, -1)


                    Dim xread As XmlTextReader = New XmlTextReader(process_directory & "processshift.xml")


                    xread.WhitespaceHandling = WhitespaceHandling.None


                    xread.Read()
                    xread.Read()
                    xread.Read()

                    Dim tNumber, tChannel1, tChannel2, tChannel3, tChannel4, tChannel5, tChannel6, tDateTime As String

                    tNumber = xread.ReadElementString("Number")
                    tChannel1 = xread.ReadElementString("Channel1")
                    tChannel2 = xread.ReadElementString("Channel2")
                    tChannel3 = xread.ReadElementString("Channel3")
                    tChannel4 = xread.ReadElementString("Channel4")
                    tChannel5 = xread.ReadElementString("Channel5")
                    tChannel6 = xread.ReadElementString("Channel6")
                    tDateTime = xread.ReadElementString("DateTime")

                    objStreamWriter.WriteLine("<p>Current Shift: " & tNumber & "<br>")
                    Dim dt As Date = New Date(1899, 12, 30)
                    Dim dou As Double
                    dou = Double.Parse(tDateTime)
                    dt = dt.AddDays(Fix(dou))


                    objStreamWriter.WriteLine("Shift Started: " & Format(dt, "yyyy/MM/dd") & "</p>")
                    objStreamWriter.WriteLine("<table border=""1"" style=""border-collapse: collapse"" cellspacing=""0"" cellpadding=""5"">")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td><b>Denomination</b></td><td><b>Count</b></td><td><b>Value</b></td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td>R10</td><td>" & tChannel1 & "</td><td>R" & tChannel1 * 10 & "</td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td>R20</td><td>" & tChannel2 & "</td><td>R" & tChannel2 * 20 & "</td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td>R50</td><td>" & tChannel3 & "</td><td>R" & tChannel3 * 50 & "</td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td>R100</td><td>" & tChannel4 & "</td><td>R" & tChannel4 * 100 & "</td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td>R200</td><td>" & tChannel5 & "</td><td>R" & tChannel5 * 200 & "</td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("<tr>")
                    objStreamWriter.WriteLine("<td>Total</td><td>" & Integer.Parse(tChannel1) + Integer.Parse(tChannel2) + Integer.Parse(tChannel3) + Integer.Parse(tChannel4) + Integer.Parse(tChannel5) & "</td><td>R" & (tChannel1 * 10) + (tChannel2 * 20) + (tChannel3 * 50) + (tChannel4 * 100) + (tChannel5 * 200) & "</td>")
                    objStreamWriter.WriteLine("</tr>")
                    objStreamWriter.WriteLine("</table>")
                    xread.Close()


                    If File.Exists(foldertomonitor & shiftfilename) = False Then
                        File.Copy(process_directory & shiftfilename, foldertomonitor & shiftfilename)
                    End If


                    File.Delete(process_directory & shiftfilename)
                    File.Delete(process_directory & "processshift.xml")

                Else
                    objStreamWriter.WriteLine("<p>Current Shift file is currently in use.</p>")

                End If
            Else
                objStreamWriter.WriteLine("<p>Unable to locate Current Shift file.</p>")

            End If

            objStreamWriter.Close()


        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while reading the Print Credit Machine shift file. The program will attempt to recover shortly.")
        End Try
    End Sub




    Private Sub read_machine_status(Optional ByVal writetofile As Boolean = True)
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            If writetofile = True Then
                objStreamWriter.WriteLine("<h2>Status File Contents</h2>")
            End If
            If File.Exists(foldertomonitor & statusfilename) Then
                If Not File.GetAttributes(foldertomonitor & statusfilename) = FileAttributes.ReadOnly Then
                    If File.Exists(process_directory & statusfilename) = True Then
                        File.Delete(process_directory & statusfilename)
                    End If

                    File.Move(foldertomonitor & statusfilename, process_directory & statusfilename)

                    Dim reader As StreamReader = New StreamReader(process_directory & statusfilename)
                    Dim readstring As String = ""
                    Dim checkstring As String = ""
                    If writetofile = True Then
                        objStreamWriter.WriteLine("<p>")
                    End If
                    Do While reader.Peek() >= 0
                        readstring = reader.ReadLine()
                        If writetofile = True Then
                            objStreamWriter.WriteLine("" & readstring & "<br>")
                        End If
                        If readstring.StartsWith("CashBoxLevel") Then
                            Try
                                CashBoxLevel = Long.Parse(readstring.Replace("CashBoxLevel=", "").Trim())
                            Catch ex As Exception
                                CashBoxLevel = 0
                            End Try
                        End If
                    Loop
                    If writetofile = True Then
                        objStreamWriter.WriteLine("</p>")
                    End If
                    reader.Close()

                    File.Delete(process_directory & statusfilename)

                Else
                    If writetofile = True Then
                        objStreamWriter.WriteLine("<p>System Status file is currently in use.</p>")
                    End If

                End If
            Else
                If writetofile = True Then
                    objStreamWriter.WriteLine("<p>Unable to locate System Status file.</p>")
                End If

            End If

            objStreamWriter.Close()


        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while reading the Print Credit Machine status file. The program will attempt to recover shortly.")
        End Try


    End Sub



    Private Sub Write_Head()
        Try
            Dim outputpath As String = filetocreate
            Dim inputpath As String = foldertomonitor
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, False, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("<html>")
            objStreamWriter.WriteLine("<head>")
            objStreamWriter.WriteLine("<meta http-equiv=""refresh"" content=""60"">")
            objStreamWriter.WriteLine("</head>")
            objStreamWriter.WriteLine("<LINK href=""http://www.commerce.uct.ac.za/Commerce_Home_Pages/Includes/Stylesheet/Commerce_Home_Pages_Stylesheet.css"" type=""text/css"" rel=""STYLESHEET"">")
            objStreamWriter.WriteLine("<style>")
            objStreamWriter.WriteLine("<!--")
            objStreamWriter.WriteLine("body            { background:#FFFFFF url('http://www.commerce.uct.ac.za/services/newsfeed/flag.jpg') no-repeat; }")
            objStreamWriter.WriteLine("-->")
            objStreamWriter.WriteLine("</style>")



            objStreamWriter.WriteLine("<body>")


            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_Tail()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("<br><br>")
            objStreamWriter.WriteLine("<div align=""center"">")
            objStreamWriter.WriteLine("<table border=""0"" width=""85%"" style=""border-collapse: collapse"" cellspacing=""0"" cellpadding=""5"">")
            objStreamWriter.WriteLine("<tr><td align=""left"" valign=""top"">")
            objStreamWriter.WriteLine("<p><font size=""1"">Print Credit Machine Status HTML Generator 1.0<br>")

            objStreamWriter.WriteLine("File generated at: " & Format(Now(), "yyyy/MM/dd HH:mm:ss") & "<br>")
            objStreamWriter.WriteLine("Next Update at: " & Format(Now().AddMinutes(Double.Parse(interval)), "yyyy/MM/dd HH:mm:ss") & "</font></p>")
            objStreamWriter.WriteLine("</td></tr>")
            objStreamWriter.WriteLine("</table>")
            objStreamWriter.WriteLine("</div>")
            objStreamWriter.WriteLine("</body>")
            objStreamWriter.WriteLine("</html>")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_1st_Half()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("<div align=""center"">")
            objStreamWriter.WriteLine("<table border=""1"" width=""85%"" style=""border-collapse: collapse"" cellspacing=""0"" cellpadding=""5"">")
            objStreamWriter.WriteLine("<tr><td align=""left"" valign=""top"">")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_Middle()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)

            objStreamWriter.WriteLine("</td><td align=""left"" valign=""top"">")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_2nd_Half()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.writeline("<p>Current Level: " & System.Math.Round(((CashBoxLevel / 1000) * 100), 1) & "%</p>")
            objStreamWriter.WriteLine("</td></tr>")
            objStreamWriter.WriteLine("</table>")
            objStreamWriter.WriteLine("</div>")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_Open_Table()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.writeline("<table>")
            objStreamWriter.WriteLine("<tr><td>")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_Mid_Table()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("</td><td>")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Write_Close_Table()
        Try
            Dim outputpath As String = filetocreate
            Dim filemanipulator2 = New System.IO.FileInfo(outputpath)
            Dim objStreamWriter = New System.IO.StreamWriter(outputpath, True, System.Text.Encoding.Unicode)
            objStreamWriter.WriteLine("</td></tr>")
            objStreamWriter.writeline("</table>")
            objStreamWriter.Close()
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while generating the file listing. The program will attempt to recover shortly.")
        End Try
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        If BusyWorking = False Then
            CodeExecute()
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
