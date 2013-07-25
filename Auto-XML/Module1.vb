Imports System.Environment
Imports System.Console
Module Module1
    Dim menuoption As Integer
Sub Main()

        WriteLine("Welcome to the PGM XML creator, Auto-XML by sillybillypiggy")
        WriteLine("Intended to help you to easily create XML files.")
        WriteLine("Is this your first time using the program on this user/computer?")
        WriteLine("1 - Yes")
        WriteLine("2 - No")
        menuoption = ReadLine()

    If menuoption = "1" Then
        FirstTimeSetup()
    ElseIf menuoption = "2" Then
        MainMenu()
    Else
            WriteLine("Well done on not reading. I said 1 or 2. Press Enter.")
        ReadLine()
        End

    End If

End Sub
Sub FirstTimeSetup()
    Dim path As String
    Dim filename As String
    MsgBox("Performing first time setup...", MsgBoxStyle.Information)

    'Creates folder in "My Documents" for XML files to be placed into.
    path = GetFolderPath(SpecialFolder.MyDocuments)

    If (Not System.IO.Directory.Exists(path & "\Auto-XML")) Then
        System.IO.Directory.CreateDirectory(path & "\Auto-XML")
    End If
    'Creates a CSV file to store filenames in
    filename = ("\Auto-XML\filenames.csv")

    FileOpen(1, path & filename, OpenMode.Output)
    FileClose(1)

        WriteLine("First time setup complete")

    MsgBox("A folder has been created in your documents folder named Auto-XML. It will contain all your XML files, and also some program files.", MsgBoxStyle.Information)

    MainMenu()


End Sub
Sub MainMenu()
        WriteLine("If first time setup has not been performed please close the program and do it")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Welcome to Auto-XML for PGM")
        WriteLine("Designed to help you write XML files")
        ForegroundColor = ConsoleColor.Gray
        WriteLine("Press 1 to create a new XML file")
        WriteLine("Press 2 to add to an XML file")
        ForegroundColor = ConsoleColor.Red
        WriteLine("Press 3 to exit")
        ForegroundColor = ConsoleColor.Yellow
        menuoption = Console.ReadLine
        If menuoption = "1" Then
            NewFile()

        End If
    End Sub
    Sub NewFile()
        Dim filename As String
        Dim newfilename As String
        Dim path As String
        Console.Clear()
        WriteLine("Please name your new file.")
        Console.WriteLine("If the program crashes in this process, please re-perform first time setup.")

        WriteLine("Enter a file name")
        newfilename = ReadLine()

        'Adds filename to CSV file for storage

        path = GetFolderPath(SpecialFolder.MyDocuments)
        filename = "\Auto-XML\filenames.CSV"
        FileOpen(1, path & filename, OpenMode.Output)
        PrintLine(1, newfilename & ",")

        'Creates file

        FileOpen(2, path & "\Auto-XML\" & newfilename & ".txt", OpenMode.Output)

        Console.WriteLine("File Created. Press Enter To continue")

        ReadLine()
        Clear()
        ForegroundColor = ConsoleColor.Blue
        WriteLine("Currently editing file:" & newfilename)
        ForegroundColor = ConsoleColor.Yellow



    End Sub
    Sub EditFile()

    End Sub

End Module
