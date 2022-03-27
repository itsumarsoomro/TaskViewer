Public Class Dashboard
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        'Transparent panel code

        Panel2.BackColor = Color.FromArgb(100, 255, 192, 128)
    End Sub



    Sub switchPanel(ByVal panel As Form)
        'Switiching panel code 

        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchPanel(weektask)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        switchPanel(calendar)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        switchPanel(history)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchPanel(dailytasker)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        'Logout button
        Me.Hide()
        Home.Show()

    End Sub

    'Menun strip buttons

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Me.Close()

    End Sub

    Private Sub formHome_Click(sender As Object, e As EventArgs) Handles formHome.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub formRegister_Click(sender As Object, e As EventArgs) Handles formRegister.Click
        Registration.Show()
        Me.Hide()


    End Sub

    Private Sub formLogin_Click(sender As Object, e As EventArgs) Handles formLogin.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub formAbout_Click(sender As Object, e As EventArgs) Handles formAbout.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub helpAbout_Click(sender As Object, e As EventArgs) Handles helpAbout.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub helpView_Click(sender As Object, e As EventArgs) Handles helpView.Click
        Help.Show()
        Me.Hide()

    End Sub

    Private Sub openFD_Click(sender As Object, e As EventArgs) Handles menuFD.Click
        openFD.InitialDirectory = “C:\Users\hp\Desktop\taskviewerlast”
        openFD.ShowDialog()
    End Sub
End Class