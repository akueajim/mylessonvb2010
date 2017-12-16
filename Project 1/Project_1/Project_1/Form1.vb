Public Class Form1

    Private Sub btnSelectPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPicture.Click
        'conditional statement to open dialog box
        If ofdSelectPicture.ShowDialog = DialogResult.OK Then
            ' if user are open the dialogbox and select the images then load
            ' the images to picturebox
            picPictureBox.Image = Image.FromFile(ofdSelectPicture.FileName)
            ' display name program and path file at title bar
            Me.Text = "Picture Viewer (" & ofdSelectPicture.FileName & ")"
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'terminating the program
        Me.Close()
    End Sub
End Class
