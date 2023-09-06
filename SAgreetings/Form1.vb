Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim lang As String

        lang = txtLang.Text.ToLower
        If lang = "tshivenda" Then
            MsgBox("ndaa")
        ElseIf lang = "xhosa" Then
            MsgBox("molo")
        ElseIf lang = "siswati" Then
            MsgBox("sawubona")
        ElseIf lang = "sipedi" Then
            MsgBox("thobela")
        ElseIf lang = "tswana" Then
            MsgBox("dumelang")
        ElseIf lang = "zulu" Then
            MsgBox("sawubona")
        ElseIf lang = "afrikaans" Then
            MsgBox("hallo")
        ElseIf lang = "ndebele" Then
            MsgBox("lotjani")
        ElseIf lang = "xitsonga" Then
            MsgBox("avuxeni")
        ElseIf lang = "sisotho" Then
            MsgBox("dumela")

        End If
    End Sub
End Class
