<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.tbsignup = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbclose = New System.Windows.Forms.Button()
        Me.tbmaximize = New System.Windows.Forms.Button()
        Me.tbminimize = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.tbclose)
        Me.Panel1.Controls.Add(Me.tbmaximize)
        Me.Panel1.Controls.Add(Me.tbminimize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 674)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(43, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1269, 593)
        Me.Panel2.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.txtusername)
        Me.Panel4.Controls.Add(Me.tbsignup)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.tblogin)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtpassword)
        Me.Panel4.Location = New System.Drawing.Point(324, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(660, 434)
        Me.Panel4.TabIndex = 16
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Silver
        Me.txtusername.Location = New System.Drawing.Point(234, 104)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(220, 30)
        Me.txtusername.TabIndex = 3
        Me.txtusername.Text = "Username"
        '
        'tbsignup
        '
        Me.tbsignup.BackColor = System.Drawing.Color.Tomato
        Me.tbsignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsignup.ForeColor = System.Drawing.Color.White
        Me.tbsignup.Location = New System.Drawing.Point(227, 300)
        Me.tbsignup.Name = "tbsignup"
        Me.tbsignup.Size = New System.Drawing.Size(240, 35)
        Me.tbsignup.TabIndex = 14
        Me.tbsignup.Text = "Sign up"
        Me.tbsignup.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Perpetua", 13.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(183, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "if you do not have any account, please sign in below"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 30.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(51, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 49)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome Back!"
        '
        'tblogin
        '
        Me.tblogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tblogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblogin.ForeColor = System.Drawing.Color.White
        Me.tblogin.Location = New System.Drawing.Point(227, 192)
        Me.tblogin.Name = "tblogin"
        Me.tblogin.Size = New System.Drawing.Size(240, 35)
        Me.tblogin.TabIndex = 10
        Me.tblogin.Text = "Log in"
        Me.tblogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(214, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "please enter your username and password"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Silver
        Me.txtpassword.Location = New System.Drawing.Point(234, 144)
        Me.txtpassword.Multiline = True
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(220, 30)
        Me.txtpassword.TabIndex = 6
        Me.txtpassword.Text = "Password"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(434, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(430, 93)
        Me.Panel3.TabIndex = 0
        '
        'tbclose
        '
        Me.tbclose.BackColor = System.Drawing.Color.Transparent
        Me.tbclose.BackgroundImage = CType(resources.GetObject("tbclose.BackgroundImage"), System.Drawing.Image)
        Me.tbclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tbclose.FlatAppearance.BorderSize = 0
        Me.tbclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbclose.Location = New System.Drawing.Point(1317, 4)
        Me.tbclose.Name = "tbclose"
        Me.tbclose.Size = New System.Drawing.Size(27, 29)
        Me.tbclose.TabIndex = 16
        Me.tbclose.UseVisualStyleBackColor = False
        '
        'tbmaximize
        '
        Me.tbmaximize.BackColor = System.Drawing.Color.Transparent
        Me.tbmaximize.BackgroundImage = CType(resources.GetObject("tbmaximize.BackgroundImage"), System.Drawing.Image)
        Me.tbmaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tbmaximize.FlatAppearance.BorderSize = 0
        Me.tbmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbmaximize.Location = New System.Drawing.Point(1284, 4)
        Me.tbmaximize.Name = "tbmaximize"
        Me.tbmaximize.Size = New System.Drawing.Size(29, 28)
        Me.tbmaximize.TabIndex = 12
        Me.tbmaximize.UseVisualStyleBackColor = False
        '
        'tbminimize
        '
        Me.tbminimize.BackColor = System.Drawing.Color.Transparent
        Me.tbminimize.BackgroundImage = CType(resources.GetObject("tbminimize.BackgroundImage"), System.Drawing.Image)
        Me.tbminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tbminimize.FlatAppearance.BorderSize = 0
        Me.tbminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbminimize.Location = New System.Drawing.Point(1252, 4)
        Me.tbminimize.Name = "tbminimize"
        Me.tbminimize.Size = New System.Drawing.Size(26, 29)
        Me.tbminimize.TabIndex = 13
        Me.tbminimize.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(295, 344)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1349, 674)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents tblogin As Button
    Friend WithEvents tbminimize As Button
    Friend WithEvents tbmaximize As Button
    Friend WithEvents tbsignup As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbclose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
