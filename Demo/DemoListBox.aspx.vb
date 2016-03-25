Public Class DemoListBox
    Inherits System.Web.UI.Page
    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = " "
        For Each itm In ListBox1.Items
            If itm.Selected Then
                str = str & itm.Text
dsdasdasdasd
            End If

        Next
        Label1.Text = str
    End Sub
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim q = From f In System.Drawing.FontFamily.Families Select f.Name
            ListBox1.DataSource = q
            ListBox1.DataBind()
        End If
    End Sub
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim q = From f In System.Drawing.FontFamily.Families Select f.Name
            ListBox1.DataSource = q
            ListBox1.DataBind()
        End If
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = " "
        For Each itm In ListBox1.Items
            If itm.Selected Then
                str = str & itm.Text

            End If

        Next
        Label1.Text = str
    End Sub
End Class
