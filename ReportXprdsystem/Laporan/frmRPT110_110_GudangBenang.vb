﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports ReportXprdsystem.HSP.Data

Public Class frmRPT110_110_GudangBenang

    Private WithEvents txtTanggal As New DateTimePicker

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTanggal))
        txtTanggal.Format = DateTimePickerFormat.Custom
        txtTanggal.CustomFormat = "dd/MM/yyyy"
        txtTanggal.Width = 95
        txtTanggal.Value = Now

        FillCombo()

        cboLaporan.SelectedIndex = 0

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)

        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.ComboBox.DataSource = DS.Tables("View")
        cboKodeUnit.ComboBox.DisplayMember = "Unit Produksi"
        cboKodeUnit.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "<SEMUA UNIT PRODUKSI>"

        'Grup Produksi
        Dim DaftarShiftProduksi As New DaftarShiftProduksi(ActiveSession)

        DS = DaftarShiftProduksi.Read("%")
        cboShift.ComboBox.DataSource = DS.Tables("View")
        cboShift.ComboBox.DisplayMember = "Nama Shift"
        cboShift.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Shift") = "<SEMUA>"

        cboKodeUnit.ComboBox.SelectedIndex = cboKodeUnit.Items.Count - 1
        cboShift.ComboBox.SelectedIndex = cboShift.Items.Count - 1

    End Sub

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
        Dim Server As New ConnectionInfo
        Dim DataTable As Table

        Me.Cursor = Cursors.WaitCursor
        '-----------------------------------------------------------------------------------------   

        '-----------------------------------------------------------------------------------------   
        Dim DBX As Object = New DBConnection(ActiveSession).ConnectionSetting()

        'Setting Koneksi Database
        With Server
            .ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=" + DBX.Server + "; PORT = " + DBX.Port.ToString + "; "
            .DatabaseName = DBX.Database
            .UserID = DBX.UserID
            .Password = DBX.Password
        End With
        '-----------------------------------------------------------------------------------------

        Dim RPTObject As New ReportDocument

        'Report
        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt110111_GudangBenang.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt110112_GudangBenang.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        'RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTanggal.Value.Date & " 07:00:00")
        'RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(DateAdd(DateInterval.Day, 1, txtTanggal.Value.Date) & " 06:59:59")
        RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTanggal.Value.Date)
        RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(txtTanggal.Value.Date)
        RPTObject.ParameterFields("Shift").CurrentValues.AddValue(cboShift.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodeUnit").CurrentValues.AddValue(cboKodeUnit.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + txtTanggal.Value.ToString("dd-MM-yyyy") + "'"

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub HideTabControl(ByVal RPT As Object)
        For Each control As Control In RPT.Controls
            If TypeOf control Is CrystalDecisions.Windows.Forms.PageView Then
                Dim tab As TabControl = DirectCast(DirectCast(control, CrystalDecisions.Windows.Forms.PageView).Controls(0), TabControl)
                tab.ItemSize = New Size(0, 1)
                tab.SizeMode = TabSizeMode.Fixed
                tab.Appearance = TabAppearance.Buttons
            End If
        Next
    End Sub

End Class
