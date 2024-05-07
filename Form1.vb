Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'Declear Variables
        Dim decCelcius, decFahrenheit As Decimal

        'Check if for temperature to convert and show an error messsage when the user enters values in both
        'temperature boxes

        If txtFahrenheit.Text <> "" And txtCelcius.Text = "" Then
            decFahrenheit = txtFahrenheit.Text

            decCelcius = (decFahrenheit - 32) * (5 / 9)

            txtCelcius.Text = decCelcius


        ElseIf txtCelcius.Text <> "" And txtFahrenheit.Text = "" Then
            decCelcius = txtCelcius.Text

            decFahrenheit = 9 / 5 * decCelcius + 32

            txtFahrenheit.Text = decFahrenheit

        Else
            'Display the below message to the user when he/she enters values in both temperature boxes

            MsgBox("Temperature values have been provided in different degree")
        End If

    End Sub

    Private Sub btbCLEAR_Click(sender As Object, e As EventArgs) Handles btbCLEAR.Click

        'Clear displayed results for new calculations

        txtFahrenheit.Text = ""
        txtCelcius.Text = ""
    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        'Close the form when the exit button is clicked
        Me.Close()
    End Sub
End Class
