<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProject2
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
    radB_Regular = New RadioButton()
    radB_Cheese = New RadioButton()
    radB_Bacon = New RadioButton()
    radB_CheeseAndBacon = New RadioButton()
    grpBurgers = New GroupBox()
    grpFries = New GroupBox()
    radF_Large = New RadioButton()
    radF_Medium = New RadioButton()
    radF_Small = New RadioButton()
    grpDrinks = New GroupBox()
    radD_BottledWater = New RadioButton()
    radD_Soda = New RadioButton()
    chkBurgers = New CheckBox()
    chkFries = New CheckBox()
    chkDrinks = New CheckBox()
    btnReset = New Button()
    btnClose = New Button()
    btnTotalCost = New Button()
    lblTotalCost = New Label()
    grpBurgers.SuspendLayout()
    grpFries.SuspendLayout()
    grpDrinks.SuspendLayout()
    SuspendLayout()
    ' 
    ' radB_Regular
    ' 
    radB_Regular.AutoSize = True
    radB_Regular.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radB_Regular.Location = New Point(22, 32)
    radB_Regular.Margin = New Padding(2)
    radB_Regular.Name = "radB_Regular"
    radB_Regular.Size = New Size(123, 33)
    radB_Regular.TabIndex = 0
    radB_Regular.Tag = "4.19"
    radB_Regular.Text = "Regular"
    radB_Regular.UseVisualStyleBackColor = True
    ' 
    ' radB_Cheese
    ' 
    radB_Cheese.AutoSize = True
    radB_Cheese.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radB_Cheese.Location = New Point(22, 69)
    radB_Cheese.Margin = New Padding(2)
    radB_Cheese.Name = "radB_Cheese"
    radB_Cheese.Size = New Size(147, 33)
    radB_Cheese.TabIndex = 1
    radB_Cheese.Tag = "4.79"
    radB_Cheese.Text = "w/Cheese"
    radB_Cheese.UseVisualStyleBackColor = True
    ' 
    ' radB_Bacon
    ' 
    radB_Bacon.AutoSize = True
    radB_Bacon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radB_Bacon.Location = New Point(22, 105)
    radB_Bacon.Margin = New Padding(2)
    radB_Bacon.Name = "radB_Bacon"
    radB_Bacon.Size = New Size(131, 33)
    radB_Bacon.TabIndex = 2
    radB_Bacon.Tag = "4.79"
    radB_Bacon.Text = "w/Bacon"
    radB_Bacon.UseVisualStyleBackColor = True
    ' 
    ' radB_CheeseAndBacon
    ' 
    radB_CheeseAndBacon.AutoSize = True
    radB_CheeseAndBacon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radB_CheeseAndBacon.Location = New Point(22, 142)
    radB_CheeseAndBacon.Margin = New Padding(2)
    radB_CheeseAndBacon.Name = "radB_CheeseAndBacon"
    radB_CheeseAndBacon.Size = New Size(267, 33)
    radB_CheeseAndBacon.TabIndex = 3
    radB_CheeseAndBacon.Tag = "5.39"
    radB_CheeseAndBacon.Text = "w/Cheese and Bacon"
    radB_CheeseAndBacon.UseVisualStyleBackColor = True
    ' 
    ' grpBurgers
    ' 
    grpBurgers.Controls.Add(radB_CheeseAndBacon)
    grpBurgers.Controls.Add(radB_Bacon)
    grpBurgers.Controls.Add(radB_Cheese)
    grpBurgers.Controls.Add(radB_Regular)
    grpBurgers.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
    grpBurgers.Location = New Point(241, 58)
    grpBurgers.Margin = New Padding(2)
    grpBurgers.Name = "grpBurgers"
    grpBurgers.Padding = New Padding(2)
    grpBurgers.Size = New Size(400, 187)
    grpBurgers.TabIndex = 10
    grpBurgers.TabStop = False
    grpBurgers.Text = "Choices for Burgers"
    ' 
    ' grpFries
    ' 
    grpFries.Controls.Add(radF_Large)
    grpFries.Controls.Add(radF_Medium)
    grpFries.Controls.Add(radF_Small)
    grpFries.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
    grpFries.Location = New Point(241, 313)
    grpFries.Margin = New Padding(2)
    grpFries.Name = "grpFries"
    grpFries.Padding = New Padding(2)
    grpFries.Size = New Size(400, 149)
    grpFries.TabIndex = 11
    grpFries.TabStop = False
    grpFries.Text = "Choices for Fries"
    ' 
    ' radF_Large
    ' 
    radF_Large.AutoSize = True
    radF_Large.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radF_Large.Location = New Point(21, 104)
    radF_Large.Margin = New Padding(2)
    radF_Large.Name = "radF_Large"
    radF_Large.Size = New Size(100, 33)
    radF_Large.TabIndex = 2
    radF_Large.Tag = "4.99"
    radF_Large.Text = "Large"
    radF_Large.UseVisualStyleBackColor = True
    ' 
    ' radF_Medium
    ' 
    radF_Medium.AutoSize = True
    radF_Medium.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radF_Medium.Location = New Point(21, 68)
    radF_Medium.Margin = New Padding(2)
    radF_Medium.Name = "radF_Medium"
    radF_Medium.Size = New Size(125, 33)
    radF_Medium.TabIndex = 1
    radF_Medium.Tag = "3.09"
    radF_Medium.Text = "Medium"
    radF_Medium.UseVisualStyleBackColor = True
    ' 
    ' radF_Small
    ' 
    radF_Small.AutoSize = True
    radF_Small.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radF_Small.Location = New Point(21, 31)
    radF_Small.Margin = New Padding(2)
    radF_Small.Name = "radF_Small"
    radF_Small.Size = New Size(99, 33)
    radF_Small.TabIndex = 0
    radF_Small.Tag = "2.39"
    radF_Small.Text = "Small"
    radF_Small.UseVisualStyleBackColor = True
    ' 
    ' grpDrinks
    ' 
    grpDrinks.Controls.Add(radD_BottledWater)
    grpDrinks.Controls.Add(radD_Soda)
    grpDrinks.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
    grpDrinks.Location = New Point(241, 534)
    grpDrinks.Margin = New Padding(2)
    grpDrinks.Name = "grpDrinks"
    grpDrinks.Padding = New Padding(2)
    grpDrinks.Size = New Size(400, 115)
    grpDrinks.TabIndex = 11
    grpDrinks.TabStop = False
    grpDrinks.Text = "Choices for Drinks"
    ' 
    ' radD_BottledWater
    ' 
    radD_BottledWater.AutoSize = True
    radD_BottledWater.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radD_BottledWater.Location = New Point(21, 68)
    radD_BottledWater.Margin = New Padding(2)
    radD_BottledWater.Name = "radD_BottledWater"
    radD_BottledWater.Size = New Size(183, 33)
    radD_BottledWater.TabIndex = 1
    radD_BottledWater.Tag = "1.49"
    radD_BottledWater.Text = "Bottled Water"
    radD_BottledWater.UseVisualStyleBackColor = True
    ' 
    ' radD_Soda
    ' 
    radD_Soda.AutoSize = True
    radD_Soda.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    radD_Soda.Location = New Point(21, 31)
    radD_Soda.Margin = New Padding(2)
    radD_Soda.Name = "radD_Soda"
    radD_Soda.Size = New Size(95, 33)
    radD_Soda.TabIndex = 0
    radD_Soda.Tag = "1.69"
    radD_Soda.Text = "Soda"
    radD_Soda.UseVisualStyleBackColor = True
    ' 
    ' chkBurgers
    ' 
    chkBurgers.AutoSize = True
    chkBurgers.Checked = True
    chkBurgers.CheckState = CheckState.Checked
    chkBurgers.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
    chkBurgers.Location = New Point(72, 142)
    chkBurgers.Name = "chkBurgers"
    chkBurgers.Size = New Size(139, 36)
    chkBurgers.TabIndex = 0
    chkBurgers.Text = "Burgers"
    chkBurgers.UseVisualStyleBackColor = True
    ' 
    ' chkFries
    ' 
    chkFries.AutoSize = True
    chkFries.Checked = True
    chkFries.CheckState = CheckState.Checked
    chkFries.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
    chkFries.Location = New Point(72, 368)
    chkFries.Name = "chkFries"
    chkFries.Size = New Size(103, 36)
    chkFries.TabIndex = 1
    chkFries.Text = "Fries"
    chkFries.UseVisualStyleBackColor = True
    ' 
    ' chkDrinks
    ' 
    chkDrinks.AutoSize = True
    chkDrinks.Checked = True
    chkDrinks.CheckState = CheckState.Checked
    chkDrinks.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
    chkDrinks.Location = New Point(72, 571)
    chkDrinks.Name = "chkDrinks"
    chkDrinks.Size = New Size(120, 36)
    chkDrinks.TabIndex = 2
    chkDrinks.Text = "Drinks"
    chkDrinks.UseVisualStyleBackColor = True
    ' 
    ' btnReset
    ' 
    btnReset.Location = New Point(715, 335)
    btnReset.Name = "btnReset"
    btnReset.Size = New Size(224, 102)
    btnReset.TabIndex = 4
    btnReset.Text = "&Reset"
    btnReset.UseVisualStyleBackColor = True
    ' 
    ' btnClose
    ' 
    btnClose.Location = New Point(715, 548)
    btnClose.Name = "btnClose"
    btnClose.Size = New Size(224, 101)
    btnClose.TabIndex = 5
    btnClose.Text = "&Close"
    btnClose.UseVisualStyleBackColor = True
    ' 
    ' btnTotalCost
    ' 
    btnTotalCost.Location = New Point(715, 76)
    btnTotalCost.Name = "btnTotalCost"
    btnTotalCost.Size = New Size(224, 102)
    btnTotalCost.TabIndex = 3
    btnTotalCost.Text = "&Total Cost"
    btnTotalCost.UseVisualStyleBackColor = True
    ' 
    ' lblTotalCost
    ' 
    lblTotalCost.AutoSize = True
    lblTotalCost.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
    lblTotalCost.Location = New Point(677, 200)
    lblTotalCost.Name = "lblTotalCost"
    lblTotalCost.Size = New Size(265, 29)
    lblTotalCost.TabIndex = 18
    lblTotalCost.Text = "Ready for next meal..."
    ' 
    ' Form1
    ' 
    AutoScaleDimensions = New SizeF(14F, 29F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(1025, 712)
    Controls.Add(lblTotalCost)
    Controls.Add(btnTotalCost)
    Controls.Add(btnClose)
    Controls.Add(btnReset)
    Controls.Add(chkDrinks)
    Controls.Add(chkFries)
    Controls.Add(chkBurgers)
    Controls.Add(grpDrinks)
    Controls.Add(grpFries)
    Controls.Add(grpBurgers)
    Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
    Margin = New Padding(4, 3, 4, 3)
    Name = "Form1"
    Text = "Project2: Fast Food Order Menu"
    grpBurgers.ResumeLayout(False)
    grpBurgers.PerformLayout()
    grpFries.ResumeLayout(False)
    grpFries.PerformLayout()
    grpDrinks.ResumeLayout(False)
    grpDrinks.PerformLayout()
    ResumeLayout(False)
    PerformLayout()
  End Sub

  Friend WithEvents radB_Regular As RadioButton
  Friend WithEvents radB_Cheese As RadioButton
  Friend WithEvents radB_Bacon As RadioButton
  Friend WithEvents radB_CheeseAndBacon As RadioButton
  Friend WithEvents grpBurgers As GroupBox
  Friend WithEvents grpFries As GroupBox
  Friend WithEvents radF_Large As RadioButton
  Friend WithEvents radF_Medium As RadioButton
  Friend WithEvents radF_Small As RadioButton
  Friend WithEvents grpDrinks As GroupBox
  Friend WithEvents radD_BottledWater As RadioButton
  Friend WithEvents radD_Soda As RadioButton
  Friend WithEvents chkBurgers As CheckBox
  Friend WithEvents chkFries As CheckBox
  Friend WithEvents chkDrinks As CheckBox
  Friend WithEvents btnReset As Button
  Friend WithEvents btnClose As Button
  Friend WithEvents btnTotalCost As Button
  Friend WithEvents lblTotalCost As Label
End Class
