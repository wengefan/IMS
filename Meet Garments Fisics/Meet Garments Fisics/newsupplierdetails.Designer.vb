﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newsupplierdetails
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ContactValid = New System.Windows.Forms.Label
        Me.pincodeValidator = New System.Windows.Forms.Label
        Me.addValidator = New System.Windows.Forms.Label
        Me.nameValidator = New System.Windows.Forms.Label
        Me.SuppCityddl = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SupID = New System.Windows.Forms.TextBox
        Me.instSupplier = New System.Windows.Forms.Button
        Me.SupCST_no = New System.Windows.Forms.TextBox
        Me.SupEmail = New System.Windows.Forms.TextBox
        Me.SupContact = New System.Windows.Forms.TextBox
        Me.SupPincode = New System.Windows.Forms.TextBox
        Me.SupAddress = New System.Windows.Forms.TextBox
        Me.SupName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ContactValid)
        Me.GroupBox1.Controls.Add(Me.pincodeValidator)
        Me.GroupBox1.Controls.Add(Me.addValidator)
        Me.GroupBox1.Controls.Add(Me.nameValidator)
        Me.GroupBox1.Controls.Add(Me.SuppCityddl)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.SupID)
        Me.GroupBox1.Controls.Add(Me.instSupplier)
        Me.GroupBox1.Controls.Add(Me.SupCST_no)
        Me.GroupBox1.Controls.Add(Me.SupEmail)
        Me.GroupBox1.Controls.Add(Me.SupContact)
        Me.GroupBox1.Controls.Add(Me.SupPincode)
        Me.GroupBox1.Controls.Add(Me.SupAddress)
        Me.GroupBox1.Controls.Add(Me.SupName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 349)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert New Supplier Details"
        '
        'ContactValid
        '
        Me.ContactValid.AutoSize = True
        Me.ContactValid.ForeColor = System.Drawing.Color.Red
        Me.ContactValid.Location = New System.Drawing.Point(437, 223)
        Me.ContactValid.Name = "ContactValid"
        Me.ContactValid.Size = New System.Drawing.Size(53, 14)
        Me.ContactValid.TabIndex = 70
        Me.ContactValid.Text = "Label13"
        Me.ContactValid.Visible = False
        '
        'pincodeValidator
        '
        Me.pincodeValidator.AutoSize = True
        Me.pincodeValidator.ForeColor = System.Drawing.Color.Red
        Me.pincodeValidator.Location = New System.Drawing.Point(437, 190)
        Me.pincodeValidator.Name = "pincodeValidator"
        Me.pincodeValidator.Size = New System.Drawing.Size(53, 14)
        Me.pincodeValidator.TabIndex = 69
        Me.pincodeValidator.Text = "Label12"
        Me.pincodeValidator.Visible = False
        '
        'addValidator
        '
        Me.addValidator.AutoSize = True
        Me.addValidator.ForeColor = System.Drawing.Color.Red
        Me.addValidator.Location = New System.Drawing.Point(436, 110)
        Me.addValidator.Name = "addValidator"
        Me.addValidator.Size = New System.Drawing.Size(53, 14)
        Me.addValidator.TabIndex = 68
        Me.addValidator.Text = "Label10"
        Me.addValidator.Visible = False
        '
        'nameValidator
        '
        Me.nameValidator.AutoSize = True
        Me.nameValidator.ForeColor = System.Drawing.Color.Red
        Me.nameValidator.Location = New System.Drawing.Point(437, 59)
        Me.nameValidator.Name = "nameValidator"
        Me.nameValidator.Size = New System.Drawing.Size(46, 14)
        Me.nameValidator.TabIndex = 67
        Me.nameValidator.Text = "Label8"
        Me.nameValidator.Visible = False
        '
        'SuppCityddl
        '
        Me.SuppCityddl.FormattingEnabled = True
        Me.SuppCityddl.Location = New System.Drawing.Point(191, 150)
        Me.SuppCityddl.Name = "SuppCityddl"
        Me.SuppCityddl.Size = New System.Drawing.Size(240, 22)
        Me.SuppCityddl.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(76, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Supplier Id:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SupID
        '
        Me.SupID.Enabled = False
        Me.SupID.Location = New System.Drawing.Point(191, 20)
        Me.SupID.Name = "SupID"
        Me.SupID.Size = New System.Drawing.Size(240, 21)
        Me.SupID.TabIndex = 65
        '
        'instSupplier
        '
        Me.instSupplier.Location = New System.Drawing.Point(211, 308)
        Me.instSupplier.Name = "instSupplier"
        Me.instSupplier.Size = New System.Drawing.Size(106, 30)
        Me.instSupplier.TabIndex = 57
        Me.instSupplier.Text = "Insert"
        Me.instSupplier.UseVisualStyleBackColor = True
        '
        'SupCST_no
        '
        Me.SupCST_no.Location = New System.Drawing.Point(191, 281)
        Me.SupCST_no.Name = "SupCST_no"
        Me.SupCST_no.Size = New System.Drawing.Size(240, 21)
        Me.SupCST_no.TabIndex = 56
        Me.SupCST_no.Text = "0"
        '
        'SupEmail
        '
        Me.SupEmail.Location = New System.Drawing.Point(191, 249)
        Me.SupEmail.Name = "SupEmail"
        Me.SupEmail.Size = New System.Drawing.Size(240, 21)
        Me.SupEmail.TabIndex = 55
        '
        'SupContact
        '
        Me.SupContact.Location = New System.Drawing.Point(191, 216)
        Me.SupContact.MaxLength = 10
        Me.SupContact.Name = "SupContact"
        Me.SupContact.Size = New System.Drawing.Size(240, 21)
        Me.SupContact.TabIndex = 54
        '
        'SupPincode
        '
        Me.SupPincode.Location = New System.Drawing.Point(191, 183)
        Me.SupPincode.Name = "SupPincode"
        Me.SupPincode.Size = New System.Drawing.Size(240, 21)
        Me.SupPincode.TabIndex = 53
        '
        'SupAddress
        '
        Me.SupAddress.Location = New System.Drawing.Point(191, 86)
        Me.SupAddress.Multiline = True
        Me.SupAddress.Name = "SupAddress"
        Me.SupAddress.Size = New System.Drawing.Size(240, 58)
        Me.SupAddress.TabIndex = 51
        '
        'SupName
        '
        Me.SupName.Location = New System.Drawing.Point(191, 53)
        Me.SupName.Name = "SupName"
        Me.SupName.Size = New System.Drawing.Size(240, 21)
        Me.SupName.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(76, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "CST No:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(76, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Email:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(76, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Contact No:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(76, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Pincode:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(76, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "City:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(76, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Address:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Supplier Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'newsupplierdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "newsupplierdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Supplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SupID As System.Windows.Forms.TextBox
    Friend WithEvents instSupplier As System.Windows.Forms.Button
    Friend WithEvents SupCST_no As System.Windows.Forms.TextBox
    Friend WithEvents SupEmail As System.Windows.Forms.TextBox
    Friend WithEvents SupContact As System.Windows.Forms.TextBox
    Friend WithEvents SupPincode As System.Windows.Forms.TextBox
    Friend WithEvents SupAddress As System.Windows.Forms.TextBox
    Friend WithEvents SupName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SuppCityddl As System.Windows.Forms.ComboBox
    Friend WithEvents ContactValid As System.Windows.Forms.Label
    Friend WithEvents pincodeValidator As System.Windows.Forms.Label
    Friend WithEvents addValidator As System.Windows.Forms.Label
    Friend WithEvents nameValidator As System.Windows.Forms.Label
End Class
