
Partial Class index
    Inherits System.Web.UI.Page
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

    Protected Sub index_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            clearcookie()
            Response.Redirect("./pages/map.aspx")
        Catch ex As Exception

        End Try
    End Sub
End Class
