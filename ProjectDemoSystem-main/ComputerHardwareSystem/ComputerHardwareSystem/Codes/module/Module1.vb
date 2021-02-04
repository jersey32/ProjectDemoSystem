Imports MySql.Data.MySqlClient
Module Module1
    Public LoginQuery As String
    Public query As MySqlCommand
    Public read As MySqlDataReader
    Public count As Integer
    Public insertQuery As String
    Public stockQuery As String
    Public updateQuery As String
    Public saveUpdateQuery As String
    Public ctrl As New controller
    Public Function Con() As MySqlConnection

        Con = New MySqlConnection()
        Con.ConnectionString = "server=localhost;" _
            & "user id=root;" _
            & "password=;" _
            & "database=computer_hardware"

        Con.Open()
        Return Con

    End Function
End Module
