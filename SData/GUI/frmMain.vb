Public Class frmMain

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim vs As String = My.Application.Info.Version.ToString
        Dim va_ar As String() = vs.Split(".")
        Dim version As String = " "
        If va_ar.Length > 3 Then
            For i As Integer = 0 To 2
                version &= va_ar(i) & "."
            Next
            SharingEntrities.version = version.Substring(0, version.Length - 1)
        End If
        LabelItem1.Text &= SharingEntrities.version

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim a As New frmLogin
        a.ShowDialog()
        Dim d As New frmWhaIsNew
        d.MdiParent = Me
        d.WindowState = FormWindowState.Maximized
        d.Show()
    End Sub

    Private Sub whatNew_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whatNew_b.Click
        Dim a As New frmWhaIsNew
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub abount_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abount_b.Click
        Dim a As New frmAbout()
        a.ShowDialog()
    End Sub

    Private Sub upgradeStructure_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upgradeStructure_b.Click
        Dim a As New frmUpgradeStructure
        a.ShowDialog()
    End Sub

    Private Sub vs2020Old_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vs2020Old_b.Click
        Dim a As New frmExportOldPersonVission
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub vs2020Student_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vs2020Student_b.Click
        Dim a As New frmExportStudentVission
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub exportDataCorrect_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exportDataCorrect_b.Click
        Dim a As New frmExportDataCorrect
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub reprot_motherandchild_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reprot_motherandchild_b.Click
        Dim a As New frmRepMotherAndChild
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub eh_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eh_b.Click
        Dim a As New frmRepEH
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub repEPI_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repEPI_b.Click
        Dim a As New frmRepEIP
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub qof_rep_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qof_rep_b.Click
        Dim a As New frmRepQOF
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub Export43F_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export43F_b.Click
        Dim a As New frmExport50F
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub older_kpi_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles older_kpi_b.Click
        Dim a As New frmRepOlder
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub account8_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles account8_bt.Click
        Dim a As New frmAccount8
        a.MdiParent = Me
        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

End Class