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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fullname_text = New System.Windows.Forms.TextBox()
        Me.age_text = New System.Windows.Forms.TextBox()
        Me.address_text = New System.Windows.Forms.TextBox()
        Me.txt_export = New System.Windows.Forms.Button()
        Me.xml_export = New System.Windows.Forms.Button()
        Me.json_export = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Work Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Work Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Work Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADDRESS"
        '
        'fullname_text
        '
        Me.fullname_text.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_text.Location = New System.Drawing.Point(234, 98)
        Me.fullname_text.Name = "fullname_text"
        Me.fullname_text.Size = New System.Drawing.Size(290, 31)
        Me.fullname_text.TabIndex = 3
        '
        'age_text
        '
        Me.age_text.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age_text.Location = New System.Drawing.Point(234, 154)
        Me.age_text.Name = "age_text"
        Me.age_text.Size = New System.Drawing.Size(290, 31)
        Me.age_text.TabIndex = 4
        '
        'address_text
        '
        Me.address_text.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_text.Location = New System.Drawing.Point(234, 212)
        Me.address_text.Name = "address_text"
        Me.address_text.Size = New System.Drawing.Size(290, 31)
        Me.address_text.TabIndex = 5
        '
        'txt_export
        '
        Me.txt_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_export.Font = New System.Drawing.Font("Work Sans Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_export.Location = New System.Drawing.Point(136, 284)
        Me.txt_export.Name = "txt_export"
        Me.txt_export.Size = New System.Drawing.Size(95, 62)
        Me.txt_export.TabIndex = 6
        Me.txt_export.Text = "Export as .txt"
        Me.txt_export.UseVisualStyleBackColor = False
        '
        'xml_export
        '
        Me.xml_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xml_export.Font = New System.Drawing.Font("Work Sans Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xml_export.Location = New System.Drawing.Point(276, 284)
        Me.xml_export.Name = "xml_export"
        Me.xml_export.Size = New System.Drawing.Size(95, 62)
        Me.xml_export.TabIndex = 7
        Me.xml_export.Text = "Export as .xml"
        Me.xml_export.UseVisualStyleBackColor = False
        '
        'json_export
        '
        Me.json_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.json_export.Font = New System.Drawing.Font("Work Sans Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.json_export.Location = New System.Drawing.Point(419, 284)
        Me.json_export.Name = "json_export"
        Me.json_export.Size = New System.Drawing.Size(95, 62)
        Me.json_export.TabIndex = 8
        Me.json_export.Text = "Export as .json"
        Me.json_export.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 444)
        Me.Controls.Add(Me.json_export)
        Me.Controls.Add(Me.xml_export)
        Me.Controls.Add(Me.txt_export)
        Me.Controls.Add(Me.address_text)
        Me.Controls.Add(Me.age_text)
        Me.Controls.Add(Me.fullname_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fullname_text As TextBox
    Friend WithEvents age_text As TextBox
    Friend WithEvents address_text As TextBox
    Friend WithEvents txt_export As Button
    Friend WithEvents xml_export As Button
    Friend WithEvents json_export As Button
End Class
