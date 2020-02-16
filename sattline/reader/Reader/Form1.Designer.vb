<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sattline_converter
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
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtbInput = New System.Windows.Forms.TextBox()
        Me.BtnSelectProject = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnFilterSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblName.Location = New System.Drawing.Point(12, 9)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(68, 13)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Projekt Path:"
        '
        'TxtbInput
        '
        Me.TxtbInput.Location = New System.Drawing.Point(86, 6)
        Me.TxtbInput.Name = "TxtbInput"
        Me.TxtbInput.Size = New System.Drawing.Size(313, 20)
        Me.TxtbInput.TabIndex = 1
        '
        'BtnSelectProject
        '
        Me.BtnSelectProject.Location = New System.Drawing.Point(405, 6)
        Me.BtnSelectProject.Name = "BtnSelectProject"
        Me.BtnSelectProject.Size = New System.Drawing.Size(80, 20)
        Me.BtnSelectProject.TabIndex = 2
        Me.BtnSelectProject.Text = "Select"
        Me.BtnSelectProject.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(313, 20)
        Me.TextBox1.TabIndex = 3
        '
        'BtnFilterSelect
        '
        Me.BtnFilterSelect.Location = New System.Drawing.Point(405, 49)
        Me.BtnFilterSelect.Name = "BtnFilterSelect"
        Me.BtnFilterSelect.Size = New System.Drawing.Size(80, 20)
        Me.BtnFilterSelect.TabIndex = 4
        Me.BtnFilterSelect.Text = "Select"
        Me.BtnFilterSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filter Path:"
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(173, 94)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(143, 56)
        Me.BtnStart.TabIndex = 6
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'sattline_converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 181)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFilterSelect)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnSelectProject)
        Me.Controls.Add(Me.TxtbInput)
        Me.Controls.Add(Me.LblName)
        Me.Name = "sattline_converter"
        Me.Text = "Sattline Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents TxtbInput As TextBox
    Friend WithEvents BtnSelectProject As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnFilterSelect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStart As Button
End Class
