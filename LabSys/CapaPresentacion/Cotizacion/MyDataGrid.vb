Public Class MyDataGrid
    Inherits DataGrid
    Public Sub New()

        'make scrollbar visible & hook up handler 

        Me.VertScrollBar.Visible = True

        AddHandler Me.VertScrollBar.VisibleChanged, AddressOf ShowScrollBars

    End Sub 'New 
    Private CAPTIONHEIGHT As Integer = 21
    Private BORDERWIDTH As Integer = 2
    Private Sub ShowScrollBars(ByVal sender As Object, ByVal e As EventArgs)
        If Not Me.VertScrollBar.Visible Then
            Dim width As Integer = Me.VertScrollBar.Width
            Me.VertScrollBar.Location = New Point(Me.ClientRectangle.Width - width - BORDERWIDTH, CAPTIONHEIGHT)
            Me.VertScrollBar.Size = New Size(width, Me.ClientRectangle.Height - CAPTIONHEIGHT - BORDERWIDTH)
            Me.VertScrollBar.Show()
        End If
    End Sub 'ShowScrollBars 
End Class




