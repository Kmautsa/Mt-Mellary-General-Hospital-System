Public Class Form6

    Private Sub Admited_PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Admited_PatientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Admited_PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdmitedPatientsDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdmitedPatientsDataSet.Admited_Patients' table. You can move, or remove it, as needed.
        Me.Admited_PatientsTableAdapter.Fill(Me.AdmitedPatientsDataSet.Admited_Patients)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admited_PatientsBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Admited_PatientsBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admited_PatientsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Admited_PatientsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(AdmitedPatientsDataSet)
            MsgBox("Record was saved  to the database")
        Catch ex As Exception
            MsgBox("Error occured, please recheck your fields")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub
End Class