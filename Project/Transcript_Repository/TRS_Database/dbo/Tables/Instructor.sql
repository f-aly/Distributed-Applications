CREATE TABLE [dbo].[Instructor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [InstructorId] INT NOT NULL, 
    [InstructorFirstName] NVARCHAR(50) NOT NULL, 
    [InstructorLastName] NVARCHAR(50) NOT NULL, 
    [InstructorEmail] NVARCHAR(50) NOT NULL
)
