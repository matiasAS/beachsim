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
        Me.weatherTxt = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.populationLbl.Size = New System.Drawing.Size(57, 13)
        Me.populationLbl.TabIndex = 4
        Me.populationLbl.Text = "Population"
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
        Me.zipTxt.Name = "zipTxt"
        Me.zipTxt.Size = New System.Drawing.Size(100, 20)
        Me.zipTxt.TabIndex = 14
        '
        'popTxt
        '
        Me.popTxt.Location = New System.Drawing.Point(34, 97)
        Me.popTxt.Name = "popTxt"
        Me.popTxt.Size = New System.Drawing.Size(100, 20)
        Me.popTxt.TabIndex = 15
        '
        'weatherTxt
        '
        Me.weatherTxt.Location = New System.Drawing.Point(34, 156)
        Me.weatherTxt.Name = "weatherTxt"
        Me.weatherTxt.Size = New System.Drawing.Size(100, 20)
        Me.weatherTxt.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.mypopRdbtn)
        Me.Panel1.Controls.Add(Me.mylocationRdbtn)
        Me.Panel1.Controls.Add(Me.locationLbl)
        Me.Panel1.Controls.Add(Me.weatherTxt)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'Simulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 606)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Simulation"
        Me.Text = "Simulation"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents weatherTxt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
