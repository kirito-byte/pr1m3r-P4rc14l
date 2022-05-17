Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, r As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a > b Then
            If a > c Then
                GoTo a_mayor
            Else
                GoTo c_mayor
            End If
        Else
            If b > c Then
                GoTo b_mayor
            Else
                GoTo c_mayor
            End If
        End If
a_mayor:
        TextBox4.Text = "El numero mayor es a"
        GoTo final
b_mayor:
        TextBox4.Text = "El numero mayor es b "
        GoTo final
c_mayor:
        TextBox4.Text = "El numero mayor es c"
        GoTo final
final:
    End Sub

End Class
