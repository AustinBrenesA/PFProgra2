Module Funciones

    Public f As Integer
    Public Sub no_digitar(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena = ""
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub

    Public Sub solo_numeros(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena = "0123456789."
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub

    Public Sub solo_letras(ByRef ee As System.Windows.Forms.KeyPressEventArgs)
        Dim cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWYZ."
        If InStr(cadena, ee.KeyChar) Then
            ee.Handled = False
        ElseIf Char.IsControl(ee.KeyChar) Then
            ee.Handled = False
        Else
            ee.Handled = True
        End If
    End Sub


End Module
