Imports Npgsql
Public Class LoginForm
    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If txtpassword.Text = "Password" Or txtpassword.Text = "" Then
            txtpassword.ForeColor = Color.Silver
            txtpassword.Text = "Password"
            txtpassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtpassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtpassword.MouseClick
        If txtpassword.Text = "Password" Then
            txtpassword.Clear()
            txtpassword.ForeColor = Color.Black
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        If txtusername.Text = "Username" Or txtusername.Text = "" Then
            txtusername.ForeColor = Color.Silver
            txtusername.Text = "Username"
        Else
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtusername.MouseClick
        If txtusername.Text = "Username" Then
            txtusername.Clear()
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbclose_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub tbmaximize_Click(sender As Object, e As EventArgs) Handles tbmaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub tbminimize_Click(sender As Object, e As EventArgs) Handles tbminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tblogin_Click(sender As Object, e As EventArgs) Handles tblogin.Click
        Dim varuser, varpassword As String
        Dim queryselect As String
        Dim cmd As NpgsqlCommand
        Dim rd As NpgsqlDataReader

        koneksiDB()
        koneksinya.Close()

        varuser = txtusername.Text
        varpassword = txtpassword.Text
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varuser.Length > 0 And varpassword.Length > 0 And varuser IsNot "Username" And varpassword IsNot "Password") Then
            queryselect = "select * from login where username='" & varuser & "' and password='" & varpassword & "';"
            cmd = New NpgsqlCommand(queryselect, koneksinya)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Me.Hide()
                HomepageForm.Show()
                HomepageForm.lbusername.Text = rd!username
            Else
                MessageBox.Show(" Username atau Password salah")
            End If
        Else
            MessageBox.Show(" Silakan isi username dan password ")
        End If
        koneksinya.Close()
    End Sub

    Private Sub tbclose_Click_1(sender As Object, e As EventArgs) Handles tbclose.Click
        Me.Close()
    End Sub
    Sub refreshData()
        Dim queryselect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        queryselect = "select * from login;"
        cmd = New NpgsqlCommand(queryselect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
        Catch ex As Exception
            MessageBox.Show("Error !! Astaghfirullah :( " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub
    Private Sub tbsignup_Click(sender As Object, e As EventArgs) Handles tbsignup.Click
        Dim queryinsert As String
        Dim cmd As NpgsqlCommand
        Dim varuser, varpassword As String

        koneksiDB()
        koneksinya.Close()

        varuser = txtusername.Text
        varpassword = txtpassword.Text
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varuser = "Username" Or varpassword = "Password") Then
            MessageBox.Show("Silakan lengkapi Username atau Password")
        Else
            queryinsert = "insert into login values('" & varuser & "','" & varpassword & "');"
            cmd = New NpgsqlCommand(queryinsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Username berhasil didaftarkan")
            Catch ex As Exception
                MessageBox.Show("Username sudah terdaftar, mohon ketik ulang username yang lain")
            End Try
        End If
        koneksinya.Close()
        refreshData()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class
