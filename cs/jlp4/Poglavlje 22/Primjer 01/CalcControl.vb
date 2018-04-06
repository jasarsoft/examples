<ComClass(CalcControl.ClassId, CalcControl.InterfaceId, CalcControl.EventsId)> _
Public Class CalcControl

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "d0f51560-76c4-4eec-b623-d2d833d2cc80"
    Public Const InterfaceId As String = "5adffa73-ba81-428b-9190-75d134d18efe"
    Public Const EventsId As String = "8294ff87-5c81-4390-b8b3-792805e0f3c6"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

    Public Function Add(left As Double, right As Double)
        Add = left + right
    End Function

    Public Function Substract(left As Double, right As Double)
        Substract = left - right
    End Function

    Public Function Multiply(left As Double, right As Double)
        Multiply = left * right
    End Function

    Public Function Divide(left As Double, right As Double)
        Divide = left / right
    End Function

End Class


