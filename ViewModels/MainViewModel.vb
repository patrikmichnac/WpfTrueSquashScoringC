Public Class MainViewModel
    Inherits BaseViewModel

    Private _score As clsScore

    Public Sub New()
        AddScore()
        isScoreVisible = Visibility.Visible
        isSettingsVisible = Visibility.Hidden
    End Sub


    Public Property MyScore As clsScore
        Get
            Return _score
        End Get
        Set
            _score = Value
            NotificationPropertyChanged("MyScore")
        End Set
    End Property

    Private _isScoreVisible As Visibility
    Public Property isScoreVisible() As Visibility
        Get
            Return _isScoreVisible
        End Get
        Set(ByVal value As Visibility)
            _isScoreVisible = value
            NotificationPropertyChanged("isScoreVisible")
        End Set
    End Property

    Private _isSettingsVisible As Visibility
    Public Property isSettingsVisible() As Visibility
        Get
            Return _isSettingsVisible
        End Get
        Set(ByVal value As Visibility)
            _isSettingsVisible = value
            NotificationPropertyChanged("isSettingsVisible")
        End Set
    End Property


    Private Sub AddScore()
        Dim lcScore As New clsScore

        lcScore.LeftScore = 10
        lcScore.RightScore = 5
        lcScore.Serve = clsScore.EnumServe.Right

        MyScore = lcScore
    End Sub

    Public Sub ZmenScore()
        Dim lcScore As New clsScore

        lcScore.LeftScore = MyScore.LeftScore + 1
        lcScore.RightScore = MyScore.RightScore + 1
        lcScore.Serve = clsScore.EnumServe.Right

        MyScore = lcScore
    End Sub

End Class
