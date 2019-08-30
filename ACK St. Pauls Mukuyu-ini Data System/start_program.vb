Public Class start_program


    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 0 Then
            directions.Text = "Checking Database"

        ElseIf ProgressBar1.Value = 10 Then
            directions.Text = "Loading Program"

        ElseIf ProgressBar1.Value = 20 Then
            directions.Text = "Loading User Interfaces"

        ElseIf ProgressBar1.Value = 30 Then
            directions.Text = "Loading Data"

        ElseIf ProgressBar1.Value = 40 Then
            directions.Text = "Loading."

        ElseIf ProgressBar1.Value = 50 Then
            directions.Text = "Loading.."

        ElseIf ProgressBar1.Value = 60 Then
            directions.Text = "Loading..."

        ElseIf ProgressBar1.Value = 70 Then
            directions.Text = "Loading Program"

        ElseIf ProgressBar1.Value = 100 Then
            Login.Show()
            Timer1.Stop()
            Me.Hide()

        End If

    End Sub

    Private Sub start_program_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class