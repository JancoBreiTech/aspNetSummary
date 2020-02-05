IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Student] (
    [StudentId] uniqueidentifier NOT NULL,
    [AnotherKeyProperty] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Age] int NULL,
    [IsRegularStudent] bit NOT NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId], [AnotherKeyProperty])
);

GO

CREATE PROCEDURE MyCustomeProcedure
                                   AS 
                                   SELECT * FROM Student

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200120084926_InitialMigration', N'3.1.1');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('b835665e-82df-4ef1-ae9b-b7e71f77a9d5', '00000000-0000-0000-0000-000000000000', 30, N'John Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('50b922ff-d1c6-469f-9c99-d368618d01a4', '00000000-0000-0000-0000-000000000000', 25, N'Jane Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200120091838_InitialSeedData', N'3.1.1');

GO

DELETE FROM [Student]
WHERE [StudentId] = '50b922ff-d1c6-469f-9c99-d368618d01a4' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = 'b835665e-82df-4ef1-ae9b-b7e71f77a9d5' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('87d3d675-cce3-465a-a58b-4ad0efb29ae1', '00000000-0000-0000-0000-000000000000', 30, N'John Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('20d0e29e-a207-4ac8-bd71-4be75cb3b6ba', '00000000-0000-0000-0000-000000000000', 25, N'Jane Doe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('66d8b5c5-3c58-4674-b211-73908083a4fc', '00000000-0000-0000-0000-000000000000', 28, N'Mike Miles');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200120092841_AdditionalRowInserted', N'3.1.1');

GO

DELETE FROM [Student]
WHERE [StudentId] = '20d0e29e-a207-4ac8-bd71-4be75cb3b6ba' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = '66d8b5c5-3c58-4674-b211-73908083a4fc' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Student]
WHERE [StudentId] = '87d3d675-cce3-465a-a58b-4ad0efb29ae1' AND [AnotherKeyProperty] = '00000000-0000-0000-0000-000000000000';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] ON;
INSERT INTO [Student] ([StudentId], [AnotherKeyProperty], [Age], [Name])
VALUES ('3a06dedf-4fa8-4219-97e4-b0448ad0b75f', '00000000-0000-0000-0000-000000000000', 30, N'John Doe'),
('4fdeea29-a3df-4cb0-8893-dc09f308ca27', '00000000-0000-0000-0000-000000000000', 25, N'Jane Doe'),
('9c3e0e6a-7707-474d-8ee2-71eaff385c33', '00000000-0000-0000-0000-000000000000', 28, N'Mike Miles'),
('f49d12d8-9339-472e-8990-ab3938332ba7', '00000000-0000-0000-0000-000000000000', 100, N'TEST NAME');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'StudentId', N'AnotherKeyProperty', N'Age', N'Name') AND [object_id] = OBJECT_ID(N'[Student]'))
    SET IDENTITY_INSERT [Student] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200120094200_RevertTestMigration', N'3.1.1');

GO

