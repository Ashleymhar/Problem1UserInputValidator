Public Class Form1
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Try
            Dim input As String = txtAge.Text.Trim()
            Dim age As Integer = Integer.Parse(input)

            If age < 0 Then
                Throw New NegativeAgeException("Age cannot be negative.")
            End If

            lblResult.Text = $"Valid age: {age}"


        Catch ex As FormatException
            lblResult.Text = "Error: Please enter a numeric value."
            'ashleymhar

        Catch ex As NegativeAgeException
            lblResult.Text = ex.Message


        End Try
    End Sub

End Class

' Custom Exception Class
Public Class NegativeAgeException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

End Class