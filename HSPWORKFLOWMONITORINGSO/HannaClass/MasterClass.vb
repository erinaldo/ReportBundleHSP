﻿Imports Sap.Data.Hana
Imports HSPWORKFLOWMONITORINGSO.HSP.Data

Public Class MasterClass : Implements IDataLookup
    Public Function ReadSO(ByVal FromDate As Date, ByVal ToDate As Date, ByVal Status As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "Select " +
            " ""OJ_Nomor""           AS ""Nomor SO"",  " +
            " ""OJ_Tanggal""         AS ""Tanggal SO"",  " +
            " ""OJ_TglBatasKirim""   AS ""Tanggal Batas Kirim"",  " +
            " ""OJ_NamaCustomer""    AS ""Customer"",  " +
            " ""OJ_KodeItem""        AS ""Kode Item"",  " +
            " ""OJ_NamaItem""        AS ""Nama Item"",  " +
            " ""OJ_QtyOrder""        AS ""Qty Order"",  " +
            " ""OJ_QtyKirim""        AS ""Qty Kirim"",  " +
            " ""Sisa""               AS ""BackOrder""  " +
            " from HSP_WORKFLOW_SO " +
            " WHERE ""OJ_Tanggal"" between '" + FromDate.ToString("yyyy-MM-dd") + "' AND '" + ToDate.ToString("yyyy-MM-dd") + "' AND ""DocStatus"" = '" + Status + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadSO = DS
        End Using
    End Function
    Public Function ReadOP(ByVal NoReff As String, ByVal KodeItem As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "Select " +
            " ""OP_Nomor""           AS ""Nomor OP"",  " +
            " ""OP_TglOrder""        AS ""Tanggal Order OP"",  " +
            " ""OP_TglSelesai""      AS ""Tanggal Selesai"",  " +
            " ""OP_KodeItem""        AS ""Kode Item"",  " +
            " ""OP_NamaItem""        AS ""Nama Item"",  " +
            " ""OP_Qty""             AS ""Qty Request"",  " +
            " ""OP_QtyHasil""        AS ""Qty Hasil"",  " +
            " ""Sisa""               AS ""BackOrder""  " +
            " from HSP_WORKFLOW_OP " +
            " WHERE ""NoRef"" = '" + NoReff + "' and ""OP_KodeItem"" = '" + KodeItem + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadOP = DS
        End Using
    End Function
    Public Function ReadWO(ByVal NoReff As String, ByVal KodeItem As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "Select " +
            " ""NoSO""                          AS ""Nomor SO"",  " +
            " ""NoWO""                          AS ""Nomor WO"",  " +
            " ""TglWO""                         AS ""Tanggal WO"",  " +
            " ""OP_KodeItem""                   AS ""Kode Item"",  " +
            " ""OP_NamaItem""                   AS ""Nama Item"",  " +
            " ""QtyWO""                         AS ""Qty WO""  " +
            " from HSP_WORKFLOW_WO " +
            " WHERE ""NoSO"" = '" + NoReff + "' and ""OP_KodeItem"" = '" + KodeItem + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadWO = DS
        End Using
    End Function
    Public Function ReadStkProd(ByVal NoReff As String, ByVal KodeItem As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "Select " +
            " ""NoSO""                          AS ""Nomor SO"",  " +
            " ""OP_Nomor""                      AS ""Nomor OP"",  " +
            " ""NoWO""                          AS ""Nomor WO"",  " +
            " ""ItemCode""                      AS ""Kode Item"",  " +
            " ""ItemName""                      AS ""Nama Item"",  " +
            " ""WhsCode""                       AS ""Kode Warehouse"",  " +
            " ""WhsName""                       AS ""Nama Warehouse"",  " +
            " ""QtyReq""                        AS ""Qty Req Produksi"",  " +
            " ""OP_QtyHasil""                   AS ""Qty Hasil Produksi"",  " +
            " ""QtyWO""                         AS ""Qty WO"",  " +
            " ""QtyProduksi""                   AS ""Qty Stock Floor""  " +
            " from HSP_WORKFLOW_STK_PROD " +
            " WHERE ""NoSO"" = '" + NoReff + "' and ""ItemCode"" = '" + KodeItem + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStkProd = DS
        End Using
    End Function
    Public Function ReadStkWH(ByVal NoReff As String, ByVal KodeItem As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "Select " +
            " ""NoSO""                          AS ""Nomor SO"",  " +
            " ""OP_Nomor""                      AS ""Nomor OP"",  " +
            " ""NoWO""                          AS ""Nomor WO"",  " +
            " ""ItemCode""                      AS ""Kode Item"",  " +
            " ""ItemName""                      AS ""Nama Item"",  " +
            " ""WhsCode""                       AS ""Kode Warehouse"",  " +
            " ""WhsName""                       AS ""Nama Warehouse"",  " +
            " ""QtyReq""                        AS ""Qty Req Produksi"",  " +
            " ""OP_QtyHasil""                   AS ""Qty Hasil Produksi"",  " +
            " ""QtyWO""                         AS ""Qty WO"",  " +
            " ""QtyProduksi""                   AS ""Qty Stock Floor""  " +
            " from HSP_WORKFLOW_STK_WH " +
            " WHERE ""NoSO"" = '" + NoReff + "' and ""ItemCode"" = '" + KodeItem + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStkWH = DS
        End Using
    End Function

    Public Function ReadDeliv(ByVal NoReff As String, ByVal KodeItem As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "Select " +
            " ""INV_Nomor""                     AS ""Nomor INV"",  " +
            " ""OJ_Tanggal""                    AS ""Tanggal INV"",  " +
            " ""OJ_TglBatasKirim""              AS ""Tanggal Batas Kirim"",  " +
            " ""OJ_KodeItem""                   AS ""Kode Item"",  " +
            " ""OJ_NamaItem""                   AS ""Nama Item"",  " +
            " ""OJ_QtyKirim""                   AS ""Qty Kirim""  " +
            " from HSP_WORKFLOW_INV " +
            " WHERE ""OJ_Nomor"" = '" + NoReff + "' and ""OJ_KodeItem"" = '" + KodeItem + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadDeliv = DS
        End Using
    End Function
    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements HSP.Data.IDataLookup.GetLookup
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""WhsCode""        AS ""Kode"", " +
              "     ""WhsName""        AS ""Lokasi"" " +
              "FROM ""OWHS"" " +
              "WHERE ""WhsCode"" ||' '||""WhsName"" LIKE '%" + Parameter(0) + "%' and ""U_beas_lck"" = 'VSP'" +
              "ORDER BY ""WhsName"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "Lookup")

            GetLookup = DS
        End Using
    End Function
End Class
