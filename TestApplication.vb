Imports System.IO
Public Class TestApplication
    Private Sub TestApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TestApplication_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StatusLabel.Text = "Checking for updates..."
        If GitHubUpdater.Syncronous.Check() Then
            StatusLabel.Text = "This is a test application."
            GitHubUpdater.Asyncronous.DownloadAsync()
        Else
            StatusLabel.Text = "This is a test application."
        End If
    End Sub
    Private Sub TestApplication_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If File.Exists("TESTFILE.BIG") Then
            Try
                File.Delete("TESTFILE.BIG")
            Catch
            End Try
        End If
        If File.Exists("TESTFILE.SMALL") Then
            Try
                File.Delete("TESTFILE.SMALL")
            Catch
            End Try
        End If
    End Sub
End Class
