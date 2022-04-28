Public Class Scripts
    Public Function CheckPassword(pwd As String) As Integer
        Dim i As Integer
        Dim pUpper As Integer = 0
        Dim pLower As Integer = 0
        Dim pNumberic As Integer = 0
        Dim pSymbol As Integer = 0
        Dim pAscii As Integer
        Dim r As Integer
        For i = 1 To Len(pwd)
            pAscii = Asc(Mid$(pwd, i, 1))
            If pAscii >= 65 And pAscii <= 90 Then
                pUpper = pUpper + 1
            ElseIf pAscii >= 97 And pAscii <= 122 Then
                pLower = pLower + 1
            ElseIf pAscii >= 48 And pAscii <= 57 Then
                pNumberic = pNumberic + 1
            Else
                pSymbol = pSymbol + 1
            End If
        Next i
        If pUpper > 0 And pLower > 0 And pNumberic > 0 And pSymbol = 0 Then
            r = 1
        ElseIf pUpper = 0 Or pLower = 0 Or pNumberic = 0 And pSymbol = 0 Then
            r = 2
        ElseIf pSymbol > 0 Then
            r = 3
        End If
        Return r
    End Function
    Public Function AutoCapitalize(StringValue As TextBox)
        Dim startPos As Integer
        Dim selectionLength As Integer
        startPos = StringValue.SelectionStart
        selectionLength = StringValue.SelectionLength
        StringValue.Text = StrConv(StringValue.Text, VbStrConv.ProperCase)
        StringValue.SelectionStart = startPos
        StringValue.SelectionLength = selectionLength
        Return StringValue
    End Function
End Class