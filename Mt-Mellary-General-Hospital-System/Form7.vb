Public Class Form7

    Private Sub Critical_PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Critical_PatientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Critical_PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CriticalPatientDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CriticalPatientDataSet.Critical_Patients' table. You can move, or remove it, as needed.
        Me.Critical_PatientsTableAdapter.Fill(Me.CriticalPatientDataSet.Critical_Patients)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Critical_PatientsBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Critical_PatientsBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Critical_PatientsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Critical_PatientsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(CriticalPatientDataSet)
            MsgBox("Record was saved to the database ")
        Catch ex As Exception
            MsgBox("Error Occured, please recheck your fields")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()

    End Sub
End Class