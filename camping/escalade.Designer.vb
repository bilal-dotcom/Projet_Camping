<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class escalade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(escalade))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fraisEscalade = New System.Windows.Forms.Button()
        Me.lblesc = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(266, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarif pour l'escalade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(510, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "           Tarif pour l'escalade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Une heure par personne  :  $10,00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(351, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(395, 193)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(43, 22)
        Me.NumericUpDown2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nombre d'heures"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(395, 148)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 22)
        Me.NumericUpDown1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre de personnes"
        '
        'fraisEscalade
        '
        Me.fraisEscalade.Location = New System.Drawing.Point(558, 265)
        Me.fraisEscalade.Name = "fraisEscalade"
        Me.fraisEscalade.Size = New System.Drawing.Size(110, 38)
        Me.fraisEscalade.TabIndex = 18
        Me.fraisEscalade.Text = "Montant du"
        Me.fraisEscalade.UseVisualStyleBackColor = True
        '
        'lblesc
        '
        Me.lblesc.AutoSize = True
        Me.lblesc.Location = New System.Drawing.Point(705, 286)
        Me.lblesc.Name = "lblesc"
        Me.lblesc.Size = New System.Drawing.Size(0, 17)
        Me.lblesc.TabIndex = 19
        '
        'escalade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblesc)
        Me.Controls.Add(Me.fraisEscalade)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "escalade"
        Me.Text = "escalade"
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents fraisEscalade As Button
    Friend WithEvents lblesc As Label
End Class
