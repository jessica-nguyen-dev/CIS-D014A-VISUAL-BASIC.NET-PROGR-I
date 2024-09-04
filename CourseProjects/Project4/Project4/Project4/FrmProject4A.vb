Imports System.Security.Cryptography

Public Class FrmProject4A

  '********************************************************************************************************
  '*** Program: Project4A
  '*** Author : Jessica Nguyen
  '*** Date   : 11/30/2023
  '***
  '*** Purpose:  Determine Poker Hand.
  '***
  '*** Prompt: Program requests five cards as input from the user, creates a related array, totals the rows
  '*** And columns,then uses those totals to determine the type of hand. 
  '********************************************************************************************************

  'Class level constants

  Const conROYALFLUSH As String = "Royal Flush"
  Const conSTRAIGHTFLUSH As String = "Straight Flush"
  Const conFOUROFAKIND As String = "Four of a Kind"
  Const conFULLHOUSE As String = "Full House"
  Const conFLUSH As String = "Flush"
  Const conSTRAIGHT As String = "Straight"
  Const conTHREEOFAKIND As String = "Three of a Kind"
  Const conTWOPAIR As String = "Two Pair"
  Const conPAIR As String = "A Pair"
  Const conNOTHING As String = "Nothing"
  Const conOK As String = "***OK***"

  'CLass level variables

  Dim aryintCards(4, 14) As Integer
  Dim aryChkboxes(52) As CheckBox   'Not using 0 index
  Dim intCardsSelected As Integer

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    'Close program
    Me.Close()

  End Sub

  Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
    'Restart Program
    Call Restart()

  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Setup the program
    Call SetupCheckBoxes()
    Call Restart()

  End Sub

  Private Sub Restart()
    'Restart program
    'Uncheck all checkboxes
    For i As Integer = 1 To 52
      aryChkboxes(i).Checked = False
    Next

    'Reset number of selected cards
    intCardsSelected = 0
    lblInfo.Text = "Select 5 cards."

  End Sub

  Private Sub SetupCheckBoxes()
    'Set up array to hold 52 checkboxes

    'Clubs
    aryChkboxes(1) = chkC_Ace
    aryChkboxes(2) = chkC_King
    aryChkboxes(3) = chkC_Queen
    aryChkboxes(4) = chkC_Jack
    aryChkboxes(5) = chkC_10
    aryChkboxes(6) = chkC_09
    aryChkboxes(7) = chkC_08
    aryChkboxes(8) = chkC_07
    aryChkboxes(9) = chkC_06
    aryChkboxes(10) = chkC_05
    aryChkboxes(11) = chkC_04
    aryChkboxes(12) = chkC_03
    aryChkboxes(13) = chkC_02

    'Diamonds
    aryChkboxes(14) = chkD_Ace
    aryChkboxes(15) = chkD_King
    aryChkboxes(16) = chkD_Queen
    aryChkboxes(17) = chkD_Jack
    aryChkboxes(18) = chkD_10
    aryChkboxes(19) = chkD_09
    aryChkboxes(20) = chkD_08
    aryChkboxes(21) = chkD_07
    aryChkboxes(22) = chkD_06
    aryChkboxes(23) = chkD_05
    aryChkboxes(24) = chkD_04
    aryChkboxes(25) = chkD_03
    aryChkboxes(26) = chkD_02

    'Hearts
    aryChkboxes(27) = chkH_Ace
    aryChkboxes(28) = chkH_King
    aryChkboxes(29) = chkH_Queen
    aryChkboxes(30) = chkH_Jack
    aryChkboxes(31) = chkH_10
    aryChkboxes(32) = chkH_09
    aryChkboxes(33) = chkH_08
    aryChkboxes(34) = chkH_07
    aryChkboxes(35) = chkH_06
    aryChkboxes(36) = chkH_05
    aryChkboxes(37) = chkH_04
    aryChkboxes(38) = chkH_03
    aryChkboxes(39) = chkH_02

    'Spades
    aryChkboxes(40) = chkS_Ace
    aryChkboxes(41) = chkS_King
    aryChkboxes(42) = chkS_Queen
    aryChkboxes(43) = chkS_Jack
    aryChkboxes(44) = chkS_10
    aryChkboxes(45) = chkS_09
    aryChkboxes(46) = chkS_08
    aryChkboxes(47) = chkS_07
    aryChkboxes(48) = chkS_06
    aryChkboxes(49) = chkS_05
    aryChkboxes(50) = chkS_04
    aryChkboxes(51) = chkS_03
    aryChkboxes(52) = chkS_02

  End Sub

  Private Sub chkC_Ace_CheckedChanged(sender As Object, e As EventArgs) Handles _
    chkC_Ace.CheckedChanged, chkC_King.CheckedChanged, chkC_Queen.CheckedChanged, chkC_Jack.CheckedChanged, chkC_10.CheckedChanged, chkC_09.CheckedChanged, chkC_08.CheckedChanged, chkC_07.CheckedChanged, chkC_06.CheckedChanged, chkC_05.CheckedChanged, chkC_04.CheckedChanged, chkC_03.CheckedChanged, chkC_02.CheckedChanged,
    chkD_Ace.CheckedChanged, chkD_King.CheckedChanged, chkD_Queen.CheckedChanged, chkD_Jack.CheckedChanged, chkD_10.CheckedChanged, chkD_09.CheckedChanged, chkD_08.CheckedChanged, chkD_07.CheckedChanged, chkD_06.CheckedChanged, chkD_05.CheckedChanged, chkD_04.CheckedChanged, chkD_03.CheckedChanged, chkD_02.CheckedChanged,
    chkH_Ace.CheckedChanged, chkH_King.CheckedChanged, chkH_Queen.CheckedChanged, chkH_Jack.CheckedChanged, chkH_10.CheckedChanged, chkH_09.CheckedChanged, chkH_08.CheckedChanged, chkH_07.CheckedChanged, chkH_06.CheckedChanged, chkH_05.CheckedChanged, chkH_04.CheckedChanged, chkH_03.CheckedChanged, chkH_02.CheckedChanged,
    chkS_Ace.CheckedChanged, chkS_King.CheckedChanged, chkS_Queen.CheckedChanged, chkS_Jack.CheckedChanged, chkS_10.CheckedChanged, chkS_09.CheckedChanged, chkS_08.CheckedChanged, chkS_07.CheckedChanged, chkS_06.CheckedChanged, chkS_05.CheckedChanged, chkS_04.CheckedChanged, chkS_03.CheckedChanged, chkS_02.CheckedChanged

    'Process card selection/unselection

    Dim chkIn As CheckBox = sender
    Dim aryIJ() As String
    Dim i, j As Integer 'Array Indexes
    Static bolSkip As Boolean

    'Check if program is invoking this event

    If bolSkip = True Then
      bolSkip = False
      Exit Sub
    End If

    'Set indexes i and j

    aryIJ = chkIn.Tag.split(",")
    i = CInt(aryIJ(0))
    j = CInt(aryIJ(1))

    lblInfo.Text = ""

    'Handling card check (rename this part later when I understand what's going on)

    If chkIn.Checked = True Then

      'If user checked a box

      If intCardsSelected = 5 Then
        lblInfo.Text = "Selected 5 cards already. " &
                       "Uncheck another card to check this one."
        bolSkip = True
        chkIn.Checked = False
        Exit Sub

      End If

      intCardsSelected += 1
      aryintCards(i, j) = 1 '1 means selected

    Else

      'If user unchecked a box

      intCardsSelected -= 1
      aryintCards(i, j) = 0 '0 means deselected

    End If

  End Sub

  Private Sub btnShowHand_Click(sender As Object, e As EventArgs) Handles btnShowHand.Click

    'Check player's hand
    Dim strReturn As String

    'Check if 5 cards are selected

    lblInfo.Text = ""

    If intCardsSelected <> 5 Then
      lblInfo.Text = "Must select 5 cards."
      Exit Sub
    End If

    'Output Result
    Call TotalUp()
    strReturn = CheckHands()
    lblInfo.Text = strReturn

  End Sub

  Private Function CheckHands() As String

    'Set default message as conOK
    Dim strReturn As String = conOK

    'Check for Flush, Straight-Flush, or Royal-Flush

    strReturn = CheckFlush()
    If strReturn <> conOK Then 'return strReturn if changed from conOK
      Return strReturn
    End If

    'Check for Straight

    strReturn = CheckStraight()
    If strReturn <> conOK Then
      Return strReturn
    End If

    'Check for Four of a Kind

    strReturn = CheckFourOfAKind()
    If strReturn <> conOK Then
      Return strReturn
    End If

    'Check for Full House (come back to this after two pair and three of a kind)?

    strReturn = CheckFullHouse()
    If strReturn <> conOK Then
      Return strReturn
    End If

    'Check for Three of a Kind

    strReturn = CheckThreeOfAKind()
    If strReturn <> conOK Then
      Return strReturn
    End If

    'Check for Two Pair

    strReturn = CheckTwoPair()
    If strReturn <> conOK Then
      Return strReturn
    End If

    'Check for One Pair

    strReturn = CheckPair()
    If strReturn <> conOK Then
      Return strReturn
    End If

    'Must be nothing if all were checked but none returned anything
    Return conNOTHING

  End Function

  Private Function CheckFlush() As String

    'Check for Flush, Straight-Flush, or Royal-Flush

    Dim strRet As String = conOK
    Dim strTemp As String   'For straight/royal
    Dim i As Integer        'loop counter

    'Check for Flush

    For i = 1 To 4 'Clubs(1), Diamonds(2), Hearts(3), Spades(4)

      If aryintCards(i, 0) = 5 Then 'checks if all selected cards are of the same suit (flush)

        strRet = conFLUSH
        strTemp = CheckStraight()

        If strTemp = conSTRAIGHT Then 'checks if straight flush (flush with consecutive cards)

          strRet = conSTRAIGHTFLUSH

          If aryintCards(0, 14) = 1 And aryintCards(0, 13) = 1 Then 'checks if royal flush (king and ace should be selected)
            strRet = conROYALFLUSH
          End If

        End If

        Return strRet 'Returns either Flush, Straight-Flush, or Royal-Flush

      End If

    Next

    Return strRet 'Returns conOk if none of the above apply

  End Function

  Private Function CheckStraight() As String

    'Checks for a straight hand

    Dim strRet As String = conOK 'Default value

    For j As Integer = 1 To 10 'Iterates thorugh columns
      If aryintCards(0, j + 0) = 1 And 'Checks to see if four in a row are selected (can be within the same suit or not)
         aryintCards(0, j + 1) = 1 And
         aryintCards(0, j + 2) = 1 And
         aryintCards(0, j + 3) = 1 And
         aryintCards(0, j + 4) = 1 Then
        Return conSTRAIGHT 'Returns conSTRAIGHT when a straight is found
      End If
    Next

    Return strRet 'Returns conOk if none of the above apply

  End Function

  Private Function CheckFourOfAKind() As String

    'Check each column's total (0,j) for a 4. If there is a 4 then it must be four of a kind!

    Dim strRet As String = conOK 'Default Value

    For j As Integer = 1 To 13 'Iterates thorugh each column

      If aryintCards(0, j) = 4 Then 'Checks all card types (Ace, 1, 2, 3, etc) and sees if there are 4 of any
        Return conFOUROFAKIND
      End If

    Next

    Return strRet 'Returns conOk if the above does not apply

  End Function

  Private Function CheckFullHouse() As String

    'Checks for 3 of same value and 2 of another same value

    Dim strRet As String = conOK 'Default Value
    Dim bolFoundThreeOfAKind As Boolean = False
    Dim bolFoundPair As Boolean = False

    ' Check for Three of a Kind
    If CheckThreeOfAKind() = conTHREEOFAKIND Then
      bolFoundThreeOfAKind = True
    End If

    ' Check for a Pair
    If CheckPair() = conPAIR Then
      bolFoundPair = True
    End If

    ' If both Three of a Kind and a Pair are found, it's a Full House
    If bolFoundThreeOfAKind And bolFoundPair Then
      Return conFULLHOUSE
    End If

    Return strRet 'Returns conOk if the above does not apply

  End Function

  Private Function CheckThreeOfAKind() As String

    'Checks if there is 3 of the same suit

    Dim strRet As String = conOK 'Default Value

    For j As Integer = 1 To 13

      If aryintCards(0, j) = 3 Then
        Return conTHREEOFAKIND

      End If

    Next

    Return strRet 'Returns conOk if the above does not apply

  End Function

  Private Function CheckTwoPair() As String 'hmmm

    'Check for a two pair (two pairs of the same value)
    Dim strReturn As String = conOK 'Default Value
    Dim intPairCount As Integer = 0

    For j As Integer = 1 To 13 'Iterate through each column

      If aryintCards(0, j) = 2 Then
        intPairCount += 1
      End If

      ' If two pairs are found, return conTWOPAIR
      If intPairCount = 2 Then
        Return conTWOPAIR
      End If

    Next

    Return strReturn 'Returns conOk if the above does not apply

  End Function

  Private Function CheckPair() As String

    Dim strReturn As String = conOK 'Default Value

    For j As Integer = 1 To 13 'Iterate through each column

      If aryintCards(0, j) = 2 Then
        Return conPAIR
      End If

    Next

    Return strReturn 'Returns conOk if the above does not apply

  End Function

  Private Sub TotalUp()

    'Totals rows and columns, copies column 1 to column 14 (Aces)

    Dim i, j As Integer   'loop counter

    'Copy Col 1 to Col 14 (Aces)
    For i = 1 To 4
      aryintCards(i, 14) = aryintCards(i, 1) 'similar to how the excel sheet automatically does it
    Next

    'Sum up the Gray area (row totals)
    For i = 1 To 4
      aryintCards(i, 0) = 0
      For j = 1 To 13
        aryintCards(i, 0) += aryintCards(i, j) 'similar to how the excel sheet automatically does it
      Next
    Next

    'Sum up the Orange area (column totals)
    For j = 0 To 14
      aryintCards(0, j) = 0
      For i = 1 To 4
        aryintCards(0, j) += aryintCards(i, j) 'similar to how the excel sheet automatically does it
      Next
    Next

  End Sub

End Class
