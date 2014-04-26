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
        Me.locationLbl = New System.Windows.Forms.Label()
        Me.mylocationRdbtn = New System.Windows.Forms.RadioButton()
        Me.textRdbtn = New System.Windows.Forms.RadioButton()
        Me.locTxt = New System.Windows.Forms.TextBox()
        Me.popTxt = New System.Windows.Forms.TextBox()
        Me.popRdbtn = New System.Windows.Forms.RadioButton()
        Me.mypopRdbtn = New System.Windows.Forms.RadioButton()
        Me.populationLbl = New System.Windows.Forms.Label()
        Me.weatherTxt = New System.Windows.Forms.TextBox()
        Me.weatherRdbtn = New System.Windows.Forms.RadioButton()
        Me.myweatherRdbtn = New System.Windows.Forms.RadioButton()
        Me.weatherLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'locationLbl
        '
        Me.locationLbl.AutoSize = True
        Me.locationLbl.Location = New System.Drawing.Point(12, 9)
        Me.locationLbl.Name = "locationLbl"
        Me.locationLbl.Size = New System.Drawing.Size(48, 13)
        Me.locationLbl.TabIndex = 0
        Me.locationLbl.Text = "Location"
        '
        'mylocationRdbtn
        '
        Me.mylocationRdbtn.AutoSize = True
        Me.mylocationRdbtn.Location = New System.Drawing.Point(15, 25)
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
        Me.textRdbtn.Location = New System.Drawing.Point(15, 48)
        Me.textRdbtn.Name = "textRdbtn"
        Me.textRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.textRdbtn.TabIndex = 2
        Me.textRdbtn.TabStop = True
        Me.textRdbtn.UseVisualStyleBackColor = True
        '
        'locTxt
        '
        Me.locTxt.Location = New System.Drawing.Point(35, 45)
        Me.locTxt.Name = "locTxt"
        Me.locTxt.Size = New System.Drawing.Size(100, 20)
        Me.locTxt.TabIndex = 3
        '
        'popTxt
        '
        Me.popTxt.Location = New System.Drawing.Point(35, 104)
        Me.popTxt.Name = "popTxt"
        Me.popTxt.Size = New System.Drawing.Size(100, 20)
        Me.popTxt.TabIndex = 7
        '
        'popRdbtn
        '
        Me.popRdbtn.AutoSize = True
        Me.popRdbtn.Location = New System.Drawing.Point(15, 107)
        Me.popRdbtn.Name = "popRdbtn"
        Me.popRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.popRdbtn.TabIndex = 6
        Me.popRdbtn.TabStop = True
        Me.popRdbtn.UseVisualStyleBackColor = True
        '
        'mypopRdbtn
        '
        Me.mypopRdbtn.AutoSize = True
        Me.mypopRdbtn.Location = New System.Drawing.Point(15, 84)
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
        Me.populationLbl.Location = New System.Drawing.Point(12, 68)
        Me.populationLbl.Name = "populationLbl"
        Me.populationLbl.Size = New System.Drawing.Size(57, 13)
        Me.populationLbl.TabIndex = 4
        Me.populationLbl.Text = "Population"
        '
        'weatherTxt
        '
        Me.weatherTxt.Location = New System.Drawing.Point(35, 163)
        Me.weatherTxt.Name = "weatherTxt"
        Me.weatherTxt.Size = New System.Drawing.Size(100, 20)
        Me.weatherTxt.TabIndex = 11
        '
        'weatherRdbtn
        '
        Me.weatherRdbtn.AutoSize = True
        Me.weatherRdbtn.Location = New System.Drawing.Point(15, 166)
        Me.weatherRdbtn.Name = "weatherRdbtn"
        Me.weatherRdbtn.Size = New System.Drawing.Size(14, 13)
        Me.weatherRdbtn.TabIndex = 10
        Me.weatherRdbtn.TabStop = True
        Me.weatherRdbtn.UseVisualStyleBackColor = True
        '
        'myweatherRdbtn
        '
        Me.myweatherRdbtn.AutoSize = True
        Me.myweatherRdbtn.Location = New System.Drawing.Point(15, 143)
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
        Me.weatherLbl.Location = New System.Drawing.Point(12, 127)
        Me.weatherLbl.Name = "weatherLbl"
        Me.weatherLbl.Size = New System.Drawing.Size(48, 13)
        Me.weatherLbl.TabIndex = 8
        Me.weatherLbl.Text = "Weather"
        '
        'Simulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 492)
        Me.Controls.Add(Me.weatherTxt)
        Me.Controls.Add(Me.weatherRdbtn)
        Me.Controls.Add(Me.myweatherRdbtn)
        Me.Controls.Add(Me.weatherLbl)
        Me.Controls.Add(Me.popTxt)
        Me.Controls.Add(Me.popRdbtn)
        Me.Controls.Add(Me.mypopRdbtn)
        Me.Controls.Add(Me.populationLbl)
        Me.Controls.Add(Me.locTxt)
        Me.Controls.Add(Me.textRdbtn)
        Me.Controls.Add(Me.mylocationRdbtn)
        Me.Controls.Add(Me.locationLbl)
        Me.Name = "Simulation"
        Me.Text = "Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents locationLbl As System.Windows.Forms.Label
    Friend WithEvents mylocationRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents textRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents locTxt As System.Windows.Forms.TextBox
    Friend WithEvents popTxt As System.Windows.Forms.TextBox
    Friend WithEvents popRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents mypopRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents populationLbl As System.Windows.Forms.Label
    Friend WithEvents weatherTxt As System.Windows.Forms.TextBox
    Friend WithEvents weatherRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents myweatherRdbtn As System.Windows.Forms.RadioButton
    Friend WithEvents weatherLbl As System.Windows.Forms.Label

End Class
