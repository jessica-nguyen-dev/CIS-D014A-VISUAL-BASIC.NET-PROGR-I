<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShowDisplay
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
    lstHistory = New ListBox()
    btnClose = New Button()
    SuspendLayout()
    ' 
    ' lstHistory
    ' 
    lstHistory.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lstHistory.FormattingEnabled = True
    lstHistory.ItemHeight = 32
    lstHistory.Location = New Point(56, 68)
    lstHistory.Name = "lstHistory"
    lstHistory.Size = New Size(939, 452)
    lstHistory.TabIndex = 0
    ' 
    ' btnClose
    ' 
    btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    btnClose.Location = New Point(418, 555)
    btnClose.Name = "btnClose"
    btnClose.Size = New Size(217, 109)
    btnClose.TabIndex = 1
    btnClose.Text = "Close"
    btnClose.UseVisualStyleBackColor = True
    ' 
    ' FrmShowDisplay
    ' 
    AutoScaleDimensions = New SizeF(10F, 25F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(1052, 704)
    Controls.Add(btnClose)
    Controls.Add(lstHistory)
    Name = "FrmShowDisplay"
    Text = "FrmHistory"
    ResumeLayout(False)
  End Sub

  Friend WithEvents lstHistory As ListBox
  Friend WithEvents btnClose As Button
End Class
