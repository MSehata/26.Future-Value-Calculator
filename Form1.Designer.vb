<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtPV = New TextBox()
        txtIR = New TextBox()
        txtN = New TextBox()
        txtFV = New TextBox()
        BtnCal = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(179, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 0
        Label1.Text = "Number Of Years"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(179, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 0
        Label2.Text = "Future Value"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(179, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 0
        Label3.Text = "Present Value"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(179, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 20)
        Label4.TabIndex = 0
        Label4.Text = "Intersert Rate (p/a)"
        ' 
        ' txtPV
        ' 
        txtPV.Location = New Point(384, 112)
        txtPV.Name = "txtPV"
        txtPV.Size = New Size(125, 27)
        txtPV.TabIndex = 1
        ' 
        ' txtIR
        ' 
        txtIR.Location = New Point(384, 158)
        txtIR.Name = "txtIR"
        txtIR.Size = New Size(125, 27)
        txtIR.TabIndex = 1
        ' 
        ' txtN
        ' 
        txtN.Location = New Point(384, 205)
        txtN.Name = "txtN"
        txtN.Size = New Size(125, 27)
        txtN.TabIndex = 1
        ' 
        ' txtFV
        ' 
        txtFV.Location = New Point(384, 247)
        txtFV.Name = "txtFV"
        txtFV.Size = New Size(125, 27)
        txtFV.TabIndex = 1
        ' 
        ' BtnCal
        ' 
        BtnCal.Location = New Point(336, 333)
        BtnCal.Name = "BtnCal"
        BtnCal.Size = New Size(94, 29)
        BtnCal.TabIndex = 2
        BtnCal.Text = "Calculate"
        BtnCal.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(336, 388)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(BtnCal)
        Controls.Add(txtFV)
        Controls.Add(txtN)
        Controls.Add(txtIR)
        Controls.Add(txtPV)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Future Value Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPV As TextBox
    Friend WithEvents txtIR As TextBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents txtFV As TextBox
    Friend WithEvents BtnCal As Button
    Friend WithEvents btnClose As Button
End Class
