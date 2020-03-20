CREATE TABLE [dbo].[Transcript]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TranscriptId] INT NOT NULL, 
    [TranscriptDate] DATE NOT NULL, 
    [TranscriptStatus] BIT NOT NULL
)
