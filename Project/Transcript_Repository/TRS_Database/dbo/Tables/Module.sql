CREATE TABLE [dbo].[Module]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ModuleId] INT NOT NULL, 
    [ModuleTitle] NVARCHAR(50) NOT NULL, 
    [ModuleResult] INT NOT NULL, 
    [ModuleTrimester] NVARCHAR(50) NOT NULL, 
    [ModuleComment] NVARCHAR(50) NOT NULL, 
    [CourseId] INT NOT NULL, 
    CONSTRAINT [FK_Module_Course] FOREIGN KEY (CourseId) REFERENCES dbo.Course(Id)
)
