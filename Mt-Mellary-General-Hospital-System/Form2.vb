Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String

        Username = TextBox1.Text
        Password = TextBox2.Text
        If Username = "" And Password = "" Then
            MsgBox("Please enter your username and your Password to Login ")
        ElseIf Username = "" Then
            MsgBox("Please enter your Username")
        ElseIf Password = "" Then
            MsgBox("Please enter your Password")
        ElseIf Username = "Admin" And Password = "kk" Then
            MsgBox("You have logged in the system")
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Error occured, Please enter correct Username or Password")
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class