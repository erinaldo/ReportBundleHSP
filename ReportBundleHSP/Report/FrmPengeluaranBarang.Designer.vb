﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengeluaranBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPengeluaranBarang))
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboKodeUnit = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cboMesin = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.cboShift = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboLaporan = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.RPT = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Toolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.cboKodeUnit, Me.ToolStripSeparator6, Me.ToolStripLabel5, Me.cboMesin, Me.ToolStripSeparator3, Me.ToolStripLabel7, Me.cboShift, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.cboLaporan, Me.ToolStripSeparator4, Me.btRefresh})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Toolbar.Size = New System.Drawing.Size(1086, 31)
        Me.Toolbar.TabIndex = 5
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(58, 28)
        Me.ToolStripLabel3.Text = "&Tanggal : "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 28)
        Me.ToolStripLabel2.Text = "&Unit Produksi :"
        '
        'cboKodeUnit
        '
        Me.cboKodeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKodeUnit.Name = "cboKodeUnit"
        Me.cboKodeUnit.Size = New System.Drawing.Size(150, 31)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(45, 28)
        Me.ToolStripLabel5.Text = "Mesin :"
        Me.ToolStripLabel5.Visible = False
        '
        'cboMesin
        '
        Me.cboMesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesin.Name = "cboMesin"
        Me.cboMesin.Size = New System.Drawing.Size(150, 31)
        Me.cboMesin.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        Me.ToolStripSeparator3.Visible = False
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(40, 28)
        Me.ToolStripLabel7.Text = "Shift : "
        '
        'cboShift
        '
        Me.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShift.Name = "cboShift"
        Me.cboShift.Size = New System.Drawing.Size(75, 31)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 28)
        Me.ToolStripLabel1.Text = "Laporan : "
        '
        'cboLaporan
        '
        Me.cboLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLaporan.Items.AddRange(New Object() {"110111", "110112", "110113", "110114"})
        Me.cboLaporan.Name = "cboLaporan"
        Me.cboLaporan.Size = New System.Drawing.Size(150, 31)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'btRefresh
        '
        Me.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(28, 28)
        Me.btRefresh.Text = "Tampilkan Laporan"
        Me.btRefresh.ToolTipText = " [F5]-Tampilkan Laporan"
        '
        'RPT
        '
        Me.RPT.ActiveViewIndex = -1
        Me.RPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RPT.Cursor = System.Windows.Forms.Cursors.Default
        Me.RPT.DisplayStatusBar = False
        Me.RPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPT.Location = New System.Drawing.Point(0, 31)
        Me.RPT.Name = "RPT"
        Me.RPT.Size = New System.Drawing.Size(1086, 354)
        Me.RPT.TabIndex = 6
        Me.RPT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmPengeluaranBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 385)
        Me.Controls.Add(Me.RPT)
        Me.Controls.Add(Me.Toolbar)
        Me.Name = "FrmPengeluaranBarang"
        Me.Text = "FrmPengeluaranBarang"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboKodeUnit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboMesin As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboShift As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboLaporan As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents RPT As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
