Imports System.Net

Public Class Downloader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://198.27.82.201/snapdl.php?key=TeamNilXXTEX&user=" + TextBox1.Text)
        TextBox2.Text = result
    End Sub
End Class