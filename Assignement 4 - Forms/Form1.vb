Imports System.IO
Imports System.Xml
Public Class Form1
    Dim i As Short
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

    Private Sub xml_export_Click(sender As Object, e As EventArgs) Handles xml_export.Click
        Dim settings As New XmlWriterSettings()
        settings.Indent = True
        Dim XmlWrt As XmlWriter = XmlWriter.Create("D:\Documents\School Stuff\Fifth Year\2nd Sem\Electives 3 - Cont\Assignement 4 - Forms\Assignment-4---Forms-with-txt-xml-and-json-export\xml file\information.xml", settings)
        If fullname_text.Text <> "" Or age_text.Text <> "" Or address_text.Text <> "" Then
            With XmlWrt
                .WriteStartDocument()

                ' Write a comment.
                .WriteComment("XML Database.")

                ' Write the root element.
                .WriteStartElement("Data")

                ' Start our first person.
                .WriteStartElement("Person")

                ' The person nodes.

                .WriteStartElement("Name")
                .WriteString(fullname_text.Text.ToString())
                .WriteEndElement()

                .WriteStartElement("Age")
                .WriteString(age_text.Text.ToString())
                .WriteEndElement()

                .WriteStartElement("Address")
                .WriteString(address_text.Text.ToString())
                .WriteEndElement()

                ' The end of this person.
                .WriteEndElement()

                ' Close the XmlTextWriter.
                .WriteEndDocument()
                .Close()
                MsgBox("XmL file has been successfully created!", MsgBoxStyle.Information, "Saved")
            End With
        Else
            MsgBox("Please input necessary data in the field", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub

    Private Sub json_export_Click(sender As Object, e As EventArgs) Handles json_export.Click
        Dim sw1 As StreamWriter
        If fullname_text.Text <> "" Or age_text.Text <> "" Or address_text.Text <> "" Then
            sw1 = File.AppendText("D:\Documents\School Stuff\Fifth Year\2nd Sem\Electives 3 - Cont\Assignement 4 - Forms\Assignment-4---Forms-with-txt-xml-and-json-export\json file\information.json")
            sw1.WriteLine("-----------------------------------------")
            sw1.WriteLine("Name: " & fullname_text.Text)
            sw1.WriteLine("Age: " & age_text.Text)
            sw1.WriteLine("Address: " & address_text.Text)
            MsgBox("JSON file has been successfully created!", MsgBoxStyle.Information, "Saved")
            sw1.Close()
        Else
            MsgBox("Please input necessary data in the field", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub
End Class
