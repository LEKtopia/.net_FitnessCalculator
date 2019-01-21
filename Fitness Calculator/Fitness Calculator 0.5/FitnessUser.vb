Imports System.Text.RegularExpressions

Public Class FitnessUser
    Public age As Integer

    Private cName As String
    Private cGender As String


    ' Gets and Sets the Name field
    Public Property Name() As String
        Get
            Return cName
        End Get
        Set(ByVal value As String)
            If isValidName(value) Then
                cName = value
            Else
                MessageBox.Show("Enter valid name containing only letters and/or spaces to continue.")
            End If
            cName = value
        End Set
    End Property
    ' Function: Makes sure name requires letters
    Private Function isValidName(name As String) As Boolean
        Dim pattern As String = "[a-zA-z\s]+$"
        Dim reg As New Regex(pattern)
        Return reg.IsMatch(name)
    End Function
    ' Create a Gender property
    Public Property Gender() As String
        Get
            Return cGender
        End Get
        Set(ByVal value As String)
            If value = "Male" Or value = "Female" Then
                cGender = value
            Else
                cGender = "Male"
            End If
        End Set
    End Property
End Class
