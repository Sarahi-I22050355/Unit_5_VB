Public Class Sequential
    Implements IOrganization

    Private ReadOnly alumnos As List(Of Student)

    Public Sub New()
        alumnos = New List(Of Student)()
    End Sub

    Public ReadOnly Property Count As Integer Implements IOrganization.Count
        Get
            Return alumnos.Count
        End Get
    End Property

    Public Sub Add(alumno As Student) Implements IOrganization.Add
        alumnos.Add(alumno)
        Update()
    End Sub

    Public Sub Delete(id As Integer) Implements IOrganization.Delete
        Dim alumno As Student = alumnos.Find(Function(a) a.Id = id)
        If alumno IsNot Nothing Then
            alumnos.Remove(alumno)
            Update()
        End If
    End Sub

    Public Sub Search(id As Integer, dataGridView As DataGridView) Implements IOrganization.Search
        dataGridView.Rows.Clear()

        Dim alumnoEncontrado As Student = alumnos.Find(Function(a) a.Id = id)
        If alumnoEncontrado IsNot Nothing Then
            dataGridView.Rows.Add(alumnoEncontrado.Id, alumnoEncontrado.Name, alumnoEncontrado.LastName, alumnoEncontrado.Unit1, alumnoEncontrado.Unit2, alumnoEncontrado.Unit3, alumnoEncontrado.Average)
        End If
    End Sub

    Public Sub Edit(id As Integer, nuevoAlumno As Student) Implements IOrganization.Edit
        Dim index As Integer = alumnos.FindIndex(Function(a) a.Id = id)
        If index <> -1 Then
            alumnos(index) = nuevoAlumno
        End If
    End Sub

    Public Sub Show(dataGridView As DataGridView) Implements IOrganization.Show
        dataGridView.Rows.Clear()

        For Each alumno As Student In alumnos
            dataGridView.Rows.Add(alumno.Id, alumno.Name, alumno.LastName, alumno.Unit1, alumno.Unit2, alumno.Unit3, alumno.Average)
        Next
    End Sub

    Private Sub Update()
        For i As Integer = 0 To alumnos.Count - 1
            alumnos(i).Id = i
        Next
    End Sub
End Class
