'
' Created by SharpDevelop.
' User: CA01114
' Date: 9/27/2016
' Time: 10:37 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
			    Dim comSource As String = "COM7"
    Dim comDestination As String = "COM5"

    Dim comSourceIO As IO.Ports.SerialPort = Nothing
    
    Try
        comSourceIO = My.Computer.Ports.OpenSerialPort(comSource)
        'comSourceIO.ReadTimeout = 10000
        comSourceIO.NewLine = Chr(13)
        Do
            Dim Incoming As String = comSourceIO.ReadLine()
            If Incoming Is Nothing Then
                Exit Do
            Else
               Using comDestinationIO As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(comDestination)
        comDestinationIO.Write(Incoming & vbCrLf)
End Using
               
            End If
        Loop
    Catch ex As TimeoutException
        Console.Write("Error: Serial Port read timed out.")
    Finally
        If comSourceIO IsNot Nothing Then comSourceIO.Close()
    End Try
			
		End Sub
		
		
	End Class
	
End Namespace
