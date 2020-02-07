Imports System.IO
Public Class Form1
    Private Sub txt_export_Click(sender As Object, e As EventArgs) Handles txt_export.Click
        Dim sw1 As StreamWriter
        If fullname_text.Text <> "" Or age_text.Text <> "" Or address_text.Text <> "" Then
            sw1 = File.AppendText("D:\Documents\School Stuff\Fifth Year\2nd Sem\Electives 3 - Cont\Assignement 4 - Forms\Assignment-4---Forms-with-txt-xml-and-json-export\txt file\information.txt")
            sw1.WriteLine("-----------------------------------------")
            sw1.WriteLine("Name: " & fullname_text.Text)
            sw1.WriteLine("Age: " & age_text.Text)
            sw1.WriteLine("Address: " & address_text.Text)
            MsgBox("Text file has been successfully created!", MsgBoxStyle.Information, "Saved")
            sw1.Close()
        Else
            MsgBox("Please input necessary data in the field", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub
End Class
