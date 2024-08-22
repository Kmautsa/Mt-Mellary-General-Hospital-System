<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim Patient_NumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Drugs_to_be_TakenLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim Service_ReceivedLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.DischargedPatientDataSet = New Mt_Mellary_General_Hospital_System.DischargedPatientDataSet()
        Me.Discharged_PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Discharged_PatientTableAdapter = New Mt_Mellary_General_Hospital_System.DischargedPatientDataSetTableAdapters.Discharged_PatientTableAdapter()
        Me.TableAdapterManager = New Mt_Mellary_General_Hospital_System.DischargedPatientDataSetTableAdapters.TableAdapterManager()
        Me.Discharged_PatientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Patient_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_BirthTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Drugs_to_be_TakenTextBox = New System.Windows.Forms.TextBox()
        Me.DosageTextBox = New System.Windows.Forms.TextBox()
        Me.Service_ReceivedTextBox = New System.Windows.Forms.TextBox()
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
        Me.Discharged_PatientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Patient_NumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Drugs_to_be_TakenLabel = New System.Windows.Forms.Label()
        DosageLabel = New System.Windows.Forms.Label()
        Service_ReceivedLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DischargedPatientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Discharged_PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Discharged_PatientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Discharged_PatientBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patient_NumberLabel
        '
        Patient_NumberLabel.AutoSize = True
        Patient_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NumberLabel.ForeColor = System.Drawing.Color.Lime
        Patient_NumberLabel.Location = New System.Drawing.Point(12, 50)
        Patient_NumberLabel.Name = "Patient_NumberLabel"
        Patient_NumberLabel.Size = New System.Drawing.Size(201, 29)
        Patient_NumberLabel.TabIndex = 1
        Patient_NumberLabel.Text = "Patient Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.Color.Lime
        NameLabel.Location = New System.Drawing.Point(12, 76)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(89, 29)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Lime
        GenderLabel.Location = New System.Drawing.Point(12, 102)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(107, 29)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_BirthLabel.ForeColor = System.Drawing.Color.Lime
        Date_of_BirthLabel.Location = New System.Drawing.Point(12, 128)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(164, 29)
        Date_of_BirthLabel.TabIndex = 7
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.Color.Lime
        AddressLabel.Location = New System.Drawing.Point(12, 154)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(116, 29)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'Drugs_to_be_TakenLabel
        '
        Drugs_to_be_TakenLabel.AutoSize = True
        Drugs_to_be_TakenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Drugs_to_be_TakenLabel.ForeColor = System.Drawing.Color.Lime
        Drugs_to_be_TakenLabel.Location = New System.Drawing.Point(12, 180)
        Drugs_to_be_TakenLabel.Name = "Drugs_to_be_TakenLabel"
        Drugs_to_be_TakenLabel.Size = New System.Drawing.Size(235, 29)
        Drugs_to_be_TakenLabel.TabIndex = 11
        Drugs_to_be_TakenLabel.Text = "Drugs to be Taken:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DosageLabel.ForeColor = System.Drawing.Color.Lime
        DosageLabel.Location = New System.Drawing.Point(12, 206)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(110, 29)
        DosageLabel.TabIndex = 13
        DosageLabel.Text = "Dosage:"
        '
        'Service_ReceivedLabel
        '
        Service_ReceivedLabel.AutoSize = True
        Service_ReceivedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Service_ReceivedLabel.ForeColor = System.Drawing.Color.Lime
        Service_ReceivedLabel.Location = New System.Drawing.Point(12, 232)
        Service_ReceivedLabel.Name = "Service_ReceivedLabel"
        Service_ReceivedLabel.Size = New System.Drawing.Size(225, 29)
        Service_ReceivedLabel.TabIndex = 15
        Service_ReceivedLabel.Text = "Service Received:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Lime
        Label1.Location = New System.Drawing.Point(12, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(313, 29)
        Label1.TabIndex = 17
        Label1.Text = "DISCHARGED PATIENTS"
        '
        'DischargedPatientDataSet
        '
        Me.DischargedPatientDataSet.DataSetName = "DischargedPatientDataSet"
        Me.DischargedPatientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Discharged_PatientBindingSource
        '
        Me.Discharged_PatientBindingSource.DataMember = "Discharged Patient"
        Me.Discharged_PatientBindingSource.DataSource = Me.DischargedPatientDataSet
        '
        'Discharged_PatientTableAdapter
        '
        Me.Discharged_PatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Discharged_PatientTableAdapter = Me.Discharged_PatientTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mt_Mellary_General_Hospital_System.DischargedPatientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Discharged_PatientBindingNavigator
        '
        Me.Discharged_PatientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Discharged_PatientBindingNavigator.BindingSource = Me.Discharged_PatientBindingSource
        Me.Discharged_PatientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Discharged_PatientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Discharged_PatientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Discharged_PatientBindingNavigatorSaveItem})
        Me.Discharged_PatientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Discharged_PatientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Discharged_PatientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Discharged_PatientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Discharged_PatientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Discharged_PatientBindingNavigator.Name = "Discharged_PatientBindingNavigator"
        Me.Discharged_PatientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Discharged_PatientBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.Discharged_PatientBindingNavigator.TabIndex = 0
        Me.Discharged_PatientBindingNavigator.Text = "BindingNavigator1"
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
        'Patient_NumberTextBox
        '
        Me.Patient_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Patient Number", True))
        Me.Patient_NumberTextBox.Location = New System.Drawing.Point(274, 58)
        Me.Patient_NumberTextBox.Name = "Patient_NumberTextBox"
        Me.Patient_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Patient_NumberTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(274, 84)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(274, 110)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 6
        '
        'Date_of_BirthTextBox
        '
        Me.Date_of_BirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Date of Birth", True))
        Me.Date_of_BirthTextBox.Location = New System.Drawing.Point(274, 136)
        Me.Date_of_BirthTextBox.Name = "Date_of_BirthTextBox"
        Me.Date_of_BirthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_of_BirthTextBox.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(274, 162)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'Drugs_to_be_TakenTextBox
        '
        Me.Drugs_to_be_TakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Drugs to be Taken", True))
        Me.Drugs_to_be_TakenTextBox.Location = New System.Drawing.Point(274, 188)
        Me.Drugs_to_be_TakenTextBox.Name = "Drugs_to_be_TakenTextBox"
        Me.Drugs_to_be_TakenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Drugs_to_be_TakenTextBox.TabIndex = 12
        '
        'DosageTextBox
        '
        Me.DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Dosage", True))
        Me.DosageTextBox.Location = New System.Drawing.Point(274, 214)
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DosageTextBox.TabIndex = 14
        '
        'Service_ReceivedTextBox
        '
        Me.Service_ReceivedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Discharged_PatientBindingSource, "Service Received", True))
        Me.Service_ReceivedTextBox.Location = New System.Drawing.Point(274, 240)
        Me.Service_ReceivedTextBox.Name = "Service_ReceivedTextBox"
        Me.Service_ReceivedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Service_ReceivedTextBox.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Lime
        Me.Button6.Location = New System.Drawing.Point(20, 281)
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
        Me.Button1.Location = New System.Drawing.Point(130, 281)
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
        Me.Button2.Location = New System.Drawing.Point(240, 281)
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
        Me.Button3.Location = New System.Drawing.Point(350, 281)
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
        Me.Button7.Location = New System.Drawing.Point(380, 180)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 71)
        Me.Button7.TabIndex = 28
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
        'Discharged_PatientBindingNavigatorSaveItem
        '
        Me.Discharged_PatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Discharged_PatientBindingNavigatorSaveItem.Image = CType(resources.GetObject("Discharged_PatientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Discharged_PatientBindingNavigatorSaveItem.Name = "Discharged_PatientBindingNavigatorSaveItem"
        Me.Discharged_PatientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Discharged_PatientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mt_Mellary_General_Hospital_System.My.Resources.Resources.IMG_20200602_WA0049
        Me.ClientSize = New System.Drawing.Size(520, 364)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Patient_NumberLabel)
        Me.Controls.Add(Me.Patient_NumberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Date_of_BirthLabel)
        Me.Controls.Add(Me.Date_of_BirthTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Drugs_to_be_TakenLabel)
        Me.Controls.Add(Me.Drugs_to_be_TakenTextBox)
        Me.Controls.Add(DosageLabel)
        Me.Controls.Add(Me.DosageTextBox)
        Me.Controls.Add(Service_ReceivedLabel)
        Me.Controls.Add(Me.Service_ReceivedTextBox)
        Me.Controls.Add(Me.Discharged_PatientBindingNavigator)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.DischargedPatientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Discharged_PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Discharged_PatientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Discharged_PatientBindingNavigator.ResumeLayout(False)
        Me.Discharged_PatientBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DischargedPatientDataSet As Mt_Mellary_General_Hospital_System.DischargedPatientDataSet
    Friend WithEvents Discharged_PatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Discharged_PatientTableAdapter As Mt_Mellary_General_Hospital_System.DischargedPatientDataSetTableAdapters.Discharged_PatientTableAdapter
    Friend WithEvents TableAdapterManager As Mt_Mellary_General_Hospital_System.DischargedPatientDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Discharged_PatientBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Discharged_PatientBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Patient_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_BirthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Drugs_to_be_TakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DosageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Service_ReceivedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
