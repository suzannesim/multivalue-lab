'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Semester
    Public Property ID As String
    Public Property CGA_MV_KEY As Integer
    Public Property SEMESTER As String

    Public Overridable Property Student As Student
    Public Overridable Property Courses As ICollection(Of Course) = New HashSet(Of Course)

End Class
