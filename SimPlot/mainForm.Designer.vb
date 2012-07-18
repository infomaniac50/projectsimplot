<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.textBox = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.comPortComboBox = New System.Windows.Forms.ComboBox()
        Me.baudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.connectDisconnectButton = New System.Windows.Forms.Button()
        Me.plotSetupBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerTickLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TerminalWindow = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.128205!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.8718!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1034, 624)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 567)
        Me.SplitContainer1.SplitterDistance = 427
        Me.SplitContainer1.TabIndex = 0
        '
        'Chart1
        '
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX.MinorTickMark.Enabled = True
        ChartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.LineColor = System.Drawing.Color.Silver
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.MinorTickMark.Enabled = True
        ChartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.BackColor = System.Drawing.Color.Black
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series5.BorderWidth = 2
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series5.Color = System.Drawing.Color.Yellow
        Series5.Legend = "Legend1"
        Series5.Name = "Channel 1"
        Series5.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series5.ShadowOffset = 1
        Series6.BorderWidth = 2
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series6.Color = System.Drawing.Color.LawnGreen
        Series6.Legend = "Legend1"
        Series6.Name = "Channel 2"
        Series6.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series6.ShadowOffset = 1
        Series7.BorderWidth = 2
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series7.Color = System.Drawing.Color.Aqua
        Series7.Legend = "Legend1"
        Series7.Name = "Channel 3"
        Series7.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series7.ShadowOffset = 1
        Series8.BorderWidth = 2
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series8.Color = System.Drawing.Color.Magenta
        Series8.Legend = "Legend1"
        Series8.Name = "Channel 4"
        Series8.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series8.ShadowOffset = 1
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(1028, 427)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "-+"
        '
        'textBox
        '
        Me.textBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox.Location = New System.Drawing.Point(0, 0)
        Me.textBox.MaxLength = 100000
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(320, 136)
        Me.textBox.TabIndex = 0
        Me.textBox.Text = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.comPortComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.baudRateComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.connectDisconnectButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.plotSetupBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1028, 24)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'comPortComboBox
        '
        Me.comPortComboBox.FormattingEnabled = True
        Me.comPortComboBox.Location = New System.Drawing.Point(3, 3)
        Me.comPortComboBox.Name = "comPortComboBox"
        Me.comPortComboBox.Size = New System.Drawing.Size(99, 21)
        Me.comPortComboBox.Sorted = True
        Me.comPortComboBox.TabIndex = 12
        '
        'baudRateComboBox
        '
        Me.baudRateComboBox.FormattingEnabled = True
        Me.baudRateComboBox.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200", "128000", "256000"})
        Me.baudRateComboBox.Location = New System.Drawing.Point(108, 3)
        Me.baudRateComboBox.Name = "baudRateComboBox"
        Me.baudRateComboBox.Size = New System.Drawing.Size(92, 21)
        Me.baudRateComboBox.TabIndex = 13
        '
        'connectDisconnectButton
        '
        Me.connectDisconnectButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.connectDisconnectButton.Location = New System.Drawing.Point(206, 3)
        Me.connectDisconnectButton.Name = "connectDisconnectButton"
        Me.connectDisconnectButton.Size = New System.Drawing.Size(75, 21)
        Me.connectDisconnectButton.TabIndex = 14
        Me.connectDisconnectButton.Text = "Connect"
        Me.connectDisconnectButton.UseVisualStyleBackColor = True
        '
        'plotSetupBtn
        '
        Me.plotSetupBtn.Location = New System.Drawing.Point(286, 2)
        Me.plotSetupBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.plotSetupBtn.Name = "plotSetupBtn"
        Me.plotSetupBtn.Size = New System.Drawing.Size(79, 19)
        Me.plotSetupBtn.TabIndex = 15
        Me.plotSetupBtn.Text = "Plot Setup"
        Me.plotSetupBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TimerTickLabel, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel_Version})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1034, 25)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(63, 20)
        Me.ToolStripStatusLabel1.Text = "Timer Tick"
        '
        'TimerTickLabel
        '
        Me.TimerTickLabel.AutoSize = False
        Me.TimerTickLabel.AutoToolTip = True
        Me.TimerTickLabel.Name = "TimerTickLabel"
        Me.TimerTickLabel.Size = New System.Drawing.Size(70, 20)
        Me.TimerTickLabel.ToolTipText = "If the counter is not updating then program has crashed or stuck in loop."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(100, 20)
        Me.ToolStripStatusLabel2.Text = "Version"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel_Version
        '
        Me.ToolStripStatusLabel_Version.Name = "ToolStripStatusLabel_Version"
        Me.ToolStripStatusLabel_Version.Size = New System.Drawing.Size(0, 20)
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM10"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AccessibleDescription = "Vertical Split for Text boxes"
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TerminalWindow)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.textBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(1028, 136)
        Me.SplitContainer2.SplitterDistance = 704
        Me.SplitContainer2.TabIndex = 0
        '
        'TerminalWindow
        '
        Me.TerminalWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TerminalWindow.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminalWindow.Location = New System.Drawing.Point(0, 0)
        Me.TerminalWindow.MaxLength = 1000000
        Me.TerminalWindow.Name = "TerminalWindow"
        Me.TerminalWindow.Size = New System.Drawing.Size(704, 136)
        Me.TerminalWindow.TabIndex = 0
        Me.TerminalWindow.Text = ""
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 624)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "mainForm"
        Me.Text = "SimPlot"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents textBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerTickLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents comPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents baudRateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents connectDisconnectButton As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents plotSetupBtn As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TerminalWindow As System.Windows.Forms.RichTextBox

End Class
