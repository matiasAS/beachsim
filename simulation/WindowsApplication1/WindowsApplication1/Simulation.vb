Imports System.Windows.Forms.DataVisualization.Charting


Public Class Simulation

    Private Sub Simulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles locationLbl.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textRdbtn.CheckedChanged

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles populationLbl.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mypopRdbtn.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weatherTxt.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myweatherRdbtn.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weatherRdbtn.CheckedChanged

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weatherLbl.Click

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Chart1.Series.Clear()
        Chart1.Titles.Add("demo")
        Dim s As New Series
        s.chartType = SeriesChartType.Line
        s.Points.AddXY("1990", 27)
        s.Points.AddXY("1991", 15)
        s.Points.AddXY("1992", 17)
        Chart1.Series.Add(s)
        Chart1.Visible = True
    End Sub
End Class
