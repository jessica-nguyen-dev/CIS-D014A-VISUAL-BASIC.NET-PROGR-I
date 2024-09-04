Public Class FrmProject3B

  '********************************************************************************************************
  '*** Program: Project3
  '*** Author : Jessica Nguyen
  '*** Date   : 11/12/2023
  '***
  '*** Purpose: Determine if a word or phrase is a palindrome.
  '***
  '*** Prompt: The program requests user to input a word or phrase and then determines if
  '*** it is a palindrome, disregarding any non alpha-numeric characters!
  '********************************************************************************************************

  'Class Level Variables and Constants
  Dim lstHistory As New List(Of String)

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    'Reset Program
    Call Reset()

  End Sub

  Private Sub FrmProject3B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Reset Program on Form Load
    Call Reset()

  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    'Close Program
    Me.Close()

  End Sub

  Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
    'Checks if user input is a palindrome, then adds result to lstHistory

    'Declare Variables
    Dim strIn As String
    Dim strCheck As String

    'Gather User Input
    strIn = CStr(txtInput.Text)

    'Verify Textbox is Not Empty
    If strIn.Length = 0 Then
      lblInfo.Text = "Must enter a word or phrase"
      Exit Sub
    End If

    'Convert strIn to ONLY Alphanumeric Characters 
    strCheck = ReturnOnlyAlhpa_Numeric(strIn)

    'Check if Input is a Palimdrome
    If IsPalindrome(strCheck) Then
      lblInfo.Text = "Is a Palindrome"
      lstHistory.Add(strIn & " " & lblInfo.Text)
    Else
      lblInfo.Text = "Is Not a palindrome"
      lstHistory.Add(strIn & " " & lblInfo.Text)
    End If

  End Sub

  Private Sub Reset()
    'Reset Program
    lstHistory.Clear()
    lblInfo.Text = "Nothing to display yet."
    txtInput.Text = ""
    txtInput.Focus()

  End Sub

  Private Function IsPalindrome(ByVal strCheck As String) As Boolean
    'Checks if a word or phrase is a palindrome by seeing if its the same as its reverse

    'Declare Required Variables
    Dim strReverse As String = ""

    'Build String in Reverse
    For i As Integer = strCheck.Length - 1 To 0 Step -1
      strReverse &= strCheck(i)
    Next

    'Compare strReverse to strCheck
    If strReverse = strCheck Then
      Return True
    Else
      Return False
    End If

  End Function


  Private Function ReturnOnlyAlhpa_Numeric(ByVal strIn As String) As String
    'Converts user input to uppercase, and removes non-alphanumeric characters

    'Decleare strOut (Variable to be Returned)
    Dim strOut As String = ""

    'Convert Original String to Uppercase
    strIn = strIn.ToUpper

    'Build strOut Using Only Letters and Numbers
    For i As Integer = 0 To strIn.Length - 1

      If ((strIn(i) >= "A") And (strIn(i) <= "Z")) Or ((strIn(i) >= "0") And (strIn(i) <= "9")) Then
        strOut &= strIn(i)

      End If

    Next

    'Return Result 
    Return strOut

  End Function

  Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
    'Displays history of all checked words and phrases

    'Create New Form
    Dim frmDisp As New FrmShowDisplay

    'Exits Sub If List Box is Not Empty
    If lstHistory.Count = 0 Then
      lblInfo.Text = "Nothing to display yet."
      Exit Sub
    End If

    'Clear List Box From Last Invocation
    frmDisp.lstHistory.Items.Clear()

    'Copy all items from listbox to frmDisp's listbox
    For i As Integer = 0 To lstHistory.Count - 1
      frmDisp.lstHistory.Items.Add((i + 1) & ": " & lstHistory(i))
    Next

    'Display History
    frmDisp.ShowDialog()

  End Sub

End Class
