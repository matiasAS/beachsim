<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simulation
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chrt = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.popTxt = New System.Windows.Forms.NumericUpDown()
        Me.defaultBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AirTempLBL = New System.Windows.Forms.Label()
        Me.waterTempBox = New System.Windows.Forms.NumericUpDown()
        Me.airTempBox = New System.Windows.Forms.NumericUpDown()
        Me.weatherTxt = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mylocationRdbtn = New System.Windows.Forms.RadioButton()
        Me.DemographicsBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.elderlyTxt = New System.Windows.Forms.NumericUpDown()
        Me.adultTxt = New System.Windows.Forms.NumericUpDown()
        Me.youngTxt = New System.Windows.Forms.NumericUpDown()
        Me.teensTxt = New System.Windows.Forms.NumericUpDown()
        Me.childrenTxt = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.elderlyTbar = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adultTbar = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.youngTbar = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teensTbar = New System.Windows.Forms.TrackBar()
        Me.childrenTbar = New System.Windows.Forms.TrackBar()
        Me.genderBox = New System.Windows.Forms.GroupBox()
        Me.femalePerLbl = New System.Windows.Forms.Label()
        Me.malePerLbl = New System.Windows.Forms.Label()
        Me.femaleLbl = New System.Windows.Forms.Label()
        Me.maleLbl = New System.Windows.Forms.Label()
        Me.femaleTbar = New System.Windows.Forms.TrackBar()
        Me.maleTbar = New System.Windows.Forms.TrackBar()
        Me.locationLbl = New System.Windows.Forms.Label()
        Me.advoptLbl = New System.Windows.Forms.LinkLabel()
        Me.textRdbtn = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.populationLbl = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.zipTxt = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAQsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutBeachSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.chrt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.waterTempBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.airTempBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DemographicsBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.elderlyTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adultTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.youngTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teensTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childrenTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.elderlyTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adultTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.youngTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teensTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childrenTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.genderBox.SuspendLayout()
        CType(Me.femaleTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maleTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chrt
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrt.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrt.Legends.Add(Legend1)
        Me.chrt.Location = New System.Drawing.Point(331, 386)
        Me.chrt.Name = "chrt"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrt.Series.Add(Series1)
        Me.chrt.Size = New System.Drawing.Size(298, 312)
        Me.chrt.TabIndex = 40
        Me.chrt.Text = "Chart2"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(311, 348)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 39
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'popTxt
        '
        Me.popTxt.DecimalPlaces = 2
        Me.popTxt.Location = New System.Drawing.Point(11, 118)
        Me.popTxt.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.popTxt.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.popTxt.Name = "popTxt"
        Me.popTxt.Size = New System.Drawing.Size(120, 20)
        Me.popTxt.TabIndex = 38
        Me.popTxt.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'defaultBtn
        '
        Me.defaultBtn.Location = New System.Drawing.Point(392, 348)
        Me.defaultBtn.Name = "defaultBtn"
        Me.defaultBtn.Size = New System.Drawing.Size(75, 23)
        Me.defaultBtn.TabIndex = 37
        Me.defaultBtn.Text = "Default"
        Me.defaultBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AirTempLBL)
        Me.GroupBox1.Controls.Add(Me.waterTempBox)
        Me.GroupBox1.Controls.Add(Me.airTempBox)
        Me.GroupBox1.Controls.Add(Me.weatherTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 130)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weather"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Weather Condition"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Water Temp"
        '
        'AirTempLBL
        '
        Me.AirTempLBL.AutoSize = True
        Me.AirTempLBL.Location = New System.Drawing.Point(5, 26)
        Me.AirTempLBL.Name = "AirTempLBL"
        Me.AirTempLBL.Size = New System.Drawing.Size(82, 13)
        Me.AirTempLBL.TabIndex = 26
        Me.AirTempLBL.Text = "Air Temperature"
        '
        'waterTempBox
        '
        Me.waterTempBox.Location = New System.Drawing.Point(93, 55)
        Me.waterTempBox.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.waterTempBox.Name = "waterTempBox"
        Me.waterTempBox.Size = New System.Drawing.Size(37, 20)
        Me.waterTempBox.TabIndex = 25
        '
        'airTempBox
        '
        Me.airTempBox.Location = New System.Drawing.Point(93, 19)
        Me.airTempBox.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.airTempBox.Name = "airTempBox"
        Me.airTempBox.Size = New System.Drawing.Size(37, 20)
        Me.airTempBox.TabIndex = 24
        '
        'weatherTxt
        '
        Me.weatherTxt.FormattingEnabled = True
        Me.weatherTxt.Items.AddRange(New Object() {"Cloudy", "Mostly Cloudy", "Partly Cloudy", "Showers", "Sunny"})
        Me.weatherTxt.Location = New System.Drawing.Point(11, 103)
        Me.weatherTxt.Name = "weatherTxt"
        Me.weatherTxt.Size = New System.Drawing.Size(119, 21)
        Me.weatherTxt.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(554, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Export"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mylocationRdbtn
        '
        Me.mylocationRdbtn.AutoSize = True
        Me.mylocationRdbtn.Location = New System.Drawing.Point(11, 50)
        Me.mylocationRdbtn.Name = "mylocationRdbtn"
        Me.mylocationRdbtn.Size = New System.Drawing.Size(83, 17)
        Me.mylocationRdbtn.TabIndex = 27
        Me.mylocationRdbtn.TabStop = True
        Me.mylocationRdbtn.Text = "My Location"
        Me.mylocationRdbtn.UseVisualStyleBackColor = True
        '
        'DemographicsBox
        '
        Me.DemographicsBox.Controls.Add(Me.GroupBox2)
        Me.DemographicsBox.Controls.Add(Me.genderBox)
        Me.DemographicsBox.Location = New System.Drawing.Point(11, 386)
        Me.DemographicsBox.Name = "DemographicsBox"
        Me.DemographicsBox.Size = New System.Drawing.Size(314, 321)
        Me.DemographicsBox.TabIndex = 35
        Me.DemographicsBox.TabStop = False
        Me.DemographicsBox.Text = "Demographics"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.elderlyTxt)
        Me.GroupBox2.Controls.Add(Me.adultTxt)
        Me.GroupBox2.Controls.Add(Me.youngTxt)
        Me.GroupBox2.Controls.Add(Me.teensTxt)
        Me.GroupBox2.Controls.Add(Me.childrenTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.elderlyTbar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.adultTbar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.youngTbar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.teensTbar)
        Me.GroupBox2.Controls.Add(Me.childrenTbar)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Age Group"
        '
        'elderlyTxt
        '
        Me.elderlyTxt.DecimalPlaces = 2
        Me.elderlyTxt.Location = New System.Drawing.Point(238, 132)
        Me.elderlyTxt.Name = "elderlyTxt"
        Me.elderlyTxt.Size = New System.Drawing.Size(58, 20)
        Me.elderlyTxt.TabIndex = 24
        '
        'adultTxt
        '
        Me.adultTxt.DecimalPlaces = 2
        Me.adultTxt.Location = New System.Drawing.Point(238, 105)
        Me.adultTxt.Name = "adultTxt"
        Me.adultTxt.Size = New System.Drawing.Size(58, 20)
        Me.adultTxt.TabIndex = 28
        '
        'youngTxt
        '
        Me.youngTxt.DecimalPlaces = 2
        Me.youngTxt.Location = New System.Drawing.Point(238, 77)
        Me.youngTxt.Name = "youngTxt"
        Me.youngTxt.Size = New System.Drawing.Size(58, 20)
        Me.youngTxt.TabIndex = 24
        '
        'teensTxt
        '
        Me.teensTxt.DecimalPlaces = 2
        Me.teensTxt.Location = New System.Drawing.Point(238, 48)
        Me.teensTxt.Name = "teensTxt"
        Me.teensTxt.Size = New System.Drawing.Size(58, 20)
        Me.teensTxt.TabIndex = 23
        '
        'childrenTxt
        '
        Me.childrenTxt.DecimalPlaces = 2
        Me.childrenTxt.Location = New System.Drawing.Point(238, 18)
        Me.childrenTxt.Name = "childrenTxt"
        Me.childrenTxt.Size = New System.Drawing.Size(58, 20)
        Me.childrenTxt.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "60+"
        '
        'elderlyTbar
        '
        Me.elderlyTbar.Location = New System.Drawing.Point(53, 130)
        Me.elderlyTbar.Maximum = 100
        Me.elderlyTbar.Name = "elderlyTbar"
        Me.elderlyTbar.Size = New System.Drawing.Size(184, 45)
        Me.elderlyTbar.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "40-59"
        '
        'adultTbar
        '
        Me.adultTbar.Location = New System.Drawing.Point(53, 102)
        Me.adultTbar.Maximum = 100
        Me.adultTbar.Name = "adultTbar"
        Me.adultTbar.Size = New System.Drawing.Size(184, 45)
        Me.adultTbar.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "20-39"
        '
        'youngTbar
        '
        Me.youngTbar.Location = New System.Drawing.Point(53, 75)
        Me.youngTbar.Maximum = 100
        Me.youngTbar.Name = "youngTbar"
        Me.youngTbar.Size = New System.Drawing.Size(184, 45)
        Me.youngTbar.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "10-19"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0-9"
        '
        'teensTbar
        '
        Me.teensTbar.Location = New System.Drawing.Point(53, 47)
        Me.teensTbar.Maximum = 100
        Me.teensTbar.Name = "teensTbar"
        Me.teensTbar.Size = New System.Drawing.Size(184, 45)
        Me.teensTbar.TabIndex = 1
        '
        'childrenTbar
        '
        Me.childrenTbar.BackColor = System.Drawing.SystemColors.Control
        Me.childrenTbar.Location = New System.Drawing.Point(54, 18)
        Me.childrenTbar.Maximum = 100
        Me.childrenTbar.Name = "childrenTbar"
        Me.childrenTbar.Size = New System.Drawing.Size(184, 45)
        Me.childrenTbar.TabIndex = 0
        '
        'genderBox
        '
        Me.genderBox.Controls.Add(Me.femalePerLbl)
        Me.genderBox.Controls.Add(Me.malePerLbl)
        Me.genderBox.Controls.Add(Me.femaleLbl)
        Me.genderBox.Controls.Add(Me.maleLbl)
        Me.genderBox.Controls.Add(Me.femaleTbar)
        Me.genderBox.Controls.Add(Me.maleTbar)
        Me.genderBox.Location = New System.Drawing.Point(6, 32)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(274, 110)
        Me.genderBox.TabIndex = 0
        Me.genderBox.TabStop = False
        Me.genderBox.Text = "Gender"
        '
        'femalePerLbl
        '
        Me.femalePerLbl.AutoSize = True
        Me.femalePerLbl.Location = New System.Drawing.Point(235, 67)
        Me.femalePerLbl.Name = "femalePerLbl"
        Me.femalePerLbl.Size = New System.Drawing.Size(13, 13)
        Me.femalePerLbl.TabIndex = 5
        Me.femalePerLbl.Text = "0"
        '
        'malePerLbl
        '
        Me.malePerLbl.AutoSize = True
        Me.malePerLbl.Location = New System.Drawing.Point(235, 29)
        Me.malePerLbl.Name = "malePerLbl"
        Me.malePerLbl.Size = New System.Drawing.Size(13, 13)
        Me.malePerLbl.TabIndex = 4
        Me.malePerLbl.Text = "0"
        '
        'femaleLbl
        '
        Me.femaleLbl.AutoSize = True
        Me.femaleLbl.Location = New System.Drawing.Point(6, 65)
        Me.femaleLbl.Name = "femaleLbl"
        Me.femaleLbl.Size = New System.Drawing.Size(44, 13)
        Me.femaleLbl.TabIndex = 3
        Me.femaleLbl.Text = "Female:"
        '
        'maleLbl
        '
        Me.maleLbl.AutoSize = True
        Me.maleLbl.Location = New System.Drawing.Point(15, 29)
        Me.maleLbl.Name = "maleLbl"
        Me.maleLbl.Size = New System.Drawing.Size(33, 13)
        Me.maleLbl.TabIndex = 2
        Me.maleLbl.Text = "Male:"
        '
        'femaleTbar
        '
        Me.femaleTbar.Location = New System.Drawing.Point(54, 65)
        Me.femaleTbar.Name = "femaleTbar"
        Me.femaleTbar.Size = New System.Drawing.Size(184, 45)
        Me.femaleTbar.TabIndex = 1
        '
        'maleTbar
        '
        Me.maleTbar.BackColor = System.Drawing.SystemColors.Control
        Me.maleTbar.Location = New System.Drawing.Point(54, 19)
        Me.maleTbar.Name = "maleTbar"
        Me.maleTbar.Size = New System.Drawing.Size(184, 45)
        Me.maleTbar.TabIndex = 0
        '
        'locationLbl
        '
        Me.locationLbl.AutoSize = True
        Me.locationLbl.Location = New System.Drawing.Point(8, 34)
        Me.locationLbl.Name = "locationLbl"
        Me.locationLbl.Size = New System.Drawing.Size(48, 13)
        Me.locationLbl.TabIndex = 26
        Me.locationLbl.Text = "Location"
        '
        'advoptLbl
        '
        Me.advoptLbl.AutoSize = True
        Me.advoptLbl.Location = New System.Drawing.Point(23, 338)
        Me.advoptLbl.Name = "advoptLbl"
        Me.advoptLbl.Size = New System.Drawing.Size(95, 13)
        Me.advoptLbl.TabIndex = 34
        Me.advoptLbl.TabStop = True
        Me.advoptLbl.Text = "Advanced Options"
        '
        'textRdbtn
        '
        Me.textRdbtn.AutoSize = True
        Me.textRdbtn.Location = New System.Drawing.Point(11, 73)
        Me.textRdbtn.Name = "textRdbtn"
        Me.textRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.textRdbtn.TabIndex = 28
        Me.textRdbtn.TabStop = True
        Me.textRdbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Tag = ""
        Me.Button1.Text = "Simulate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'populationLbl
        '
        Me.populationLbl.AutoSize = True
        Me.populationLbl.Location = New System.Drawing.Point(8, 102)
        Me.populationLbl.Name = "populationLbl"
        Me.populationLbl.Size = New System.Drawing.Size(131, 13)
        Me.populationLbl.TabIndex = 29
        Me.populationLbl.Text = "Population (In Thousands)"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Location = New System.Drawing.Point(170, 27)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(459, 315)
        Me.Chart1.TabIndex = 30
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'zipTxt
        '
        Me.zipTxt.Location = New System.Drawing.Point(31, 70)
        Me.zipTxt.Mask = "00000-9999"
        Me.zipTxt.Name = "zipTxt"
        Me.zipTxt.Size = New System.Drawing.Size(100, 20)
        Me.zipTxt.TabIndex = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(648, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountSettingsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AccountSettingsToolStripMenuItem.Text = "Account Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSettingsToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.ToolStripSeparator3, Me.RunToolStripMenuItem, Me.ToolStripSeparator1, Me.ExportToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripMenuItem1.Text = "Run"
        '
        'ClearSettingsToolStripMenuItem
        '
        Me.ClearSettingsToolStripMenuItem.Name = "ClearSettingsToolStripMenuItem"
        Me.ClearSettingsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ClearSettingsToolStripMenuItem.Text = "Clear Settings"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FAQsToolStripMenuItem, Me.OnlineHelpToolStripMenuItem, Me.ContactUsToolStripMenuItem, Me.ToolStripSeparator4, Me.AboutBeachSimToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FAQsToolStripMenuItem
        '
        Me.FAQsToolStripMenuItem.Name = "FAQsToolStripMenuItem"
        Me.FAQsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.FAQsToolStripMenuItem.Text = "FAQs"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Online Help"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(159, 6)
        '
        'AboutBeachSimToolStripMenuItem
        '
        Me.AboutBeachSimToolStripMenuItem.Name = "AboutBeachSimToolStripMenuItem"
        Me.AboutBeachSimToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AboutBeachSimToolStripMenuItem.Text = "About BeachSim"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(230, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Load"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Simulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 727)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chrt)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.popTxt)
        Me.Controls.Add(Me.defaultBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.mylocationRdbtn)
        Me.Controls.Add(Me.DemographicsBox)
        Me.Controls.Add(Me.locationLbl)
        Me.Controls.Add(Me.advoptLbl)
        Me.Controls.Add(Me.textRdbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.populationLbl)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.zipTxt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Simulation"
        Me.Text = "Simulation"
        CType(Me.chrt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.waterTempBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.airTempBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DemographicsBox.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.elderlyTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adultTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.youngTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teensTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childrenTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.elderlyTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adultTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.youngTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teensTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childrenTbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.genderBox.ResumeLayout(False)
        Me.genderBox.PerformLayout()
        CType(Me.femaleTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maleTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chrt As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents popTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents defaultBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AirTempLBL As System.Windows.Forms.Label
    Friend WithEvents waterTempBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents airTempBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents weatherTxt As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents mylocationRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents DemographicsBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents elderlyTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents adultTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents youngTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents teensTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents childrenTxt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents elderlyTbar As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents adultTbar As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents youngTbar As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teensTbar As System.Windows.Forms.TrackBar
    Friend WithEvents childrenTbar As System.Windows.Forms.TrackBar
    Friend WithEvents genderBox As System.Windows.Forms.GroupBox
    Friend WithEvents femalePerLbl As System.Windows.Forms.Label
    Friend WithEvents malePerLbl As System.Windows.Forms.Label
    Friend WithEvents femaleLbl As System.Windows.Forms.Label
    Friend WithEvents maleLbl As System.Windows.Forms.Label
    Friend WithEvents femaleTbar As System.Windows.Forms.TrackBar
    Friend WithEvents maleTbar As System.Windows.Forms.TrackBar
    Friend WithEvents locationLbl As System.Windows.Forms.Label
    Friend WithEvents advoptLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents textRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents populationLbl As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents zipTxt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FAQsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutBeachSimToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
