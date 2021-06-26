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
            REM task = Await hc.GetFromJsonAsync(Of Task(Of List(Of Book)))("http://h2908727.stratoserver.net:8080/api/books")
            books = Await hc.GetFromJsonAsync(Of List(Of Book))("http://localhost:5000/api/Books")
            books.ForEach(Sub(element) Debug.WriteLine(element))

        Catch ex As Exception
        End Try


    End Sub
End Class
