Public Interface IOrganization
    ReadOnly Property Count As Integer
    Sub Add(alumno As Student)
    Sub Delete(id As Integer)
    Sub Search(id As Integer, dataGridView As DataGridView)
    Sub Edit(id As Integer, nuevoAlumno As Student)
    Sub Show(dataGridView As DataGridView)
End Interface
