Imports System.Security.Policy

Public Class RandomAccess
    Implements IOrganization

    Private ReadOnly organizationsHash As Hash

    Public Sub New()
        organizationsHash = New Hash()
    End Sub

    Public ReadOnly Property Count As Integer Implements IOrganization.Count
        Get
            Return organizationsHash.Count
        End Get
    End Property

    Public Sub Add(alumno As Student) Implements IOrganization.Add
        organizationsHash.Add(alumno)
        Update()
    End Sub

    Public Sub Delete(id As Integer) Implements IOrganization.Delete
        organizationsHash.Delete(id)
        Update()
    End Sub

    Public Sub Search(id As Integer, dataGridView As DataGridView) Implements IOrganization.Search
        organizationsHash.Search(id, dataGridView)
    End Sub

    Public Sub Edit(id As Integer, nuevoAlumno As Student) Implements IOrganization.Edit
        organizationsHash.Edit(id, nuevoAlumno)
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IOrganization.Show
        organizationsHash.Show(dataGridView)
    End Sub

    Private Sub Update()
        organizationsHash.Update()
    End Sub
End Class
