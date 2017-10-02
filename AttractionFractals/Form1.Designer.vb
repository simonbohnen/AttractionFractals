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
        Me.DrawFractal = New System.Windows.Forms.Button()
        Me.addPoint = New System.Windows.Forms.Button()
        Me.attPointsList = New System.Windows.Forms.ListBox()
        Me.delPoint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DrawFractal
        '
        Me.DrawFractal.Location = New System.Drawing.Point(771, 12)
        Me.DrawFractal.Name = "DrawFractal"
        Me.DrawFractal.Size = New System.Drawing.Size(124, 23)
        Me.DrawFractal.TabIndex = 0
        Me.DrawFractal.Text = "Draw fractal"
        Me.DrawFractal.UseVisualStyleBackColor = True
        '
        'addPoint
        '
        Me.addPoint.Location = New System.Drawing.Point(771, 41)
        Me.addPoint.Name = "addPoint"
        Me.addPoint.Size = New System.Drawing.Size(124, 23)
        Me.addPoint.TabIndex = 1
        Me.addPoint.Text = "Add attraction point"
        Me.addPoint.UseVisualStyleBackColor = True
        '
        'attPointsList
        '
        Me.attPointsList.FormattingEnabled = True
        Me.attPointsList.Location = New System.Drawing.Point(771, 114)
        Me.attPointsList.Name = "attPointsList"
        Me.attPointsList.Size = New System.Drawing.Size(124, 95)
        Me.attPointsList.TabIndex = 2
        '
        'delPoint
        '
        Me.delPoint.Location = New System.Drawing.Point(771, 70)
        Me.delPoint.Name = "delPoint"
        Me.delPoint.Size = New System.Drawing.Size(124, 23)
        Me.delPoint.TabIndex = 3
        Me.delPoint.Text = "Delete attraction point"
        Me.delPoint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(768, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Attraction points:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 761)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delPoint)
        Me.Controls.Add(Me.attPointsList)
        Me.Controls.Add(Me.addPoint)
        Me.Controls.Add(Me.DrawFractal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawFractal As Button
    Friend WithEvents addPoint As Button
    Friend WithEvents attPointsList As ListBox
    Friend WithEvents delPoint As Button
    Friend WithEvents Label1 As Label
End Class
