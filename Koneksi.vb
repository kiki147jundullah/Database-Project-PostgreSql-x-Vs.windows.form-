Imports Npgsql
Module Koneksi
    Public koneksinya As NpgsqlConnection

    Sub koneksiDB()
        Dim dbstring As String

        dbstring = "server=localhost;port=5432;database=getthebook;username=postgres;password=Bismillah22;"
        koneksinya = New NpgsqlConnection(dbstring)

    End Sub
End Module
