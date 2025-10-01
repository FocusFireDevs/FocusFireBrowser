Imports Microsoft.Web.WebView2.WinForms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView1.Enabled = True
        WebView1.Visible = True
    End Sub

    Private Sub Tab1_Click(sender As Object, e As EventArgs) Handles Tab1.Click
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView1.Enabled = True
        WebView1.Visible = True
    End Sub

    Private Sub Tab2_Click(sender As Object, e As EventArgs) Handles Tab2.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView2.Visible = True
        WebView2.Enabled = True
    End Sub

    Private Sub Tab3_Click(sender As Object, e As EventArgs) Handles Tab3.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView3.Visible = True
        WebView3.Enabled = True
    End Sub

    Private Sub Tab4_Click(sender As Object, e As EventArgs) Handles Tab4.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = True
        WebView4.Enabled = True
    End Sub

    Private Sub Search_KeyUp(sender As Object, e As KeyEventArgs) Handles Search.KeyUp
        If e.KeyCode = Keys.Enter Then
            WebView1.Source = New Uri("https://ghosterysearch.com/search?q=" + Search.Text)
            WebView2.Source = New Uri("https://ghosterysearch.com/search?q=" + Search.Text)
            WebView3.Source = New Uri("https://ghosterysearch.com/search?q=" + Search.Text)
            WebView4.Source = New Uri("https://ghosterysearch.com/search?q=" + Search.Text)
        End If
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        WebView1.Source = New Uri("https://ghosterysearch.com/")
        WebView2.Source = New Uri("https://ghosterysearch.com/")
        WebView3.Source = New Uri("https://ghosterysearch.com/")
        WebView4.Source = New Uri("https://ghosterysearch.com/")
    End Sub

    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles Reload.Click
        WebView1.Reload()
        WebView2.Reload()
        WebView3.Reload()
        WebView4.Reload()
    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        WebView1.GoForward()
        WebView2.GoForward()
        WebView3.GoForward()
        WebView4.GoForward()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        WebView1.GoBack()
        WebView2.GoBack()
        WebView3.GoBack()
        WebView4.GoBack()
    End Sub

    Private Sub MS_Click(sender As Object, e As EventArgs) Handles MS.Click
        ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle
        ActiveForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FS_Click(sender As Object, e As EventArgs) Handles FS.Click
        ActiveForm.WindowState = FormWindowState.Normal
        ActiveForm.FormBorderStyle = FormBorderStyle.None
        ActiveForm.WindowState = FormWindowState.Maximized
    End Sub
End Class