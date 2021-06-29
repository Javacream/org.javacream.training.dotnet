Imports System.Net.Http

Class MainWindow
    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        LoadData()
    End Sub
    Private Async Sub LoadData()

        Dim hc As HttpClient
        Dim response As HttpResponseMessage
        hc = New HttpClient
        Try
            REM books = Await hc.GetFromJsonAsync(Of List(Of Book))("http://localhost:5000/api/Books")
            response = Await hc.GetAsync("http://h2908727.stratoserver.net:8080/api/books")
            booksTextBlock.Text = Await response.Content.ReadAsStringAsync()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class
