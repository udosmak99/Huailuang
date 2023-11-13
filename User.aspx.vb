
Partial Class User
    Inherits System.Web.UI.Page

        Public Sub New()

        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
                If (Not IsPostBack) Then
                        grdUser.DataSource = New cUser().GetUsers(Nothing)
                        grdUser.DataBind()
                        btnNew_Click(btnNew, New EventArgs)
                End If
        End Sub

        Protected Sub grdUser_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grdUser.RowCommand
                If e.CommandArgument.ToString().Trim <> "" Then

                        Dim User As New UserItem()
                        User.LOGIN_NAME = e.CommandArgument

                        User = New cUser().GetUsers(User)(0)
                        If Not IsNothing(User) Then
                                txtLogInName.Text = False
                                txtLogInName.Text = User.LOGIN_NAME
                                txtName.Text = User.NAME
                                txtLastName.Text = User.LAST_NAME
                                txtPositon.Text = User.POSITION
                                btnCreate.Text = " Update User"
                                btnCreate.CommandArgument = "U"
                        End If
                End If
        End Sub

        Protected Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
                If (txtPassword.Text.Length > 0 And txtConfirmPassword.Text.Length > 0 And txtPassword.Text = txtConfirmPassword.Text) Then
                        Dim Item As New UserItem
                        Item.LOGIN_NAME = txtLogInName.Text
                        Item.LOGIN_PASSWORD = txtPassword.Text
                        Item.NAME = txtName.Text
                        Item.LAST_NAME = txtLastName.Text
                        Item.POSITION = txtPositon.Text
                        Item.USER_LEVEL = cmbLevel.SelectedValue
                        Dim Result As Boolean
                        If btnCreate.CommandArgument = "U" Then
                                Result = New cUser().Update(Item)
                        Else
                                Result = New cUser().Save(Item)

                        End If
                        If Result = True Then
                                grdUser.DataSource = New cUser().GetUsers(Nothing)
                                grdUser.DataBind()
                                btnNew_Click(btnNew, New EventArgs)
                        End If
                Else

                End If
        End Sub

        Protected Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
                txtLastName.Text = ""
                txtName.Text = ""
                txtLogInName.Text = ""
                txtLogInName.Text = ""
                txtPositon.Text = ""
                txtPassword.Text = ""
                txtConfirmPassword.Text = ""
                btnCreate.Text = "Create User"
                btnCreate.CommandArgument = ""
                cmbLevel.SelectedValue = -1
                btnDelete.Enabled = False

        End Sub

        Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click

                Dim Item As New UserItem
                Item.LOGIN_NAME = txtLogInName.Text
                Item.LOGIN_PASSWORD = txtPassword.Text
                Item.NAME = txtName.Text
                Item.LAST_NAME = txtLastName.Text
                Item.POSITION = txtPositon.Text
                Item.USER_LEVEL = cmbLevel.SelectedValue
           
                If New cUser().Save(Item) = True Then
                        grdUser.DataSource = New cUser().GetUsers(Nothing)
                        grdUser.DataBind()
                        btnNew_Click(btnNew, New EventArgs)
                End If
               
        End Sub
End Class
