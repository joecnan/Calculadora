Public Class Calculadora
    Private memoriaA1 As Double = 0.0
    Private memoriaA2 As Double = 0.0
    Private signo As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        lblentrada.Text = lblentrada.Text & "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lblentrada.Text = lblentrada.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lblentrada.Text = lblentrada.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lblentrada.Text = lblentrada.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblentrada.Text = lblentrada.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lblentrada.Text = lblentrada.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lblentrada.Text = lblentrada.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lblentrada.Text = lblentrada.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lblentrada.Text = lblentrada.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lblentrada.Text = lblentrada.Text & "9"
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        Try
            If lblentrada.Text <> "" Then
                memoriaA1 = Val(lblentrada.Text)
                signo = "+"
                lblsalida.Clear()
                lblsalida.Text = lblentrada.Text & "+"
                lblentrada.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnresultado_Click(sender As Object, e As EventArgs) Handles btnresultado.Click
        Try
            If lblentrada.Text <> "" And memoriaA1 <> 0.0 Then
                memoriaA2 = lblentrada.Text
                lblsalida.Text = lblsalida.Text & lblentrada.Text & "="
                Calcular()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Calcular()
        Select Case signo
            Case "+"
                lblentrada.Text = memoriaA1 + memoriaA2
            Case "-"
                lblentrada.Text = memoriaA1 - memoriaA2
            Case "x"
                lblentrada.Text = memoriaA1 * memoriaA2
            Case "➗"
                lblentrada.Text = memoriaA1 / memoriaA2
            Case "%"
                lblentrada.Text = memoriaA1 * memoriaA2 / 100
            Case Else
                MsgBox("Error")

        End Select
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        Try
            If lblentrada.Text <> "" Then
                memoriaA1 = Val(lblentrada.Text)
                signo = "-"
                lblsalida.Clear()
                lblsalida.Text = lblentrada.Text & "-"
                lblentrada.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmultiplicacion_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        Try
            If lblentrada.Text <> "" Then
                memoriaA1 = Val(lblentrada.Text)
                signo = "x"
                lblsalida.Clear()
                lblsalida.Text = lblentrada.Text & "x"
                lblentrada.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        Try
            If lblentrada.Text <> "" Then
                memoriaA1 = Val(lblentrada.Text)
                signo = "➗"
                lblsalida.Clear()
                lblsalida.Text = lblentrada.Text & "➗"
                lblentrada.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Try
            Dim largo As Integer
            If lblentrada.Text <> "" Then
                largo = lblentrada.Text.Length
                lblentrada.Text = Mid(lblentrada.Text, 1, largo - 1)

            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnsigno_Click(sender As Object, e As EventArgs) Handles btnsigno.Click
        Try
            If lblentrada.Text <> "" Then
                lblentrada.Text = lblentrada.Text * (-1)
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Function existepunto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False
        largo = cadena.Length

        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True
            End If
        Next

        Return respuesta
    End Function

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        If lblentrada.Text = "" Then
            lblentrada.Text = "0."
        ElseIf existepunto(lblentrada.Text) = False Then
            lblentrada.Text = lblentrada.Text & "."
        End If
    End Sub

    Private Sub btnporcentaje_Click(sender As Object, e As EventArgs) Handles btnporcentaje.Click
        Try
            If lblentrada.Text <> "" Then
                memoriaA1 = Val(lblentrada.Text)
                signo = "%"
                lblsalida.Clear()
                lblsalida.Text = lblentrada.Text & "%"
                lblentrada.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        If lblentrada.Text <> "" Then
            lblentrada.Text = lblentrada.Text & "0."

        End If
    End Sub
End Class
