Imports MySql
Imports MySql.Data.MySqlClient
Public Class AllMembersShow
    Dim MySQLKon As MySqlConnection
    Dim Kommand As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource
    Private Sub AllMembersShow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_table()
        Men_withdrwaer()
        women_Withdrawer()
        Zote_()
    End Sub
    Private Sub AllMembersShow_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Main_Menu.Show()
    End Sub
    Private Sub load_table()
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select *from mukuyu.church_members"
            Kommand = New MySqlCommand(Query, MySQLKon)
            SDA.SelectCommand = Kommand
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)
            MySQLKon.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DataGridView1.Refresh()
        load_table()
    End Sub

    Private Sub Men_withdrwaer()
        Dim READER As MySqlDataReader
        'Dim MySQLKon As MySqlConnection
        Dim Command As MySqlCommand

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Title = 'Mr.'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                TotalMen.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Receive_Holy_Communion = 'Yes'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                MenCommunicant.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Receive_Holy_Communion = 'Yes'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                MenCommunicant.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Baptized = 'Yes'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                MenBaptized.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Attend_Fellowships = 'Yes'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                MenFellowship.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub women_Withdrawer()
        Dim READER As MySqlDataReader
        'Dim MySQLKon As MySqlConnection
        Dim Command As MySqlCommand
        Dim Wtot As Integer

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Receive_Holy_Communion = 'Yes' and Title = 'Miss' or title = 'Mrs.'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Wtot = READER.GetString("count(Full_Names)")
                TotalWomen.Text = (Wtot)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Receive_Holy_Communion = 'Yes' and Title = 'Miss' or title = 'Mrs.'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")

                WomenCommunicant.Text = AN
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Baptized = 'Yes' and Title = 'Miss' or title = 'Mrs.'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                WomenBaptized.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Attend_Fellowships= 'Yes' and Title = 'Miss' or title = 'Mrs.'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("count(Full_Names)")
                WomenFellowship.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Zote_()
        Dim READER As MySqlDataReader
        'Dim MySQLKon As MySqlConnection
        Dim Command As MySqlCommand

        'all
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim Wtot = READER.GetString("count(Full_Names)")
                wote.Text = (Wtot)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'kayo
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Enrolled_in = 'KAYO'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim Wtot = READER.GetString("count(Full_Names)")
                kayo.Text = (Wtot)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Enrolled_in = 'Mothers Union'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim Wtot = READER.GetString("count(Full_Names)")
                mothers.Text = (Wtot)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Full_Names) from mukuyu.church_Members where Enrolled_in = 'KAMA'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim Wtot = READER.GetString("count(Full_Names)")
                kama.Text = (Wtot)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select count(Child_ID) from mukuyu.children"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim Wtot = READER.GetString("count(Child_ID)")
                watoi.Text = (Wtot)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class