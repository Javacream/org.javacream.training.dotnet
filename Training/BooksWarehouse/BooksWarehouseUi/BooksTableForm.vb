Imports System.Net.Http
Imports System.Net.Http.Json
Imports BooksWarehouse.Api

Public Class BooksTableForm
    Private Sub LoadDataButton_Click(sender As Object, e As EventArgs) Handles LoadDataButton.Click
        LoadData()
    End Sub
    Private Async Sub LoadData()

        Dim hc As HttpClient
        Dim books As List(Of Book)
        hc = New HttpClient
        Try
            REM books = Await hc.GetFromJsonAsync(Of List(Of Book))("http://localhost:5000/api/Books")
            books = Await hc.GetFromJsonAsync(Of List(Of Book))("http://h2908727.stratoserver.net:8080/api/books")
            BooksTextField.Clear()
            books.ForEach(Sub(element) BooksTextField.AppendText(element.ToString()))

        Catch ex As Exception
        End Try


    End Sub
End Class
