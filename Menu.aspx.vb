Imports Microsoft.VisualBasic
Partial Class Menu
        Inherits System.Web.UI.Page

       

        Protected Sub btnAlert_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAlert.Click

        End Sub

        Protected Sub btnUser_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnUser.Click
                Me.Response.Redirect("~/pages/User.aspx")
        End Sub

        Protected Sub btnReport_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnReport.Click
                Me.Response.Redirect("~/pages/ReportManager.aspx")

        End Sub

        Protected Sub BtnResource_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnResource.Click

        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
                If (cUser.CheckLogin() = "") Then
                        Me.Response.Redirect("~/login.aspx")
                End If
        End Sub
End Class
