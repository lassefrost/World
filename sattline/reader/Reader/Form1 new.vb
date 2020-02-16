Imports Microsoft.Office.Interop




Public Class sattline_converter

    Dim sInputLocation As String
    Dim sOutputLocation As String
    Dim sTempstring As String
    Dim Outputfilter(23) As String
    Dim inputfilter(23) As String

    Public HeaderArr(20) As Word.Paragraph
    Public BodyArr(20) As Word.Paragraph

    'Function Between(value As String, a As String, b As String) As String
    ' Get positions for both string arguments.
    ' Dim posA As Integer = value.IndexOf(a)
    'Dim posB As Integer = value.LastIndexOf(b)
    'If posA = -1 Then
    'Return ""
    ' End If
    'If posB = -1 Then
    'Return ""
    'End If

    ' Dim adjustedPosA As Integer = posA + a.Length
    'If adjustedPosA >= posB Then
    'Return ""
    'End If
    'End Function
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
            sInputLocation = openfile.FileName
        End If


    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnFilterSelect.Click

        Dim openfile As New OpenFileDialog With {
            .InitialDirectory = "C:\Users",
            .Title = "Select file location"}

        If openfile.ShowDialog = DialogResult.OK Then

            TextBox1.Text = openfile.FileName
            sOutputLocation = openfile.FileName
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnStart.Click

        Outputfilter(0) = Environment.NewLine & "IF "
        Outputfilter(1) = "("
        Outputfilter(2) = "  "
        Outputfilter(3) = "False"
        Outputfilter(4) = "<"
        Outputfilter(5) = ">"
        Outputfilter(6) = "== "
        Outputfilter(7) = "= "
        Outputfilter(8) = "THEN" & Environment.NewLine
        Outputfilter(9) = "ELSIF"
        Outputfilter(10) = "ELSE"
        Outputfilter(11) = Environment.NewLine & "ENDIF"
        Outputfilter(12) = "AND"
        Outputfilter(13) = "OR"
        Outputfilter(14) = "NOT"
        Outputfilter(15) = "STEP IN"
        Outputfilter(16) = "STEP LOOP"
        Outputfilter(17) = "Transition"
        Outputfilter(18) = "Transition Statement"
        Outputfilter(19) = "Afslutning af dokument"
        Outputfilter(20) = ";" & Environment.NewLine
        Outputfilter(21) = " "
        Outputfilter(22) = Environment.NewLine & "Name:"
        Outputfilter(23) = "True;"

        inputfilter(0) = "#0? "
        inputfilter(1) = "#01 "
        inputfilter(2) = "#8 "
        inputfilter(3) = "#1<"
        inputfilter(4) = "#04 "
        inputfilter(5) = "#05 "
        inputfilter(6) = "#08 "
        inputfilter(7) = "#8? "
        inputfilter(8) = "#10 "
        inputfilter(9) = "#11 "
        inputfilter(10) = "#12 "
        inputfilter(11) = "#13"
        inputfilter(12) = "#14 "
        inputfilter(13) = "#15 "
        inputfilter(14) = "#16 "
        inputfilter(15) = "#28 "
        inputfilter(16) = "#29 "
        inputfilter(17) = "#30 "
        inputfilter(18) = "#31 "
        inputfilter(19) = "#85; "
        inputfilter(20) = ";"
        inputfilter(21) = Environment.NewLine
        inputfilter(22) = "#20 "
        inputfilter(23) = "#1;;"

        Dim myStreamReaderL1 As System.IO.StreamReader
        Dim myStream As System.IO.StreamWriter
        Dim myStr As String

        Dim tempstring20 As String = "#20"

        Dim tempstring88 As String = "#88"

        Dim tempstring1 As String
        Dim i As Integer = 0
        Dim a As Integer = 0
        Dim oldindex As Integer
        myStreamReaderL1 = System.IO.File.OpenText(sInputLocation)
        myStr = myStreamReaderL1.ReadToEnd()
        myStreamReaderL1.Close()

        For i = 0 To myStr.Length() - 1 Step 1
            tempstring1 = myStr.Substring(i, i + 3)
            If tempstring1 = "#20" Then
                oldindex = i
            End If
            If oldindex > 0 And tempstring1 = "#88" Then
                HeaderArr(a).Range.Text = myStr.Substring(oldindex, i)
                a = a + 1
            End If
        Next



        For i = 23 To 0 Step -1
            myStr = myStr.Replace(inputfilter(i), Outputfilter(i))
        Next



        myStream = System.IO.File.CreateText(sOutputLocation)
        myStream.WriteLine(myStr)
        myStream.Close()


    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double



        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add("C:\Users\Lasse\Desktop\sattlinetemplate")


        HeaderArr(0) = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks("overskrift0").Range)
        HeaderArr(0).Range.Text = "her er en overskrift0"
        HeaderArr(0).Range.Style = "heading 1"
        HeaderArr(0).Format.SpaceAfter = 0    '24 pt spacing after paragraph.
        'oPara1.Range.InsertParagraphAfter()


        BodyArr(0) = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks("text0").Range)
        BodyArr(0).Range.Text = "her er noget tekst på tekst0"
        BodyArr(0).Range.Style = "Normal"
        BodyArr(0).Format.SpaceAfter = 0
        'oPara2.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data and make the first row
        'bold,italic.
        Dim r As Integer, c As Integer
        oTable = oDoc.Tables.Add(oDoc.Bookmarks("\endofdoc").Range, 3, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 3
            For c = 1 To 5
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Rows(1).Range.Font.Bold = True
        oTable.Rows(1).Range.Font.Italic = True

        'Add some text after the table.
        'oTable.Range.InsertParagraphAfter
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks("\endofdoc").Range)
        oPara4.Range.InsertParagraphBefore()
        oPara4.Range.Text = "And here's another table:"
        oPara4.Format.SpaceAfter = 24
        oPara4.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data and change the column widths.
        oTable = oDoc.Tables.Add(oDoc.Bookmarks("\endofdoc").Range, 5, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 5
            For c = 1 To 2
                oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
            Next
        Next
        oTable.Columns(1).Width = oWord.InchesToPoints(2)
        oTable.Columns(2).Width = oWord.InchesToPoints(3)

        'Keep inserting text. When you get to 7 inches from top of the
        'document, insert a hard page break.
        'Pos = oWord.InchesToPoints(7)
        ' oDoc.Bookmarks("\endofdoc").Range.InsertParagraphAfter()

        'Do
        'oRng = oDoc.Bookmarks("\endofdoc").Range
        'oRng.ParagraphFormat.SpaceAfter = 6
        'oRng.InsertAfter "A line of text"
        ' oRng.InsertParagraphAfter()
        'Loop While Pos >= oRng.Information(wdVerticalPositionRelativeToPage)
        'oRng.Collapse(wdCollapseEnd)
        'oRng.InsertBreak wdPageBreak
        'oRng.Collapse wdCollapseEnd
        'o'Rng.InsertAfter "We're now on page 2. Here's my chart:"
        'oRng.InsertParagraphAfter()

        'Insert a chart and change the chart.
        'oShape = oDoc.Bookmarks("\endofdoc").Range.InlineShapes.AddOLEObject(
        'ClassType:="MSGraph.Chart.8", FileName _
        ':="", LinkToFile:=False, DisplayAsIcon:=False)
        'oChart = oShape.OLEFormat.Object
        'oChart.charttype = 4 'xlLine = 4
        'oChart.Application.Update
        'oChart.Application.Quit
        '... If desired, you can proceed from here using the Microsoft Graph 
        'Object model on the oChart object to make additional changes to the
        'chart.
        ' oShape.Width = oWord.InchesToPoints(6.25)
        'oShape.Height = oWord.InchesToPoints(3.57)

        'Add text after the chart.


        'All done. Unload this form.

    End Sub

End Class