﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaftarKPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDaftarKPI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.btAdd = New System.Windows.Forms.ToolStripButton()
        Me.btEdit = New System.Windows.Forms.ToolStripButton()
        Me.btRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cboBulan = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboTahun = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KodeUnit = New System.Windows.Forms.ToolStripLabel()
        Me.cboDept = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboBagian = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCariData = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PopupMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btAddCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.btEditCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.btDeleteCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btRefreshCTXM = New System.Windows.Forms.ToolStripMenuItem()
        Me.View = New Enerzie.EPSGridControls.EPSDataGridView()
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
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btAdd, Me.btEdit, Me.btRefresh, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.cboBulan, Me.ToolStripLabel1, Me.cboTahun, Me.ToolStripSeparator3, Me.KodeUnit, Me.cboDept, Me.ToolStripSeparator4, Me.ToolStripLabel3, Me.cboBagian, Me.ToolStripSeparator5, Me.ToolStripLabel2, Me.txtCariData})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(1090, 31)
        Me.Toolbar.TabIndex = 0
        Me.Toolbar.TabStop = True
        Me.Toolbar.Text = "ToolStrip1"
        '
        'btAdd
        '
        Me.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btAdd.Image = CType(resources.GetObject("btAdd.Image"), System.Drawing.Image)
        Me.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(28, 28)
        Me.btAdd.Text = " [F6]-Tambah Data "
        '
        'btEdit
        '
        Me.btEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btEdit.Image = CType(resources.GetObject("btEdit.Image"), System.Drawing.Image)
        Me.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(28, 28)
        Me.btEdit.Text = " [F7]-Ubah Data "
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(56, 28)
        Me.ToolStripLabel4.Text = "&Periode : "
        '
        'cboBulan
        '
        Me.cboBulan.Name = "cboBulan"
        Me.cboBulan.Size = New System.Drawing.Size(100, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(12, 28)
        Me.ToolStripLabel1.Text = "-"
        '
        'cboTahun
        '
        Me.cboTahun.Name = "cboTahun"
        Me.cboTahun.Size = New System.Drawing.Size(75, 31)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'KodeUnit
        '
        Me.KodeUnit.Name = "KodeUnit"
        Me.KodeUnit.Size = New System.Drawing.Size(81, 28)
        Me.KodeUnit.Text = "Departemen : "
        '
        'cboDept
        '
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(150, 31)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(52, 28)
        Me.ToolStripLabel3.Text = "Bagian : "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'cboBagian
        '
        Me.cboBagian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBagian.Name = "cboBagian"
        Me.cboBagian.Size = New System.Drawing.Size(150, 31)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
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
        Me.txtCariData.Size = New System.Drawing.Size(150, 23)
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusBar.Location = New System.Drawing.Point(0, 441)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1090, 22)
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
        '
        'btDeleteCTXM
        '
        Me.btDeleteCTXM.Image = CType(resources.GetObject("btDeleteCTXM.Image"), System.Drawing.Image)
        Me.btDeleteCTXM.Name = "btDeleteCTXM"
        Me.btDeleteCTXM.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.btDeleteCTXM.Size = New System.Drawing.Size(177, 22)
        Me.btDeleteCTXM.Text = "Hapus Data"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'btRefreshCTXM
        '
        Me.btRefreshCTXM.Image = CType(resources.GetObject("btRefreshCTXM.Image"), System.Drawing.Image)
        Me.btRefreshCTXM.Name = "btRefreshCTXM"
        Me.btRefreshCTXM.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.btRefreshCTXM.Size = New System.Drawing.Size(177, 22)
        Me.btRefreshCTXM.Text = "Perbaharui Data"
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
        Me.View.Size = New System.Drawing.Size(1090, 404)
        Me.View.StandardTab = True
        Me.View.TabIndex = 1
        '
        'frmDaftarKPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 463)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Toolbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmDaftarKPI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar KPI"
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
    Friend WithEvents btAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btEdit As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KodeUnit As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboBagian As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboDept As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboBulan As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboTahun As System.Windows.Forms.ToolStripComboBox
End Class
