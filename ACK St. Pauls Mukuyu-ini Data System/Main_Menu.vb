Public Class Main_Menu

    Private Sub Main_Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Main_Menu_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddMember_Click(sender As System.Object, e As System.EventArgs) Handles AddMember.Click
        Add_Members.Show()
        Me.Hide()
    End Sub

    Private Sub EditMemberDetails_Click(sender As System.Object, e As System.EventArgs) Handles EditMemberDetails.Click
        Edit_Members.Show()
        Me.Hide()
    End Sub

    Private Sub MembStats_Click(sender As System.Object, e As System.EventArgs) Handles MembStats.Click
        Statistics.Show()
        Me.Hide()
    End Sub

    Private Sub SeeAllMembs_Click(sender As System.Object, e As System.EventArgs) Handles SeeAllMembs.Click
        AllMembersShow.Show()
        Me.Hide()
    End Sub
End Class