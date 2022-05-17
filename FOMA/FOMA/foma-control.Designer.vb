<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnDescargarNomina = New System.Windows.Forms.Button()
        Me.btnConsultarVenta = New System.Windows.Forms.Button()
        Me.btnCargarVenta = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 34)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(858, 60)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Coral
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 0)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(20, 12, 0, 2)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 34)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDescargarNomina)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnConsultarVenta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCargarVenta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgregar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(858, 505)
        Me.SplitContainer1.SplitterDistance = 138
        Me.SplitContainer1.TabIndex = 1
        '
        'btnDescargarNomina
        '
        Me.btnDescargarNomina.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDescargarNomina.FlatAppearance.BorderSize = 0
        Me.btnDescargarNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescargarNomina.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargarNomina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDescargarNomina.Image = CType(resources.GetObject("btnDescargarNomina.Image"), System.Drawing.Image)
        Me.btnDescargarNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargarNomina.Location = New System.Drawing.Point(0, 156)
        Me.btnDescargarNomina.Name = "btnDescargarNomina"
        Me.btnDescargarNomina.Size = New System.Drawing.Size(138, 52)
        Me.btnDescargarNomina.TabIndex = 8
        Me.btnDescargarNomina.Text = "Descargar nomina de clientes"
        Me.btnDescargarNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargarNomina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDescargarNomina.UseVisualStyleBackColor = True
        '
        'btnConsultarVenta
        '
        Me.btnConsultarVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultarVenta.FlatAppearance.BorderSize = 0
        Me.btnConsultarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarVenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnConsultarVenta.Image = CType(resources.GetObject("btnConsultarVenta.Image"), System.Drawing.Image)
        Me.btnConsultarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarVenta.Location = New System.Drawing.Point(0, 104)
        Me.btnConsultarVenta.Name = "btnConsultarVenta"
        Me.btnConsultarVenta.Size = New System.Drawing.Size(138, 52)
        Me.btnConsultarVenta.TabIndex = 7
        Me.btnConsultarVenta.Text = "Consultar ventas"
        Me.btnConsultarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultarVenta.UseVisualStyleBackColor = True
        '
        'btnCargarVenta
        '
        Me.btnCargarVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargarVenta.FlatAppearance.BorderSize = 0
        Me.btnCargarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarVenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnCargarVenta.Image = CType(resources.GetObject("btnCargarVenta.Image"), System.Drawing.Image)
        Me.btnCargarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarVenta.Location = New System.Drawing.Point(0, 52)
        Me.btnCargarVenta.Name = "btnCargarVenta"
        Me.btnCargarVenta.Size = New System.Drawing.Size(138, 52)
        Me.btnCargarVenta.TabIndex = 6
        Me.btnCargarVenta.Text = "Cargar ventas"
        Me.btnCargarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargarVenta.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(138, 52)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar cliente"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(546, 276)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(592, 482)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraLight", 44.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(454, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(791, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡BIENVENIDO A FOMA CONTROL!"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 52)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salir del sistema"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "FOMA Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConsultarVenta As Button
    Friend WithEvents btnCargarVenta As Button
    Friend WithEvents btnDescargarNomina As Button
    Friend WithEvents Button1 As Button
End Class
