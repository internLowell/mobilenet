Imports MySql.Data.MySqlClient
Module convb
    Public con As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=wifi;User ID=root;Password=;")
    Public da As MySqlDataAdapter
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public dt As DataTable
    Public query As String
End Module
