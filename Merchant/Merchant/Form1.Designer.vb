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
        Me.type = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.show = New System.Windows.Forms.Button()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'type
        '
        Me.type.Location = New System.Drawing.Point(94, 85)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(159, 26)
        Me.type.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type:"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(45, 293)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 33)
        Me.Submit.TabIndex = 2
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'show
        '
        Me.show.Location = New System.Drawing.Point(339, 325)
        Me.show.Name = "show"
        Me.show.Size = New System.Drawing.Size(97, 33)
        Me.show.TabIndex = 3
        Me.show.Text = "Show Info"
        Me.show.UseVisualStyleBackColor = True
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(94, 179)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(158, 26)
        Me.price.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quantity:"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(94, 137)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(33, 26)
        Me.qty.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 450)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.show)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.type)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents type As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Submit As Button
    Friend WithEvents show As Button
    Friend WithEvents price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents qty As TextBox
End Class
