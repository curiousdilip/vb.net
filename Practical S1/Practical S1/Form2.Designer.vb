<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.india = New System.Windows.Forms.RadioButton()
        Me.america = New System.Windows.Forms.RadioButton()
        Me.russia = New System.Windows.Forms.RadioButton()
        Me.france = New System.Windows.Forms.RadioButton()
        Me.president = New System.Windows.Forms.CheckBox()
        Me.currency = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'india
        '
        Me.india.AutoSize = True
        Me.india.Location = New System.Drawing.Point(16, 19)
        Me.india.Name = "india"
        Me.india.Size = New System.Drawing.Size(48, 17)
        Me.india.TabIndex = 1
        Me.india.TabStop = True
        Me.india.Text = "India"
        Me.india.UseVisualStyleBackColor = True
        '
        'america
        '
        Me.america.AutoSize = True
        Me.america.Location = New System.Drawing.Point(16, 42)
        Me.america.Name = "america"
        Me.america.Size = New System.Drawing.Size(63, 17)
        Me.america.TabIndex = 2
        Me.america.TabStop = True
        Me.america.Text = "America"
        Me.america.UseVisualStyleBackColor = True
        '
        'russia
        '
        Me.russia.AutoSize = True
        Me.russia.Location = New System.Drawing.Point(16, 60)
        Me.russia.Name = "russia"
        Me.russia.Size = New System.Drawing.Size(57, 17)
        Me.russia.TabIndex = 3
        Me.russia.TabStop = True
        Me.russia.Text = "Russia"
        Me.russia.UseVisualStyleBackColor = True
        '
        'france
        '
        Me.france.AutoSize = True
        Me.france.Location = New System.Drawing.Point(16, 83)
        Me.france.Name = "france"
        Me.france.Size = New System.Drawing.Size(58, 17)
        Me.france.TabIndex = 4
        Me.france.TabStop = True
        Me.france.Text = "France"
        Me.france.UseVisualStyleBackColor = True
        '
        'president
        '
        Me.president.AutoSize = True
        Me.president.Location = New System.Drawing.Point(35, 145)
        Me.president.Name = "president"
        Me.president.Size = New System.Drawing.Size(146, 17)
        Me.president.TabIndex = 5
        Me.president.Text = "Prime Minister / President"
        Me.president.UseVisualStyleBackColor = True
        '
        'currency
        '
        Me.currency.AutoSize = True
        Me.currency.Location = New System.Drawing.Point(197, 145)
        Me.currency.Name = "currency"
        Me.currency.Size = New System.Drawing.Size(68, 17)
        Me.currency.TabIndex = 6
        Me.currency.Text = "Currency"
        Me.currency.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.india)
        Me.GroupBox1.Controls.Add(Me.america)
        Me.GroupBox1.Controls.Add(Me.russia)
        Me.GroupBox1.Controls.Add(Me.france)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Countries"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 226)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.currency)
        Me.Controls.Add(Me.president)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents india As RadioButton
    Friend WithEvents america As RadioButton
    Friend WithEvents russia As RadioButton
    Friend WithEvents france As RadioButton
    Friend WithEvents president As CheckBox
    Friend WithEvents currency As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
