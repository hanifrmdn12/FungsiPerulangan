Public Class Form1

    Sub Perulangan_For()
        For i = 1 To 10
            ListFor.Items.Add(i)
        Next
    End Sub

    Sub Perulangan_While()
        Dim i As Integer = 1
        While i <= 10
            ListWhile.Items.Add(i)
            i = i + 1
        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Perulangan_For()
        Perulangan_While()
    End Sub
End Class
