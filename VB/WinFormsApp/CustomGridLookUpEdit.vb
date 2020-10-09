Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports WinFormsApp
Imports System.Drawing

Namespace WinFormsApp

    <ToolboxItem(True)> _
    Public Class CustomGridLookUpEdit
        Inherits GridLookUpEdit
        Shared Sub New()
            RepositoryItemCustomridLookUpEdit.RegisterCustomEdit()
        End Sub

        Public Sub New()

        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomridLookUpEdit.CustomEditName
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomridLookUpEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomridLookUpEdit)
            End Get
        End Property

        Protected Overrides Function FindItem(ByVal text As String, ByVal startIndex As Integer) As Integer
            If (Not IsReady) Then
                Return -1
            End If
            Dim index As Integer = Properties.MyFindItem(text)
            Return index
        End Function
    End Class

    <UserRepositoryItem("RegisterCustomEdit")> _
    Public Class RepositoryItemCustomridLookUpEdit
        Inherits RepositoryItemGridLookUpEdit

        Shared Sub New()
            RegisterCustomEdit()
        End Sub


        Public Sub New()

        End Sub

        Public Const CustomEditName As String = "CustomGridLookUpEdit"


        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property


        Public Shared Sub RegisterCustomEdit()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, _
                GetType(CustomGridLookUpEdit), GetType(RepositoryItemCustomridLookUpEdit), _
                GetType(GridLookUpEditBaseViewInfo), New ButtonEditPainter, True))

        End Sub

        Public Function MyFindItem(ByVal text As String) As Integer
            Dim resultItemIndex As Integer = FindItem(text, False)
            If resultItemIndex = -1 Then
                resultItemIndex = FindItem(text, True)
            End If
            Return resultItemIndex
        End Function

    End Class

End Namespace
