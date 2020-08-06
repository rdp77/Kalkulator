Public Class Form1

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Bil1 As Integer
        Dim Bil2 As Integer

        Bil1 = Val(TextBox1.Text)
        Bil2 = Val(TextBox2.Text)

        If RadioButton1.Checked = True Then
            TextBox3.Text = Bil1 + Bil2
        End If

        If RadioButton2.Checked = True Then
            TextBox3.Text = Bil1 - Bil2
        End If

        If RadioButton3.Checked = True Then
            TextBox3.Text = Bil1 * Bil2
        End If

        If RadioButton4.Checked = True Then
            TextBox3.Text = Bil1 / Bil2
        End If

        If RadioButton5.Checked = True Then
            TextBox3.Text = Bil1 \ Bil2
        End If

        If RadioButton6.Checked = True Then
            TextBox3.Text = Bil1 ^ Bil2
        End If

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Isi Bilangan 1 Dan 2 Sebelum Menghitung")
        End If

    End Sub
End Class
