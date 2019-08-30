Imports MySql
Imports MySql.Data.MySqlClient
Public Class Login
    Dim MySQLKon As MySqlConnection
    Dim Kommando As MySqlCommand
    Dim Soma As MySqlDataReader
    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'check connection to the database for the purpose of logging into the system
        MySQLKon = New MySqlConnection
        MySQLKon.ConnectionString = "server=localhost; userid=root; password=morris"
    End Sub

    Private Sub Login_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        MessageBox.Show("Are you sure you want to close the application?" & vbCrLf & "Unsaved data will be lost", "ACK ST PAULS MUKUYU-INI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Application.Exit()

    End Sub

    Private Sub LoginBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoginBtn.Click
        'ProfilePicBox.Image = Image.FromFile(ofdSelectPicture.FileName)
        'Check the Credentials Entered into the Login Text Box to validate Entry
            Try
            MySQLKon.Open()
                Dim Query As String
            Query = "select * from Mukuyu.Users where User_Name ='" & UserName.Text & "' and insignia ='" & Password.Text & "'"
            Kommando = New MySqlCommand(Query, MySQLKon)
            Soma = Kommando.ExecuteReader
                Dim count As Integer
                count = 0
            While Soma.Read
                count = count + 1
            End While
            If count = 1 Then
                'Step 1: open the connection to the database
                'step 2: declare a command that you will use to communicate with the database
                'step 3: use the string to enter the data into the database
                'Query = "insert into mukuyu.user_logs (Log_ID, User_Name, insignia_used, Login_Status, Login_Time, Logout_Time) values ('''', '" & UserName.Text & "', '" & Password.Text & "', 'Successful', Now(), '''')"
                'Kommando = New MySqlCommand(Query, MySQLKon)
                'Soma = Kommando.ExecuteReader
                MessageBox.Show("Login Successful")
                Password.ResetText()
                UserName.ResetText()
                Main_Menu.Show()
                Me.Hide()
            ElseIf count > 1 Then
                Query = "insert into mukuyu.user_logs (Log_ID, User_Name, insignia_used, Login_Status, Login_Time, Logout_Time) values ('''', '" & UserName.Text & "', '" & Password.Text & "', ''Failed'', Now(), '''')"
                'Kommando = New MySqlCommand(Query, MySQLKon)
                'Soma = Kommando.ExecuteReader
                MessageBox.Show("A similar username or password has been found" & vbCrLf & "Resolve this issue with the database administrator", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Query = "insert into mukuyu.user_logs (Log_ID, User_Name, insignia_used, Login_Status, Login_Time, Logout_Time) values ('''', '" & UserName.Text & "', '" & Password.Text & "', ''Failed'', Now(), '')"
                'Kommando = New MySqlCommand(Query, MySQLKon)
                'Soma = Kommando.ExecuteReader
                MessageBox.Show("Login Failed", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Password.ResetText()
                UserName.ResetText()

            End If

            Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
            Password.ResetText()
            UserName.ResetText()
            UserName.Focus()
            Finally
            MySQLKon.Dispose()
            End Try

    End Sub

    Private Sub ProfilePicBox_Click(sender As System.Object, e As System.EventArgs) Handles ProfilePicBox.Click
        Image.FromFile("C:\Users\Folio 13\Documents\Visual Studio 2010\Projects\ACK St. Pauls Mukuyu-ini Data System\ACK St. Pauls Mukuyu-ini Data System\drwables\muks.ico")
    End Sub

    Private Sub UserName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ExitBtn_Click(sender As System.Object, e As System.EventArgs) Handles ExitBtn.Click
        MessageBox.Show("Are you sure you want to close the application?" & vbCrLf & "Unsaved data will be lost", "ACK ST PAULS MUKUYU-INI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Application.Exit()
        'ExitBtn.Click
    End Sub
End Class