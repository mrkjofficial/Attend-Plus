Imports MySql.Data.MySqlClient
Public Class DeleteStaffDetails
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Public Sub DeleteStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("delete from ams.staff where binary staff_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@userid", value:=ManageStaffDetails.ID)
            MySqlRead = MySqlComm.ExecuteReader
            MysqlConn.Close()
            Hide()
            ViewStaffDetails.Hide()
            ManageStaffDetails.ManageStaffDetails_Load(e, e)
            ManageStaffDetails.Show()
            ManageStaffDetails.ManageStaffDetailsStatusLabel.Text = "Staff record successfully deleted!"
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Hide()
    End Sub
End Class