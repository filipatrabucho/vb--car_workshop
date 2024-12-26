<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtinicio = New System.Windows.Forms.TextBox()
        Me.txtentrega = New System.Windows.Forms.TextBox()
        Me.txtkminicio = New System.Windows.Forms.TextBox()
        Me.txtkmfim = New System.Windows.Forms.TextBox()
        Me.lbldias = New System.Windows.Forms.Label()
        Me.lblkm = New System.Windows.Forms.Label()
        Me.lblpagamento = New System.Windows.Forms.Label()
        Me.lblPagKms = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Label1.Location = New System.Drawing.Point(419, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KN Aluguer Auto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(135, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data de Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(135, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data de Entrega"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(135, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quilometragem Inicial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(135, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quilometragem Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(378, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nº de dias (35€/dia)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(351, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "KN @0.10€ -preço total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label8.Location = New System.Drawing.Point(424, 535)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Valor a Pagar"
        '
        'txtinicio
        '
        Me.txtinicio.Location = New System.Drawing.Point(331, 262)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(204, 22)
        Me.txtinicio.TabIndex = 9
        '
        'txtentrega
        '
        Me.txtentrega.Location = New System.Drawing.Point(331, 306)
        Me.txtentrega.Name = "txtentrega"
        Me.txtentrega.Size = New System.Drawing.Size(204, 22)
        Me.txtentrega.TabIndex = 10
        '
        'txtkminicio
        '
        Me.txtkminicio.Location = New System.Drawing.Point(331, 352)
        Me.txtkminicio.Name = "txtkminicio"
        Me.txtkminicio.Size = New System.Drawing.Size(204, 22)
        Me.txtkminicio.TabIndex = 11
        '
        'txtkmfim
        '
        Me.txtkmfim.Location = New System.Drawing.Point(331, 392)
        Me.txtkmfim.Name = "txtkmfim"
        Me.txtkmfim.Size = New System.Drawing.Size(204, 22)
        Me.txtkmfim.TabIndex = 12
        '
        'lbldias
        '
        Me.lbldias.AutoSize = True
        Me.lbldias.Location = New System.Drawing.Point(287, 449)
        Me.lbldias.Name = "lbldias"
        Me.lbldias.Size = New System.Drawing.Size(0, 16)
        Me.lbldias.TabIndex = 13
        '
        'lblkm
        '
        Me.lblkm.AutoSize = True
        Me.lblkm.Location = New System.Drawing.Point(287, 485)
        Me.lblkm.Name = "lblkm"
        Me.lblkm.Size = New System.Drawing.Size(0, 16)
        Me.lblkm.TabIndex = 14
        '
        'lblpagamento
        '
        Me.lblpagamento.AutoSize = True
        Me.lblpagamento.Location = New System.Drawing.Point(559, 453)
        Me.lblpagamento.Name = "lblpagamento"
        Me.lblpagamento.Size = New System.Drawing.Size(0, 16)
        Me.lblpagamento.TabIndex = 15
        '
        'lblPagKms
        '
        Me.lblPagKms.AutoSize = True
        Me.lblPagKms.Location = New System.Drawing.Point(559, 489)
        Me.lblPagKms.Name = "lblPagKms"
        Me.lblPagKms.Size = New System.Drawing.Size(0, 16)
        Me.lblPagKms.TabIndex = 16
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(559, 538)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 16)
        Me.lbltotal.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(581, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 53)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(581, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 53)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Limpar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Location = New System.Drawing.Point(581, 381)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 53)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Fechar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(685, 629)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblPagKms)
        Me.Controls.Add(Me.lblpagamento)
        Me.Controls.Add(Me.lblkm)
        Me.Controls.Add(Me.lbldias)
        Me.Controls.Add(Me.txtkmfim)
        Me.Controls.Add(Me.txtkminicio)
        Me.Controls.Add(Me.txtentrega)
        Me.Controls.Add(Me.txtinicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "KN ALUGUER AUTO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtinicio As TextBox
    Friend WithEvents txtentrega As TextBox
    Friend WithEvents txtkminicio As TextBox
    Friend WithEvents txtkmfim As TextBox
    Friend WithEvents lbldias As Label
    Friend WithEvents lblkm As Label
    Friend WithEvents lblpagamento As Label
    Friend WithEvents lblPagKms As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
