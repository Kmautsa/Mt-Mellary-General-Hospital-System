Public Class Form5

    Private Sub Add_NurseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Add_NurseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Add_NurseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddNurseDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AddNurseDataSet.Add_Nurse' table. You can move, or remove it, as needed.
        Me.Add_NurseTableAdapter.Fill(Me.AddNurseDataSet.Add_Nurse)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add_NurseBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Add_NurseBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(AddNurseDataSet)
            MsgBox("Record successfully saved to the database")
        Catch ex As Exception
            MsgBox("Error occured,Please recheck your fields")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Add_NurseBindingSource.MoveNext()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Add_NurseBindingSource.MovePrevious()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub
End Class