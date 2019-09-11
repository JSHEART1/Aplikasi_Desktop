Public Class Report
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using cn As New SqlClient.SqlConnection(strConnLocal3)
            Using cmd As New SqlClient.SqlCommand
                cmd.Connection = cn
                cn.Open()
                Try
                    cmd.CommandText =
                    "select a.TRNo,a.Lokasi,Materi,Pemateri,TglTraining, convert(varchar,Durasi)+' Menit' as Durasi,Jenis,Batch,Customer,Divisi,Month,TglPenerima,AWB,Status,Penerima, " &
                    "from monitoring a inner join Monitoring b on a.TRNo=b.TRNo " &
                    "where cast(floor(cast(TglTraining as float))as datetime) between '" & Format(Me.StartDate.Value, "yyyy/MM/dd") & "' and '" & Format(Me.EndDate.Value, "yyyy/MM/dd") & "' "
                    Dim ds As New DataSet
                    Dim da As New SqlClient.SqlDataAdapter(cmd)
                    da.Fill(ds, "hasil")
                    Me.DataGridView1.DataSource = ds.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class