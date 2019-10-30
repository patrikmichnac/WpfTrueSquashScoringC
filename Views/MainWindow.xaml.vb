Imports System.ComponentModel

Class MainWindow

    Private Shared MainViewModel As New MainViewModel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = MainViewModel
    End Sub


    Private Sub ButtonClickOpenWindow()
        button3.IsEnabled = False

        Dim SubWindow As New OutputWindow()
        SubWindow.DataContext = MainViewModel
        SubWindow.Show()
    End Sub

    Private Sub ButtonClickZmenScore()
        MainViewModel.ZmenScore()
    End Sub

    Private Sub ButtonCloseApp()
        Application.Current.Shutdown()
    End Sub

    Private Sub Window_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs)
        'MessageBox.Show("Closing")
    End Sub

    Private Sub Window_Closed(sender As Object, e As EventArgs)
        'MessageBox.Show("Closed")
    End Sub

    Private Sub btnScore_Click(sender As Object, e As RoutedEventArgs) Handles btnScore.Click
        MainViewModel.isScoreVisible = Visibility.Visible
        MainViewModel.isSettingsVisible = Visibility.Hidden
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As RoutedEventArgs) Handles btnSettings.Click
        MainViewModel.isScoreVisible = Visibility.Hidden
        MainViewModel.isSettingsVisible = Visibility.Visible
    End Sub
End Class
