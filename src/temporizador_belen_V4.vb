Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class temporizador_belen
	Inherits System.Windows.Forms.Form
	Dim H1I, M1I As Object
	Dim S1I As Short
	Dim H1F, M1F As Object
	Dim S1F As Short
	Dim Inicio1 As Object
	Dim Final1 As Integer
	
	Dim H2I, M2I As Object
	Dim S2I As Short
	Dim H2F, M2F As Object
	Dim S2F As Short
	Dim Inicio2 As Object
	Dim Final2 As Integer
	
	Dim H3I, M3I As Object
	Dim S3I As Short
	Dim H3F, M3F As Object
	Dim S3F As Short
	Dim Inicio3 As Object
	Dim Final3 As Integer
	
	Dim H4I, M4I As Object
	Dim S4I As Short
	Dim H4F, M4F As Object
	Dim S4F As Short
	Dim Inicio4 As Object
	Dim Final4 As Integer
	
	Dim H5I, M5I As Object
	Dim S5I As Short
	Dim H5F, M5F As Object
	Dim S5F As Short
	Dim Inicio5 As Object
	Dim Final5 As Integer
	
	Dim H6I, M6I As Object
	Dim S6I As Short
	Dim H6F, M6F As Object
	Dim S6F As Short
	Dim Inicio6 As Object
	Dim Final6 As Integer
	
	Dim H7I, M7I As Object
	Dim S7I As Short
	Dim H7F, M7F As Object
	Dim S7F As Short
	Dim Inicio7 As Object
	Dim Final7 As Integer
	
	Dim H8I, M8I As Object
	Dim S8I As Short
	Dim H8F, M8F As Object
	Dim S8F As Short
	Dim Inicio8 As Object
	Dim Final8 As Integer
	
	Dim H9I, M9I As Object
	Dim S9I As Short
	Dim H9F, M9F As Object
	Dim S9F As Short
	Dim Inicio9 As Object
	Dim Final9 As Integer
	
	Dim H10I, M10I As Object
	Dim S10I As Short
	Dim H10F, M10F As Object
	Dim S10F As Short
	Dim Inicio10 As Object
	Dim Final10 As Integer
	
	Dim H11I, M11I As Object
	Dim S11I As Short
	Dim H11F, M11F As Object
	Dim S11F As Short
	Dim Inicio11 As Object
	Dim Final11 As Integer
	
	Dim H12I, M12I As Object
	Dim S12I As Short
	Dim H12F, M12F As Object
	Dim S12F As Short
	Dim Inicio12 As Object
	Dim Final12 As Integer
	
	Dim H13I, M13I As Object
	Dim S13I As Short
	Dim H13F, M13F As Object
	Dim S13F As Short
	Dim Inicio13 As Object
	Dim Final13 As Integer
	
	Dim H14I, M14I As Object
	Dim S14I As Short
	Dim H14F, M14F As Object
	Dim S14F As Short
	Dim Inicio14 As Object
	Dim Final14 As Integer
	
	Dim H15I, M15I As Object
	Dim S15I As Short
	Dim H15F, M15F As Object
	Dim S15F As Short
	Dim Inicio15 As Object
	Dim Final15 As Integer
	
	Dim H16I, M16I As Object
	Dim S16I As Short
	Dim H16F, M16F As Object
	Dim S16F As Short
	Dim Inicio16 As Object
	Dim Final16 As Integer
	
	Dim HC, MC As Object
	Dim SC As Short
	Dim HC16, MC16 As Object
	Dim SC16 As Short
	Dim H, M As Object
	Dim S As Short
	Dim Final As Object
	Dim FinalCanal16 As Integer
	Dim HFinal, MFinal As Object
	Dim SFinal As Short
	Dim HFinal16, MFinal16 As Object
	Dim SFinal16 As Short
	Dim H16, M16 As Object
	Dim S16 As Short
	
	
	
	
	'HC MC SC hora, minutos y segundos de comienzo de todo el proceso,
	Private Sub CmdInicio_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdInicio.Click


        HFinal = CShort(HRT1.Text)
        MFinal = CShort(MRT1.Text)
        SFinal = CShort(SRT1.Text)

        'OUT1
        H1I = CShort(H1ITXT.Text)
        M1I = CShort(M1ITXT.Text)
        S1I = CShort(S1ITXT.Text)

        H1F = CShort(H1FTXT.Text)
        M1F = CShort(M1FTXT.Text)
        S1F = CShort(S1FTXT.Text)

        'OUT2
        H2I = CShort(H2ITXT.Text)
        M2I = CShort(M2ITXT.Text)
        S2I = CShort(S2ITXT.Text)

        H2F = CShort(H2FTXT.Text)
        M2F = CShort(M2FTXT.Text)
        S2F = CShort(S2FTXT.Text)

        'OUT3
        H3I = CShort(H3ITXT.Text)
        M3I = CShort(M3ITXT.Text)
        S3I = CShort(S3ITXT.Text)

        H3F = CShort(H3FTXT.Text)
        M3F = CShort(M3FTXT.Text)
        S3F = CShort(S3FTXT.Text)

        'OUT4
        H4I = CShort(H4ITXT.Text)
        M4I = CShort(M4ITXT.Text)
        S4I = CShort(S4ITXT.Text)

        H4F = CShort(H4FTXT.Text)
        M4F = CShort(M4FTXT.Text)
        S4F = CShort(S4FTXT.Text)

        'OUT5
        H5I = CShort(H5ITXT.Text)
        M5I = CShort(M5ITXT.Text)
        S5I = CShort(S5ITXT.Text)

        H5F = CShort(H5FTXT.Text)
        M5F = CShort(M5FTXT.Text)
        S5F = CShort(S5FTXT.Text)

        'OUT6
        H6I = CShort(H6ITXT.Text)
        M6I = CShort(M6ITXT.Text)
        S6I = CShort(S6ITXT.Text)

        H6F = CShort(H6FTXT.Text)
        M6F = CShort(M6FTXT.Text)
        S6F = CShort(S6FTXT.Text)

        'OUT7
        H7I = CShort(H7ITXT.Text)
        M7I = CShort(M7ITXT.Text)
        S7I = CShort(S7ITXT.Text)

        H7F = CShort(H7FTXT.Text)
        M7F = CShort(M7FTXT.Text)
        S7F = CShort(S7FTXT.Text)

        'OUT8
        H8I = CShort(H8ITXT.Text)
        M8I = CShort(M8ITXT.Text)
        S8I = CShort(S8ITXT.Text)

        H8F = CShort(H8FTXT.Text)
        M8F = CShort(M8FTXT.Text)
        S8F = CShort(S8FTXT.Text)

        'OUT9
        H9I = CShort(H9ITXT.Text)
        M9I = CShort(M9ITXT.Text)
        S9I = CShort(S9ITXT.Text)

        H9F = CShort(H9FTXT.Text)
        M9F = CShort(M9FTXT.Text)
        S9F = CShort(S9FTXT.Text)

        'OUT10
        H10I = CShort(H10ITXT.Text)
        M10I = CShort(M10ITXT.Text)
        S10I = CShort(S10ITXT.Text)

        H10F = CShort(H10FTXT.Text)
        M10F = CShort(M10FTXT.Text)
        S10F = CShort(S10FTXT.Text)

        'OUT11
        H11I = CShort(H11ITXT.Text)
        M11I = CShort(M11ITXT.Text)
        S11I = CShort(S11ITXT.Text)

        H11F = CShort(H11FTXT.Text)
        M11F = CShort(M11FTXT.Text)
        S11F = CShort(S11FTXT.Text)

        'OUT12
        H12I = CShort(H12ITXT.Text)
        M12I = CShort(M12ITXT.Text)
        S12I = CShort(S12ITXT.Text)

        H12F = CShort(H12FTXT.Text)
        M12F = CShort(M12FTXT.Text)
        S12F = CShort(S12FTXT.Text)

        'OUT13
        H13I = CShort(H13ITXT.Text)
        M13I = CShort(M13ITXT.Text)
        S13I = CShort(S13ITXT.Text)

        H13F = CShort(H13FTXT.Text)
        M13F = CShort(M13FTXT.Text)
        S13F = CShort(S13FTXT.Text)

        'OUT14
        H14I = CShort(H14ITXT.Text)
        M14I = CShort(M14ITXT.Text)
        S14I = CShort(S14ITXT.Text)

        H14F = CShort(H14FTXT.Text)
        M14F = CShort(M14FTXT.Text)
        S14F = CShort(S14FTXT.Text)

        'OUT15
        H15I = CShort(H15ITXT.Text)
        M15I = CShort(M15ITXT.Text)
        S15I = CShort(S15ITXT.Text)

        H15F = CShort(H15FTXT.Text)
        M15F = CShort(M15FTXT.Text)
        S15F = CShort(S15FTXT.Text)
		
		
        HC = Hour(TimeOfDay)
        MC = Minute(TimeOfDay)
		SC = Second(TimeOfDay)
		
        Final = (HFinal + HC) * 3600 + (MFinal + MC) * 60 + (SFinal + SC)

        Inicio1 = (H1I + HC) * 3600 + (M1I + MC) * 60 + (S1I + SC)
        Final1 = (H1F + HC) * 3600 + (M1F + MC) * 60 + (S1F + SC)

        Inicio2 = (H2I + HC) * 3600 + (M2I + MC) * 60 + (S2I + SC)
        Final2 = (H2F + HC) * 3600 + (M2F + MC) * 60 + (S2F + SC)

        Inicio3 = (H3I + HC) * 3600 + (M3I + MC) * 60 + (S3I + SC)
        Final3 = (H3F + HC) * 3600 + (M3F + MC) * 60 + (S3F + SC)

        Inicio4 = (H4I + HC) * 3600 + (M4I + MC) * 60 + (S4I + SC)
        Final4 = (H4F + HC) * 3600 + (M4F + MC) * 60 + (S4F + SC)

        Inicio5 = (H5I + HC) * 3600 + (M5I + MC) * 60 + (S5I + SC)
        Final5 = (H5F + HC) * 3600 + (M5F + MC) * 60 + (S5F + SC)

        Inicio6 = (H6I + HC) * 3600 + (M6I + MC) * 60 + (S6I + SC)
        Final6 = (H6F + HC) * 3600 + (M6F + MC) * 60 + (S6F + SC)

        Inicio7 = (H7I + HC) * 3600 + (M7I + MC) * 60 + (S7I + SC)
        Final7 = (H7F + HC) * 3600 + (M7F + MC) * 60 + (S7F + SC)

        Inicio8 = (H8I + HC) * 3600 + (M8I + MC) * 60 + (S8I + SC)
        Final8 = (H8F + HC) * 3600 + (M8F + MC) * 60 + (S8F + SC)

        Inicio9 = (H9I + HC) * 3600 + (M9I + MC) * 60 + (S9I + SC)
        Final9 = (H9F + HC) * 3600 + (M9F + MC) * 60 + (S9F + SC)

        Inicio10 = (H10I + HC) * 3600 + (M10I + MC) * 60 + (S10I + SC)
        Final10 = (H10F + HC) * 3600 + (M10F + MC) * 60 + (S10F + SC)

        Inicio11 = (H11I + HC) * 3600 + (M11I + MC) * 60 + (S11I + SC)
        Final11 = (H11F + HC) * 3600 + (M11F + MC) * 60 + (S11F + SC)

        Inicio12 = (H12I + HC) * 3600 + (M12I + MC) * 60 + (S12I + SC)
        Final12 = (H12F + HC) * 3600 + (M12F + MC) * 60 + (S12F + SC)

        Inicio13 = (H13I + HC) * 3600 + (M13I + MC) * 60 + (S13I + SC)
        Final13 = (H13F + HC) * 3600 + (M13F + MC) * 60 + (S13F + SC)

        Inicio14 = (H14I + HC) * 3600 + (M14I + MC) * 60 + (S14I + SC)
        Final14 = (H14F + HC) * 3600 + (M14F + MC) * 60 + (S14F + SC)

        Inicio15 = (H15I + HC) * 3600 + (M15I + MC) * 60 + (S15I + SC)
        Final15 = (H15F + HC) * 3600 + (M15F + MC) * 60 + (S15F + SC)

		
		
		HCtxt.Text = CStr(TimeOfDay)
        Timer1.Enabled = True
        'desactivo el boton de inicio del timer2
        CmdInicio2.Enabled = False
        'compruebo si el timer 2 esta ya iniciado
        If Timer2.Enabled = False Then
            parametrostimer2()
        End If
        'inicio el sonido
        WindowsMediaPlayer1.URL = ("C:\belen.mp3")
		
		
		
	End Sub
	
	Private Sub CmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStop.Click
        'Todos los timers los paramos
        Timer1.Enabled = False
        Timer2.Enabled = False
        WindowsMediaPlayer1.close()
        'todos los botones de los timers, inicio activados y Fin la desactivados 
        CmdInicio2.Enabled = True
        CmdStop2.Enabled = False
        'apagamos todas las salidas que se encuentren encendidas
        ClearAllIO()
        'apagamos todos los leds
        Led1.Visible = False
        Led2.Visible = False
        Led3.Visible = False
        Led4.Visible = False
        Led5.Visible = False
        Led6.Visible = False
        Led7.Visible = False
        Led8.Visible = False
        Led9.Visible = False
        Led10.Visible = False
        Led11.Visible = False
        Led12.Visible = False
        Led13.Visible = False
        Led14.Visible = False
        Led15.Visible = False
        Led16.Visible = False
	End Sub
	
    Private Sub CmdInicio2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdInicio2.Click
        parametrostimer2()
        CmdStop2.Enabled = True

    End Sub

    Private Sub CmdStop2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStop2.Click
        CmdInicio2.Enabled = True
        Timer2.Enabled = False
        Led16.Visible = False
        ClearIOchannel(16)
    End Sub

    Private Sub temporizador_belen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call main_Renamed()
        SelectI2CprinterPort(1)
        ConfigAllIOasOutput()
        'Compruebo que el fichero c:\k8000.dat exista

        Dim sContent As String = vbNullString
        Dim Cadena As String = vbNullString
        Dim Aux2 As String
        'inicializo Aux2 a 0 porque sino me da error
        Aux2 = 0
        'contador para el bocle for

        Try

            Dim SPath As String = "C:\k8000.dat"
            With My.Computer.FileSystem
                ' verifica si existe el path   
                If .FileExists(SPath) Then
                    'lee todo el contenido y asignamos los valores del fichero a los cajones de texto de la interface.  
                    sContent = .ReadAllText(SPath)
                    'sContent contiene todo el fichero
                    'MsgBox(sContent.ToString, MsgBoxStyle.Information, "Datos del Fichero")
                    Cadena = sContent.ToCharArray()
                    'MsgBox(Len(sContent), MsgBoxStyle.Information, "Longitud del Fichero")


                    'OUT1
                    H1ITXT.Text = Cadena(7) + Cadena(8)
                    M1ITXT.Text = Cadena(10) + Cadena(11)
                    S1ITXT.Text = Cadena(13) + Cadena(14)

                    H1FTXT.Text = Cadena(24) + Cadena(25)
                    M1FTXT.Text = Cadena(27) + Cadena(28)
                    S1FTXT.Text = Cadena(30) + Cadena(31)

                    'OUT2
                    H2ITXT.Text = Cadena(41) + Cadena(42)
                    M2ITXT.Text = Cadena(44) + Cadena(45)
                    S2ITXT.Text = Cadena(47) + Cadena(48)

                    H2FTXT.Text = Cadena(58) + Cadena(59)
                    M2FTXT.Text = Cadena(61) + Cadena(62)
                    S2FTXT.Text = Cadena(64) + Cadena(65)

                    'OUT3
                    H3ITXT.Text = Cadena(75) + Cadena(76)
                    M3ITXT.Text = Cadena(78) + Cadena(79)
                    S3ITXT.Text = Cadena(81) + Cadena(82)

                    H3FTXT.Text = Cadena(92) + Cadena(93)
                    M3FTXT.Text = Cadena(95) + Cadena(96)
                    S3FTXT.Text = Cadena(98) + Cadena(99)

                    'OUT4
                    H4ITXT.Text = Cadena(109) + Cadena(110)
                    M4ITXT.Text = Cadena(112) + Cadena(113)
                    S4ITXT.Text = Cadena(115) + Cadena(116)

                    H4FTXT.Text = Cadena(126) + Cadena(127)
                    M4FTXT.Text = Cadena(129) + Cadena(130)
                    S4FTXT.Text = Cadena(132) + Cadena(133)

                    'OUT5
                    H5ITXT.Text = Cadena(143) + Cadena(144)
                    M5ITXT.Text = Cadena(146) + Cadena(147)
                    S5ITXT.Text = Cadena(149) + Cadena(150)

                    H5FTXT.Text = Cadena(160) + Cadena(161)
                    M5FTXT.Text = Cadena(163) + Cadena(164)
                    S5FTXT.Text = Cadena(166) + Cadena(167)

                    'OUT6
                    H6ITXT.Text = Cadena(177) + Cadena(178)
                    M6ITXT.Text = Cadena(180) + Cadena(181)
                    S6ITXT.Text = Cadena(183) + Cadena(184)

                    H6FTXT.Text = Cadena(194) + Cadena(195)
                    M6FTXT.Text = Cadena(197) + Cadena(198)
                    S6FTXT.Text = Cadena(200) + Cadena(201)

                    'OUT7
                    H7ITXT.Text = Cadena(211) + Cadena(212)
                    M7ITXT.Text = Cadena(214) + Cadena(215)
                    S7ITXT.Text = Cadena(217) + Cadena(218)

                    H7FTXT.Text = Cadena(228) + Cadena(229)
                    M7FTXT.Text = Cadena(231) + Cadena(232)
                    S7FTXT.Text = Cadena(234) + Cadena(235)

                    'OUT8
                    H8ITXT.Text = Cadena(245) + Cadena(246)
                    M8ITXT.Text = Cadena(248) + Cadena(249)
                    S8ITXT.Text = Cadena(251) + Cadena(252)

                    H8FTXT.Text = Cadena(262) + Cadena(263)
                    M8FTXT.Text = Cadena(265) + Cadena(266)
                    S8FTXT.Text = Cadena(268) + Cadena(269)

                    'OUT9
                    H9ITXT.Text = Cadena(279) + Cadena(280)
                    M9ITXT.Text = Cadena(282) + Cadena(283)
                    S9ITXT.Text = Cadena(285) + Cadena(286)

                    H9FTXT.Text = Cadena(296) + Cadena(297)
                    M9FTXT.Text = Cadena(299) + Cadena(300)
                    S9FTXT.Text = Cadena(302) + Cadena(303)

                    'OUT10
                    H10ITXT.Text = Cadena(313) + Cadena(314)
                    M10ITXT.Text = Cadena(316) + Cadena(317)
                    S10ITXT.Text = Cadena(319) + Cadena(320)

                    H10FTXT.Text = Cadena(330) + Cadena(331)
                    M10FTXT.Text = Cadena(333) + Cadena(334)
                    S10FTXT.Text = Cadena(336) + Cadena(337)

                    'OUT11
                    H11ITXT.Text = Cadena(347) + Cadena(348)
                    M11ITXT.Text = Cadena(350) + Cadena(351)
                    S11ITXT.Text = Cadena(353) + Cadena(354)

                    H11FTXT.Text = Cadena(364) + Cadena(365)
                    M11FTXT.Text = Cadena(367) + Cadena(368)
                    S11FTXT.Text = Cadena(370) + Cadena(371)

                    'OUT12
                    H12ITXT.Text = Cadena(381) + Cadena(382)
                    M12ITXT.Text = Cadena(384) + Cadena(385)
                    S12ITXT.Text = Cadena(387) + Cadena(388)

                    H12FTXT.Text = Cadena(398) + Cadena(399)
                    M12FTXT.Text = Cadena(401) + Cadena(402)
                    S12FTXT.Text = Cadena(404) + Cadena(405)

                    'OUT13
                    H13ITXT.Text = Cadena(415) + Cadena(416)
                    M13ITXT.Text = Cadena(418) + Cadena(419)
                    S13ITXT.Text = Cadena(421) + Cadena(422)

                    H13FTXT.Text = Cadena(432) + Cadena(433)
                    M13FTXT.Text = Cadena(435) + Cadena(436)
                    S13FTXT.Text = Cadena(438) + Cadena(439)

                    'OUT14
                    H14ITXT.Text = Cadena(449) + Cadena(450)
                    M14ITXT.Text = Cadena(452) + Cadena(453)
                    S14ITXT.Text = Cadena(455) + Cadena(456)

                    H14FTXT.Text = Cadena(466) + Cadena(467)
                    M14FTXT.Text = Cadena(469) + Cadena(470)
                    S14FTXT.Text = Cadena(472) + Cadena(473)

                    'OUT15
                    H15ITXT.Text = Cadena(483) + Cadena(484)
                    M15ITXT.Text = Cadena(486) + Cadena(487)
                    S15ITXT.Text = Cadena(489) + Cadena(490)

                    H15FTXT.Text = Cadena(500) + Cadena(501)
                    M15FTXT.Text = Cadena(503) + Cadena(504)
                    S15FTXT.Text = Cadena(506) + Cadena(507)

                    'OUT16
                    H16ITXT.Text = Cadena(517) + Cadena(518)
                    M16ITXT.Text = Cadena(520) + Cadena(521)
                    S16ITXT.Text = Cadena(523) + Cadena(524)

                    H16FTXT.Text = Cadena(534) + Cadena(535)
                    M16FTXT.Text = Cadena(537) + Cadena(538)
                    S16FTXT.Text = Cadena(540) + Cadena(541)

                    'Repeticiones del ciclo temporizador 1
                    HRT1.Text = Cadena(551) + Cadena(552)
                    MRT1.Text = Cadena(554) + Cadena(555)
                    SRT1.Text = Cadena(557) + Cadena(558)
                    'Repeticiones del ciclo temporizador 2
                    HRT2.Text = Cadena(568) + Cadena(569)
                    MRT2.Text = Cadena(571) + Cadena(572)
                    SRT2.Text = Cadena(574) + Cadena(575)

                Else
                    'Asignamos el valor 0 a todos los cajones de texto de la Interface.
                    MsgBox("El fichero C:/K8000.dat no existe. Todos los tiempos se pondran a 0", MsgBoxStyle.Information, "Advertencia")
                End If
            End With
            ' errores   
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form_Terminate_Renamed()
        ClearAllDA()
        ClearAllDAC()
        ClearAllIO()
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000

        H = Hour(TimeOfDay) - HC
        M = Minute(TimeOfDay) - MC
        S = Second(TimeOfDay) - SC


        HActualTxt.Text = CStr(TimeSerial(H, M, S))


        If Inicio1 < VB.Timer() And Final1 > VB.Timer() Then
            Led1.Visible = True
            SetIOchannel(1)
        Else
            Led1.Visible = False
            ClearIOchannel(1)
        End If


        If Inicio2 < VB.Timer() And Final2 > VB.Timer() Then
            Led2.Visible = True
            SetIOchannel(2)
        Else
            Led2.Visible = False
            ClearIOchannel(2)
        End If


        If Inicio3 < VB.Timer() And Final3 > VB.Timer() Then
            Led3.Visible = True
            SetIOchannel(3)
        Else
            Led3.Visible = False
            ClearIOchannel(3)
        End If


        If Inicio4 < VB.Timer() And Final4 > VB.Timer() Then
            Led4.Visible = True
            SetIOchannel(4)
        Else
            ClearIOchannel(4)
            Led4.Visible = False
        End If


        If Inicio5 < VB.Timer() And Final5 > VB.Timer() Then
            Led5.Visible = True
            SetIOchannel(5)
        Else
            ClearIOchannel(5)
            Led5.Visible = False
        End If


        If Inicio6 < VB.Timer() And Final6 > VB.Timer() Then
            Led6.Visible = True
            SetIOchannel(6)
        Else
            ClearIOchannel(6)
            Led6.Visible = False
        End If


        If Inicio7 < VB.Timer() And Final7 > VB.Timer() Then
            Led7.Visible = True
            SetIOchannel(7)
        Else
            ClearIOchannel(7)
            Led7.Visible = False
        End If



        If Inicio8 < VB.Timer() And Final8 > VB.Timer() Then
            Led8.Visible = True
            SetIOchannel(8)
        Else
            ClearIOchannel(8)
            Led8.Visible = False
        End If


        If Inicio9 < VB.Timer() And Final9 > VB.Timer() Then
            Led9.Visible = True
            SetIOchannel(9)
        Else
            ClearIOchannel(9)
            Led9.Visible = False
        End If


        If Inicio10 < VB.Timer() And Final10 > VB.Timer() Then
            Led10.Visible = True
            SetIOchannel(10)
        Else
            ClearIOchannel(10)
            Led10.Visible = False
        End If


        If Inicio11 < VB.Timer() And Final11 > VB.Timer() Then
            Led11.Visible = True
            SetIOchannel(11)
        Else
            ClearIOchannel(11)
            Led11.Visible = False
        End If


        If Inicio12 < VB.Timer() And Final12 > VB.Timer() Then
            Led12.Visible = True
            SetIOchannel(12)
        Else
            ClearIOchannel(12)
            Led12.Visible = False
        End If


        If Inicio13 < VB.Timer() And Final13 > VB.Timer() Then
            Led13.Visible = True
            SetIOchannel(13)
        Else
            ClearIOchannel(13)
            Led13.Visible = False
        End If


        If Inicio14 < VB.Timer() And Final14 > VB.Timer() Then
            Led14.Visible = True
            SetIOchannel(14)
        Else
            ClearIOchannel(14)
            Led14.Visible = False
        End If


        If Inicio15 < VB.Timer() And Final15 > VB.Timer() Then
            Led15.Visible = True
            SetIOchannel(15)
        Else
            ClearIOchannel(15)
            Led15.Visible = False
        End If


        If Final < VB.Timer() Then
            CmdInicio.PerformClick()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        'intervalo del timer
        Timer2.Interval = 1000

        H16 = Hour(TimeOfDay) - HC16
        M16 = Minute(TimeOfDay) - MC16
        S16 = Second(TimeOfDay) - SC16


        Text5.Text = CStr(TimeSerial(H16, M16, S16))


        If Inicio16 < VB.Timer() And Final16 > VB.Timer() Then
            Led16.Visible = True
            SetIOchannel(16)
        Else
            ClearIOchannel(16)
            Led16.Visible = False
        End If

        If FinalCanal16 < VB.Timer() Then
            'CmdInicio2.PerformClick()
            parametrostimer2()
        End If
    End Sub

    Sub parametrostimer2()

        HFinal16 = CShort(HRT2.Text)
        MFinal16 = CShort(MRT2.Text)
        SFinal16 = CShort(SRT2.Text)


        H16I = CShort(H16ITXT.Text)
        M16I = CShort(M16ITXT.Text)
        S16I = CShort(S16ITXT.Text)


        H16F = CShort(H16FTXT.Text)
        M16F = CShort(M16FTXT.Text)
        S16F = CShort(S16FTXT.Text)


        HC16 = Hour(TimeOfDay)
        MC16 = Minute(TimeOfDay)
        SC16 = Second(TimeOfDay)


        FinalCanal16 = (HFinal16 + HC16) * 3600 + (MFinal16 + MC16) * 60 + (SFinal16 + SC16)


        Inicio16 = (H16I + HC16) * 3600 + (M16I + MC16) * 60 + (S16I + SC16)
        Final16 = (H16F + HC16) * 3600 + (M16F + MC16) * 60 + (S16F + SC16)

        hc16txt.Text = CStr(TimeOfDay)
        Timer2.Enabled = True

    End Sub
End Class