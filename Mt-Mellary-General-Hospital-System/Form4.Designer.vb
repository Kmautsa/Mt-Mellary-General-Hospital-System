<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim ID_NumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_RegistrationLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.AddDocterDataSet = New Mt_Mellary_General_Hospital_System.AddDocterDataSet()
        Me.Add_DocterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Add_DocterTableAdapter = New Mt_Mellary_General_Hospital_System.AddDocterDataSetTableAdapters.Add_DocterTableAdapter()
        Me.TableAdapterManager = New Mt_Mellary_General_Hospital_System.AddDocterDataSetTableAdapters.TableAdapterManager()
        Me.Add_DocterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Add_DocterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_RegistrationTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        ID_NumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_RegistrationLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.AddDocterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_DocterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_DocterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Add_DocterBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.BackColor = System.Drawing.Color.Transparent
        ID_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_NumberLabel.ForeColor = System.Drawing.Color.Lime
        ID_NumberLabel.Location = New System.Drawing.Point(12, 49)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(145, 29)
        ID_NumberLabel.TabIndex = 1
        ID_NumberLabel.Text = "ID Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.Color.Lime
        NameLabel.Location = New System.Drawing.Point(12, 75)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(89, 29)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.BackColor = System.Drawing.Color.Transparent
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.ForeColor = System.Drawing.Color.Lime
        SurnameLabel.Location = New System.Drawing.Point(12, 101)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(124, 29)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Lime
        GenderLabel.Location = New System.Drawing.Point(12, 127)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(107, 29)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Date_of_RegistrationLabel
        '
        Date_of_RegistrationLabel.AutoSize = True
        Date_of_RegistrationLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_RegistrationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_RegistrationLabel.ForeColor = System.Drawing.Color.Lime
        Date_of_RegistrationLabel.Location = New System.Drawing.Point(12, 153)
        Date_of_RegistrationLabel.Name = "Date_of_RegistrationLabel"
        Date_of_RegistrationLabel.Size = New System.Drawing.Size(251, 29)
        Date_of_RegistrationLabel.TabIndex = 9
        Date_of_RegistrationLabel.Text = "Date of Registration:"
        AddHandler Date_of_RegistrationLabel.Click, AddressOf Me.Date_of_RegistrationLabel_Click
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Lime
        Label1.Location = New System.Drawing.Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(180, 29)
        Label1.TabIndex = 27
        Label1.Text = "ADD DOCTER"
        '
        'AddDocterDataSet
        '
        Me.AddDocterDataSet.DataSetName = "AddDocterDataSet"
        Me.AddDocterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add_DocterBindingSource
        '
        Me.Add_DocterBindingSource.DataMember = "Add Docter"
        Me.Add_DocterBindingSource.DataSource = Me.AddDocterDataSet
        '
        'Add_DocterTableAdapter
        '
        Me.Add_DocterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_DocterTableAdapter = Me.Add_DocterTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Mt_Mellary_General_Hospital_System.AddDocterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Add_DocterBindingNavigator
        '
        Me.Add_DocterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Add_DocterBindingNavigator.BindingSource = Me.Add_DocterBindingSource
        Me.Add_DocterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Add_DocterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Add_DocterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Add_DocterBindingNavigatorSaveItem})
        Me.Add_DocterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Add_DocterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Add_DocterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Add_DocterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Add_DocterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Add_DocterBindingNavigator.Name = "Add_DocterBindingNavigator"
        Me.Add_DocterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Add_DocterBindingNavigator.Size = New System.Drawing.Size(674, 25)
        Me.Add_DocterBindingNavigator.TabIndex = 0
        Me.Add_DocterBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Add_DocterBindingNavigatorSaveItem
        '
        Me.Add_DocterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add_DocterBindingNavigatorSaveItem.Image = CType(resources.GetObject("Add_DocterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Add_DocterBindingNavigatorSaveItem.Name = "Add_DocterBindingNavigatorSaveItem"
        Me.Add_DocterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Add_DocterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_NumberTextBox
        '
        Me.ID_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_DocterBindingSource, "ID Number", True))
        Me.ID_NumberTextBox.ForeColor = System.Drawing.Color.Lime
        Me.ID_NumberTextBox.Location = New System.Drawing.Point(308, 49)
        Me.ID_NumberTextBox.Name = "ID_NumberTextBox"
        Me.ID_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_NumberTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_DocterBindingSource, "Name", True))
        Me.NameTextBox.ForeColor = System.Drawing.Color.Lime
        Me.NameTextBox.Location = New System.Drawing.Point(308, 75)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_DocterBindingSource, "Surname", True))
        Me.SurnameTextBox.ForeColor = System.Drawing.Color.Lime
        Me.SurnameTextBox.Location = New System.Drawing.Point(308, 101)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_DocterBindingSource, "Gender", True))
        Me.GenderTextBox.ForeColor = System.Drawing.Color.Lime
        Me.GenderTextBox.Location = New System.Drawing.Point(308, 127)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'Date_of_RegistrationTextBox
        '
        Me.Date_of_RegistrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_DocterBindingSource, "Date of Registration", True))
        Me.Date_of_RegistrationTextBox.ForeColor = System.Drawing.Color.Lime
        Me.Date_of_RegistrationTextBox.Location = New System.Drawing.Point(308, 153)
        Me.Date_of_RegistrationTextBox.Name = "Date_of_RegistrationTextBox"
        Me.Date_of_RegistrationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_of_RegistrationTextBox.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(12, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 71)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "<<<"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(90, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 71)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(200, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 71)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "SAVE DATA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(310, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 71)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = ">>>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(391, 211)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 71)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mt_Mellary_General_Hospital_System.My.Resources.Resources.IMG_20200602_WA0043
        Me.ClientSize = New System.Drawing.Size(674, 387)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(ID_NumberLabel)
        Me.Controls.Add(Me.ID_NumberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Date_of_RegistrationLabel)
        Me.Controls.Add(Me.Date_of_RegistrationTextBox)
        Me.Controls.Add(Me.Add_DocterBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.AddDocterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_DocterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_DocterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Add_DocterBindingNavigator.ResumeLayout(False)
        Me.Add_DocterBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddDocterDataSet As Mt_Mellary_General_Hospital_System.AddDocterDataSet
    Friend WithEvents Add_DocterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_DocterTableAdapter As Mt_Mellary_General_Hospital_System.AddDocterDataSetTableAdapters.Add_DocterTableAdapter
    Friend WithEvents TableAdapterManager As Mt_Mellary_General_Hospital_System.AddDocterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Add_DocterBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Add_DocterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_RegistrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
