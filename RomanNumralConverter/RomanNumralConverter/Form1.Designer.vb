<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumeral = New System.Windows.Forms.Label()
        Me.txtRange = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(56, 198)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(166, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter a decimal integer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in range 1-10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Equivalent Roman" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Numeral"
        '
        'lblNumeral
        '
        Me.lblNumeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumeral.Location = New System.Drawing.Point(166, 69)
        Me.lblNumeral.Name = "lblNumeral"
        Me.lblNumeral.Size = New System.Drawing.Size(106, 24)
        Me.lblNumeral.TabIndex = 5
        '
        'txtRange
        '
        Me.txtRange.Location = New System.Drawing.Point(166, 34)
        Me.txtRange.Name = "txtRange"
        Me.txtRange.Size = New System.Drawing.Size(106, 20)
        Me.txtRange.TabIndex = 6
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(56, 135)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(185, 37)
        Me.lblError.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 267)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtRange)
        Me.Controls.Add(Me.lblNumeral)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumeral As System.Windows.Forms.Label
    Friend WithEvents txtRange As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
