<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_AdmissionLabel As System.Windows.Forms.Label
        Dim SicknessLabel As System.Windows.Forms.Label
        Dim TreatmentLabel As System.Windows.Forms.Label
        Dim Amount_Paid_for_TreatmentLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.AdmitedPatientsDataSet = New Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSet()
        Me.Admited_PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Admited_PatientsTableAdapter = New Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSetTableAdapters.Admited_PatientsTableAdapter()
        Me.TableAdapterManager = New Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSetTableAdapters.TableAdapterManager()
        Me.Admited_PatientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Admited_PatientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patient_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_AdmissionTextBox = New System.Windows.Forms.TextBox()
        Me.SicknessTextBox = New System.Windows.Forms.TextBox()
        Me.TreatmentTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_Paid_for_TreatmentTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Patient_NumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_AdmissionLabel = New System.Windows.Forms.Label()
        SicknessLabel = New System.Windows.Forms.Label()
        TreatmentLabel = New System.Windows.Forms.Label()
        Amount_Paid_for_TreatmentLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.AdmitedPatientsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admited_PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admited_PatientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Admited_PatientsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patient_NumberLabel
        '
        Patient_NumberLabel.AutoSize = True
        Patient_NumberLabel.BackColor = System.Drawing.Color.Transparent
        Patient_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NumberLabel.ForeColor = System.Drawing.Color.Lime
        Patient_NumberLabel.Location = New System.Drawing.Point(12, 69)
        Patient_NumberLabel.Name = "Patient_NumberLabel"
        Patient_NumberLabel.Size = New System.Drawing.Size(201, 29)
        Patient_NumberLabel.TabIndex = 1
        Patient_NumberLabel.Text = "Patient Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.Transparent
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.Color.Lime
        NameLabel.Location = New System.Drawing.Point(12, 95)
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
        SurnameLabel.Location = New System.Drawing.Point(12, 121)
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
        GenderLabel.Location = New System.Drawing.Point(12, 147)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(107, 29)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Date_of_AdmissionLabel
        '
        Date_of_AdmissionLabel.AutoSize = True
        Date_of_AdmissionLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_AdmissionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_AdmissionLabel.ForeColor = System.Drawing.Color.Lime
        Date_of_AdmissionLabel.Location = New System.Drawing.Point(12, 173)
        Date_of_AdmissionLabel.Name = "Date_of_AdmissionLabel"
        Date_of_AdmissionLabel.Size = New System.Drawing.Size(231, 29)
        Date_of_AdmissionLabel.TabIndex = 9
        Date_of_AdmissionLabel.Text = "Date of Admission:"
        '
        'SicknessLabel
        '
        SicknessLabel.AutoSize = True
        SicknessLabel.BackColor = System.Drawing.Color.Transparent
        SicknessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SicknessLabel.ForeColor = System.Drawing.Color.Lime
        SicknessLabel.Location = New System.Drawing.Point(12, 199)
        SicknessLabel.Name = "SicknessLabel"
        SicknessLabel.Size = New System.Drawing.Size(125, 29)
        SicknessLabel.TabIndex = 11
        SicknessLabel.Text = "Sickness:"
        '
        'TreatmentLabel
        '
        TreatmentLabel.AutoSize = True
        TreatmentLabel.BackColor = System.Drawing.Color.Transparent
        TreatmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreatmentLabel.ForeColor = System.Drawing.Color.Lime
        TreatmentLabel.Location = New System.Drawing.Point(12, 225)
        TreatmentLabel.Name = "TreatmentLabel"
        TreatmentLabel.Size = New System.Drawing.Size(139, 29)
        TreatmentLabel.TabIndex = 13
        TreatmentLabel.Text = "Treatment:"
        '
        'Amount_Paid_for_TreatmentLabel
        '
        Amount_Paid_for_TreatmentLabel.AutoSize = True
        Amount_Paid_for_TreatmentLabel.BackColor = System.Drawing.Color.Transparent
        Amount_Paid_for_TreatmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_Paid_for_TreatmentLabel.ForeColor = System.Drawing.Color.Lime
        Amount_Paid_for_TreatmentLabel.Location = New System.Drawing.Point(12, 251)
        Amount_Paid_for_TreatmentLabel.Name = "Amount_Paid_for_TreatmentLabel"
        Amount_Paid_for_TreatmentLabel.Size = New System.Drawing.Size(331, 29)
        Amount_Paid_for_TreatmentLabel.TabIndex = 15
        Amount_Paid_for_TreatmentLabel.Text = "Amount Paid for Treatment:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Lime
        Label1.Location = New System.Drawing.Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(261, 29)
        Label1.TabIndex = 17
        Label1.Text = "ADMITED PATIENTS"
        '
        'AdmitedPatientsDataSet
        '
        Me.AdmitedPatientsDataSet.DataSetName = "AdmitedPatientsDataSet"
        Me.AdmitedPatientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Admited_PatientsBindingSource
        '
        Me.Admited_PatientsBindingSource.DataMember = "Admited Patients"
        Me.Admited_PatientsBindingSource.DataSource = Me.AdmitedPatientsDataSet
        '
        'Admited_PatientsTableAdapter
        '
        Me.Admited_PatientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Admited_PatientsTableAdapter = Me.Admited_PatientsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Admited_PatientsBindingNavigator
        '
        Me.Admited_PatientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Admited_PatientsBindingNavigator.BindingSource = Me.Admited_PatientsBindingSource
        Me.Admited_PatientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Admited_PatientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Admited_PatientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Admited_PatientsBindingNavigatorSaveItem})
        Me.Admited_PatientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Admited_PatientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Admited_PatientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Admited_PatientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Admited_PatientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Admited_PatientsBindingNavigator.Name = "Admited_PatientsBindingNavigator"
        Me.Admited_PatientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Admited_PatientsBindingNavigator.Size = New System.Drawing.Size(601, 25)
        Me.Admited_PatientsBindingNavigator.TabIndex = 0
        Me.Admited_PatientsBindingNavigator.Text = "BindingNavigator1"
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
        'Admited_PatientsBindingNavigatorSaveItem
        '
        Me.Admited_PatientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Admited_PatientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Admited_PatientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Admited_PatientsBindingNavigatorSaveItem.Name = "Admited_PatientsBindingNavigatorSaveItem"
        Me.Admited_PatientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Admited_PatientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Patient_NumberTextBox
        '
        Me.Patient_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Patient Number", True))
        Me.Patient_NumberTextBox.Location = New System.Drawing.Point(388, 77)
        Me.Patient_NumberTextBox.Name = "Patient_NumberTextBox"
        Me.Patient_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Patient_NumberTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(388, 103)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(388, 129)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(388, 155)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'Date_of_AdmissionTextBox
        '
        Me.Date_of_AdmissionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Date of Admission", True))
        Me.Date_of_AdmissionTextBox.Location = New System.Drawing.Point(388, 181)
        Me.Date_of_AdmissionTextBox.Name = "Date_of_AdmissionTextBox"
        Me.Date_of_AdmissionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Date_of_AdmissionTextBox.TabIndex = 10
        '
        'SicknessTextBox
        '
        Me.SicknessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Sickness", True))
        Me.SicknessTextBox.Location = New System.Drawing.Point(388, 207)
        Me.SicknessTextBox.Name = "SicknessTextBox"
        Me.SicknessTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SicknessTextBox.TabIndex = 12
        '
        'TreatmentTextBox
        '
        Me.TreatmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Treatment", True))
        Me.TreatmentTextBox.Location = New System.Drawing.Point(388, 233)
        Me.TreatmentTextBox.Name = "TreatmentTextBox"
        Me.TreatmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TreatmentTextBox.TabIndex = 14
        '
        'Amount_Paid_for_TreatmentTextBox
        '
        Me.Amount_Paid_for_TreatmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Admited_PatientsBindingSource, "Amount Paid for Treatment", True))
        Me.Amount_Paid_for_TreatmentTextBox.Location = New System.Drawing.Point(388, 259)
        Me.Amount_Paid_for_TreatmentTextBox.Name = "Amount_Paid_for_TreatmentTextBox"
        Me.Amount_Paid_for_TreatmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amount_Paid_for_TreatmentTextBox.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(12, 283)
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
        Me.Button1.Location = New System.Drawing.Point(90, 283)
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
        Me.Button2.Location = New System.Drawing.Point(200, 285)
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
        Me.Button3.Location = New System.Drawing.Point(310, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 71)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = ">>>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Lime
        Me.Button7.Location = New System.Drawing.Point(385, 283)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 71)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "EXIT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mt_Mellary_General_Hospital_System.My.Resources.Resources.IMG_20200602_WA0033
        Me.ClientSize = New System.Drawing.Size(601, 366)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Patient_NumberLabel)
        Me.Controls.Add(Me.Patient_NumberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Date_of_AdmissionLabel)
        Me.Controls.Add(Me.Date_of_AdmissionTextBox)
        Me.Controls.Add(SicknessLabel)
        Me.Controls.Add(Me.SicknessTextBox)
        Me.Controls.Add(TreatmentLabel)
        Me.Controls.Add(Me.TreatmentTextBox)
        Me.Controls.Add(Amount_Paid_for_TreatmentLabel)
        Me.Controls.Add(Me.Amount_Paid_for_TreatmentTextBox)
        Me.Controls.Add(Me.Admited_PatientsBindingNavigator)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.AdmitedPatientsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admited_PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admited_PatientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Admited_PatientsBindingNavigator.ResumeLayout(False)
        Me.Admited_PatientsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmitedPatientsDataSet As Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSet
    Friend WithEvents Admited_PatientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Admited_PatientsTableAdapter As Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSetTableAdapters.Admited_PatientsTableAdapter
    Friend WithEvents TableAdapterManager As Mt_Mellary_General_Hospital_System.AdmitedPatientsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Admited_PatientsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Admited_PatientsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Patient_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_AdmissionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SicknessTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TreatmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_Paid_for_TreatmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
