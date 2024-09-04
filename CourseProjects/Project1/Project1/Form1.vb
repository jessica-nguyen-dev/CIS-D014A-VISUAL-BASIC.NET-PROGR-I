Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form1

  '********************************************************************************************************
  '*** Program: Project1
  '*** Author : Jessica Nguyen
  '*** Date   : 10/5/2023
  '***
  '*** Purpose: Create a business expense form
  '***
  '*** Prompt: The program requests the name of the organization visited, the date and location of the visit,
  '*** as well as the expenses for meals and entertainment, airplane fares, taxi fares, and lodging in order
  '*** to create the business expense form.
  '********************************************************************************************************

  Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
    'Initialize program
  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    'Closes the window
    Me.Close()

  End Sub

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    'Reset for next expense report
    txtOut.Text = " "
    txtAirfare.Text = " "
    txtDates.Text = " "
    txtLocation.Text = " "
    txtLodging.Text = " "
    txtME.Text = " "
    txtTaxi.Text = " "
    txtVisited.Text = " "
    txtVisited.Focus() 'puts focus on txtVisited


  End Sub

  Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
    'Preview expense report

    On Error Resume Next

    Dim strDescription As String 'enetered by user
    Dim strLocation As String
    Dim strDates As String
    Dim dblME As Double
    Dim dblAirfare As Double
    Dim dblLodging As Double
    Dim dblTaxi As Double
    Dim dblMEHalf As Double 'calculated
    Dim dblSubTotNoMe As Double
    Dim dblDeductable As Double

    'Input the data user entered
    strDescription = txtVisited.Text
    strLocation = txtLocation.Text
    strDates = txtDates.Text
    dblME = CDbl(txtME.Text)
    dblAirfare = CDbl(txtAirfare.Text)
    dblLodging = CDbl(txtLodging.Text)
    dblTaxi = CDbl(txtTaxi.Text)

    'Process the data

    dblMEHalf = dblME / 2
    dblSubTotNoMe = dblAirfare + dblLodging + dblTaxi
    dblDeductable = dblMEHalf + dblSubTotNoMe

    'Display results to user
    Dim strOut = "Business Travel Expense" & vbCrLf & ' vbCrLf makes text go to next line
             "Trip to:           " & vbCrLf &
             strDescription & vbCrLf &
             strDates & " in " & strLocation & vbCrLf & vbCrLf &
             "Meals & Entertainment                               :  " & FormatCurrency(dblME) & vbCrLf & vbCrLf &
             "Airline Fares                                                :  " & FormatCurrency(dblAirfare) & vbCrLf &
             "Lodging                                                      :  " & FormatCurrency(dblLodging) & vbCrLf &
             "Taxi Fares                                                    :  " & FormatCurrency(dblTaxi) & vbCrLf &
             "Total other than M&E                                  : " & FormatCurrency(dblSubTotNoMe) & vbCrLf &
             "50% of M & E                                             : " & FormatCurrency(dblMEHalf) & vbCrLf & vbCrLf &
             "TOTAL DEDUCTABLE EXP                             :  " & FormatCurrency(dblDeductable)

    txtOut.Text = strOut

  End Sub
End Class