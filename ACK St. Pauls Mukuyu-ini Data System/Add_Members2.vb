'import libraries for linking your application to mysql
Imports MySql
Imports MySql.Data.MySqlClient

'after that, link
Public Class Add_Members2
    'declare the variables to use to connect to the database...
    Dim MySQLKon As MySqlConnection
    Dim Kommando As MySqlCommand
    Dim Soma As MySqlDataReader
    Private Sub Combo_Boxes()
        'fill Prefered services
        PrefService.Items.Add("Teens Service")
        PrefService.Items.Add("English Service")
        PrefService.Items.Add("Kikuyu Service")

        'Fill comfortab;e with service timing
        ComfTiming.Items.Add("Yes")
        ComfTiming.Items.Add("No")

        'Fill Born Agian
        bornAgain.Items.Add("Yes")
        bornAgain.Items.Add("No")

        'Fill Enrolment
        EnrolledIn.Items.Add("KAYO")
        EnrolledIn.Items.Add("KAMA")
        EnrolledIn.Items.Add("Mothers Union")
        EnrolledIn.Items.Add("None")

        'Fill Cell group
        CellGroup.Items.Add("Baraka")
        CellGroup.Items.Add("Vision")
        CellGroup.Items.Add("Emmanuel")
        CellGroup.Items.Add("Jerusalem")

        'Fill Fellowship Attendance
        AttFellowship.Items.Add("Yes")
        AttFellowship.Items.Add("No")
    End Sub

    Private Sub Checkboxes()
        'declare a string to hold all the preferences
        Dim preference As String
        preference = " "

        'time to play
        If Preching_Check.Checked = True Then
            preference &= Preching_Check.Text
            preference &= ", "
        End If

        If LEadServ_check.Checked = True Then
            preference &= LEadServ_check.Text
            preference &= ", "
        End If

        If ReadBible_Check.Checked = True Then
            preference &= ReadBible_Check.Text
            preference &= ", "
        End If

        If Language_Check.Checked = True Then
            preference &= Language_Check.Text
            preference &= ", "
        End If

        If Choir_Check.Checked = True Then
            preference &= Choir_Check.Text
            preference &= ", "
        End If

        If Mission_Check.Checked = True Then
            preference &= Mission_Check.Text
            preference &= ", "
        End If

        If CommWork_Check.Checked = True Then
            preference &= CommWork_Check.Text
            preference &= ", "
        End If

        If SundaySch_Check.Checked = True Then
            preference &= SundaySch_Check.Text
            preference &= ", "
        End If

        If Teens_Check.Checked = True Then
            preference &= Teens_Check.Text
            preference &= ", "
        End If

        If Youth_Check.Checked = True Then
            preference &= Youth_Check.Text
            preference &= ", "
        End If

        If BibleStudy_Check.Checked = True Then
            preference &= BibleStudy_Check.Text
            preference &= ", "
        End If

        If Development_Check.Checked = True Then
            preference &= Development_Check.Text
            preference &= ", "
        End If

        If Strategic_Check.Checked = True Then
            preference &= Strategic_Check.Text
            preference &= ", "
        End If

        If Strategic_Check.Checked = True Then
            preference &= Strategic_Check.Text
            preference &= ", "
        End If

        If Counselling_Check.Checked = True Then
            preference &= Counselling_Check.Text
            preference &= ", "
        End If

        'output into the text box
        participation.Text = preference

    End Sub

    Private Sub Add_Members2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'connect to the database
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Combo_Boxes()
        LoadMemberNumber()
        other_Member_Details()
        save.Enabled = False
    End Sub
    Private Sub Add_Members2_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        Add_Members.Show()
    End Sub

    Private Sub validate_Click(sender As System.Object, e As System.EventArgs) Handles validate.Click
        Checkboxes()
        save.Enabled = True
    End Sub

    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles save.Click
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim Kommando As MySqlCommand
        Dim Soma As MySqlDataReader
        Dim Query As String
        Try
            MySQLKon.Open()
            Query = "update mukuyu.Church_Members set Prefered_Service='" & PrefService.Text & "', Confortable_with_Service_Timeing='" & ComfTiming.Text & "', If_No_Why='" & WhyUncWithSerTme.Text & "', Born_Again='" & bornAgain.Text & "', Enrolled_in='" & EnrolledIn.Text & "', Why_Not='" & ynotEnrolled.Text & "', Cell_Group='" & CellGroup.Text & "', Attend_Fellowships='" & AttFellowship.Text & "', Why_not_attend='" & ynotAttFel.Text & "', Member_for_How_Long='" & Memberlength.Text & "', Formaer_CHurch='" & FormerChurch.Text & "', Diocese='" & FormerDiocese.Text & "', Why_Relocate_here='" & yrelocate.Text & "', Areas_of_Participation='" & participation.Text & "', comments='" & improvement_comment.Text & "' where Memeber_ID='" & MemberID.Text & "' "
            Kommando = New MySqlCommand(Query, MySQLKon)
            Soma = Kommando.ExecuteReader
            MessageBox.Show("The new record has been added.", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK)
            Add_Children.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error in saving data!" & vbCrLf & "1. Check connection to the database" & vbCrLf & "2. Check for error in the data", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
            save.Enabled = False
        End Try

        
    End Sub

    Private Sub LoadMemberNumber()
        'It will be getting the most recently added Member Number.
        Dim READER As MySqlDataReader
        'Dim MySQLKon As MySqlConnection
        Dim Command As MySqlCommand

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "select max(Memeber_ID) from mukuyu.church_Members"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("max(Memeber_ID)")
                MemberID.Text = (AN)
            End While
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub other_Member_Details()
        Dim READER As MySqlDataReader

        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select * from mukuyu.church_Members where Memeber_ID='" & MemberID.Text & "'"
            Kommando = New MySqlCommand(Query, MySQLKon)
            READER = Kommando.ExecuteReader
            While READER.Read
                FullNoms.Text = READER.GetString("Full_Names")
                PhoneNoos.Text = READER.GetString("Telephone_Number")
            End While
            MySQLKon.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
End Class