Imports CefSharp

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
        WebView1.LoadUrl("https://focusfiresearch.pages.dev/")
        WebView2.LoadUrl("https://focusfiresearch.pages.dev/")
        WebView3.LoadUrl("https://focusfiresearch.pages.dev/")
        WebView4.LoadUrl("https://focusfiresearch.pages.dev/")
    End Sub

    Private Sub Tab1_Click(sender As Object, e As EventArgs) Handles Tab1.Click
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView1.Enabled = True
        WebView1.Visible = True
    End Sub

    Private Sub Tab2_Click(sender As Object, e As EventArgs) Handles Tab2.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView2.Visible = True
        WebView2.Enabled = True
    End Sub

    Private Sub Tab3_Click(sender As Object, e As EventArgs) Handles Tab3.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
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
        WebView3.Visible = True
        WebView3.Enabled = True
    End Sub

    Private Sub Search_KeyUp(sender As Object, e As KeyEventArgs) Handles Search.KeyUp
        If e.KeyCode = Keys.Enter Then
            WebView1.LoadUrl("https://ghosterysearch.com/search?q=" + Search.Text)
            WebView2.LoadUrl("https://ghosterysearch.com/search?q=" + Search.Text)
            WebView3.LoadUrl("https://ghosterysearch.com/search?q=" + Search.Text)
            WebView4.LoadUrl("https://ghosterysearch.com/search?q=" + Search.Text)
        End If
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        WebView1.LoadUrl("https://ghosterysearch.com/")
        WebView2.LoadUrl("https://ghosterysearch.com/")
        WebView3.LoadUrl("https://ghosterysearch.com/")
        WebView4.LoadUrl("https://ghosterysearch.com/")
    End Sub

    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles Reload.Click
        WebView1.Reload
        WebView2.Reload
        WebView3.Reload
        WebView3.Reload
    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        If WebView1.CanGoForward Then
            WebView1.Forward
        End If
        If WebView2.CanGoForward Then
            WebView2.Forward
        End If
        If WebView3.CanGoForward Then
            WebView3.Forward
        End If
        If WebView4.CanGoForward Then
            WebView4.Forward
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        If WebView1.CanGoBack Then
            WebView1.Back
        End If
        If WebView2.CanGoBack Then
            WebView2.Back
        End If
        If WebView3.CanGoBack Then
            WebView3.Back
        End If
        If WebView4.CanGoBack Then
            WebView4.Back
        End If
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