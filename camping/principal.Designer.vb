<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tarif = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Le camping de tante Irma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(346, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 68)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Fuchsia
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Fuchsia
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(280, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Fuchsia
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(190, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nb de personnes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Fuchsia
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(206, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date de depart"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Fuchsia
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(23, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Les activites"
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(403, 183)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(214, 22)
        Me.txtbox1.TabIndex = 7
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(403, 132)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(214, 22)
        Me.date1.TabIndex = 8
        Me.date1.TabStop = False
        '
        'date2
        '
        Me.date2.Location = New System.Drawing.Point(403, 298)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(214, 22)
        Me.date2.TabIndex = 9
        Me.date2.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(403, 237)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(194, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 47)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Equitation"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(370, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 47)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Canot"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(550, 479)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 47)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Escalade"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tarif
        '
        Me.tarif.BackColor = System.Drawing.Color.LightGray
        Me.tarif.Location = New System.Drawing.Point(39, 488)
        Me.tarif.Name = "tarif"
        Me.tarif.Size = New System.Drawing.Size(103, 47)
        Me.tarif.TabIndex = 14
        Me.tarif.Text = "$ Tarif $"
        Me.tarif.UseVisualStyleBackColor = False
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1020, 589)
        Me.Controls.Add(Me.tarif)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "principal"
        Me.Text = "\"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents date2 As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tarif As Button
End Class
