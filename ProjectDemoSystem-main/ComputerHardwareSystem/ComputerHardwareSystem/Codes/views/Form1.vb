Public Class Form1
    Dim ctrl As New controller
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ctrl.login()
    End Sub

    Private Sub txtbox_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ctrl.login()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub
End Class
