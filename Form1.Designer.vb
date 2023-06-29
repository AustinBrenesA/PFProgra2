<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblID = New System.Windows.Forms.Label()
        Me.GpbDatos = New System.Windows.Forms.GroupBox()
        Me.lBLtIPO = New System.Windows.Forms.Label()
        Me.Cmbtipoid = New System.Windows.Forms.ComboBox()
        Me.TxtNotaQ1 = New System.Windows.Forms.TextBox()
        Me.TxtNotaQ2 = New System.Windows.Forms.TextBox()
        Me.TxtNotaProyecto = New System.Windows.Forms.TextBox()
        Me.TxtNotaP2 = New System.Windows.Forms.TextBox()
        Me.TxtNotaP1 = New System.Windows.Forms.TextBox()
        Me.Txt2Apellido = New System.Windows.Forms.TextBox()
        Me.Txt1Apellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.MskID = New System.Windows.Forms.MaskedTextBox()
        Me.LblNotaProyecto = New System.Windows.Forms.Label()
        Me.LblNotaQuiz2 = New System.Windows.Forms.Label()
        Me.LblNotaQuiz1 = New System.Windows.Forms.Label()
        Me.LblNota2 = New System.Windows.Forms.Label()
        Me.LblNota1 = New System.Windows.Forms.Label()
        Me.Lbl2Apellido = New System.Windows.Forms.Label()
        Me.Lbl1Apellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GpbEstado = New System.Windows.Forms.GroupBox()
        Me.TxtEstadoFinalShow = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNotaFinalShow = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TIPO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDENTIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAPARCIAL1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAPARCIAL2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAQUIZ1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAQUIZ2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAPROYECTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTAFINALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADOFINALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTUDIANTENOTABindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_EstudiantesDataSet4 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet4()
        Me.ESTUDIANTENOTABindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_EstudiantesDataSet3 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet3()
        Me.ESTUDIANTENOTABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_EstudiantesDataSet2 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet2()
        Me.ESTUDIANTENOTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_EstudiantesDataSet1 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet1()
        Me.RegistroEstudiantesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_EstudiantesDataSet = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.ESTUDIANTE_NOTATableAdapter = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet1TableAdapters.ESTUDIANTE_NOTATableAdapter()
        Me.ESTUDIANTE_NOTATableAdapter1 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet2TableAdapters.ESTUDIANTE_NOTATableAdapter()
        Me.ESTUDIANTE_NOTATableAdapter2 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet3TableAdapters.ESTUDIANTE_NOTATableAdapter()
        Me.ESTUDIANTE_NOTATableAdapter3 = New Proyecto_Final_Austin_Brenes.Registro_EstudiantesDataSet4TableAdapters.ESTUDIANTE_NOTATableAdapter()
        Me.GpbDatos.SuspendLayout()
        Me.GpbEstado.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTUDIANTENOTABindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_EstudiantesDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTUDIANTENOTABindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_EstudiantesDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTUDIANTENOTABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_EstudiantesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTUDIANTENOTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_EstudiantesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroEstudiantesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_EstudiantesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(148, 29)
        Me.LblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(70, 13)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "Identificacion"
        '
        'GpbDatos
        '
        Me.GpbDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GpbDatos.Controls.Add(Me.lBLtIPO)
        Me.GpbDatos.Controls.Add(Me.Cmbtipoid)
        Me.GpbDatos.Controls.Add(Me.TxtNotaQ1)
        Me.GpbDatos.Controls.Add(Me.TxtNotaQ2)
        Me.GpbDatos.Controls.Add(Me.TxtNotaProyecto)
        Me.GpbDatos.Controls.Add(Me.TxtNotaP2)
        Me.GpbDatos.Controls.Add(Me.TxtNotaP1)
        Me.GpbDatos.Controls.Add(Me.Txt2Apellido)
        Me.GpbDatos.Controls.Add(Me.Txt1Apellido)
        Me.GpbDatos.Controls.Add(Me.TxtNombre)
        Me.GpbDatos.Controls.Add(Me.MskID)
        Me.GpbDatos.Controls.Add(Me.LblNotaProyecto)
        Me.GpbDatos.Controls.Add(Me.LblNotaQuiz2)
        Me.GpbDatos.Controls.Add(Me.LblNotaQuiz1)
        Me.GpbDatos.Controls.Add(Me.LblNota2)
        Me.GpbDatos.Controls.Add(Me.LblNota1)
        Me.GpbDatos.Controls.Add(Me.Lbl2Apellido)
        Me.GpbDatos.Controls.Add(Me.Lbl1Apellido)
        Me.GpbDatos.Controls.Add(Me.LblNombre)
        Me.GpbDatos.Controls.Add(Me.LblID)
        Me.GpbDatos.Location = New System.Drawing.Point(10, 20)
        Me.GpbDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.GpbDatos.Name = "GpbDatos"
        Me.GpbDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.GpbDatos.Size = New System.Drawing.Size(725, 153)
        Me.GpbDatos.TabIndex = 1
        Me.GpbDatos.TabStop = False
        Me.GpbDatos.Text = "Registro de Datos"
        '
        'lBLtIPO
        '
        Me.lBLtIPO.AutoSize = True
        Me.lBLtIPO.Location = New System.Drawing.Point(16, 29)
        Me.lBLtIPO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lBLtIPO.Name = "lBLtIPO"
        Me.lBLtIPO.Size = New System.Drawing.Size(42, 13)
        Me.lBLtIPO.TabIndex = 19
        Me.lBLtIPO.Text = "Tipo ID"
        '
        'Cmbtipoid
        '
        Me.Cmbtipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbtipoid.FormattingEnabled = True
        Me.Cmbtipoid.Items.AddRange(New Object() {"CEDULA NACIONAL", "DIMEX", "DIDI", "PASAPORTE"})
        Me.Cmbtipoid.Location = New System.Drawing.Point(14, 52)
        Me.Cmbtipoid.Name = "Cmbtipoid"
        Me.Cmbtipoid.Size = New System.Drawing.Size(121, 21)
        Me.Cmbtipoid.TabIndex = 1
        '
        'TxtNotaQ1
        '
        Me.TxtNotaQ1.Location = New System.Drawing.Point(210, 120)
        Me.TxtNotaQ1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotaQ1.Name = "TxtNotaQ1"
        Me.TxtNotaQ1.Size = New System.Drawing.Size(52, 20)
        Me.TxtNotaQ1.TabIndex = 8
        '
        'TxtNotaQ2
        '
        Me.TxtNotaQ2.Location = New System.Drawing.Point(299, 120)
        Me.TxtNotaQ2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotaQ2.Name = "TxtNotaQ2"
        Me.TxtNotaQ2.Size = New System.Drawing.Size(52, 20)
        Me.TxtNotaQ2.TabIndex = 9
        '
        'TxtNotaProyecto
        '
        Me.TxtNotaProyecto.Location = New System.Drawing.Point(391, 120)
        Me.TxtNotaProyecto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotaProyecto.Name = "TxtNotaProyecto"
        Me.TxtNotaProyecto.Size = New System.Drawing.Size(52, 20)
        Me.TxtNotaProyecto.TabIndex = 10
        '
        'TxtNotaP2
        '
        Me.TxtNotaP2.Location = New System.Drawing.Point(107, 120)
        Me.TxtNotaP2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotaP2.Name = "TxtNotaP2"
        Me.TxtNotaP2.Size = New System.Drawing.Size(52, 20)
        Me.TxtNotaP2.TabIndex = 7
        '
        'TxtNotaP1
        '
        Me.TxtNotaP1.Location = New System.Drawing.Point(14, 120)
        Me.TxtNotaP1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotaP1.Name = "TxtNotaP1"
        Me.TxtNotaP1.Size = New System.Drawing.Size(52, 20)
        Me.TxtNotaP1.TabIndex = 6
        '
        'Txt2Apellido
        '
        Me.Txt2Apellido.Location = New System.Drawing.Point(557, 53)
        Me.Txt2Apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt2Apellido.Name = "Txt2Apellido"
        Me.Txt2Apellido.Size = New System.Drawing.Size(117, 20)
        Me.Txt2Apellido.TabIndex = 5
        '
        'Txt1Apellido
        '
        Me.Txt1Apellido.Location = New System.Drawing.Point(427, 53)
        Me.Txt1Apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt1Apellido.Name = "Txt1Apellido"
        Me.Txt1Apellido.Size = New System.Drawing.Size(117, 20)
        Me.Txt1Apellido.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(292, 53)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(118, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'MskID
        '
        Me.MskID.Location = New System.Drawing.Point(150, 53)
        Me.MskID.Margin = New System.Windows.Forms.Padding(2)
        Me.MskID.Name = "MskID"
        Me.MskID.Size = New System.Drawing.Size(123, 20)
        Me.MskID.TabIndex = 2
        '
        'LblNotaProyecto
        '
        Me.LblNotaProyecto.AutoSize = True
        Me.LblNotaProyecto.Location = New System.Drawing.Point(388, 96)
        Me.LblNotaProyecto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNotaProyecto.Name = "LblNotaProyecto"
        Me.LblNotaProyecto.Size = New System.Drawing.Size(75, 13)
        Me.LblNotaProyecto.TabIndex = 8
        Me.LblNotaProyecto.Text = "Nota Proyecto"
        '
        'LblNotaQuiz2
        '
        Me.LblNotaQuiz2.AutoSize = True
        Me.LblNotaQuiz2.Location = New System.Drawing.Point(296, 96)
        Me.LblNotaQuiz2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNotaQuiz2.Name = "LblNotaQuiz2"
        Me.LblNotaQuiz2.Size = New System.Drawing.Size(63, 13)
        Me.LblNotaQuiz2.TabIndex = 7
        Me.LblNotaQuiz2.Text = "Nota Quiz 2"
        '
        'LblNotaQuiz1
        '
        Me.LblNotaQuiz1.AutoSize = True
        Me.LblNotaQuiz1.Location = New System.Drawing.Point(207, 96)
        Me.LblNotaQuiz1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNotaQuiz1.Name = "LblNotaQuiz1"
        Me.LblNotaQuiz1.Size = New System.Drawing.Size(63, 13)
        Me.LblNotaQuiz1.TabIndex = 6
        Me.LblNotaQuiz1.Text = "Nota Quiz 1"
        '
        'LblNota2
        '
        Me.LblNota2.AutoSize = True
        Me.LblNota2.Location = New System.Drawing.Point(106, 96)
        Me.LblNota2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNota2.Name = "LblNota2"
        Me.LblNota2.Size = New System.Drawing.Size(74, 13)
        Me.LblNota2.TabIndex = 5
        Me.LblNota2.Text = "Nota Parcial 2"
        '
        'LblNota1
        '
        Me.LblNota1.AutoSize = True
        Me.LblNota1.Location = New System.Drawing.Point(12, 96)
        Me.LblNota1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNota1.Name = "LblNota1"
        Me.LblNota1.Size = New System.Drawing.Size(74, 13)
        Me.LblNota1.TabIndex = 4
        Me.LblNota1.Text = "Nota Parcial 1"
        '
        'Lbl2Apellido
        '
        Me.Lbl2Apellido.AutoSize = True
        Me.Lbl2Apellido.Location = New System.Drawing.Point(554, 29)
        Me.Lbl2Apellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl2Apellido.Name = "Lbl2Apellido"
        Me.Lbl2Apellido.Size = New System.Drawing.Size(90, 13)
        Me.Lbl2Apellido.TabIndex = 3
        Me.Lbl2Apellido.Text = "Segundo Apellido"
        '
        'Lbl1Apellido
        '
        Me.Lbl1Apellido.AutoSize = True
        Me.Lbl1Apellido.Location = New System.Drawing.Point(424, 29)
        Me.Lbl1Apellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl1Apellido.Name = "Lbl1Apellido"
        Me.Lbl1Apellido.Size = New System.Drawing.Size(76, 13)
        Me.Lbl1Apellido.TabIndex = 2
        Me.Lbl1Apellido.Text = "Primer Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(290, 29)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'GpbEstado
        '
        Me.GpbEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GpbEstado.Controls.Add(Me.TxtEstadoFinalShow)
        Me.GpbEstado.Controls.Add(Me.Label2)
        Me.GpbEstado.Controls.Add(Me.TxtNotaFinalShow)
        Me.GpbEstado.Controls.Add(Me.Label1)
        Me.GpbEstado.Location = New System.Drawing.Point(10, 185)
        Me.GpbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.GpbEstado.Name = "GpbEstado"
        Me.GpbEstado.Padding = New System.Windows.Forms.Padding(2)
        Me.GpbEstado.Size = New System.Drawing.Size(202, 77)
        Me.GpbEstado.TabIndex = 2
        Me.GpbEstado.TabStop = False
        Me.GpbEstado.Text = "Estado"
        '
        'TxtEstadoFinalShow
        '
        Me.TxtEstadoFinalShow.Location = New System.Drawing.Point(97, 50)
        Me.TxtEstadoFinalShow.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEstadoFinalShow.Name = "TxtEstadoFinalShow"
        Me.TxtEstadoFinalShow.ReadOnly = True
        Me.TxtEstadoFinalShow.Size = New System.Drawing.Size(83, 20)
        Me.TxtEstadoFinalShow.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Estado Final"
        '
        'TxtNotaFinalShow
        '
        Me.TxtNotaFinalShow.Location = New System.Drawing.Point(17, 50)
        Me.TxtNotaFinalShow.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotaFinalShow.Name = "TxtNotaFinalShow"
        Me.TxtNotaFinalShow.ReadOnly = True
        Me.TxtNotaFinalShow.Size = New System.Drawing.Size(52, 20)
        Me.TxtNotaFinalShow.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nota final"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnCalcular.FlatAppearance.BorderSize = 2
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnCalcular.Location = New System.Drawing.Point(34, 8)
        Me.BtnCalcular.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(88, 38)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "&Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnRegistrar.FlatAppearance.BorderSize = 2
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnRegistrar.Location = New System.Drawing.Point(129, 8)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(88, 38)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "&Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.BorderSize = 2
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnLimpiar.Location = New System.Drawing.Point(224, 8)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 38)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPO_ID, Me.IDENTIFICACIONDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.PRIMERAPELLIDODataGridViewTextBoxColumn, Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn, Me.NOTAPARCIAL1DataGridViewTextBoxColumn, Me.NOTAPARCIAL2DataGridViewTextBoxColumn, Me.NOTAQUIZ1DataGridViewTextBoxColumn, Me.NOTAQUIZ2DataGridViewTextBoxColumn, Me.NOTAPROYECTODataGridViewTextBoxColumn, Me.NOTAFINALDataGridViewTextBoxColumn, Me.ESTADOFINALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ESTUDIANTENOTABindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(10, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 151)
        Me.DataGridView1.TabIndex = 6
        '
        'TIPO_ID
        '
        Me.TIPO_ID.DataPropertyName = "TIPO_ID"
        Me.TIPO_ID.HeaderText = "TIPO_ID"
        Me.TIPO_ID.Name = "TIPO_ID"
        '
        'IDENTIFICACIONDataGridViewTextBoxColumn
        '
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "IDENTIFICACION"
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.HeaderText = "IDENTIFICACION"
        Me.IDENTIFICACIONDataGridViewTextBoxColumn.Name = "IDENTIFICACIONDataGridViewTextBoxColumn"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        '
        'PRIMERAPELLIDODataGridViewTextBoxColumn
        '
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "PRIMER_APELLIDO"
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn.HeaderText = "PRIMER_APELLIDO"
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn.Name = "PRIMERAPELLIDODataGridViewTextBoxColumn"
        '
        'SEGUNDOAPELLIDODataGridViewTextBoxColumn
        '
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "SEGUNDO_APELLIDO"
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn.HeaderText = "SEGUNDO_APELLIDO"
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn.Name = "SEGUNDOAPELLIDODataGridViewTextBoxColumn"
        '
        'NOTAPARCIAL1DataGridViewTextBoxColumn
        '
        Me.NOTAPARCIAL1DataGridViewTextBoxColumn.DataPropertyName = "NOTA_PARCIAL_1"
        Me.NOTAPARCIAL1DataGridViewTextBoxColumn.HeaderText = "NOTA_PARCIAL_1"
        Me.NOTAPARCIAL1DataGridViewTextBoxColumn.Name = "NOTAPARCIAL1DataGridViewTextBoxColumn"
        Me.NOTAPARCIAL1DataGridViewTextBoxColumn.Width = 50
        '
        'NOTAPARCIAL2DataGridViewTextBoxColumn
        '
        Me.NOTAPARCIAL2DataGridViewTextBoxColumn.DataPropertyName = "NOTA_PARCIAL_2"
        Me.NOTAPARCIAL2DataGridViewTextBoxColumn.HeaderText = "NOTA_PARCIAL_2"
        Me.NOTAPARCIAL2DataGridViewTextBoxColumn.Name = "NOTAPARCIAL2DataGridViewTextBoxColumn"
        Me.NOTAPARCIAL2DataGridViewTextBoxColumn.Width = 50
        '
        'NOTAQUIZ1DataGridViewTextBoxColumn
        '
        Me.NOTAQUIZ1DataGridViewTextBoxColumn.DataPropertyName = "NOTA_QUIZ_1"
        Me.NOTAQUIZ1DataGridViewTextBoxColumn.HeaderText = "NOTA_QUIZ_1"
        Me.NOTAQUIZ1DataGridViewTextBoxColumn.Name = "NOTAQUIZ1DataGridViewTextBoxColumn"
        Me.NOTAQUIZ1DataGridViewTextBoxColumn.Width = 50
        '
        'NOTAQUIZ2DataGridViewTextBoxColumn
        '
        Me.NOTAQUIZ2DataGridViewTextBoxColumn.DataPropertyName = "NOTA_QUIZ_2"
        Me.NOTAQUIZ2DataGridViewTextBoxColumn.HeaderText = "NOTA_QUIZ_2"
        Me.NOTAQUIZ2DataGridViewTextBoxColumn.Name = "NOTAQUIZ2DataGridViewTextBoxColumn"
        Me.NOTAQUIZ2DataGridViewTextBoxColumn.Width = 50
        '
        'NOTAPROYECTODataGridViewTextBoxColumn
        '
        Me.NOTAPROYECTODataGridViewTextBoxColumn.DataPropertyName = "NOTA_PROYECTO"
        Me.NOTAPROYECTODataGridViewTextBoxColumn.HeaderText = "NOTA_PROYECTO"
        Me.NOTAPROYECTODataGridViewTextBoxColumn.Name = "NOTAPROYECTODataGridViewTextBoxColumn"
        Me.NOTAPROYECTODataGridViewTextBoxColumn.Width = 50
        '
        'NOTAFINALDataGridViewTextBoxColumn
        '
        Me.NOTAFINALDataGridViewTextBoxColumn.DataPropertyName = "NOTA_FINAL"
        Me.NOTAFINALDataGridViewTextBoxColumn.HeaderText = "NOTA_FINAL"
        Me.NOTAFINALDataGridViewTextBoxColumn.Name = "NOTAFINALDataGridViewTextBoxColumn"
        Me.NOTAFINALDataGridViewTextBoxColumn.Width = 50
        '
        'ESTADOFINALDataGridViewTextBoxColumn
        '
        Me.ESTADOFINALDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_FINAL"
        Me.ESTADOFINALDataGridViewTextBoxColumn.HeaderText = "ESTADO_FINAL"
        Me.ESTADOFINALDataGridViewTextBoxColumn.Name = "ESTADOFINALDataGridViewTextBoxColumn"
        '
        'ESTUDIANTENOTABindingSource3
        '
        Me.ESTUDIANTENOTABindingSource3.DataMember = "ESTUDIANTE_NOTA"
        Me.ESTUDIANTENOTABindingSource3.DataSource = Me.Registro_EstudiantesDataSet4
        '
        'Registro_EstudiantesDataSet4
        '
        Me.Registro_EstudiantesDataSet4.DataSetName = "Registro_EstudiantesDataSet4"
        Me.Registro_EstudiantesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESTUDIANTENOTABindingSource2
        '
        Me.ESTUDIANTENOTABindingSource2.DataMember = "ESTUDIANTE_NOTA"
        Me.ESTUDIANTENOTABindingSource2.DataSource = Me.Registro_EstudiantesDataSet3
        '
        'Registro_EstudiantesDataSet3
        '
        Me.Registro_EstudiantesDataSet3.DataSetName = "Registro_EstudiantesDataSet3"
        Me.Registro_EstudiantesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESTUDIANTENOTABindingSource1
        '
        Me.ESTUDIANTENOTABindingSource1.DataMember = "ESTUDIANTE_NOTA"
        Me.ESTUDIANTENOTABindingSource1.DataSource = Me.Registro_EstudiantesDataSet2
        '
        'Registro_EstudiantesDataSet2
        '
        Me.Registro_EstudiantesDataSet2.DataSetName = "Registro_EstudiantesDataSet2"
        Me.Registro_EstudiantesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESTUDIANTENOTABindingSource
        '
        Me.ESTUDIANTENOTABindingSource.DataMember = "ESTUDIANTE_NOTA"
        Me.ESTUDIANTENOTABindingSource.DataSource = Me.Registro_EstudiantesDataSet1
        '
        'Registro_EstudiantesDataSet1
        '
        Me.Registro_EstudiantesDataSet1.DataSetName = "Registro_EstudiantesDataSet1"
        Me.Registro_EstudiantesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroEstudiantesDataSetBindingSource
        '
        Me.RegistroEstudiantesDataSetBindingSource.DataSource = Me.Registro_EstudiantesDataSet
        Me.RegistroEstudiantesDataSetBindingSource.Position = 0
        '
        'Registro_EstudiantesDataSet
        '
        Me.Registro_EstudiantesDataSet.DataSetName = "Registro_EstudiantesDataSet"
        Me.Registro_EstudiantesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Controls.Add(Me.BtnConsultar)
        Me.Panel1.Controls.Add(Me.BtnCalcular)
        Me.Panel1.Controls.Add(Me.BtnRegistrar)
        Me.Panel1.Controls.Add(Me.BtnLimpiar)
        Me.Panel1.Location = New System.Drawing.Point(304, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 97)
        Me.Panel1.TabIndex = 7
        '
        'BtnSalir
        '
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnSalir.FlatAppearance.BorderSize = 2
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnSalir.Location = New System.Drawing.Point(214, 50)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(88, 38)
        Me.BtnSalir.TabIndex = 9
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnModificar.FlatAppearance.BorderSize = 2
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnModificar.Location = New System.Drawing.Point(107, 50)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(88, 38)
        Me.BtnModificar.TabIndex = 7
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.BorderSize = 2
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BtnConsultar.Location = New System.Drawing.Point(317, 8)
        Me.BtnConsultar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(88, 38)
        Me.BtnConsultar.TabIndex = 6
        Me.BtnConsultar.Text = "&Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'ESTUDIANTE_NOTATableAdapter
        '
        Me.ESTUDIANTE_NOTATableAdapter.ClearBeforeFill = True
        '
        'ESTUDIANTE_NOTATableAdapter1
        '
        Me.ESTUDIANTE_NOTATableAdapter1.ClearBeforeFill = True
        '
        'ESTUDIANTE_NOTATableAdapter2
        '
        Me.ESTUDIANTE_NOTATableAdapter2.ClearBeforeFill = True
        '
        'ESTUDIANTE_NOTATableAdapter3
        '
        Me.ESTUDIANTE_NOTATableAdapter3.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(746, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GpbEstado)
        Me.Controls.Add(Me.GpbDatos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Calculo de Notas Finales"
        Me.GpbDatos.ResumeLayout(False)
        Me.GpbDatos.PerformLayout()
        Me.GpbEstado.ResumeLayout(False)
        Me.GpbEstado.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTUDIANTENOTABindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_EstudiantesDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTUDIANTENOTABindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_EstudiantesDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTUDIANTENOTABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_EstudiantesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTUDIANTENOTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_EstudiantesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroEstudiantesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_EstudiantesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents GpbDatos As GroupBox
    Friend WithEvents LblNota2 As Label
    Friend WithEvents LblNota1 As Label
    Friend WithEvents Lbl2Apellido As Label
    Friend WithEvents Lbl1Apellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNotaQ1 As TextBox
    Friend WithEvents TxtNotaQ2 As TextBox
    Friend WithEvents TxtNotaProyecto As TextBox
    Friend WithEvents TxtNotaP2 As TextBox
    Friend WithEvents TxtNotaP1 As TextBox
    Friend WithEvents Txt2Apellido As TextBox
    Friend WithEvents Txt1Apellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents MskID As MaskedTextBox
    Friend WithEvents LblNotaProyecto As Label
    Friend WithEvents LblNotaQuiz2 As Label
    Friend WithEvents LblNotaQuiz1 As Label
    Friend WithEvents GpbEstado As GroupBox
    Friend WithEvents TxtNotaFinalShow As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RegistroEstudiantesDataSetBindingSource As BindingSource
    Friend WithEvents Registro_EstudiantesDataSet As Registro_EstudiantesDataSet
    Friend WithEvents TxtEstadoFinalShow As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents Registro_EstudiantesDataSet1 As Registro_EstudiantesDataSet1
    Friend WithEvents ESTUDIANTENOTABindingSource As BindingSource
    Friend WithEvents ESTUDIANTE_NOTATableAdapter As Registro_EstudiantesDataSet1TableAdapters.ESTUDIANTE_NOTATableAdapter
    Friend WithEvents Registro_EstudiantesDataSet2 As Registro_EstudiantesDataSet2
    Friend WithEvents ESTUDIANTENOTABindingSource1 As BindingSource
    Friend WithEvents ESTUDIANTE_NOTATableAdapter1 As Registro_EstudiantesDataSet2TableAdapters.ESTUDIANTE_NOTATableAdapter
    Friend WithEvents Cmbtipoid As ComboBox
    Friend WithEvents Registro_EstudiantesDataSet3 As Registro_EstudiantesDataSet3
    Friend WithEvents ESTUDIANTENOTABindingSource2 As BindingSource
    Friend WithEvents ESTUDIANTE_NOTATableAdapter2 As Registro_EstudiantesDataSet3TableAdapters.ESTUDIANTE_NOTATableAdapter
    Friend WithEvents lBLtIPO As Label
    Friend WithEvents TIPO_ID As DataGridViewTextBoxColumn
    Friend WithEvents IDENTIFICACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRIMERAPELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEGUNDOAPELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTAPARCIAL1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTAPARCIAL2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTAQUIZ1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTAQUIZ2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTAPROYECTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOTAFINALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADOFINALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Registro_EstudiantesDataSet4 As Registro_EstudiantesDataSet4
    Friend WithEvents ESTUDIANTENOTABindingSource3 As BindingSource
    Friend WithEvents ESTUDIANTE_NOTATableAdapter3 As Registro_EstudiantesDataSet4TableAdapters.ESTUDIANTE_NOTATableAdapter
End Class
