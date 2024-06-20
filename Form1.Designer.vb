<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListFilesData = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTXT = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveHowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecuencialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoAleatorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add = New System.Windows.Forms.Button()
        Me.NombreTXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Unidad1TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ApellidoTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Unidad3TXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Unidad2TXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.ViewAll = New System.Windows.Forms.Button()
        CType(Me.ListFilesData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListFilesData
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListFilesData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListFilesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListFilesData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Apellido, Me.Unidad1, Me.Unidad2, Me.Unidad3, Me.Promedio})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListFilesData.DefaultCellStyle = DataGridViewCellStyle2
        Me.ListFilesData.Location = New System.Drawing.Point(12, 136)
        Me.ListFilesData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListFilesData.Name = "ListFilesData"
        Me.ListFilesData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.ListFilesData.Size = New System.Drawing.Size(734, 344)
        Me.ListFilesData.TabIndex = 0
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Unidad1
        '
        Me.Unidad1.HeaderText = "Unidad1"
        Me.Unidad1.Name = "Unidad1"
        '
        'Unidad2
        '
        Me.Unidad2.HeaderText = "Unidad2"
        Me.Unidad2.Name = "Unidad2"
        '
        'Unidad3
        '
        Me.Unidad3.HeaderText = "Unidad3"
        Me.Unidad3.Name = "Unidad3"
        '
        'Promedio
        '
        Me.Promedio.HeaderText = "Promedio"
        Me.Promedio.Name = "Promedio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(2, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'IDTXT
        '
        Me.IDTXT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IDTXT.Location = New System.Drawing.Point(47, 35)
        Me.IDTXT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IDTXT.Name = "IDTXT"
        Me.IDTXT.Size = New System.Drawing.Size(178, 33)
        Me.IDTXT.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OrganizaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 31)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveHowToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveHowToolStripMenuItem
        '
        Me.SaveHowToolStripMenuItem.Name = "SaveHowToolStripMenuItem"
        Me.SaveHowToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SaveHowToolStripMenuItem.Text = "Save How"
        '
        'OrganizaToolStripMenuItem
        '
        Me.OrganizaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecuencialsToolStripMenuItem, Me.HashToolStripMenuItem, Me.AccesoAleatorioToolStripMenuItem})
        Me.OrganizaToolStripMenuItem.Name = "OrganizaToolStripMenuItem"
        Me.OrganizaToolStripMenuItem.Size = New System.Drawing.Size(119, 25)
        Me.OrganizaToolStripMenuItem.Text = "Organizations"
        '
        'SecuencialsToolStripMenuItem
        '
        Me.SecuencialsToolStripMenuItem.Name = "SecuencialsToolStripMenuItem"
        Me.SecuencialsToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.SecuencialsToolStripMenuItem.Text = "Sequentials"
        '
        'HashToolStripMenuItem
        '
        Me.HashToolStripMenuItem.Name = "HashToolStripMenuItem"
        Me.HashToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.HashToolStripMenuItem.Text = "Hash"
        '
        'AccesoAleatorioToolStripMenuItem
        '
        Me.AccesoAleatorioToolStripMenuItem.Name = "AccesoAleatorioToolStripMenuItem"
        Me.AccesoAleatorioToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.AccesoAleatorioToolStripMenuItem.Text = "Random Access"
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Add.Location = New System.Drawing.Point(765, 145)
        Me.Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(133, 47)
        Me.Add.TabIndex = 4
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'NombreTXT
        '
        Me.NombreTXT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NombreTXT.Location = New System.Drawing.Point(106, 95)
        Me.NombreTXT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NombreTXT.Name = "NombreTXT"
        Me.NombreTXT.Size = New System.Drawing.Size(119, 33)
        Me.NombreTXT.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(2, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'Unidad1TXT
        '
        Me.Unidad1TXT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Unidad1TXT.Location = New System.Drawing.Point(358, 95)
        Me.Unidad1TXT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Unidad1TXT.Name = "Unidad1TXT"
        Me.Unidad1TXT.Size = New System.Drawing.Size(111, 33)
        Me.Unidad1TXT.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(246, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Unit 1:"
        '
        'ApellidoTXT
        '
        Me.ApellidoTXT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ApellidoTXT.Location = New System.Drawing.Point(351, 35)
        Me.ApellidoTXT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ApellidoTXT.Name = "ApellidoTXT"
        Me.ApellidoTXT.Size = New System.Drawing.Size(118, 33)
        Me.ApellidoTXT.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(246, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name:"
        '
        'Unidad3TXT
        '
        Me.Unidad3TXT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Unidad3TXT.Location = New System.Drawing.Point(623, 95)
        Me.Unidad3TXT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Unidad3TXT.Name = "Unidad3TXT"
        Me.Unidad3TXT.Size = New System.Drawing.Size(111, 33)
        Me.Unidad3TXT.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(511, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Unit 3:"
        '
        'Unidad2TXT
        '
        Me.Unidad2TXT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Unidad2TXT.Location = New System.Drawing.Point(623, 35)
        Me.Unidad2TXT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Unidad2TXT.Name = "Unidad2TXT"
        Me.Unidad2TXT.Size = New System.Drawing.Size(111, 33)
        Me.Unidad2TXT.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(511, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Unit 2:"
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Delete.Location = New System.Drawing.Point(765, 200)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(133, 47)
        Me.Delete.TabIndex = 15
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Search.Location = New System.Drawing.Point(765, 254)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(133, 47)
        Me.Search.TabIndex = 16
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Edit.Location = New System.Drawing.Point(765, 309)
        Me.Edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(133, 47)
        Me.Edit.TabIndex = 17
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'ViewAll
        '
        Me.ViewAll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewAll.Location = New System.Drawing.Point(765, 364)
        Me.ViewAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ViewAll.Name = "ViewAll"
        Me.ViewAll.Size = New System.Drawing.Size(133, 47)
        Me.ViewAll.TabIndex = 18
        Me.ViewAll.Text = "Show All"
        Me.ViewAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 491)
        Me.Controls.Add(Me.ViewAll)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Unidad3TXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Unidad2TXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Unidad1TXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ApellidoTXT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NombreTXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.IDTXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListFilesData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Unit 5 VB"
        CType(Me.ListFilesData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListFilesData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTXT As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Add As Button
    Friend WithEvents SecuencialsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoAleatorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NombreTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Unidad1TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ApellidoTXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Unidad3TXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Unidad2TXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Delete As Button
    Friend WithEvents Search As Button
    Friend WithEvents Edit As Button
    Friend WithEvents ViewAll As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Unidad1 As DataGridViewTextBoxColumn
    Friend WithEvents Unidad2 As DataGridViewTextBoxColumn
    Friend WithEvents Unidad3 As DataGridViewTextBoxColumn
    Friend WithEvents Promedio As DataGridViewTextBoxColumn

End Class
