Imports MySql
Imports MySql.Data.MySqlClient
Public Class Edit_Members
    Dim MySQLKon As MySqlConnection
    Dim READER As MySqlDataReader
    Dim Command As MySqlCommand

    Private Sub Edit_Members_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime=true"

        'Children Functions
        load_ChildLoadID()
        Child_komboBoxes()
        SaveChildRecords.Enabled = False

        'basic member details functions
        BasicCombo_boxes()
        load_basicmemberid()
        saveBasicEdit.Enabled = False

        'other member details
        OtherDCombo_Boxes()
        loadOtherMID()
        Membership_Save.Enabled = False
    End Sub
    Private Sub Edit_Members_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Main_Menu.Show()
    End Sub

    'tab buttons
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Edit_Basic.Visible = True
        Edit_Membership.Visible = False
        Edit_Children.Visible = False
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Edit_Basic.Visible = False
        Edit_Membership.Visible = True
        Edit_Children.Visible = False
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Edit_Basic.Visible = False
        Edit_Membership.Visible = False
        Edit_Children.Visible = True
    End Sub

    'Firstly I will deal with adding a new child fro a couple/individual... so thats whats up
    Private Sub Child_komboBoxes()
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
    Private Sub load_ChildLoadID()
        Dim READER As MySqlDataReader
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select * from mukuyu.church_members   where Have_Kids = 'Yes'"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("Memeber_ID")
                ChildLoadID.Items.Add(sName)
            End While
            MySQLKon.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
    Private Sub Child_Baptized_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Child_Baptized.SelectedIndexChanged
        If Child_Baptized.Text.Contains("No") Then
            Child_Confirmed.Text = "No"
        Else
            Child_Confirmed.ResetText()
        End If
    End Sub
    Private Sub SaveChildRecords_Click(sender As System.Object, e As System.EventArgs) Handles SaveChildRecords.Click
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
            ChildName.ResetText()
            Child_DOB.ResetText()
            Gender.ResetText()
            Child_Baptized.ResetText()
            Child_Confirmed.ResetText()
            MySQLKon.Close()
            SaveChildRecords.Enabled = False
            ChildName.Focus()
        Catch ex As Exception
            MessageBox.Show("Error saving record!" & vbCrLf & "Connection to the Datatbase May be lost!", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ChildLoadID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ChildLoadID.TextChanged
        'SelectedIndex
        Dim Query As String
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim TelNo, names, title, TelNo2, names2 As String
        Dim id1 As Integer
        Try
            If ChildLoadID.Text = "" Or ChildLoadID.Text = 0 Then
                Father_Member_Number.ResetText()
                Fathers_Names.ResetText()
                Contacts_of_Father.ResetText()
                Contacts_of_Mother.ResetText()
                Names_of_Mother.ResetText()
                Mother_Member_Number.ResetText()
                Names_of_Mother.ResetText()
                Contacts_of_Mother.ResetText()
                Fathers_Names.ResetText()
                Contacts_of_Father.ResetText()
                ChildName.ResetText()
                Child_DOB.ResetText()
                Gender.ResetText()
                Child_Baptized.ResetText()
                Child_Confirmed.ResetText()
            Else
                MySQLKon.Open()
                Query = "Select * from mukuyu.church_Members where Memeber_ID='" & ChildLoadID.Text & "'"
                Command = New MySqlCommand(Query, MySQLKon)
                READER = Command.ExecuteReader
                While READER.Read
                    id1 = READER.GetString("Memeber_ID")
                    names = READER.GetString("Full_Names")
                    TelNo = READER.GetString("Telephone_Number")
                    title = READER.GetString("Title")
                    TelNo2 = READER.GetString("Tel_Number")
                    names2 = READER.GetString("Name")

                    If title = "Mr." Then
                        Father_Member_Number.Text = id1
                        Fathers_Names.Text = names
                        Contacts_of_Father.Text = TelNo
                        Contacts_of_Mother.Text = TelNo2
                        Names_of_Mother.Text = names2
                    Else
                        Mother_Member_Number.Text = id1
                        Names_of_Mother.Text = names
                        Contacts_of_Mother.Text = TelNo
                        Fathers_Names.Text = names2
                        Contacts_of_Father.Text = TelNo2

                    End If
                End While
            End If
            MySQLKon.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
    Private Sub ValidateRecords_Click(sender As System.Object, e As System.EventArgs) Handles ValidateRecords.Click
        If Child_Baptized.Text = "" Or Child_Confirmed.Text = "" Or Child_DOB.Text = "" Or ChildName.Text = "" Or Gender.Text = "" Then
            MessageBox.Show("One of the fields has not been populated" & vbCrLf & "Please recheck that all the necessary data has been entered", "Empty Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChildName.Focus()
            SaveChildRecords.Enabled = False
        Else
            SaveChildRecords.Enabled = True
        End If

        If Child_Baptized.Text.Contains("No") And Child_Confirmed.Text.Contains("Yes") Then
            MessageBox.Show("A child that is not Baptized cannot be confirmed!!" & vbCrLf & "Please recheck that your data is correct!", "Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Child_Baptized.Focus()
            SaveChildRecords.Enabled = False
        Else
            SaveChildRecords.Enabled = True
        End If
    End Sub

    'Now let us edit the basic members' details, shall we?
    Private Sub validate_Click(sender As System.Object, e As System.EventArgs) Handles validate.Click
        Try
            If AppFnames.Text = "" Or title.Text = "" Or AppDOB.Text = "" Or ApplPOB.Text = "" Or AgeBracket.Text = "" Or Appl_PhoneNo.Text = "" Or emailAdd.Text = "" Or ApplProfession.Text = "" Or ApplOccupation.Text = "" Or ApplEmployer.Text = "" Or Residence.Text = "" Or HomeParish.Text = "" Or LocalChurch.Text = "" Or HomeDiocese.Text = "" Or Baptizeed.Text = "" Or Confirmed_.Text = "" Or MaritalStatus.Text = "" Or Havekids.Text = "" Then
                MessageBox.Show("Some Fields have not been filled!", "ACK ST. PAULS MUKUYU-INI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                saveBasicEdit.Enabled = False
                AppFnames.Focus()
            Else
                saveBasicEdit.Enabled = True
            End If

            If Baptizeed.Text.Contains("No") And Confirmed_.Text.Contains("Yes") Then
                MessageBox.Show("A person that is not Baptized cannot be confirmed!!" & vbCrLf & "Please recheck that your data is correct!", "Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Baptizeed.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("There is an error in the data you want to submit" & vbCrLf & "Please review it and try again!", "ACK ST. PAULS MUKUYU-INI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            saveBasicEdit.Enabled = False
        End Try
    End Sub
    Private Sub BasicCombo_boxes()
        'load the title combobox
        title.Items.Add("Mr.")
        title.Items.Add("Mrs.")
        title.Items.Add("Miss")

        'Agebracket combobox
        AgeBracket.Items.Add("13-18")
        AgeBracket.Items.Add("19-24")
        AgeBracket.Items.Add("25-34")
        AgeBracket.Items.Add("35-44")
        AgeBracket.Items.Add("45-54")
        AgeBracket.Items.Add("55-64")
        AgeBracket.Items.Add("Above 64")

        'Baptized combobox
        Baptizeed.Items.Add("Yes")
        Baptizeed.Items.Add("No")

        'Confirmed combobox
        Confirmed_.Items.Add("Yes")
        Confirmed_.Items.Add("No")

        'Receives Holy Communion combobox
        ReceivesCommunion.Items.Add("Yes")
        ReceivesCommunion.Items.Add("No")

        'Marital status
        MaritalStatus.Items.Add("Single")
        MaritalStatus.Items.Add("Married")
        MaritalStatus.Items.Add("Divorced")
        MaritalStatus.Items.Add("Separated")
        MaritalStatus.Items.Add("Widow")
        MaritalStatus.Items.Add("Widower")

        'Marriage Form
        MarriageForm.Items.Add("Christian Marriage")
        MarriageForm.Items.Add("Civil Marriage")
        MarriageForm.Items.Add("Customary Marriage")
        MarriageForm.Items.Add("Other")

        'Have Kids
        Havekids.Items.Add("Yes")
        Havekids.Items.Add("No")
    End Sub
    Private Sub load_basicmemberid()
        Dim READER As MySqlDataReader
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select * from mukuyu.church_members"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("Memeber_ID")
                basicmemberid.Items.Add(sName)
            End While
            MySQLKon.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")
        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
    Private Sub basicmemberid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles basicmemberid.TextChanged
        'SelectedIndex
        Dim Query As String
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"
        Dim Ttitle, Full_Names, Date_of_Birth, Place_of_Birth, Age_Bracket, Telephone_Number, Email_Address, Profession, Occupation, Employer, Rresidence, Home_Parish, Local_Church, Home_Diocese, Baptized, Year_Baptized, Place_of_Baptism, Baptized_By, Confirmed, Year_Confirmed, Place_of_Confirmation, Confirmed_By, Receive_Holy_Communion, Reason, Marital_Status, Form_Of_Marriage, Year_Married, Location_Of_Marriage, Specify_other, Have_Kids, Number_of_Children, Name, Spouce_Occupation, Tel_Number, Employer_ As String
        If basicmemberid.Text = "" Or basicmemberid.Text = "0" Then
            basicResetter()
        Else
            Try
                MySQLKon.Open()
                Query = "Select * from mukuyu.church_Members where Memeber_ID='" & basicmemberid.Text & "'"
                Command = New MySqlCommand(Query, MySQLKon)
                READER = Command.ExecuteReader
                While READER.Read
                    Ttitle = READER.GetString("Title")
                    Full_Names = READER.GetString("Full_Names")
                    Date_of_Birth = READER.GetString("Date_of_Birth")
                    Place_of_Birth = READER.GetString("Place_of_Birth")
                    Age_Bracket = READER.GetString("Age_Bracket")
                    Telephone_Number = READER.GetString("Telephone_Number")
                    Email_Address = READER.GetString("Email_Address")
                    Profession = READER.GetString("Profession")
                    Occupation = READER.GetString("Occupation")
                    Employer = READER.GetString("Employer")
                    Rresidence = READER.GetString("Residence")
                    Home_Parish = READER.GetString("Home_Parish")
                    Local_Church = READER.GetString("Local_Church")
                    Home_Diocese = READER.GetString("Home_Diocese")
                    Baptized = READER.GetString("Baptized")
                    Year_Baptized = READER.GetString("Year_Baptized")
                    Place_of_Baptism = READER.GetString("Place_of_Baptism")
                    Baptized_By = READER.GetString("Baptized_By")
                    Confirmed = READER.GetString("Confirmed")
                    Year_Confirmed = READER.GetString("Year_Confirmed")
                    Place_of_Confirmation = READER.GetString("Place_of_Confirmation")
                    Confirmed_By = READER.GetString("Confirmed_By")
                    Receive_Holy_Communion = READER.GetString("Receive_Holy_Communion")
                    Reason = READER.GetString("Reason")
                    Marital_Status = READER.GetString("Marital_Status")
                    Form_Of_Marriage = READER.GetString("Form_Of_Marriage")
                    Year_Married = READER.GetString("Year_Married")
                    Location_Of_Marriage = READER.GetString("Location_Of_Marriage")
                    Specify_other = READER.GetString("Specify_other")
                    Have_Kids = READER.GetString("Have_Kids")
                    Number_of_Children = READER.GetString("Number_of_Children")
                    Name = READER.GetString("Name")
                    Spouce_Occupation = READER.GetString("Spouce_Occupation")
                    Tel_Number = READER.GetString("Tel_Number")
                    Employer_ = READER.GetString("Employer_")

                    'time to populate the other text boxes
                    title.Text = Ttitle
                    AppFnames.Text = Full_Names
                    AppDOB.Text = Date_of_Birth.Remove(startIndex:=10)
                    ApplPOB.Text = Place_of_Birth
                    AgeBracket.Text = Age_Bracket
                    Appl_PhoneNo.Text = Telephone_Number
                    emailAdd.Text = Email_Address
                    ApplProfession.Text = Profession
                    ApplOccupation.Text = Occupation
                    ApplEmployer.Text = Employer
                    Residence.Text = Rresidence
                    HomeParish.Text = Home_Parish
                    LocalChurch.Text = Local_Church
                    HomeDiocese.Text = Home_Diocese
                    Baptizeed.Text = Baptized
                    YearBaptized.Text = Year_Baptized
                    PlaceBaptized.Text = Place_of_Baptism
                    BaptixedBy.Text = Baptized_By
                    Confirmed_.Text = Confirmed
                    YearConfirmed.Text = Year_Confirmed
                    PlaceConfirmed.Text = Place_of_Confirmation
                    ConfirmedBy.Text = Confirmed_By
                    ReceivesCommunion.Text = Receive_Holy_Communion
                    ynotreceivecommunion.Text = Reason
                    MaritalStatus.Text = Marital_Status
                    MarriageForm.Text = Form_Of_Marriage
                    YearMarried.Text = Year_Married
                    WeddingLocation.Text = Location_Of_Marriage
                    SpecOther.Text = Specify_other
                    Havekids.Text = Have_Kids
                    howmanykids.Text = Number_of_Children
                    SpouceNames.Text = Name
                    SpoucepProfession.Text = Spouce_Occupation
                    SpouceNo.Text = Tel_Number
                    SpouceEmployer.Text = Employer_
                End While
            Catch ex As Exception
                MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                MySQLKon.Dispose()
            End Try
        End If
    End Sub
    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles saveBasicEdit.Click
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim Kommando As MySqlCommand
        Dim Soma As MySqlDataReader
        Dim Query As String
        Try
            MySQLKon.Open()
            Query = "update mukuyu.Church_Members set Title='" & title.Text & "', Full_Names='" & AppFnames.Text & "', Place_of_Birth='" & ApplPOB.Text & "', Age_Bracket='" & AgeBracket.Text & "', Telephone_Number='" & Appl_PhoneNo.Text & "', Email_Address='" & emailAdd.Text & "', Profession='" & ApplProfession.Text & "', Occupation='" & ApplOccupation.Text & "', Employer='" & ApplEmployer.Text & "', Residence='" & Residence.Text & "', Home_Parish='" & HomeParish.Text & "', Local_Church='" & LocalChurch.Text & "', Home_Diocese='" & HomeDiocese.Text & "', Baptized='" & Baptizeed.Text & "', Year_Baptized='" & YearBaptized.Text & "', Place_of_Baptism='" & PlaceBaptized.Text & "', Baptized_By='" & BaptixedBy.Text & "', Confirmed='" & Confirmed_.Text & "', Year_Confirmed='" & YearConfirmed.Text & "', Place_of_Confirmation='" & PlaceConfirmed.Text & "', Confirmed_By='" & ConfirmedBy.Text & "', Receive_Holy_Communion='" & ReceivesCommunion.Text & "', Reason='" & ynotreceivecommunion.Text & "', Marital_Status='" & MaritalStatus.Text & "', Form_Of_Marriage='" & MarriageForm.Text & "', Year_Married='" & YearMarried.Text & "', Location_Of_Marriage='" & WeddingLocation.Text & "', Specify_other='" & SpecOther.Text & "', Have_Kids='" & Havekids.Text & "', Number_of_Children='" & howmanykids.Text & "', Name='" & SpouceNames.Text & "', Spouce_Occupation='" & SpoucepProfession.Text & "', Tel_Number='" & SpouceNo.Text & "', Employer_='" & SpouceEmployer.Text & "'  where Memeber_ID='" & basicmemberid.Text & "'  "
            Kommando = New MySqlCommand(Query, MySQLKon) 'Date_of_Birth='" & AppDOB.Text & "', 
            Soma = Kommando.ExecuteReader
            MessageBox.Show("The record has been edited.", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK)
            basicResetter()
        Catch ex As Exception
            MessageBox.Show("Error in saving data!" & vbCrLf & "1. Check connection to the database" & vbCrLf & "2. Check for error in the data", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
            saveBasicEdit.Enabled = False
        End Try
    End Sub
    Private Sub basicResetter()
        basicmemberid.ResetText()
        title.ResetText()
        AppFnames.ResetText()
        AppDOB.ResetText()
        ApplPOB.ResetText()
        AgeBracket.ResetText()
        Appl_PhoneNo.ResetText()
        emailAdd.ResetText()
        ApplProfession.ResetText()
        ApplOccupation.ResetText()
        ApplEmployer.ResetText()
        Residence.ResetText()
        HomeParish.ResetText()
        LocalChurch.ResetText()
        HomeDiocese.ResetText()
        Baptizeed.ResetText()
        YearBaptized.ResetText()
        PlaceBaptized.ResetText()
        BaptixedBy.ResetText()
        Confirmed_.ResetText()
        YearConfirmed.ResetText()
        PlaceConfirmed.ResetText()
        ConfirmedBy.ResetText()
        ReceivesCommunion.ResetText()
        ynotreceivecommunion.ResetText()
        MaritalStatus.ResetText()
        MarriageForm.ResetText()
        YearMarried.ResetText()
        WeddingLocation.ResetText()
        SpecOther.ResetText()
        Havekids.ResetText()
        howmanykids.ResetText()
        SpouceNames.ResetText()
        SpoucepProfession.ResetText()
        SpouceNo.ResetText()
        SpouceEmployer.ResetText()
    End Sub

    'now we deal with the other member details... I bet it will be a walk in the park :)
    Private Sub OtherDCombo_Boxes()
        'fill Prefered services
        PrefService.Items.Add("Teens Service")
        PrefService.Items.Add("English Service")
        PrefService.Items.Add("Kikuyu Service")

        'Fill comfortable with service timing
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
    Private Sub loadOtherMID()
        Dim READER As MySqlDataReader
        Try
            MySQLKon.Open()
            Dim Query As String
            Query = "Select * from mukuyu.church_members"
            Command = New MySqlCommand(Query, MySQLKon)
            READER = Command.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("Memeber_ID")
                otherMemberID.Items.Add(sName)
            End While
            MySQLKon.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")
        Finally
            MySQLKon.Dispose()
        End Try
    End Sub
    Private Sub Membership_Validate_Click(sender As System.Object, e As System.EventArgs) Handles Membership_Validate.Click
        Checkboxes()
        If PrefService.Text = "" Or ComfTiming.Text = "" Or bornAgain.Text = "" Or EnrolledIn.Text = "" Or CellGroup.Text = "" Or AttFellowship.Text = "" Or Memberlength.Text = "" Or FormerDiocese.Text = "" Or participation.Text = "" Then
            MessageBox.Show("One of the fields has not been populated" & vbCrLf & "Please recheck that all the necessary data has been entered", "Empty Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PrefService.Focus()
            Membership_Save.Enabled = False
        Else
            Membership_Save.Enabled = True
        End If
    End Sub
    Private Sub otherMemberID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles otherMemberID.TextChanged
        Dim Query As String
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"
        If otherMemberID.Text = "" Or otherMemberID.Text = "0" Then
            resetOther()
        Else
            Try
                MySQLKon.Open()
                Query = "Select * from mukuyu.church_Members where Memeber_ID='" & otherMemberID.Text & "'"
                Command = New MySqlCommand(Query, MySQLKon)
                READER = Command.ExecuteReader
                While READER.Read
                    FullNoms.Text = READER.GetString("Full_Names")
                    PhoneNoos.Text = READER.GetString("Telephone_Number")
                    PrefService.Text = READER.GetString("Prefered_Service")
                    ComfTiming.Text = READER.GetString("Confortable_with_Service_Timeing")
                    WhyUncWithSerTme.Text = READER.GetString("If_No_Why")
                    bornAgain.Text = READER.GetString("Born_Again")
                    EnrolledIn.Text = READER.GetString("Enrolled_in")
                    ynotEnrolled.Text = READER.GetString("Why_Not")
                    CellGroup.Text = READER.GetString("Cell_Group")
                    AttFellowship.Text = READER.GetString("Attend_Fellowships")
                    ynotAttFel.Text = READER.GetString("Why_not_attend")
                    Memberlength.Text = READER.GetString("Member_for_How_Long")
                    FormerChurch.Text = READER.GetString("Formaer_CHurch")
                    FormerDiocese.Text = READER.GetString("Diocese")
                    yrelocate.Text = READER.GetString("Why_Relocate_here")
                    participation.Text = READER.GetString("Areas_of_Participation")
                    improvement_comment.Text = READER.GetString("comments")
                End While
            Catch ex As Exception
                MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                MySQLKon.Dispose()
            End Try
        End If
    End Sub
    Private Sub resetOther()
        FullNoms.ResetText()
        otherMemberID.ResetText()
        PhoneNoos.ResetText()
        PrefService.ResetText()
        ComfTiming.ResetText()
        WhyUncWithSerTme.ResetText()
        bornAgain.ResetText()
        EnrolledIn.ResetText()
        ynotEnrolled.ResetText()
        CellGroup.ResetText()
        AttFellowship.ResetText()
        ynotAttFel.ResetText()
        Memberlength.ResetText()
        FormerChurch.ResetText()
        FormerDiocese.ResetText()
        yrelocate.ResetText()
        participation.ResetText()
        improvement_comment.ResetText()
    End Sub
    Private Sub Membership_Save_Click(sender As System.Object, e As System.EventArgs) Handles Membership_Save.Click
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim Kommando As MySqlCommand
        Dim Soma As MySqlDataReader
        Dim Query As String
        Try
            MySQLKon.Open()
            Query = "update mukuyu.Church_Members set Prefered_Service='" & PrefService.Text & "', Confortable_with_Service_Timeing='" & ComfTiming.Text & "', If_No_Why='" & WhyUncWithSerTme.Text & "', Born_Again='" & bornAgain.Text & "', Enrolled_in='" & EnrolledIn.Text & "', Why_Not='" & ynotEnrolled.Text & "', Cell_Group='" & CellGroup.Text & "', Attend_Fellowships='" & AttFellowship.Text & "', Why_not_attend='" & ynotAttFel.Text & "', Member_for_How_Long='" & Memberlength.Text & "', Formaer_CHurch='" & FormerChurch.Text & "', Diocese='" & FormerDiocese.Text & "', Why_Relocate_here='" & yrelocate.Text & "', Areas_of_Participation='" & participation.Text & "', comments='" & improvement_comment.Text & "' where Memeber_ID='" & otherMemberID.Text & "' "
            Kommando = New MySqlCommand(Query, MySQLKon)
            Soma = Kommando.ExecuteReader
            MessageBox.Show("The record has been updateded.", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("Error in saving data!" & vbCrLf & "1. Check connection to the database" & vbCrLf & "2. Check for error in the data", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Membership_Save.Enabled = False
        End Try
    End Sub
End Class