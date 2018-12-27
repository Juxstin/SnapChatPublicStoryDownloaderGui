Imports System.Net

Public Class Downloader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("A New broweser will open... RIGHT CLICK THE VIDEO TO SAVE <3")
        Process.Start("https://story.snapchat.com/s/" + TextBox1.Text)
    End Sub

    Private Sub Downloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class