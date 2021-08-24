Public Class Form1
    Private Shared TabControl1 As Object

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' WebBrowser.Navigate()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Navigate("https://www.google.com/")

    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()
    End Sub





    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim newPage As New TabPage()
        newPage.Text = "New Tab"
        TabControl2.TabPages.Add(newPage)
        Dim WebBrowswer1 As New WebBrowser()
        WebBrowswer1.Dock = DockStyle.Fill
        newPage.Controls.Add(WebBrowser1)
        TabControl2.SelectedTab = newPage
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TabControl2.SelectedTab IsNot Nothing Then
            TabControl2.TabPages.Remove(TabControl2.SelectedTab)
        End If
    End Sub
End Class