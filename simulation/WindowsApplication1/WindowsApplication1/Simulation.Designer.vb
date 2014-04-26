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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.locationLbl = New System.Windows.Forms.Label()
        Me.mylocationRdbtn = New System.Windows.Forms.RadioButton()
        Me.textRdbtn = New System.Windows.Forms.RadioButton()
        Me.popRdbtn = New System.Windows.Forms.RadioButton()
        Me.mypopRdbtn = New System.Windows.Forms.RadioButton()
        Me.populationLbl = New System.Windows.Forms.Label()
        Me.weatherRdbtn = New System.Windows.Forms.RadioButton()
        Me.myweatherRdbtn = New System.Windows.Forms.RadioButton()
        Me.weatherLbl = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.DemographicsBox.SuspendLayout()
        Me.genderBox.SuspendLayout()
        CType(Me.maleTbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.femaleTbar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.popRdbtn.Location = New System.Drawing.Point(14, 100)
        Me.popRdbtn.Name = "popRdbtn"
        Me.popRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.popRdbtn.TabIndex = 6
        Me.popRdbtn.TabStop = True
        Me.popRdbtn.UseVisualStyleBackColor = True
        '
        'mypopRdbtn
        '
        Me.mypopRdbtn.AutoSize = True
        Me.mypopRdbtn.Location = New System.Drawing.Point(14, 74)
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
        Me.populationLbl.Location = New System.Drawing.Point(11, 61)
        Me.populationLbl.Name = "populationLbl"
        Me.populationLbl.Size = New System.Drawing.Size(131, 13)
        Me.populationLbl.TabIndex = 4
        Me.populationLbl.Text = "Population (In Thousands)"
        '
        'weatherRdbtn
        '
        Me.weatherRdbtn.AutoSize = True
        Me.weatherRdbtn.Location = New System.Drawing.Point(14, 159)
        Me.weatherRdbtn.Name = "weatherRdbtn"
        Me.weatherRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.weatherRdbtn.TabIndex = 10
        Me.weatherRdbtn.TabStop = True
        Me.weatherRdbtn.UseVisualStyleBackColor = True
        '
        'myweatherRdbtn
        '
        Me.myweatherRdbtn.AutoSize = True
        Me.myweatherRdbtn.Location = New System.Drawing.Point(14, 136)
        Me.myweatherRdbtn.Name = "myweatherRdbtn"
        Me.myweatherRdbtn.Size = New System.Drawing.Size(83, 17)
        Me.myweatherRdbtn.TabIndex = 9
        Me.myweatherRdbtn.TabStop = True
        Me.myweatherRdbtn.Text = "My Weather"
        Me.myweatherRdbtn.UseVisualStyleBackColor = True
        '
        'weatherLbl
        '
        Me.weatherLbl.AutoSize = True
        Me.weatherLbl.Location = New System.Drawing.Point(11, 120)
        Me.weatherLbl.Name = "weatherLbl"
        Me.weatherLbl.Size = New System.Drawing.Size(48, 13)
        Me.weatherLbl.TabIndex = 8
        Me.weatherLbl.Text = "Weather"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(224, 12)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
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
        Me.popTxt.Location = New System.Drawing.Point(34, 97)
        Me.popTxt.Mask = "00000"
        Me.popTxt.Name = "popTxt"
        Me.popTxt.Size = New System.Drawing.Size(100, 20)
        Me.popTxt.TabIndex = 15
        Me.popTxt.ValidatingType = GetType(Integer)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckedListBox1)
        Me.Panel1.Controls.Add(Me.mypopRdbtn)
        Me.Panel1.Controls.Add(Me.mylocationRdbtn)
        Me.Panel1.Controls.Add(Me.locationLbl)
        Me.Panel1.Controls.Add(Me.textRdbtn)
        Me.Panel1.Controls.Add(Me.popTxt)
        Me.Panel1.Controls.Add(Me.populationLbl)
        Me.Panel1.Controls.Add(Me.zipTxt)
        Me.Panel1.Controls.Add(Me.popRdbtn)
        Me.Panel1.Controls.Add(Me.weatherLbl)
        Me.Panel1.Controls.Add(Me.myweatherRdbtn)
        Me.Panel1.Controls.Add(Me.weatherRdbtn)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 184)
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
        Me.DemographicsBox.Controls.Add(Me.genderBox)
        Me.DemographicsBox.Location = New System.Drawing.Point(12, 383)
        Me.DemographicsBox.Name = "DemographicsBox"
        Me.DemographicsBox.Size = New System.Drawing.Size(263, 261)
        Me.DemographicsBox.TabIndex = 20
        Me.DemographicsBox.TabStop = False
        Me.DemographicsBox.Text = "Demographics"
        '
        'genderBox
        '
        Me.genderBox.Controls.Add(Me.Label1)
        Me.genderBox.Controls.Add(Me.maleLbl)
        Me.genderBox.Controls.Add(Me.femaleTbar)
        Me.genderBox.Controls.Add(Me.maleTbar)
        Me.genderBox.Location = New System.Drawing.Point(6, 32)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(251, 110)
        Me.genderBox.TabIndex = 0
        Me.genderBox.TabStop = False
        Me.genderBox.Text = "Gender"
        '
        'maleTbar
        '
        Me.maleTbar.Location = New System.Drawing.Point(61, 19)
        Me.maleTbar.Name = "maleTbar"
        Me.maleTbar.Size = New System.Drawing.Size(184, 45)
        Me.maleTbar.TabIndex = 0
        '
        'femaleTbar
        '
        Me.femaleTbar.Location = New System.Drawing.Point(61, 65)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(34, 159)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 16
        '
        'Simulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 684)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents locationLbl As System.Windows.Forms.Label
    Friend WithEvents mylocationRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents textRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents popRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents mypopRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents populationLbl As System.Windows.Forms.Label
    Friend WithEvents weatherRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents myweatherRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents weatherLbl As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox

End Class
