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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Spherez = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Spherex = New System.Windows.Forms.TrackBar()
        Me.Spherey = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nTB = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kdTB = New System.Windows.Forms.TrackBar()
        Me.kaTB = New System.Windows.Forms.TrackBar()
        Me.ksTB = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lightz = New System.Windows.Forms.TrackBar()
        Me.Lighty = New System.Windows.Forms.TrackBar()
        Me.Lightx = New System.Windows.Forms.TrackBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Spherez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spherex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spherey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kdTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kaTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ksTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Lightz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lighty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lightx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(379, 368)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Spherez)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Spherex)
        Me.GroupBox3.Controls.Add(Me.Spherey)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(632, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 181)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sphere Control"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Z"
        '
        'Spherez
        '
        Me.Spherez.Location = New System.Drawing.Point(50, 130)
        Me.Spherez.Margin = New System.Windows.Forms.Padding(2)
        Me.Spherez.Maximum = -10
        Me.Spherez.Minimum = -100
        Me.Spherez.Name = "Spherez"
        Me.Spherez.Size = New System.Drawing.Size(178, 45)
        Me.Spherez.TabIndex = 16
        Me.Spherez.Value = -40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "X"
        '
        'Spherex
        '
        Me.Spherex.Location = New System.Drawing.Point(50, 43)
        Me.Spherex.Margin = New System.Windows.Forms.Padding(2)
        Me.Spherex.Minimum = -10
        Me.Spherex.Name = "Spherex"
        Me.Spherex.Size = New System.Drawing.Size(179, 45)
        Me.Spherex.TabIndex = 6
        '
        'Spherey
        '
        Me.Spherey.Location = New System.Drawing.Point(50, 93)
        Me.Spherey.Margin = New System.Windows.Forms.Padding(2)
        Me.Spherey.Minimum = -10
        Me.Spherey.Name = "Spherey"
        Me.Spherey.Size = New System.Drawing.Size(179, 45)
        Me.Spherey.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.nTB)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.kdTB)
        Me.GroupBox2.Controls.Add(Me.kaTB)
        Me.GroupBox2.Controls.Add(Me.ksTB)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(393, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(473, 181)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coefficient and Intensity"
        '
        'nTB
        '
        Me.nTB.Location = New System.Drawing.Point(289, 25)
        Me.nTB.Maximum = 100
        Me.nTB.Name = "nTB"
        Me.nTB.Size = New System.Drawing.Size(138, 45)
        Me.nTB.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(254, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "n"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Specular"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Diffuse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ambient"
        '
        'kdTB
        '
        Me.kdTB.Location = New System.Drawing.Point(86, 77)
        Me.kdTB.Name = "kdTB"
        Me.kdTB.Size = New System.Drawing.Size(138, 45)
        Me.kdTB.TabIndex = 13
        '
        'kaTB
        '
        Me.kaTB.Location = New System.Drawing.Point(86, 25)
        Me.kaTB.Name = "kaTB"
        Me.kaTB.Size = New System.Drawing.Size(138, 45)
        Me.kaTB.TabIndex = 12
        '
        'ksTB
        '
        Me.ksTB.Location = New System.Drawing.Point(86, 129)
        Me.ksTB.Name = "ksTB"
        Me.ksTB.Size = New System.Drawing.Size(138, 45)
        Me.ksTB.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lightz)
        Me.GroupBox1.Controls.Add(Me.Lighty)
        Me.GroupBox1.Controls.Add(Me.Lightx)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(393, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 181)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Light Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Z"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "X"
        '
        'Lightz
        '
        Me.Lightz.Location = New System.Drawing.Point(38, 133)
        Me.Lightz.Margin = New System.Windows.Forms.Padding(2)
        Me.Lightz.Maximum = 300
        Me.Lightz.Minimum = -300
        Me.Lightz.Name = "Lightz"
        Me.Lightz.Size = New System.Drawing.Size(186, 45)
        Me.Lightz.TabIndex = 12
        '
        'Lighty
        '
        Me.Lighty.Location = New System.Drawing.Point(38, 83)
        Me.Lighty.Margin = New System.Windows.Forms.Padding(2)
        Me.Lighty.Maximum = 300
        Me.Lighty.Minimum = -300
        Me.Lighty.Name = "Lighty"
        Me.Lighty.Size = New System.Drawing.Size(186, 45)
        Me.Lighty.TabIndex = 11
        Me.Lighty.Value = 20
        '
        'Lightx
        '
        Me.Lightx.Location = New System.Drawing.Point(38, 33)
        Me.Lightx.Margin = New System.Windows.Forms.Padding(2)
        Me.Lightx.Maximum = 300
        Me.Lightx.Minimum = -300
        Me.Lightx.Name = "Lightx"
        Me.Lightx.Size = New System.Drawing.Size(186, 45)
        Me.Lightx.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(882, 384)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Ray Tracing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Spherez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spherex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spherey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kdTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kaTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ksTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Lightz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lighty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lightx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Spherex As TrackBar
    Friend WithEvents Spherey As TrackBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents kdTB As TrackBar
    Friend WithEvents kaTB As TrackBar
    Friend WithEvents ksTB As TrackBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lightz As TrackBar
    Friend WithEvents Lighty As TrackBar
    Friend WithEvents Lightx As TrackBar
    Friend WithEvents Spherez As TrackBar
    Friend WithEvents Label12 As Label
    Friend WithEvents nTB As TrackBar
    Friend WithEvents Label9 As Label
End Class
