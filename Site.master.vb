Imports System.Data
Partial Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim server As System.Web.HttpApplication = New HttpApplication
        Dim cookie As HttpCookie = System.Web.HttpContext.Current.Request.Cookies("UserWC")
        Try
            If Not IsPostBack Then
                If Session("pagename") = Nothing Then
                    setMenu()
                    img_main.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_1-over.png'")
                    img_main.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_1-over.png'")
                    img_main.ImageUrl = "./Images/menu/menu_1-over.png"
                ElseIf Session("pagename") = "map" Then
                    setMenu()
                    img_main.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_1-over.png'")
                    img_main.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_1-over.png'")
                    img_main.ImageUrl = "./Images/menu/menu_1-over.png"
                ElseIf Session("pagename") = "cctv" Then
                    setMenu()
                    img_cctv.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_7.png'")
                    img_cctv.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_7.png'")
                    img_cctv.ImageUrl = "./Images/menu/menu_7.png"
                ElseIf Session("pagename") = "station" Then
                    setMenu()
                    img_station.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_2-over.png'")
                    img_station.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_2-over.png'")
                    img_station.ImageUrl = "./Images/menu/menu_2-over.png"
                ElseIf Session("pagename") = "about" Then
                    setMenu()
                    img_about.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_6-over.png'")
                    img_about.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_6-over.png'")
                    img_about.ImageUrl = "./Images/menu/menu_6-over.png"
                ElseIf Session("pagename") = "result" Then
                    setMenu()
                    img_conclude.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_3-over.png'")
                    img_conclude.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_3-over.png'")
                    img_conclude.ImageUrl = "./Images/menu/menu_3-over.png"
                ElseIf Session("pagename") = "plan" Then
                    setMenu()
                    img_conclude.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_5-over.png'")
                    img_conclude.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_5-over.png'")
                    img_conclude.ImageUrl = "./Images/menu/menu_5-over.png"
                    'ElseIf Session("pagename") = "forecast" Then
                    '    setMenu()
                    '    img_conclude.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_4-over.png'")
                    '    img_conclude.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_4-over.png'")
                    '    img_conclude.ImageUrl = "./Images/menu/forecast_ov.png"
                End If
            End If

            If Not (cookie Is Nothing) Then
                Image2.Visible = True
                imgLogin0.Visible = True
                imgLogin.ImageUrl = "./Images/logout.png"
                lblnameLogin.Text = "คุณ " & server.Server.UrlDecode(cookie.Values("Name")) & "  " & server.Server.UrlDecode(cookie.Values("LastName"))
                lblpositionlogin.Text = server.Server.UrlDecode(cookie.Values("POSITION"))
            Else
                Image2.Visible = False
                imgLogin0.Visible = False
                lblnameLogin.Text = ""
                lblpositionlogin.Text = ""
            End If
        Catch ex As Exception
            Throw New Exception("Pagename error : " & ex.Message)
        End Try

    End Sub

    Private Sub setMenu()
        'หน้าหลัก()
        img_main.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_1.png'")
        img_main.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_1-over.png'")
        'ความเป็นมาโครงการ
        img_about.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_6.png'")
        img_about.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_6-over.png'")
        'ข้อมูลสถานี
        img_station.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_2.png'")
        img_station.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_2-over.png'")
        'สรุปข้อมูลทุกสถานี()
        img_conclude.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_3.png'")
        img_conclude.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_3-over.png'")
        'ข้อมูลการพยากรณ์
        'img_forecast.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_4.png'")
        'img_forecast.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_4-over.png'")
        'แผนผังการไหลของน้ำ
        img_plan.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_5.png'")
        img_plan.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_5-over.png'")
        'ดูภาพปัจจุบันกล้อง CCTV
        img_cctv.Attributes.Add("onMouseOut", "this.src='./Images/menu/menu_7.png'")
        img_cctv.Attributes.Add("onMouseOver", "this.src='./Images/menu/menu_7.png'")

    End Sub

    'Protected Sub img_login_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_login.Click
    '    Me.Response.Redirect("~/login.aspx")
    'End Sub

    Protected Sub img_station_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_station.Click
        Session("pagename") = "station"
        Response.Redirect("DetailStation.aspx?CODE=TUD01")
    End Sub

    Protected Sub img_about_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_about.Click
        Session("pagename") = "about"
        Response.Redirect("History1.aspx")
    End Sub

    'Protected Sub img_cctv_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_cctv.Click
    '    Session("pagename") = "cctv"
    '    'Response.Redirect("CCTV.aspx")
    '    Dim sb As String
    '    sb = "<div><script language='JavaScript'>window.open('http://118.175.32.173:82/XProtectMobile/Web/index.html');</script></div>"
    '    Page.RegisterClientScriptBlock("OpenWindow", sb)
    'End Sub

    Protected Sub img_main_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_main.Click
        Session("pagename") = "map"
        Response.Redirect("map.aspx")
    End Sub

    Protected Sub img_conclude_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_conclude.Click
        Session("pagename") = "result"
        Response.Redirect("AllStation.aspx")
    End Sub

    Protected Sub img_plan_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_plan.Click
        Session("pagename") = "plan"
        'Response.Redirect("AllStation.aspx")
    End Sub
    'Protected Sub img_forecast_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_forecast.Click
    '    Session("pagename") = "forecast"
    'End Sub

    'Protected Sub img_graph_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_graph.Click
    '    'Session("pagename") = "result"
    '    'Response.Redirect("AllStation.aspx")
    'End Sub
    'Protected Sub Image1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Image1.Click
    '    '  OpenRID()
    'End Sub
    Public Sub OpenRID()
        Dim sb As String
        sb = "<div><script language='JavaScript'>window.open('http://www.rid.go.th','rid');</script></div>"
        Page.RegisterClientScriptBlock("OpenWindow", sb)
    End Sub


    Protected Sub imgLogin_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgLogin.Click
        Dim server As System.Web.HttpApplication = New HttpApplication
        Dim cookie As HttpCookie = System.Web.HttpContext.Current.Request.Cookies("UserWC")
        If Not (cookie Is Nothing) Then
            clearcookie()
            imgLogin.ImageUrl = "./Images/login.png"
            Image2.Visible = False
            imgLogin0.Visible = False
            lblnameLogin.Text = ""
            lblpositionlogin.Text = ""
            Response.Redirect("Map.aspx")
        Else
            Response.Redirect("loginofficial.aspx")
        End If

    End Sub

    'Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    clearcookie()
    '    Dim sb As String
    '    imgLogin.Visible = False
    '    divCurrent.Visible = False
    '    imgLogin.Visible = True
    '    lbName.InnerText = ""
    '    If cUser.Logout() = True Then

    '        sb = "<div><script language='JavaScript'>Logount()</script></div>"
    '        Page.RegisterClientScriptBlock("OpenWindow", sb)
    '    End If
    '    Response.Redirect("map.aspx")
    'End Sub
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
    'Protected Sub btnalarmdetail1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim sb As String
    '    sb = "<div><script language='JavaScript'>window.open('Popupcontent.aspx?infomation_id=" & lblinformation1.Value & "','MyPopup', 'width==800','menubar=no,directories=no, location=no, resizable=no, scrollbars=yes , toolbar=no, status = no', true);</script></div>"
    '    Page.RegisterClientScriptBlock("OpenWindow", sb)
    'End Sub
    'Protected Sub btnalarmdetail2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim sb As String
    '    sb = "<div><script language='JavaScript'>window.open('Popupcontent.aspx?infomation_id=" & lblinformation2.Value & "','MyPopup', 'width==800','menubar=no,directories=no, location=no, resizable=no, scrollbars=yes , toolbar=no, status = no', true);</script></div>"
    '    Page.RegisterClientScriptBlock("OpenWindow", sb)
    'End Sub
    'Protected Sub btnalarmdetail3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim sb As String
    '    sb = "<div><script language='JavaScript'>window.open('Popupcontent.aspx?infomation_id=" & lblinformation3.Value & "','MyPopup', 'width==800','menubar=no,directories=no, location=no, resizable=no, scrollbars=yes , toolbar=no, status = no', true);</script></div>"
    '    Page.RegisterClientScriptBlock("OpenWindow", sb)
    'End Sub


    Protected Sub imgLogin0_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgLogin0.Click
        Response.Redirect("../pages/pageupdate.aspx")
    End Sub
End Class

