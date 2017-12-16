<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSelectPicture = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picPictureBox = New System.Windows.Forms.PictureBox()
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        CType(Me.picPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Location = New System.Drawing.Point(295, 10)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(85, 23)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Select Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(295, 40)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picPictureBox
        '
        Me.picPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPictureBox.Location = New System.Drawing.Point(8, 8)
        Me.picPictureBox.Name = "picPictureBox"
        Me.picPictureBox.Size = New System.Drawing.Size(282, 376)
        Me.picPictureBox.TabIndex = 2
        Me.picPictureBox.TabStop = False
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP|JPEG Files|*.JPG"
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Location = New System.Drawing.Point(338, 361)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(21, 23)
        Me.btnEnlarge.TabIndex = 3
        Me.btnEnlarge.Text = "^"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnShrink
        '
        Me.btnShrink.Location = New System.Drawing.Point(359, 361)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(21, 23)
        Me.btnShrink.TabIndex = 4
        Me.btnShrink.Text = "v"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 392)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.picPictureBox)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelectPicture As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents picPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ofdSelectPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnEnlarge As System.Windows.Forms.Button
    Friend WithEvents btnShrink As System.Windows.Forms.Button

End Class
