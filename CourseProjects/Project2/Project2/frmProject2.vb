Public Class frmProject2

  '************************************************************************************
  '*** Program: Project2
  '*** Author : Jessica Nguyen
  '*** Date   : 10/17/2023
  '***
  '*** Purpose: Create a fast food order menu
  '***
  '*** Prompt: The program calculates cost of a fast food meal based on the user's
  '*** selection of items from the menu.
  '************************************************************************************

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Setup Program

    'Setup the Pricing (Burgers)
    radB_Regular.Text &= " (" &
      FormatCurrency(radB_Regular.Tag) & ")"
    radB_Cheese.Text &= " (" &
      FormatCurrency(radB_Cheese.Tag) & ")"
    radB_Bacon.Text &= " (" &
      FormatCurrency(radB_Bacon.Tag) & ")"
    radB_CheeseAndBacon.Text &= " (" &
      FormatCurrency(radB_CheeseAndBacon.Tag) & ")"

    'Setup the Pricing (Fries)
    radF_Small.Text &= " (" &
      FormatCurrency(radF_Small.Tag) & ")"
    radF_Medium.Text &= " (" &
      FormatCurrency(radF_Medium.Tag) & ")"
    radF_Large.Text &= " (" &
      FormatCurrency(radF_Large.Tag) & ")"

    'Setup the Pricing (Drinks)
    radD_Soda.Text &= " (" &
      FormatCurrency(radD_Soda.Tag) & ")"
    radD_BottledWater.Text &= " (" &
      FormatCurrency(radD_BottledWater.Tag) & ")"

    'Uncheck boxes on form load
    chkBurgers.Checked = False
    chkFries.Checked = False
    chkDrinks.Checked = False

    'Requests user to input meal selections
    lblTotalCost.Text = "Ready for next meal... "

  End Sub

  Private Sub chkBurgers_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurgers.CheckedChanged
    'Burgers Checked
    If chkBurgers.Checked = True Then 'If checked then automatically check default option (Regular)
      radB_Regular.Checked = True
      grpBurgers.Visible = True
    Else                              'Hide group if unchecked 
      grpBurgers.Visible = False
    End If

  End Sub

  Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
    'Fries Checked
    If chkFries.Checked = True Then 'If checked then automatically check default option (Small)
      radF_Small.Checked = True
      grpFries.Visible = True
    Else                            'Hide group if unchecked 
      grpFries.Visible = False
    End If

  End Sub

  Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged
    'Drinks Checked
    If chkDrinks.Checked = True Then 'If checked then automatically check default option (Soda)
      radD_Soda.Checked = True
      grpDrinks.Visible = True
    Else                             'Hide group if unchecked 
      grpDrinks.Visible = False
    End If

  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    'Close the Program
    Me.Close()
  End Sub

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    'Reset Program
    chkBurgers.Checked = False
    chkFries.Checked = False
    chkDrinks.Checked = False

    lblTotalCost.Text = "Ready for next meal... "

  End Sub

  Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click

    'Calculate Total Cost

    Dim dblTotalCost As Double 'declare variable to hold total cost

    'Output If Nothing is Checked
    If chkBurgers.Checked = False And
       chkFries.Checked = False And
       chkDrinks.Checked = False Then
      lblTotalCost.Text = "Must Check Something..."
    End If

    'Add Burger Cost
    If chkBurgers.Checked Then
      If radB_Regular.Checked Then
        dblTotalCost += radB_Regular.Tag
      ElseIf radB_Cheese.Checked Then
        dblTotalCost += radB_Cheese.Tag
      ElseIf radB_Bacon.Checked Then
        dblTotalCost += radB_Bacon.Tag
      ElseIf radB_CheeseAndBacon.Checked Then
        dblTotalCost += radB_CheeseAndBacon.Tag
      End If
    End If

    'Add Fries Cost
    If chkFries.Checked Then
      If radF_Small.Checked Then
        dblTotalCost += radF_Small.Tag
      ElseIf radF_Medium.Checked Then
        dblTotalCost += radF_Medium.Tag
      ElseIf radF_Large.Checked Then
        dblTotalCost += radF_Large.Tag
      End If
    End If

    'Add Drink Cost
    If chkDrinks.Checked Then
      If radD_Soda.Checked Then
        dblTotalCost += radD_Soda.Tag
      ElseIf radD_BottledWater.Checked Then
        dblTotalCost += radD_BottledWater.Tag
      End If
    End If

    'Output Total Cost
    lblTotalCost.Text = "Total Cost: " & FormatCurrency(dblTotalCost)

  End Sub

End Class