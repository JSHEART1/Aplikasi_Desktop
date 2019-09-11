Public Class Monitoring
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.txtTRNo.Text = "" Then
            Me.DataGridView1.RowCount = Me.DataGridView1.RowCount + 1
            Me.DataGridView1.Item("Customer", Me.DataGridView1.RowCount - 1).Value = Me.txtCustomer.Text
            Me.DataGridView1.Item("Divisi", Me.DataGridView1.RowCount - 1).Value = Me.txtDivisi.Text
            Me.DataGridView1.Item("Month", Me.DataGridView1.RowCount - 1).Value = Me.txtMonth.Text
            Me.DataGridView1.Item("Penerima", Me.DataGridView1.RowCount - 1).Value = Me.txtPenerima.Text
            Me.DataGridView1.Item("AWB", Me.DataGridView1.RowCount - 1).Value = Me.txtAWB.Text
            Me.DataGridView1.Item("Status", Me.DataGridView1.RowCount - 1).Value = Me.txtStatus.Text
            Me.DataGridView1.Item("TglPenerima", Me.DataGridView1.RowCount - 1).Value = Me.dtpTglPenerima.Text
        Else
            Using cn As New SqlClient.SqlConnection(strConnLocal3)
                Using cmd As New SqlClient.SqlCommand
                    cmd.Connection = cn
                    cn.Open()
                    Try
                        cmd.CommandText =
                        "INSERT INTO Monitoring (TRNo,Customer, Divisi, Month, Penerima,AWB,Status,) VALUES (@TRNo,@Customer,@Divisi,@Month,@Penerima,@AWB,@Status,)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.Add(New SqlClient.SqlParameter("Customer", Me.txtCustomer.Text.Trim))
                        cmd.Parameters.Add(New SqlClient.SqlParameter("Divisi", Me.txtDivisi.Text))
                        cmd.Parameters.Add(New SqlClient.SqlParameter("Month", Me.txtMonth.Text))
                        cmd.Parameters.Add(New SqlClient.SqlParameter("Penerima", Me.txtPenerima.Text))
                        cmd.Parameters.Add(New SqlClient.SqlParameter("AWB", Me.txtAWB.Text))
                        cmd.Parameters.Add(New SqlClient.SqlParameter("Status", Me.txtStatus.Text.Trim))


                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End Using
            End Using
            G_Monitoring(Me.txtTRNo.Text.Trim, Me.DataGridView1)
        End If
    End Sub

    Private Sub Monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Monitoring_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        isiDivisi(Me.txtDivisi.Text)
    End Sub
    Public Sub isiDivisi(ByVal strNIK As String)
        Using cn As New SqlClient.SqlConnection(strConnLocal3)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                cmd.CommandText = "Select Customer,Jabatan from tbabsmst where NIK='" & strNIK & "' Order By Employeename Desc"

                Dim ds As New DataSet
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                Try
                    da.Fill(ds, "hasil")
                Catch ex As Exception
                End Try
            End Using
        End Using

        Using cn As New SqlClient.SqlConnection(strConnLocal3)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                cmd.CommandText = "Select Customer,Jabatan from tbabsmst where NIK='" & strNIK & "' Order By Employeename Desc"

                Dim ds1 As New DataSet
                Dim da1 As New SqlClient.SqlDataAdapter(cmd)
                Try
                    da1.Fill(ds1, "hasil")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub INSERTDATAMASTER()

        Me.txtTRNo.Text = G_MaxTRNo(G_KodeWH(Me.txtStatus.Text.Trim))

        Using cn As New SqlClient.SqlConnection(strConnLocal3)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                '1502030001'
                cmd.CommandText =
                    "INSERT INTO Monitoring (TRNo,Customer, Divisi, Month, Penerima,AWB,Status,TglPenerima) VALUES (@TRNo,@Customer,@Divisi,@Month,@Penerima,@AWB,@Status,@TglPenerima,)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlClient.SqlParameter("TRNo", Me.txtTRNo.Text))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Customer", Me.txtCustomer.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Divisi", Me.txtDivisi.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Month", Me.txtMonth.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Penerima", Me.txtPenerima.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("AWB", Me.txtAWB.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Status", Me.txtStatus.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("TglPenerima", Me.dtpTglPenerima.Value))

                Try
                    cmd.ExecuteNonQuery()

                    Dim dr As SqlClient.SqlDataReader
                    cmd.CommandText = "Select max(TransID) as TransID from tbATKPRMain"

                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        Me.txtTransID.Text = dr(0)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub INSERTDATADETAILS()

        Using cn As New SqlClient.SqlConnection(strConnLocal3)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                '1502030001'
                For i As Integer = 0 To Me.DataGridView1.RowCount - 1
                    With Me.DataGridView1
                        If IsDBNull(.Item("ID", i).Value) Or .Item("ID", i).Value = Nothing Then
                            cmd.CommandText =
                          "INSERT INTO Monitoring (TRNo,Customer, Divisi, Month, Penerima,AWB,Status,TglPenerima) VALUES (@TRNo,@Customer,@Divisi,@Month,@Penerima,@AWB,@Status,)"
                            cmd.Parameters.Clear()

                            cmd.Parameters.Add(New SqlClient.SqlParameter("TRNo", Me.txtTRNo.Text.Trim))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Customer", .Item("Customer", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Divisi", .Item("Divisi", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Month", .Item("Month", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Penerima", .Item("Penerima", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("AWB", .Item("AWB", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Status", .Item("Status", i).Value))
                        Else
                            cmd.CommandText =
                            "Update Monitoring set Customer=@Customer,Divisi=@Divisi,Month=@Month,Penerima=@Penerima,AWB=@AWB,Jenis=@Jenis,Status=@Status where TransID=@TransID"
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add(New SqlClient.SqlParameter("TransID", .Item("ID", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Customer", .Item("Customer", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Divisi", .Item("Divisi", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Month", .Item("Month", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Penerima", .Item("Penerima", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("AWB", .Item("AWB", i).Value))
                            cmd.Parameters.Add(New SqlClient.SqlParameter("Status", .Item("Status", i).Value))
                        End If
                        Try
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End With
                Next
            End Using
        End Using
    End Sub

    Private Sub UpdateDataMaster()
        Using cn As New SqlClient.SqlConnection(strConnLocal3)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                '1502030001'
                cmd.CommandText =
                    "Update Monitoring set Customer=@Customer,Divisi=@Divisi,Month=@Month,Penerima=@Penerima,AWB=@AWB,Status=@Status=@Status where TRNo=@TRNo "

                cmd.Parameters.Clear()
                cmd.Parameters.Add(New SqlClient.SqlParameter("TRNo", Me.txtTRNo.Text))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Customer", Me.txtCustomer.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Divisi", Me.txtDivisi.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Month", Me.txtMonth.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Penerima", Me.txtPenerima.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("AWB", Me.txtAWB.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("Status", Me.txtStatus.Text.Trim))
                cmd.Parameters.Add(New SqlClient.SqlParameter("AddWho", strUserID))

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        GridKosong()
        Me.txtTRNo.Text = ""
        Me.txtCustomer.Text = ""
        Me.txtDivisi.Text = ""
        Me.txtMonth.Text = ""
        Me.txtPenerima.Text = ""
        Me.txtAWB.Text = ""
        Me.txtStatus.Text = ""
    End Sub
    Private Sub GridKosong()
        Me.DataGridView1.RowCount = 0
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim strTRNo As String = ""
        Dim strTransID As Integer
        strTRNo = InputBox("No. TR : ", "Input No yang akan dicari", "")
        If strTRNo.Trim = "" Then
            Exit Sub
        Else
            strTransID = G_NoTR(strTRNo)
            If strTransID <> -2 Then
                Me.txtTRNo.Text = strTRNo
                Me.txtTransID.Text = strTransID
                IsiDataTR()
            End If
        End If
    End Sub

    Public Sub IsiDataTR()
        Dim ht As New Hashtable
        ht = G_Monitoring(Me.txtTransID.Text)

        If ht.Count > 0 Then

            Me.txtCustomer.Text = ht("Customer")
            Me.txtDivisi.Text = ht("Divisi")
            Me.txtMonth.Text = ht("Month")
            Me.txtPenerima.Text = ht("Penerima")
            Me.txtAWB.Text = ht("AWB")
            Me.txtStatus.Text = ht("Status")
            Me.dtpTglPenerima.Text = ht("TglPenerima")

        End If
        G_Monitoring(Me.txtTRNo.Text, Me.DataGridView1)

        Application.DoEvents()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Main_Menu.ReportToolStripMenuItem.PerformClick()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtTRNo.Text.Trim = "" Then
            'INSERTDATA
            INSERTDATAMASTER()
            INSERTDATADETAILS()
        Else
            INSERTDATADETAILS()
            UpdateDataMaster()
        End If

        'G_Monitoring(Me.txtTRNo.Text.Trim, Me.DataGridView1)
    End Sub
End Class