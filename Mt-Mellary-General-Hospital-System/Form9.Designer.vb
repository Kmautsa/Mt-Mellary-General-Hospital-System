<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim Drug_NameLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Dim Date_ReceivedLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.StockDeliveryDataSet = New Mt_Mellary_General_Hospital_System.StockDeliveryDataSet()
        Me.Stock_DeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stock_DeliveryTableAdapter = New Mt_Mellary_General_Hospital_System.StockDeliveryDataSetTableAdapters.Stock_DeliveryTableAdapter()
        Me.TableAdapterManager = New Mt_Mellary_General_Hospital_System.StockDeliveryDataSetTableAdapters.TableAdapterManager()
        Me.Stock_DeliveryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Drug_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Date_ReceivedTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Stock_DeliveryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Product_NameLabel = New System.Windows.Forms.Label()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        Drug_NameLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Date_ReceivedLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.StockDeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_DeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_DeliveryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Stock_DeliveryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.BackColor = System.Drawing.Color.Transparent
        Product_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_NameLabel.ForeColor = System.Drawing.Color.Lime
        Product_NameLabel.Location = New System.Drawing.Point(12, 63)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(186, 29)
        Product_NameLabel.TabIndex = 1
        Product_NameLabel.Text = "Product Name:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.BackColor = System.Drawing.Color.Transparent
        Supplier_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NameLabel.ForeColor = System.Drawing.Color.Lime
        Supplier_NameLabel.Location = New System.Drawing.Point(12, 89)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.Size = New System.Drawing.Size(195, 29)
        Supplier_NameLabel.TabIndex = 3
        Supplier_NameLabel.Text = "Supplier Name:"
        '
        'Drug_NameLabel
        '
        Drug_NameLabel.AutoSize = True
        Drug_NameLabel.BackColor = System.Drawing.Color.Transparent
        Drug_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Drug_NameLabel.ForeColor = System.Drawing.Color.Lime
        Drug_NameLabel.Location = New System.Drawing.Point(12, 115)
        Drug_NameLabel.Name = "Drug_NameLabel"
        Drug_NameLabel.Size = New System.Drawing.Size(152, 29)
        Drug_NameLabel.TabIndex = 5
        Drug_NameLabel.Text = "Drug Name:"
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.BackColor = System.Drawing.Color.Transparent
        Amount_PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_PaidLabel.ForeColor = System.Drawing.Color.Lime
        Amount_PaidLabel.Location = New System.Drawing.Point(12, 141)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(167, 29)
        Amount_PaidLabel.TabIndex = 7
        Amount_PaidLabel.Text = "Amount Paid:"
        '
        'Date_ReceivedLabel
        '
        Date_ReceivedLabel.AutoSize = True
        Date_ReceivedLabel.BackColor = System.Drawing.Color.Transparent
        Date_ReceivedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_ReceivedLabel.ForeColor = System.Drawing.Color.Lime
        Date_ReceivedLabel.Location = New System.Drawing.Point(12, 167)
        Date_ReceivedLabel.Name = "Date_ReceivedLabel"
        Date_ReceivedLabel.Size = New System.Drawing.Size(191, 29)
        Date_ReceivedLabel.TabIndex = 9
        Date_ReceivedLabel.Text = "Date Received:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = System.Drawing.Color.Transparent
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.ForeColor = System.Drawing.Color.Lime
        QuantityLabel.Location = New System.Drawing.Point(12, 193)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(115, 29)
        QuantityLabel.TabIndex = 11
        QuantityLabel.Text = "Quantity:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Lime
        Label1.Location = New System.Drawing.Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(233, 29)
        Label1.TabIndex = 28
        Label1.Text = "STOCK DELIVERY"
        '
        'StockDeliveryDataSet
        '
        Me.StockDeliveryDataSet.DataSetName = "StockDeliveryDataSet"
        Me.StockDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Stock_DeliveryBindingSource
        '
        Me.Stock_DeliveryBindingSource.DataMember = "Stock Delivery"
        Me.Stock_DeliveryBindingSource.DataSource = Me.StockDeliveryDataSet
        '
        'Stock_DeliveryTableAdapter
        '
        Me.Stock_DeliveryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Stock_DeliveryTableAdapter = Me.Stock_DeliveryTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mt_Mellary_General_Hospital_System.StockDeliveryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Stock_DeliveryBindingNavigator
        '
        Me.Stock_DeliveryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Stock_DeliveryBindingNavigator.BindingSource = Me.Stock_DeliveryBindingSource
        Me.Stock_DeliveryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Stock_DeliveryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Stock_DeliveryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Stock_DeliveryBindingNavigatorSaveItem})
        Me.Stock_DeliveryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Stock_DeliveryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Stock_DeliveryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Stock_DeliveryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Stock_DeliveryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Stock_DeliveryBindingNavigator.Name = "Stock_DeliveryBindingNavigator"
        Me.Stock_DeliveryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Stock_DeliveryBindingNavigator.Size = New System.Drawing.Size(471, 25)
        Me.Stock_DeliveryBindingNavigator.TabIndex = 0
        Me.Stock_DeliveryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_DeliveryBindingSource, "Product Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(231, 71)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Product_NameTextBox.TabIndex = 2
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_DeliveryBindingSource, "Supplier Name", True))
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(231, 97)
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Supplier_NameTextBox.TabIndex = 4
        '
        'Drug_NameTextBox
        '
        Me.Drug_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_DeliveryBindingSource, "Drug Name", True))
        Me.Drug_NameTextBox.Location = New System.Drawing.Point(231, 123)
        Me.Drug_NameTextBox.Name = "Drug_NameTextBox"
        Me.Drug_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Drug_NameTextBox.TabIndex = 6
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_DeliveryBindingSource, "Amount Paid", True))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(231, 149)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amount_PaidTextBox.TabIndex = 8
        '
        'Date_ReceivedTextBox
        '
        Me.Date_ReceivedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_DeliveryBindingSource, "Date Received", True))
        Me.Date_ReceivedTextBox.Location = New System.Drawing.Point(231, 175)
        Me.Date_ReceivedTextBox.Name = "Date_ReceivedTextBox"
        Me.Date_ReceivedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_ReceivedTextBox.TabIndex = 10
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_DeliveryBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(231, 201)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 12
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Lime
        Me.Button6.Location = New System.Drawing.Point(7, 242)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 71)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "<<<"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(117, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 71)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(227, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 71)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "SAVE DATA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(350, 242)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 71)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = ">>>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(350, 146)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 71)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "EXIT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'Stock_DeliveryBindingNavigatorSaveItem
        '
        Me.Stock_DeliveryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Stock_DeliveryBindingNavigatorSaveItem.Image = CType(resources.GetObject("Stock_DeliveryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Stock_DeliveryBindingNavigatorSaveItem.Name = "Stock_DeliveryBindingNavigatorSaveItem"
        Me.Stock_DeliveryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Stock_DeliveryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mt_Mellary_General_Hospital_System.My.Resources.Resources.IMG_20200602_WA0034
        Me.ClientSize = New System.Drawing.Size(471, 325)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(Supplier_NameLabel)
        Me.Controls.Add(Me.Supplier_NameTextBox)
        Me.Controls.Add(Drug_NameLabel)
        Me.Controls.Add(Me.Drug_NameTextBox)
        Me.Controls.Add(Amount_PaidLabel)
        Me.Controls.Add(Me.Amount_PaidTextBox)
        Me.Controls.Add(Date_ReceivedLabel)
        Me.Controls.Add(Me.Date_ReceivedTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Stock_DeliveryBindingNavigator)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.StockDeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_DeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_DeliveryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Stock_DeliveryBindingNavigator.ResumeLayout(False)
        Me.Stock_DeliveryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StockDeliveryDataSet As Mt_Mellary_General_Hospital_System.StockDeliveryDataSet
    Friend WithEvents Stock_DeliveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stock_DeliveryTableAdapter As Mt_Mellary_General_Hospital_System.StockDeliveryDataSetTableAdapters.Stock_DeliveryTableAdapter
    Friend WithEvents TableAdapterManager As Mt_Mellary_General_Hospital_System.StockDeliveryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stock_DeliveryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Stock_DeliveryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Product_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Supplier_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Drug_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_PaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_ReceivedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
