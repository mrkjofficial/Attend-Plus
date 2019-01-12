Imports MySql.Data.MySqlClient
Public Class DeleteStudentDetails
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Public Sub DeleteStudentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("delete from ams.student where binary student_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@userid", value:=ManageStudentDetails.ID)
            MySqlRead = MySqlComm.ExecuteReader
            MysqlConn.Close()
            Hide()
            ViewStudentDetails.Hide()
            ManageStudentDetails.ManageStudentDetails_Load(e, e)
            ManageStudentDetails.Show()
            ManageStudentDetails.ManageStudentDetailsStatusLabel.Text = "Student record successfully deleted!"
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