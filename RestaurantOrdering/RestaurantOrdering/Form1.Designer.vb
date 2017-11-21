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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBread = New System.Windows.Forms.RadioButton()
        Me.radChicken = New System.Windows.Forms.RadioButton()
        Me.radCheeseBurger = New System.Windows.Forms.RadioButton()
        Me.radHamburger = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radChickenTenders = New System.Windows.Forms.RadioButton()
        Me.radOnionRings = New System.Windows.Forms.RadioButton()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBread)
        Me.GroupBox1.Controls.Add(Me.radChicken)
        Me.GroupBox1.Controls.Add(Me.radCheeseBurger)
        Me.GroupBox1.Controls.Add(Me.radHamburger)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal"
        '
        'radBread
        '
        Me.radBread.AutoSize = True
        Me.radBread.Location = New System.Drawing.Point(21, 89)
        Me.radBread.Name = "radBread"
        Me.radBread.Size = New System.Drawing.Size(53, 17)
        Me.radBread.TabIndex = 4
        Me.radBread.TabStop = True
        Me.radBread.Text = "Bread"
        Me.radBread.UseVisualStyleBackColor = True
        '
        'radChicken
        '
        Me.radChicken.AutoSize = True
        Me.radChicken.Location = New System.Drawing.Point(21, 66)
        Me.radChicken.Name = "radChicken"
        Me.radChicken.Size = New System.Drawing.Size(114, 17)
        Me.radChicken.TabIndex = 3
        Me.radChicken.TabStop = True
        Me.radChicken.Text = "Chicken Sandwich"
        Me.radChicken.UseVisualStyleBackColor = True
        '
        'radCheeseBurger
        '
        Me.radCheeseBurger.AutoSize = True
        Me.radCheeseBurger.Location = New System.Drawing.Point(21, 43)
        Me.radCheeseBurger.Name = "radCheeseBurger"
        Me.radCheeseBurger.Size = New System.Drawing.Size(95, 17)
        Me.radCheeseBurger.TabIndex = 2
        Me.radCheeseBurger.TabStop = True
        Me.radCheeseBurger.Text = "Cheese Burger"
        Me.radCheeseBurger.UseVisualStyleBackColor = True
        '
        'radHamburger
        '
        Me.radHamburger.AutoSize = True
        Me.radHamburger.Location = New System.Drawing.Point(21, 19)
        Me.radHamburger.Name = "radHamburger"
        Me.radHamburger.Size = New System.Drawing.Size(77, 17)
        Me.radHamburger.TabIndex = 1
        Me.radHamburger.TabStop = True
        Me.radHamburger.Text = "Hamburger"
        Me.radHamburger.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBacon)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(311, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Topping"
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(29, 90)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(57, 17)
        Me.chkBacon.TabIndex = 3
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(29, 67)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(29, 43)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(29, 19)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radChickenTenders)
        Me.GroupBox3.Controls.Add(Me.radOnionRings)
        Me.GroupBox3.Controls.Add(Me.radFries)
        Me.GroupBox3.Location = New System.Drawing.Point(244, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 122)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'radChickenTenders
        '
        Me.radChickenTenders.AutoSize = True
        Me.radChickenTenders.Location = New System.Drawing.Point(29, 76)
        Me.radChickenTenders.Name = "radChickenTenders"
        Me.radChickenTenders.Size = New System.Drawing.Size(106, 17)
        Me.radChickenTenders.TabIndex = 2
        Me.radChickenTenders.TabStop = True
        Me.radChickenTenders.Text = "Chicken Tenders"
        Me.radChickenTenders.UseVisualStyleBackColor = True
        '
        'radOnionRings
        '
        Me.radOnionRings.AutoSize = True
        Me.radOnionRings.Location = New System.Drawing.Point(29, 53)
        Me.radOnionRings.Name = "radOnionRings"
        Me.radOnionRings.Size = New System.Drawing.Size(83, 17)
        Me.radOnionRings.TabIndex = 1
        Me.radOnionRings.TabStop = True
        Me.radOnionRings.Text = "Onion Rings"
        Me.radOnionRings.UseVisualStyleBackColor = True
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(29, 30)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(47, 17)
        Me.radFries.TabIndex = 0
        Me.radFries.TabStop = True
        Me.radFries.Text = "Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(29, 236)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(209, 49)
        Me.lblResult.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(29, 324)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RestaurantOrdering.My.Resources.Resources.burger
        Me.PictureBox1.Location = New System.Drawing.Point(179, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(69, 289)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(111, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 363)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBread As System.Windows.Forms.RadioButton
    Friend WithEvents radChicken As System.Windows.Forms.RadioButton
    Friend WithEvents radCheeseBurger As System.Windows.Forms.RadioButton
    Friend WithEvents radHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBacon As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radChickenTenders As System.Windows.Forms.RadioButton
    Friend WithEvents radOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents radFries As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
