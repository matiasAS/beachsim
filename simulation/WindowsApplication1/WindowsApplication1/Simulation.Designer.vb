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
        Me.locationLbl = New System.Windows.Forms.Label()
        Me.mylocationRdbtn = New System.Windows.Forms.RadioButton()
        Me.textRdbtn = New System.Windows.Forms.RadioButton()
        Me.popRdbtn = New System.Windows.Forms.RadioButton()
        Me.mypopRdbtn = New System.Windows.Forms.RadioButton()
        Me.populationLbl = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.zipTxt = New System.Windows.Forms.MaskedTextBox()
        Me.popTxt = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.advoptLbl = New System.Windows.Forms.LinkLabel()
        Me.DemographicsBox = New System.Windows.Forms.GroupBox()
        Me.genderBox = New System.Windows.Forms.GroupBox()
        Me.maleTbar = New System.Windows.Forms.TrackBar()
        Me.femaleTbar = New System.Windows.Forms.TrackBar()
        Me.maleLbl = New System.Windows.Forms.Label()
        Me.femaleLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.malePerLbl = New System.Windows.Forms.Label()
        Me.femalePerLbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teensTbar = New System.Windows.Forms.TrackBar()
        Me.childrenTbar = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.youngTbar = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adultTbar = New System.Windows.Forms.TrackBar()
        Me.elderlyTbar = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.childrenTxt = New System.Windows.Forms.TextBox()
        Me.teensTxt = New System.Windows.Forms.TextBox()
        Me.youngTxt = New System.Windows.Forms.TextBox()
        Me.adultTxt = New System.Windows.Forms.TextBox()
        Me.elderTxt = New System.Windows.Forms.TextBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.DemographicsBox.SuspendLayout()
        Me.genderBox.SuspendLayout()
        CType(Me.maleTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.femaleTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.teensTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childrenTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.youngTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adultTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.elderlyTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'locationLbl
        '
        Me.locationLbl.AutoSize = True
        Me.locationLbl.Location = New System.Drawing.Point(11, 2)
        Me.locationLbl.Name = "locationLbl"
        Me.locationLbl.Size = New System.Drawing.Size(48, 13)
        Me.locationLbl.TabIndex = 0
        Me.locationLbl.Text = "Location"
        '
        'mylocationRdbtn
        '
        Me.mylocationRdbtn.AutoSize = True
        Me.mylocationRdbtn.Location = New System.Drawing.Point(14, 18)
        Me.mylocationRdbtn.Name = "mylocationRdbtn"
        Me.mylocationRdbtn.Size = New System.Drawing.Size(83, 17)
        Me.mylocationRdbtn.TabIndex = 1
        Me.mylocationRdbtn.TabStop = True
        Me.mylocationRdbtn.Text = "My Location"
        Me.mylocationRdbtn.UseVisualStyleBackColor = True
        '
        'textRdbtn
        '
        Me.textRdbtn.AutoSize = True
        Me.textRdbtn.Location = New System.Drawing.Point(14, 41)
        Me.textRdbtn.Name = "textRdbtn"
        Me.textRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.textRdbtn.TabIndex = 2
        Me.textRdbtn.TabStop = True
        Me.textRdbtn.UseVisualStyleBackColor = True
        '
        'popRdbtn
        '
        Me.popRdbtn.AutoSize = True
        Me.popRdbtn.Location = New System.Drawing.Point(14, 112)
        Me.popRdbtn.Name = "popRdbtn"
        Me.popRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.popRdbtn.TabIndex = 6
        Me.popRdbtn.TabStop = True
        Me.popRdbtn.UseVisualStyleBackColor = True
        '
        'mypopRdbtn
        '
        Me.mypopRdbtn.AutoSize = True
        Me.mypopRdbtn.Location = New System.Drawing.Point(14, 86)
        Me.mypopRdbtn.Name = "mypopRdbtn"
        Me.mypopRdbtn.Size = New System.Drawing.Size(112, 17)
        Me.mypopRdbtn.TabIndex = 5
        Me.mypopRdbtn.TabStop = True
        Me.mypopRdbtn.Text = "Default Population"
        Me.mypopRdbtn.UseVisualStyleBackColor = True
        '
        'populationLbl
        '
        Me.populationLbl.AutoSize = True
        Me.populationLbl.Location = New System.Drawing.Point(11, 70)
        Me.populationLbl.Name = "populationLbl"
        Me.populationLbl.Size = New System.Drawing.Size(131, 13)
        Me.populationLbl.TabIndex = 4
        Me.populationLbl.Text = "Population (In Thousands)"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(224, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(449, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'zipTxt
        '
        Me.zipTxt.Location = New System.Drawing.Point(34, 38)
        Me.zipTxt.Mask = "00000-9999"
        Me.zipTxt.Name = "zipTxt"
        Me.zipTxt.Size = New System.Drawing.Size(100, 20)
        Me.zipTxt.TabIndex = 14
        '
        'popTxt
        '
        Me.popTxt.Location = New System.Drawing.Point(34, 109)
        Me.popTxt.Mask = "00000"
        Me.popTxt.Name = "popTxt"
        Me.popTxt.Size = New System.Drawing.Size(100, 20)
        Me.popTxt.TabIndex = 15
        Me.popTxt.ValidatingType = GetType(Integer)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.mypopRdbtn)
        Me.Panel1.Controls.Add(Me.mylocationRdbtn)
        Me.Panel1.Controls.Add(Me.locationLbl)
        Me.Panel1.Controls.Add(Me.textRdbtn)
        Me.Panel1.Controls.Add(Me.popTxt)
        Me.Panel1.Controls.Add(Me.populationLbl)
        Me.Panel1.Controls.Add(Me.zipTxt)
        Me.Panel1.Controls.Add(Me.popRdbtn)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 263)
        Me.Panel1.TabIndex = 17
        '
        'advoptLbl
        '
        Me.advoptLbl.AutoSize = True
        Me.advoptLbl.Location = New System.Drawing.Point(24, 335)
        Me.advoptLbl.Name = "advoptLbl"
        Me.advoptLbl.Size = New System.Drawing.Size(95, 13)
        Me.advoptLbl.TabIndex = 19
        Me.advoptLbl.TabStop = True
        Me.advoptLbl.Text = "Advanced Options"
        '
        'DemographicsBox
        '
        Me.DemographicsBox.Controls.Add(Me.GroupBox2)
        Me.DemographicsBox.Controls.Add(Me.genderBox)
        Me.DemographicsBox.Location = New System.Drawing.Point(12, 383)
        Me.DemographicsBox.Name = "DemographicsBox"
        Me.DemographicsBox.Size = New System.Drawing.Size(280, 321)
        Me.DemographicsBox.TabIndex = 20
        Me.DemographicsBox.TabStop = False
        Me.DemographicsBox.Text = "Demographics"
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
        Me.genderBox.Size = New System.Drawing.Size(268, 110)
        Me.genderBox.TabIndex = 0
        Me.genderBox.TabStop = False
        Me.genderBox.Text = "Gender"
        '
        'maleTbar
        '
        Me.maleTbar.BackColor = System.Drawing.SystemColors.Control
        Me.maleTbar.Location = New System.Drawing.Point(54, 19)
        Me.maleTbar.Name = "maleTbar"
        Me.maleTbar.Size = New System.Drawing.Size(184, 45)
        Me.maleTbar.TabIndex = 0
        '
        'femaleTbar
        '
        Me.femaleTbar.Location = New System.Drawing.Point(54, 65)
        Me.femaleTbar.Name = "femaleTbar"
        Me.femaleTbar.Size = New System.Drawing.Size(184, 45)
        Me.femaleTbar.TabIndex = 1
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
        'femaleLbl
        '
        Me.femaleLbl.AutoSize = True
        Me.femaleLbl.Location = New System.Drawing.Point(6, 65)
        Me.femaleLbl.Name = "femaleLbl"
        Me.femaleLbl.Size = New System.Drawing.Size(44, 13)
        Me.femaleLbl.TabIndex = 3
        Me.femaleLbl.Text = "Female:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 113)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weather"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Air Temperature"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "Water Temperature"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'malePerLbl
        '
        Me.malePerLbl.AutoSize = True
        Me.malePerLbl.Location = New System.Drawing.Point(235, 29)
        Me.malePerLbl.Name = "malePerLbl"
        Me.malePerLbl.Size = New System.Drawing.Size(21, 13)
        Me.malePerLbl.TabIndex = 4
        Me.malePerLbl.Text = "0%"
        '
        'femalePerLbl
        '
        Me.femalePerLbl.AutoSize = True
        Me.femalePerLbl.Location = New System.Drawing.Point(235, 67)
        Me.femalePerLbl.Name = "femalePerLbl"
        Me.femalePerLbl.Size = New System.Drawing.Size(21, 13)
        Me.femalePerLbl.TabIndex = 5
        Me.femalePerLbl.Text = "0%"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.elderTxt)
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
        Me.GroupBox2.Size = New System.Drawing.Size(268, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Age Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "13-18"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0-12"
        '
        'teensTbar
        '
        Me.teensTbar.Location = New System.Drawing.Point(53, 47)
        Me.teensTbar.Name = "teensTbar"
        Me.teensTbar.Size = New System.Drawing.Size(184, 45)
        Me.teensTbar.TabIndex = 1
        '
        'childrenTbar
        '
        Me.childrenTbar.BackColor = System.Drawing.SystemColors.Control
        Me.childrenTbar.Location = New System.Drawing.Point(54, 19)
        Me.childrenTbar.Name = "childrenTbar"
        Me.childrenTbar.Size = New System.Drawing.Size(184, 45)
        Me.childrenTbar.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "19-29"
        '
        'youngTbar
        '
        Me.youngTbar.Location = New System.Drawing.Point(53, 75)
        Me.youngTbar.Name = "youngTbar"
        Me.youngTbar.Size = New System.Drawing.Size(184, 45)
        Me.youngTbar.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "30-49"
        '
        'adultTbar
        '
        Me.adultTbar.Location = New System.Drawing.Point(53, 102)
        Me.adultTbar.Name = "adultTbar"
        Me.adultTbar.Size = New System.Drawing.Size(184, 45)
        Me.adultTbar.TabIndex = 8
        '
        'elderlyTbar
        '
        Me.elderlyTbar.Location = New System.Drawing.Point(53, 130)
        Me.elderlyTbar.Name = "elderlyTbar"
        Me.elderlyTbar.Size = New System.Drawing.Size(184, 45)
        Me.elderlyTbar.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "50+"
        '
        'childrenTxt
        '
        Me.childrenTxt.Location = New System.Drawing.Point(238, 19)
        Me.childrenTxt.Name = "childrenTxt"
        Me.childrenTxt.Size = New System.Drawing.Size(26, 20)
        Me.childrenTxt.TabIndex = 12
        Me.childrenTxt.Text = "0%"
        '
        'teensTxt
        '
        Me.teensTxt.Location = New System.Drawing.Point(238, 47)
        Me.teensTxt.Name = "teensTxt"
        Me.teensTxt.Size = New System.Drawing.Size(26, 20)
        Me.teensTxt.TabIndex = 13
        Me.teensTxt.Text = "0%"
        '
        'youngTxt
        '
        Me.youngTxt.Location = New System.Drawing.Point(238, 75)
        Me.youngTxt.Name = "youngTxt"
        Me.youngTxt.Size = New System.Drawing.Size(26, 20)
        Me.youngTxt.TabIndex = 14
        Me.youngTxt.Text = "0%"
        '
        'adultTxt
        '
        Me.adultTxt.Location = New System.Drawing.Point(238, 102)
        Me.adultTxt.Name = "adultTxt"
        Me.adultTxt.Size = New System.Drawing.Size(26, 20)
        Me.adultTxt.TabIndex = 15
        Me.adultTxt.Text = "0%"
        '
        'elderTxt
        '
        Me.elderTxt.Location = New System.Drawing.Point(238, 131)
        Me.elderTxt.Name = "elderTxt"
        Me.elderTxt.Size = New System.Drawing.Size(26, 20)
        Me.elderTxt.TabIndex = 16
        Me.elderTxt.Text = "0%"
        '
        'Simulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 712)
        Me.Controls.Add(Me.DemographicsBox)
        Me.Controls.Add(Me.advoptLbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Simulation"
        Me.Text = "Simulation"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DemographicsBox.ResumeLayout(False)
        Me.genderBox.ResumeLayout(False)
        Me.genderBox.PerformLayout()
        CType(Me.maleTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.femaleTbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.teensTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childrenTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.youngTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adultTbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.elderlyTbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents locationLbl As System.Windows.Forms.Label
    Friend WithEvents mylocationRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents textRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents popRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents mypopRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents populationLbl As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents zipTxt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents popTxt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents advoptLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents DemographicsBox As System.Windows.Forms.GroupBox
    Friend WithEvents genderBox As System.Windows.Forms.GroupBox
    Friend WithEvents maleTbar As System.Windows.Forms.TrackBar
    Friend WithEvents femaleTbar As System.Windows.Forms.TrackBar
    Friend WithEvents maleLbl As System.Windows.Forms.Label
    Friend WithEvents femaleLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teensTbar As System.Windows.Forms.TrackBar
    Friend WithEvents childrenTbar As System.Windows.Forms.TrackBar
    Friend WithEvents femalePerLbl As System.Windows.Forms.Label
    Friend WithEvents malePerLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents youngTbar As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents adultTbar As System.Windows.Forms.TrackBar
    Friend WithEvents elderlyTbar As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents childrenTxt As System.Windows.Forms.TextBox
    Friend WithEvents elderTxt As System.Windows.Forms.TextBox
    Friend WithEvents adultTxt As System.Windows.Forms.TextBox
    Friend WithEvents youngTxt As System.Windows.Forms.TextBox
    Friend WithEvents teensTxt As System.Windows.Forms.TextBox

End Class
