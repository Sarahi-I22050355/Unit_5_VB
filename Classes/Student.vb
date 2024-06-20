Public Class Student
    Public Property Id As Integer
    Public Property Name As String
    Public Property LastName As String
    Public Property Unit1 As Integer
    Public Property Unit2 As Integer
    Public Property Unit3 As Integer

    Public ReadOnly Property Average As Decimal
        Get
            Return (Unit1 + Unit2 + Unit3) / 3
        End Get
    End Property
End Class
