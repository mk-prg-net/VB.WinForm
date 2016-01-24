Public Class MyChildForm

    Public Property Image As System.Drawing.Bitmap
        Get
            Return PictureBox1.Image
        End Get
        Set(value As System.Drawing.Bitmap)
            PictureBox1.Image = value
        End Set
    End Property

    ' Ein Dateiname wird übergeben. Aus diesem wird versucht, eine Bilddatei als Bitmap einzulesen, und die 
    ' Bitmap der Image Eigenschaft zuzuweisen
    Public WriteOnly Property ImageFileName As String
        Set(value As String)
            Try
                ' Bitmap laden
                Dim bmp = System.Drawing.Bitmap.FromFile(value)

                ' Bitmap mittels PictureBox anzeigen
                PictureBox1.Image = bmp

            Catch ex As Exception
                Dim msg As String = "Das einlesen der Datei " & value & " als Bilddatei scheiterte"
                Debug.WriteLine(msg)
                MessageBox.Show(msg, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Set
    End Property


End Class