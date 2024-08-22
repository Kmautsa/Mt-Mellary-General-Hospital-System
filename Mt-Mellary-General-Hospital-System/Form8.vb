Public Class Form8

    Private Sub Discharged_PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Discharged_PatientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Discharged_PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DischargedPatientDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DischargedPatientDataSet.Discharged_Patient' table. You can move, or remove it, as needed.
        Me.Discharged_PatientTableAdapter.Fill(Me.DischargedPatientDataSet.Discharged_Patient)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Discharged_PatientBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Discharged_PatientBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Discharged_PatientBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Discharged_PatientBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DischargedPatientDataSet)
            MsgBox("Record was saved to the database")
        Catch ex As Exception
            MsgBox("Error occured,please recheck your fields ")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()

    End Sub
End Class