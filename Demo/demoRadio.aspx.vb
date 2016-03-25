Public Class demoRadio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblRespond.Text = rblFrog.SelectedValue
        If Not IsPostBack Then
            Dim arrL As New ArrayList
            arrL.Add("Scrabble")
            arrL.Add("Crosswords")
            arrL.Add("WonderWord")
            arrL.Add("Sudoku")
            arrL.Sort()
            CheckBoxList1.DataSource = arrL
            CheckBoxList1.DataBind()
        End If
    End Sub

    Protected Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = CheckBoxList1.SelectedValue

    End Sub
End Class