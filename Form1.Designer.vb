<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnConvert = New Button()
        txtCelcius = New TextBox()
        txtFahrenheit = New TextBox()
        lblCelcius = New Label()
        lblFahrenheit = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btbCLEAR = New Button()
        btnEXIT = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConvert.Location = New Point(347, 245)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(111, 28)
        btnConvert.TabIndex = 0
        btnConvert.Text = "CONVERT"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(437, 202)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(100, 23)
        txtCelcius.TabIndex = 1
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(260, 203)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(100, 23)
        txtFahrenheit.TabIndex = 2
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCelcius.Location = New Point(245, 170)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(118, 15)
        lblCelcius.TabIndex = 3
        lblCelcius.Text = "DEGREE CELCIUS (C)"
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFahrenheit.Location = New Point(417, 170)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(142, 15)
        lblFahrenheit.TabIndex = 4
        lblFahrenheit.Text = "DEGREE FAHRENHEIT (F)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.TEMPERATURE
        PictureBox1.Location = New Point(-3, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 365)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.double_way
        PictureBox2.Location = New Point(366, 203)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 24)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' btbCLEAR
        ' 
        btbCLEAR.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btbCLEAR.Location = New Point(249, 279)
        btbCLEAR.Name = "btbCLEAR"
        btbCLEAR.Size = New Size(111, 28)
        btbCLEAR.TabIndex = 10
        btbCLEAR.Text = "CLEAR"
        btbCLEAR.UseVisualStyleBackColor = True
        ' 
        ' btnEXIT
        ' 
        btnEXIT.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEXIT.Location = New Point(442, 279)
        btnEXIT.Name = "btnEXIT"
        btnEXIT.Size = New Size(111, 28)
        btnEXIT.TabIndex = 11
        btnEXIT.Text = "EXIT"
        btnEXIT.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(btnEXIT)
        Controls.Add(btbCLEAR)
        Controls.Add(PictureBox2)
        Controls.Add(lblFahrenheit)
        Controls.Add(lblCelcius)
        Controls.Add(txtFahrenheit)
        Controls.Add(txtCelcius)
        Controls.Add(btnConvert)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "TEMPERATURE CONVERTER         C = (F - 32) * (5 / 9)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents lblCelcius As Label
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btbCLEAR As Button
    Friend WithEvents btnEXIT As Button

End Class
