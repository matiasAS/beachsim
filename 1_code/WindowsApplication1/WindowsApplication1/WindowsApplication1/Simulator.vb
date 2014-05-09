Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Simulation

    Public Function updatePieChart()
        Dim yValues As Double() = {childrenTxt.Value, teensTxt.Value, youngTxt.Value, adultTxt.Value, elderlyTxt.Value} ' Getting values from Textboxes 
        Dim xValues As String() = {"child", "teen", "young adult", "adult", "elderly"} ' Headings
        Dim seriesName As String = Nothing


        chrt.Series.Clear()
        chrt.Titles.Clear()
        ' Give unique Series Name
        seriesName = "ChartInv"
        chrt.Series.Add(seriesName)

        ' Bind X and Y values
        chrt.Series(seriesName).Points.DataBindXY(xValues, yValues)

        ' Chart Area Modification (Optional)
        Dim CArea As ChartArea = chrt.ChartAreas(0)
        CArea.BackColor = Color.Azure
        CArea.ShadowColor = Color.Red
        CArea.Area3DStyle.Enable3D = True

        ' Define Custom Chart Colors
        chrt.Series(seriesName).Points(0).Color = Color.MediumSeaGreen
        chrt.Series(seriesName).Points(1).Color = Color.PaleGreen
        chrt.Series(seriesName).Points(2).Color = Color.LawnGreen

        ' Define Chart Type
        chrt.Series(seriesName).ChartType = SeriesChartType.Pie

        chrt.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True

        ' Formatting the Chart Title
        Dim T As Title = chrt.Titles.Add("Amount Distribution")
        With T
            .ForeColor = Color.Black
            .BackColor = Color.LightBlue
            .Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold)
            .BorderColor = Color.Black
        End With

        ' If you want to show Chart Legends
        chrt.Legends(0).Enabled = True

        ' If you don't want to show data values and headings as label inside each Pie in chart
        chrt.Series(seriesName)("PieLabelStyle") = "Disabled"
        chrt.Series("ChartInv").IsValueShownAsLabel = False

        ' If you want to show datavalues as label inside each Pie in chart
        chrt.Series("ChartInv").IsValueShownAsLabel = True

    End Function


    Private Sub Simulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(660, 420)
        Me.MaximumSize = New Size(660, 420)
        Me.MinimumSize = New Size(660, 420)
        Chart1.Series.Clear()
        Chart1.Titles.Add("Simulation")
        Dim s As New Series
        s.ChartType = SeriesChartType.Line
        With Chart1.ChartAreas(0)
            .AxisX.Minimum = 0
            .AxisX.Maximum = 100
            .AxisY.Minimum = 0
            .AxisY.Maximum = 100
            .AxisY.Interval = 10
            .AxisX.Interval = 10
            .AxisX.Title = "Simulation #"
            .AxisY.Title = "Expected Visitors (%)"
        End With
        s.Points.AddXY(0, 0)
        s.Points.AddXY(1, 0)
        Chart1.Series.Add(s)
        Chart1.Visible = True
        femaleTbar.Minimum = ("0")
        femaleTbar.Maximum = ("100")
        femaleTbar.TickFrequency = ("10")
        maleTbar.Minimum = ("0")
        maleTbar.Maximum = ("100")
        maleTbar.TickFrequency = ("10")
        maleTbar.Value = ("50")
        femaleTbar.Value = ("50")
        airTempBox.Value = 85
        waterTempBox.Value = 75
        popTxt.Value = 100
        weatherTxt.Text = "Sunny"
        childrenTxt.Value = 20
        youngTxt.Value = 20
        adultTxt.Value = 20
        teensTxt.Value = 20
        elderlyTxt.Value = 20

        updatePieChart()
    End Sub

    Public simResult(100, 1) As Double
    Public total As Double

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles locationLbl.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textRdbtn.CheckedChanged

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles populationLbl.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Chart1.Series.Clear()
        'Dim s As New Series
        's.chartType = SeriesChartType.Line
        's.Points.AddXY(10, 27)
        's.Points.AddXY(20, 15)
        's.Points.AddXY(30, 17)
        'Chart1.Series.Add(s)
        Chart1.Visible = True
        Dim totalpop As Decimal
        totalpop = childrenTxt.Value + teensTxt.Value + youngTxt.Value + adultTxt.Value + elderlyTxt.Value
        total = 0
        Dim foo2 As Double
        foo2 = totalpop
        Dim bar As Double
        bar = popTxt.Value
        Dim multiplier As Double
        multiplier = bar / foo2
        'Math.Round(multiplier, 2)
        'multiplier = popTxt.Value \ totalpop
        Debug.Write("multiplier" + multiplier.ToString + vbCrLf)
        Dim normalchildpop As Integer
        normalchildpop = childrenTxt.Value * multiplier
        Dim malechildpop As Integer
        malechildpop = normalchildpop * maleTbar.Value \ 100
        Dim femalechildpop As Integer
        femalechildpop = normalchildpop - malechildpop
        Dim normalteenspop As Integer
        normalteenspop = multiplier * teensTxt.Value
        Dim maleteenspop As Integer
        maleteenspop = normalteenspop * maleTbar.Value \ 100
        Dim femaleteenspop As Integer
        femaleteenspop = normalteenspop - maleteenspop
        Dim normalyoungpop As Integer
        normalyoungpop = multiplier * youngTxt.Value
        Dim maleyoungpop As Integer
        maleyoungpop = normalyoungpop * maleTbar.Value \ 100
        Dim femaleyoungpop As Integer
        femaleyoungpop = normalyoungpop - maleyoungpop
        Dim normaladultpop As Integer
        normaladultpop = multiplier * adultTxt.Value
        Dim maleadultpop As Integer
        maleadultpop = normaladultpop * maleTbar.Value \ 100
        Dim femaleadultpop As Integer
        femaleadultpop = normaladultpop - maleadultpop
        Dim normalelderlypop As Integer
        normalelderlypop = multiplier * elderlyTxt.Value
        Dim maleelderlypop As Integer
        maleelderlypop = normalelderlypop * maleTbar.Value \ 100
        Dim femaleelderlypop As Integer
        femaleelderlypop = normalelderlypop - maleelderlypop
        Dim normaltotalpop As Integer
        normaltotalpop = normalchildpop + normalteenspop + normalyoungpop + normaladultpop + normalelderlypop
        Debug.Write("Normalchildpop: " & normalchildpop.ToString & vbCrLf)
        Debug.Write("Malechildpop: " & malechildpop.ToString & vbCrLf)
        Debug.Write("Femalechildpop: " & femalechildpop.ToString & vbCrLf)
        Debug.Write("Normalteenspop: " & normalteenspop.ToString & vbCrLf)
        Debug.Write("Maleteenspop: " & maleteenspop.ToString & vbCrLf)
        Debug.Write("Femaleteenspop: " & femaleteenspop.ToString & vbCrLf)
        Debug.Write("Normalyoungpop: " & normalyoungpop.ToString & vbCrLf)
        Debug.Write("Maleyoungpop: " & maleyoungpop.ToString & vbCrLf)
        Debug.Write("Femaleyoungpop: " & femaleyoungpop.ToString & vbCrLf)
        Debug.Write("Normaladultpop: " & normaladultpop.ToString & vbCrLf)
        Debug.Write("Maleadultpop: " & maleadultpop.ToString & vbCrLf)
        Debug.Write("Femaleadultpop: " & femaleadultpop.ToString & vbCrLf)
        Debug.Write("Normalelderlypop: " & normalelderlypop.ToString & vbCrLf)
        Debug.Write("Maleelderlypop: " & maleelderlypop.ToString & vbCrLf)
        Debug.Write("Femaleelderlypop: " & femaleelderlypop.ToString & vbCrLf)
        Debug.Write("Normaltotalpop: " & normaltotalpop.ToString & vbCrLf)

        Dim agents(normaltotalpop, 8) As Integer
        Dim agentindex As Integer = 0
        For i As Integer = 1 To femalechildpop
            agents(agentindex, 0) = 1
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To malechildpop
            agents(agentindex, 0) = 2
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To femaleteenspop
            agents(agentindex, 0) = 3
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To maleteenspop
            agents(agentindex, 0) = 4
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To femaleyoungpop
            agents(agentindex, 0) = 5
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To maleyoungpop
            agents(agentindex, 0) = 6
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To femaleadultpop
            agents(agentindex, 0) = 7
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To maleadultpop
            agents(agentindex, 0) = 8
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To femaleelderlypop
            agents(agentindex, 0) = 9
            agentindex = agentindex + 1
        Next
        For i As Integer = 1 To maleelderlypop
            agents(agentindex, 0) = 10
            agentindex = agentindex + 1
        Next
        Dim rnd As New Random
        For j As Integer = 0 To normaltotalpop
            agents(j, 1) = rnd.Next(-50, 0)
            agents(j, 2) = rnd.Next(0, 50)
            'agents(j, 3) = some random computation bound by demographics
            'agents(j, 4) = past experience
            agents(j, 8) = rnd.Next(2, 15)
        Next
        Dim normalairtemp() As Integer = {-30, -15, -5, 5, 15, 15, 5, -5, -15, -30}
        Dim childairtemp() As Integer = {-15, -5, 5, 15, 30, 30, 15, 5, -5, -15}
        Dim elderairtemp() As Integer = {-40, -25, -15, -5, 5, 5, -5, -15, -25, -40}

        Dim temps_lookup(10, 10) As Integer
        For m As Integer = 0 To 9 'm is demographic type
            For n As Integer = 0 To 9 'n is index (that represents the temperature)
                If m = 0 Or m = 1 Then
                    temps_lookup(m, n) = childairtemp(n)
                ElseIf m = 2 Or m = 3 Or m = 4 Or m = 5 Or m = 6 Or m = 7 Then
                    temps_lookup(m, n) = normalairtemp(n)
                Else
                    temps_lookup(m, n) = elderairtemp(n)
                End If
            Next
        Next
        '{30, 0, 40, 0, 50, 0, 60, 0, 70, 0, 80, 0, 90, 0, 100}
        Dim childwater() As Integer = {-50, -50, -40, -40, -20, -20, -10, 0, +15, +15, +20, +15, -10, -15, -30}
        Dim adultwater() As Integer = {-50, -50, -40, -40, -20, -20, -10, 0, +15, +15, +20, +15, -10, -15, -30}
        Dim elderwater() As Integer = {-50, -50, -40, -40, -20, -20, -10, 0, +15, +15, +20, +15, -10, -15, -30}

        Dim water_lookup(10, 15) As Integer
        For m As Integer = 0 To 9
            For n As Integer = 0 To 9
                If m = 0 Or m = 1 Then
                    water_lookup(m, n) = childwater(n)
                ElseIf m = 2 Or m = 3 Or m = 4 Or m = 5 Or m = 6 Or m = 7 Then
                    water_lookup(m, n) = adultwater(n)
                Else
                    water_lookup(m, n) = elderwater(n)
                End If
            Next
        Next

        'Cloudy()
        'Mostly(Cloudy)
        'Partly(Cloudy)
        'Showers()
        'Sunny()
        Dim childcloud() As Integer = {-10, 0, 10, -50, 15}
        Dim adultcloud() As Integer = {-10, 0, 10, -50, 15}
        Dim eldercloud() As Integer = {15, 10, 5, -50, 0}

        Dim cloud_lookup(10, 5) As Integer
        For m As Integer = 0 To 9
            For n As Integer = 0 To 4
                If m = 0 Or m = 1 Then
                    cloud_lookup(m, n) = childcloud(n)
                ElseIf m = 2 Or m = 3 Or m = 4 Or m = 5 Or m = 6 Or m = 7 Then
                    cloud_lookup(m, n) = adultcloud(n)
                Else
                    cloud_lookup(m, n) = eldercloud(n)
                End If
            Next
        Next


        'DATES QUALIA
        ' weekends have preference (maybe not for kids or old people)
        ' holidays are probably going to be crowded (everyone)
        ' seasons: winter=poop spring=spring break? summer=ideal autumn=dwindle to poop


        'TODO fill the other variable tables
        ' for agentIndex = 0 to maxAgents
        ' agents(agentIndex,3) = temps_lookup(agents(agentIndex,1), TODAYS_TEMP)+ cloud_lookup(agents(agentIndex,1), TODAYS_CLOUD) + etc
        ' if agents(agentIndex, 3) < agents(agentIndex, 4) && agents(agentIndex,3)>agents(agentIndex,5)   'if eager is between high and low
        '    set agent(agentIndex, 6) = 1  'this agent went to the beach

        'add up the total number of agents that went [ in agent(agentIndex, 6)]

        'After simulation, go back and adjust min/max values for the agents that went
        'send results to graph



        Dim s As New Series
        s.ChartType = SeriesChartType.Line
        Dim rndDay As New Random
        Dim absence As Integer
        For trials As Integer = 0 To 99



            absence = rndDay.Next(0, 100)
            '
            'Compute the 10 eagerness types
            '
            ' This block takes the day's values, looks up each qualia, and then saves each component
            '  TODO sum the component values to get an overall eagerness DONE
            '  TODO tempindex = (todays_temp - offset) / 5 DONE
            '    if tempindex > max_index {aka temp>110} throw error, or set tempindex=max_index
            Dim eagerness_components(4, 10) As Integer
            For x As Integer = 0 To 3 'x is the qualia type
                If x = 0 Then 'aka TEMPERATURE
                    Dim todays_temp As Integer
                    todays_temp = airTempBox.Value
                    Dim temp_index As Integer
                    temp_index = (todays_temp - 60) / 5

                    If temp_index <= 0 Then
                        temp_index = 0
                    ElseIf temp_index >= 9 Then
                        temp_index = 9
                        'FIXME is max temp 9 or 8?
                    End If

                    For y As Integer = 0 To 9 'y is the demographic number
                        eagerness_components(x, y) = temps_lookup(y, temp_index)
                    Next
                End If

                If x = 1 Then 'aka TEMPERATURE
                    Dim todays_water As Integer
                    todays_water = waterTempBox.Value
                    Dim water_index As Integer
                    water_index = (todays_water - 30) / 5 'check math

                    If water_index <= 0 Then
                        water_index = 0
                    ElseIf water_index >= 9 Then
                        water_index = 9
                        'FIXME is max temp 9 or 8?
                    End If

                    For y As Integer = 0 To 9 'y is the demographic number
                        eagerness_components(x, y) = water_lookup(y, water_index)
                    Next
                End If

                If x = 2 Then
                    Dim todayscloud As String
                    todayscloud = weatherTxt.Text
                    Dim cloud_index As Integer
                    If todayscloud = "Cloudy" Then
                        cloud_index = 0
                    ElseIf todayscloud = "Mostly Cloudy" Then
                        cloud_index = 1
                    ElseIf todayscloud = "Partly Cloudy" Then
                        cloud_index = 2
                    ElseIf todayscloud = "Showers" Then
                        cloud_index = 3
                    ElseIf todayscloud = "Sunny" Then
                        cloud_index = 4
                    End If

                    'TODO grab cloud dropdown DONE
                    '
                    'TODO more qualia
                    For y As Integer = 0 To 9 'y is the demographic number
                        eagerness_components(x, y) = cloud_lookup(y, cloud_index)

                    Next
                End If
            Next


            '
            'Sum up eagerness component for each demographic type
            '
            Dim eagerness_total(10) As Integer
            For x As Integer = 0 To 9 'demographic number
                For y As Integer = 0 To 3 ' y is qualia type
                    eagerness_total(x) = eagerness_total(x) + eagerness_components(y, x)
                Next
            Next


            '
            'Assign agent's eagerness
            '
            '
            For i As Integer = 0 To popTxt.Value - 1
                Dim demographic As Integer
                demographic = agents(i, 0)
                Dim foo As Integer
                foo = eagerness_total(demographic)

                agents(i, 5) = foo
            Next



            '
            'Determine if the agent goes to beach
            '
            Dim beachgoers As Integer

            beachgoers = 0
            For i As Integer = 0 To popTxt.Value - 1
                Dim eager As Integer
                eager = agents(i, 5)
                Dim max As Integer
                max = agents(i, 2)
                Dim min As Integer
                min = agents(i, 1)
                If eager < max And eager > min Then
                    agents(i, 6) = 1
                    beachgoers = beachgoers + 1
                Else
                    agents(i, 6) = 0
                    agents(i, 7) = agents(i, 7) + 1

                    If agents(i, 7) > agents(i, 8) Then
                        absence = rndDay.Next(0, 100)
                        If absence > 50 Then
                            agents(i, 6) = 1
                            beachgoers = beachgoers + 1
                            agents(i, 7) = 0
                        End If

                    End If
                End If
                'OPTIONAL beachgoers++;DONE
            Next

            '
            'Get number of beachgoersDONE
            '
            'beachgoers=0
            'For i to max agents
            '   if agents(i,__went) == 1
            '      beachgoers++


            '
            'TODO publish beachgoer count to graph
            'Dim s As New Series
            's.chartType = SeriesChartType.Line
            's.Points.AddXY(10, 27)
            's.Points.AddXY(20, 15)
            's.Points.AddXY(30, 17)
            'Chart1.Series.Add(s)


            Dim beachNormal As Double
            beachNormal = beachgoers / normaltotalpop * 100
            s.Points.AddXY(trials, beachNormal)
            simResult(trials, 0) = beachNormal
            total = total + beachNormal
            '
            'Good or bad experience?
            '
            Dim notsatisfied As Integer
            If beachgoers < popTxt.Value * 0.15 Then
                '   //too empty
                notsatisfied = 1
            ElseIf beachgoers > popTxt.Value * 0.15 And beachgoers < popTxt.Value * 0.6 Then
                '   //good day
                notsatisfied = 0
            Else
                '   //too crowded
                notsatisfied = 2
            End If


            '
            'Adjust agent's eagerness bounds
            '
            If notsatisfied = 1 Then
                '   //empty, move bounds up
                For i As Integer = 0 To popTxt.Value - 1
                    If agents(i, 6) = 1 Then
                        agents(i, 1) = agents(i, 1) + 5
                        agents(i, 2) = agents(i, 2) + 5
                        agents(i, 4) = agents(i, 4) + 1
                        'Else
                        'agents(i, 7) = agents(i, 7) + 1
                    End If

                Next
            ElseIf notsatisfied = 2 Then
                '   //crowded, move bounds down
                For i As Integer = 0 To popTxt.Value - 1
                    If agents(i, 6) = 1 Then
                        agents(i, 1) = agents(i, 1) - 5
                        agents(i, 2) = agents(i, 2) - 5
                        agents(i, 4) = agents(i, 4) + 1
                        'Else
                        'agents(i, 7) = agents(i, 7) + 1
                    End If
                Next


            End If
            '
            'OPTIONAL keep track of agent's # of fails DONE
            '
        Next
        Chart1.Series.Add(s)

    End Sub

    Private Sub zipTxt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles zipTxt.MaskInputRejected

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub genderBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genderBox.Enter

    End Sub



    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femaleLbl.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TrackBar2_Scroll_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles childrenTbar.Scroll

    End Sub

    Private Sub TrackBar2_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles childrenTbar.ValueChanged
        childrenTbar.Maximum = ("100")
        childrenTbar.TickFrequency = ("10")
        childrenTxt.Value = childrenTbar.Value
        updatePieChart()
    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles youngTbar.Scroll

    End Sub

    Private Sub TrackBar3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles youngTbar.ValueChanged
        youngTbar.Maximum = ("100")
        youngTbar.TickFrequency = ("10")
        youngTxt.Value = youngTbar.Value
        updatePieChart()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teensTbar.Scroll

    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teensTbar.ValueChanged
        teensTbar.Maximum = ("100")
        teensTbar.TickFrequency = ("10")
        teensTxt.Value = teensTbar.Value
        updatePieChart()
    End Sub

    Private Sub TrackBar4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultTbar.Scroll

    End Sub

    Private Sub TrackBar4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultTbar.ValueChanged
        adultTbar.Maximum = ("100")
        adultTbar.TickFrequency = ("10")
        adultTxt.Value = adultTbar.Value
        updatePieChart()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TrackBar5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elderlyTbar.Scroll

    End Sub

    Private Sub TrackBar5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elderlyTbar.ValueChanged
        elderlyTbar.Maximum = ("100")
        elderlyTbar.TickFrequency = ("10")
        elderlyTxt.Value = elderlyTbar.Value
        updatePieChart()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub advoptLbl_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles advoptLbl.LinkClicked
        If Me.MaximumSize.Height = 420 Then
            Me.MaximumSize = New Size(660, 750)
            Me.Size = New Size(660, 750)
            Me.AutoScroll = True
        Else
            Me.MaximumSize = New Size(660, 420)
            Me.AutoScroll = False
        End If
    End Sub

    Private Sub maleTbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maleTbar.Scroll

    End Sub

    Private Sub malePerLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles malePerLbl.Click

    End Sub
    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femaleTbar.Scroll

    End Sub
    Private Sub maleTbar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maleTbar.ValueChanged
        malePerLbl.Text = maleTbar.Value & ("%")
        femaleTbar.Value = 100 - maleTbar.Value
    End Sub

    Private Sub femaleTbar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femaleTbar.ValueChanged
        femalePerLbl.Text = femaleTbar.Value & ("%")
        maleTbar.Value = 100 - femaleTbar.Value
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub childrenTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles childrenTxt.ValueChanged
        childrenTbar.Value = childrenTxt.Value
    End Sub

    Private Sub teensTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teensTxt.ValueChanged
        teensTbar.Value = teensTxt.Value
    End Sub

    Private Sub youngTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles youngTxt.ValueChanged
        youngTbar.Value = youngTxt.Value
    End Sub

    Private Sub adultTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultTxt.ValueChanged
        adultTbar.Value = adultTxt.Value
    End Sub

    Private Sub elderlyTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elderlyTxt.ValueChanged
        elderlyTbar.Value = elderlyTxt.Value
    End Sub

    Private Sub popTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popTxt.ValueChanged

    End Sub

    Private Sub defaultBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultBtn.Click
        airTempBox.Value = 85
        waterTempBox.Value = 75
        popTxt.Value = 100
        maleTbar.Value = 50
        femaleTbar.Value = 50
        weatherTxt.Text = "Sunny"
        childrenTxt.Value = 20
        youngTxt.Value = 20
        adultTxt.Value = 20
        teensTxt.Value = 20
        elderlyTxt.Value = 20
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub weatherTxt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weatherTxt.SelectedIndexChanged

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim Connection As MySqlConnection
        Connection = New MySqlConnection("Server=144.76.19.105;Database=beachsim;Uid=beachsim;pwd=bAtCFWe5KpZG")
        Try
            Connection.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Can't connect to database. Your internet may be off")
        End Try

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = Connection
            .CommandText = "UPDATE `Accounts` SET `Population` = " & popTxt.Text & ", `Airtemp` = " & airTempBox.Value & ", `Watertemp` = " & waterTempBox.Value & ", `Weather` = '" & weatherTxt.Text & "', `Male` = " & maleTbar.Value & ", `Female` = " & femaleTbar.Value & ", `0-9` = " & childrenTxt.Value & ", `10-19` = " & teensTxt.Value & ", `20-39` = " & youngTxt.Value & ", `40-59` =" & adultTxt.Value & ", `60+` = " & elderlyTxt.Value & " WHERE `Email` = '" & Login.UsernameTxtBx.Text & "'"
            cmd.ExecuteNonQuery()
        End With
        Connection.Close()
    End Sub


    Private Sub femalePerLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femalePerLbl.Click

    End Sub

    Private Sub Chart2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chrt.Click

    End Sub

    Private Sub mylocationRdbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mylocationRdbtn.CheckedChanged

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Export(saveFileDialog1.FileName)
        End If
    End Sub
    Private Function Export(ByVal fileN As String) As Boolean
        If My.Computer.FileSystem.FileExists(fileN) Then
            My.Computer.FileSystem.DeleteFile(fileN)
            Debug.Write("File Deleted" & vbCrLf)
        Else
            Debug.Write("File Does Not Exist" & vbCrLf)
        End If
        My.Computer.FileSystem.WriteAllText(fileN, "SimNum: ", True)
        My.Computer.FileSystem.WriteAllText(fileN, " ", True)
        My.Computer.FileSystem.WriteAllText(fileN, "Attendance:(%Beachgoers)", True)
        My.Computer.FileSystem.WriteAllText(fileN, vbCrLf, True)
        For index As Integer = 1 To 100
            If index < 10 Then
                My.Computer.FileSystem.WriteAllText(fileN, index, True)
                My.Computer.FileSystem.WriteAllText(fileN, "        ", True)
                My.Computer.FileSystem.WriteAllText(fileN, simResult(index - 1, 0), True)
                My.Computer.FileSystem.WriteAllText(fileN, vbCrLf, True)
            ElseIf index < 100 Then
                My.Computer.FileSystem.WriteAllText(fileN, index, True)
                My.Computer.FileSystem.WriteAllText(fileN, "       ", True)
                My.Computer.FileSystem.WriteAllText(fileN, simResult(index - 1, 0), True)
                My.Computer.FileSystem.WriteAllText(fileN, vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(fileN, index, True)
                My.Computer.FileSystem.WriteAllText(fileN, "      ", True)
                My.Computer.FileSystem.WriteAllText(fileN, simResult(index - 1, 0), True)
                My.Computer.FileSystem.WriteAllText(fileN, vbCrLf, True)
            End If
        Next
        My.Computer.FileSystem.WriteAllText(fileN, "Average Attendance: " & (total / 100), True)
        Return 1
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Save Test
        Dim Connection As MySqlConnection
        Dim Result As MySqlDataReader
        Dim resultpass As String
        Connection = New MySqlConnection("Server=144.76.19.105;Database=beachsim;Uid=beachsim;pwd=bAtCFWe5KpZG")
        Try
            Connection.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Can't connect to database. Your internet may be off")
        End Try

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = Connection
            .CommandText = "UPDATE `Accounts` SET `Population` = " & popTxt.Text & ", `Airtemp` = " & airTempBox.Value & ", `Watertemp` = " & waterTempBox.Value & ", `Weather` = '" & weatherTxt.Text & "', `Male` = " & maleTbar.Value & ", `Female` = " & femaleTbar.Value & ", `0-9` = " & childrenTxt.Value & ", `10-19` = " & teensTxt.Value & ", `20-39` = " & youngTxt.Value & ", `40-59` =" & adultTxt.Value & ", `60+` = " & elderlyTxt.Value & " WHERE `Email` = '" & Login.UsernameTxtBx.Text & "'"
            cmd.ExecuteNonQuery()
        End With
        'Load Test within Save
        Dim passfail As Integer
        passfail = 0
        Dim passfailLoad As Integer
        passfailLoad = 0
        With cmd
            .Connection = Connection
            .CommandText = "SELECT * FROM Accounts WHERE Email = '" & Login.UsernameTxtBx.Text & "'"
            Result = cmd.ExecuteReader
            If Result.Read Then
                resultpass = Result.GetString(20)
                If popTxt.Value <> resultpass Then
                    passfail = 1
                End If
                popTxt.Value = resultpass
                If popTxt.Value <> Result.GetString(20) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(21)
                If airTempBox.Value <> resultpass Then
                    passfail = 1
                End If
                airTempBox.Value = resultpass
                If airTempBox.Value <> Result.GetInt16(21) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(22)
                If waterTempBox.Value <> resultpass Then
                    passfail = 1
                End If
                waterTempBox.Value = resultpass
                If waterTempBox.Value <> Result.GetInt16(22) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetString(23)
                If weatherTxt.Text <> resultpass Then
                    passfail = 1
                End If
                weatherTxt.Text = resultpass
                If weatherTxt.Text <> Result.GetString(23) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(24)
                If maleTbar.Value <> resultpass Then
                    passfail = 1
                End If
                maleTbar.Value = resultpass
                If maleTbar.Value <> Result.GetInt16(24) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(25)
                If femaleTbar.Value <> resultpass Then
                    passfail = 1
                End If
                femaleTbar.Value = resultpass
                If femaleTbar.Value <> Result.GetInt16(25) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(26)
                If childrenTbar.Value <> resultpass Then
                    passfail = 1
                End If
                childrenTbar.Value = resultpass
                If childrenTbar.Value <> Result.GetInt16(26) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(27)
                If teensTxt.Value <> resultpass Then
                    passfail = 1
                End If
                teensTxt.Value = resultpass
                If teensTxt.Value <> Result.GetInt16(27) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(28)
                If youngTxt.Value <> resultpass Then
                    passfail = 1
                End If
                youngTxt.Value = resultpass
                If youngTxt.Value <> Result.GetInt16(28) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(29)
                If adultTxt.Value <> resultpass Then
                    passfail = 1
                End If
                adultTxt.Value = resultpass
                If adultTxt.Value <> Result.GetInt16(29) Then
                    passfailLoad = 1
                End If

                resultpass = Result.GetInt16(30)
                If elderlyTxt.Value <> resultpass Then
                    passfail = 1
                End If
                elderlyTxt.Value = resultpass
                If elderlyTxt.Value <> Result.GetInt16(30) Then
                    passfailLoad = 1
                End If

                Result.Close()
            End If



        End With

        Connection.Close()

        If passfail <> 0 Then
            Debug.Write("Save Failed" & vbCrLf)
        Else
            Debug.Write("Save Success" & vbCrLf)
        End If

        If passfailLoad <> 0 Then
            Debug.Write("Load Failed" & vbCrLf)
        Else
            Debug.Write("Load Success" & vbCrLf)
        End If


        'Export Test
        Dim path As String = Directory.GetCurrentDirectory()
        Export(path & "/test.txt")
        If My.Computer.FileSystem.FileExists(path & "/test.txt") Then
            Debug.Write("Test Passed: Simulation was exported" & vbCrLf)
        Else
            Debug.Write("Test Failed: Simulation was not exported" & vbCrLf)
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Connection As MySqlConnection
        Dim Result As MySqlDataReader
        Dim resultpass As String
        Connection = New MySqlConnection("Server=144.76.19.105;Database=beachsim;Uid=beachsim;pwd=bAtCFWe5KpZG")
        Try
            Connection.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("Can't connect to database. Your internet may be off")
        End Try

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = Connection
            .CommandText = "SELECT * FROM Accounts WHERE Email = '" & Login.UsernameTxtBx.Text & "'"
            Result = cmd.ExecuteReader
            If Result.Read Then
                resultpass = Result.GetString(20)
                popTxt.Value = resultpass
                resultpass = Result.GetInt16(21)
                airTempBox.Value = resultpass
                resultpass = Result.GetInt16(22)
                waterTempBox.Value = resultpass
                resultpass = Result.GetString(23)
                weatherTxt.Text = resultpass
                resultpass = Result.GetInt16(24)
                maleTbar.Value = resultpass
                resultpass = Result.GetInt16(25)
                femaleTbar.Value = resultpass
                resultpass = Result.GetInt16(26)
                childrenTbar.Value = resultpass
                resultpass = Result.GetInt16(27)
                teensTxt.Value = resultpass
                resultpass = Result.GetInt16(28)
                youngTxt.Value = resultpass
                resultpass = Result.GetInt16(29)
                adultTxt.Value = resultpass
                resultpass = Result.GetInt16(30)
                elderlyTxt.Value = resultpass
                Result.Close()
            End If

            Connection.Close()

        End With
    End Sub
End Class
