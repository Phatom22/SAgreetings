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
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLang = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(317, 208)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(134, 58)
        Me.btnGreet.TabIndex = 0
        Me.btnGreet.Text = "Greet"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "South African Language"
        '
        'txtLang
        '
        Me.txtLang.Location = New System.Drawing.Point(490, 114)
        Me.txtLang.Name = "txtLang"
        Me.txtLang.Size = New System.Drawing.Size(100, 26)
        Me.txtLang.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtLang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGreet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGreet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLang As TextBox
End Class
