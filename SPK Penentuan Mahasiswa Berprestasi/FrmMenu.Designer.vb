<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.tsKeluar = New System.Windows.Forms.ToolStripLabel()
        Me.tsMaster = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsDataAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsDataMahasiswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsKriteria = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnalisa = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsHelp = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsKeluar
        '
        Me.tsKeluar.Image = CType(resources.GetObject("tsKeluar.Image"), System.Drawing.Image)
        Me.tsKeluar.Name = "tsKeluar"
        Me.tsKeluar.Size = New System.Drawing.Size(77, 75)
        Me.tsKeluar.Text = "Keluar"
        Me.tsKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsMaster
        '
        Me.tsMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDataAdmin, Me.tsDataMahasiswa, Me.tsKriteria})
        Me.tsMaster.Image = CType(resources.GetObject("tsMaster.Image"), System.Drawing.Image)
        Me.tsMaster.Name = "tsMaster"
        Me.tsMaster.Size = New System.Drawing.Size(77, 79)
        Me.tsMaster.Text = "Master"
        Me.tsMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsDataAdmin
        '
        Me.tsDataAdmin.Name = "tsDataAdmin"
        Me.tsDataAdmin.Size = New System.Drawing.Size(212, 30)
        Me.tsDataAdmin.Text = "Data Admin"
        '
        'tsDataMahasiswa
        '
        Me.tsDataMahasiswa.Name = "tsDataMahasiswa"
        Me.tsDataMahasiswa.Size = New System.Drawing.Size(212, 30)
        Me.tsDataMahasiswa.Text = "Data Mahasiswa"
        '
        'tsKriteria
        '
        Me.tsKriteria.Name = "tsKriteria"
        Me.tsKriteria.Size = New System.Drawing.Size(212, 30)
        Me.tsKriteria.Text = "Data Kriteria"
        '
        'tsAnalisa
        '
        Me.tsAnalisa.Image = CType(resources.GetObject("tsAnalisa.Image"), System.Drawing.Image)
        Me.tsAnalisa.Name = "tsAnalisa"
        Me.tsAnalisa.Size = New System.Drawing.Size(77, 75)
        Me.tsAnalisa.Text = "Analisa"
        Me.tsAnalisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsKeluar, Me.tsMaster, Me.tsAnalisa, Me.tsHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(80, 572)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsHelp
        '
        Me.tsHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMeToolStripMenuItem})
        Me.tsHelp.Image = CType(resources.GetObject("tsHelp.Image"), System.Drawing.Image)
        Me.tsHelp.Name = "tsHelp"
        Me.tsHelp.Size = New System.Drawing.Size(77, 79)
        Me.tsHelp.Text = "Help"
        Me.tsHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.AboutMeToolStripMenuItem.Text = "About Me"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(80, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(787, 31)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(139, 28)
        Me.ToolStripLabel1.Text = "U-Smart V1.0"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SPK_Penentuan_Mahasiswa_Berprestasi.My.Resources.Resources._629055
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(867, 572)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMenu"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsKeluar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsMaster As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsDataAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDataMahasiswa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsKriteria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAnalisa As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsHelp As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AboutMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
