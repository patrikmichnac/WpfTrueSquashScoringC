Public Class UserControlNumericUpDownViewModel
    Inherits BaseViewModel

    Private _value As Integer
    Public Property value() As Integer
        Get
            Return _value
        End Get
        Set(ByVal value As Integer)
            _value = value
            NotificationPropertyChanged("value")
        End Set
    End Property

    Public Sub plus(ByVal pocet As Integer)
        value += pocet
    End Sub

    Public Sub minus(ByVal pocet As Integer)
        value -= pocet
    End Sub

End Class
