'
' Created by SharpDevelop.
' User: CA01114
' Date: 9/27/2016
' Time: 7:42 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
Sub Main()
    Dim comSource As String = "COM1"
    Dim comDestination As String = "COM6"

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
               ' Using comDestinationIO As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(comDestination)
        Console.Write(Incoming & vbCrLf)
        'comDestinationIO.Write(Incoming & vbCrLf)
'End Using
               
            End If
        Loop
    Catch ex As TimeoutException
        Console.Write("Error: Serial Port read timed out.")
    Finally
        If comSourceIO IsNot Nothing Then comSourceIO.Close()
    End Try

End Sub
End Module
