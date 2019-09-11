Imports System.Data
Imports System.Data.Sql
Module Module1
    Public strConnLocal1 As String = "Integrated Security=False;initial catalog=master;Data Source=.\sqlexpress;User ID=sahrul; Password=sahrul"
    Public strUserID As String
    Public Function G_MaxTRNo(ByVal strNamaSite As String) As String
        Dim hasil As String = ""
        Using cn As New SqlClient.SqlConnection(strConnLocal1)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                cmd.CommandText = "select isnull(max(right(TRNo,5)),0)+1 as MaxRefNo from Monitoring where substring(TRNo,5,4)='" & Format(Now.Date, "yyyy") & "' "

                Dim dr As SqlClient.SqlDataReader
                Try
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        hasil = strNamaSite & "." & Format(Now.Date, "yyyy") & "." & Microsoft.VisualBasic.Right(10000 + dr(0), 5)
                    End If
                Catch ex As Exception
                    hasil = ""
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
        Return hasil
    End Function
    Public Sub isiDivisi(ByRef combo As ComboBox)
        Using cn As New SqlClient.SqlConnection(strConnLocal1)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                cmd.CommandText = "Select TglTransaksi from tbATKPRMain Order By NamaSite Desc"

                Dim ds As New DataSet
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Try
                    da.Fill(ds, "hasil")
                    combo.DataSource = ds.Tables(0)
                    combo.DisplayMember = ds.Tables(0).Columns(0).ColumnName
                    combo.ValueMember = ds.Tables(0).Columns(0).ColumnName
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub
    'Public Sub isiNamaKaryawan(ByRef combo As ComboBox, ByVal strSite As String)
    '    Using cn As New SqlClient.SqlConnection(strConnLocal1)
    '        Using cmd As New SqlClient.SqlCommand
    '            cmd.Connection = cn
    '            cn.Open()
    '            cmd.CommandText = "Select Customer,Divisi from tbabsmst where Location='" & strSite & "' Order By Employeename Desc"

    '            Dim ds As New DataSet
    '            Dim da As New SqlClient.SqlDataAdapter(cmd)
    '            Try
    '                da.Fill(ds, "hasil")
    '                combo.DataSource = ds.Tables(0)
    '                combo.DisplayMember = ds.Tables(0).Columns(0).ColumnName
    '                combo.ValueMember = ds.Tables(0).Columns(0).ColumnName
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        End Using
    '    End Using
    'End Sub
    Public Sub G_Monitoring(ByVal strTRNo As String, ByRef dgv As DataGridView)
        Dim ds As New DataSet
        Using cn As New SqlClient.SqlConnection(strConnLocal1)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                '1502030001'
                cmd.CommandText =
                    "Select TransID,Customer,Divisi,Month,TglPenerima,AWB,Status,Penerima from Monitoring where TRNo='" & strTRNo & "' "
                cmd.Parameters.Clear()

                Try
                    Dim da As New SqlClient.SqlDataAdapter(cmd)
                    da.Fill(ds, "hasil")
                    dgv.RowCount = 0
                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        dgv.RowCount = dgv.RowCount + 1
                        dgv.Item("ID", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("TransID")
                        'dgv.Item("TRNo", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("TRNo")
                        dgv.Item("Customer", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("Customer")
                        dgv.Item("Divisi", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("Divisi")
                        dgv.Item("Month", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("Month")
                        dgv.Item("TglPenerima", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("TglPenerima")
                        dgv.Item("AWB", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("AWB")
                        dgv.Item("Status", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("Status")
                        dgv.Item("Penerima", dgv.RowCount - 1).Value = ds.Tables(0).Rows(i)("Penerima")
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

    End Sub
    Public Function G_KodeWH(ByVal strNamaSite As String) As String
        Dim hasil As String = ""

        Using cn As New SqlClient.SqlConnection(strConnLocal1)
            Using cmd As New SqlClient.SqlCommand("select KodeSite from [tbDORSite] where NamaSite=@NamaSite", cn)
                cn.Open()
                cmd.Parameters.Add(New SqlClient.SqlParameter("NamaSite", strNamaSite))

                Dim dr As SqlClient.SqlDataReader
                Try
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        hasil = dr(0)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    hasil = ""
                End Try
            End Using
        End Using
        Return hasil
    End Function
    Public Function G_Monitoring(ByVal intNoTR As Integer) As Hashtable
        Dim ht As New Hashtable
        Using cn As New SqlClient.SqlConnection(strConnLocal1)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                '1502030001'
                cmd.CommandText =
                    "Select * from Monitoring where TransID= " & intNoTR
                cmd.Parameters.Clear()

                Try
                    Dim dr As SqlClient.SqlDataReader
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        ht.Clear()
                        ht.Add("TRNo", dr!TRNo)
                        ht.Add("Customer", dr!Customer)
                        ht.Add("Divisi", dr!Divisi)
                        ht.Add("Month", dr!Month)
                        ht.Add("TglPenerima", dr!TglPenerima)
                        ht.Add("Jenis", dr!Durasi)
                        ht.Add("Status", dr!Jenis)
                        ht.Add("TglPenerima", dr!TglPenerima)
                    End If
                Catch ex As Exception
                    ht.Clear()
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
        Return ht
    End Function
    Public Function G_NoTR(ByVal strNoTR As String) As Integer
        Dim hasil As New Integer
        Using cn As New SqlClient.SqlConnection(strConnLocal1)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                '1502030001'
                cmd.CommandText =
                    "Select TransID From Monitoring Where TRNo = @TRNo"

                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlClient.SqlParameter("TRNo", strNoTR))

                Try
                    Dim dr As SqlClient.SqlDataReader
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        hasil = dr(0)
                    End If
                Catch ex As Exception
                    hasil = -1
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
        Return hasil
    End Function
End Module
