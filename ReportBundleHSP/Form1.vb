﻿Public Class Form1

    Private Sub PengeluaranBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranBarangToolStripMenuItem.Click

        Dim ifrmChild As New FrmPengeluaranBarang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub TambahLokasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahLokasiToolStripMenuItem.Click
        'Dim ifrmChild As New FrmTambahLokasiUser
        'IsMdiContainer = True
        'ifrmChild.MdiParent = Me
        ''frmformDO.Dock = DockStyle.Fill
        'ifrmChild.Show()
    End Sub

    Private Sub PengeluaranBonSparepartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranBonSparepartToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7701_PengeluaranBarang
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub PenerimaanSparepartReturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanSparepartReturToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7702_PenerimaanBarangRetur
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub DistribusiSparepartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribusiSparepartToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7703_DistribusiSparePart
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub MutasiSparepartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MutasiSparepartToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7704_MutasiSparePart
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub BackOrderPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackOrderPenjualanToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_BackOrderPenjualanLombok
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub AgingBackOrderPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgingBackOrderPenjualanToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_BO001_BackOrderWAging
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub CancelationDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelationDateToolStripMenuItem.Click
        Dim ifrmChil As New FrmRpt_Cancelationdate_SO
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub BSVsAfvalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BSVsAfvalToolStripMenuItem.Click
        Dim ifrmChil As New FrmRpt_BSvsAfval
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub BackOrderPenjualanMakasarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackOrderPenjualanMakasarToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_BackOrderPenjualanMakasar
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub
End Class
