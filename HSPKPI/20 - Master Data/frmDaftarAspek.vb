﻿Imports HSPKPI.HSP.Data

Public Class frmDaftarAspek

    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        ComboPosisi()

        'Isi Data Bagian
        Dim DaftarBagian As New DaftarHRBagian()
        DS = New DataSet
        DS = DaftarBagian.Read("%")
        cboBagian.ComboBox.DataSource = DS.Tables("View")
        cboBagian.ComboBox.DisplayMember = "Nama Bagian"
        cboBagian.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Bagian") = "<SEMUA BAGIAN>"

        cboBagian.ComboBox.SelectedValue = ""

        'Isi Data Kelompok
        Dim DaftarKelompok As New DaftarKelompok(ActiveSession)
        DS = New DataSet
        DS = DaftarKelompok.Read("%")
        cboKelompok.ComboBox.DataSource = DS.Tables("View")
        cboKelompok.ComboBox.DisplayMember = "Kelompok"
        cboKelompok.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Kelompok") = "<SEMUA KELOMPOK>"

        cboKelompok.ComboBox.SelectedValue = ""
    End Sub

    Private Sub ComboPosisi()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Isi Data Posisi
        Dim DaftarPosisi As New DaftarHRPosisi()
        DS = New DataSet
        DS = DaftarPosisi.Read("%", cboBagian.ComboBox.SelectedValue)
        cboPosisi.ComboBox.DataSource = DS.Tables("View")
        cboPosisi.ComboBox.DisplayMember = "Nama Posisi"
        cboPosisi.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Posisi") = "<SEMUA POSISI>"

        cboPosisi.ComboBox.SelectedValue = ""

    End Sub

    'Form Load
    Private Sub frmDaftarAspek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        FillCombo()
    End Sub

    'Cek Jika Ditekan Enter Pada Saat Pengisian Kriteria            
    Private Sub PressEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCariData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Execute("btRefresh")
        End If
    End Sub

    'Form Show
    Private Sub frmDaftarAspek_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        View.SettingID = Me.Name

        SetHeaderView(View)

        ShowData()
        View.SetColumnOrder()
    End Sub

    'Form Closing
    Private Sub frmDaftarAspek_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        View.SaveColumnOrder()
    End Sub

    ' Tampilkan Data Sesuai Kriteria
    Private Sub ShowData(Optional ByVal ID As String = "")

        Toolbar.Items(0).Enabled = False
        Toolbar.Items(1).Enabled = False
        Toolbar.Items(2).Enabled = False
        Toolbar.Items(3).Enabled = False

        Me.Cursor = Cursors.WaitCursor
        View.SuspendLayout()

        'Baca Data
        Dim DaftarAspek As New DaftarAspek(ActiveSession)
        Dim BS As New BindingSource
        Dim DataSet As DataSet = DaftarAspek.ReadHeader(txtCariData.Text, cboBagian.ComboBox.SelectedValue.ToString, cboKelompok.ComboBox.SelectedValue.ToString, cboPosisi.ComboBox.SelectedValue.ToString)

        BS.DataSource = DataSet
        BS.DataMember = "View"

        View.RowTemplate.Height = 16
        View.DataSource = BS

        'Format Kolom
        Dim Column As DataColumn
        For Each Column In DataSet.Tables("View").Columns
            If Column.DataType.Name.ToUpper = "DATETIME" Then
                View.Columns(Column.ColumnName).DefaultCellStyle.Format = "dd/MM/yyyy"
                View.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                View.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            If Column.DataType.Name.ToUpper = "DOUBLE" Then
                View.Columns(Column.ColumnName).DefaultCellStyle.Format = "#,##0.00"
                View.Columns(Column.ColumnName).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                View.Columns(Column.ColumnName).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        'Set Posisi Baris Aktif
        If ID <> "" Then
            BS.Position = BS.Find("Kode", ID)
        End If

        'Tampilkan Jumlah Baris
        Status.Text = "Total : " + View.RowCount.ToString + " Baris"

        'Enable/Disable Menu
        If View.RowCount = 0 Then
            Toolbar.Items(1).Enabled = False
            Toolbar.Items(2).Enabled = False
            PopupMenu.Items(1).Enabled = False
            PopupMenu.Items(2).Enabled = False

            If txtCariData.Focused Then
                txtCariData.SelectAll()
            End If
        Else
            Toolbar.Items(1).Enabled = True
            Toolbar.Items(2).Enabled = True
            PopupMenu.Items(1).Enabled = True
            PopupMenu.Items(2).Enabled = True
        End If

        Toolbar.Items(0).Enabled = True
        Toolbar.Items(3).Enabled = True

        Me.Cursor = Cursors.Default
        View.ResumeLayout()

    End Sub

    'Jika Kriteria Selesai Diisikan            
    Private Sub txtCariData_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCariData.Enter
        txtCariData.SelectAll()
    End Sub

    'Jika Toolbar Di Click
    Private Sub Toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked, PopupMenu.ItemClicked
        Execute(e.ClickedItem.Name)
    End Sub

    'Tampilkan Popupmenu Jika Klik Kanan
    Private Sub View_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles View.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim P As Point = New Point(e.X, e.Y)
            PopupMenu.Show(View, P)
        End If
    End Sub

    'Jika Ditekan DoubleClick
    Private Sub View_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles View.DoubleClick
        If View.RowCount > 0 Then
            Execute("btEdit")
        End If
    End Sub

    'Jika Ditekan Tombol Tertentu
    Private Sub frmDaftarAspek_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                '---------------------------------------------------------------------------------------------------------
                Execute("btRefresh")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F6, Keys.Insert
                '---------------------------------------------------------------------------------------------------------
                Execute("btAdd")
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F7
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    Execute("btEdit")
                End If
                '---------------------------------------------------------------------------------------------------------
            Case Keys.F8, Keys.Delete
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    Execute("btDelete")
                End If
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Jika Area View Ditekan Tombol Tertentu
    Private Sub View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles View.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                '---------------------------------------------------------------------------------------------------------
                If View.RowCount > 0 Then
                    e.Handled = True
                    Execute("btEdit")
                End If
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    'Eksekusi Menu
    Private Sub Execute(ByVal ID As String)

        Dim DataKey As String = If(View.Rows.Count = 0, "", View(0, View.CurrentCell.RowIndex).Value.ToString())
        Dim GroupKey As String = cboBagian.ComboBox.SelectedValue
        'Dim Groupkey1 As String = cboKelompok.ComboBox.SelectedValue
        Dim GroupKey2 As String = cboKelompok.ComboBox.SelectedValue
        PopupMenu.Hide()

        Select Case ID
            Case "btAdd", "btAddCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim formAdd As New frmAspek("", GroupKey, GroupKey2) 'Groupkey1,

                formAdd.ShowDialog()

                If formAdd.IDData <> "" Then
                    ShowData(formAdd.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btEdit", "btEditCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim FormEdit As New frmAspek(DataKey, GroupKey, GroupKey2) ', Groupkey1
                FormEdit.ShowDialog()

                If FormEdit.IDData <> "" Then
                    ShowData(FormEdit.IDData)
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btDelete", "btDeleteCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim DaftarAspek As New DaftarAspek(ActiveSession)

                If DaftarAspek.Locked(View(0, View.CurrentCell.RowIndex).Value) Then
                    MessageBox.Show("Data Ini Telah Digunakan Data Lain, Hapus Tidak Dapat Dilakukan ! ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    SendKeys.Send("{RIGHT}")
                    If MessageBox.Show("Hapus Data Baris Ini ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        DaftarAspek.DeleteHeader(View(0, View.CurrentCell.RowIndex).Value)
                        View.Rows.RemoveAt(View.CurrentCell.RowIndex)

                        If View.RowCount = 0 Then
                            ShowData()
                        Else
                            If View.CurrentCell.RowIndex > 1 Then
                                SendKeys.Send("{UP}+{DOWN}")
                            End If
                            Status.Text = "Total : " + View.RowCount.ToString + " Baris"
                        End If
                    End If
                End If
                '---------------------------------------------------------------------------------------------------------

            Case "btRefresh", "btRefreshCTXM"

                '---------------------------------------------------------------------------------------------------------
                ShowData()
                If View.RowCount > 0 Then
                    View.Focus()
                End If
                '---------------------------------------------------------------------------------------------------------
            Case "btCopy", "btCopyCTXM"

                '---------------------------------------------------------------------------------------------------------
                Dim formAdd As New frmCopyAspek

                formAdd.ShowDialog()
                '---------------------------------------------------------------------------------------------------------
        End Select
    End Sub

    Private Sub cboBagian_KeyUp(sender As Object, e As KeyEventArgs) Handles cboBagian.KeyUp
        ComboPosisi()
    End Sub

    Private Sub cboBagian_LostFocus(sender As Object, e As EventArgs) Handles cboBagian.LostFocus
        ComboPosisi()
    End Sub
End Class