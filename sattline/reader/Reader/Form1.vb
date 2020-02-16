Imports System.IO


Public Class sattline_converter

    Dim sInputLocation As String
    Dim sFilterlocation As String
    Dim sOutputLocation As String



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblName.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtbInput.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSelectProject.Click

        Dim openfile As New OpenFileDialog With {
            .InitialDirectory = "C:\Users",
            .Title = "Select file location"}

        If openfile.ShowDialog = DialogResult.OK Then

            TxtbInput.Text = openfile.FileName

        End If

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnFilterSelect.Click

        Dim openfile As New OpenFileDialog With {
            .InitialDirectory = "C:\Users",
            .Title = "select file location"}

        If openfile.ShowDialog = DialogResult.OK Then

            TextBox1.Text = openfile.FileName

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnStart.Click


        Dim value As String = File.ReadAllText(sInputLocation)



        Using reader As StreamReader = New StreamReader(sInputLocation)

            reader.ReadToEnd()

        End Using

        'Dim a As Integer

        'For a = 0 To sTempString.Length - 1
        'If sTempString(a).Contains(sTegn) Then
        '
        'sTempString(a) = "UserName =" & sTegn
        '
        'End If
        'Exit For
        'Next

        'IO.File.WriteAllText(sInputLocation, String.Join(vbCrLf, sTempString))

    End Sub
End Class
