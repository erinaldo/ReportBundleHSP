﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoringHasilProduksi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitoringHasilProduksi))
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboProduksi = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cboStatus = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCariData = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PopupMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.View = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btExcel = New System.Windows.Forms.ToolStripButton()
        Me.btAddCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.btEditCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.btDeleteCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.btRefreshCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Toolbar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.PopupMenu.SuspendLayout()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.BackColor = System.Drawing.SystemColors.Control
        Me.Toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btRefresh, Me.btExcel, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboProduksi, Me.ToolStripSeparator3, Me.ToolStripLabel3, Me.cboStatus, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.ToolStripSeparator4, Me.ToolStripLabel2, Me.txtCariData})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(992, 31)
        Me.Toolbar.TabIndex = 1
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 28)
        Me.ToolStripLabel1.Text = "&Produksi : "
        '
        'cboProduksi
        '
        Me.cboProduksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduksi.Name = "cboProduksi"
        Me.cboProduksi.Size = New System.Drawing.Size(200, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(48, 28)
        Me.ToolStripLabel3.Text = "&Status : "
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Items.AddRange(New Object() {"OPEN", "CLOSE", "<Seluruh Status>"})
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 31)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(68, 28)
        Me.ToolStripLabel4.Text = "Tgl. Mulai : "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(64, 28)
        Me.ToolStripLabel2.Text = "&Cari Data : "
        '
        'txtCariData
        '
        Me.txtCariData.AutoSize = False
        Me.txtCariData.BackColor = System.Drawing.Color.White
        Me.txtCariData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCariData.Name = "txtCariData"
        Me.txtCariData.Size = New System.Drawing.Size(200, 23)
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusBar.Location = New System.Drawing.Point(0, 441)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(992, 22)
        Me.StatusBar.TabIndex = 2
        Me.StatusBar.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(34, 17)
        Me.Status.Text = "Data "
        '
        'PopupMenu
        '
        Me.PopupMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btAddCTXM, Me.btEditCTXM, Me.btDeleteCTXM, Me.ToolStripMenuItem1, Me.btRefreshCTXM})
        Me.PopupMenu.Name = "ContextMenuStrip1"
        Me.PopupMenu.Size = New System.Drawing.Size(178, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'View
        '
        Me.View.AllowUserToAddRows = False
        Me.View.AllowUserToDeleteRows = False
        Me.View.AllowUserToOrderColumns = True
        Me.View.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.View.BackgroundColor = System.Drawing.Color.White
        Me.View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.View.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View.DefaultCellStyle = DataGridViewCellStyle2
        Me.View.Location = New System.Drawing.Point(0, 34)
        Me.View.MultiSelect = False
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.View.RowHeadersVisible = False
        Me.View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View.ShowEditingIcon = False
        Me.View.Size = New System.Drawing.Size(992, 404)
        Me.View.StandardTab = True
        Me.View.TabIndex = 0
        '
        'btRefresh
        '
        Me.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btRefresh.Image = CType(resources.GetObject("btRefresh.Image"), System.Drawing.Image)
        Me.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(28, 28)
        Me.btRefresh.Text = "Perbaharui Data "
        Me.btRefresh.ToolTipText = " [F5]-Perbaharui Data "
        '
        'btExcel
        '
        Me.btExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btExcel.Image = CType(resources.GetObject("btExcel.Image"), System.Drawing.Image)
        Me.btExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Size = New System.Drawing.Size(28, 28)
        Me.btExcel.Text = "Export"
        Me.btExcel.ToolTipText = "[F12]-Export Ke Excel"
        '
        'btAddCTXM
        '
        Me.btAddCTXM.Image = CType(resources.GetObject("btAddCTXM.Image"), System.Drawing.Image)
        Me.btAddCTXM.Name = "btAddCTXM"
        Me.btAddCTXM.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.btAddCTXM.Size = New System.Drawing.Size(177, 22)
        Me.btAddCTXM.Text = "Tambah Data"
        '
        'btEditCTXM
        '
        Me.btEditCTXM.Image = CType(resources.GetObject("btEditCTXM.Image"), System.Drawing.Image)
        Me.btEditCTXM.Name = "btEditCTXM"
        Me.btEditCTXM.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.btEditCTXM.Size = New System.Drawing.Size(177, 22)
        Me.btEditCTXM.Text = "Ubah data"
        Me.btEditCTXM.Visible = False
        '
        'btDeleteCTXM
        '
        Me.btDeleteCTXM.Image = CType(resources.GetObject("btDeleteCTXM.Image"), System.Drawing.Image)
        Me.btDeleteCTXM.Name = "btDeleteCTXM"
        Me.btDeleteCTXM.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.btDeleteCTXM.Size = New System.Drawing.Size(177, 22)
        Me.btDeleteCTXM.Text = "Hapus Data"
        Me.btDeleteCTXM.Visible = False
        '
        'btRefreshCTXM
        '
        Me.btRefreshCTXM.Image = CType(resources.GetObject("btRefreshCTXM.Image"), System.Drawing.Image)
        Me.btRefreshCTXM.Name = "btRefreshCTXM"
        Me.btRefreshCTXM.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.btRefreshCTXM.Size = New System.Drawing.Size(177, 22)
        Me.btRefreshCTXM.Text = "Perbaharui Data"
        '
        'frmMonitoringHasilProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 463)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Toolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMonitoringHasilProduksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Hasil Produksi (WO)"
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.PopupMenu.ResumeLayout(False)
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCariData As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PopupMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btAddCTXM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btEditCTXM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btDeleteCTXM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btRefreshCTXM As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents View As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboProduksi As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboStatus As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btExcel As System.Windows.Forms.ToolStripButton
End Class
