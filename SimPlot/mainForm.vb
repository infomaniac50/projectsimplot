Public Class mainForm

    Private pktSize As Integer = 0
    Private pktBuf(1000) As Byte

    Private points As New ArrayList
    Private pointsArray As New ArrayList


    Private Sub updateComPortList()

        comPortComboBox.Items.Clear()
        comPortComboBox.Items.Add("None")

        Dim s As String
        For Each s In IO.Ports.SerialPort.GetPortNames()
            comPortComboBox.Items.Add(s)
        Next s

        comPortComboBox.SelectedIndex = 0
        baudRateComboBox.SelectedIndex = 0
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'NOTE: The version info does not come out correctly when debugging inside Visual Studio. It comes out correctly
        'when installed and run from using the Click-once generated setup files.
        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                ToolStripStatusLabel_Version.Text = .Major & "." & .Minor
            End With
        End If

        updateComPortList()
        ''''''Chart Setup'''''''
        Chart1.ChartAreas(0).AxisX.Maximum = plotSetup.xAxisNumPoints
        Chart1.ChartAreas(0).AxisY.Minimum = plotSetup.yAxisMinVal
        Chart1.ChartAreas(0).AxisY.Maximum = plotSetup.yAxisMaxVal

        ' Adjust Y & X axis scale
        Chart1.ResetAutoValues()

        ' Add any initialization after the InitializeComponent() call.
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Dim tickCount As UShort = 0

        'integer overflow generates an exception in .net
        If tickCount = UShort.MaxValue Then
            tickCount = 0
        Else
            tickCount += 1
        End If

        TimerTickLabel.Text = tickCount

        If connectDisconnectButton.Text = "Disconnect" Then

            'Parse the data from serial port and store all the packets in a collection data type.
            parseData()

        End If

        ' '''''''''''''''Simulating data '''''''''''''''''''''''
        'Static Dim ANGLE As Double = 0

        'ANGLE += Math.PI / 53
        'points.Add(1000 * Math.Cos(ANGLE))
        'points.Add(1000 * Math.Sin(ANGLE))
        'points.Add(1000 * Math.Cos(ANGLE) / 2)
        'If Chart1.Series(0).Points.Count = plotSetup.xAxisNumPoints Then
        '    points.Add(1000 * Math.Sin(ANGLE) / 2)
        'End If


        'pointsArray.Add(New ArrayList(points))
        'points.Clear()

        'ANGLE += Math.PI / 53
        'points.Add(1000 * Math.Cos(ANGLE))
        'points.Add(1000 * Math.Sin(ANGLE))
        'points.Add(1000 * Math.Cos(ANGLE) / 2)
        'If Chart1.Series(0).Points.Count = plotSetup.xAxisNumPoints Then
        '    points.Add(1000 * Math.Sin(ANGLE) / 2)
        'End If


        'pointsArray.Add(New ArrayList(points))
        'points.Clear()

        'ANGLE += Math.PI / 53
        'points.Add(1000 * Math.Cos(ANGLE))
        'points.Add(1000 * Math.Sin(ANGLE))
        'points.Add(1000 * Math.Cos(ANGLE) / 2)
        'If Chart1.Series(0).Points.Count = plotSetup.xAxisNumPoints Then
        '    points.Add(1000 * Math.Sin(ANGLE) / 2)
        'End If

        'pointsArray.Add(New ArrayList(points))
        'points.Clear()

        'ANGLE += Math.PI / 53
        'points.Add(1000 * Math.Cos(ANGLE))
        'points.Add(1000 * Math.Sin(ANGLE))
        'points.Add(1000 * Math.Cos(ANGLE) / 2)
        'If Chart1.Series(0).Points.Count = plotSetup.xAxisNumPoints Then
        '    points.Add(1000 * Math.Sin(ANGLE) / 2)
        'End If

        'pointsArray.Add(New ArrayList(points))
        'points.Clear()
        ' '''''''''''''''end of Simulating data '''''''''''''''''''''''


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' At this stage pointsArray contains the new samples obtained from the serial port.
        ' pointsArray is an array of arrays.
        ' Perform any filtering or signal processing on the samples at this point.
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



        'Copy new samples from pointsArray into the plot array
        'check if there is something to plot
        If pointsArray.Count > 0 Then
            Chart1.Series.SuspendUpdates()

            'Outer for loop, cycles through the array containing samples from different sampling instants
            For Each i In pointsArray
                'inner loops cycles through the samples of data from different channels at a given sampling instant.
                For j As Integer = 0 To plotSetup.MAX_DATA_SERIES - 1 Step 1

                    'the number of channels on chart and number of channels in the packet may not match
                    If j < i.count Then
                        'add the samples to the chart that were got from serial port
                        Chart1.Series(j).Points.AddY(i.item(j))
                    Else
                        'if less number of samples than number of channels were got, then add "nothing" data points to remaining channels 
                        'so that they are in sync with other channels
                        Chart1.Series(j).Points.AddY(0.0)
                        Chart1.Series(j).Points(Chart1.Series(j).Points.Count - 1).IsEmpty = True

                    End If
                Next
            Next

            While Chart1.Series(0).Points.Count > plotSetup.xAxisNumPoints
                For Each i In Chart1.Series
                    i.Points.RemoveAt(0)
                Next
            End While


            Chart1.Series.ResumeUpdates()
            ' Adjust Y & X axis scale
            Chart1.ResetAutoValues()

        End If

    End Sub

    Private Sub connectDisconnectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connectDisconnectButton.Click

        If connectDisconnectButton.Text = "Connect" Then
            If comPortOpen() Then
                connectDisconnectButton.Text = "Disconnect"
            Else
                textBox.AppendText("Error: Unable to open specified Com Port")
            End If
        Else
            SerialPort1.Close()
            connectDisconnectButton.Text = "Connect"
        End If

    End Sub

    Private Function comPortOpen() As Boolean
        Dim portName As String = Nothing
        Dim baudRate As Integer

        portName = comPortComboBox.Text
        baudRate = Convert.ToInt32(baudRateComboBox.Text)

        textBox.AppendText("Port Name :" & portName & vbCrLf)
        textBox.AppendText("Baud Rate :" & baudRate & vbCrLf)

        SerialPort1.PortName = portName
        SerialPort1.BaudRate = baudRate
        SerialPort1.Open()

        If SerialPort1.IsOpen Then
            textBox.AppendText("Serial Port Opened")
            textBox.AppendText(Environment.NewLine)
            Return True
        End If


        Return False
    End Function

    Public Enum ParseState_MC
        IDLE
        HEADER1
        HEADER2
        PKT_SIZE
        PAYLOAD
    End Enum

    Private Function parseData() As Boolean
        Dim tempByte As Byte
        Static Dim tempBuf(2) As Byte
        Static Dim asciBuf As New ArrayList

        Dim byteCount As Integer = 0

        Static Dim parseState As ParseState_MC = ParseState_MC.IDLE

        points.Clear()
        pointsArray.Clear()
        byteCount = SerialPort1.BytesToRead

        While byteCount > 0
            Select Case parseState
                Case ParseState_MC.IDLE
                    pktSize = 0
                    tempByte = SerialPort1.ReadByte()
                    byteCount -= 1
                    '171 = hex AB
                    If tempByte = &HAB Then
                        parseState = ParseState_MC.HEADER1
                    Else
                        asciBuf.Add(CStr(tempByte))
                        parseState = ParseState_MC.IDLE
                    End If

                Case ParseState_MC.HEADER1
                    tempByte = SerialPort1.ReadByte()
                    byteCount -= 1
                    '205 = hex CD
                    If tempByte = &HCD Then
                        parseState = ParseState_MC.HEADER2
                    Else
                        asciBuf.Add(CStr(tempByte))
                        parseState = ParseState_MC.IDLE
                    End If

                Case ParseState_MC.HEADER2
                    tempBuf(0) = SerialPort1.ReadByte()
                    byteCount -= 1
                    parseState = ParseState_MC.PKT_SIZE

                Case ParseState_MC.PKT_SIZE
                    tempBuf(1) = SerialPort1.ReadByte()
                    byteCount -= 1
                    parseState = ParseState_MC.PAYLOAD
                    pktSize = BitConverter.ToUInt16(tempBuf, 0)

                Case ParseState_MC.PAYLOAD
                    ''IMPORTANT : buffer size is only 1000.
                    If byteCount >= pktSize Then
                        SerialPort1.Read(pktBuf, 0, pktSize)
                        byteCount -= pktSize
                        parseState = ParseState_MC.IDLE

                        points = byteArrayToInt16(pktBuf, pktSize)
                        pointsArray.Add(points)

                        ''ToArray function: converts the ArrayList collection to Array type
                        '' CType type casting function is used here to convert the Array collection to string array
                        ''Dim arr() As String = CType(tempArray.ToArray(Type.GetType("System.String")), String())
                        'tempstr = String.Join("", CType(asciBuf.ToArray(GetType(String)), String()))
                        'textBox.AppendText(tempstr)
                        'textBox.AppendText(tempstr)
                    Else
                        'Full packet not arrived yet, try in the next iteration
                        byteCount = 0
                        parseState = ParseState_MC.IDLE
                    End If

            End Select
        End While

        'Dim text As String() = CType(asciBuf.ToArray(GetType(String)), String())
        'tempstr = String.Join("", CType(asciBuf.ToArray(GetType(String)), String()))
        'textBox.AppendText(tempstr)
        'textBox.AppendText(tempstr)
        asciBuf.Clear()
        If pointsArray.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function byteArrayToInt16(ByVal buf() As Byte, ByVal len As Integer) As ArrayList
        Dim myAL As New ArrayList()

        For i As Integer = 0 To len - 1 Step 2
            If i + 2 > len Then
                Exit For
            End If
            myAL.Add(BitConverter.ToInt16(buf, i))
        Next

        Return myAL

    End Function

    Private Sub comPortComboBox_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comPortComboBox.DropDown
        updateComPortList()
    End Sub

    Private Sub plotSetupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotSetupBtn.Click
        If plotSetup.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Chart1.Series.SuspendUpdates()
            Chart1.ChartAreas(0).AxisX.Maximum = plotSetup.xAxisNumPoints
            Chart1.ChartAreas(0).AxisY.Minimum = plotSetup.yAxisMinVal
            Chart1.ChartAreas(0).AxisY.Maximum = plotSetup.yAxisMaxVal

            Chart1.Series(0).Name = plotSetup.Ch1LegendTxtBox.Text
            Chart1.Series(1).Name = plotSetup.Ch2LegendTxtBox.Text
            Chart1.Series(2).Name = plotSetup.Ch3LegendTxtBox.Text
            Chart1.Series(3).Name = plotSetup.Ch4LegendTxtBox.Text

            Chart1.Series(0).Enabled = plotSetup.Ch1EnChkBox.Checked
            Chart1.Series(1).Enabled = plotSetup.Ch2EnChkBox.Checked
            Chart1.Series(2).Enabled = plotSetup.Ch3EnChkBox.Checked
            Chart1.Series(3).Enabled = plotSetup.Ch4EnChkBox.Checked

            ' Adjust Y & X axis scale
            Chart1.ResetAutoValues()
            Chart1.Series.ResumeUpdates()
        End If
    End Sub
End Class
