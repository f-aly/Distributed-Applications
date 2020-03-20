CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[StudentId] INT NOT NULL, 
    [StudentFirstName] NCHAR(10) NOT NULL, 
    [StudentLastName] NCHAR(10) NOT NULL, 
    [StudentEmail] NCHAR(10) NOT NULL
)
