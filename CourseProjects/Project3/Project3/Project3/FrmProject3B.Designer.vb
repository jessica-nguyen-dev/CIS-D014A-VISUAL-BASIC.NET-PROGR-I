<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProject3B
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
    lblInfo = New Label()
    lblWordOrPhrase = New Label()
    txtInput = New TextBox()
    btnClose = New Button()
    btnCheck = New Button()
    btnHistory = New Button()
    btnReset = New Button()
    SuspendLayout()
    ' 
    ' lblInfo
    ' 
    lblInfo.AutoSize = True
    lblInfo.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    lblInfo.Location = New Point(105, 145)
    lblInfo.Name = "lblInfo"
    lblInfo.Size = New Size(0, 38)
    lblInfo.TabIndex = 0
    ' 
    ' lblWordOrPhrase
    ' 
    lblWordOrPhrase.AutoSize = True
    lblWordOrPhrase.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    lblWordOrPhrase.Location = New Point(48, 65)
    lblWordOrPhrase.Name = "lblWordOrPhrase"
    lblWordOrPhrase.Size = New Size(215, 38)
    lblWordOrPhrase.TabIndex = 1
    lblWordOrPhrase.Text = "Word or Phrase:"
    ' 
    ' txtInput
    ' 
    txtInput.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    txtInput.Location = New Point(356, 62)
    txtInput.Name = "txtInput"
    txtInput.Size = New Size(621, 45)
    txtInput.TabIndex = 2
    ' 
    ' btnClose
    ' 
    btnClose.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    btnClose.Location = New Point(536, 217)
    btnClose.Name = "btnClose"
    btnClose.Size = New Size(201, 97)
    btnClose.TabIndex = 6
    btnClose.Text = "Close"
    btnClose.UseVisualStyleBackColor = True
    ' 
    ' btnCheck
    ' 
    btnCheck.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    btnCheck.Location = New Point(48, 217)
    btnCheck.Name = "btnCheck"
    btnCheck.Size = New Size(201, 97)
    btnCheck.TabIndex = 7
    btnCheck.Text = "Check"
    btnCheck.UseVisualStyleBackColor = True
    ' 
    ' btnHistory
    ' 
    btnHistory.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    btnHistory.Location = New Point(294, 217)
    btnHistory.Name = "btnHistory"
    btnHistory.Size = New Size(201, 97)
    btnHistory.TabIndex = 8
    btnHistory.Text = "Show History"
    btnHistory.UseVisualStyleBackColor = True
    ' 
    ' btnReset
    ' 
    btnReset.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
    btnReset.Location = New Point(776, 217)
    btnReset.Name = "btnReset"
    btnReset.Size = New Size(201, 97)
    btnReset.TabIndex = 9
    btnReset.Text = "Reset"
    btnReset.UseVisualStyleBackColor = True
    ' 
    ' FrmProject3B
    ' 
    AutoScaleDimensions = New SizeF(10F, 25F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(1024, 368)
    Controls.Add(btnReset)
    Controls.Add(btnHistory)
    Controls.Add(btnCheck)
    Controls.Add(btnClose)
    Controls.Add(txtInput)
    Controls.Add(lblWordOrPhrase)
    Controls.Add(lblInfo)
    Name = "FrmProject3B"
    Text = "Project3B"
    ResumeLayout(False)
    PerformLayout()
  End Sub

  Friend WithEvents lblInfo As Label
  Friend WithEvents lblWordOrPhrase As Label
  Friend WithEvents txtInput As TextBox
  Friend WithEvents btnClose As Button
  Friend WithEvents btnCheck As Button
  Friend WithEvents btnHistory As Button
  Friend WithEvents btnReset As Button
End Class
