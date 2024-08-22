Public Class Form9

    Private Sub Stock_DeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Stock_DeliveryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Stock_DeliveryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StockDeliveryDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDeliveryDataSet.Stock_Delivery' table. You can move, or remove it, as needed.
        Me.Stock_DeliveryTableAdapter.Fill(Me.StockDeliveryDataSet.Stock_Delivery)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Stock_DeliveryBindingSource.MovePrevious()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Stock_DeliveryBindingSource.MoveNext()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Stock_DeliveryBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Stock_DeliveryBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(StockDeliveryDataSet)
            MsgBox("Record was saved to database")
        Catch ex As Exception
            MsgBox("Error occured, please recheck your fields")
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()

    End Sub
End Class