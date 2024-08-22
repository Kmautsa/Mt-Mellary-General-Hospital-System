<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.AddNurseDataSet = New Mt_Mellary_General_Hospital_System.AddNurseDataSet()
        Me.Add_NurseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Add_NurseTableAdapter = New Mt_Mellary_General_Hospital_System.AddNurseDataSetTableAdapters.Add_NurseTableAdapter()
        Me.TableAdapterManager = New Mt_Mellary_General_Hospital_System.AddNurseDataSetTableAdapters.TableAdapterManager()
        Me.Add_NurseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ID_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_RegistrationTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Add_NurseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        ID_NumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_RegistrationLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.AddNurseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_NurseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_NurseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Add_NurseBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.BackColor = System.Drawing.Color.Transparent
        ID_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_NumberLabel.ForeColor = System.Drawing.Color.Lime
        ID_NumberLabel.Location = New System.Drawing.Point(12, 54)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(129, 25)
        ID_NumberLabel.TabIndex = 1
        ID_NumberLabel.Text = "ID Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.Color.Lime
        NameLabel.Location = New System.Drawing.Point(12, 80)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(79, 25)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.BackColor = System.Drawing.Color.Transparent
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.ForeColor = System.Drawing.Color.Lime
        SurnameLabel.Location = New System.Drawing.Point(12, 106)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(112, 25)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Lime
        GenderLabel.Location = New System.Drawing.Point(12, 132)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(96, 25)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Date_of_RegistrationLabel
        '
        Date_of_RegistrationLabel.AutoSize = True
        Date_of_RegistrationLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_RegistrationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_RegistrationLabel.ForeColor = System.Drawing.Color.Lime
        Date_of_RegistrationLabel.Location = New System.Drawing.Point(12, 158)
        Date_of_RegistrationLabel.Name = "Date_of_RegistrationLabel"
        Date_of_RegistrationLabel.Size = New System.Drawing.Size(229, 25)
        Date_of_RegistrationLabel.TabIndex = 9
        Date_of_RegistrationLabel.Text = "Date of Registration:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Lime
        Label1.Location = New System.Drawing.Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(161, 29)
        Label1.TabIndex = 11
        Label1.Text = "ADD NURSE"
        '
        'AddNurseDataSet
        '
        Me.AddNurseDataSet.DataSetName = "AddNurseDataSet"
        Me.AddNurseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add_NurseBindingSource
        '
        Me.Add_NurseBindingSource.DataMember = "Add Nurse"
        Me.Add_NurseBindingSource.DataSource = Me.AddNurseDataSet
        '
        'Add_NurseTableAdapter
        '
        Me.Add_NurseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_NurseTableAdapter = Me.Add_NurseTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Mt_Mellary_General_Hospital_System.AddNurseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Add_NurseBindingNavigator
        '
        Me.Add_NurseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Add_NurseBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.Add_NurseBindingNavigator.BindingSource = Me.Add_NurseBindingSource
        Me.Add_NurseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Add_NurseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Add_NurseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Add_NurseBindingNavigatorSaveItem})
        Me.Add_NurseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Add_NurseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Add_NurseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Add_NurseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Add_NurseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Add_NurseBindingNavigator.Name = "Add_NurseBindingNavigator"
        Me.Add_NurseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Add_NurseBindingNavigator.Size = New System.Drawing.Size(676, 25)
        Me.Add_NurseBindingNavigator.TabIndex = 0
        Me.Add_NurseBindingNavigator.Text = "BindingNavigator1"
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
        'ID_NumberTextBox
        '
        Me.ID_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_NurseBindingSource, "ID Number", True))
        Me.ID_NumberTextBox.Location = New System.Drawing.Point(285, 54)
        Me.ID_NumberTextBox.Name = "ID_NumberTextBox"
        Me.ID_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_NumberTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_NurseBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(285, 80)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_NurseBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(285, 106)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_NurseBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(285, 132)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'Date_of_RegistrationTextBox
        '
        Me.Date_of_RegistrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Add_NurseBindingSource, "Date of Registration", True))
        Me.Date_of_RegistrationTextBox.Location = New System.Drawing.Point(285, 158)
        Me.Date_of_RegistrationTextBox.Name = "Date_of_RegistrationTextBox"
        Me.Date_of_RegistrationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_of_RegistrationTextBox.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(17, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 71)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "<<<"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(91, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 71)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(201, 202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 71)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "SAVE DATA"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(311, 202)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 71)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = ">>>"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(391, 202)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 71)
        Me.Button7.TabIndex = 25
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
        'Add_NurseBindingNavigatorSaveItem
        '
        Me.Add_NurseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Add_NurseBindingNavigatorSaveItem.Image = CType(resources.GetObject("Add_NurseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Add_NurseBindingNavigatorSaveItem.Name = "Add_NurseBindingNavigatorSaveItem"
        Me.Add_NurseBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Add_NurseBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mt_Mellary_General_Hospital_System.My.Resources.Resources.IMG_20200602_WA0043
        Me.ClientSize = New System.Drawing.Size(676, 401)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label1)
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
        Me.Controls.Add(Me.Add_NurseBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.AddNurseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_NurseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_NurseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Add_NurseBindingNavigator.ResumeLayout(False)
        Me.Add_NurseBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddNurseDataSet As Mt_Mellary_General_Hospital_System.AddNurseDataSet
    Friend WithEvents Add_NurseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_NurseTableAdapter As Mt_Mellary_General_Hospital_System.AddNurseDataSetTableAdapters.Add_NurseTableAdapter
    Friend WithEvents TableAdapterManager As Mt_Mellary_General_Hospital_System.AddNurseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Add_NurseBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Add_NurseBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_RegistrationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
