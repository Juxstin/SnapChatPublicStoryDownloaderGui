
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Python3.7 Required MAKE SURE U INSTALL PIP W/IT")
        Dim pythonDL As String = "https://www.python.org/ftp/python/3.7.0/python-3.7.0.exe"
        Process.Start(pythonDL)
        MsgBox("Click ok once python is installed!")
        MsgBox("Now Setting up Files....")
        If Dir("PythonScriptz", vbDirectory) = "" Then
            MkDir("PythonScriptz")
            Dim webClient As New System.Net.WebClient
            'after this the file specified on second parameter should exists.
            Dim folderPath As String = "PythonScriptz"
            Dim fileName As String = "snapstory.py"
            Dim combinePath As String = System.IO.Path.Combine(folderPath, fileName)
            webClient.DownloadFile("http://198.27.82.201/latestandgreatist.py", combinePath)
            MsgBox("Done! Program now useable!")
            Form2.Show()
        Else
            Dim webClient As New System.Net.WebClient
            'after this the file specified on second parameter should exists.
            Dim folderPath As String = "PythonScriptz"
            Dim fileName As String = "snapstory.py"
            Dim combinePath As String = System.IO.Path.Combine(folderPath, fileName)
            webClient.DownloadFile("http://198.27.82.201/latestandgreatist.py", combinePath)
            MsgBox("Done! Program now useable!")
            Form2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Downloader.Show()
    End Sub
End Class
