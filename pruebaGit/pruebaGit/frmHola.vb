Public Class frmHola

    Private Function saludos() As String
        Dim cad As String = "Hola"

        Return cad
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(saludos)
    End Sub
End Class