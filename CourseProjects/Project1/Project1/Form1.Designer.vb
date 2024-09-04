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
    lblVisited = New Label()
    txtVisited = New TextBox()
    txtDates = New TextBox()
    lblDates = New Label()
    txtLocation = New TextBox()
    lblLocation = New Label()
    txtME = New TextBox()
    lblME = New Label()
    txtAirfare = New TextBox()
    lblAirFare = New Label()
    txtLodging = New TextBox()
    lblLodging = New Label()
    txtTaxi = New TextBox()
    lblTaxi = New Label()
    btnPreview = New Button()
    btnReset = New Button()
    btnClose = New Button()
    txtOut = New TextBox()
    ColorDialog1 = New ColorDialog()
    SuspendLayout()
    ' 
    ' lblVisited
    ' 
    lblVisited.AutoSize = True
    lblVisited.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblVisited.Location = New Point(31, 29)
    lblVisited.Margin = New Padding(4, 0, 4, 0)
    lblVisited.Name = "lblVisited"
    lblVisited.Size = New Size(231, 32)
    lblVisited.TabIndex = 0
    lblVisited.Text = "&Visited                    :"
    ' 
    ' txtVisited
    ' 
    txtVisited.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtVisited.Location = New Point(293, 29)
    txtVisited.Margin = New Padding(4)
    txtVisited.Name = "txtVisited"
    txtVisited.Size = New Size(417, 39)
    txtVisited.TabIndex = 1
    ' 
    ' txtDates
    ' 
    txtDates.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtDates.Location = New Point(293, 80)
    txtDates.Margin = New Padding(4)
    txtDates.Name = "txtDates"
    txtDates.Size = New Size(417, 39)
    txtDates.TabIndex = 3
    ' 
    ' lblDates
    ' 
    lblDates.AutoSize = True
    lblDates.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblDates.Location = New Point(31, 80)
    lblDates.Margin = New Padding(4, 0, 4, 0)
    lblDates.Name = "lblDates"
    lblDates.Size = New Size(233, 32)
    lblDates.TabIndex = 2
    lblDates.Text = "&Dates                      :"
    ' 
    ' txtLocation
    ' 
    txtLocation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtLocation.Location = New Point(293, 139)
    txtLocation.Margin = New Padding(4)
    txtLocation.Name = "txtLocation"
    txtLocation.Size = New Size(417, 39)
    txtLocation.TabIndex = 5
    ' 
    ' lblLocation
    ' 
    lblLocation.AutoSize = True
    lblLocation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblLocation.Location = New Point(31, 139)
    lblLocation.Margin = New Padding(4, 0, 4, 0)
    lblLocation.Name = "lblLocation"
    lblLocation.Size = New Size(235, 32)
    lblLocation.TabIndex = 4
    lblLocation.Text = "&Location                  :"
    ' 
    ' txtME
    ' 
    txtME.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtME.Location = New Point(293, 219)
    txtME.Margin = New Padding(4)
    txtME.Name = "txtME"
    txtME.Size = New Size(417, 39)
    txtME.TabIndex = 7
    ' 
    ' lblME
    ' 
    lblME.AutoSize = True
    lblME.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblME.Location = New Point(31, 187)
    lblME.Margin = New Padding(4, 0, 4, 0)
    lblME.Name = "lblME"
    lblME.Size = New Size(233, 64)
    lblME.TabIndex = 6
    lblME.Text = "&Meals and" & vbCrLf & "Entertainment         :" & vbCrLf
    ' 
    ' txtAirfare
    ' 
    txtAirfare.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtAirfare.Location = New Point(293, 281)
    txtAirfare.Margin = New Padding(4)
    txtAirfare.Name = "txtAirfare"
    txtAirfare.Size = New Size(417, 39)
    txtAirfare.TabIndex = 9
    ' 
    ' lblAirFare
    ' 
    lblAirFare.AutoSize = True
    lblAirFare.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblAirFare.Location = New Point(31, 281)
    lblAirFare.Margin = New Padding(4, 0, 4, 0)
    lblAirFare.Name = "lblAirFare"
    lblAirFare.Size = New Size(235, 32)
    lblAirFare.TabIndex = 8
    lblAirFare.Text = "&Air Fares                  :"
    ' 
    ' txtLodging
    ' 
    txtLodging.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtLodging.Location = New Point(293, 344)
    txtLodging.Margin = New Padding(4)
    txtLodging.Name = "txtLodging"
    txtLodging.Size = New Size(417, 39)
    txtLodging.TabIndex = 11
    ' 
    ' lblLodging
    ' 
    lblLodging.AutoSize = True
    lblLodging.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblLodging.Location = New Point(31, 344)
    lblLodging.Margin = New Padding(4, 0, 4, 0)
    lblLodging.Name = "lblLodging"
    lblLodging.Size = New Size(232, 32)
    lblLodging.TabIndex = 10
    lblLodging.Text = "L&odging                  :"
    ' 
    ' txtTaxi
    ' 
    txtTaxi.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtTaxi.Location = New Point(293, 413)
    txtTaxi.Margin = New Padding(4)
    txtTaxi.Name = "txtTaxi"
    txtTaxi.Size = New Size(417, 39)
    txtTaxi.TabIndex = 13
    ' 
    ' lblTaxi
    ' 
    lblTaxi.AutoSize = True
    lblTaxi.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    lblTaxi.Location = New Point(31, 413)
    lblTaxi.Margin = New Padding(4, 0, 4, 0)
    lblTaxi.Name = "lblTaxi"
    lblTaxi.Size = New Size(231, 32)
    lblTaxi.TabIndex = 12
    lblTaxi.Text = "&Taxi Fares                :"
    ' 
    ' btnPreview
    ' 
    btnPreview.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    btnPreview.Location = New Point(29, 478)
    btnPreview.Margin = New Padding(4)
    btnPreview.Name = "btnPreview"
    btnPreview.Size = New Size(681, 49)
    btnPreview.TabIndex = 14
    btnPreview.Text = "&Preview Travel Expenses"
    btnPreview.UseVisualStyleBackColor = True
    ' 
    ' btnReset
    ' 
    btnReset.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    btnReset.Location = New Point(29, 553)
    btnReset.Margin = New Padding(4)
    btnReset.Name = "btnReset"
    btnReset.Size = New Size(681, 49)
    btnReset.TabIndex = 15
    btnReset.Text = "&Restart"
    btnReset.UseVisualStyleBackColor = True
    ' 
    ' btnClose
    ' 
    btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    btnClose.Location = New Point(752, 553)
    btnClose.Margin = New Padding(4)
    btnClose.Name = "btnClose"
    btnClose.Size = New Size(627, 46)
    btnClose.TabIndex = 16
    btnClose.Text = "&Close"
    btnClose.UseVisualStyleBackColor = True
    ' 
    ' txtOut
    ' 
    txtOut.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    txtOut.Location = New Point(752, 29)
    txtOut.Margin = New Padding(4)
    txtOut.Multiline = True
    txtOut.Name = "txtOut"
    txtOut.ReadOnly = True
    txtOut.Size = New Size(627, 498)
    txtOut.TabIndex = 17
    ' 
    ' Form1
    ' 
    AutoScaleDimensions = New SizeF(13F, 32F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(1413, 634)
    Controls.Add(txtOut)
    Controls.Add(btnClose)
    Controls.Add(btnReset)
    Controls.Add(btnPreview)
    Controls.Add(txtTaxi)
    Controls.Add(lblTaxi)
    Controls.Add(txtLodging)
    Controls.Add(lblLodging)
    Controls.Add(txtAirfare)
    Controls.Add(lblAirFare)
    Controls.Add(txtME)
    Controls.Add(lblME)
    Controls.Add(txtLocation)
    Controls.Add(lblLocation)
    Controls.Add(txtDates)
    Controls.Add(lblDates)
    Controls.Add(txtVisited)
    Controls.Add(lblVisited)
    Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
    Margin = New Padding(4)
    Name = "Form1"
    Text = "Form1"
    ResumeLayout(False)
    PerformLayout()
  End Sub

  Friend WithEvents lblVisited As Label
  Friend WithEvents txtVisited As TextBox
  Friend WithEvents txtDates As TextBox
  Friend WithEvents lblDates As Label
  Friend WithEvents txtLocation As TextBox
  Friend WithEvents lblLocation As Label
  Friend WithEvents txtME As TextBox
  Friend WithEvents lblME As Label
  Friend WithEvents txtAirfare As TextBox
  Friend WithEvents lblAirFare As Label
  Friend WithEvents txtLodging As TextBox
  Friend WithEvents lblLodging As Label
  Friend WithEvents txtTaxi As TextBox
  Friend WithEvents lblTaxi As Label
  Friend WithEvents btnPreview As Button
  Friend WithEvents btnReset As Button
  Friend WithEvents btnClose As Button
  Friend WithEvents txtOut As TextBox
  Friend WithEvents ColorDialog1 As ColorDialog
End Class
