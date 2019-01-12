Imports MySql.Data.MySqlClient
Public Class RestoreDefaults
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        MysqlConn.Open()
        MySqlComm = New MySqlCommand("update ams.staff set first_name = @firstname,middle_name = @middlename,last_name = @lastname,dob = @birthdate,gender = @gender,email_id = @emailid,mobile_no = @mobileno,address = @address,zip_code = @zipcode,city = @city,province = @province,country = @country,security_question = @securityquestion,security_answer = @securityanswer,profile_picture = @profilepicture where binary staff_id = @userid", MysqlConn)
        MySqlComm.Parameters.AddWithValue("@firstname", value:="Admin")
        MySqlComm.Parameters.AddWithValue("@middlename", value:=Nothing)
        MySqlComm.Parameters.AddWithValue("@lastname", value:="Attend+")
        MySqlComm.Parameters.AddWithValue("@birthdate", value:="2000-01-01")
        MySqlComm.Parameters.AddWithValue("@gender", value:="Male")
        MySqlComm.Parameters.AddWithValue("@emailid", value:="admin@attend.com")
        MySqlComm.Parameters.AddWithValue("@mobileno", value:=Val("0000000000"))
        MySqlComm.Parameters.AddWithValue("@address", value:="Siliguri Institute of Technology")
        MySqlComm.Parameters.AddWithValue("@zipcode", value:=Val("734009"))
        MySqlComm.Parameters.AddWithValue("@city", value:="Siliguri")
        MySqlComm.Parameters.AddWithValue("@province", value:="West Bengal")
        MySqlComm.Parameters.AddWithValue("@country", value:="India")
        MySqlComm.Parameters.AddWithValue("@securityquestion", value:=Nothing)
        MySqlComm.Parameters.AddWithValue("@securityanswer", value:=Nothing)
        MySqlComm.Parameters.AddWithValue("@profilepicture", value:=Nothing)
        MySqlComm.Parameters.AddWithValue("@userid", value:="1")
        MySqlRead = MySqlComm.ExecuteReader
        MysqlConn.Close()
        MysqlConn.Dispose()
        MysqlConn.Open()
        MySqlComm = New MySqlCommand("delete from ams.attendence", MysqlConn)
        MySqlRead = MySqlComm.ExecuteReader
        MysqlConn.Close()
        MysqlConn.Dispose()
        MysqlConn.Open()
        MySqlComm = New MySqlCommand("delete from ams.student", MysqlConn)
        MySqlRead = MySqlComm.ExecuteReader
        MysqlConn.Close()
        MysqlConn.Dispose()
        MysqlConn.Open()
        MySqlComm = New MySqlCommand("delete from ams.staff where staff_id != @userid", MysqlConn)
        MySqlComm.Parameters.AddWithValue("@userid", value:="1")
        MySqlRead = MySqlComm.ExecuteReader
        MysqlConn.Close()
        MysqlConn.Dispose()
        Hide()
        Application.Restart()
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Hide()
    End Sub
End Class