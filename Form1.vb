Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim ntipoid As Integer
    Dim Conexion As Conexion = New Conexion()

    Private Sub TxtNombre_keypress(sender As Object, e As EventArgs) Handles TxtNombre.KeyPress
        solo_letras(e)
    End Sub

    Private Sub Txt1Apellido_keypress(sender As Object, e As EventArgs) Handles Txt1Apellido.KeyPress
        solo_letras(e)
    End Sub

    Private Sub Txt2Apellido_KeyPress(sender As Object, e As EventArgs) Handles Txt2Apellido.KeyPress
        solo_letras(e)
    End Sub
    Private Sub TxtNotaP1_keypress(sender As Object, e As EventArgs) Handles TxtNotaP1.KeyPress
        solo_numeros(e)
        Dim Adjusted As String = adjInput(0, 100, TxtNotaP1.Text)
        TxtNotaP1.Text = Adjusted
        TxtNotaP1.SelectionStart = TxtNotaP1.Text.Length + 1
        TxtNotaP1.SelectionLength = 0
    End Sub

    Private Sub TxtNotaP2_keypress(sender As Object, e As EventArgs) Handles TxtNotaP2.KeyPress
        solo_numeros(e)
        Dim Adjusted As String = adjInput(0, 100, TxtNotaP2.Text)
        TxtNotaP2.Text = Adjusted
        TxtNotaP2.SelectionStart = TxtNotaP2.Text.Length + 1
        TxtNotaP2.SelectionLength = 0
    End Sub

    Private Sub TxtNotaQ1_keypress(sender As Object, e As EventArgs) Handles TxtNotaQ1.KeyPress
        solo_numeros(e)
        Dim Adjusted As String = adjInput(0, 100, TxtNotaQ1.Text)
        TxtNotaQ1.Text = Adjusted
        TxtNotaQ1.SelectionStart = TxtNotaQ1.Text.Length + 1
        TxtNotaQ1.SelectionLength = 0
    End Sub

    Private Sub TxtNotaQ2_keypress(sender As Object, e As EventArgs) Handles TxtNotaQ2.KeyPress
        solo_numeros(e)
        Dim Adjusted As String = adjInput(0, 100, TxtNotaProyecto.Text)
        TxtNotaProyecto.Text = Adjusted
        TxtNotaProyecto.SelectionStart = TxtNotaProyecto.Text.Length + 1
        TxtNotaProyecto.SelectionLength = 0
    End Sub

    Private Sub TxtNotaProyecto_keypress(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNotaProyecto.KeyPress
        solo_numeros(e)
        Dim Adjusted As String = adjInput(0, 100, TxtNotaProyecto.Text)
        TxtNotaProyecto.Text = Adjusted
        TxtNotaProyecto.SelectionStart = TxtNotaProyecto.Text.Length + 1
        TxtNotaProyecto.SelectionLength = 0
    End Sub

    Sub ShowMessage1()
        MessageBox.Show("Valor ingresado no está en el rango!(0-100)", "Valor ajustado!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Function adjInput(ByVal Min As Decimal, ByVal Max As Decimal, ByVal Input As String) As String
        Dim Value As Decimal
        If Not Decimal.TryParse(Input, Value) Then Return "0"
        If Value > Max Then Value = Max : ShowMessage1()
        If Value < Min Then Value = Min : ShowMessage1()
        Return Math.Round(Value, 3).ToString
    End Function

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        f = 0 'Inicializaqr variable'
        Dim strsql As String = ""
        Dim vtipoid, vnotap1, vnotap2, vnotaq1, vnotaq2, vnotaproyecto, vnotafinal As Integer
        vtipoid = 0
        vnotap1 = 0
        vnotap2 = 0
        vnotaq1 = 0
        vnotaq2 = 0
        vnotaproyecto = 0
        vnotafinal = 0
        Dim vid, vnombre, vapellido1, vapellido2, vest_final As String
        vid = ""
        vnombre = ""
        vapellido1 = ""
        vapellido2 = ""
        vest_final = ""

        Try
            If validar_campos() = False Then
                MsgBox("Datos Incompletos")
                Cmbtipoid.Focus()
                Return
            Else
                If MessageBox.Show("Está seguro de insertar el registro en la base de datos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Dim idcedula As String = Nothing
                    Dim valorformateado As String
                    valorformateado = MskID.Text
                    Dim valorsinformato As String = valorformateado.Replace("-", "")
                    vid = valorsinformato
                    'Vamos a consultar si la identificacion existe en la base de datos'
                    Dim dt = Conexion.busca_id(vtipoid, vid)
                    If f = 0 Then
                        MsgBox("Identificacion ya fue registradsa")
                        Return
                    Else
                        f = 0

                    End If
                    'Construyo el Insert'
                    vnombre = TxtNombre.Text
                    vapellido1 = Txt1Apellido.Text
                    vapellido2 = Txt2Apellido.Text
                    vnotap1 = Val(TxtNotaP1.Text)
                    vnotap2 = Val(TxtNotaP2.Text)
                    vnotaproyecto = Val(TxtNotaProyecto.Text)
                    vnotaq1 = Val(TxtNotaQ1.Text)
                    vnotaq2 = Val(TxtNotaQ2.Text)
                    vnotafinal = Val(TxtNotaFinalShow.Text)
                    vest_final = TxtEstadoFinalShow.Text
                    strsql = "INSERT INTO ESTUDIANTE_NOTA (TIPO_ID, IDENTIFICACION, NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, NOTA_PARCIAL_1, NOTA_PARCIAL_2, NOTA_QUIZ_1, NOTA_QUIZ_2, NOTA_PROYECTO, NOTA_FINAL, ESTADO_FINAL)"
                    strsql += vbCrLf + "VALUES ('" & vtipoid & "','" & vid & "','" & vnombre & "','" & vapellido1 & "','" & vapellido2 & "','" & vnotap1 & "','" & vnotap2 & "','" & vnotaq1 & "','" & vnotaq2 & "','" & vnotaproyecto & "','" & vnotafinal & "','" & vest_final & "')"
                    MsgBox(strsql)
                    Conexion.insertar_Estudiantes_Nota(strsql)
                    If f = 0 Then
                        MessageBox.Show("Datos almacenados con exito", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.ESTUDIANTE_NOTATableAdapter3.Fill(Me.Registro_EstudiantesDataSet4.ESTUDIANTE_NOTA)
                    Else
                        MessageBox.Show("Error al insertar datos", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error al insertar el registro en bases de datos")
        Finally

        End Try


    End Sub

    Private Function validar_campos() As Boolean
        If Cmbtipoid.Text = "" Or MskID.MaskFull = False Or Txt1Apellido.Text = "" Or Txt2Apellido.Text = "" Or TxtNombre.Text = "" Or TxtNotaP1.Text = "" Or TxtNotaP2.Text = "" Or TxtNotaProyecto.Text = "" Or TxtNotaQ1.Text = "" Or TxtNotaQ2.Text = "" Then
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        TxtNotaFinalShow.Text = calculo()
        TxtEstadoFinalShow.Text = estado()
    End Sub

    Public Function calculo()
        Dim porc1, porc2, porc3, porc4, porc5 As Double
        Dim notap1, notap2, notaquiz1, notaquiz2, notaproyecto As Double
        Dim notaFinal As Integer
        notap1 = Val(TxtNotaP1.Text)
        notap2 = Val(TxtNotaP2.Text)
        notaquiz1 = Val(TxtNotaQ1.Text)
        notaquiz2 = Val(TxtNotaQ2.Text)
        notaproyecto = Val(TxtNotaProyecto.Text)


        porc1 = notap1 * 0.2
        porc2 = notap2 * 0.2
        porc3 = notaquiz1 * 0.2
        porc4 = notaquiz2 * 0.2
        porc5 = notaproyecto * 0.2

        notaFinal = porc1 + porc2 + porc3 + porc4 + porc5

        Return notaFinal


    End Function

    Public Function estado()

        If Val(TxtNotaFinalShow.Text) >= 70 Then
            TxtEstadoFinalShow.Text = "APROBADO"
        Else
            TxtEstadoFinalShow.Text = "REPROBADO"
        End If
        Return TxtEstadoFinalShow.Text
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Registro_EstudiantesDataSet4.ESTUDIANTE_NOTA' Puede moverla o quitarla según sea necesario.
        Me.ESTUDIANTE_NOTATableAdapter3.Fill(Me.Registro_EstudiantesDataSet4.ESTUDIANTE_NOTA)
        Conexion.conectar()
    End Sub

    Private Sub TxtEstadoFinalShow_TextChanged(sender As Object, e As EventArgs) Handles TxtEstadoFinalShow.TextChanged
        If TxtEstadoFinalShow.Text = "APROBADO" Then
            TxtEstadoFinalShow.BackColor = Color.Green
            TxtEstadoFinalShow.ForeColor = Color.Black
        ElseIf TxtEstadoFinalShow.Text = "REPROBADO" Then
            TxtEstadoFinalShow.BackColor = Color.Red
            TxtEstadoFinalShow.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt1Apellido.Clear()
        Txt2Apellido.Clear()
        TxtNombre.Clear()
        TxtNotaFinalShow.Clear()
        TxtNotaP1.Clear()
        TxtNotaP2.Clear()
        TxtNotaProyecto.Clear()
        TxtNotaQ1.Clear()
        TxtNotaQ2.Clear()
        TxtEstadoFinalShow.Clear()
        Cmbtipoid.Items.Clear()
        MskID.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub Cmbtipoid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbtipoid.SelectedIndexChanged
        MskID.Text = ""
        If Cmbtipoid.Text = "CEDULA NACIONAL" Then
            ntipoid = 1
            MskID.Mask = "9-9999-9999"
            SendKeys.Send("{tab}")
        ElseIf Cmbtipoid.Text = "DIMEX" Then
            ntipoid = 2
            MskID.Mask = "999999999999"
            SendKeys.Send("{tab}")
        ElseIf Cmbtipoid.Text = "DIDI" Then
            ntipoid = 3
            MskID.Mask = "999999999999"
            SendKeys.Send("{tab}")
        ElseIf Cmbtipoid.Text = "PASAPORTE" Then
            ntipoid = 4
            MskID.Mask = "AAAAAAAAAAAAAAAAAAAA"
            SendKeys.Send("{tab}")
        End If
    End Sub


End Class
