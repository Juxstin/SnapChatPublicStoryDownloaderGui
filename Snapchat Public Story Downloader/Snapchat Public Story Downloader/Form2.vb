Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim PIP As String = "https://pastebin.com/raw/fqPgm79U"
            Process.Start(PIP)
        Catch ex As Exception
            MsgBox("Error 721Z")
        End Try
        Threading.Thread.Sleep(5000)
        Try
            'broken code below idek
            Dim p As New Process
            p.StartInfo.FileName = My.Application.Info.DirectoryPath + "\PythonScriptz\snapstory.py"
            p.StartInfo.Arguments = TextBox1.Text
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = True
            p.Start()
        Catch ex As Exception
            MsgBox("I guess the story wasn't public or the person is not popular enough")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class