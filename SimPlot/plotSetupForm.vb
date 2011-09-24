Imports System.Windows.Forms



Public Class plotSetup

    Public Const MAX_X_AXIS_POINTS As Integer = 1000
    Public Const MAX_DATA_SERIES As Integer = 4

    Public xAxisNumPoints As Integer = 200
    Public yAxisMinVal As Integer = -1000
    Public yAxisMaxVal As Integer = 1000



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim correctValues As Boolean = True
        Dim number As Integer


        Try
            number = Int32.Parse(XAxisNumPointsTextBox.Text)
            If (number < 0 Or number > MAX_X_AXIS_POINTS) Then
                MessageBox.Show("X axis value is out of range.")
                correctValues = False
            Else
                xAxisNumPoints = number
            End If
        Catch
            MessageBox.Show("X axis value should be integer value")
            correctValues = False
        End Try


        Try
            number = Int32.Parse(yAxisMinValTextBox.Text)
            yAxisMinVal = number
        Catch
            MessageBox.Show("Y axis min value should be integer value")
            correctValues = False
        End Try

        Try
            number = Int32.Parse(yAxisMaxValTextBox.Text)
            yAxisMaxVal = number
        Catch
            MessageBox.Show("Y axis max value should be integer value")
            correctValues = False
        End Try

        'Update channel legends


        If (correctValues = True) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
