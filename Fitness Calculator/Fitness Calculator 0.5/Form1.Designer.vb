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
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtWeightKg = New System.Windows.Forms.TextBox()
        Me.txtHeightCm = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnCalcRMR = New System.Windows.Forms.Button()
        Me.gbxStats = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHeightIn = New System.Windows.Forms.TextBox()
        Me.txtWeightLb = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtForearm = New System.Windows.Forms.TextBox()
        Me.txtHip = New System.Windows.Forms.TextBox()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.txtWrist = New System.Windows.Forms.TextBox()
        Me.txtBodyWeight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcBodyFat = New System.Windows.Forms.Button()
        Me.btnClearBodyFat = New System.Windows.Forms.Button()
        Me.btnClearRMR = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.btnListStats = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayFat = New System.Windows.Forms.Label()
        Me.lblDisplayRMR = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblDisplayWtLb = New System.Windows.Forms.Label()
        Me.lblDisplayWtKg = New System.Windows.Forms.Label()
        Me.lblDisplayHeight = New System.Windows.Forms.Label()
        Me.lblDisplayAge = New System.Windows.Forms.Label()
        Me.lblDisplayGender = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblResultRMR = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblCalculatedFat = New System.Windows.Forms.Label()
        Me.lblCalculatedRMR = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.gbxStats.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(13, 191)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(65, 13)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Weight (kg):"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(14, 217)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(64, 13)
        Me.lblHeight.TabIndex = 1
        Me.lblHeight.Text = "Height (cm):"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(34, 77)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 13)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'txtWeightKg
        '
        Me.txtWeightKg.Location = New System.Drawing.Point(82, 188)
        Me.txtWeightKg.Name = "txtWeightKg"
        Me.txtWeightKg.Size = New System.Drawing.Size(100, 20)
        Me.txtWeightKg.TabIndex = 3
        Me.txtWeightKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHeightCm
        '
        Me.txtHeightCm.Location = New System.Drawing.Point(82, 214)
        Me.txtHeightCm.Name = "txtHeightCm"
        Me.txtHeightCm.Size = New System.Drawing.Size(100, 20)
        Me.txtHeightCm.TabIndex = 4
        Me.txtHeightCm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(66, 74)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(55, 20)
        Me.txtAge.TabIndex = 1
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcRMR
        '
        Me.btnCalcRMR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcRMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcRMR.Location = New System.Drawing.Point(281, 263)
        Me.btnCalcRMR.Name = "btnCalcRMR"
        Me.btnCalcRMR.Size = New System.Drawing.Size(98, 43)
        Me.btnCalcRMR.TabIndex = 1
        Me.btnCalcRMR.Text = "Calculate RMR"
        Me.btnCalcRMR.UseVisualStyleBackColor = False
        '
        'gbxStats
        '
        Me.gbxStats.Controls.Add(Me.Label11)
        Me.gbxStats.Controls.Add(Me.Label10)
        Me.gbxStats.Controls.Add(Me.Label9)
        Me.gbxStats.Controls.Add(Me.txtHeightIn)
        Me.gbxStats.Controls.Add(Me.txtWeightLb)
        Me.gbxStats.Controls.Add(Me.btnConvert)
        Me.gbxStats.Controls.Add(Me.Label2)
        Me.gbxStats.Controls.Add(Me.Label1)
        Me.gbxStats.Controls.Add(Me.lblWeight)
        Me.gbxStats.Controls.Add(Me.lblHeight)
        Me.gbxStats.Controls.Add(Me.txtHeightCm)
        Me.gbxStats.Controls.Add(Me.txtWeightKg)
        Me.gbxStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxStats.Location = New System.Drawing.Point(261, 12)
        Me.gbxStats.Name = "gbxStats"
        Me.gbxStats.Size = New System.Drawing.Size(216, 245)
        Me.gbxStats.TabIndex = 7
        Me.gbxStats.TabStop = False
        Me.gbxStats.Text = "Estimate your Resting Metabolic Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Standard to Metric Converter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Metric Measurements"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "(Cals/day needed to maintain at rest)"
        '
        'txtHeightIn
        '
        Me.txtHeightIn.Location = New System.Drawing.Point(83, 96)
        Me.txtHeightIn.Name = "txtHeightIn"
        Me.txtHeightIn.Size = New System.Drawing.Size(99, 20)
        Me.txtHeightIn.TabIndex = 1
        '
        'txtWeightLb
        '
        Me.txtWeightLb.Location = New System.Drawing.Point(82, 69)
        Me.txtWeightLb.Name = "txtWeightLb"
        Me.txtWeightLb.Size = New System.Drawing.Size(100, 20)
        Me.txtWeightLb.TabIndex = 0
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(20, 122)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(163, 28)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert To Metric"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Height (in):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Weight (lb):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtForearm)
        Me.GroupBox1.Controls.Add(Me.txtHip)
        Me.GroupBox1.Controls.Add(Me.txtWaist)
        Me.GroupBox1.Controls.Add(Me.txtWrist)
        Me.GroupBox1.Controls.Add(Me.txtBodyWeight)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 245)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate Your Body Fat Percentage"
        '
        'txtForearm
        '
        Me.txtForearm.Location = New System.Drawing.Point(149, 160)
        Me.txtForearm.Name = "txtForearm"
        Me.txtForearm.Size = New System.Drawing.Size(100, 20)
        Me.txtForearm.TabIndex = 3
        '
        'txtHip
        '
        Me.txtHip.Location = New System.Drawing.Point(149, 122)
        Me.txtHip.Name = "txtHip"
        Me.txtHip.Size = New System.Drawing.Size(100, 20)
        Me.txtHip.TabIndex = 2
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(149, 83)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(100, 20)
        Me.txtWaist.TabIndex = 1
        '
        'txtWrist
        '
        Me.txtWrist.Location = New System.Drawing.Point(149, 201)
        Me.txtWrist.Name = "txtWrist"
        Me.txtWrist.Size = New System.Drawing.Size(100, 20)
        Me.txtWrist.TabIndex = 4
        '
        'txtBodyWeight
        '
        Me.txtBodyWeight.Location = New System.Drawing.Point(149, 43)
        Me.txtBodyWeight.Name = "txtBodyWeight"
        Me.txtBodyWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtBodyWeight.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 26)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Forearm Circumference (in) : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(widest point)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hip Circumference (in) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(widest point)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Waist Circumference (in) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(at your unbilicus)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Wrist Circumference (in) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(widest point)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Weight (lb) :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcBodyFat
        '
        Me.btnCalcBodyFat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcBodyFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcBodyFat.Location = New System.Drawing.Point(506, 263)
        Me.btnCalcBodyFat.Name = "btnCalcBodyFat"
        Me.btnCalcBodyFat.Size = New System.Drawing.Size(152, 43)
        Me.btnCalcBodyFat.TabIndex = 3
        Me.btnCalcBodyFat.Text = "Calculate Body Fat"
        Me.btnCalcBodyFat.UseVisualStyleBackColor = False
        '
        'btnClearBodyFat
        '
        Me.btnClearBodyFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBodyFat.Location = New System.Drawing.Point(494, 309)
        Me.btnClearBodyFat.Name = "btnClearBodyFat"
        Me.btnClearBodyFat.Size = New System.Drawing.Size(265, 25)
        Me.btnClearBodyFat.TabIndex = 4
        Me.btnClearBodyFat.Text = "Clear"
        Me.btnClearBodyFat.UseVisualStyleBackColor = True
        '
        'btnClearRMR
        '
        Me.btnClearRMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearRMR.Location = New System.Drawing.Point(261, 309)
        Me.btnClearRMR.Name = "btnClearRMR"
        Me.btnClearRMR.Size = New System.Drawing.Size(216, 25)
        Me.btnClearRMR.TabIndex = 2
        Me.btnClearRMR.Text = "Clear"
        Me.btnClearRMR.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(375, 494)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(265, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstUsers
        '
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(12, 253)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(229, 225)
        Me.lstUsers.TabIndex = 6
        '
        'btnListStats
        '
        Me.btnListStats.Location = New System.Drawing.Point(38, 494)
        Me.btnListStats.Name = "btnListStats"
        Me.btnListStats.Size = New System.Drawing.Size(176, 38)
        Me.btnListStats.TabIndex = 5
        Me.btnListStats.Text = "Display User's Statistics"
        Me.btnListStats.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDisplayFat)
        Me.GroupBox2.Controls.Add(Me.lblDisplayRMR)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.lblDisplayWtLb)
        Me.GroupBox2.Controls.Add(Me.lblDisplayWtKg)
        Me.GroupBox2.Controls.Add(Me.lblDisplayHeight)
        Me.GroupBox2.Controls.Add(Me.lblDisplayAge)
        Me.GroupBox2.Controls.Add(Me.lblDisplayGender)
        Me.GroupBox2.Controls.Add(Me.lblDisplayName)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 110)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fitness User's Statistics"
        '
        'lblDisplayFat
        '
        Me.lblDisplayFat.AutoSize = True
        Me.lblDisplayFat.Location = New System.Drawing.Point(416, 49)
        Me.lblDisplayFat.Name = "lblDisplayFat"
        Me.lblDisplayFat.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayFat.TabIndex = 15
        Me.lblDisplayFat.Text = "*"
        '
        'lblDisplayRMR
        '
        Me.lblDisplayRMR.AutoSize = True
        Me.lblDisplayRMR.Location = New System.Drawing.Point(416, 26)
        Me.lblDisplayRMR.Name = "lblDisplayRMR"
        Me.lblDisplayRMR.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayRMR.TabIndex = 14
        Me.lblDisplayRMR.Text = "*"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(196, 73)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = "Weight (lb):"
        '
        'lblDisplayWtLb
        '
        Me.lblDisplayWtLb.AutoSize = True
        Me.lblDisplayWtLb.Location = New System.Drawing.Point(262, 73)
        Me.lblDisplayWtLb.Name = "lblDisplayWtLb"
        Me.lblDisplayWtLb.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayWtLb.TabIndex = 12
        Me.lblDisplayWtLb.Text = "*"
        '
        'lblDisplayWtKg
        '
        Me.lblDisplayWtKg.AutoSize = True
        Me.lblDisplayWtKg.Location = New System.Drawing.Point(262, 49)
        Me.lblDisplayWtKg.Name = "lblDisplayWtKg"
        Me.lblDisplayWtKg.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayWtKg.TabIndex = 11
        Me.lblDisplayWtKg.Text = "*"
        '
        'lblDisplayHeight
        '
        Me.lblDisplayHeight.AutoSize = True
        Me.lblDisplayHeight.Location = New System.Drawing.Point(262, 26)
        Me.lblDisplayHeight.Name = "lblDisplayHeight"
        Me.lblDisplayHeight.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayHeight.TabIndex = 10
        Me.lblDisplayHeight.Text = "*"
        '
        'lblDisplayAge
        '
        Me.lblDisplayAge.AutoSize = True
        Me.lblDisplayAge.Location = New System.Drawing.Point(80, 49)
        Me.lblDisplayAge.Name = "lblDisplayAge"
        Me.lblDisplayAge.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayAge.TabIndex = 9
        Me.lblDisplayAge.Text = "*"
        '
        'lblDisplayGender
        '
        Me.lblDisplayGender.AutoSize = True
        Me.lblDisplayGender.Location = New System.Drawing.Point(80, 73)
        Me.lblDisplayGender.Name = "lblDisplayGender"
        Me.lblDisplayGender.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayGender.TabIndex = 8
        Me.lblDisplayGender.Text = "*"
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.Location = New System.Drawing.Point(80, 25)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(11, 13)
        Me.lblDisplayName.TabIndex = 7
        Me.lblDisplayName.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(33, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Gender:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(358, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Body Fat:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(375, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "RMR:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(194, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Weight (kg):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(195, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Height (cm):"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Age:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Name:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(66, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(151, 20)
        Me.txtName.TabIndex = 0
        '
        'cbxGender
        '
        Me.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxGender.Location = New System.Drawing.Point(66, 111)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(92, 21)
        Me.cbxGender.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Gender:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtAge)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.lblAge)
        Me.GroupBox3.Controls.Add(Me.cbxGender)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 160)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fitness User Profile Information"
        '
        'lblResultRMR
        '
        Me.lblResultRMR.AutoSize = True
        Me.lblResultRMR.Location = New System.Drawing.Point(401, 263)
        Me.lblResultRMR.Name = "lblResultRMR"
        Me.lblResultRMR.Size = New System.Drawing.Size(43, 13)
        Me.lblResultRMR.TabIndex = 31
        Me.lblResultRMR.Text = "Result: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(683, 263)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Result: "
        '
        'lblCalculatedFat
        '
        Me.lblCalculatedFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalculatedFat.Location = New System.Drawing.Point(664, 281)
        Me.lblCalculatedFat.Name = "lblCalculatedFat"
        Me.lblCalculatedFat.Size = New System.Drawing.Size(79, 25)
        Me.lblCalculatedFat.TabIndex = 35
        '
        'lblCalculatedRMR
        '
        Me.lblCalculatedRMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalculatedRMR.Location = New System.Drawing.Point(385, 281)
        Me.lblCalculatedRMR.Name = "lblCalculatedRMR"
        Me.lblCalculatedRMR.Size = New System.Drawing.Size(79, 25)
        Me.lblCalculatedRMR.TabIndex = 36
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(38, 200)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(176, 37)
        Me.btnAddUser.TabIndex = 0
        Me.btnAddUser.Text = "Add User To List Below"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(773, 559)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.lblCalculatedRMR)
        Me.Controls.Add(Me.lblCalculatedFat)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblResultRMR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnListStats)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearRMR)
        Me.Controls.Add(Me.btnClearBodyFat)
        Me.Controls.Add(Me.btnCalcBodyFat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxStats)
        Me.Controls.Add(Me.btnCalcRMR)
        Me.Name = "Form1"
        Me.Text = "Fitness Calculator"
        Me.gbxStats.ResumeLayout(False)
        Me.gbxStats.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtWeightKg As TextBox
    Friend WithEvents txtHeightCm As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnCalcRMR As Button
    Friend WithEvents gbxStats As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHeightIn As TextBox
    Friend WithEvents txtWeightLb As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtForearm As TextBox
    Friend WithEvents txtHip As TextBox
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents txtWrist As TextBox
    Friend WithEvents txtBodyWeight As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcBodyFat As Button
    Friend WithEvents btnClearBodyFat As Button
    Friend WithEvents btnClearRMR As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lstUsers As ListBox
    Friend WithEvents btnListStats As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents lblResultRMR As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblCalculatedFat As Label
    Friend WithEvents lblCalculatedRMR As Label
    Friend WithEvents lblDisplayFat As Label
    Friend WithEvents lblDisplayRMR As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lblDisplayWtLb As Label
    Friend WithEvents lblDisplayWtKg As Label
    Friend WithEvents lblDisplayHeight As Label
    Friend WithEvents lblDisplayAge As Label
    Friend WithEvents lblDisplayGender As Label
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents btnAddUser As Button
End Class
