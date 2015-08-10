'Reference
Imports System.Runtime.InteropServices

'http://www.pinvoke.net/default.aspx/kernel32.setprocessworkingsetsize

Public Class WorkingSet
    <DllImport("kernel32.dll", EntryPoint:="SetProcessWorkingSetSize")>
    Private Shared Function SetWorkingSet(handle As IntPtr, minimum As Integer, maximum As Integer) As Boolean
    End Function

    Public Shared Sub setMaximizeProcess(process_name As String, minimum As Integer, maximum As Integer)
        Dim setMaximize As Process() = Process.GetProcessesByName(process_name)
        For Each theprocess As Process In setMaximize
            If setMaximize.Length > 0 Then
                SetWorkingSet(theprocess.Handle, minimum, maximum)
            End If
        Next
    End Sub
End Class