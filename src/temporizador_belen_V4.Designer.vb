<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class temporizador_belen
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
				Form_Terminate_renamed()
				fTerminateCalled = True
			End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents CmdStop2 As System.Windows.Forms.Button
    Public WithEvents CmdInicio2 As System.Windows.Forms.Button
    Public WithEvents SRT2 As System.Windows.Forms.TextBox
    Public WithEvents MRT2 As System.Windows.Forms.TextBox
    Public WithEvents HRT2 As System.Windows.Forms.TextBox
    Public WithEvents Text5 As System.Windows.Forms.TextBox
    Public WithEvents hc16txt As System.Windows.Forms.TextBox
    Public WithEvents H16ITXT As System.Windows.Forms.TextBox
    Public WithEvents M16ITXT As System.Windows.Forms.TextBox
    Public WithEvents S16ITXT As System.Windows.Forms.TextBox
    Public WithEvents H16FTXT As System.Windows.Forms.TextBox
    Public WithEvents M16FTXT As System.Windows.Forms.TextBox
    Public WithEvents S16FTXT As System.Windows.Forms.TextBox
    Public WithEvents Label78 As System.Windows.Forms.Label
    Public WithEvents Label77 As System.Windows.Forms.Label
    Public WithEvents Label76 As System.Windows.Forms.Label
    Public WithEvents Led16 As System.Windows.Forms.Label
    Public WithEvents Label71 As System.Windows.Forms.Label
    Public WithEvents Label70 As System.Windows.Forms.Label
    Public WithEvents Label69 As System.Windows.Forms.Label
    Public WithEvents Frame16 As System.Windows.Forms.GroupBox
    Public WithEvents H15ITXT As System.Windows.Forms.TextBox
    Public WithEvents M15ITXT As System.Windows.Forms.TextBox
    Public WithEvents S15ITXT As System.Windows.Forms.TextBox
    Public WithEvents H15FTXT As System.Windows.Forms.TextBox
    Public WithEvents M15FTXT As System.Windows.Forms.TextBox
    Public WithEvents S15FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led15 As System.Windows.Forms.Label
    Public WithEvents Label67 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents Frame15 As System.Windows.Forms.GroupBox
    Public WithEvents H14ITXT As System.Windows.Forms.TextBox
    Public WithEvents M14ITXT As System.Windows.Forms.TextBox
    Public WithEvents S14ITXT As System.Windows.Forms.TextBox
    Public WithEvents H14FTXT As System.Windows.Forms.TextBox
    Public WithEvents M14FTXT As System.Windows.Forms.TextBox
    Public WithEvents S14FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led14 As System.Windows.Forms.Label
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Label61 As System.Windows.Forms.Label
    Public WithEvents Frame14 As System.Windows.Forms.GroupBox
    Public WithEvents H13ITXT As System.Windows.Forms.TextBox
    Public WithEvents M13ITXT As System.Windows.Forms.TextBox
    Public WithEvents S13ITXT As System.Windows.Forms.TextBox
    Public WithEvents H13FTXT As System.Windows.Forms.TextBox
    Public WithEvents M13FTXT As System.Windows.Forms.TextBox
    Public WithEvents S13FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led13 As System.Windows.Forms.Label
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents Label58 As System.Windows.Forms.Label
    Public WithEvents Label57 As System.Windows.Forms.Label
    Public WithEvents Frame13 As System.Windows.Forms.GroupBox
    Public WithEvents H12ITXT As System.Windows.Forms.TextBox
    Public WithEvents M12ITXT As System.Windows.Forms.TextBox
    Public WithEvents S12ITXT As System.Windows.Forms.TextBox
    Public WithEvents H12FTXT As System.Windows.Forms.TextBox
    Public WithEvents M12FTXT As System.Windows.Forms.TextBox
    Public WithEvents S12FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led12 As System.Windows.Forms.Label
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents Label53 As System.Windows.Forms.Label
    Public WithEvents Frame12 As System.Windows.Forms.GroupBox
    Public WithEvents H11ITXT As System.Windows.Forms.TextBox
    Public WithEvents M11ITXT As System.Windows.Forms.TextBox
    Public WithEvents S11ITXT As System.Windows.Forms.TextBox
    Public WithEvents H11FTXT As System.Windows.Forms.TextBox
    Public WithEvents M11FTXT As System.Windows.Forms.TextBox
    Public WithEvents S11FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led11 As System.Windows.Forms.Label
    Public WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Frame11 As System.Windows.Forms.GroupBox
    Public WithEvents H10ITXT As System.Windows.Forms.TextBox
    Public WithEvents M10ITXT As System.Windows.Forms.TextBox
    Public WithEvents S10ITXT As System.Windows.Forms.TextBox
    Public WithEvents H10FTXT As System.Windows.Forms.TextBox
    Public WithEvents M10FTXT As System.Windows.Forms.TextBox
    Public WithEvents S10FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led10 As System.Windows.Forms.Label
    Public WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents Frame10 As System.Windows.Forms.GroupBox
    Public WithEvents H9ITXT As System.Windows.Forms.TextBox
    Public WithEvents M9ITXT As System.Windows.Forms.TextBox
    Public WithEvents S9ITXT As System.Windows.Forms.TextBox
    Public WithEvents H9FTXT As System.Windows.Forms.TextBox
    Public WithEvents M9FTXT As System.Windows.Forms.TextBox
    Public WithEvents S9FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led9 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents CmdStop As System.Windows.Forms.Button
    Public WithEvents SRT1 As System.Windows.Forms.TextBox
    Public WithEvents MRT1 As System.Windows.Forms.TextBox
    Public WithEvents HRT1 As System.Windows.Forms.TextBox
    Public WithEvents H8ITXT As System.Windows.Forms.TextBox
    Public WithEvents M8ITXT As System.Windows.Forms.TextBox
    Public WithEvents S8ITXT As System.Windows.Forms.TextBox
    Public WithEvents H8FTXT As System.Windows.Forms.TextBox
    Public WithEvents M8FTXT As System.Windows.Forms.TextBox
    Public WithEvents S8FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led8 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents H7ITXT As System.Windows.Forms.TextBox
    Public WithEvents M7ITXT As System.Windows.Forms.TextBox
    Public WithEvents S7ITXT As System.Windows.Forms.TextBox
    Public WithEvents H7FTXT As System.Windows.Forms.TextBox
    Public WithEvents M7FTXT As System.Windows.Forms.TextBox
    Public WithEvents S7FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led7 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents S6FTXT As System.Windows.Forms.TextBox
    Public WithEvents M6FTXT As System.Windows.Forms.TextBox
    Public WithEvents H6FTXT As System.Windows.Forms.TextBox
    Public WithEvents S6ITXT As System.Windows.Forms.TextBox
    Public WithEvents M6ITXT As System.Windows.Forms.TextBox
    Public WithEvents H6ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Led6 As System.Windows.Forms.Label
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents S5FTXT As System.Windows.Forms.TextBox
    Public WithEvents M5FTXT As System.Windows.Forms.TextBox
    Public WithEvents H5FTXT As System.Windows.Forms.TextBox
    Public WithEvents S5ITXT As System.Windows.Forms.TextBox
    Public WithEvents M5ITXT As System.Windows.Forms.TextBox
    Public WithEvents H5ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Led5 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents S4FTXT As System.Windows.Forms.TextBox
    Public WithEvents M4FTXT As System.Windows.Forms.TextBox
    Public WithEvents H4FTXT As System.Windows.Forms.TextBox
    Public WithEvents S4ITXT As System.Windows.Forms.TextBox
    Public WithEvents M4ITXT As System.Windows.Forms.TextBox
    Public WithEvents H4ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Led4 As System.Windows.Forms.Label
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents S3FTXT As System.Windows.Forms.TextBox
    Public WithEvents M3FTXT As System.Windows.Forms.TextBox
    Public WithEvents H3FTXT As System.Windows.Forms.TextBox
    Public WithEvents S3ITXT As System.Windows.Forms.TextBox
    Public WithEvents M3ITXT As System.Windows.Forms.TextBox
    Public WithEvents H3ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Led3 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents H2ITXT As System.Windows.Forms.TextBox
    Public WithEvents M2ITXT As System.Windows.Forms.TextBox
    Public WithEvents S2ITXT As System.Windows.Forms.TextBox
    Public WithEvents H2FTXT As System.Windows.Forms.TextBox
    Public WithEvents M2FTXT As System.Windows.Forms.TextBox
    Public WithEvents S2FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led2 As System.Windows.Forms.Label
    Public WithEvents _Label9_0 As System.Windows.Forms.Label
    Public WithEvents _Label8_0 As System.Windows.Forms.Label
    Public WithEvents _Label7_0 As System.Windows.Forms.Label
    Public WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
    Public WithEvents HActualTxt As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents CmdInicio As System.Windows.Forms.Button
    Public WithEvents HCtxt As System.Windows.Forms.TextBox
    Public WithEvents S1FTXT As System.Windows.Forms.TextBox
    Public WithEvents M1FTXT As System.Windows.Forms.TextBox
    Public WithEvents H1FTXT As System.Windows.Forms.TextBox
    Public WithEvents S1ITXT As System.Windows.Forms.TextBox
    Public WithEvents M1ITXT As System.Windows.Forms.TextBox
    Public WithEvents H1ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Led1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents WindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Public WithEvents Label74 As System.Windows.Forms.Label
    Public WithEvents Label73 As System.Windows.Forms.Label
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Public WithEvents Label7 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label8 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label9 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temporizador_belen))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame16 = New System.Windows.Forms.GroupBox
        Me.CmdStop2 = New System.Windows.Forms.Button
        Me.CmdInicio2 = New System.Windows.Forms.Button
        Me.SRT2 = New System.Windows.Forms.TextBox
        Me.MRT2 = New System.Windows.Forms.TextBox
        Me.HRT2 = New System.Windows.Forms.TextBox
        Me.Text5 = New System.Windows.Forms.TextBox
        Me.hc16txt = New System.Windows.Forms.TextBox
        Me.H16ITXT = New System.Windows.Forms.TextBox
        Me.M16ITXT = New System.Windows.Forms.TextBox
        Me.S16ITXT = New System.Windows.Forms.TextBox
        Me.H16FTXT = New System.Windows.Forms.TextBox
        Me.M16FTXT = New System.Windows.Forms.TextBox
        Me.S16FTXT = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.Led16 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Frame15 = New System.Windows.Forms.GroupBox
        Me.H15ITXT = New System.Windows.Forms.TextBox
        Me.M15ITXT = New System.Windows.Forms.TextBox
        Me.S15ITXT = New System.Windows.Forms.TextBox
        Me.H15FTXT = New System.Windows.Forms.TextBox
        Me.M15FTXT = New System.Windows.Forms.TextBox
        Me.S15FTXT = New System.Windows.Forms.TextBox
        Me.Led15 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Frame14 = New System.Windows.Forms.GroupBox
        Me.H14ITXT = New System.Windows.Forms.TextBox
        Me.M14ITXT = New System.Windows.Forms.TextBox
        Me.S14ITXT = New System.Windows.Forms.TextBox
        Me.H14FTXT = New System.Windows.Forms.TextBox
        Me.M14FTXT = New System.Windows.Forms.TextBox
        Me.S14FTXT = New System.Windows.Forms.TextBox
        Me.Led14 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Frame13 = New System.Windows.Forms.GroupBox
        Me.H13ITXT = New System.Windows.Forms.TextBox
        Me.M13ITXT = New System.Windows.Forms.TextBox
        Me.S13ITXT = New System.Windows.Forms.TextBox
        Me.H13FTXT = New System.Windows.Forms.TextBox
        Me.M13FTXT = New System.Windows.Forms.TextBox
        Me.S13FTXT = New System.Windows.Forms.TextBox
        Me.Led13 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Frame12 = New System.Windows.Forms.GroupBox
        Me.H12ITXT = New System.Windows.Forms.TextBox
        Me.M12ITXT = New System.Windows.Forms.TextBox
        Me.S12ITXT = New System.Windows.Forms.TextBox
        Me.H12FTXT = New System.Windows.Forms.TextBox
        Me.M12FTXT = New System.Windows.Forms.TextBox
        Me.S12FTXT = New System.Windows.Forms.TextBox
        Me.Led12 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Frame11 = New System.Windows.Forms.GroupBox
        Me.H11ITXT = New System.Windows.Forms.TextBox
        Me.M11ITXT = New System.Windows.Forms.TextBox
        Me.S11ITXT = New System.Windows.Forms.TextBox
        Me.H11FTXT = New System.Windows.Forms.TextBox
        Me.M11FTXT = New System.Windows.Forms.TextBox
        Me.S11FTXT = New System.Windows.Forms.TextBox
        Me.Led11 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Frame10 = New System.Windows.Forms.GroupBox
        Me.H10ITXT = New System.Windows.Forms.TextBox
        Me.M10ITXT = New System.Windows.Forms.TextBox
        Me.S10ITXT = New System.Windows.Forms.TextBox
        Me.H10FTXT = New System.Windows.Forms.TextBox
        Me.M10FTXT = New System.Windows.Forms.TextBox
        Me.S10FTXT = New System.Windows.Forms.TextBox
        Me.Led10 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Frame9 = New System.Windows.Forms.GroupBox
        Me.H9ITXT = New System.Windows.Forms.TextBox
        Me.M9ITXT = New System.Windows.Forms.TextBox
        Me.S9ITXT = New System.Windows.Forms.TextBox
        Me.H9FTXT = New System.Windows.Forms.TextBox
        Me.M9FTXT = New System.Windows.Forms.TextBox
        Me.S9FTXT = New System.Windows.Forms.TextBox
        Me.Led9 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.CmdStop = New System.Windows.Forms.Button
        Me.SRT1 = New System.Windows.Forms.TextBox
        Me.MRT1 = New System.Windows.Forms.TextBox
        Me.HRT1 = New System.Windows.Forms.TextBox
        Me.Frame8 = New System.Windows.Forms.GroupBox
        Me.H8ITXT = New System.Windows.Forms.TextBox
        Me.M8ITXT = New System.Windows.Forms.TextBox
        Me.S8ITXT = New System.Windows.Forms.TextBox
        Me.H8FTXT = New System.Windows.Forms.TextBox
        Me.M8FTXT = New System.Windows.Forms.TextBox
        Me.S8FTXT = New System.Windows.Forms.TextBox
        Me.Led8 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Frame7 = New System.Windows.Forms.GroupBox
        Me.H7ITXT = New System.Windows.Forms.TextBox
        Me.M7ITXT = New System.Windows.Forms.TextBox
        Me.S7ITXT = New System.Windows.Forms.TextBox
        Me.H7FTXT = New System.Windows.Forms.TextBox
        Me.M7FTXT = New System.Windows.Forms.TextBox
        Me.S7FTXT = New System.Windows.Forms.TextBox
        Me.Led7 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Frame6 = New System.Windows.Forms.GroupBox
        Me.S6FTXT = New System.Windows.Forms.TextBox
        Me.M6FTXT = New System.Windows.Forms.TextBox
        Me.H6FTXT = New System.Windows.Forms.TextBox
        Me.S6ITXT = New System.Windows.Forms.TextBox
        Me.M6ITXT = New System.Windows.Forms.TextBox
        Me.H6ITXT = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Led6 = New System.Windows.Forms.Label
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.S5FTXT = New System.Windows.Forms.TextBox
        Me.M5FTXT = New System.Windows.Forms.TextBox
        Me.H5FTXT = New System.Windows.Forms.TextBox
        Me.S5ITXT = New System.Windows.Forms.TextBox
        Me.M5ITXT = New System.Windows.Forms.TextBox
        Me.H5ITXT = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Led5 = New System.Windows.Forms.Label
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.S4FTXT = New System.Windows.Forms.TextBox
        Me.M4FTXT = New System.Windows.Forms.TextBox
        Me.H4FTXT = New System.Windows.Forms.TextBox
        Me.S4ITXT = New System.Windows.Forms.TextBox
        Me.M4ITXT = New System.Windows.Forms.TextBox
        Me.H4ITXT = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Led4 = New System.Windows.Forms.Label
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.S3FTXT = New System.Windows.Forms.TextBox
        Me.M3FTXT = New System.Windows.Forms.TextBox
        Me.H3FTXT = New System.Windows.Forms.TextBox
        Me.S3ITXT = New System.Windows.Forms.TextBox
        Me.M3ITXT = New System.Windows.Forms.TextBox
        Me.H3ITXT = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Led3 = New System.Windows.Forms.Label
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me.H2ITXT = New System.Windows.Forms.TextBox
        Me.M2ITXT = New System.Windows.Forms.TextBox
        Me.S2ITXT = New System.Windows.Forms.TextBox
        Me.H2FTXT = New System.Windows.Forms.TextBox
        Me.M2FTXT = New System.Windows.Forms.TextBox
        Me.S2FTXT = New System.Windows.Forms.TextBox
        Me.Led2 = New System.Windows.Forms.Label
        Me._Label9_0 = New System.Windows.Forms.Label
        Me._Label8_0 = New System.Windows.Forms.Label
        Me._Label7_0 = New System.Windows.Forms.Label
        Me.HActualTxt = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CmdInicio = New System.Windows.Forms.Button
        Me.HCtxt = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.S1FTXT = New System.Windows.Forms.TextBox
        Me.M1FTXT = New System.Windows.Forms.TextBox
        Me.H1FTXT = New System.Windows.Forms.TextBox
        Me.S1ITXT = New System.Windows.Forms.TextBox
        Me.M1ITXT = New System.Windows.Forms.TextBox
        Me.H1ITXT = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Led1 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.WindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame2 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label7 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label8 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label9 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Frame16.SuspendLayout()
        Me.Frame15.SuspendLayout()
        Me.Frame14.SuspendLayout()
        Me.Frame13.SuspendLayout()
        Me.Frame12.SuspendLayout()
        Me.Frame11.SuspendLayout()
        Me.Frame10.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me._Frame2_0.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Frame16
        '
        Me.Frame16.BackColor = System.Drawing.Color.Transparent
        Me.Frame16.Controls.Add(Me.CmdStop2)
        Me.Frame16.Controls.Add(Me.CmdInicio2)
        Me.Frame16.Controls.Add(Me.SRT2)
        Me.Frame16.Controls.Add(Me.MRT2)
        Me.Frame16.Controls.Add(Me.HRT2)
        Me.Frame16.Controls.Add(Me.Text5)
        Me.Frame16.Controls.Add(Me.hc16txt)
        Me.Frame16.Controls.Add(Me.H16ITXT)
        Me.Frame16.Controls.Add(Me.M16ITXT)
        Me.Frame16.Controls.Add(Me.S16ITXT)
        Me.Frame16.Controls.Add(Me.H16FTXT)
        Me.Frame16.Controls.Add(Me.M16FTXT)
        Me.Frame16.Controls.Add(Me.S16FTXT)
        Me.Frame16.Controls.Add(Me.Label78)
        Me.Frame16.Controls.Add(Me.Label77)
        Me.Frame16.Controls.Add(Me.Label76)
        Me.Frame16.Controls.Add(Me.Led16)
        Me.Frame16.Controls.Add(Me.Label71)
        Me.Frame16.Controls.Add(Me.Label70)
        Me.Frame16.Controls.Add(Me.Label69)
        Me.Frame16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame16.Location = New System.Drawing.Point(810, 355)
        Me.Frame16.Name = "Frame16"
        Me.Frame16.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame16.Size = New System.Drawing.Size(223, 201)
        Me.Frame16.TabIndex = 180
        Me.Frame16.TabStop = False
        Me.Frame16.Text = "OUT 16          "
        '
        'CmdStop2
        '
        Me.CmdStop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdStop2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStop2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStop2.Location = New System.Drawing.Point(137, 56)
        Me.CmdStop2.Name = "CmdStop2"
        Me.CmdStop2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStop2.Size = New System.Drawing.Size(65, 25)
        Me.CmdStop2.TabIndex = 204
        Me.CmdStop2.Text = "Parar"
        Me.CmdStop2.UseVisualStyleBackColor = False
        '
        'CmdInicio2
        '
        Me.CmdInicio2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInicio2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdInicio2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdInicio2.Location = New System.Drawing.Point(137, 24)
        Me.CmdInicio2.Name = "CmdInicio2"
        Me.CmdInicio2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdInicio2.Size = New System.Drawing.Size(65, 25)
        Me.CmdInicio2.TabIndex = 203
        Me.CmdInicio2.Text = "Inicio"
        Me.CmdInicio2.UseVisualStyleBackColor = False
        '
        'SRT2
        '
        Me.SRT2.AcceptsReturn = True
        Me.SRT2.BackColor = System.Drawing.SystemColors.Window
        Me.SRT2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SRT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SRT2.Location = New System.Drawing.Point(178, 104)
        Me.SRT2.MaxLength = 0
        Me.SRT2.Name = "SRT2"
        Me.SRT2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SRT2.Size = New System.Drawing.Size(25, 20)
        Me.SRT2.TabIndex = 202
        Me.SRT2.Text = "0"
        '
        'MRT2
        '
        Me.MRT2.AcceptsReturn = True
        Me.MRT2.BackColor = System.Drawing.SystemColors.Window
        Me.MRT2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MRT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MRT2.Location = New System.Drawing.Point(154, 104)
        Me.MRT2.MaxLength = 0
        Me.MRT2.Name = "MRT2"
        Me.MRT2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MRT2.Size = New System.Drawing.Size(25, 20)
        Me.MRT2.TabIndex = 201
        Me.MRT2.Text = "0"
        '
        'HRT2
        '
        Me.HRT2.AcceptsReturn = True
        Me.HRT2.BackColor = System.Drawing.SystemColors.Window
        Me.HRT2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HRT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HRT2.Location = New System.Drawing.Point(130, 104)
        Me.HRT2.MaxLength = 0
        Me.HRT2.Name = "HRT2"
        Me.HRT2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HRT2.Size = New System.Drawing.Size(25, 20)
        Me.HRT2.TabIndex = 200
        Me.HRT2.Text = "0"
        '
        'Text5
        '
        Me.Text5.AcceptsReturn = True
        Me.Text5.BackColor = System.Drawing.SystemColors.Window
        Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text5.Location = New System.Drawing.Point(130, 152)
        Me.Text5.MaxLength = 0
        Me.Text5.Name = "Text5"
        Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text5.Size = New System.Drawing.Size(73, 20)
        Me.Text5.TabIndex = 199
        Me.Text5.Text = "0"
        '
        'hc16txt
        '
        Me.hc16txt.AcceptsReturn = True
        Me.hc16txt.BackColor = System.Drawing.SystemColors.Window
        Me.hc16txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hc16txt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.hc16txt.Location = New System.Drawing.Point(130, 128)
        Me.hc16txt.MaxLength = 0
        Me.hc16txt.Name = "hc16txt"
        Me.hc16txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hc16txt.Size = New System.Drawing.Size(73, 20)
        Me.hc16txt.TabIndex = 198
        Me.hc16txt.Text = "0"
        '
        'H16ITXT
        '
        Me.H16ITXT.AcceptsReturn = True
        Me.H16ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H16ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H16ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H16ITXT.Location = New System.Drawing.Point(28, 34)
        Me.H16ITXT.MaxLength = 0
        Me.H16ITXT.Name = "H16ITXT"
        Me.H16ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H16ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H16ITXT.TabIndex = 186
        Me.H16ITXT.Text = "0"
        '
        'M16ITXT
        '
        Me.M16ITXT.AcceptsReturn = True
        Me.M16ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M16ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M16ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M16ITXT.Location = New System.Drawing.Point(52, 34)
        Me.M16ITXT.MaxLength = 0
        Me.M16ITXT.Name = "M16ITXT"
        Me.M16ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M16ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M16ITXT.TabIndex = 185
        Me.M16ITXT.Text = "0"
        '
        'S16ITXT
        '
        Me.S16ITXT.AcceptsReturn = True
        Me.S16ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S16ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S16ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S16ITXT.Location = New System.Drawing.Point(76, 34)
        Me.S16ITXT.MaxLength = 0
        Me.S16ITXT.Name = "S16ITXT"
        Me.S16ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S16ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S16ITXT.TabIndex = 184
        Me.S16ITXT.Text = "0"
        '
        'H16FTXT
        '
        Me.H16FTXT.AcceptsReturn = True
        Me.H16FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H16FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H16FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H16FTXT.Location = New System.Drawing.Point(28, 58)
        Me.H16FTXT.MaxLength = 0
        Me.H16FTXT.Name = "H16FTXT"
        Me.H16FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H16FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H16FTXT.TabIndex = 183
        Me.H16FTXT.Text = "0"
        '
        'M16FTXT
        '
        Me.M16FTXT.AcceptsReturn = True
        Me.M16FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M16FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M16FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M16FTXT.Location = New System.Drawing.Point(52, 58)
        Me.M16FTXT.MaxLength = 0
        Me.M16FTXT.Name = "M16FTXT"
        Me.M16FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M16FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M16FTXT.TabIndex = 182
        Me.M16FTXT.Text = "0"
        '
        'S16FTXT
        '
        Me.S16FTXT.AcceptsReturn = True
        Me.S16FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S16FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S16FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S16FTXT.Location = New System.Drawing.Point(76, 58)
        Me.S16FTXT.MaxLength = 0
        Me.S16FTXT.Name = "S16FTXT"
        Me.S16FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S16FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S16FTXT.TabIndex = 181
        Me.S16FTXT.Text = "0"
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label78.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label78.Location = New System.Drawing.Point(8, 153)
        Me.Label78.Name = "Label78"
        Me.Label78.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label78.Size = New System.Drawing.Size(125, 17)
        Me.Label78.TabIndex = 197
        Me.Label78.Text = "Tiempo transcurrido:"
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label77.Location = New System.Drawing.Point(8, 129)
        Me.Label77.Name = "Label77"
        Me.Label77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label77.Size = New System.Drawing.Size(97, 17)
        Me.Label77.TabIndex = 196
        Me.Label77.Text = "Hora de inicio:"
        '
        'Label76
        '
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label76.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label76.Location = New System.Drawing.Point(8, 105)
        Me.Label76.Name = "Label76"
        Me.Label76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label76.Size = New System.Drawing.Size(100, 17)
        Me.Label76.TabIndex = 195
        Me.Label76.Text = "Repetir cada:"
        '
        'Led16
        '
        Me.Led16.BackColor = System.Drawing.Color.Red
        Me.Led16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led16.Location = New System.Drawing.Point(67, 2)
        Me.Led16.Name = "Led16"
        Me.Led16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led16.Size = New System.Drawing.Size(17, 9)
        Me.Led16.TabIndex = 190
        Me.Led16.Visible = False
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label71.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label71.Location = New System.Drawing.Point(28, 18)
        Me.Label71.Name = "Label71"
        Me.Label71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label71.Size = New System.Drawing.Size(17, 17)
        Me.Label71.TabIndex = 189
        Me.Label71.Text = "h:"
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label70.Location = New System.Drawing.Point(52, 18)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(17, 17)
        Me.Label70.TabIndex = 188
        Me.Label70.Text = "m:"
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label69.Location = New System.Drawing.Point(76, 18)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(25, 17)
        Me.Label69.TabIndex = 187
        Me.Label69.Text = "s:"
        '
        'Frame15
        '
        Me.Frame15.BackColor = System.Drawing.Color.Transparent
        Me.Frame15.Controls.Add(Me.H15ITXT)
        Me.Frame15.Controls.Add(Me.M15ITXT)
        Me.Frame15.Controls.Add(Me.S15ITXT)
        Me.Frame15.Controls.Add(Me.H15FTXT)
        Me.Frame15.Controls.Add(Me.M15FTXT)
        Me.Frame15.Controls.Add(Me.S15FTXT)
        Me.Frame15.Controls.Add(Me.Led15)
        Me.Frame15.Controls.Add(Me.Label67)
        Me.Frame15.Controls.Add(Me.Label66)
        Me.Frame15.Controls.Add(Me.Label65)
        Me.Frame15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame15.Location = New System.Drawing.Point(703, 393)
        Me.Frame15.Name = "Frame15"
        Me.Frame15.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame15.Size = New System.Drawing.Size(89, 89)
        Me.Frame15.TabIndex = 169
        Me.Frame15.TabStop = False
        Me.Frame15.Text = "OUT 15          "
        '
        'H15ITXT
        '
        Me.H15ITXT.AcceptsReturn = True
        Me.H15ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H15ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H15ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H15ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H15ITXT.MaxLength = 0
        Me.H15ITXT.Name = "H15ITXT"
        Me.H15ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H15ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H15ITXT.TabIndex = 175
        Me.H15ITXT.Text = "0"
        '
        'M15ITXT
        '
        Me.M15ITXT.AcceptsReturn = True
        Me.M15ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M15ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M15ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M15ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M15ITXT.MaxLength = 0
        Me.M15ITXT.Name = "M15ITXT"
        Me.M15ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M15ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M15ITXT.TabIndex = 174
        Me.M15ITXT.Text = "0"
        '
        'S15ITXT
        '
        Me.S15ITXT.AcceptsReturn = True
        Me.S15ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S15ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S15ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S15ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S15ITXT.MaxLength = 0
        Me.S15ITXT.Name = "S15ITXT"
        Me.S15ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S15ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S15ITXT.TabIndex = 173
        Me.S15ITXT.Text = "0"
        '
        'H15FTXT
        '
        Me.H15FTXT.AcceptsReturn = True
        Me.H15FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H15FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H15FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H15FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H15FTXT.MaxLength = 0
        Me.H15FTXT.Name = "H15FTXT"
        Me.H15FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H15FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H15FTXT.TabIndex = 172
        Me.H15FTXT.Text = "0"
        '
        'M15FTXT
        '
        Me.M15FTXT.AcceptsReturn = True
        Me.M15FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M15FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M15FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M15FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M15FTXT.MaxLength = 0
        Me.M15FTXT.Name = "M15FTXT"
        Me.M15FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M15FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M15FTXT.TabIndex = 171
        Me.M15FTXT.Text = "0"
        '
        'S15FTXT
        '
        Me.S15FTXT.AcceptsReturn = True
        Me.S15FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S15FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S15FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S15FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S15FTXT.MaxLength = 0
        Me.S15FTXT.Name = "S15FTXT"
        Me.S15FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S15FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S15FTXT.TabIndex = 170
        Me.S15FTXT.Text = "0"
        '
        'Led15
        '
        Me.Led15.BackColor = System.Drawing.Color.Red
        Me.Led15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led15.Location = New System.Drawing.Point(57, 1)
        Me.Led15.Name = "Led15"
        Me.Led15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led15.Size = New System.Drawing.Size(17, 9)
        Me.Led15.TabIndex = 179
        Me.Led15.Visible = False
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(8, 16)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(17, 17)
        Me.Label67.TabIndex = 178
        Me.Label67.Text = "h:"
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(32, 16)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(17, 17)
        Me.Label66.TabIndex = 177
        Me.Label66.Text = "m:"
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(56, 16)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(25, 17)
        Me.Label65.TabIndex = 176
        Me.Label65.Text = "s:"
        '
        'Frame14
        '
        Me.Frame14.BackColor = System.Drawing.Color.Transparent
        Me.Frame14.Controls.Add(Me.H14ITXT)
        Me.Frame14.Controls.Add(Me.M14ITXT)
        Me.Frame14.Controls.Add(Me.S14ITXT)
        Me.Frame14.Controls.Add(Me.H14FTXT)
        Me.Frame14.Controls.Add(Me.M14FTXT)
        Me.Frame14.Controls.Add(Me.S14FTXT)
        Me.Frame14.Controls.Add(Me.Led14)
        Me.Frame14.Controls.Add(Me.Label63)
        Me.Frame14.Controls.Add(Me.Label62)
        Me.Frame14.Controls.Add(Me.Label61)
        Me.Frame14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame14.Location = New System.Drawing.Point(615, 393)
        Me.Frame14.Name = "Frame14"
        Me.Frame14.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame14.Size = New System.Drawing.Size(89, 89)
        Me.Frame14.TabIndex = 158
        Me.Frame14.TabStop = False
        Me.Frame14.Text = "OUT 14          "
        '
        'H14ITXT
        '
        Me.H14ITXT.AcceptsReturn = True
        Me.H14ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H14ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H14ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H14ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H14ITXT.MaxLength = 0
        Me.H14ITXT.Name = "H14ITXT"
        Me.H14ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H14ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H14ITXT.TabIndex = 164
        Me.H14ITXT.Text = "0"
        '
        'M14ITXT
        '
        Me.M14ITXT.AcceptsReturn = True
        Me.M14ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M14ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M14ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M14ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M14ITXT.MaxLength = 0
        Me.M14ITXT.Name = "M14ITXT"
        Me.M14ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M14ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M14ITXT.TabIndex = 163
        Me.M14ITXT.Text = "0"
        '
        'S14ITXT
        '
        Me.S14ITXT.AcceptsReturn = True
        Me.S14ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S14ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S14ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S14ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S14ITXT.MaxLength = 0
        Me.S14ITXT.Name = "S14ITXT"
        Me.S14ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S14ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S14ITXT.TabIndex = 162
        Me.S14ITXT.Text = "0"
        '
        'H14FTXT
        '
        Me.H14FTXT.AcceptsReturn = True
        Me.H14FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H14FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H14FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H14FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H14FTXT.MaxLength = 0
        Me.H14FTXT.Name = "H14FTXT"
        Me.H14FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H14FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H14FTXT.TabIndex = 161
        Me.H14FTXT.Text = "0"
        '
        'M14FTXT
        '
        Me.M14FTXT.AcceptsReturn = True
        Me.M14FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M14FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M14FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M14FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M14FTXT.MaxLength = 0
        Me.M14FTXT.Name = "M14FTXT"
        Me.M14FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M14FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M14FTXT.TabIndex = 160
        Me.M14FTXT.Text = "0"
        '
        'S14FTXT
        '
        Me.S14FTXT.AcceptsReturn = True
        Me.S14FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S14FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S14FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S14FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S14FTXT.MaxLength = 0
        Me.S14FTXT.Name = "S14FTXT"
        Me.S14FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S14FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S14FTXT.TabIndex = 159
        Me.S14FTXT.Text = "0"
        '
        'Led14
        '
        Me.Led14.BackColor = System.Drawing.Color.Red
        Me.Led14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led14.Location = New System.Drawing.Point(57, 1)
        Me.Led14.Name = "Led14"
        Me.Led14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led14.Size = New System.Drawing.Size(17, 9)
        Me.Led14.TabIndex = 168
        Me.Led14.Visible = False
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(8, 16)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(17, 17)
        Me.Label63.TabIndex = 167
        Me.Label63.Text = "h:"
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(32, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(17, 17)
        Me.Label62.TabIndex = 166
        Me.Label62.Text = "m:"
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(56, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(25, 17)
        Me.Label61.TabIndex = 165
        Me.Label61.Text = "s:"
        '
        'Frame13
        '
        Me.Frame13.BackColor = System.Drawing.Color.Transparent
        Me.Frame13.Controls.Add(Me.H13ITXT)
        Me.Frame13.Controls.Add(Me.M13ITXT)
        Me.Frame13.Controls.Add(Me.S13ITXT)
        Me.Frame13.Controls.Add(Me.H13FTXT)
        Me.Frame13.Controls.Add(Me.M13FTXT)
        Me.Frame13.Controls.Add(Me.S13FTXT)
        Me.Frame13.Controls.Add(Me.Led13)
        Me.Frame13.Controls.Add(Me.Label59)
        Me.Frame13.Controls.Add(Me.Label58)
        Me.Frame13.Controls.Add(Me.Label57)
        Me.Frame13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame13.Location = New System.Drawing.Point(527, 393)
        Me.Frame13.Name = "Frame13"
        Me.Frame13.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame13.Size = New System.Drawing.Size(89, 89)
        Me.Frame13.TabIndex = 147
        Me.Frame13.TabStop = False
        Me.Frame13.Text = "OUT 13          "
        '
        'H13ITXT
        '
        Me.H13ITXT.AcceptsReturn = True
        Me.H13ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H13ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H13ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H13ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H13ITXT.MaxLength = 0
        Me.H13ITXT.Name = "H13ITXT"
        Me.H13ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H13ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H13ITXT.TabIndex = 153
        Me.H13ITXT.Text = "0"
        '
        'M13ITXT
        '
        Me.M13ITXT.AcceptsReturn = True
        Me.M13ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M13ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M13ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M13ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M13ITXT.MaxLength = 0
        Me.M13ITXT.Name = "M13ITXT"
        Me.M13ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M13ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M13ITXT.TabIndex = 152
        Me.M13ITXT.Text = "0"
        '
        'S13ITXT
        '
        Me.S13ITXT.AcceptsReturn = True
        Me.S13ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S13ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S13ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S13ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S13ITXT.MaxLength = 0
        Me.S13ITXT.Name = "S13ITXT"
        Me.S13ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S13ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S13ITXT.TabIndex = 151
        Me.S13ITXT.Text = "0"
        '
        'H13FTXT
        '
        Me.H13FTXT.AcceptsReturn = True
        Me.H13FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H13FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H13FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H13FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H13FTXT.MaxLength = 0
        Me.H13FTXT.Name = "H13FTXT"
        Me.H13FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H13FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H13FTXT.TabIndex = 150
        Me.H13FTXT.Text = "0"
        '
        'M13FTXT
        '
        Me.M13FTXT.AcceptsReturn = True
        Me.M13FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M13FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M13FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M13FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M13FTXT.MaxLength = 0
        Me.M13FTXT.Name = "M13FTXT"
        Me.M13FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M13FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M13FTXT.TabIndex = 149
        Me.M13FTXT.Text = "0"
        '
        'S13FTXT
        '
        Me.S13FTXT.AcceptsReturn = True
        Me.S13FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S13FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S13FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S13FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S13FTXT.MaxLength = 0
        Me.S13FTXT.Name = "S13FTXT"
        Me.S13FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S13FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S13FTXT.TabIndex = 148
        Me.S13FTXT.Text = "0"
        '
        'Led13
        '
        Me.Led13.BackColor = System.Drawing.Color.Red
        Me.Led13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led13.Location = New System.Drawing.Point(57, 1)
        Me.Led13.Name = "Led13"
        Me.Led13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led13.Size = New System.Drawing.Size(17, 9)
        Me.Led13.TabIndex = 157
        Me.Led13.Visible = False
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(8, 16)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(17, 17)
        Me.Label59.TabIndex = 156
        Me.Label59.Text = "h:"
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(32, 16)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(17, 17)
        Me.Label58.TabIndex = 155
        Me.Label58.Text = "m:"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(56, 16)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(25, 17)
        Me.Label57.TabIndex = 154
        Me.Label57.Text = "s:"
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.Color.Transparent
        Me.Frame12.Controls.Add(Me.H12ITXT)
        Me.Frame12.Controls.Add(Me.M12ITXT)
        Me.Frame12.Controls.Add(Me.S12ITXT)
        Me.Frame12.Controls.Add(Me.H12FTXT)
        Me.Frame12.Controls.Add(Me.M12FTXT)
        Me.Frame12.Controls.Add(Me.S12FTXT)
        Me.Frame12.Controls.Add(Me.Led12)
        Me.Frame12.Controls.Add(Me.Label55)
        Me.Frame12.Controls.Add(Me.Label54)
        Me.Frame12.Controls.Add(Me.Label53)
        Me.Frame12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame12.Location = New System.Drawing.Point(439, 393)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame12.Size = New System.Drawing.Size(89, 89)
        Me.Frame12.TabIndex = 136
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "OUT 12          "
        '
        'H12ITXT
        '
        Me.H12ITXT.AcceptsReturn = True
        Me.H12ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H12ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H12ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H12ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H12ITXT.MaxLength = 0
        Me.H12ITXT.Name = "H12ITXT"
        Me.H12ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H12ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H12ITXT.TabIndex = 142
        Me.H12ITXT.Text = "0"
        '
        'M12ITXT
        '
        Me.M12ITXT.AcceptsReturn = True
        Me.M12ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M12ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M12ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M12ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M12ITXT.MaxLength = 0
        Me.M12ITXT.Name = "M12ITXT"
        Me.M12ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M12ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M12ITXT.TabIndex = 141
        Me.M12ITXT.Text = "0"
        '
        'S12ITXT
        '
        Me.S12ITXT.AcceptsReturn = True
        Me.S12ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S12ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S12ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S12ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S12ITXT.MaxLength = 0
        Me.S12ITXT.Name = "S12ITXT"
        Me.S12ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S12ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S12ITXT.TabIndex = 140
        Me.S12ITXT.Text = "0"
        '
        'H12FTXT
        '
        Me.H12FTXT.AcceptsReturn = True
        Me.H12FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H12FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H12FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H12FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H12FTXT.MaxLength = 0
        Me.H12FTXT.Name = "H12FTXT"
        Me.H12FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H12FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H12FTXT.TabIndex = 139
        Me.H12FTXT.Text = "0"
        '
        'M12FTXT
        '
        Me.M12FTXT.AcceptsReturn = True
        Me.M12FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M12FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M12FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M12FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M12FTXT.MaxLength = 0
        Me.M12FTXT.Name = "M12FTXT"
        Me.M12FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M12FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M12FTXT.TabIndex = 138
        Me.M12FTXT.Text = "0"
        '
        'S12FTXT
        '
        Me.S12FTXT.AcceptsReturn = True
        Me.S12FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S12FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S12FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S12FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S12FTXT.MaxLength = 0
        Me.S12FTXT.Name = "S12FTXT"
        Me.S12FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S12FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S12FTXT.TabIndex = 137
        Me.S12FTXT.Text = "0"
        '
        'Led12
        '
        Me.Led12.BackColor = System.Drawing.Color.Red
        Me.Led12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led12.Location = New System.Drawing.Point(57, 2)
        Me.Led12.Name = "Led12"
        Me.Led12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led12.Size = New System.Drawing.Size(17, 9)
        Me.Led12.TabIndex = 146
        Me.Led12.Visible = False
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(8, 16)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(17, 17)
        Me.Label55.TabIndex = 145
        Me.Label55.Text = "h:"
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(32, 16)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(17, 17)
        Me.Label54.TabIndex = 144
        Me.Label54.Text = "m:"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(56, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label53.Size = New System.Drawing.Size(25, 17)
        Me.Label53.TabIndex = 143
        Me.Label53.Text = "s:"
        '
        'Frame11
        '
        Me.Frame11.BackColor = System.Drawing.Color.Transparent
        Me.Frame11.Controls.Add(Me.H11ITXT)
        Me.Frame11.Controls.Add(Me.M11ITXT)
        Me.Frame11.Controls.Add(Me.S11ITXT)
        Me.Frame11.Controls.Add(Me.H11FTXT)
        Me.Frame11.Controls.Add(Me.M11FTXT)
        Me.Frame11.Controls.Add(Me.S11FTXT)
        Me.Frame11.Controls.Add(Me.Led11)
        Me.Frame11.Controls.Add(Me.Label51)
        Me.Frame11.Controls.Add(Me.Label50)
        Me.Frame11.Controls.Add(Me.Label49)
        Me.Frame11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame11.Location = New System.Drawing.Point(351, 393)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame11.Size = New System.Drawing.Size(89, 89)
        Me.Frame11.TabIndex = 125
        Me.Frame11.TabStop = False
        Me.Frame11.Text = "OUT 11          "
        '
        'H11ITXT
        '
        Me.H11ITXT.AcceptsReturn = True
        Me.H11ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H11ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H11ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H11ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H11ITXT.MaxLength = 0
        Me.H11ITXT.Name = "H11ITXT"
        Me.H11ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H11ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H11ITXT.TabIndex = 131
        Me.H11ITXT.Text = "0"
        '
        'M11ITXT
        '
        Me.M11ITXT.AcceptsReturn = True
        Me.M11ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M11ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M11ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M11ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M11ITXT.MaxLength = 0
        Me.M11ITXT.Name = "M11ITXT"
        Me.M11ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M11ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M11ITXT.TabIndex = 130
        Me.M11ITXT.Text = "0"
        '
        'S11ITXT
        '
        Me.S11ITXT.AcceptsReturn = True
        Me.S11ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S11ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S11ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S11ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S11ITXT.MaxLength = 0
        Me.S11ITXT.Name = "S11ITXT"
        Me.S11ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S11ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S11ITXT.TabIndex = 129
        Me.S11ITXT.Text = "0"
        '
        'H11FTXT
        '
        Me.H11FTXT.AcceptsReturn = True
        Me.H11FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H11FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H11FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H11FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H11FTXT.MaxLength = 0
        Me.H11FTXT.Name = "H11FTXT"
        Me.H11FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H11FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H11FTXT.TabIndex = 128
        Me.H11FTXT.Text = "0"
        '
        'M11FTXT
        '
        Me.M11FTXT.AcceptsReturn = True
        Me.M11FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M11FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M11FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M11FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M11FTXT.MaxLength = 0
        Me.M11FTXT.Name = "M11FTXT"
        Me.M11FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M11FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M11FTXT.TabIndex = 127
        Me.M11FTXT.Text = "0"
        '
        'S11FTXT
        '
        Me.S11FTXT.AcceptsReturn = True
        Me.S11FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S11FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S11FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S11FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S11FTXT.MaxLength = 0
        Me.S11FTXT.Name = "S11FTXT"
        Me.S11FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S11FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S11FTXT.TabIndex = 126
        Me.S11FTXT.Text = "0"
        '
        'Led11
        '
        Me.Led11.BackColor = System.Drawing.Color.Red
        Me.Led11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led11.Location = New System.Drawing.Point(57, 1)
        Me.Led11.Name = "Led11"
        Me.Led11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led11.Size = New System.Drawing.Size(17, 9)
        Me.Led11.TabIndex = 135
        Me.Led11.Visible = False
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label51.Location = New System.Drawing.Point(8, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label51.Size = New System.Drawing.Size(17, 17)
        Me.Label51.TabIndex = 134
        Me.Label51.Text = "h:"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(32, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(17, 17)
        Me.Label50.TabIndex = 133
        Me.Label50.Text = "m:"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(56, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(25, 17)
        Me.Label49.TabIndex = 132
        Me.Label49.Text = "s:"
        '
        'Frame10
        '
        Me.Frame10.BackColor = System.Drawing.Color.Transparent
        Me.Frame10.Controls.Add(Me.H10ITXT)
        Me.Frame10.Controls.Add(Me.M10ITXT)
        Me.Frame10.Controls.Add(Me.S10ITXT)
        Me.Frame10.Controls.Add(Me.H10FTXT)
        Me.Frame10.Controls.Add(Me.M10FTXT)
        Me.Frame10.Controls.Add(Me.S10FTXT)
        Me.Frame10.Controls.Add(Me.Led10)
        Me.Frame10.Controls.Add(Me.Label47)
        Me.Frame10.Controls.Add(Me.Label46)
        Me.Frame10.Controls.Add(Me.Label45)
        Me.Frame10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame10.Location = New System.Drawing.Point(263, 393)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame10.Size = New System.Drawing.Size(89, 89)
        Me.Frame10.TabIndex = 114
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "OUT 10          "
        '
        'H10ITXT
        '
        Me.H10ITXT.AcceptsReturn = True
        Me.H10ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H10ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H10ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H10ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H10ITXT.MaxLength = 0
        Me.H10ITXT.Name = "H10ITXT"
        Me.H10ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H10ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H10ITXT.TabIndex = 120
        Me.H10ITXT.Text = "0"
        '
        'M10ITXT
        '
        Me.M10ITXT.AcceptsReturn = True
        Me.M10ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M10ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M10ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M10ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M10ITXT.MaxLength = 0
        Me.M10ITXT.Name = "M10ITXT"
        Me.M10ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M10ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M10ITXT.TabIndex = 119
        Me.M10ITXT.Text = "0"
        '
        'S10ITXT
        '
        Me.S10ITXT.AcceptsReturn = True
        Me.S10ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S10ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S10ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S10ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S10ITXT.MaxLength = 0
        Me.S10ITXT.Name = "S10ITXT"
        Me.S10ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S10ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S10ITXT.TabIndex = 118
        Me.S10ITXT.Text = "0"
        '
        'H10FTXT
        '
        Me.H10FTXT.AcceptsReturn = True
        Me.H10FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H10FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H10FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H10FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H10FTXT.MaxLength = 0
        Me.H10FTXT.Name = "H10FTXT"
        Me.H10FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H10FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H10FTXT.TabIndex = 117
        Me.H10FTXT.Text = "0"
        '
        'M10FTXT
        '
        Me.M10FTXT.AcceptsReturn = True
        Me.M10FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M10FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M10FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M10FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M10FTXT.MaxLength = 0
        Me.M10FTXT.Name = "M10FTXT"
        Me.M10FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M10FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M10FTXT.TabIndex = 116
        Me.M10FTXT.Text = "0"
        '
        'S10FTXT
        '
        Me.S10FTXT.AcceptsReturn = True
        Me.S10FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S10FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S10FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S10FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S10FTXT.MaxLength = 0
        Me.S10FTXT.Name = "S10FTXT"
        Me.S10FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S10FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S10FTXT.TabIndex = 115
        Me.S10FTXT.Text = "0"
        '
        'Led10
        '
        Me.Led10.BackColor = System.Drawing.Color.Red
        Me.Led10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led10.Location = New System.Drawing.Point(59, 1)
        Me.Led10.Name = "Led10"
        Me.Led10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led10.Size = New System.Drawing.Size(17, 9)
        Me.Led10.TabIndex = 124
        Me.Led10.Visible = False
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(8, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(17, 17)
        Me.Label47.TabIndex = 123
        Me.Label47.Text = "h:"
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label46.Location = New System.Drawing.Point(32, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label46.Size = New System.Drawing.Size(17, 17)
        Me.Label46.TabIndex = 122
        Me.Label46.Text = "m:"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(56, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(25, 17)
        Me.Label45.TabIndex = 121
        Me.Label45.Text = "s:"
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.Transparent
        Me.Frame9.Controls.Add(Me.H9ITXT)
        Me.Frame9.Controls.Add(Me.M9ITXT)
        Me.Frame9.Controls.Add(Me.S9ITXT)
        Me.Frame9.Controls.Add(Me.H9FTXT)
        Me.Frame9.Controls.Add(Me.M9FTXT)
        Me.Frame9.Controls.Add(Me.S9FTXT)
        Me.Frame9.Controls.Add(Me.Led9)
        Me.Frame9.Controls.Add(Me.Label43)
        Me.Frame9.Controls.Add(Me.Label42)
        Me.Frame9.Controls.Add(Me.Label41)
        Me.Frame9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(175, 393)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(89, 89)
        Me.Frame9.TabIndex = 103
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "OUT 9          "
        '
        'H9ITXT
        '
        Me.H9ITXT.AcceptsReturn = True
        Me.H9ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H9ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H9ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H9ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H9ITXT.MaxLength = 0
        Me.H9ITXT.Name = "H9ITXT"
        Me.H9ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H9ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H9ITXT.TabIndex = 109
        Me.H9ITXT.Text = "0"
        '
        'M9ITXT
        '
        Me.M9ITXT.AcceptsReturn = True
        Me.M9ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M9ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M9ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M9ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M9ITXT.MaxLength = 0
        Me.M9ITXT.Name = "M9ITXT"
        Me.M9ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M9ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M9ITXT.TabIndex = 108
        Me.M9ITXT.Text = "0"
        '
        'S9ITXT
        '
        Me.S9ITXT.AcceptsReturn = True
        Me.S9ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S9ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S9ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S9ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S9ITXT.MaxLength = 0
        Me.S9ITXT.Name = "S9ITXT"
        Me.S9ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S9ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S9ITXT.TabIndex = 107
        Me.S9ITXT.Text = "0"
        '
        'H9FTXT
        '
        Me.H9FTXT.AcceptsReturn = True
        Me.H9FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H9FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H9FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H9FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H9FTXT.MaxLength = 0
        Me.H9FTXT.Name = "H9FTXT"
        Me.H9FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H9FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H9FTXT.TabIndex = 106
        Me.H9FTXT.Text = "0"
        '
        'M9FTXT
        '
        Me.M9FTXT.AcceptsReturn = True
        Me.M9FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M9FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M9FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M9FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M9FTXT.MaxLength = 0
        Me.M9FTXT.Name = "M9FTXT"
        Me.M9FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M9FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M9FTXT.TabIndex = 105
        Me.M9FTXT.Text = "0"
        '
        'S9FTXT
        '
        Me.S9FTXT.AcceptsReturn = True
        Me.S9FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S9FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S9FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S9FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S9FTXT.MaxLength = 0
        Me.S9FTXT.Name = "S9FTXT"
        Me.S9FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S9FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S9FTXT.TabIndex = 104
        Me.S9FTXT.Text = "0"
        '
        'Led9
        '
        Me.Led9.BackColor = System.Drawing.Color.Red
        Me.Led9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led9.Location = New System.Drawing.Point(52, 1)
        Me.Led9.Name = "Led9"
        Me.Led9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led9.Size = New System.Drawing.Size(17, 9)
        Me.Led9.TabIndex = 113
        Me.Led9.Visible = False
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(8, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(17, 17)
        Me.Label43.TabIndex = 112
        Me.Label43.Text = "h:"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(32, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(17, 17)
        Me.Label42.TabIndex = 111
        Me.Label42.Text = "m:"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(56, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(25, 17)
        Me.Label41.TabIndex = 110
        Me.Label41.Text = "s:"
        '
        'CmdStop
        '
        Me.CmdStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStop.Location = New System.Drawing.Point(358, 591)
        Me.CmdStop.Name = "CmdStop"
        Me.CmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStop.Size = New System.Drawing.Size(57, 25)
        Me.CmdStop.TabIndex = 102
        Me.CmdStop.Text = "Parar"
        Me.CmdStop.UseVisualStyleBackColor = False
        '
        'SRT1
        '
        Me.SRT1.AcceptsReturn = True
        Me.SRT1.BackColor = System.Drawing.SystemColors.Window
        Me.SRT1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SRT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRT1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SRT1.Location = New System.Drawing.Point(302, 559)
        Me.SRT1.MaxLength = 0
        Me.SRT1.Name = "SRT1"
        Me.SRT1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SRT1.Size = New System.Drawing.Size(25, 20)
        Me.SRT1.TabIndex = 95
        Me.SRT1.Text = "0"
        '
        'MRT1
        '
        Me.MRT1.AcceptsReturn = True
        Me.MRT1.BackColor = System.Drawing.SystemColors.Window
        Me.MRT1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MRT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRT1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MRT1.Location = New System.Drawing.Point(278, 559)
        Me.MRT1.MaxLength = 0
        Me.MRT1.Name = "MRT1"
        Me.MRT1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MRT1.Size = New System.Drawing.Size(25, 20)
        Me.MRT1.TabIndex = 94
        Me.MRT1.Text = "0"
        '
        'HRT1
        '
        Me.HRT1.AcceptsReturn = True
        Me.HRT1.BackColor = System.Drawing.SystemColors.Window
        Me.HRT1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HRT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRT1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HRT1.Location = New System.Drawing.Point(254, 559)
        Me.HRT1.MaxLength = 0
        Me.HRT1.Name = "HRT1"
        Me.HRT1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HRT1.Size = New System.Drawing.Size(25, 20)
        Me.HRT1.TabIndex = 93
        Me.HRT1.Text = "0"
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.Color.Transparent
        Me.Frame8.Controls.Add(Me.H8ITXT)
        Me.Frame8.Controls.Add(Me.M8ITXT)
        Me.Frame8.Controls.Add(Me.S8ITXT)
        Me.Frame8.Controls.Add(Me.H8FTXT)
        Me.Frame8.Controls.Add(Me.M8FTXT)
        Me.Frame8.Controls.Add(Me.S8FTXT)
        Me.Frame8.Controls.Add(Me.Led8)
        Me.Frame8.Controls.Add(Me.Label33)
        Me.Frame8.Controls.Add(Me.Label32)
        Me.Frame8.Controls.Add(Me.Label31)
        Me.Frame8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(791, 249)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(89, 89)
        Me.Frame8.TabIndex = 82
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "OUT 8          "
        '
        'H8ITXT
        '
        Me.H8ITXT.AcceptsReturn = True
        Me.H8ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H8ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H8ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H8ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H8ITXT.MaxLength = 0
        Me.H8ITXT.Name = "H8ITXT"
        Me.H8ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H8ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H8ITXT.TabIndex = 88
        Me.H8ITXT.Text = "0"
        '
        'M8ITXT
        '
        Me.M8ITXT.AcceptsReturn = True
        Me.M8ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M8ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M8ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M8ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M8ITXT.MaxLength = 0
        Me.M8ITXT.Name = "M8ITXT"
        Me.M8ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M8ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M8ITXT.TabIndex = 87
        Me.M8ITXT.Text = "0"
        '
        'S8ITXT
        '
        Me.S8ITXT.AcceptsReturn = True
        Me.S8ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S8ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S8ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S8ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S8ITXT.MaxLength = 0
        Me.S8ITXT.Name = "S8ITXT"
        Me.S8ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S8ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S8ITXT.TabIndex = 86
        Me.S8ITXT.Text = "0"
        '
        'H8FTXT
        '
        Me.H8FTXT.AcceptsReturn = True
        Me.H8FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H8FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H8FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H8FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H8FTXT.MaxLength = 0
        Me.H8FTXT.Name = "H8FTXT"
        Me.H8FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H8FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H8FTXT.TabIndex = 85
        Me.H8FTXT.Text = "0"
        '
        'M8FTXT
        '
        Me.M8FTXT.AcceptsReturn = True
        Me.M8FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M8FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M8FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M8FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M8FTXT.MaxLength = 0
        Me.M8FTXT.Name = "M8FTXT"
        Me.M8FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M8FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M8FTXT.TabIndex = 84
        Me.M8FTXT.Text = "0"
        '
        'S8FTXT
        '
        Me.S8FTXT.AcceptsReturn = True
        Me.S8FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S8FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S8FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S8FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S8FTXT.MaxLength = 0
        Me.S8FTXT.Name = "S8FTXT"
        Me.S8FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S8FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S8FTXT.TabIndex = 83
        Me.S8FTXT.Text = "0"
        '
        'Led8
        '
        Me.Led8.BackColor = System.Drawing.Color.Red
        Me.Led8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led8.Location = New System.Drawing.Point(51, 1)
        Me.Led8.Name = "Led8"
        Me.Led8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led8.Size = New System.Drawing.Size(17, 9)
        Me.Led8.TabIndex = 92
        Me.Led8.Visible = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(8, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(17, 17)
        Me.Label33.TabIndex = 91
        Me.Label33.Text = "h:"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(32, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(17, 17)
        Me.Label32.TabIndex = 90
        Me.Label32.Text = "m:"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(56, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(17, 17)
        Me.Label31.TabIndex = 89
        Me.Label31.Text = "s:"
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.Transparent
        Me.Frame7.Controls.Add(Me.H7ITXT)
        Me.Frame7.Controls.Add(Me.M7ITXT)
        Me.Frame7.Controls.Add(Me.S7ITXT)
        Me.Frame7.Controls.Add(Me.H7FTXT)
        Me.Frame7.Controls.Add(Me.M7FTXT)
        Me.Frame7.Controls.Add(Me.S7FTXT)
        Me.Frame7.Controls.Add(Me.Led7)
        Me.Frame7.Controls.Add(Me.Label29)
        Me.Frame7.Controls.Add(Me.Label28)
        Me.Frame7.Controls.Add(Me.Label27)
        Me.Frame7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(703, 249)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(89, 89)
        Me.Frame7.TabIndex = 71
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "OUT 7          "
        '
        'H7ITXT
        '
        Me.H7ITXT.AcceptsReturn = True
        Me.H7ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H7ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H7ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H7ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H7ITXT.MaxLength = 0
        Me.H7ITXT.Name = "H7ITXT"
        Me.H7ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H7ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H7ITXT.TabIndex = 77
        Me.H7ITXT.Text = "0"
        '
        'M7ITXT
        '
        Me.M7ITXT.AcceptsReturn = True
        Me.M7ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M7ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M7ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M7ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M7ITXT.MaxLength = 0
        Me.M7ITXT.Name = "M7ITXT"
        Me.M7ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M7ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M7ITXT.TabIndex = 76
        Me.M7ITXT.Text = "0"
        '
        'S7ITXT
        '
        Me.S7ITXT.AcceptsReturn = True
        Me.S7ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S7ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S7ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S7ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S7ITXT.MaxLength = 0
        Me.S7ITXT.Name = "S7ITXT"
        Me.S7ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S7ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S7ITXT.TabIndex = 75
        Me.S7ITXT.Text = "0"
        '
        'H7FTXT
        '
        Me.H7FTXT.AcceptsReturn = True
        Me.H7FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H7FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H7FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H7FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H7FTXT.MaxLength = 0
        Me.H7FTXT.Name = "H7FTXT"
        Me.H7FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H7FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H7FTXT.TabIndex = 74
        Me.H7FTXT.Text = "0"
        '
        'M7FTXT
        '
        Me.M7FTXT.AcceptsReturn = True
        Me.M7FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M7FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M7FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M7FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M7FTXT.MaxLength = 0
        Me.M7FTXT.Name = "M7FTXT"
        Me.M7FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M7FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M7FTXT.TabIndex = 73
        Me.M7FTXT.Text = "0"
        '
        'S7FTXT
        '
        Me.S7FTXT.AcceptsReturn = True
        Me.S7FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S7FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S7FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S7FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S7FTXT.MaxLength = 0
        Me.S7FTXT.Name = "S7FTXT"
        Me.S7FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S7FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S7FTXT.TabIndex = 72
        Me.S7FTXT.Text = "0"
        '
        'Led7
        '
        Me.Led7.BackColor = System.Drawing.Color.Red
        Me.Led7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led7.Location = New System.Drawing.Point(51, 1)
        Me.Led7.Name = "Led7"
        Me.Led7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led7.Size = New System.Drawing.Size(17, 9)
        Me.Led7.TabIndex = 81
        Me.Led7.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(8, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(17, 17)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "h:"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(32, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(17, 17)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "m:"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(56, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(17, 17)
        Me.Label27.TabIndex = 78
        Me.Label27.Text = "s:"
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.Transparent
        Me.Frame6.Controls.Add(Me.S6FTXT)
        Me.Frame6.Controls.Add(Me.M6FTXT)
        Me.Frame6.Controls.Add(Me.H6FTXT)
        Me.Frame6.Controls.Add(Me.S6ITXT)
        Me.Frame6.Controls.Add(Me.M6ITXT)
        Me.Frame6.Controls.Add(Me.H6ITXT)
        Me.Frame6.Controls.Add(Me.Label26)
        Me.Frame6.Controls.Add(Me.Label25)
        Me.Frame6.Controls.Add(Me.Label24)
        Me.Frame6.Controls.Add(Me.Led6)
        Me.Frame6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(615, 249)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(89, 89)
        Me.Frame6.TabIndex = 60
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "OUT 6          "
        '
        'S6FTXT
        '
        Me.S6FTXT.AcceptsReturn = True
        Me.S6FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S6FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S6FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S6FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S6FTXT.MaxLength = 0
        Me.S6FTXT.Name = "S6FTXT"
        Me.S6FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S6FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S6FTXT.TabIndex = 66
        Me.S6FTXT.Text = "0"
        '
        'M6FTXT
        '
        Me.M6FTXT.AcceptsReturn = True
        Me.M6FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M6FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M6FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M6FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M6FTXT.MaxLength = 0
        Me.M6FTXT.Name = "M6FTXT"
        Me.M6FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M6FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M6FTXT.TabIndex = 65
        Me.M6FTXT.Text = "0"
        '
        'H6FTXT
        '
        Me.H6FTXT.AcceptsReturn = True
        Me.H6FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H6FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H6FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H6FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H6FTXT.MaxLength = 0
        Me.H6FTXT.Name = "H6FTXT"
        Me.H6FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H6FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H6FTXT.TabIndex = 64
        Me.H6FTXT.Text = "0"
        '
        'S6ITXT
        '
        Me.S6ITXT.AcceptsReturn = True
        Me.S6ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S6ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S6ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S6ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S6ITXT.MaxLength = 0
        Me.S6ITXT.Name = "S6ITXT"
        Me.S6ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S6ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S6ITXT.TabIndex = 63
        Me.S6ITXT.Text = "0"
        '
        'M6ITXT
        '
        Me.M6ITXT.AcceptsReturn = True
        Me.M6ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M6ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M6ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M6ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M6ITXT.MaxLength = 0
        Me.M6ITXT.Name = "M6ITXT"
        Me.M6ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M6ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M6ITXT.TabIndex = 62
        Me.M6ITXT.Text = "0"
        '
        'H6ITXT
        '
        Me.H6ITXT.AcceptsReturn = True
        Me.H6ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H6ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H6ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H6ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H6ITXT.MaxLength = 0
        Me.H6ITXT.Name = "H6ITXT"
        Me.H6ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H6ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H6ITXT.TabIndex = 61
        Me.H6ITXT.Text = "0"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(56, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(17, 17)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "s:"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(32, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(17, 17)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "m:"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(17, 17)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "h:"
        '
        'Led6
        '
        Me.Led6.BackColor = System.Drawing.Color.Red
        Me.Led6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led6.Location = New System.Drawing.Point(51, 1)
        Me.Led6.Name = "Led6"
        Me.Led6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led6.Size = New System.Drawing.Size(17, 9)
        Me.Led6.TabIndex = 67
        Me.Led6.Visible = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.Transparent
        Me.Frame5.Controls.Add(Me.S5FTXT)
        Me.Frame5.Controls.Add(Me.M5FTXT)
        Me.Frame5.Controls.Add(Me.H5FTXT)
        Me.Frame5.Controls.Add(Me.S5ITXT)
        Me.Frame5.Controls.Add(Me.M5ITXT)
        Me.Frame5.Controls.Add(Me.H5ITXT)
        Me.Frame5.Controls.Add(Me.Label22)
        Me.Frame5.Controls.Add(Me.Label21)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Led5)
        Me.Frame5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(527, 249)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(89, 89)
        Me.Frame5.TabIndex = 49
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "OUT 5          "
        '
        'S5FTXT
        '
        Me.S5FTXT.AcceptsReturn = True
        Me.S5FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S5FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S5FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S5FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S5FTXT.MaxLength = 0
        Me.S5FTXT.Name = "S5FTXT"
        Me.S5FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S5FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S5FTXT.TabIndex = 55
        Me.S5FTXT.Text = "0"
        '
        'M5FTXT
        '
        Me.M5FTXT.AcceptsReturn = True
        Me.M5FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M5FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M5FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M5FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M5FTXT.MaxLength = 0
        Me.M5FTXT.Name = "M5FTXT"
        Me.M5FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M5FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M5FTXT.TabIndex = 54
        Me.M5FTXT.Text = "0"
        '
        'H5FTXT
        '
        Me.H5FTXT.AcceptsReturn = True
        Me.H5FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H5FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H5FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H5FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H5FTXT.MaxLength = 0
        Me.H5FTXT.Name = "H5FTXT"
        Me.H5FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H5FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H5FTXT.TabIndex = 53
        Me.H5FTXT.Text = "0"
        '
        'S5ITXT
        '
        Me.S5ITXT.AcceptsReturn = True
        Me.S5ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S5ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S5ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S5ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S5ITXT.MaxLength = 0
        Me.S5ITXT.Name = "S5ITXT"
        Me.S5ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S5ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S5ITXT.TabIndex = 52
        Me.S5ITXT.Text = "0"
        '
        'M5ITXT
        '
        Me.M5ITXT.AcceptsReturn = True
        Me.M5ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M5ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M5ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M5ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M5ITXT.MaxLength = 0
        Me.M5ITXT.Name = "M5ITXT"
        Me.M5ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M5ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M5ITXT.TabIndex = 51
        Me.M5ITXT.Text = "0"
        '
        'H5ITXT
        '
        Me.H5ITXT.AcceptsReturn = True
        Me.H5ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H5ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H5ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H5ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H5ITXT.MaxLength = 0
        Me.H5ITXT.Name = "H5ITXT"
        Me.H5ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H5ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H5ITXT.TabIndex = 50
        Me.H5ITXT.Text = "0"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(56, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(17, 17)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "s:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(32, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(17, 17)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "m:"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(17, 17)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "h:"
        '
        'Led5
        '
        Me.Led5.BackColor = System.Drawing.Color.Red
        Me.Led5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led5.Location = New System.Drawing.Point(51, 1)
        Me.Led5.Name = "Led5"
        Me.Led5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led5.Size = New System.Drawing.Size(17, 9)
        Me.Led5.TabIndex = 56
        Me.Led5.Visible = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.Transparent
        Me.Frame4.Controls.Add(Me.S4FTXT)
        Me.Frame4.Controls.Add(Me.M4FTXT)
        Me.Frame4.Controls.Add(Me.H4FTXT)
        Me.Frame4.Controls.Add(Me.S4ITXT)
        Me.Frame4.Controls.Add(Me.M4ITXT)
        Me.Frame4.Controls.Add(Me.H4ITXT)
        Me.Frame4.Controls.Add(Me.Label18)
        Me.Frame4.Controls.Add(Me.Label17)
        Me.Frame4.Controls.Add(Me.Label16)
        Me.Frame4.Controls.Add(Me.Led4)
        Me.Frame4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(439, 249)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(89, 89)
        Me.Frame4.TabIndex = 38
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "OUT 4          "
        '
        'S4FTXT
        '
        Me.S4FTXT.AcceptsReturn = True
        Me.S4FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S4FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S4FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S4FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S4FTXT.MaxLength = 0
        Me.S4FTXT.Name = "S4FTXT"
        Me.S4FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S4FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S4FTXT.TabIndex = 44
        Me.S4FTXT.Text = "0"
        '
        'M4FTXT
        '
        Me.M4FTXT.AcceptsReturn = True
        Me.M4FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M4FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M4FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M4FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M4FTXT.MaxLength = 0
        Me.M4FTXT.Name = "M4FTXT"
        Me.M4FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M4FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M4FTXT.TabIndex = 43
        Me.M4FTXT.Text = "0"
        '
        'H4FTXT
        '
        Me.H4FTXT.AcceptsReturn = True
        Me.H4FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H4FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H4FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H4FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H4FTXT.MaxLength = 0
        Me.H4FTXT.Name = "H4FTXT"
        Me.H4FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H4FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H4FTXT.TabIndex = 42
        Me.H4FTXT.Text = "0"
        '
        'S4ITXT
        '
        Me.S4ITXT.AcceptsReturn = True
        Me.S4ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S4ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S4ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S4ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S4ITXT.MaxLength = 0
        Me.S4ITXT.Name = "S4ITXT"
        Me.S4ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S4ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S4ITXT.TabIndex = 41
        Me.S4ITXT.Text = "0"
        '
        'M4ITXT
        '
        Me.M4ITXT.AcceptsReturn = True
        Me.M4ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M4ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M4ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M4ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M4ITXT.MaxLength = 0
        Me.M4ITXT.Name = "M4ITXT"
        Me.M4ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M4ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M4ITXT.TabIndex = 40
        Me.M4ITXT.Text = "0"
        '
        'H4ITXT
        '
        Me.H4ITXT.AcceptsReturn = True
        Me.H4ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H4ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H4ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H4ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H4ITXT.MaxLength = 0
        Me.H4ITXT.Name = "H4ITXT"
        Me.H4ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H4ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H4ITXT.TabIndex = 39
        Me.H4ITXT.Text = "0"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(56, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(17, 17)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "s:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(32, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(17, 17)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "m:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(17, 17)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "h:"
        '
        'Led4
        '
        Me.Led4.BackColor = System.Drawing.Color.Red
        Me.Led4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led4.Location = New System.Drawing.Point(51, 1)
        Me.Led4.Name = "Led4"
        Me.Led4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led4.Size = New System.Drawing.Size(17, 9)
        Me.Led4.TabIndex = 45
        Me.Led4.Visible = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.Transparent
        Me.Frame3.Controls.Add(Me.S3FTXT)
        Me.Frame3.Controls.Add(Me.M3FTXT)
        Me.Frame3.Controls.Add(Me.H3FTXT)
        Me.Frame3.Controls.Add(Me.S3ITXT)
        Me.Frame3.Controls.Add(Me.M3ITXT)
        Me.Frame3.Controls.Add(Me.H3ITXT)
        Me.Frame3.Controls.Add(Me.Label14)
        Me.Frame3.Controls.Add(Me.Label13)
        Me.Frame3.Controls.Add(Me.Label11)
        Me.Frame3.Controls.Add(Me.Led3)
        Me.Frame3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(351, 249)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(89, 89)
        Me.Frame3.TabIndex = 27
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "OUT 3          "
        '
        'S3FTXT
        '
        Me.S3FTXT.AcceptsReturn = True
        Me.S3FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S3FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S3FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S3FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S3FTXT.MaxLength = 0
        Me.S3FTXT.Name = "S3FTXT"
        Me.S3FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S3FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S3FTXT.TabIndex = 33
        Me.S3FTXT.Text = "0"
        '
        'M3FTXT
        '
        Me.M3FTXT.AcceptsReturn = True
        Me.M3FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M3FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M3FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M3FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M3FTXT.MaxLength = 0
        Me.M3FTXT.Name = "M3FTXT"
        Me.M3FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M3FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M3FTXT.TabIndex = 32
        Me.M3FTXT.Text = "0"
        '
        'H3FTXT
        '
        Me.H3FTXT.AcceptsReturn = True
        Me.H3FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H3FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H3FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H3FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H3FTXT.MaxLength = 0
        Me.H3FTXT.Name = "H3FTXT"
        Me.H3FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H3FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H3FTXT.TabIndex = 31
        Me.H3FTXT.Text = "0"
        '
        'S3ITXT
        '
        Me.S3ITXT.AcceptsReturn = True
        Me.S3ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S3ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S3ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S3ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S3ITXT.MaxLength = 0
        Me.S3ITXT.Name = "S3ITXT"
        Me.S3ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S3ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S3ITXT.TabIndex = 30
        Me.S3ITXT.Text = "0"
        '
        'M3ITXT
        '
        Me.M3ITXT.AcceptsReturn = True
        Me.M3ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M3ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M3ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M3ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M3ITXT.MaxLength = 0
        Me.M3ITXT.Name = "M3ITXT"
        Me.M3ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M3ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M3ITXT.TabIndex = 29
        Me.M3ITXT.Text = "0"
        '
        'H3ITXT
        '
        Me.H3ITXT.AcceptsReturn = True
        Me.H3ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H3ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H3ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H3ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H3ITXT.MaxLength = 0
        Me.H3ITXT.Name = "H3ITXT"
        Me.H3ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H3ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H3ITXT.TabIndex = 28
        Me.H3ITXT.Text = "0"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(56, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(17, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "s:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(32, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(17, 17)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "m:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(17, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "h:"
        '
        'Led3
        '
        Me.Led3.BackColor = System.Drawing.Color.Red
        Me.Led3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led3.Location = New System.Drawing.Point(51, 1)
        Me.Led3.Name = "Led3"
        Me.Led3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led3.Size = New System.Drawing.Size(17, 9)
        Me.Led3.TabIndex = 34
        Me.Led3.Visible = False
        '
        '_Frame2_0
        '
        Me._Frame2_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_0.Controls.Add(Me.H2ITXT)
        Me._Frame2_0.Controls.Add(Me.M2ITXT)
        Me._Frame2_0.Controls.Add(Me.S2ITXT)
        Me._Frame2_0.Controls.Add(Me.H2FTXT)
        Me._Frame2_0.Controls.Add(Me.M2FTXT)
        Me._Frame2_0.Controls.Add(Me.S2FTXT)
        Me._Frame2_0.Controls.Add(Me.Led2)
        Me._Frame2_0.Controls.Add(Me._Label9_0)
        Me._Frame2_0.Controls.Add(Me._Label8_0)
        Me._Frame2_0.Controls.Add(Me._Label7_0)
        Me._Frame2_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.SetIndex(Me._Frame2_0, CType(0, Short))
        Me._Frame2_0.Location = New System.Drawing.Point(263, 249)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_0.Size = New System.Drawing.Size(89, 89)
        Me._Frame2_0.TabIndex = 14
        Me._Frame2_0.TabStop = False
        Me._Frame2_0.Text = "OUT 2          "
        '
        'H2ITXT
        '
        Me.H2ITXT.AcceptsReturn = True
        Me.H2ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H2ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H2ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H2ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H2ITXT.MaxLength = 0
        Me.H2ITXT.Name = "H2ITXT"
        Me.H2ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H2ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H2ITXT.TabIndex = 20
        Me.H2ITXT.Text = "0"
        '
        'M2ITXT
        '
        Me.M2ITXT.AcceptsReturn = True
        Me.M2ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M2ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M2ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M2ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M2ITXT.MaxLength = 0
        Me.M2ITXT.Name = "M2ITXT"
        Me.M2ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M2ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M2ITXT.TabIndex = 19
        Me.M2ITXT.Text = "0"
        '
        'S2ITXT
        '
        Me.S2ITXT.AcceptsReturn = True
        Me.S2ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S2ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S2ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S2ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S2ITXT.MaxLength = 0
        Me.S2ITXT.Name = "S2ITXT"
        Me.S2ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S2ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S2ITXT.TabIndex = 18
        Me.S2ITXT.Text = "0"
        '
        'H2FTXT
        '
        Me.H2FTXT.AcceptsReturn = True
        Me.H2FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H2FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H2FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H2FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H2FTXT.MaxLength = 0
        Me.H2FTXT.Name = "H2FTXT"
        Me.H2FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H2FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H2FTXT.TabIndex = 17
        Me.H2FTXT.Text = "0"
        '
        'M2FTXT
        '
        Me.M2FTXT.AcceptsReturn = True
        Me.M2FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M2FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M2FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M2FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M2FTXT.MaxLength = 0
        Me.M2FTXT.Name = "M2FTXT"
        Me.M2FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M2FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M2FTXT.TabIndex = 16
        Me.M2FTXT.Text = "0"
        '
        'S2FTXT
        '
        Me.S2FTXT.AcceptsReturn = True
        Me.S2FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S2FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S2FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S2FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S2FTXT.MaxLength = 0
        Me.S2FTXT.Name = "S2FTXT"
        Me.S2FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S2FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S2FTXT.TabIndex = 15
        Me.S2FTXT.Text = "0"
        '
        'Led2
        '
        Me.Led2.BackColor = System.Drawing.Color.Red
        Me.Led2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led2.Location = New System.Drawing.Point(51, 1)
        Me.Led2.Name = "Led2"
        Me.Led2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led2.Size = New System.Drawing.Size(17, 9)
        Me.Led2.TabIndex = 24
        Me.Led2.Visible = False
        '
        '_Label9_0
        '
        Me._Label9_0.BackColor = System.Drawing.Color.Transparent
        Me._Label9_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.SetIndex(Me._Label9_0, CType(0, Short))
        Me._Label9_0.Location = New System.Drawing.Point(8, 16)
        Me._Label9_0.Name = "_Label9_0"
        Me._Label9_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_0.Size = New System.Drawing.Size(17, 17)
        Me._Label9_0.TabIndex = 23
        Me._Label9_0.Text = "h:"
        '
        '_Label8_0
        '
        Me._Label8_0.BackColor = System.Drawing.Color.Transparent
        Me._Label8_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label8_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.SetIndex(Me._Label8_0, CType(0, Short))
        Me._Label8_0.Location = New System.Drawing.Point(32, 16)
        Me._Label8_0.Name = "_Label8_0"
        Me._Label8_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label8_0.Size = New System.Drawing.Size(17, 17)
        Me._Label8_0.TabIndex = 22
        Me._Label8_0.Text = "m:"
        '
        '_Label7_0
        '
        Me._Label7_0.BackColor = System.Drawing.Color.Transparent
        Me._Label7_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label7_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.SetIndex(Me._Label7_0, CType(0, Short))
        Me._Label7_0.Location = New System.Drawing.Point(56, 16)
        Me._Label7_0.Name = "_Label7_0"
        Me._Label7_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label7_0.Size = New System.Drawing.Size(17, 17)
        Me._Label7_0.TabIndex = 21
        Me._Label7_0.Text = "s:"
        '
        'HActualTxt
        '
        Me.HActualTxt.AcceptsReturn = True
        Me.HActualTxt.BackColor = System.Drawing.SystemColors.Window
        Me.HActualTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HActualTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HActualTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HActualTxt.Location = New System.Drawing.Point(254, 607)
        Me.HActualTxt.MaxLength = 0
        Me.HActualTxt.Name = "HActualTxt"
        Me.HActualTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HActualTxt.Size = New System.Drawing.Size(73, 20)
        Me.HActualTxt.TabIndex = 9
        Me.HActualTxt.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CmdInicio
        '
        Me.CmdInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdInicio.Location = New System.Drawing.Point(358, 559)
        Me.CmdInicio.Name = "CmdInicio"
        Me.CmdInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdInicio.Size = New System.Drawing.Size(57, 25)
        Me.CmdInicio.TabIndex = 5
        Me.CmdInicio.Text = "Inicio"
        Me.CmdInicio.UseVisualStyleBackColor = False
        '
        'HCtxt
        '
        Me.HCtxt.AcceptsReturn = True
        Me.HCtxt.BackColor = System.Drawing.SystemColors.Window
        Me.HCtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HCtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HCtxt.Location = New System.Drawing.Point(254, 583)
        Me.HCtxt.MaxLength = 0
        Me.HCtxt.Name = "HCtxt"
        Me.HCtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HCtxt.Size = New System.Drawing.Size(73, 20)
        Me.HCtxt.TabIndex = 4
        Me.HCtxt.Text = "0"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.S1FTXT)
        Me.Frame1.Controls.Add(Me.M1FTXT)
        Me.Frame1.Controls.Add(Me.H1FTXT)
        Me.Frame1.Controls.Add(Me.S1ITXT)
        Me.Frame1.Controls.Add(Me.M1ITXT)
        Me.Frame1.Controls.Add(Me.H1ITXT)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Led1)
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(175, 249)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(89, 89)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "OUT 1          "
        '
        'S1FTXT
        '
        Me.S1FTXT.AcceptsReturn = True
        Me.S1FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S1FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S1FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S1FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S1FTXT.MaxLength = 0
        Me.S1FTXT.Name = "S1FTXT"
        Me.S1FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S1FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S1FTXT.TabIndex = 8
        Me.S1FTXT.Text = "0"
        '
        'M1FTXT
        '
        Me.M1FTXT.AcceptsReturn = True
        Me.M1FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M1FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M1FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M1FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M1FTXT.MaxLength = 0
        Me.M1FTXT.Name = "M1FTXT"
        Me.M1FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M1FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M1FTXT.TabIndex = 7
        Me.M1FTXT.Text = "0"
        '
        'H1FTXT
        '
        Me.H1FTXT.AcceptsReturn = True
        Me.H1FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H1FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H1FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H1FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H1FTXT.MaxLength = 0
        Me.H1FTXT.Name = "H1FTXT"
        Me.H1FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H1FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H1FTXT.TabIndex = 6
        Me.H1FTXT.Text = "0"
        '
        'S1ITXT
        '
        Me.S1ITXT.AcceptsReturn = True
        Me.S1ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S1ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S1ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S1ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S1ITXT.MaxLength = 0
        Me.S1ITXT.Name = "S1ITXT"
        Me.S1ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S1ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S1ITXT.TabIndex = 3
        Me.S1ITXT.Text = "0"
        '
        'M1ITXT
        '
        Me.M1ITXT.AcceptsReturn = True
        Me.M1ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M1ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M1ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M1ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M1ITXT.MaxLength = 0
        Me.M1ITXT.Name = "M1ITXT"
        Me.M1ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M1ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M1ITXT.TabIndex = 2
        Me.M1ITXT.Text = "0"
        '
        'H1ITXT
        '
        Me.H1ITXT.AcceptsReturn = True
        Me.H1ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H1ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H1ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H1ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H1ITXT.MaxLength = 0
        Me.H1ITXT.Name = "H1ITXT"
        Me.H1ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H1ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H1ITXT.TabIndex = 1
        Me.H1ITXT.Text = "0"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(56, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "s:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "m:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "h:"
        '
        'Led1
        '
        Me.Led1.BackColor = System.Drawing.Color.Red
        Me.Led1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led1.Location = New System.Drawing.Point(51, 1)
        Me.Led1.Name = "Led1"
        Me.Led1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led1.Size = New System.Drawing.Size(17, 9)
        Me.Led1.TabIndex = 10
        Me.Led1.Visible = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(302, 543)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(17, 17)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "s:"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(278, 543)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(17, 17)
        Me.Label39.TabIndex = 100
        Me.Label39.Text = "m:"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(254, 543)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(17, 17)
        Me.Label38.TabIndex = 99
        Me.Label38.Text = "h:"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(123, 559)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(100, 17)
        Me.Label35.TabIndex = 96
        Me.Label35.Text = "Repetir cada:"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(122, 583)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(97, 17)
        Me.Label36.TabIndex = 97
        Me.Label36.Text = "Hora de inicio:"
        '
        'WindowsMediaPlayer1
        '
        Me.WindowsMediaPlayer1.Enabled = True
        Me.WindowsMediaPlayer1.Location = New System.Drawing.Point(436, 578)
        Me.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1"
        Me.WindowsMediaPlayer1.OcxState = CType(resources.GetObject("WindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WindowsMediaPlayer1.Size = New System.Drawing.Size(297, 44)
        Me.WindowsMediaPlayer1.TabIndex = 193
        Me.WindowsMediaPlayer1.Visible = False
        '
        'Label74
        '
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label74.Location = New System.Drawing.Point(119, 449)
        Me.Label74.Name = "Label74"
        Me.Label74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label74.Size = New System.Drawing.Size(49, 17)
        Me.Label74.TabIndex = 192
        Me.Label74.Text = " Final:"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(119, 425)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label73.Size = New System.Drawing.Size(49, 17)
        Me.Label73.TabIndex = 191
        Me.Label73.Text = " Inicio:"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(120, 607)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(130, 17)
        Me.Label37.TabIndex = 98
        Me.Label37.Text = "Tiempo transcurrido:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(119, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = " Final:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(119, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = " Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(844, 718)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 22)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "www.alvarolara.com"
        '
        'temporizador_belen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1146, 810)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Frame16)
        Me.Controls.Add(Me.Frame15)
        Me.Controls.Add(Me.Frame14)
        Me.Controls.Add(Me.Frame13)
        Me.Controls.Add(Me.Frame12)
        Me.Controls.Add(Me.Frame11)
        Me.Controls.Add(Me.Frame10)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.CmdStop)
        Me.Controls.Add(Me.SRT1)
        Me.Controls.Add(Me.MRT1)
        Me.Controls.Add(Me.HRT1)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me._Frame2_0)
        Me.Controls.Add(Me.HActualTxt)
        Me.Controls.Add(Me.CmdInicio)
        Me.Controls.Add(Me.HCtxt)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.WindowsMediaPlayer1)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(162, 140)
        Me.MaximizeBox = False
        Me.Name = "temporizador_belen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Control Luces del Belén"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame16.ResumeLayout(False)
        Me.Frame16.PerformLayout()
        Me.Frame15.ResumeLayout(False)
        Me.Frame15.PerformLayout()
        Me.Frame14.ResumeLayout(False)
        Me.Frame14.PerformLayout()
        Me.Frame13.ResumeLayout(False)
        Me.Frame13.PerformLayout()
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        Me.Frame11.ResumeLayout(False)
        Me.Frame11.PerformLayout()
        Me.Frame10.ResumeLayout(False)
        Me.Frame10.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame9.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me._Frame2_0.ResumeLayout(False)
        Me._Frame2_0.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.WindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
#End Region 
End Class