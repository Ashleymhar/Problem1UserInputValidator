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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(319, 150)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 1
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(319, 176)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(75, 23)
        Me.btnValidate.TabIndex = 2
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(400, 181)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnValidate As Button
    Friend WithEvents lblResult As Label
End Class
