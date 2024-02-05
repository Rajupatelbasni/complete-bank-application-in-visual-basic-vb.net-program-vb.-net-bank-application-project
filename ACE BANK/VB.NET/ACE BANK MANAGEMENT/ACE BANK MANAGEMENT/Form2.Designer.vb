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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenaccountDataSet = New ACE_BANK_MANAGEMENT.openaccountDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.OpenaccountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(254, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACCOUNT MANAGEMENT SYSTEM"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(297, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD NEW AC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(522, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 53)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "REMOVE AC"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(297, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 49)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "WITHDROW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(522, 309)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 49)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "DEPOSIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(807, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 37)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "LOG OUT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenaccountDataSet
        '
        Me.OpenaccountDataSet.DataSetName = "openaccountDataSet"
        Me.OpenaccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "A̳̿͟͞U̳̿͟͞T̳̿͟͞H̳̿͟͞O̳̿͟͞R̳̿͟͞: R̳̿͟͞A̳̿͟͞J̳̿͟͞U̳̿͟͞ P̳̿͟͞A̳̿͟͞T̳̿͟͞E̳̿͟͞L̳̿͟͞ B͞" & _
            "̳̿͟A̳̿͟͞S̳̿͟͞N̳̿͟͞I̳̿͟͞"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 720)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.OpenaccountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenaccountDataSet As ACE_BANK_MANAGEMENT.openaccountDataSet
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
