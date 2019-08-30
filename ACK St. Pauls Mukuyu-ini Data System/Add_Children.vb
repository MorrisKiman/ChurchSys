Imports MySql
Imports MySql.Data.MySqlClient
Public Class Add_Children
    Dim MySQLKon As MySqlConnection
    Dim READER As MySqlDataReader
    Dim Command As MySqlCommand

    Private Sub Add_Children_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        komboBoxes()
        AutoCheck_Parent()
        Parent_alg()
        Child_Loader()
        SaveRecords.Enabled = False
        ChildName.Focus()
        'check_for_baby()
    End Sub

    Private Sub komboBoxes()
        'Baptized Box
        Child_Baptized.Items.Add("Yes")
        Child_Baptized.Items.Add("No")

        'Confirmed boxes
        Child_Confirmed.Items.Add("Yes")
        Child_Confirmed.Items.Add("No")

        'Gender box
        Gender.Items.Add("Boy")
        Gender.Items.Add("Girl")
    End Sub

    Private Sub AutoCheck_Parent()
        'this code obtains the most recent entry's details from the database.
        'It then checks the gender of the member and if the gender is male, the member is kicked to the "Father's details"
        'section of the form and for Mrs.and Miss go to the Mother's section of the form and vice versa.
        'It will be getting the most recently added Member Number
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select max(Memeber_ID) from mukuyu.church_Members"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("max(Memeber_ID)")
                ig.Text = (AN)
            End While

            'We have the newest member's ID so now let us proceed to caputuring the other details

            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Parent_alg()
        Dim Query As String
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim memID As Integer
        Dim TelNo, names, title, TelNo2, names2 As String
        Try
            MySQLKon.Open()
            Query = "Select * from mukuyu.church_Members where Memeber_ID='" & ig.Text & "'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                names = READER.GetString("Full_Names")
                TelNo = READER.GetString("Telephone_Number")
                title = READER.GetString("Title")
                TelNo2 = READER.GetString("Tel_Number")
                names2 = READER.GetString("Name")
                memID = ig.Text

                If title = "Mr." Then
                    Father_Member_Number.Text = memID
                    Fathers_Names.Text = names
                    Contacts_of_Father.Text = TelNo
                    Contacts_of_Mother.Text = TelNo2
                    Names_of_Mother.Text = names2
                Else
                    Mother_Member_Number.Text = memID
                    Names_of_Mother.Text = names
                    Contacts_of_Mother.Text = TelNo
                    Fathers_Names.Text = names2
                    Contacts_of_Father.Text = TelNo2

                End If
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Child_Loader()
        'This section checks the number of kids the individual has and saves the value in a visible texbox for manipulation.
        'get the number of children he/she has from the database and throw it into the dbVal variable
        Dim Query As String
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Try
            MySQLKon.Open()
            Query = "Select * from mukuyu.church_Members where Memeber_ID='" & ig.Text & "'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                noChildren.Text = READER.GetString("Number_of_Children")
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Child_Counter()
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim Command As MySqlCommand
        Dim Query As String
        Dim Soma As MySqlDataReader
        Try
            'lets run this loop till all the kids are in the systemfvsw
            MySQLKon.Open()
            Query = "insert into mukuyu.children (Child_ID, Child_Full_Names, Child_DOB, Gender, Baptized, Confirmed, Names_of_Father, Contacts_of_Father, Father_Member_Number, Names_of_Mother, Contacts_of_Mother, Age_of_Child, Mother_Member_Number) values ('""', '" & ChildName.Text & "', '" & Child_DOB.Text & "', '" & Gender.Text & "', '" & Child_Baptized.Text & "', '" & Child_Confirmed.Text & "', '" & Fathers_Names.Text & "', '" & Contacts_of_Father.Text & "', '" & Father_Member_Number.Text & "', '" & Names_of_Mother.Text & "', '" & Names_of_Mother.Text & "', '" & Contacts_of_Mother.Text & "', '" & Mother_Member_Number.Text & "')"
            Command = New MySqlCommand(Query, MySQLKon)
            Soma = Command.ExecuteReader
            MessageBox.Show("The new record has been added.", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearere()
            MySQLKon.Close()
            SaveRecords.Enabled = False
            ChildName.Focus()
        Catch ex As Exception
            MessageBox.Show("Error saving record!" & vbCrLf & "Connection to the Datatbase May be lost!", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Child_Baptized_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Child_Baptized.SelectedIndexChanged
        If Child_Baptized.Text.Contains("No") Then
            Child_Confirmed.Text = "No"
        Else
            Child_Confirmed.ResetText()
        End If
    End Sub

    Private Sub ValidateRecords_Click(sender As System.Object, e As System.EventArgs) Handles ValidateRecords.Click
        If Child_Baptized.Text = "" Or Child_Confirmed.Text = "" Or Child_DOB.Text = "" Or ChildName.Text = "" Or Gender.Text = "" Then
            MessageBox.Show("One of the fields has not been populated" & vbCrLf & "Please recheck that all the necessary data has been entered", "Empty Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChildName.Focus()
            SaveRecords.Enabled = False
        Else
            SaveRecords.Enabled = True
        End If

        If Child_Baptized.Text.Contains("No") And Child_Confirmed.Text.Contains("Yes") Then
            MessageBox.Show("A child that is not Baptized cannot be confirmed!!" & vbCrLf & "Please recheck that your data is correct!", "Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Child_Baptized.Focus()
            SaveRecords.Enabled = False
        Else
            SaveRecords.Enabled = True
        End If
    End Sub

    Private Sub SaveRecords_Click(sender As System.Object, e As System.EventArgs) Handles SaveRecords.Click
        Dim No, i As Integer
        No = Integer.Parse(noChildren.Text, Globalization.NumberStyles.Integer)
        i = Integer.Parse(Label3.Text, Globalization.NumberStyles.Integer)

        If i <= (No - 1) Then
            Child_Counter()
            SaveRecords.Enabled = False
            If Label3.Text.Contains(1) Then
                chfeed.Text = "Child Entered"
            Else
                chfeed.Text = "Children Entered"
            End If
            i += 1
            Label3.Text = i.ToString("")
        ElseIf i > (No - 1) Then
            MessageBox.Show("All the Children have been added to the Datatbase!", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SaveRecords.Enabled = False
        End If
    End Sub

    Private Sub clearere()
        ChildName.ResetText()
        Child_DOB.ResetText()
        Gender.ResetText()
        Child_Baptized.ResetText()
        Child_Confirmed.ResetText()
    End Sub

    Private Sub Label3_Click_1(sender As System.Object, e As System.EventArgs) Handles Label3.TextChanged
        Dim i As Integer = Integer.Parse(Label3.Text, Globalization.NumberStyles.Integer)
        Dim Noc = Integer.Parse(noChildren.Text, Globalization.NumberStyles.Integer)

        If i = Noc And i > 0 Then
            ValidateRecords.Enabled = False
            SaveRecords.Enabled = False
            MessageBox.Show("All the Children have been added to the Datatbase!", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Add_Members.Show()
        End If
    End Sub
    Private Sub check_for_baby()
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim Kommando As MySqlCommand
        Dim Soma As MySqlDataReader
        Dim Query As String
        Try
            Dim have As String
            MySQLKon.Open()
            Query = "Select * from mukuyu.church_Members where Memeber_ID='" & ig.Text & "'"
            Kommando = New MySqlCommand(Query, MySQLKon)
            Soma = Kommando.ExecuteReader
            While Soma.Read
                hvtoi.Text = Soma.GetString("Full_Names")

                If hvtoi.Text.Contains("No") Then
                    MessageBox.Show("This Member Has no children", "ACK ST. PAUL MUKUYUINI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Add_Members.Show()
                Else
                    ChildName.Focus()
                End If
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class