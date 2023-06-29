Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Http.Headers

Public Class Conexion

    Public conexion As SqlConnection = New SqlConnection("data source= DESKTOP-M503059\SQLEXPRESS; Initial Catalog=Registro_Estudiantes;Trusted_connection=Yes")
    Public pubcomand As New Data.OleDb.OleDbCommand
    Public pubda As New Data.OleDb.OleDbDataAdapter
    Public comando As SqlCommand
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public builder As SqlCommandBuilder

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("CONEXION EXITOSA")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function busca_id(ByVal vtipo As String, idcedula As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM ESTUDIANTE_NOTA WHERE TIPO_ID =" + vtipo.ToString() + "AND IDENTIFICACION = '" + idcedula + "'", "ESTUDIANTE_NOTA")
        If ds.Tables("ESTUDIANTE_NOTA").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt

    End Function

    Public Sub consultar(ByVal Sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(Sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Public Function insertar_Estudiantes_Nota(ByVal datos As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            f = 0 'TRUE
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
            f = 1
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

End Class
