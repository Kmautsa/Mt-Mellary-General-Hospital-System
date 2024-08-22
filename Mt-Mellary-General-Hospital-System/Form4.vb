Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AddDocterDataSet.Add_Docter' table. You can move, or remove it, as needed.
        Me.Add_DocterTableAdapter.Fill(Me.AddDocterDataSet.Add_Docter)

    End Sub

    Private Sub Add_DocterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Add_DocterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Add_DocterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddDocterDataSet)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Add_DocterBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Add_DocterBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add_DocterBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Add_DocterBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(AddDocterDataSet)
            MsgBox("Record was successfully saved to the database")
        Catch ex As Exception
            MsgBox("Error occured, please recheck your fields")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Date_of_RegistrationLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class