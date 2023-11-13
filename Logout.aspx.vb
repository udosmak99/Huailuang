
Partial Class Logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If cUser.Logout() = True Then
            clearcookie()
            'ScriptManager.RegisterClientScriptBlock(Page, GetType(Page), "close", "window.close();", True)
            '  ClientScript.RegisterStartupScript(Me.GetType(), "uploadNotify", "<script  type='text/javascript' >window.returnValue =true;self.close(); </script>")
            'Dim closeScript As String = "<script language='javascript'> window.close() </script>"
            'ClientScript.RegisterStartupScript(Me.GetType, "closeScript", closeScript)
            Response.Write("<script language='javascript'> { window.close(); }</script>")

        End If
    End Sub
    Private Sub clearcookie()
        Dim myCookie As HttpCookie
        myCookie = New HttpCookie("LastUserWC")
        myCookie.Expires = DateTime.Now.AddDays(-1D)
        Response.Cookies.Add(myCookie)
        Dim myCookie2 As HttpCookie
        myCookie2 = New HttpCookie("UserWC")
        myCookie2.Expires = DateTime.Now.AddDays(-1D)
        Response.Cookies.Add(myCookie2)
    End Sub
End Class
