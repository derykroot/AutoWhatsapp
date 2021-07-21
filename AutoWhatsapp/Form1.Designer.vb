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
        Me.components = New System.ComponentModel.Container()
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'webBrowser1
        '
        Me.webBrowser1.Location = New System.Drawing.Point(292, 43)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(355, 379)
        Me.webBrowser1.TabIndex = 11
        '
        'listBox1
        '
        Me.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 20
        Me.listBox1.Location = New System.Drawing.Point(26, 145)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(224, 264)
        Me.listBox1.TabIndex = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(23, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 17)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Quantidade:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(23, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 17)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Numero inicial"
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(115, 85)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(135, 26)
        Me.textBox2.TabIndex = 7
        Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(26, 43)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(224, 26)
        Me.textBox1.TabIndex = 6
        Me.textBox1.Text = "55"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(292, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(129, 24)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Mostrar Painel"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 455)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.webBrowser1)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "AutoWhatsApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
