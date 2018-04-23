Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace WinFormsApp
	Partial Public Class Form1
		Inherits Form
        Public Function CreateDataSource() As List(Of MyTestClass)
            Dim myList As New List(Of MyTestClass)()
            myList.Add(New MyTestClass() With {.ID = 0, .Value = "AA1A"})
            myList.Add(New MyTestClass() With {.ID = 1, .Value = "AA"})
            myList.Add(New MyTestClass() With {.ID = 2, .Value = "AAA"})
            myList.Add(New MyTestClass() With {.ID = 3, .Value = "D"})
            myList.Add(New MyTestClass() With {.ID = 4, .Value = "E"})

            Return myList
        End Function

		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim rep As RepositoryItemCustomridLookUpEdit = customGridLookUpEdit1.Properties

			rep.DataSource = CreateDataSource()
			rep.DisplayMember = "Value"
			rep.ValueMember = "Value"
		End Sub

	End Class

    Public Class MyTestClass
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property
        Private privateValue As String
        Public Property Value() As String
            Get
                Return privateValue
            End Get
            Set(ByVal value As String)
                privateValue = value
            End Set
        End Property

    End Class
End Namespace
