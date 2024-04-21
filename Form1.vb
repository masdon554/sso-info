Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.BackColor = Color.Transparent
        GroupBox2.BackColor = Color.Transparent
        GroupBox1.ForeColor = Color.White
        GroupBox2.ForeColor = Color.White

        'First Condition
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button3.Text = "Object 1"
        Button4.Text = "Object 2"
        Button5.Text = "Object 3"
        Button6.Text = "Object 4"
        Button7.Text = "Object 5"
        Button8.Text = "Object 6"
        Button9.Text = "Object 7"
        Button10.Text = "Object 8"

        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False

        Button1.Enabled = False
        'button 2 is useless
        Button2.Enabled = False
        Button2.Visible = False
        'special object appearn
        Label1.Text = "OBJECT NAME"
        TextBox1.Text = "OBJECT NAME"
        PictureBox1.Image = Nothing
        TextBox1.Enabled = False


        GroupBox2.ForeColor = Color.Black



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True And RadioButton2.Checked = False Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            Button1.Enabled = True

            'STAR LIST
            Button3.Enabled = True
            Button3.Text = "The Sun"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            'PLANET LIST
            'Text Change
            Button3.Text = "Mercury"
            Button4.Text = "Venus"
            Button5.Text = "Earth"
            Button6.Text = "Mars"
            Button7.Text = "Jupiter"
            Button8.Text = "Saturn"
            Button9.Text = "Uranus"
            Button10.Text = "Neptune"
            
            'Enable = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CLEAR ALL
        Button2.Enabled = False

        PictureBox1.Image = Nothing
        RadioButton1.Checked = False
        RadioButton1.Enabled = True
        RadioButton2.Checked = False
        RadioButton2.Enabled = True

        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False

        Button3.Text = "Object 1"
        Button4.Text = "Object 2"
        Button5.Text = "Object 3"
        Button6.Text = "Object 4"
        Button7.Text = "Object 5"
        Button8.Text = "Object 6"
        Button9.Text = "Object 7"
        Button10.Text = "Object 8"

        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'CLEAR OBJECT
        PictureBox1.Image = Nothing
        Label1.Text = ""
        TextBox1.Text = ""
        Button2.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True And RadioButton2.Checked = False Then
            TextBox1.Text = Button3.Text
            Label1.Text = Button3.Text
            PictureBox1.Image = My.Resources.sun
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            TextBox1.Visible = True
            Label1.Visible = True
            PictureBox1.Visible = True
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button3.Text
            Label1.Text = Button3.Text
            PictureBox1.Image = My.Resources.mercury
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button4.Text
            Label1.Text = Button4.Text
            PictureBox1.Image = My.Resources.venus
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button5.Text
            Label1.Text = Button5.Text
            PictureBox1.Image = My.Resources.earth
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button6.Text
            Label1.Text = Button6.Text
            PictureBox1.Image = My.Resources.mars
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button7.Text
            Label1.Text = Button7.Text
            PictureBox1.Image = My.Resources.jupiter
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button8.Text
            Label1.Text = Button8.Text
            PictureBox1.Image = My.Resources.saturn
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button9.Text
            Label1.Text = Button9.Text
            PictureBox1.Image = My.Resources.uranus
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = True Then
            TextBox1.Text = Button10.Text
            Label1.Text = Button10.Text
            PictureBox1.Image = My.Resources.neptune
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MessageBox.Show("Thank's For Use Our Simple Application Desktop!. This application is create by @masdon554 (github user)")
    End Sub
End Class
