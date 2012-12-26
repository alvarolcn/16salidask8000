Option Strict Off
Option Explicit On
Module routines
	'function and sub for parallel port data access
	'Use just like their QuickBasic Counterparts
	'Out port%,Value ----- or X% = Inp(Port%)
	
	
	Public Declare Function DlPortReadPortUshort Lib "dlportio.dll" (ByVal Port As Integer) As Short '  inp
	Public Declare Sub DlPortWritePortUshort Lib "dlportio.dll" (ByVal Port As Integer, ByVal Value As Short) ' out
	
	
	'COMMON USED GLOBALS AND VARIABELS
	Public Const MaxIOcard As Short = 3
	Public Const MaxIOchip As Short = 7
	Public Const MaxIOchannel As Short = 64
	Public Const MaxDACchannel As Short = 32
	Public Const MaxADchannel As Short = 16
	Public Const MaxDAchannel As Short = 4
	Public Const StartValue As Short = 0
	
	Public IOconfig(MaxIOchip) As Short
	Public IOdata(MaxIOchip) As Short
	Public IO(MaxIOchannel) As Short
	Public DAC(MaxDACchannel) As Short
	Public AD(MaxADchannel) As Short
	Public DA(MaxDAchannel) As Short
	
	Public ADDAchipCode(MaxIOcard) As Short
	Public DACchipCode(MaxIOcard) As Short
	Public IOChipCode(MaxIOchip) As Short
	
	Public Statusport As Short
	Public Controlport As Short
	Public I2Cbusdelay As Short
	
	Function BINNOT(ByRef Dec As Short) As Short
		Dim Temp, Complement As String
		Dim i As Short
		Temp = DecToBin(Dec)
		Complement = ""
		For i = 1 To Len(Temp)
			If Mid(Temp, i, 1) = "1" Then
				Complement = Complement & "0"
			Else
				Complement = Complement & "1"
			End If
		Next 
		BINNOT = BinToDec(Complement)
	End Function
	
	Function BinToDec(ByRef BinNumber As String) As Short
		Dim Weight As Short
		Dim Dec As Short
		Dim i As Short
		Weight = 1
		Dec = 0 'Reset decimal number
		
		If BinNumber <> "00000000" Then
			For i = Len(BinNumber) To 1 Step -1
				If Mid(BinNumber, i, 1) = "1" Then
					Dec = Dec + Weight 'If bit=1 then add weigth factor
				End If
				Weight = Weight * 2 'Multiply weight factor by 2
			Next 
			BinToDec = Dec 'Store result
		Else
			BinToDec = 0
		End If
	End Function
	
	Sub ClearAllDA()
		Dim ChannelNo As Short
		For ChannelNo = 1 To MaxDAchannel
			OutputDAchannel(ChannelNo, 0)
		Next 
	End Sub
	
	Sub ClearAllDAC()
		Dim ChannelNo As Short
		For ChannelNo = 1 To MaxDACchannel
			DAC(ChannelNo) = 0
		Next 
		UpdateAllDAC()
	End Sub
	
	Sub ClearAllIO()
		Dim ChipNo As Short
		For ChipNo = 0 To MaxIOchip
			IOoutput(ChipNo, 0)
		Next 
	End Sub
	
	Sub ClearDACchannel(ByRef ChannelNo As Short)
		OutputDACchannel(ChannelNo, 0)
	End Sub
	
	Sub ClearDACchip(ByRef ChipNo As Short)
		Dim Channel, i As Short
		Channel = ChipNo * 8
		For i = 1 To 8
			DAC(Channel + i) = 0
		Next 
		UpdateDACchip(ChipNo)
	End Sub
	
	Sub ClearDAchannel(ByRef ChannelNo As Short)
		OutputDAchannel(ChannelNo, 0)
	End Sub
	
	Sub ClearIOchannel(ByRef ChannelNo As Short)
		Dim Channel As Short
		Dim Datavar, ChipNo As Short
		ChipNo = (ChannelNo - 1) \ 8
		Channel = (ChannelNo - 1) Mod 8
		Datavar = IOdata(ChipNo) And BINNOT(SHL(1, Channel))
		IOoutput(ChipNo, Datavar)
	End Sub
	
	Sub ClearIOchArray(ByRef ChannelNo As Short)
		Dim Channel As Short
		Dim Datavar, ChipNo As Short
		ChipNo = (ChannelNo - 1) \ 8
		Channel = (ChannelNo - 1) Mod 8
		Datavar = IOdata(ChipNo) And BINNOT(SHL(1, Channel))
		UpdateIOdataArray(ChipNo, Datavar)
	End Sub
	
	Sub ClearIOChip(ByRef ChipNo As Short)
		IOoutput(ChipNo, 0)
	End Sub
	
	Sub ClearIOdataArray(ByRef ChipNo As Short)
		Dim StartChannel As Short
		Dim Temp As Short
		Dim Datavar As String
		Dim Channel As Short
		'Update IOdata array
		IOdata(ChipNo) = IOdata(ChipNo) And IOconfig(ChipNo)
		
		'Update IO array
		StartChannel = ChipNo * 8 + 1
		Temp = IOdata(ChipNo)
		Datavar = DecToBin(Temp)
		For Channel = 0 To 7
			If Mid(Datavar, 8 - Channel, 1) = "1" Then
				IO(StartChannel + Channel) = 1
			Else
				IO(StartChannel + Channel) = 0
			End If
		Next 
	End Sub
	
	' IO CONFIGURATION SUBROUTINES
	Sub ConfigAllIOasInput()
		Dim ChipNo As Short
		For ChipNo = 0 To MaxIOchip
			IOconfig(ChipNo) = 0
			ClearIOChip(ChipNo)
			IOconfig(ChipNo) = 255
			ReadIOchip(ChipNo)
		Next 
	End Sub
	
	Sub ConfigAllIOasOutput()
		Dim ChipNo As Short
		For ChipNo = 0 To MaxIOchip
			IOconfig(ChipNo) = 0
		Next 
		ClearAllIO()
	End Sub
	
	Sub ConfigIOChannelAsInput(ByRef ChannelNo As Short)
		Dim Channel, ChipNo As Short
		ChipNo = (ChannelNo - 1) \ 8
		Channel = (ChannelNo - 1) Mod 8
		IOconfig(ChipNo) = IOconfig(ChipNo) And BINNOT(SHL(1, Channel))
		ClearIOchannel(ChannelNo)
		IOconfig(ChipNo) = IOconfig(ChipNo) Or SHL(1, Channel)
		ReadIOchannel(ChannelNo)
	End Sub
	
	Sub ConfigIOchannelAsOutput(ByRef ChannelNo As Short)
		Dim Channel, ChipNo As Short
		ChipNo = (ChannelNo - 1) \ 8
		Channel = (ChannelNo - 1) Mod 8
		IOconfig(ChipNo) = IOconfig(ChipNo) And BINNOT(SHL(1, Channel))
		ClearIOchannel(ChannelNo)
	End Sub
	
	Sub ConfigIOchipAsInput(ByRef ChipNo As Short)
		IOconfig(ChipNo) = 0
		ClearIOChip(ChipNo)
		IOconfig(ChipNo) = 255
		ReadIOchip(ChipNo)
	End Sub
	
	Sub ConfigIOchipAsOutput(ByRef ChipNo As Short)
		IOconfig(ChipNo) = 0
		ClearIOChip(ChipNo)
	End Sub
	
	Function DecTo7seg(ByRef Decnumber As Short) As Short
		' Zet een Decimaal getal van 0..9 om in een 7-segment
		' tegenwaarde voor sturing van een 7 segment display
		' via I2C-bus
		
		Dim Temp As Short
		Select Case Decnumber
			Case 0
				Temp = 63
			Case 1
				Temp = 6
			Case 2
				Temp = 91
			Case 3
				Temp = 79
			Case 4
				Temp = 102
			Case 5
				Temp = 109
			Case 6
				Temp = 125
			Case 7
				Temp = 7
			Case 8
				Temp = 127
			Case 9
				Temp = 111
		End Select
		DecTo7seg = Temp
	End Function
	
	' RADIX CONVERSION SUBROUTINES
	Function DecToBin(ByRef Decnumber As Short) As String
		'Conversion of decimal number (0...255) to 8 bit binary string.
		'--------------------------------------------------------------
		Dim Bin As String
		Dim Faktor, i As Short
		
		Bin = ""
		Faktor = 128
		
		If Decnumber <> 0 Then
			For i = 1 To 8
				If Faktor > Decnumber Then
					Bin = Bin & "0"
				Else
					Bin = Bin & "1"
					Decnumber = Decnumber - Faktor
				End If
				Faktor = Faktor \ 2
			Next 
			DecToBin = Bin
		Else
			DecToBin = "00000000"
		End If
	End Function
	
	Function DecToHex(ByRef Decnumber As Short) As String
		DecToHex = Hex(Decnumber)
	End Function
	
	Function HexToDec(ByRef Hexnumber As String) As Short
		Dim StrLength As Short
		Dim decl As Short
		Dim dech As Short
		
        'Dim StrLenght As Short
		StrLength = 0
		decl = 0
		dech = 0
		Hexnumber = UCase(Hexnumber)
		StrLength = Len(Hexnumber)
		decl = Asc(Mid(Hexnumber, StrLength, 1))
		If decl >= Asc("A") Then
			decl = decl - Asc("A") + 10
		Else
			decl = decl - Asc("0")
		End If
		If StrLength = 2 Then
			dech = Asc(Mid(Hexnumber, 1, 1)) 'Convert most significant digit
			If dech > Asc("A") Then 'Digit > 9 subtract offset A...F
				dech = dech - Asc("A") + 10
			Else
				dech = dech - Asc("0")
			End If
		End If
		HexToDec = 16 * dech + decl
	End Function
	
	Sub I2CBusNotBusy()
		Dim i As Short
		DlPortWritePortUshort(Controlport, 4)
		For i = 0 To I2Cbusdelay
		Next 
		
	End Sub
	
	Sub I2Cclockpulse()
		' Veroorzaak een look-alike Ack-puls op I2C-bus
		Dim i As Short
		DlPortWritePortUshort(Controlport, 12)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 4)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 12)
		For i = 0 To I2Cbusdelay
		Next 
	End Sub
	
	Sub I2CInit()
		SelectI2CprinterPort(1)
		I2Cbusdelay = 1
		I2CBusNotBusy()
		ConfigAllIOasInput()
		ClearAllDAC()
		ClearAllDA()
		ReadAll()
	End Sub
	
	Function I2CInput() As Short
		Dim Serdata As Short
		Dim j, i As Short
		Dim Inputdata As Short
		Serdata = 0
		For j = 1 To 8
			Serdata = SHL(Serdata, 1)
			DlPortWritePortUshort(Controlport, 4)
			For i = 0 To I2Cbusdelay
			Next 
			
			Inputdata = DlPortReadPortUshort(Statusport) And 16
			If Inputdata <> 0 Then
				Serdata = Serdata Or 1
			End If
			
			DlPortWritePortUshort(Controlport, 12)
			For i = 0 To I2Cbusdelay
			Next 
		Next 
		I2CInput = Serdata
	End Function
	
	Sub I2Cmasterclockpulse()
		Dim i As Short
		DlPortWritePortUshort(Controlport, 14)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 6)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 14)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 12)
		For i = 0 To I2Cbusdelay
		Next 
	End Sub
	
	Sub I2COutput(ByRef Serdata As Short)
		Dim Temp As Short
		Dim Serdat As String
		Dim j As Short
		Dim DataOut As Short
		Dim i As Short
		Temp = Serdata
		Serdat = DecToBin(Temp)
		
		For j = 1 To 8
			
			If Mid(Serdat, j, 1) = "1" Then
				DataOut = 12
			Else
				DataOut = 14
			End If
			DlPortWritePortUshort(Controlport, DataOut)
			For i = 0 To I2Cbusdelay
			Next 
			
			DataOut = DlPortReadPortUshort(Controlport) And 7
			DlPortWritePortUshort(Controlport, DataOut)
			For i = 0 To I2Cbusdelay
			Next 
			
			DataOut = DlPortReadPortUshort(Controlport) Or 8
			DlPortWritePortUshort(Controlport, DataOut)
			For i = 0 To I2Cbusdelay
			Next 
		Next 
	End Sub
	
	Sub I2Cstart()
		Dim i As Short
		DlPortWritePortUshort(Controlport, 6)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 14)
		For i = 0 To I2Cbusdelay
		Next 
	End Sub
	
	Sub I2CStop()
		Dim i As Short
		DlPortWritePortUshort(Controlport, 14)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 6)
		For i = 0 To I2Cbusdelay
		Next 
		
		DlPortWritePortUshort(Controlport, 4)
		For i = 0 To I2Cbusdelay
		Next 
	End Sub
	
	Sub init()
		' Initialiseerd de I2C Bus
		Dim i As Short
		DlPortWritePortUshort(Controlport, 4)
		For i = 0 To I2Cbusdelay
		Next 
		
	End Sub
	
	' OUTPUT SUBROUTINES
	Sub IOoutput(ByRef ChipNo As Short, ByRef Datavar As Short)
		Dim Temp As Short
		Dim StartChannel, Channel As Short
		Dim Datvar As String
		Temp = Datavar
		Datavar = BINNOT(Temp) Or IOconfig(ChipNo)
		
		I2Cstart()
		
		Temp = IOChipCode(ChipNo)
		I2COutput(Temp)
		
		I2Cclockpulse()
		
		Temp = Datavar
		I2COutput(Temp)
		
		I2Cclockpulse()
		
		I2CStop()
		
		IOdata(ChipNo) = (IOdata(ChipNo) And IOconfig(ChipNo)) Or BINNOT(Datavar)
		
		
		StartChannel = ChipNo * 8 + 1
		Temp = IOdata(ChipNo)
		Datvar = DecToBin(Temp)
		For Channel = 0 To 7
			If Mid(Datvar, 8 - Channel, 1) = "1" Then
				IO(StartChannel + Channel) = 1
			Else
				IO(StartChannel + Channel) = 0
			End If
		Next 
	End Sub
	
	'UPGRADE_NOTE: main se actualizó a main_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Sub main_Renamed()
		Dim CardNo As Short
		Dim ChipNo As Short
		For CardNo = 0 To MaxIOcard
			DACchipCode(CardNo) = 64 + 2 * CardNo
			ADDAchipCode(CardNo) = 144 + 2 * CardNo
		Next 
		
		For ChipNo = 0 To MaxIOchip
			IOChipCode(ChipNo) = 112 + 2 * ChipNo
		Next 
		
		I2CInit()
		
	End Sub
	
	' 6 BIT DAC CONVERTER SUBROUTINES
	Sub OutputDACchannel(ByRef ChannelNo As Short, ByRef Datavar As Short)
		Dim Serdata As Short
		If Datavar > 63 Then
			Datavar = 63
		End If
		DAC(ChannelNo) = Datavar
		
		I2Cstart()
		
		Serdata = DACchipCode((ChannelNo - 1) \ 8)
		I2COutput(Serdata)
		
		I2Cclockpulse()
		
		Serdata = 240 Or ((ChannelNo - 1) Mod 8)
		I2COutput(Serdata)
		
		I2Cclockpulse()
		
		I2COutput(Datavar)
		
		I2Cclockpulse()
		
		I2CStop()
	End Sub
	
	' 8 BIT DA CONVERTER SUBROUTINES
	Sub OutputDAchannel(ByRef ChannelNo As Short, ByRef Datavar As Short)
		Dim Temp As Short
		DA(ChannelNo) = Datavar
		I2Cstart()
		
		Temp = ADDAchipCode(ChannelNo - 1)
		I2COutput(Temp)
		
		I2Cclockpulse()
		
		I2COutput(64)
		
		I2Cclockpulse()
		
		I2COutput(Datavar)
		
		I2Cclockpulse()
		
		I2CStop()
	End Sub
	
	'8 BIT AD CONVERTER SUBROUTINES
	Sub ReadADchannel(ByRef ChannelNo As Short)
		Dim ChipCode, Serdata As Short
		ChipCode = ADDAchipCode((ChannelNo - 1) \ 4)
		
		I2Cstart()
		
		I2COutput(ChipCode)
		
		I2Cclockpulse()
		
		Serdata = 64 Or ((ChannelNo - 1) Mod 4)
		I2COutput(Serdata)
		
		I2Cclockpulse()
		
		I2CStop()
		
		I2Cstart()
		
		Serdata = ChipCode Or 1
		I2COutput(Serdata)
		
		I2Cclockpulse()
		
		AD(ChannelNo) = I2CInput()
		
		I2Cmasterclockpulse()
		
		AD(ChannelNo) = I2CInput()
		
		I2Cclockpulse()
		
		I2CStop()
	End Sub
	
	Sub ReadADchip(ByRef ChipNo As Short)
		Dim Serdata, Channel, Temp, k As Short
		Channel = ChipNo * 4 + 1
		
		I2Cstart()
		
		Temp = ADDAchipCode(ChipNo)
		I2COutput(Temp)
		
		I2Cclockpulse()
		
		I2COutput(68)
		
		I2Cclockpulse()
		
		I2CStop()
		
		I2Cstart()
		
		Temp = ADDAchipCode(ChipNo) Or 1
		I2COutput(Temp)
		
		I2Cclockpulse()
		
		Serdata = I2CInput()
		
		For k = 0 To 3
			I2Cmasterclockpulse()
			Serdata = I2CInput()
			AD(Channel + k) = Serdata
		Next 
		
		I2Cclockpulse()
		
		I2CStop()
	End Sub
	
	'GENERAL SUBROUTINES
	Sub ReadAll()
		ReadAllIO()
		ReadAllAD()
	End Sub
	
	Sub ReadAllAD()
		Dim CardNo As Short
        'Dim ard As Object
		For CardNo = 0 To MaxIOcard
			ReadADchip(CardNo)
		Next 
	End Sub
	
	Sub ReadAllIO()
		Dim ChipNo As Short
		For ChipNo = 0 To MaxIOchip
			ReadIOchip(ChipNo)
		Next 
	End Sub
	
	Sub ReadCard(ByRef CardNo As Short)
		Dim ChipNo As Short
		ChipNo = CardNo * 2
		ReadIOchip(ChipNo)
		ReadIOchip(ChipNo + 1)
		ReadADchip(CardNo)
	End Sub
	
	Sub ReadIOchannel(ByRef ChannelNo As Short)
		Dim ChipNo As Short
		ChipNo = (ChannelNo - 1) \ 8
		ReadIOchip(ChipNo)
	End Sub
	
	' INPUT SUBROUTINES
	Sub ReadIOchip(ByRef ChipNo As Short)
		Dim Temp, Datavar, StartChannel, Channel As Short
		Dim Datvar As String
		I2Cstart()
		
		Datavar = IOChipCode(ChipNo) Or 1
		I2COutput(Datavar)
		
		I2Cclockpulse()
		
		IOdata(ChipNo) = I2CInput()
		IOdata(ChipNo) = BINNOT(IOdata(ChipNo))
		I2Cclockpulse()
		
		I2CStop()
		
		StartChannel = ChipNo * 8 + 1
		Temp = IOdata(ChipNo)
		Datvar = DecToBin(Temp)
		For Channel = 0 To 7
			If Mid(Datvar, 8 - Channel, 1) = "1" Then
				IO(StartChannel + Channel) = 1
			Else
				IO(StartChannel + Channel) = 0
			End If
		Next 
	End Sub
	
	Sub SelectI2CprinterPort(ByRef PrinterNo As Short)
		Select Case PrinterNo
			Case 0
				Statusport = 957
				Controlport = 958
			Case 1
				Statusport = 889
				Controlport = 890
			Case 2
				Statusport = 633
				Controlport = 634
		End Select
	End Sub
	
	Sub SetAllDA()
		Dim ChannelNo As Short
		For ChannelNo = 1 To MaxDAchannel
			OutputDAchannel(ChannelNo, 255)
		Next 
	End Sub
	
	Sub SetAllDAC()
		Dim ChannelNo As Short
		For ChannelNo = 1 To MaxDACchannel
			DAC(ChannelNo) = 63
		Next 
		UpdateAllDAC()
	End Sub
	
	Sub SetAllIO()
		Dim ChipNo As Short
		For ChipNo = 0 To MaxIOchip
			IOoutput(ChipNo, 255)
		Next 
	End Sub
	
	Sub SetDACchannel(ByRef ChannelNo As Short)
		OutputDACchannel(ChannelNo, 63)
	End Sub
	
	Sub SetDACchip(ByRef ChipNo As Short)
		Dim Channel, i As Short
		Channel = ChipNo * 8
		For i = 1 To 8
			DAC(Channel + i) = 63
		Next 
		UpdateDACchip(ChipNo)
	End Sub
	
	Sub SetDAchannel(ByRef ChannelNo As Short)
		OutputDAchannel(ChannelNo, 255)
	End Sub
	
	Sub SetIOchannel(ByRef ChannelNo As Short)
		Dim Channel, ChipNo, Datavar As Short
		ChipNo = (ChannelNo - 1) \ 8
		Channel = (ChannelNo - 1) Mod 8
		Datavar = SHL(1, Channel) Or IOdata(ChipNo)
		IOoutput(ChipNo, Datavar)
	End Sub
	
	Sub SetIOchArray(ByRef ChannelNo As Short)
		Dim Channel, ChipNo, Datavar As Short
		ChipNo = (ChannelNo - 1) \ 8
		Channel = (ChannelNo - 1) Mod 8
		Datavar = IOdata(ChipNo) Or SHL(1, Channel)
		UpdateIOdataArray(ChipNo, Datavar)
	End Sub
	
	Sub SetIOchip(ByRef ChipNo As Short)
		IOoutput(ChipNo, 255)
	End Sub
	
	Sub SetIOdataArray(ByRef ChipNo As Short)
		Dim StartChannel, Temp, Channel As Short
		Dim Datvar As String
		' Update IOdata array
		Temp = IOconfig(ChipNo)
		IOdata(ChipNo) = IOdata(ChipNo) Or (BINNOT(Temp))
		
		' Updata IO array
		StartChannel = ChipNo * 8 + 1
		Temp = IOdata(ChipNo)
		Datvar = DecToBin(Temp)
		For Channel = 0 To 7
			If Mid(Datvar, 8 - Channel, 1) = "1" Then
				IO(StartChannel + Channel) = 1
			Else
				IO(StartChannel + Channel) = 0
			End If
		Next 
	End Sub
	
	Function SHL(ByRef Dec As Short, ByRef Positions As Short) As Short
		Dim Temp As String
		Temp = Right(DecToBin(Dec) & New String("0", Positions), 8)
		SHL = BinToDec(Temp)
	End Function
	
	Sub UpdateAll()
		UpdateAllIO()
		UpdateAllDAC()
		UpdateAllDA()
	End Sub
	
	Sub UpdateAllDA()
		Dim ChannelNo, Temp As Short
		For ChannelNo = 1 To MaxDAchannel
			Temp = DA(ChannelNo)
			OutputDAchannel(ChannelNo, Temp)
		Next 
	End Sub
	
	Sub UpdateAllDAC()
		Dim CardNo As Short
		For CardNo = 0 To MaxIOcard
			UpdateDACchip(CardNo)
		Next 
	End Sub
	
	Sub UpdateAllIO()
		Dim ChipNo, Temp As Short
		For ChipNo = 0 To MaxIOchip
			Temp = IOdata(ChipNo)
			IOoutput(ChipNo, Temp)
		Next 
	End Sub
	
	Sub UpdateCard(ByRef CardNo As Short)
		Dim ChipNo As Short
		ChipNo = CardNo * 2
		UpdateIOchip(ChipNo)
		UpdateIOchip(ChipNo + 1)
		UpdateDACchip(CardNo)
		UpdateDAchannel(CardNo + 1)
	End Sub
	
	Sub UpdateDACchannel(ByRef ChannelNo As Short)
		Dim Temp As Short
		Temp = DAC(ChannelNo)
		OutputDACchannel(ChannelNo, Temp)
	End Sub
	
	Sub UpdateDACchip(ByRef ChipNo As Short)
		Dim k, Serdata, Channel, Temp As Short
		I2Cstart()
		
		Serdata = DACchipCode(ChipNo)
		I2COutput(Serdata)
		
		I2Cclockpulse()
		
		I2COutput(0)
		
		I2Cclockpulse()
		
		Channel = ChipNo * 8
		For k = 1 To 8
			If DAC(Channel + k) > 63 Then
				DAC(Channel + k) = 63
			End If
			Temp = DAC(Channel + k)
			I2COutput(Temp)
			I2Cclockpulse()
		Next 
		
		I2CStop()
	End Sub
	
	Sub UpdateDAchannel(ByRef ChannelNo As Short)
		Dim Temp As Short
		Temp = DA(ChannelNo)
		OutputDAchannel(ChannelNo, Temp)
	End Sub
	
	Sub UpdateIOchip(ByRef ChipNo As Short)
		Dim Temp As Short
		Temp = IOdata(ChipNo)
		IOoutput(ChipNo, Temp)
	End Sub
	
	' UPDATE IODATA & IO ARRAY SUBROUTINES
	Sub UpdateIOdataArray(ByRef ChipNo As Short, ByRef Datavar As Short)
		Dim StartChannel, Temp, Channel As Short
		Dim Datvar As String
		' Update IOdata array
		IOdata(ChipNo) = IOdata(ChipNo) And IOconfig(ChipNo)
		Temp = IOconfig(ChipNo)
		IOdata(ChipNo) = IOdata(ChipNo) Or (Datavar And BINNOT(Temp))
		
		'Update IO array
		StartChannel = ChipNo * 8 + 1
		Temp = IOdata(ChipNo)
		Datvar = DecToBin(Temp)
		For Channel = 0 To 7
			If Mid(Datvar, 8 - Channel, 1) = "1" Then
				IO(StartChannel + Channel) = 1
			Else
				IO(StartChannel + Channel) = 0
			End If
		Next 
	End Sub
End Module