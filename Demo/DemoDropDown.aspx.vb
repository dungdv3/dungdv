Public Class DemoDropDown
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim enClr As System.Drawing.KnownColor
            Dim clrs As New System.Collections.Generic.List(Of System.Drawing.KnownColor)
            clrs.AddRange(System.Enum.GetValues(enClr.GetType()))
            DropDownList1.DataSource = clrs
            DropDownList1.DataBind()
            Panel1.Width = Unit.Pixel(300)
            Panel1.Height = Unit.Pixel(200)
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim str As String
        str = DropDownList1.SelectedValue
        Dim objColor As System.Drawing.Color
        objColor = _
            System.Drawing.ColorTranslator.FromHtml(str)
        Panel1.BackColor = objColor
        Label1.Text = str
    End Sub
End Class