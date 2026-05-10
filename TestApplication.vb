Imports System.IO
Public Class TestApplication
    Private Sub TestApplication_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If GitHubUpdater.Check() Then GitHubUpdater.Download()
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
