Public Class Hash
    Implements IOrganization

    Private ReadOnly hashTable As Dictionary(Of Integer, Student)

    Public Sub New()
        hashTable = New Dictionary(Of Integer, Student)()
    End Sub

    Public ReadOnly Property Count As Integer Implements IOrganization.Count
        Get
            Return hashTable.Count
        End Get
    End Property

    Public Sub Add(alumno As Student) Implements IOrganization.Add
        hashTable.Add(alumno.Id, alumno)
        Update()
    End Sub

    Public Sub Delete(id As Integer) Implements IOrganization.Delete
        If hashTable.ContainsKey(id) Then
            hashTable.Remove(id)
            Update()
        End If
    End Sub

    Public Sub Search(id As Integer, dataGridView As DataGridView) Implements IOrganization.Search
        dataGridView.Rows.Clear()

        Dim alumnoEncontrado As Student = Nothing
        If hashTable.TryGetValue(id, alumnoEncontrado) Then
            dataGridView.Rows.Add(alumnoEncontrado.Id, alumnoEncontrado.Name, alumnoEncontrado.LastName, alumnoEncontrado.Unit1, alumnoEncontrado.Unit2, alumnoEncontrado.Unit3, alumnoEncontrado.Average)
        End If
    End Sub

    Public Sub Edit(id As Integer, nuevoAlumno As Student) Implements IOrganization.Edit
        If hashTable.ContainsKey(id) Then
            hashTable(id) = nuevoAlumno
        End If
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IOrganization.Show
        dataGridView.Rows.Clear()

        For Each alumno As Student In hashTable.Values
            dataGridView.Rows.Add(alumno.Id, alumno.Name, alumno.LastName, alumno.Unit1, alumno.Unit2, alumno.Unit3, alumno.Average)
        Next
    End Sub

    Public Sub Update()
        Dim id As Integer = 0
        For Each alumno As Student In hashTable.Values
            alumno.Id = id
            id += 1
        Next
    End Sub

End Class
