Imports MySql.Data.MySqlClient
Imports MySql
Public Class Add_Members
    Dim MySQLKon As MySqlConnection
    Dim Kommando As MySqlCommand
    Dim Soma As MySqlDataReader

    Private Sub Add_Members_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'check connection to the database for the purpose of logging into the system
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
        save.Enabled = False
        Combo_boxes()
    End Sub

    Private Sub Add_Members_Closed(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        'msgbox
        Main_Menu.Show()
    End Sub

    Private Sub validate_Click(sender As System.Object, e As System.EventArgs) Handles validate.Click
        Try
            If AppFnames.Text = "" Or title.Text = "" Or AppDOB.Text = "" Or ApplPOB.Text = "" Or AgeBracket.Text = "" Or Appl_PhoneNo.Text = "" Or emailAdd.Text = "" Or ApplProfession.Text = "" Or ApplOccupation.Text = "" Or ApplEmployer.Text = "" Or Residence.Text = "" Or HomeParish.Text = "" Or LocalChurch.Text = "" Or HomeDiocese.Text = "" Or Baptized.Text = "" Or BaptixedBy.Text = "" Or PlaceBaptized.Text = "" Or YearBaptized.Text = "" Or Confirmed.Text = "" Or PlaceConfirmed.Text = "" Or ConfirmedBy.Text = "" Or YearConfirmed.Text = "" Or ReceivesCommunion.Text = "" Or ynotreceivecommunion.Text = "" Or MaritalStatus.Text = "" Or MarriageForm.Text = "" Or YearMarried.Text = "" Or WeddingLocation.Text = "" Or SpecOther.Text = "" Or Havekids.Text = "" Or SpouceNames.Text = "" Or SpouceNo.Text = "" Or SpoucepProfession.Text = "" Or SpouceEmployer.Text = "" Then
                MessageBox.Show("Some Fields have not been filled!", "ACK ST. PAULS MUKUYU-INI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                save.Enabled = False
                AppFnames.Focus()
            Else
                save.Enabled = True
            End If

            If Baptized.Text.Contains("No") And Confirmed.Text.Contains("Yes") Then
                MessageBox.Show("A person that is not Baptized cannot be confirmed!!" & vbCrLf & "Please recheck that your data is correct!", "Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Baptized.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("There is an error in the data you want to submit" & vbCrLf & "Please review it and try again!", "ACK ST. PAULS MUKUYU-INI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            save.Enabled = False
        End Try
    End Sub

    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles save.Click

        Try
            'Step 1: open the connection to the database
            MySQLKon.Open()
            'step 2: declare a command that you will use to communicate with the database
            Dim Query As String
            'step 3: use the string to enter the data into the database
            Query = "insert into mukuyu.church_members (Memeber_ID, Title, Full_Names, Date_of_Birth, Place_of_Birth, Age_Bracket, Telephone_Number, Email_Address, Profession, Occupation, Employer, Residence, Home_Parish, Local_Church, Home_Diocese, Baptized, Year_Baptized, Place_of_Baptism, Baptized_By, Confirmed, Year_Confirmed, Place_of_Confirmation, Confirmed_By, Receive_Holy_Communion, Reason, Marital_Status, Form_Of_Marriage, Year_Married, Location_Of_Marriage, Specify_other, Have_Kids, Number_of_Children, Name, Spouce_Occupation, Tel_Number, Employer_) values ('""', '" & title.Text & "', '" & AppFnames.Text & "', '" & AppDOB.Text & "', '" & ApplPOB.Text & "', '" & AgeBracket.Text & "', '" & Appl_PhoneNo.Text & "', '" & emailAdd.Text & "', '" & ApplProfession.Text & "', '" & ApplOccupation.Text & "', '" & ApplEmployer.Text & "', '" & Residence.Text & "', '" & HomeParish.Text & "', '" & LocalChurch.Text & "', '" & HomeDiocese.Text & "', '" & Baptized.Text & "', '" & YearBaptized.Text & "', '" & PlaceBaptized.Text & "', '" & BaptixedBy.Text & "', '" & Confirmed.Text & "', '" & YearConfirmed.Text & "', '" & PlaceConfirmed.Text & "', '" & ConfirmedBy.Text & "', '" & ReceivesCommunion.Text & "', '" & ynotreceivecommunion.Text & "', '" & MaritalStatus.Text & "', '" & MarriageForm.Text & "', '" & YearMarried.Text & "', '" & WeddingLocation.Text & "', '" & SpecOther.Text & "', '" & Havekids.Text & "', '" & howmanykids.Text & "' , '" & SpouceNames.Text & "', '" & SpoucepProfession.Text & "', '" & SpouceNo.Text & "', '" & SpouceEmployer.Text & "')"
            Kommando = New MySqlCommand(Query, MySQLKon)
            Soma = Kommando.ExecuteReader
            MessageBox.Show("The new record has been added.", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK)
            Me.Hide()
            Add_Members2.Show()
            '
        Catch ex As Exception
            MessageBox.Show("Error in saving data!", "ACK St Pauls Mukuyu-ini", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Combo_boxes()
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
        Baptized.Items.Add("Yes")
        Baptized.Items.Add("No")

        'Confirmed combobox
        Confirmed.Items.Add("Yes")
        Confirmed.Items.Add("No")

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

    Private Sub MaritalStatus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles MaritalStatus.SelectedIndexChanged
        'it disables the irelevant fields
        If MaritalStatus.Text.Contains("Single") Then
            MarriageForm.Enabled = False
            YearMarried.Enabled = False
            YearMarried.Enabled = False
            WeddingLocation.Enabled = False
            SpecOther.Enabled = False
            SpouceNames.Enabled = False
            SpouceNo.Enabled = False
            SpoucepProfession.Enabled = False
            SpouceEmployer.Enabled = False
            'insert the n/a thingie
            MarriageForm.Text = "N/A"
            YearMarried.Text = "N/A"
            YearMarried.Text = "N/A"
            WeddingLocation.Text = "N/A"
            SpecOther.Text = "N/A"
            SpouceNames.Text = "N/A"
            SpouceNo.Text = "N/A"
            SpoucepProfession.Text = "N/A"
            SpouceEmployer.Text = "N/A"
        Else
            MarriageForm.Enabled = True
            YearMarried.Enabled = True
            YearMarried.Enabled = True
            WeddingLocation.Enabled = True
            SpecOther.Enabled = True
            SpouceNames.Enabled = True
            SpouceNo.Enabled = True
            SpoucepProfession.Enabled = True
            SpouceEmployer.Enabled = True
            'clear the boxes for alternate input
            MarriageForm.ResetText()
            YearMarried.ResetText()
            YearMarried.ResetText()
            WeddingLocation.ResetText()
            SpecOther.ResetText()
            SpouceNames.ResetText()
            SpouceNo.ResetText()
            SpoucepProfession.ResetText()
            SpouceEmployer.ResetText()
        End If
    End Sub

    Private Sub Baptized_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Baptized.SelectedIndexChanged
        If Baptized.Text.Contains("No") Then
            BaptixedBy.Enabled = False
            PlaceBaptized.Enabled = False
            YearBaptized.Enabled = False
            Confirmed.Enabled = False
            PlaceConfirmed.Enabled = False
            ConfirmedBy.Enabled = False
            YearConfirmed.Enabled = False
            ReceivesCommunion.Enabled = False
            ynotreceivecommunion.Enabled = False
            'input that N/A thingie
            BaptixedBy.Text = "N/A"
            PlaceBaptized.Text = "N/A"
            YearBaptized.Text = "N/A"
            Confirmed.Text = "N/A"
            PlaceConfirmed.Text = "N/A"
            ConfirmedBy.Text = "N/A"
            YearConfirmed.Text = "N/A"
            ReceivesCommunion.Text = "N/A"
            ynotreceivecommunion.Text = "N/A"
        Else
            BaptixedBy.Enabled = True
            PlaceBaptized.Enabled = True
            YearBaptized.Enabled = True
            Confirmed.Enabled = True
            PlaceConfirmed.Enabled = True
            ConfirmedBy.Enabled = True
            YearConfirmed.Enabled = True
            ReceivesCommunion.Enabled = True
            ynotreceivecommunion.Enabled = True
            'Toa hio nonsense hapo
            BaptixedBy.ResetText()
            PlaceBaptized.ResetText()
            YearBaptized.ResetText()
            Confirmed.ResetText()
            PlaceConfirmed.ResetText()
            ConfirmedBy.ResetText()
            YearConfirmed.ResetText()
            ReceivesCommunion.ResetText()
            ynotreceivecommunion.ResetText()
        End If
    End Sub

    Private Sub Confirmed_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Confirmed.SelectedIndexChanged
        If Confirmed.Text.Contains("No") Then
            PlaceConfirmed.Enabled = False
            ConfirmedBy.Enabled = False
            YearConfirmed.Enabled = False
            ReceivesCommunion.Enabled = False
            ynotreceivecommunion.Enabled = False
            'input these values
            PlaceConfirmed.Text = "N/A"
            ConfirmedBy.Text = "N/A"
            YearConfirmed.Text = "N/A"
            ReceivesCommunion.Text = "N/A"
            ynotreceivecommunion.Text = "N/A"

        Else
            PlaceConfirmed.Enabled = True
            ConfirmedBy.Enabled = True
            YearConfirmed.Enabled = True
            ReceivesCommunion.Enabled = True
            ynotreceivecommunion.Enabled = True
            'reset the text boxes
            PlaceConfirmed.ResetText()
            ConfirmedBy.ResetText()
            YearConfirmed.ResetText()
            ReceivesCommunion.ResetText()
            ynotreceivecommunion.ResetText()
        End If
    End Sub

    Private Sub Havekids_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Havekids.SelectedIndexChanged
        If Havekids.Text.Contains("No") Then
            howmanykids.Enabled = False
            howmanykids.Text = "0"
        Else
            howmanykids.Enabled = True
            howmanykids.ResetText()

        End If
    End Sub
End Class