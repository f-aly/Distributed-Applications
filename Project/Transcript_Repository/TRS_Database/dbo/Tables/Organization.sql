CREATE TABLE [dbo].[Organization]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrganizationId] INT NOT NULL, 
    [OrganizationName] NVARCHAR(50) NOT NULL, 
    [OrganizationEmail] NVARCHAR(50) NOT NULL
)
