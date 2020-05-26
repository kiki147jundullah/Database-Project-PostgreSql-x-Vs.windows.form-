Imports Npgsql
Imports CrystalDecisions.CrystalReports.Engine
Public Class HomepageForm
    Dim kodebuku, kodedistributor, kodecabang, kodepegawai, kodemember, kodetransaksi, kodeinvestor As String
    Dim cmd As NpgsqlCommand
    Dim reader As NpgsqlDataReader

    Private Sub tbclose_Click(sender As Object, e As EventArgs) Handles tbclose.Click
        Me.Close()
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

    Private Sub tbdatautama_Click(sender As Object, e As EventArgs) Handles tbdatautama.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub tblaporan_Click(sender As Object, e As EventArgs) Handles tblaporan.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub

    Private Sub tbinformasi_Click(sender As Object, e As EventArgs) Handles tbinformasi.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = True
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = True
    End Sub

    Private Sub tblogout_Click(sender As Object, e As EventArgs) Handles tblogout.Click
        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = True
        lbdashboard.Visible = False

        Dim pilihan = MessageBox.Show(" Anda akan ingin keluar dari aplikasi ini ? ", "WARNING !!!", MessageBoxButtons.YesNo)
        If pilihan = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
            LoginForm.txtusername.Text = "Username"
            LoginForm.txtusername.ForeColor = Color.Silver
            LoginForm.txtpassword.Text = "Password"
            LoginForm.txtpassword.ForeColor = Color.Silver
            LoginForm.txtpassword.PasswordChar = ""
        End If
    End Sub

    Private Sub tbdashboard_Click(sender As Object, e As EventArgs) Handles tbdashboard.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = True

        pnldashboard.Visible = True
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub btMember_Click(sender As Object, e As EventArgs) Handles btMember.Click

        pnlmember.Visible = True
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshData()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodemember = "select kodemember from member;"
        cmd = New NpgsqlCommand(kodemember, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sMember = reader("kodemember")
            ComboBox3.Items.Add(sMember)
        End While
    End Sub
    Sub refreshData()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from member;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgMember.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCari_Click(sender As Object, e As EventArgs) Handles btCari.Click
        'menampilkan data Member sesuai dg yg dimasukkan di kolom text Member
        Dim queryselect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varKodeMember As String

        koneksiDB()
        koneksinya.Close()

        varKodeMember = ComboBox3.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeMember.Length > 0) Then
            queryselect = "select * from member where kodemember='" & varKodeMember & "';"
            cmd = New NpgsqlCommand(queryselect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgMember.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi kode Member yang ingin dicari! ")
        End If
        koneksinya.Close()
    End Sub

    Private Sub btTambah0_Click(sender As Object, e As EventArgs) Handles btTambah0.Click
        Dim queryinsert As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varNamaDepan, varNamaBelakang, varKodeMember As String
        Dim varTanggal As DateTime

        koneksiDB()
        koneksinya.Close()

        varNamaDepan = txtNamaDepan.Text
        varNamaBelakang = txtNamaBelakang.Text
        varKodeMember = ComboBox3.SelectedItem.ToString
        varTanggal = "Data Tanggal Member Belum Diinput"
        'Menambahkan data Member

        varTanggal = DateTimeMember1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varTanggal.ToBinary > 0 And varNamaDepan.Length > 0 And varNamaBelakang.Length > 0 And varKodeMember.Length > 0) Then
            queryinsert = "insert into member values('" & ComboBox3.SelectedItem.ToString & "','" & txtNamaDepan.Text & "','" & txtNamaBelakang.Text & "','" & varTanggal & "');"
            cmd = New NpgsqlCommand(queryinsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah berhasil ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan lengkapi datanya!")
        End If
        koneksinya.Close()
        refreshData()
    End Sub

    Private Sub BtUbah_Click(sender As Object, e As EventArgs) Handles btUbah.Click
        Dim queryUpdate As String
        Dim cmd As NpgsqlCommand
        Dim varNamaDepan, varNamaBelakang, varKodeMember As String
        Dim varTanggal As DateTime
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varTanggal = "Tanggal Member Belum Diinput"
        varNamaDepan = txtNamaDepan.Text
        varNamaBelakang = txtNamaBelakang.Text
        varKodeMember = ComboBox3.SelectedItem.ToString
        'Mengubah data Member

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varTanggal.ToBinary > 0 And varNamaDepan.Length > 0 And varNamaBelakang.Length > 0 And varKodeMember.Length > 0) Then
            queryUpdate = "update Member set NamaDepan='" & varNamaDepan & "', 	NamaBelakang ='" & varNamaBelakang & "', Tanggal='" & varTanggal & "' where KodeMember ='" & varKodeMember & "';"
            cmd = New NpgsqlCommand(queryUpdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris udah berhasil diubah")
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan lengkapi datanya ! ")
        End If
        koneksinya.Close()
        refreshData()
    End Sub

    Private Sub BtHapus_Click(sender As Object, e As EventArgs) Handles btHapus.Click
        Dim queryDelete As String
        Dim cmd As NpgsqlCommand
        Dim varKodeMember As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeMember = ComboBox3.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeMember.Length > 0) Then
            'Menghapus data Member
            queryDelete = "delete from Member where KodeMember ='" & varKodeMember & "';"
            cmd = New NpgsqlCommand(queryDelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris udah berhasil dihapus")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi kode KodeMember yang akan dihapus!")
        End If
        koneksinya.Close()
        refreshData()
    End Sub

    Private Sub btDistributor_Click(sender As Object, e As EventArgs) Handles btDistributor.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = True
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataDistributor()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodedistributor = "select kodedistributor from pengadaan;"
        cmd = New NpgsqlCommand(kodedistributor, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sD = reader("kodedistributor")
            cmbdKode.Items.Add(sD)
        End While
    End Sub
    Sub refreshDataDistributor()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from distributor;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgDistributor.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariDistributor_Click(sender As Object, e As EventArgs) Handles btCariDistributor.Click
        'menampilkan data distributor sesuai dengan yang dimasukkan di kolom kode distributor
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varKodeDistributor As String

        koneksiDB()
        koneksinya.Close()

        varKodeDistributor = cmbdKode.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeDistributor.Length > 0) Then
            querySelect = "select * from distributor where kodedistributor='" & varKodeDistributor & "';"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgDistributor.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan isi kode distributor yang ingin dicari!")
        End If
    End Sub

    Private Sub btTambahDistributor_Click(sender As Object, e As EventArgs) Handles btTambahDistributor.Click
        Dim queryInsert As String
        Dim cmd As NpgsqlCommand
        Dim varAlamat, varKota, varNoTelepon, varKodeDistributor, varNamaDistributor As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varAlamat = txtAlamatDistributor.Text
        varKota = txtKotaDistributor.Text
        varNoTelepon = txtNoTeleponDistributor.Text
        varKodeDistributor = cmbdKode.SelectedItem.ToString
        varNamaDistributor = txtNamaDistributor.Text
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varAlamat.Length > 0 And varKota.Length > 0 And varNoTelepon.Length > 0 And varKodeDistributor.Length > 0 And varNamaDistributor.Length > 0) Then
            'menambahkan data distributor
            queryInsert = "insert into distributor values ('" & varKodeDistributor & "','" & varNamaDistributor & "','" & varAlamat & "','" & varKota & "','" & varNoTelepon & "');"
            cmd = New NpgsqlCommand(queryInsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah berhasil ditambahkan.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataDistributor()
        Else
            MessageBox.Show("Silakan lengkapi data")
        End If
    End Sub


    Private Sub btUbahDistributor_Click(sender As Object, e As EventArgs) Handles btUbahDistributor.Click
        Dim queryUpdate As String
        Dim cmd As NpgsqlCommand
        Dim varAlamat, varKota, varNoTelepon, varKodeDistributor, varNamaDistributor As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varAlamat = txtAlamatDistributor.Text
        varKota = txtKotaDistributor.Text
        varNoTelepon = txtNoTeleponDistributor.Text
        varKodeDistributor = cmbdKode.SelectedItem.ToString
        varNamaDistributor = txtNamaDistributor.Text
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varAlamat.Length > 0 And varKota.Length > 0 And varNoTelepon.Length > 0 And varKodeDistributor.Length > 0 And varNamaDistributor.Length > 0) Then
            'mengubah data distributor
            queryUpdate = "update distributor set Namadistributor='" & varNamaDistributor & "', alamat_dstrbtr='" & varAlamat & "', kota_dstrbtr='" & varKota & "', telp_dstrbtr='" & varNoTelepon & "' where kodedistributor='" & varKodeDistributor & "';"
            cmd = New NpgsqlCommand(queryUpdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil mengubah " & rowAffected & " baris.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataDistributor()
        Else
            MessageBox.Show("Silakan lengkapi data")
        End If
    End Sub

    Private Sub btHapusDistributor_Click(sender As Object, e As EventArgs) Handles btHapusDistributor.Click
        Dim queryDelete As String
        Dim cmd As NpgsqlCommand
        Dim varKodeDistributor As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeDistributor = cmbdKode.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeDistributor.Length > 0) Then
            'menghapus data distributor
            queryDelete = "delete from distributor where kodedistributor='" & varKodeDistributor & "';"
            cmd = New NpgsqlCommand(queryDelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil menghapus " & rowAffected & " baris.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataDistributor()
        Else
            MessageBox.Show("Silakan isi kode distributor yang akan dihapus!")
        End If
    End Sub

    Private Sub btInvestor_Click(sender As Object, e As EventArgs) Handles btInvestor.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = True
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataInvestor()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodecabang = "select kodecabang from cabang;"
        cmd = New NpgsqlCommand(kodecabang, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sCabang = reader("kodecabang")
            cmbiCab.Items.Add(sCabang)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodeinvestor = "select kodeinvestor from investor;"
        cmd = New NpgsqlCommand(kodeinvestor, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sI = reader("kodeinvestor")
            cmbiInvest.Items.Add(sI)
        End While
        koneksinya.Close()
    End Sub
    Sub refreshDataInvestor()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from investor;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dginvestor.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariInvestor_Click(sender As Object, e As EventArgs) Handles btCariInvestor.Click
        'menampilkan data distributor sesuai dengan yang dimasukkan di kolom kode distributor
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varKodeinvestor As String

        koneksiDB()
        koneksinya.Close()

        varKodeinvestor = cmbiInvest.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeinvestor.Length > 0) Then
            querySelect = "select * from investor where kodeinvestor='" & varKodeinvestor & "';"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dginvestor.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan isi kode investor yang ingin dicari!")
        End If
    End Sub

    Private Sub btTambahInvestor_Click(sender As Object, e As EventArgs) Handles btTambahInvestor.Click
        Dim queryInsert As String
        Dim cmd As NpgsqlCommand
        Dim varAlamat, varNama, varInvestasi, varKodeInvestor, varKodeCabang As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varAlamat = txtalamatinvestor.Text
        varNama = txtNamaInvestor.Text
        varInvestasi = txtinvestasi.Text
        varKodeInvestor = cmbiInvest.SelectedItem.ToString
        varKodeCabang = cmbiCab.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varAlamat.Length > 0 And varNama.Length > 0 And varInvestasi.Length > 0 And varKodeInvestor.Length > 0 And varKodeCabang.Length > 0) Then
            'menambahkan data distributor
            queryInsert = "insert into investor values ('" & varKodeInvestor & "','" & varNama & "','" & varInvestasi & "','" & varAlamat & "','" & varKodeCabang & "');"
            cmd = New NpgsqlCommand(queryInsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah berhasil ditambahkan.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataInvestor()
        Else
            MessageBox.Show("Silakan lengkapi data")
        End If
    End Sub


    Private Sub btUbahInvestor_Click(sender As Object, e As EventArgs) Handles btUbahInvestor.Click
        Dim queryUpdate As String
        Dim cmd As NpgsqlCommand
        Dim varAlamat, varNama, varInvestasi, varKodeInvestor, varKodeCabang As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varAlamat = txtalamatinvestor.Text
        varNama = txtNamaInvestor.Text
        varInvestasi = txtinvestasi.Text
        varKodeInvestor = cmbiInvest.SelectedItem.ToString
        varKodeCabang = cmbiCab.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varAlamat.Length > 0 And varNama.Length > 0 And varInvestasi.Length > 0 And varKodeInvestor.Length > 0 And varKodeCabang.Length > 0) Then
            'mengubah data distributor
            queryUpdate = "update investor set Nama='" & varNama & "', alamat='" & varAlamat & "', investasi='" & varInvestasi & "', kodeinvestor='" & varKodeInvestor & "' where kodecabang='" & varKodeCabang & "';"
            cmd = New NpgsqlCommand(queryUpdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil mengubah " & rowAffected & " baris.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataInvestor()
        Else
            MessageBox.Show("Silakan lengkapi data")
        End If
    End Sub

    Private Sub btHapusInvestor_Click(sender As Object, e As EventArgs) Handles btHapusInvestor.Click
        Dim queryDelete As String
        Dim cmd As NpgsqlCommand
        Dim varKodeInvestor As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeInvestor = cmbiInvest.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeInvestor.Length > 0) Then
            'menghapus data distributor
            queryDelete = "delete from investor where kodeinvestor='" & varKodeInvestor & "';"
            cmd = New NpgsqlCommand(queryDelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil menghapus " & rowAffected & " baris.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataInvestor()
        Else
            MessageBox.Show("Silakan isi kode investor yang akan dihapus!")
        End If
    End Sub

    Private Sub btPenjualan_Click(sender As Object, e As EventArgs) Handles btPenjualan.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = True
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataPenjualan()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodetransaksi = "select kodetransaksi from penjualan;"
        cmd = New NpgsqlCommand(kodetransaksi, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sT = reader("kodetransaksi")
            cmbpTrans.Items.Add(sT)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodecabang = "select kodecabang from cabang;"
        cmd = New NpgsqlCommand(kodecabang, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sCab = reader("kodecabang")
            cmbpCab.Items.Add(sCab)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodebuku = "select kodebuku from buku;"
        cmd = New NpgsqlCommand(kodebuku, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sBuku = reader("kodebuku")
            cmbpBuku.Items.Add(sBuku)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodepegawai = "select kodepegawai from pegawai;"
        cmd = New NpgsqlCommand(kodepegawai, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sPeg = reader("kodepegawai")
            cmbpPeg.Items.Add(sPeg)
        End While
        koneksinya.Close()
    End Sub
    Sub refreshDataPenjualan()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from penjualan;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgPenjualan.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariPenjualan_Click(sender As Object, e As EventArgs) Handles btCariPenjualan.Click
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varkodetransaksi As String

        koneksiDB()
        koneksinya.Close()

        varkodetransaksi = cmbpTrans.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varkodetransaksi.Length > 0) Then
            querySelect = "select * from penjualan where kodetransaki='" & varkodetransaksi & "' ;"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgPenjualan.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isikan kode pegawai yang ingin dicari")
        End If
    End Sub

    Private Sub btUbahPenjualan_Click(sender As Object, e As EventArgs) Handles btUbahPenjualan.Click
        Dim queryupdate As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varKodePegawai, varHargaSatuan, varKuantitas, varKodeMember, varKodeBuku, varKodeCabang, varkodetransaksi As String
        Dim varTanggalTransaksi As DateTime

        koneksiDB()
        koneksinya.Close()

        varHargaSatuan = txtHargaSatuan.Text
        varKuantitas = txtKuantitas.Text
        varKodeMember = txtKodeMember3.Text
        varKodeCabang = cmbpCab.SelectedItem.ToString
        varKodeBuku = cmbpBuku.SelectedItem.ToString
        varKodePegawai = cmbpPeg.SelectedItem.ToString
        varkodetransaksi = cmbpTrans.SelectedItem.ToString
        varTanggalTransaksi = "Tanggal Transaksi Belum Diinput"

        varTanggalTransaksi = DateTimePenjualan1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodePegawai.Length > 0 And varHargaSatuan.Length > 0 And varKuantitas.Length > 0 And varKodeMember.Length > 0 And varKodeBuku.Length > 0 And varTanggalTransaksi.ToBinary > 0 And varKodeCabang.Length > 0 And varkodetransaksi.Length > 0) Then
            queryupdate = "update pegawai Set kodepegawai='" & varKodePegawai & "',hargasatuan='" & varHargaSatuan & "',kuantitas='" & varKuantitas & "',kodemember='" & varKodeMember & "',kodebuku='" & varKodeBuku & "',tanggaltransaksi='" & varTanggalTransaksi & "',kodecabang='" & varKodeCabang & "' where kodetransaksi='" & varkodetransaksi & "';"
            cmd = New NpgsqlCommand(queryupdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah diubah")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi data yang masih kosong")
        End If
        koneksinya.Close()

        refreshDataPenjualan()
    End Sub

    Private Sub btTambahPenjualan_Click(sender As Object, e As EventArgs) Handles btTambahPenjualan.Click
        Dim queryInsert As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varKodePegawai, varHargaSatuan, varKuantitas, varKodeMember, varKodeBuku, varKodeCabang, varkodetransaksi As String
        Dim varTanggalTransaksi As DateTime

        koneksiDB()
        koneksinya.Close()
        varHargaSatuan = txtHargaSatuan.Text
        varKuantitas = txtKuantitas.Text
        varKodeMember = txtKodeMember3.Text
        varKodeCabang = cmbpCab.SelectedItem.ToString
        varKodeBuku = cmbpBuku.SelectedItem.ToString
        varKodePegawai = cmbpPeg.SelectedItem.ToString
        varkodetransaksi = cmbpTrans.SelectedItem.ToString
        varTanggalTransaksi = "Tanggal Transaksi Belum Diinput"

        varTanggalTransaksi = DateTimePenjualan1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        'menambah database
        If (varKodePegawai.Length > 0 And varHargaSatuan.Length > 0 And varKuantitas.Length > 0 And varKodeMember.Length > 0 And varKodeBuku.Length > 0 And varTanggalTransaksi.ToBinary > 0 And varKodeCabang.Length > 0 And varkodetransaksi.Length > 0) Then
            queryInsert = "insert into penjualan values(' " & varkodetransaksi & "','" & varKodeCabang & " ','" & varTanggalTransaksi & " ', '" & varKodeBuku & " ','" & varKodeMember & " ','" & varKuantitas & "','" & varHargaSatuan & "','" & varKodePegawai & "');"
            cmd = New NpgsqlCommand(queryInsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan lengkapi data yang masih kosong")
        End If
        koneksinya.Close()
        refreshDataPenjualan()
    End Sub

    Private Sub btHapusPenjualan_Click(sender As Object, e As EventArgs) Handles btHapusPenjualan.Click
        Dim querydelete As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varkodetransaksi As String

        koneksiDB()
        koneksinya.Close()

        varkodetransaksi = cmbpTrans.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varkodetransaksi.Length > 0) Then
            querydelete = "delete from penjualan where kodetransaksi='" & varkodetransaksi & "';"
            cmd = New NpgsqlCommand(querydelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah dihapus")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi kode transaksi yang ingin dihapus")
        End If
        koneksinya.Close()
        refreshDataPenjualan()
    End Sub

    Private Sub btCabang_Click(sender As Object, e As EventArgs) Handles btCabang.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = True
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataCabang()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodecabang = "select kodecabang from cabang;"
        cmd = New NpgsqlCommand(kodecabang, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sCabang = reader("kodecabang")
            cmbcCab.Items.Add(sCabang)
        End While
    End Sub
    Sub refreshDataCabang()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from cabang;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgCabang.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariCabang_Click(sender As Object, e As EventArgs) Handles btCariCabang.Click
        Dim queryselect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varKodeCabang As String

        koneksiDB()
        koneksinya.Close()

        varKodeCabang = cmbcCab.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeCabang.Length > 0) Then
            queryselect = "select * from cabang where kodecabang = '" & varKodeCabang & "';"
            cmd = New NpgsqlCommand(queryselect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgCabang.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi kode cabang yang ingin Anda cari")
        End If
        koneksinya.Close()
    End Sub

    Private Sub btTambahCabang_Click(sender As Object, e As EventArgs) Handles btTambahCabang.Click
        Dim queryinsert As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varJalan, varKota, varKodePos, varKodeCabang As String

        koneksiDB()
        koneksinya.Close()

        varJalan = txtJalan.Text
        varKota = txtKota.Text
        varKodePos = txtKodePos.Text
        varKodeCabang = cmbcCab.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varJalan.Length > 0 And varKota.Length > 0 And varKodePos.Length > 0 And varKodeCabang.Length > 0) Then
            queryinsert = "insert into cabang values('" & varKodeCabang & "','" & varJalan & "','" & varKota & "','" & varKodePos & "');"
            cmd = New NpgsqlCommand(queryinsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan lengkapi data yang masih kosong")
        End If
        koneksinya.Close()
        refreshDataCabang()
    End Sub

    Private Sub btUbahCabang_Click(sender As Object, e As EventArgs) Handles btUbahCabang.Click
        Dim queryupdate As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varjalan, varkota, varkodepos, varkodecabang As String

        koneksiDB()
        koneksinya.Close()

        varjalan = txtJalan.Text
        varkota = txtKota.Text
        varkodepos = txtKodePos.Text
        varkodecabang = cmbcCab.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varjalan.Length > 0 Or varkota.Length > 0 Or varkodepos.Length > 0 Or varkodecabang.Length > 0) Then
            queryupdate = "update cabang Set jalan='" & varjalan & "',kota='" & varkota & "',kodepos='" & varkodepos & "' where kodecabang='" & varkodecabang & "';"
            cmd = New NpgsqlCommand(queryupdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah diubah")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan lengkapi data yang masih kosong")
        End If
        koneksinya.Close()
        refreshDataCabang()
    End Sub

    Private Sub btHapusCabang_Click(sender As Object, e As EventArgs) Handles btHapusCabang.Click
        Dim querydelete As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varkodecabang As String

        koneksiDB()
        koneksinya.Close()

        varkodecabang = cmbcCab.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varkodecabang.Length > 0) Then
            querydelete = "delete from cabang where kodecabang='" & varkodecabang & "';"
            cmd = New NpgsqlCommand(querydelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah dihapus")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi kode cabang yang ingin dihapus")
        End If
        koneksinya.Close()
        refreshDataCabang()
    End Sub

    Private Sub btPengadaan_Click(sender As Object, e As EventArgs) Handles btPengadaan.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = True
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataStock()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodedistributor = "select kodedistributor from pengadaan;"
        cmd = New NpgsqlCommand(kodedistributor, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sDist = reader("kodedistributor")
            cmbDistributor.Items.Add(sDist)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodecabang = "select kodecabang from cabang;"
        cmd = New NpgsqlCommand(kodecabang, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sCab = reader("kodecabang")
            cmbCab.Items.Add(sCab)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodebuku = "select kodebuku from buku;"
        cmd = New NpgsqlCommand(kodebuku, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sBuku = reader("kodebuku")
            cmbBuku.Items.Add(sBuku)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodepegawai = "select kodepegawai from pegawai;"
        cmd = New NpgsqlCommand(kodepegawai, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sPeg = reader("kodepegawai")
            cmbPeg.Items.Add(sPeg)
        End While
    End Sub
    Sub refreshDataStock()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from pengadaan;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgPengadaan.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariStock_Click(sender As Object, e As EventArgs) Handles btCariStock.Click
        'menampilkan data pengadaan sesuai dengan yang dicari
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varKodeDistributor, varKodeCabang, varKodeBuku, varKodePegawai As String

        koneksiDB()
        koneksinya.Close()

        varKodeDistributor = cmbDistributor.SelectedItem.ToString
        varKodeCabang = cmbCab.SelectedItem.ToString
        varKodeBuku = cmbBuku.SelectedItem.ToString
        varKodePegawai = cmbPeg.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeDistributor.Length > 0 Or varKodeCabang.Length > 0 Or varKodeBuku.Length > 0 Or varKodePegawai.Length > 0) Then
            querySelect = "select * from pengadaan where kodedistributor='" & varKodeDistributor & "' or kodecabang='" & varKodeCabang & "' or kodebuku='" & varKodeBuku & "' or kodepegawai='" & varKodePegawai & "';"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgPengadaan.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan isi kode distributor / kode cabang / kode buku / kode pegaweai yang ingin dicari!")
        End If
    End Sub

    Private Sub btTambahStock_Click(sender As Object, e As EventArgs) Handles btTambahStock.Click
        Dim queryInsert As String
        Dim cmd As NpgsqlCommand
        Dim varKodeCabang, varKodeBuku, varKodePegawai, varKodeDistributor, varHarga, varBanyak, varOngkir As String
        Dim varTanggal As DateTime
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeDistributor = cmbDistributor.SelectedItem.ToString
        varKodeCabang = cmbCab.SelectedItem.ToString
        varKodeBuku = cmbBuku.SelectedItem.ToString
        varKodePegawai = cmbPeg.SelectedItem.ToString
        varHarga = txtHarga.Text
        varBanyak = txtBanyak.Text
        varTanggal = "Tanggal Pengadaan Belum Diinput"
        varOngkir = txtOngkir.Text

        varTanggal = DateTimePengadaan1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varHarga.Length > 0 And varBanyak.Length > 0 And varOngkir.Length > 0 And varKodeDistributor.Length > 0 And varTanggal.ToBinary > 0 And varKodeCabang.Length > 0 And varKodeBuku.Length > 0 And varKodePegawai.Length > 0) Then
            'menambahkan data pengadaan
            queryInsert = "insert into pengadaan values ('" & varKodeDistributor & "','" & varKodeCabang & "','" & varKodeBuku & "','" & varHarga & "','" & varBanyak & "','" & varOngkir & "','" & varTanggal & "','" & varKodePegawai & "');
            update pengadaan
            set jumlah_buku=banyak_kodi*20, total_ongkir=ongkir*banyak_kodi;
            update pengadaan
            set total_hargabuku=jumlah_buku*hargabeli;
            update pengadaan
            set pajak=total_hargabuku*10/100;
            update pengadaan
            set total =(pajak + total_ongkir + total_hargabuku);"
            cmd = New NpgsqlCommand(queryInsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah berhasil ditambahkan.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshData()
        Else
            MessageBox.Show("Silakan lengkapi data")
        End If
    End Sub

    Private Sub btUbahStock_Click(sender As Object, e As EventArgs) Handles btUbahStock.Click
        Dim queryUpdate As String
        Dim cmd As NpgsqlCommand
        Dim varKodeCabang, varKodeBuku, varKodePegawai, varKodeDistributor, varHarga, varBanyak, varOngkir As String
        Dim varTanggal As DateTime
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeDistributor = cmbDistributor.SelectedItem.ToString
        varKodeCabang = cmbCab.SelectedItem.ToString
        varKodeBuku = cmbBuku.SelectedItem.ToString
        varKodePegawai = cmbPeg.SelectedItem.ToString
        varHarga = txtHarga.Text
        varBanyak = txtBanyak.Text
        varTanggal = "Tanggal Pengadaan Belum Diinput"
        varOngkir = txtOngkir.Text

        varTanggal = DateTimePengadaan1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varHarga.Length > 0 And varBanyak.Length > 0 And varOngkir.Length > 0 And varKodeDistributor.Length > 0 And varTanggal.ToBinary > 0 And varKodeCabang.Length > 0 And varKodeBuku.Length > 0 And varKodePegawai.Length > 0) Then
            'mengubah data pengadaan
            queryUpdate = "update pengadaan set hargabeli='" & varHarga & "', banyak_kodi='" & varBanyak & "', ongkir='" & varOngkir & "', tgl='" & varTanggal & "', kodecabang='" & varKodeCabang & "', kodebuku='" & varKodeBuku & "', kodepegawai='" & varKodePegawai & "' where kodedistributor='" & varKodeDistributor & "';
            update pengadaan
            set jumlah_buku=banyak_kodi*20, total_ongkir=ongkir*banyak_kodi;
            update pengadaan
            set total_hargabuku=jumlah_buku*hargabeli;
            update pengadaan
            set pajak=total_hargabuku*10/100;
            update pengadaan
            set total =(pajak + total_ongkir + total_hargabuku);"
            cmd = New NpgsqlCommand(queryUpdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil mengubah " & rowAffected & " baris.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataStock()
        Else
            MessageBox.Show("Silakan lengkapi data")
        End If
    End Sub

    Private Sub btHapusStock_Click(sender As Object, e As EventArgs) Handles btHapusStock.Click
        Dim queryDelete As String
        Dim cmd As NpgsqlCommand
        Dim varKodeDistributor, varKodeCabang, varKodeBuku, varKodePegawai As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeDistributor = cmbDistributor.SelectedItem.ToString
        varKodeCabang = cmbCab.SelectedItem.ToString
        varKodeBuku = cmbBuku.SelectedItem.ToString
        varKodePegawai = cmbPeg.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeDistributor.Length > 0 And varKodeCabang.Length > 0 And varKodeBuku.Length > 0 And varKodePegawai.Length > 0) Then
            'menghapus data pengadaan
            queryDelete = "delete from pengadaan where kodedistributor='" & varKodeDistributor & "' and kodecabang='" & varKodeCabang & "' and kodebuku='" & varKodeBuku & "' and kodepegawai='" & varKodePegawai & "';"
            cmd = New NpgsqlCommand(queryDelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil menghapus " & rowAffected & " baris.")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
            'tampilkan datanya
            refreshDataStock()
        Else
            MessageBox.Show("Silakan isi kode distributor, kode cabang, kode buku, dan kode pegawai yang akan dihapus!")
        End If
    End Sub

    Private Sub btAbsensi_Click(sender As Object, e As EventArgs) Handles btAbsensi.Click

        Dim kodecabang, kodepegawai As String
        Dim cmd As NpgsqlCommand
        Dim reader As NpgsqlDataReader

        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = True

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataAbsensi()

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodecabang = "select kodecabang from cabang;"
        cmd = New NpgsqlCommand(kodecabang, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sCabang = reader("kodecabang")
            ComboBox2Absensi.Items.Add(sCabang)
        End While
        koneksinya.Close()
        koneksinya.Open()
        kodepegawai = "select kodepegawai from pegawai;"
        cmd = New NpgsqlCommand(kodepegawai, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sPegawai = reader("kodepegawai")
            ComboBox1Absensi.Items.Add(sPegawai)
        End While
        koneksinya.Close()

    End Sub
    Sub refreshDataAbsensi()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from absensi;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgAbsensi.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariAbsensi_Click(sender As Object, e As EventArgs) Handles btCariAbsensi.Click
        Dim varKodePegawai As String
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        'menampilkan data absensi pegawai sesuai yang dimasukkan di kolom kode pegawai'
        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1Absensi.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodePegawai.Length > 0) Then
            querySelect = "select * from absensi where kodepegawai='" & varKodePegawai & "';"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgAbsensi.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan isi Kode Pegawai yang ingin dicari")
        End If
    End Sub

    Private Sub btTambahAbsensi_Click(sender As Object, e As EventArgs) Handles btTambahAbsensi.Click
        Dim queryinsert As String
        Dim cmd As NpgsqlCommand
        Dim varKodePegawai, varKodeCabang, varKeterangan, varWaktuHadir, varAlasan As String
        Dim varTanggal As DateTime
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1Absensi.SelectedItem.ToString
        varKodeCabang = ComboBox2Absensi.SelectedItem.ToString
        varTanggal = "Tanggal Absensi Belum Diinput"
        varKeterangan = txt_keterangan.Text
        varWaktuHadir = txt_waktuhadir.Text
        varAlasan = txt_alasan.Text

        varTanggal = DateTimeAbsensi1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        'menambahkan data absensi pegawai'
        If (varKodePegawai.Length > 0 And varKodeCabang.Length > 0 And varTanggal.ToBinary > 0 And varKeterangan.Length > 0) Then
            queryinsert = "insert into absensi values('" & varKodePegawai & "','" & varKodeCabang & "','" & varTanggal & "','" & varKeterangan & "','" & varWaktuHadir & "', '" & varAlasan & "');"
            cmd = New NpgsqlCommand(queryinsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil ditambah " & rowAffected & " baris")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan lengkapi datanya!")
        End If
        'tampilkan datanya'
        refreshDataAbsensi()
    End Sub

    Private Sub btUbahAbsensi_Click(sender As Object, e As EventArgs) Handles btUbahAbsensi.Click
        Dim queryupdate As String
        Dim varKodePegawai, varKodeCabang, varKeterangan, varWaktuHadir, varAlasan As String
        Dim varTanggal As DateTime
        Dim rowAffected As Integer
        Dim cmd As NpgsqlCommand

        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1Absensi.SelectedItem.ToString
        varKodeCabang = ComboBox2Absensi.SelectedItem.ToString
        varTanggal = "Tanggal Absensi Belum Diinput"
        varKeterangan = txt_keterangan.Text
        varWaktuHadir = txt_waktuhadir.Text
        varAlasan = txt_alasan.Text

        varTanggal = DateTimeAbsensi1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodePegawai.Length > 0 And varKodeCabang.Length > 0 And varTanggal.ToBinary > 0 And varKeterangan.Length > 0) Then
            'mengubah data absensi pegawai'
            queryupdate = "update absensi set keterangan='" & varKeterangan & "',waktuhadir='" & varWaktuHadir & "',alasan='" & varAlasan & "' where kodepegawai='" & varKodePegawai & "' and kodecabang='" & varKodeCabang & "' and tanggal='" & varTanggal & "';"
            cmd = New NpgsqlCommand(queryupdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil diubah " & rowAffected & " baris")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan lengkapi datanya!")
        End If
        'tampilkan datanya'
        refreshDataAbsensi()
    End Sub

    Private Sub btHapusAbsensi_Click(sender As Object, e As EventArgs) Handles btHapusAbsensi.Click
        Dim querydelete As String
        Dim varKodePegawai As String
        Dim varTanggal As DateTime
        Dim rowAffected As Integer
        Dim cmd As NpgsqlCommand

        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1Absensi.SelectedItem.ToString
        varTanggal = "Tanggal Absensi Belum Diinput"
        varTanggal = DateTimeAbsensi1.Value

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        'menghapus data branch'
        If (varKodePegawai.Length > 0 And varTanggal.ToBinary > 0) Then
            querydelete = "delete from absensi where kodepegawai='" & varKodePegawai & "',tanggal='" & varTanggal & "' ;"
            cmd = New NpgsqlCommand(querydelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil dihapus " & rowAffected & " baris")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi Kode Pegawai dan Tanggal yang akan dihapus")
            koneksinya.Close()
        End If

        'tampilkan datanya'
        refreshDataAbsensi()
    End Sub

    Private Sub btBuku_Click(sender As Object, e As EventArgs) Handles btBuku.Click

        Dim kodebuku, kodedistributor As String
        Dim cmd As NpgsqlCommand
        Dim reader As NpgsqlDataReader

        pnlmember.Visible = False
        pnlbuku.Visible = True
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataBuku()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodebuku = "select kodebuku from buku;"
        kodedistributor = "select kodedistributor from pengadaan;"
        cmd = New NpgsqlCommand(kodebuku, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sBuku = reader("kodebuku")
            cbBuku.Items.Add(sBuku)
        End While
        koneksinya.Close()
        koneksinya.Open()
        cmd = New NpgsqlCommand(kodedistributor, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sDist = reader("kodedistributor")
            cbDist.Items.Add(sDist)
        End While
        koneksinya.Close()
    End Sub
    Sub refreshDataBuku()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from buku;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgBuku.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub bt_cari_Click(sender As Object, e As EventArgs) Handles bt_cari.Click
        Dim varKodeBuku As String
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        'menampilkan data buku sesuai yang dimasukkan di kolom kode buku'
        koneksiDB()
        koneksinya.Close()

        varKodeBuku = cbBuku.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeBuku.Length > 0) Then
            querySelect = "select * from buku where kodebuku='" & varKodeBuku & "';"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgBuku.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan isi Kode Buku yang ingin dicari")
        End If
    End Sub

    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        Dim queryinsert As String
        Dim varKodeBuku, varJudulBuku, varHarga, varKodeDistributor As String
        Dim rowAffected As Integer
        Dim cmd As NpgsqlCommand

        koneksiDB()
        koneksinya.Close()

        varKodeBuku = cbBuku.SelectedItem.ToString
        varJudulBuku = txt_judulbuku.Text
        varHarga = txt_harga.Text
        varKodeDistributor = cbDist.SelectedItem.ToString

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        'menambahkan data buku'
        If (varKodeBuku.Length > 0 And varJudulBuku.Length > 0 And varHarga.Length > 0 And varKodeDistributor.Length > 0) Then
            queryinsert = "insert into buku values('" & varKodeBuku & "','" & varJudulBuku & "','" & varHarga & "','" & varKodeDistributor & "');"
            cmd = New NpgsqlCommand(queryinsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil ditambah " & rowAffected & " baris")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan lengkapi datanya!")
        End If
        'tampilkan datanya'
        refreshDataBuku()
    End Sub

    Private Sub bt_ubah_Click(sender As Object, e As EventArgs) Handles bt_ubah.Click
        Dim queryupdate As String
        Dim cmd As NpgsqlCommand
        Dim varKodeBuku, varJudulBuku, varHarga, varKodeDistributor As String
        Dim rowAffected As Integer

        koneksiDB()
        koneksinya.Close()

        varKodeBuku = cbBuku.SelectedItem.ToString
        varJudulBuku = txt_judulbuku.Text
        varHarga = txt_harga.Text
        varKodeDistributor = cbDist.SelectedItem.ToString

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeBuku.Length > 0 And varJudulBuku.Length > 0 And varHarga.Length > 0 And varKodeDistributor.Length > 0) Then
            'mengubah data buku'
            queryupdate = "update buku set judulbuku='" & varJudulBuku & "',harga='" & varHarga & "',kodedistributor='" & varKodeDistributor & "' where kodebuku='" & varKodeBuku & "';"
            cmd = New NpgsqlCommand(queryupdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil diubah " & rowAffected & " baris")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
            koneksinya.Close()
        Else
            MessageBox.Show("Silakan lengkapi datanya!")
        End If
        'tampilkan datanya'
        refreshDataBuku()
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        Dim querydelete As String
        Dim varKodeBuku As String
        Dim rowAffected As Integer
        Dim cmd As NpgsqlCommand

        koneksiDB()
        koneksinya.Close()

        varKodeBuku = cbBuku.SelectedItem.ToString

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        'menghapus data branch'
        If (varKodeBuku.Length > 0) Then
            querydelete = "delete from buku where kodebuku='" & varKodeBuku & "';"
            cmd = New NpgsqlCommand(querydelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil dihapus " & rowAffected & " baris")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi Kode Buku yang akan dihapus")
            koneksinya.Close()
        End If

        'tampilkan datanya'
        refreshDataBuku()
    End Sub

    Private Sub btPegawai_Click(sender As Object, e As EventArgs) Handles btPegawai.Click
        Dim kodepegawai, kodecabang As String
        Dim cmd As NpgsqlCommand
        Dim reader As NpgsqlDataReader

        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = True
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False

        refreshDataPegawai()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        kodecabang = "select kodecabang from cabang;"
        kodepegawai = "select kodepegawai from pegawai;"
        cmd = New NpgsqlCommand(kodecabang, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sCabang = reader("kodecabang")
            ComboBox2.Items.Add(sCabang)
        End While
        koneksinya.Close()
        koneksinya.Open()
        cmd = New NpgsqlCommand(kodepegawai, koneksinya)
        cmd.CommandType = CommandType.Text
        reader = cmd.ExecuteReader
        While reader.Read
            Dim sPegawai = reader("kodepegawai")
            ComboBox1.Items.Add(sPegawai)
        End While
    End Sub
    Sub refreshDataPegawai()
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet

        koneksiDB()
        koneksinya.Close()

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        querySelect = "select * from pegawai;"
        cmd = New NpgsqlCommand(querySelect, koneksinya)
        cmd.CommandType = CommandType.Text
        Try
            cmd.ExecuteNonQuery()
            data = New NpgsqlDataAdapter(cmd)
            datasetnya = New DataSet
            datasetnya.Reset()
            data.Fill(datasetnya)
            dgPegawai.DataSource = datasetnya.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
        koneksinya.Close()
    End Sub

    Private Sub btCariPegawai_Click(sender As Object, e As EventArgs) Handles btCariPegawai.Click
        Dim querySelect As String
        Dim cmd As NpgsqlCommand
        Dim data As NpgsqlDataAdapter
        Dim datasetnya As DataSet
        Dim varkodepegawai As String


        koneksiDB()
        koneksinya.Close()

        varkodepegawai = ComboBox1.SelectedItem.ToString
        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varkodepegawai.Length > 0) Then
            querySelect = "select * from pegawai where kodepegawai='" & varkodepegawai & "' ;"
            cmd = New NpgsqlCommand(querySelect, koneksinya)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Try
                cmd.ExecuteNonQuery()
                data = New NpgsqlDataAdapter(cmd)
                datasetnya = New DataSet
                datasetnya.Reset()
                data.Fill(datasetnya)
                dgPegawai.DataSource = datasetnya.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isikan kode pegawai yang ingin dicari")
        End If
    End Sub

    Private Sub btTambahPegawai_Click(sender As Object, e As EventArgs) Handles btTambahPegawai.Click
        Dim queryInsert As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varKodePegawai, varNamaDepan, varNamaBelakang, varPosisi, varGaji, varGender, varKodeCabang As String

        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1.SelectedItem.ToString
        varNamaDepan = txtnamadepan8.Text
        varNamaBelakang = txtnamabelakang8.Text
        varPosisi = txtPosisi.Text
        varGaji = txtGaji.Text
        varKodeCabang = ComboBox2.SelectedItem.ToString
        varGender = "Data Gender Belum Diinput"

        If rbPria.Checked = True Then
            varGender = rbPria.Text
        ElseIf rbWanita.Checked = True Then
            varGender = rbWanita.Text
        End If

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        'menambah database
        If (varKodeCabang.Length > 0 And varGender.Length > 0 And varGaji.Length > 0 And varPosisi.Length > 0 And varNamaBelakang.Length > 0 And varNamaDepan.Length > 0 And varKodePegawai.Length > 0) Then
            queryInsert = "insert into pegawai values(' " & varKodePegawai & "','" & varNamaDepan & " ','" & varNamaBelakang & " ', '" & varPosisi & " ','" & varGaji & " ','" & varGender & "','" & varKodeCabang & "');"
            cmd = New NpgsqlCommand(queryInsert, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah ditambahkan")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan lengkapi data yang masih kosong")
        End If
        koneksinya.Close()
        refreshDataPegawai()
    End Sub


    Private Sub btUbahPegawai_Click(sender As Object, e As EventArgs) Handles btUbahPegawai.Click
        Dim queryupdate As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varKodeCabang, varGender, varGaji, varPosisi, varNamaBelakang, varNamaDepan, varKodePegawai As String

        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1.SelectedItem.ToString
        varNamaDepan = txtnamadepan8.Text
        varNamaBelakang = txtnamabelakang8.Text
        varPosisi = txtPosisi.Text
        varGaji = txtGaji.Text
        varGender = "Data Anda Belum Lengkap"
        varKodeCabang = ComboBox2.SelectedItem.ToString

        If rbPria.Checked = True Then
            varGender = rbPria.Text
        ElseIf rbWanita.Checked = True Then
            varGender = rbWanita.Text
        End If

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodeCabang.Length > 0 And varGender.Length > 0 And varGaji.Length > 0 And varPosisi.Length > 0 And varNamaBelakang.Length > 0 And varNamaDepan.Length > 0 And varKodePegawai.Length > 0) Then
            queryupdate = "update pegawai Set kodecabang='" & varKodeCabang & "',jeniskelamin='" & varGender & "',gaji='" & varGaji & "',posisi='" & varPosisi & "',namabelakang='" & varNamaBelakang & "',namadepan='" & varNamaDepan & "' where kodepegawai='" & varKodePegawai & "';"
            cmd = New NpgsqlCommand(queryupdate, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah diubah")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi data yang masih kosong")
        End If
        koneksinya.Close()

        refreshDataPegawai()
    End Sub

    Private Sub btHapusPegawai_Click(sender As Object, e As EventArgs) Handles btHapusPegawai.Click
        Dim querydelete As String
        Dim cmd As NpgsqlCommand
        Dim rowAffected As Integer
        Dim varKodePegawai As String

        koneksiDB()
        koneksinya.Close()

        varKodePegawai = ComboBox1.SelectedItem.ToString

        If (koneksinya.State = ConnectionState.Closed) Then koneksinya.Open()
        If (varKodePegawai.Length > 0) Then
            querydelete = "delete from pegawai where kodepegawai='" & varKodePegawai & "';"
            cmd = New NpgsqlCommand(querydelete, koneksinya)
            cmd.CommandType = CommandType.Text
            Try
                rowAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Sejumlah " & rowAffected & " baris sudah dihapus")
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan isi kode pegawai yang ingin dihapus")
        End If
        koneksinya.Close()
        refreshDataPegawai()
    End Sub

    Private Sub tbabsensi_Click(sender As Object, e As EventArgs) Handles tbabsensi.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = True

        'IN CASE THE AUTO GENERATE CRYSTAL VIEWER DOESN'T POPUP
        'USE MY SPECIAL CODE! - D!cer 2020
        'Dim cryRpt As New ReportDocument
        'cryRpt.Load("Gedebug/KehadiranPegawaiReport.rpt")
        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.Refresh()

        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub tbkeuangan_Click(sender As Object, e As EventArgs) Handles tbkeuangan.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = True
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub tbgajipegawai_Click(sender As Object, e As EventArgs) Handles tbgajipegawai.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = True
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub tbstockbuku_Click(sender As Object, e As EventArgs) Handles tbstockbuku.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = True
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub tbtransaksi_Click(sender As Object, e As EventArgs) Handles tbtransaksi.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = True

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub tbbestseller_Click(sender As Object, e As EventArgs) Handles tbbestseller.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = True
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = True
        lbinformasi.Visible = False
        lblaporan.Visible = False
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = True
        pnllaporan.Visible = False
        pnlinformasi.Visible = False
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        pnlmember.Visible = False
        pnlbuku.Visible = False
        pnlcabang.Visible = False
        pnlinvestor.Visible = False
        pnlpegawai.Visible = False
        pnlpengadaan.Visible = False
        pnlpenjualan.Visible = False
        pnldistributor.Visible = False
        pnlabsensi.Visible = False

        pnllaporanabsensi.Visible = False
        pnllaporanbukubest.Visible = False
        pnllaporangaji.Visible = False
        pnllaporankeuangan.Visible = False
        pnllaporanstockbuku.Visible = False
        pnllaporantransaksi.Visible = False

        lbdatautama.Visible = False
        lbinformasi.Visible = False
        lblaporan.Visible = True
        lblogout.Visible = False
        lbdashboard.Visible = False

        pnldashboard.Visible = False
        pnldatautama.Visible = False
        pnllaporan.Visible = True
        pnlinformasi.Visible = False
    End Sub
End Class