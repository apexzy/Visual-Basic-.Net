Public Class Form

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Label1 As Integer
        Dim Label2 As Integer
        Dim Result As String
        Dim OfficialResult As String

        Label1 = Integer.Parse(TextBox1.Text)
        Label2 = Integer.Parse(TextBox2.Text)
        Result = Label1 + Label2
        OfficialResult = ("The Answer is:")
        MessageBox.Show(OfficialResult + " " + Result)
        TextBox1.Text = " "
        TextBox2.Text = " "

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Label1 As Integer
        Dim Label2 As Integer
        Dim Result As String
        Dim OfficialResult As String

        Label1 = Integer.Parse(TextBox1.Text)
        Label2 = Integer.Parse(TextBox2.Text)
        Result = Label1 - Label2
        OfficialResult = ("The Answer is:")
        MessageBox.Show(OfficialResult + Result)
        TextBox1.Text = " "
        TextBox2.Text = " "

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Label1 As Integer
        Dim Label2 As Integer
        Dim Result As String
        Dim OfficialResult As String

        Label1 = Integer.Parse(TextBox1.Text)
        Label2 = Integer.Parse(TextBox2.Text)
        Result = Label1 * Label2
        OfficialResult = ("The Answer is:")
        MessageBox.Show(OfficialResult + Result)
        TextBox1.Text = " "
        TextBox2.Text = " "

    End Sub
End Class
