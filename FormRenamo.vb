Public Class FormRenamo

    Private Args() As String
    Private StrFormat As String
    Private IntDigits As Integer
    Private IntStartingIndex As Integer
    Private FinishedLoading As Boolean

    Private Sub FormRenamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Args = Environment.GetCommandLineArgs
        If Args.Length <= 1 Then
            MsgBox("Please read the instructions below. You must drag the files you wish to rename onto the executable to use this program.")
        Else
            FinishedLoading = True
        End If
        BtnRenamo.Enabled = FinishedLoading
        RefreshOutputPreview()
    End Sub

    Private Sub TxtFormat_TextChanged(sender As Object, e As EventArgs) Handles TxtFormat.TextChanged
        StrFormat = TxtFormat.Text
        RefreshOutputPreview()
    End Sub

    Private Sub TxtIndexStart_TextChanged(sender As Object, e As EventArgs) Handles TxtIndexStart.TextChanged
        IntStartingIndex = Val(TxtIndexStart.Text)
        RefreshOutputPreview()
    End Sub

    Private Sub TxtForcedDigits_TextChanged(sender As Object, e As EventArgs) Handles TxtForcedDigits.TextChanged
        IntDigits = Val(TxtForcedDigits.Text)
        RefreshOutputPreview()
    End Sub

    Private Sub RefreshOutputPreview()
        If Not FinishedLoading Then Exit Sub

        Dim newOutput As String = ""
        Dim currentIndex As Integer = IntStartingIndex
        For intA As Integer = 1 To Args.Length - 1
            newOutput &= Args(intA) & "   ====>   " & ReformattedName(currentIndex) & vbNewLine
            currentIndex += 1
        Next

        If newOutput <> TxtOutputPreview.Text Then TxtOutputPreview.Text = newOutput
    End Sub

    Private Function ReformattedName(index As Integer) As String
        Return Replace(StrFormat, "[#]", String.Format("{0,0:" & StrDup(IntDigits, "0") & "}", index))
    End Function

    Private Sub BtnRenamo_Click(sender As Object, e As EventArgs) Handles BtnRenamo.Click
        Dim currentIndex As Integer = IntStartingIndex
        Try
            For intA As Integer = 1 To Args.Length - 1
                FileSystem.Rename(Args(intA), ReformattedName(currentIndex))
                currentIndex += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class