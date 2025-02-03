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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkbSeePassword = New System.Windows.Forms.CheckBox()
        Me.txtbCallsign = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.btnDowload = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCounter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calTo = New System.Windows.Forms.MonthCalendar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbNew = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.txtbQSLctr = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.calFrom = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShowList = New System.Windows.Forms.Button()
        Me.chkbFullRange = New System.Windows.Forms.CheckBox()
        Me.chkbSaveLogs = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDateTo = New System.Windows.Forms.Button()
        Me.btnDateFrom = New System.Windows.Forms.Button()
        Me.txtbDateTo = New System.Windows.Forms.MaskedTextBox()
        Me.txtbDateFrom = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExplorer = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Callsign"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pass"
        '
        'chkbSeePassword
        '
        Me.chkbSeePassword.AutoSize = True
        Me.chkbSeePassword.Location = New System.Drawing.Point(22, 98)
        Me.chkbSeePassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkbSeePassword.Name = "chkbSeePassword"
        Me.chkbSeePassword.Size = New System.Drawing.Size(136, 24)
        Me.chkbSeePassword.TabIndex = 1
        Me.chkbSeePassword.Text = "See password"
        Me.chkbSeePassword.UseVisualStyleBackColor = True
        '
        'txtbCallsign
        '
        Me.txtbCallsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbCallsign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCallsign.Location = New System.Drawing.Point(92, 18)
        Me.txtbCallsign.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbCallsign.Name = "txtbCallsign"
        Me.txtbCallsign.Size = New System.Drawing.Size(102, 26)
        Me.txtbCallsign.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtbCallsign, "Write a new callsign")
        '
        'txtbPassword
        '
        Me.txtbPassword.Location = New System.Drawing.Point(72, 58)
        Me.txtbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(162, 26)
        Me.txtbPassword.TabIndex = 3
        Me.txtbPassword.UseSystemPasswordChar = True
        '
        'btnDowload
        '
        Me.btnDowload.Location = New System.Drawing.Point(18, 343)
        Me.btnDowload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDowload.Name = "btnDowload"
        Me.btnDowload.Size = New System.Drawing.Size(94, 35)
        Me.btnDowload.TabIndex = 4
        Me.btnDowload.Text = "Download"
        Me.btnDowload.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCounter, Me.tsslProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(895, 32)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(59, 25)
        Me.tsslStatus.Text = "status"
        '
        'tsslCounter
        '
        Me.tsslCounter.Name = "tsslCounter"
        Me.tsslCounter.Size = New System.Drawing.Size(72, 25)
        Me.tsslCounter.Text = "counter"
        '
        'tsslProgress
        '
        Me.tsslProgress.Name = "tsslProgress"
        Me.tsslProgress.Size = New System.Drawing.Size(150, 24)
        Me.tsslProgress.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(146, 343)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(90, 35)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse >"
        Me.ToolTip1.SetToolTip(Me.btnBrowse, "Open browsing panel to the right")
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(159, 428)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.calTo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.calFrom)
        Me.Panel1.Location = New System.Drawing.Point(244, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 461)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(627, 408)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'calTo
        '
        Me.calTo.Location = New System.Drawing.Point(164, 59)
        Me.calTo.Margin = New System.Windows.Forms.Padding(14)
        Me.calTo.Name = "calTo"
        Me.calTo.TabIndex = 10
        Me.calTo.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbNew)
        Me.Panel2.Controls.Add(Me.rbAll)
        Me.Panel2.Controls.Add(Me.txtbQSLctr)
        Me.Panel2.Controls.Add(Me.btnFirst)
        Me.Panel2.Controls.Add(Me.btnPrevious)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnLast)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 408)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(627, 49)
        Me.Panel2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Panel2, "Alphanumeric, left arrow, right arrow," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "home and end keys to navigate")
        '
        'rbNew
        '
        Me.rbNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbNew.AutoSize = True
        Me.rbNew.Location = New System.Drawing.Point(164, 5)
        Me.rbNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbNew.Name = "rbNew"
        Me.rbNew.Size = New System.Drawing.Size(50, 30)
        Me.rbNew.TabIndex = 6
        Me.rbNew.Text = "New"
        Me.ToolTip1.SetToolTip(Me.rbNew, "Show only last downloaded QSLs")
        Me.rbNew.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(112, 5)
        Me.rbAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(36, 30)
        Me.rbAll.TabIndex = 5
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All"
        Me.ToolTip1.SetToolTip(Me.rbAll, "Show all QSLs")
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'txtbQSLctr
        '
        Me.txtbQSLctr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbQSLctr.Location = New System.Drawing.Point(278, 12)
        Me.txtbQSLctr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbQSLctr.Name = "txtbQSLctr"
        Me.txtbQSLctr.ReadOnly = True
        Me.txtbQSLctr.ShortcutsEnabled = False
        Me.txtbQSLctr.Size = New System.Drawing.Size(128, 19)
        Me.txtbQSLctr.TabIndex = 4
        Me.txtbQSLctr.TabStop = False
        Me.txtbQSLctr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFirst
        '
        Me.btnFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFirst.AutoSize = True
        Me.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFirst.Location = New System.Drawing.Point(4, 10)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(37, 30)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.btnFirst, "Home")
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.AutoSize = True
        Me.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrevious.Location = New System.Drawing.Point(57, 10)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(28, 30)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btnPrevious, "Left")
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.AutoSize = True
        Me.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNext.Location = New System.Drawing.Point(542, 10)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(28, 30)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Right")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLast.AutoSize = True
        Me.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLast.Location = New System.Drawing.Point(586, 10)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(37, 30)
        Me.btnLast.TabIndex = 0
        Me.btnLast.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.btnLast, "End")
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'calFrom
        '
        Me.calFrom.Location = New System.Drawing.Point(-19, 180)
        Me.calFrom.Margin = New System.Windows.Forms.Padding(14)
        Me.calFrom.Name = "calFrom"
        Me.calFrom.ShowWeekNumbers = True
        Me.calFrom.TabIndex = 4
        Me.calFrom.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(18, 424)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Help..."
        Me.ToolTip1.SetToolTip(Me.Button1, "Help")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnShowList
        '
        Me.btnShowList.AutoSize = True
        Me.btnShowList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShowList.Location = New System.Drawing.Point(200, 15)
        Me.btnShowList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowList.Name = "btnShowList"
        Me.btnShowList.Size = New System.Drawing.Size(31, 30)
        Me.btnShowList.TabIndex = 5
        Me.btnShowList.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnShowList, "Show list of available downloads so far.")
        Me.btnShowList.UseVisualStyleBackColor = True
        '
        'chkbFullRange
        '
        Me.chkbFullRange.AutoSize = True
        Me.chkbFullRange.Checked = True
        Me.chkbFullRange.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbFullRange.Location = New System.Drawing.Point(9, 29)
        Me.chkbFullRange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkbFullRange.Name = "chkbFullRange"
        Me.chkbFullRange.Size = New System.Drawing.Size(52, 24)
        Me.chkbFullRange.TabIndex = 1
        Me.chkbFullRange.Text = "All"
        Me.ToolTip1.SetToolTip(Me.chkbFullRange, "No date limits")
        Me.chkbFullRange.UseVisualStyleBackColor = True
        '
        'chkbSaveLogs
        '
        Me.chkbSaveLogs.AutoSize = True
        Me.chkbSaveLogs.Location = New System.Drawing.Point(18, 308)
        Me.chkbSaveLogs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkbSaveLogs.Name = "chkbSaveLogs"
        Me.chkbSaveLogs.Size = New System.Drawing.Size(104, 24)
        Me.chkbSaveLogs.TabIndex = 11
        Me.chkbSaveLogs.Text = "Save logs"
        Me.ToolTip1.SetToolTip(Me.chkbSaveLogs, "Save logs. One file per download operation")
        Me.chkbSaveLogs.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(92, 48)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(142, 84)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 5
        Me.ListBox1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.btnDateTo)
        Me.GroupBox1.Controls.Add(Me.btnDateFrom)
        Me.GroupBox1.Controls.Add(Me.txtbDateTo)
        Me.GroupBox1.Controls.Add(Me.txtbDateFrom)
        Me.GroupBox1.Controls.Add(Me.chkbFullRange)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 134)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(216, 163)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date range"
        '
        'btnDateTo
        '
        Me.btnDateTo.Enabled = False
        Me.btnDateTo.Location = New System.Drawing.Point(170, 103)
        Me.btnDateTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDateTo.Name = "btnDateTo"
        Me.btnDateTo.Size = New System.Drawing.Size(38, 31)
        Me.btnDateTo.TabIndex = 3
        Me.btnDateTo.Text = "..."
        Me.btnDateTo.UseVisualStyleBackColor = True
        '
        'btnDateFrom
        '
        Me.btnDateFrom.Enabled = False
        Me.btnDateFrom.Location = New System.Drawing.Point(170, 65)
        Me.btnDateFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDateFrom.Name = "btnDateFrom"
        Me.btnDateFrom.Size = New System.Drawing.Size(38, 31)
        Me.btnDateFrom.TabIndex = 3
        Me.btnDateFrom.Text = "..."
        Me.btnDateFrom.UseVisualStyleBackColor = True
        '
        'txtbDateTo
        '
        Me.txtbDateTo.Enabled = False
        Me.txtbDateTo.Location = New System.Drawing.Point(63, 105)
        Me.txtbDateTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbDateTo.Mask = "00/00/0000"
        Me.txtbDateTo.Name = "txtbDateTo"
        Me.txtbDateTo.Size = New System.Drawing.Size(102, 26)
        Me.txtbDateTo.TabIndex = 2
        Me.txtbDateTo.ValidatingType = GetType(Date)
        '
        'txtbDateFrom
        '
        Me.txtbDateFrom.Enabled = False
        Me.txtbDateFrom.Location = New System.Drawing.Point(63, 65)
        Me.txtbDateFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbDateFrom.Mask = "00/00/0000"
        Me.txtbDateFrom.Name = "txtbDateFrom"
        Me.txtbDateFrom.Size = New System.Drawing.Size(102, 26)
        Me.txtbDateFrom.TabIndex = 2
        Me.txtbDateFrom.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        '
        'btnExplorer
        '
        Me.btnExplorer.Location = New System.Drawing.Point(146, 383)
        Me.btnExplorer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExplorer.Name = "btnExplorer"
        Me.btnExplorer.Size = New System.Drawing.Size(90, 35)
        Me.btnExplorer.TabIndex = 6
        Me.btnExplorer.Text = "Explore..."
        Me.ToolTip1.SetToolTip(Me.btnExplorer, "Explore <callsign> folder")
        Me.btnExplorer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(895, 507)
        Me.Controls.Add(Me.chkbSaveLogs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnShowList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExplorer)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnDowload)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.txtbCallsign)
        Me.Controls.Add(Me.chkbSeePassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(242, 510)
        Me.Name = "Form1"
        Me.Text = "eQSLcc Downloader"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkbSeePassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtbCallsign As System.Windows.Forms.TextBox
    Friend WithEvents txtbPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnDowload As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslCounter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents tsslProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtbQSLctr As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnShowList As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents rbNew As System.Windows.Forms.RadioButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDateTo As System.Windows.Forms.Button
    Friend WithEvents btnDateFrom As System.Windows.Forms.Button
    Friend WithEvents txtbDateTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtbDateFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkbFullRange As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents calFrom As System.Windows.Forms.MonthCalendar
    Friend WithEvents calTo As System.Windows.Forms.MonthCalendar
    Friend WithEvents chkbSaveLogs As System.Windows.Forms.CheckBox
    Friend WithEvents btnExplorer As Button
End Class
