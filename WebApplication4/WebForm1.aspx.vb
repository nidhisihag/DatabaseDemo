Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException



Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Disp()
    End Sub

    Protected Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=www.risk-technologies.com;Initial Catalog=DemoDB;Persist Security Info=True;User ID=demo;Password=demo123!"
        con.Open()
        cmd = New SqlCommand("Insert Into Contacts values('" & txtFirst.Text & "','" & txtLast.Text & "', '" & txtCity.Text & "')", con)
        If (txtFirst.Text = "" Or txtLast.Text = "" Or txtCity.Text = "") Then
            MsgBox("Please Enter the data")
        Else
            cmd.ExecuteNonQuery()
            txtFirst.Text = ""
            txtLast.Text = ""
            txtCity.Text = ""
            con.Close()
            Disp()
        End If
    End Sub
    Public Sub Disp()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        con.ConnectionString = "Data Source=www.risk-technologies.com;Initial Catalog=DemoDB;Persist Security Info=True;User ID=demo;Password=demo123!"
        con.Open()
        cmd = New SqlCommand("Select * from Contacts", con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()


        Dim da As New SqlDataAdapter(cmd)

        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()



        con.Close()












    End Sub

End Class