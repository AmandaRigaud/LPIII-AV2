CREATE TABLE [dbo].[Projeto]
(
	id int NOT NULL PRIMARY KEY IDENTITY,
	name text,
	manager text,
	startDate date,
	summary text,
	status text
)
