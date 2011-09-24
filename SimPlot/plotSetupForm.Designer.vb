<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class plotSetup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.plotSetupXGroup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XAxisNumPointsTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.yAxisMaxValTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.yAxisMinValTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Ch4EnChkBox = New System.Windows.Forms.CheckBox()
        Me.Ch3EnChkBox = New System.Windows.Forms.CheckBox()
        Me.Ch2EnChkBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ch1EnChkBox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ch1LegendTxtBox = New System.Windows.Forms.TextBox()
        Me.Ch2LegendTxtBox = New System.Windows.Forms.TextBox()
        Me.Ch3LegendTxtBox = New System.Windows.Forms.TextBox()
        Me.Ch4LegendTxtBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.plotSetupXGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(305, 480)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'plotSetupXGroup
        '
        Me.plotSetupXGroup.Controls.Add(Me.Label2)
        Me.plotSetupXGroup.Controls.Add(Me.Label1)
        Me.plotSetupXGroup.Controls.Add(Me.XAxisNumPointsTextBox)
        Me.plotSetupXGroup.Location = New System.Drawing.Point(12, 12)
        Me.plotSetupXGroup.Name = "plotSetupXGroup"
        Me.plotSetupXGroup.Size = New System.Drawing.Size(497, 65)
        Me.plotSetupXGroup.TabIndex = 1
        Me.plotSetupXGroup.TabStop = False
        Me.plotSetupXGroup.Text = "X Axis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Integer value between 10 to 1000."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of data points"
        '
        'XAxisNumPointsTextBox
        '
        Me.XAxisNumPointsTextBox.Location = New System.Drawing.Point(160, 28)
        Me.XAxisNumPointsTextBox.Name = "XAxisNumPointsTextBox"
        Me.XAxisNumPointsTextBox.Size = New System.Drawing.Size(66, 22)
        Me.XAxisNumPointsTextBox.TabIndex = 3
        Me.XAxisNumPointsTextBox.Tag = ""
        Me.XAxisNumPointsTextBox.Text = "200"
        Me.XAxisNumPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.yAxisMaxValTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.yAxisMinValTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 129)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Y Axis"
        '
        'yAxisMaxValTextBox
        '
        Me.yAxisMaxValTextBox.Location = New System.Drawing.Point(160, 84)
        Me.yAxisMaxValTextBox.Name = "yAxisMaxValTextBox"
        Me.yAxisMaxValTextBox.Size = New System.Drawing.Size(66, 22)
        Me.yAxisMaxValTextBox.TabIndex = 4
        Me.yAxisMaxValTextBox.Text = "1000"
        Me.yAxisMaxValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Maximum Value"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(313, 54)
        Me.Label4.MaximumSize = New System.Drawing.Size(0, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 50)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Interger value, range is data dependant."
        '
        'yAxisMinValTextBox
        '
        Me.yAxisMinValTextBox.Location = New System.Drawing.Point(160, 38)
        Me.yAxisMinValTextBox.Name = "yAxisMinValTextBox"
        Me.yAxisMinValTextBox.Size = New System.Drawing.Size(66, 22)
        Me.yAxisMinValTextBox.TabIndex = 1
        Me.yAxisMinValTextBox.Text = "-1000"
        Me.yAxisMinValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Minimum Value"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 232)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Channels"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch4EnChkBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch3EnChkBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch2EnChkBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch1EnChkBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch1LegendTxtBox, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch2LegendTxtBox, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch3LegendTxtBox, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Ch4LegendTxtBox, 2, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(17, 21)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(466, 196)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(235, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 39)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Legend"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 40)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Channel 4"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 39)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Channel 3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 39)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Channel 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ch4EnChkBox
        '
        Me.Ch4EnChkBox.AutoSize = True
        Me.Ch4EnChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch4EnChkBox.Checked = True
        Me.Ch4EnChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ch4EnChkBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ch4EnChkBox.Location = New System.Drawing.Point(119, 159)
        Me.Ch4EnChkBox.Name = "Ch4EnChkBox"
        Me.Ch4EnChkBox.Size = New System.Drawing.Size(110, 34)
        Me.Ch4EnChkBox.TabIndex = 4
        Me.Ch4EnChkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch4EnChkBox.UseVisualStyleBackColor = True
        '
        'Ch3EnChkBox
        '
        Me.Ch3EnChkBox.AutoSize = True
        Me.Ch3EnChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch3EnChkBox.Checked = True
        Me.Ch3EnChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ch3EnChkBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ch3EnChkBox.Location = New System.Drawing.Point(119, 120)
        Me.Ch3EnChkBox.Name = "Ch3EnChkBox"
        Me.Ch3EnChkBox.Size = New System.Drawing.Size(110, 33)
        Me.Ch3EnChkBox.TabIndex = 3
        Me.Ch3EnChkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch3EnChkBox.UseVisualStyleBackColor = True
        '
        'Ch2EnChkBox
        '
        Me.Ch2EnChkBox.AutoSize = True
        Me.Ch2EnChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch2EnChkBox.Checked = True
        Me.Ch2EnChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ch2EnChkBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ch2EnChkBox.Location = New System.Drawing.Point(119, 81)
        Me.Ch2EnChkBox.Name = "Ch2EnChkBox"
        Me.Ch2EnChkBox.Size = New System.Drawing.Size(110, 33)
        Me.Ch2EnChkBox.TabIndex = 2
        Me.Ch2EnChkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch2EnChkBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(119, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 39)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Enable"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ch1EnChkBox
        '
        Me.Ch1EnChkBox.AutoSize = True
        Me.Ch1EnChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch1EnChkBox.Checked = True
        Me.Ch1EnChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ch1EnChkBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ch1EnChkBox.Location = New System.Drawing.Point(119, 42)
        Me.Ch1EnChkBox.Name = "Ch1EnChkBox"
        Me.Ch1EnChkBox.Size = New System.Drawing.Size(110, 33)
        Me.Ch1EnChkBox.TabIndex = 1
        Me.Ch1EnChkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ch1EnChkBox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 39)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Channel 1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChLegendTxtBox1
        '
        Me.Ch1LegendTxtBox.Location = New System.Drawing.Point(235, 42)
        Me.Ch1LegendTxtBox.Name = "ChLegendTxtBox1"
        Me.Ch1LegendTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.Ch1LegendTxtBox.TabIndex = 10
        Me.Ch1LegendTxtBox.Text = "Channel 1"
        Me.Ch1LegendTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChLegendTxtBox2
        '
        Me.Ch2LegendTxtBox.Location = New System.Drawing.Point(235, 81)
        Me.Ch2LegendTxtBox.Name = "ChLegendTxtBox2"
        Me.Ch2LegendTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.Ch2LegendTxtBox.TabIndex = 11
        Me.Ch2LegendTxtBox.Text = "Channel 2"
        Me.Ch2LegendTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChLegendTxtBox3
        '
        Me.Ch3LegendTxtBox.Location = New System.Drawing.Point(235, 120)
        Me.Ch3LegendTxtBox.Name = "ChLegendTxtBox3"
        Me.Ch3LegendTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.Ch3LegendTxtBox.TabIndex = 12
        Me.Ch3LegendTxtBox.Text = "Channel 3"
        Me.Ch3LegendTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChLegendTxtBox4
        '
        Me.Ch4LegendTxtBox.Location = New System.Drawing.Point(235, 159)
        Me.Ch4LegendTxtBox.Name = "ChLegendTxtBox4"
        Me.Ch4LegendTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.Ch4LegendTxtBox.TabIndex = 13
        Me.Ch4LegendTxtBox.Text = "Channel 4"
        Me.Ch4LegendTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'plotSetup
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(516, 531)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.plotSetupXGroup)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "plotSetup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plot Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.plotSetupXGroup.ResumeLayout(False)
        Me.plotSetupXGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents plotSetupXGroup As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XAxisNumPointsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents yAxisMinValTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents yAxisMaxValTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ch4EnChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents Ch3EnChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents Ch2EnChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents Ch1EnChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Ch1LegendTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Ch2LegendTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Ch3LegendTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Ch4LegendTxtBox As System.Windows.Forms.TextBox

End Class
