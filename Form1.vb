Imports Microsoft.Web.WebView2.WinForms

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebView1.GoBack()
        WebView2.GoBack()
        WebView3.GoBack()
        WebView4.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebView1.GoForward()
        WebView2.GoForward()
        WebView3.GoForward()
        WebView4.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebView1.Reload()
        WebView2.Reload()
        WebView3.Reload()
        WebView4.Reload()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebView1.Source = New Uri("https://start.duckduckgo.com/")
        WebView2.Source = New Uri("https://start.duckduckgo.com/")
        WebView3.Source = New Uri("https://start.duckduckgo.com/")
        WebView4.Source = New Uri("https://start.duckduckgo.com/")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ActiveForm.WindowState = FormWindowState.Maximized
        ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ActiveForm.WindowState = FormWindowState.Normal
        ActiveForm.FormBorderStyle = FormBorderStyle.None
        ActiveForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView1.Enabled = True
        WebView1.Visible = True
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView2.Visible = True
        WebView2.Enabled = True
    End Sub

    Private Sub OpenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView4.Visible = False
        WebView4.Enabled = False
        WebView3.Visible = True
        WebView3.Enabled = True
    End Sub

    Private Sub OpenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        WebView1.Visible = False
        WebView1.Enabled = False
        WebView2.Visible = False
        WebView2.Enabled = False
        WebView3.Visible = False
        WebView3.Enabled = False
        WebView4.Visible = True
        WebView4.Enabled = True
    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        Tab1ToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub CancelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Tab1ToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub CancelToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Tab1ToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub Tab4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Tab1ToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Form1_Load(sender, e, Label2, GetLabel1(), GetLabel3(), GetLabel4())
    End Sub

    Private Function GetLabel1() As Label
        Return Label1
    End Function

    Private Function GetLabel3() As Label
        Return Label3
    End Function

    Private Function GetLabel4() As Label
        Return Label4
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs, label2 As Label, label1 As Label, label3 As Label, label4 As Label)
        label1.Text = WebView1.Source.ToString
        label2.Text = WebView2.Source.ToString
        label3.Text = WebView3.Source.ToString
        label4.Text = WebView4.Source.ToString
    End Sub
End Class