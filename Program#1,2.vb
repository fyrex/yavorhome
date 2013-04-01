Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As Integer
        username = TextBox1.Text
        password = TextBox2.Text
        If username = "fyrex" And password = "12345" Then
            Label3.Text = "Log In Successful"
        Else
            Label3.Text = "You have entered incorrect details. Please try again."
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num1, num2 As Double
        num1 = TextBox3.Text
        num2 = TextBox4.Text
        TextBox5.Text = num1 + num2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim num1, num2 As Double
        num1 = TextBox3.Text
        num2 = TextBox4.Text
        TextBox5.Text = num1 - num2
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim num1, num2 As Double
        num1 = TextBox3.Text
        num2 = TextBox4.Text
        TextBox5.Text = num1 * num2
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim num1, num2 As Double
        num1 = TextBox3.Text
        num2 = TextBox4.Text
        TextBox5.Text = num1 / num2
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
