Imports System.ComponentModel

Public Class frm_register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword2.Text.Equals(txtPassword1.Text) Then
        Else
            MsgBox("password not match")
        End If

    End Sub

    Private Sub frm_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()

    End Sub

    Private Sub frm_register_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frm_login.Show()
    End Sub
End Class