Imports System.Web.Mvc

Public Class HelloWorldController
    Inherits Controller

    ' GET: /HelloWorld
    Function Index() As ActionResult
        Return View()
    End Function
End Class