<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equitation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(equitation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.personneequitation = New System.Windows.Forms.NumericUpDown()
        Me.parcoursequitation = New System.Windows.Forms.NumericUpDown()
        Me.btconges = New System.Windows.Forms.RadioButton()
        Me.btsemaine = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fraisEquitation = New System.Windows.Forms.Button()
        Me.lbleq = New System.Windows.Forms.Label()
        CType(Me.personneequitation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parcoursequitation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(182, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarif pour l'equitation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(394, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 85)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de personne"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero de parcours"
        '
        'personneequitation
        '
        Me.personneequitation.Location = New System.Drawing.Point(335, 154)
        Me.personneequitation.Name = "personneequitation"
        Me.personneequitation.Size = New System.Drawing.Size(43, 22)
        Me.personneequitation.TabIndex = 4
        '
        'parcoursequitation
        '
        Me.parcoursequitation.Location = New System.Drawing.Point(335, 212)
        Me.parcoursequitation.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.parcoursequitation.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.parcoursequitation.Name = "parcoursequitation"
        Me.parcoursequitation.Size = New System.Drawing.Size(43, 22)
        Me.parcoursequitation.TabIndex = 5
        Me.parcoursequitation.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btconges
        '
        Me.btconges.AutoSize = True
        Me.btconges.Location = New System.Drawing.Point(423, 151)
        Me.btconges.Name = "btconges"
        Me.btconges.Size = New System.Drawing.Size(243, 21)
        Me.btconges.TabIndex = 6
        Me.btconges.TabStop = True
        Me.btconges.Text = "Fin de semaine ou jour de conges"
        Me.btconges.UseVisualStyleBackColor = True
        '
        'btsemaine
        '
        Me.btsemaine.AutoSize = True
        Me.btsemaine.Location = New System.Drawing.Point(423, 214)
        Me.btsemaine.Name = "btsemaine"
        Me.btsemaine.Size = New System.Drawing.Size(134, 21)
        Me.btsemaine.TabIndex = 7
        Me.btsemaine.TabStop = True
        Me.btsemaine.Text = "Jour de semaine"
        Me.btsemaine.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(326, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fraisEquitation
        '
        Me.fraisEquitation.Location = New System.Drawing.Point(520, 285)
        Me.fraisEquitation.Name = "fraisEquitation"
        Me.fraisEquitation.Size = New System.Drawing.Size(110, 35)
        Me.fraisEquitation.TabIndex = 9
        Me.fraisEquitation.Text = "Montant du"
        Me.fraisEquitation.UseVisualStyleBackColor = True
        '
        'lbleq
        '
        Me.lbleq.AutoSize = True
        Me.lbleq.Location = New System.Drawing.Point(668, 303)
        Me.lbleq.Name = "lbleq"
        Me.lbleq.Size = New System.Drawing.Size(0, 17)
        Me.lbleq.TabIndex = 11
        '
        'equitation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbleq)
        Me.Controls.Add(Me.fraisEquitation)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btsemaine)
        Me.Controls.Add(Me.btconges)
        Me.Controls.Add(Me.parcoursequitation)
        Me.Controls.Add(Me.personneequitation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "equitation"
        Me.Text = "equitation"
        CType(Me.personneequitation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parcoursequitation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents personneequitation As NumericUpDown
    Friend WithEvents parcoursequitation As NumericUpDown
    Friend WithEvents btconges As RadioButton
    Friend WithEvents btsemaine As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents fraisEquitation As Button
    Friend WithEvents lbleq As Label
End Class
