CREATE TABLE [dbo].[Course]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CourseId] INT NOT NULL, 
    [CourseName] NVARCHAR(50) NOT NULL, 
    [CourseQualification] NVARCHAR(50) NOT NULL, 
    [CourseResult] INT NOT NULL, 
    [CourseStartDate] DATE NOT NULL, 
    [CourseEndDate] DATE NOT NULL, 
    [CourseLength] INT NOT NULL,
	
)
