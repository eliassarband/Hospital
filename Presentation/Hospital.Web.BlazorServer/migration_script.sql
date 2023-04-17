IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    IF SCHEMA_ID(N'Sec') IS NULL EXEC(N'CREATE SCHEMA [Sec];');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    CREATE TABLE [Sec].[Role] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(50) NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        [Description] nvarchar(1000) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Role] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    CREATE TABLE [Sec].[User] (
        [Id] int NOT NULL IDENTITY,
        [FirstName] nvarchar(100) NOT NULL,
        [LastName] nvarchar(100) NOT NULL,
        [Username] nvarchar(100) NOT NULL,
        [Password] nvarchar(100) NOT NULL,
        [Email] nvarchar(100) NULL,
        [PhoneNumber] nvarchar(15) NOT NULL,
        [Active] bit NOT NULL,
        [Theme] nvarchar(100) NOT NULL,
        [Photo] varbinary(max) NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    CREATE TABLE [Sec].[UserRole] (
        [Id] int NOT NULL IDENTITY,
        [UserId] int NOT NULL,
        [RoleId] int NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_UserRole] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserRole_Role_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Sec].[Role] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserRole_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [Sec].[User] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'Description', N'ModifiedDate', N'ModifiedUser', N'Name') AND [object_id] = OBJECT_ID(N'[Sec].[Role]'))
        SET IDENTITY_INSERT [Sec].[Role] ON;
    EXEC(N'INSERT INTO [Sec].[Role] ([Id], [Code], [CreatedDate], [CreatedUser], [Description], [ModifiedDate], [ModifiedUser], [Name])
    VALUES (1, N''Super'', ''2022-11-15T12:12:55.1941302+03:30'', NULL, N'''', ''2022-11-15T12:12:55.1941233+03:30'', NULL, N''Super Admin''),
    (2, N''Admin'', ''2022-11-15T12:12:55.1941306+03:30'', NULL, N'''', ''2022-11-15T12:12:55.1941304+03:30'', NULL, N''Administrator''),
    (3, N''Operator'', ''2022-11-15T12:12:55.1941309+03:30'', NULL, N'''', ''2022-11-15T12:12:55.1941307+03:30'', NULL, N''Operator'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'Description', N'ModifiedDate', N'ModifiedUser', N'Name') AND [object_id] = OBJECT_ID(N'[Sec].[Role]'))
        SET IDENTITY_INSERT [Sec].[Role] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'CreatedDate', N'CreatedUser', N'Email', N'FirstName', N'LastName', N'ModifiedDate', N'ModifiedUser', N'Password', N'PhoneNumber', N'Photo', N'Theme', N'Username') AND [object_id] = OBJECT_ID(N'[Sec].[User]'))
        SET IDENTITY_INSERT [Sec].[User] ON;
    EXEC(N'INSERT INTO [Sec].[User] ([Id], [Active], [CreatedDate], [CreatedUser], [Email], [FirstName], [LastName], [ModifiedDate], [ModifiedUser], [Password], [PhoneNumber], [Photo], [Theme], [Username])
    VALUES (1, CAST(1 AS bit), ''2022-11-15T12:12:55.1957260+03:30'', NULL, N''elias.sarband@gmail.com'', N''Elias'', N''Sarband'', ''2022-11-15T12:12:55.1941474+03:30'', NULL, N''SEIE/b+BtdSahkhMsl4KK3SuEjCF1OKUEn4oQYMaYSc='', N''9125056182'', NULL, N''Light'', N''elias.sarband'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'CreatedDate', N'CreatedUser', N'Email', N'FirstName', N'LastName', N'ModifiedDate', N'ModifiedUser', N'Password', N'PhoneNumber', N'Photo', N'Theme', N'Username') AND [object_id] = OBJECT_ID(N'[Sec].[User]'))
        SET IDENTITY_INSERT [Sec].[User] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    CREATE INDEX [IX_UserRole_RoleId] ON [Sec].[UserRole] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    CREATE INDEX [IX_UserRole_UserId] ON [Sec].[UserRole] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084255_InitialDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221115084255_InitialDatabase', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084838_SeedDataForUserRole')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-11-15T12:18:38.2882810+03:30'', [CreatedUser] = N''elias.sarband'', [ModifiedDate] = ''2022-11-15T12:18:38.2882743+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084838_SeedDataForUserRole')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-11-15T12:18:38.2882816+03:30'', [CreatedUser] = N''elias.sarband'', [ModifiedDate] = ''2022-11-15T12:18:38.2882813+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084838_SeedDataForUserRole')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-11-15T12:18:38.2882821+03:30'', [CreatedUser] = N''elias.sarband'', [ModifiedDate] = ''2022-11-15T12:18:38.2882819+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084838_SeedDataForUserRole')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-11-15T12:18:38.2902391+03:30'', [CreatedUser] = N''elias.sarband'', [ModifiedDate] = ''2022-11-15T12:18:38.2883052+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084838_SeedDataForUserRole')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[Sec].[UserRole]'))
        SET IDENTITY_INSERT [Sec].[UserRole] ON;
    EXEC(N'INSERT INTO [Sec].[UserRole] ([Id], [CreatedDate], [CreatedUser], [ModifiedDate], [ModifiedUser], [RoleId], [UserId])
    VALUES (1, ''2022-11-15T12:18:38.2902472+03:30'', N''elias.sarband'', ''2022-11-15T12:18:38.2902468+03:30'', NULL, 1, 1)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[Sec].[UserRole]'))
        SET IDENTITY_INSERT [Sec].[UserRole] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115084838_SeedDataForUserRole')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221115084838_SeedDataForUserRole', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sec].[User]') AND [c].[name] = N'Photo');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Sec].[User] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Sec].[User] DROP COLUMN [Photo];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    IF SCHEMA_ID(N'Gnr') IS NULL EXEC(N'CREATE SCHEMA [Gnr];');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    ALTER TABLE [Sec].[User] ADD [AttachmentId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    CREATE TABLE [Gnr].[Attachment] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Extension] nvarchar(10) NOT NULL,
        [ContentType] nvarchar(50) NOT NULL,
        [Content] varbinary(max) NOT NULL,
        [Description] nvarchar(500) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Attachment] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-11-15T15:17:36.1459671+03:30'', [ModifiedDate] = ''2022-11-15T15:17:36.1459615+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-11-15T15:17:36.1459674+03:30'', [ModifiedDate] = ''2022-11-15T15:17:36.1459673+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-11-15T15:17:36.1459677+03:30'', [ModifiedDate] = ''2022-11-15T15:17:36.1459676+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [AttachmentId] = NULL, [CreatedDate] = ''2022-11-15T15:17:36.1470003+03:30'', [ModifiedDate] = ''2022-11-15T15:17:36.1459793+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-11-15T15:17:36.1470077+03:30'', [ModifiedDate] = ''2022-11-15T15:17:36.1470073+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    CREATE INDEX [IX_User_AttachmentId] ON [Sec].[User] ([AttachmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    ALTER TABLE [Sec].[User] ADD CONSTRAINT [FK_User_Attachment_AttachmentId] FOREIGN KEY ([AttachmentId]) REFERENCES [Gnr].[Attachment] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221115114736_AddAttachmenttoUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221115114736_AddAttachmenttoUser', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    CREATE TABLE [Gnr].[Department] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [IsMain] bit NOT NULL,
        [MainDept] nvarchar(max) NOT NULL,
        [NotInUse] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T10:32:31.9874947+03:30'', [ModifiedDate] = ''2022-12-04T10:32:31.9874892+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T10:32:31.9874950+03:30'', [ModifiedDate] = ''2022-12-04T10:32:31.9874949+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T10:32:31.9874953+03:30'', [ModifiedDate] = ''2022-12-04T10:32:31.9874952+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T10:32:31.9899949+03:30'', [ModifiedDate] = ''2022-12-04T10:32:31.9875072+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T10:32:31.9900190+03:30'', [ModifiedDate] = ''2022-12-04T10:32:31.9900178+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204070232_addDepartment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204070232_addDepartment', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Department]') AND [c].[name] = N'MainDept');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Department] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Gnr].[Department] DROP COLUMN [MainDept];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    ALTER TABLE [Gnr].[Department] ADD [MainDeptartment] nvarchar(200) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:08:34.4504104+03:30'', [ModifiedDate] = ''2022-12-04T11:08:34.4504049+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:08:34.4504107+03:30'', [ModifiedDate] = ''2022-12-04T11:08:34.4504105+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:08:34.4504110+03:30'', [ModifiedDate] = ''2022-12-04T11:08:34.4504108+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T11:08:34.4514262+03:30'', [ModifiedDate] = ''2022-12-04T11:08:34.4504214+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T11:08:34.4514307+03:30'', [ModifiedDate] = ''2022-12-04T11:08:34.4514305+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204073834_editDepartmentMainDept')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204073834_editDepartmentMainDept', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    CREATE TABLE [Gnr].[Service] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [DepartmentId] int NULL,
        [OPDRate] int NOT NULL,
        [IPDRate] int NOT NULL,
        [AddPercentage] int NOT NULL,
        [AddAmount] int NOT NULL,
        [DiscountPercentage] int NOT NULL,
        [DiscountAmount] int NOT NULL,
        [Remark] nvarchar(max) NOT NULL,
        [NotInUse] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Service] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Service_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Gnr].[Department] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:28:05.6480432+03:30'', [ModifiedDate] = ''2022-12-04T11:28:05.6480378+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:28:05.6480436+03:30'', [ModifiedDate] = ''2022-12-04T11:28:05.6480434+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:28:05.6480439+03:30'', [ModifiedDate] = ''2022-12-04T11:28:05.6480437+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T11:28:05.6491138+03:30'', [ModifiedDate] = ''2022-12-04T11:28:05.6480549+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T11:28:05.6491194+03:30'', [ModifiedDate] = ''2022-12-04T11:28:05.6491190+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    CREATE INDEX [IX_Service_DepartmentId] ON [Gnr].[Service] ([DepartmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204075805_addService')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204075805_addService', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    ALTER TABLE [Gnr].[Service] ADD [Cost] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:43:09.7255011+03:30'', [ModifiedDate] = ''2022-12-04T11:43:09.7254954+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:43:09.7255016+03:30'', [ModifiedDate] = ''2022-12-04T11:43:09.7255014+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T11:43:09.7255018+03:30'', [ModifiedDate] = ''2022-12-04T11:43:09.7255017+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T11:43:09.7265306+03:30'', [ModifiedDate] = ''2022-12-04T11:43:09.7255139+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T11:43:09.7265400+03:30'', [ModifiedDate] = ''2022-12-04T11:43:09.7265397+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204081309_editServiceCost')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204081309_editServiceCost', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'Remark');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [Remark] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'OPDRate');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [OPDRate] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'IPDRate');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [IPDRate] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'DiscountPercentage');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [DiscountPercentage] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'DiscountAmount');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [DiscountAmount] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'AddPercentage');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [AddPercentage] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Service]') AND [c].[name] = N'AddAmount');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Service] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Gnr].[Service] ALTER COLUMN [AddAmount] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:03:31.3217338+03:30'', [ModifiedDate] = ''2022-12-04T12:03:31.3217285+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:03:31.3217341+03:30'', [ModifiedDate] = ''2022-12-04T12:03:31.3217340+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:03:31.3217344+03:30'', [ModifiedDate] = ''2022-12-04T12:03:31.3217343+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T12:03:31.3227762+03:30'', [ModifiedDate] = ''2022-12-04T12:03:31.3217451+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T12:03:31.3227816+03:30'', [ModifiedDate] = ''2022-12-04T12:03:31.3227812+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204083331_editServiceNullableFields')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204083331_editServiceNullableFields', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    CREATE TABLE [Gnr].[RoomType] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [Floor] int NOT NULL,
        [Ward] nvarchar(200) NULL,
        [NotInUse] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_RoomType] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:33:31.7841348+03:30'', [ModifiedDate] = ''2022-12-04T12:33:31.7841298+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:33:31.7841352+03:30'', [ModifiedDate] = ''2022-12-04T12:33:31.7841350+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:33:31.7841354+03:30'', [ModifiedDate] = ''2022-12-04T12:33:31.7841353+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T12:33:31.7851587+03:30'', [ModifiedDate] = ''2022-12-04T12:33:31.7841474+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T12:33:31.7851644+03:30'', [ModifiedDate] = ''2022-12-04T12:33:31.7851641+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204090332_addRoomType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204090332_addRoomType', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[RoomType]') AND [c].[name] = N'Floor');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[RoomType] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Gnr].[RoomType] ALTER COLUMN [Floor] nvarchar(50) NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:48:46.4954970+03:30'', [ModifiedDate] = ''2022-12-04T12:48:46.4954908+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:48:46.4954974+03:30'', [ModifiedDate] = ''2022-12-04T12:48:46.4954972+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:48:46.4954978+03:30'', [ModifiedDate] = ''2022-12-04T12:48:46.4954976+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T12:48:46.4966309+03:30'', [ModifiedDate] = ''2022-12-04T12:48:46.4955134+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T12:48:46.4966358+03:30'', [ModifiedDate] = ''2022-12-04T12:48:46.4966355+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204091846_editRoomTypeFieldTypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204091846_editRoomTypeFieldTypes', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    CREATE TABLE [Gnr].[Room] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [RoomTypeId] int NOT NULL,
        [Rest] int NOT NULL,
        [Cost] int NOT NULL,
        [NotInUse] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Room] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Room_RoomType_RoomTypeId] FOREIGN KEY ([RoomTypeId]) REFERENCES [Gnr].[RoomType] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:54:36.9396016+03:30'', [ModifiedDate] = ''2022-12-04T12:54:36.9395967+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:54:36.9396020+03:30'', [ModifiedDate] = ''2022-12-04T12:54:36.9396018+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-04T12:54:36.9396023+03:30'', [ModifiedDate] = ''2022-12-04T12:54:36.9396021+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-04T12:54:36.9406686+03:30'', [ModifiedDate] = ''2022-12-04T12:54:36.9396156+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-04T12:54:36.9406735+03:30'', [ModifiedDate] = ''2022-12-04T12:54:36.9406732+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    CREATE INDEX [IX_Room_RoomTypeId] ON [Gnr].[Room] ([RoomTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221204092437_addRoom')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221204092437_addRoom', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    CREATE TABLE [Gnr].[HospitalInformation] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(200) NOT NULL,
        [Address] nvarchar(max) NULL,
        [Phone] nvarchar(20) NULL,
        [Mobile] nvarchar(20) NULL,
        [Logo] varbinary(max) NOT NULL,
        [RegisterationNumber] nvarchar(20) NULL,
        [Email] nvarchar(50) NULL,
        [BackupDirectory1] nvarchar(100) NULL,
        [BackupDirectory2] nvarchar(100) NULL,
        [CurrencyName] nvarchar(20) NULL,
        [CurrencySymbol] nvarchar(10) NULL,
        [CurrencyCents] nvarchar(20) NULL,
        [SessionTimeout] int NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_HospitalInformation] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-12T11:12:17.7697050+03:30'', [ModifiedDate] = ''2022-12-12T11:12:17.7697001+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-12T11:12:17.7697054+03:30'', [ModifiedDate] = ''2022-12-12T11:12:17.7697052+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-12T11:12:17.7697057+03:30'', [ModifiedDate] = ''2022-12-12T11:12:17.7697055+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-12T11:12:17.7707638+03:30'', [ModifiedDate] = ''2022-12-12T11:12:17.7697169+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-12T11:12:17.7707690+03:30'', [ModifiedDate] = ''2022-12-12T11:12:17.7707688+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212074217_addHospitalInformation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221212074217_addHospitalInformation', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    ALTER TABLE [Gnr].[HospitalInformation] ADD [WhiteLogo] varbinary(max) NOT NULL DEFAULT 0x;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-12T13:31:56.8228792+03:30'', [ModifiedDate] = ''2022-12-12T13:31:56.8228739+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-12T13:31:56.8228796+03:30'', [ModifiedDate] = ''2022-12-12T13:31:56.8228794+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-12T13:31:56.8228799+03:30'', [ModifiedDate] = ''2022-12-12T13:31:56.8228797+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-12T13:31:56.8240882+03:30'', [ModifiedDate] = ''2022-12-12T13:31:56.8228948+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-12T13:31:56.8240943+03:30'', [ModifiedDate] = ''2022-12-12T13:31:56.8240936+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212100157_editHospitalInformationWhiteLogo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221212100157_editHospitalInformationWhiteLogo', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214074600_addAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-14T11:16:00.1529753+03:30'', [ModifiedDate] = ''2022-12-14T11:16:00.1529698+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214074600_addAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-14T11:16:00.1529757+03:30'', [ModifiedDate] = ''2022-12-14T11:16:00.1529755+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214074600_addAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-14T11:16:00.1529759+03:30'', [ModifiedDate] = ''2022-12-14T11:16:00.1529758+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214074600_addAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-14T11:16:00.1540133+03:30'', [ModifiedDate] = ''2022-12-14T11:16:00.1529887+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214074600_addAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-14T11:16:00.1540195+03:30'', [ModifiedDate] = ''2022-12-14T11:16:00.1540192+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214074600_addAttachment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221214074600_addAttachment', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Attachment]') AND [c].[name] = N'Extension');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Attachment] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Gnr].[Attachment] ALTER COLUMN [Extension] nvarchar(10) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-14T16:18:28.9701439+03:30'', [ModifiedDate] = ''2022-12-14T16:18:28.9701383+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-14T16:18:28.9701443+03:30'', [ModifiedDate] = ''2022-12-14T16:18:28.9701441+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-14T16:18:28.9701446+03:30'', [ModifiedDate] = ''2022-12-14T16:18:28.9701444+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-14T16:18:28.9716507+03:30'', [ModifiedDate] = ''2022-12-14T16:18:28.9701588+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-14T16:18:28.9716728+03:30'', [ModifiedDate] = ''2022-12-14T16:18:28.9716722+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214124829_editAttachment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221214124829_editAttachment', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    CREATE TABLE [Gnr].[BasicInformationCategory] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(50) NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        [Viewable] bit NOT NULL,
        [RelatedCategoryId] int NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_BasicInformationCategory] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_BasicInformationCategory_BasicInformationCategory_RelatedCategoryId] FOREIGN KEY ([RelatedCategoryId]) REFERENCES [Gnr].[BasicInformationCategory] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    CREATE TABLE [Gnr].[BasicInformation] (
        [Id] int NOT NULL IDENTITY,
        [Code] int NOT NULL,
        [StrCode] nvarchar(50) NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        [CategoryId] int NOT NULL,
        [Priority] int NOT NULL,
        [RelatedBasicInformationId] int NULL,
        [Active] bit NOT NULL,
        [IsDeleted] bit NOT NULL,
        [AllowChange] bit NOT NULL,
        [AllowDelete] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_BasicInformation] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_BasicInformation_BasicInformationCategory_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Gnr].[BasicInformationCategory] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_BasicInformation_BasicInformation_RelatedBasicInformationId] FOREIGN KEY ([RelatedBasicInformationId]) REFERENCES [Gnr].[BasicInformation] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-17T11:45:16.1558724+03:30'', [ModifiedDate] = ''2022-12-17T11:45:16.1558672+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-17T11:45:16.1558729+03:30'', [ModifiedDate] = ''2022-12-17T11:45:16.1558726+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-17T11:45:16.1558733+03:30'', [ModifiedDate] = ''2022-12-17T11:45:16.1558731+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-17T11:45:16.1577280+03:30'', [ModifiedDate] = ''2022-12-17T11:45:16.1558893+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-17T11:45:16.1577326+03:30'', [ModifiedDate] = ''2022-12-17T11:45:16.1577324+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    CREATE INDEX [IX_BasicInformation_CategoryId] ON [Gnr].[BasicInformation] ([CategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    CREATE INDEX [IX_BasicInformation_RelatedBasicInformationId] ON [Gnr].[BasicInformation] ([RelatedBasicInformationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    CREATE INDEX [IX_BasicInformationCategory_RelatedCategoryId] ON [Gnr].[BasicInformationCategory] ([RelatedCategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221217081516_addBasicInformation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221217081516_addBasicInformation', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Department]') AND [c].[name] = N'MainDeptartment');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Department] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Gnr].[Department] DROP COLUMN [MainDeptartment];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    ALTER TABLE [Gnr].[Department] ADD [MainDepartmentId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    ALTER TABLE [Gnr].[Department] ADD [MainDeptartmentId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-18T11:21:15.2838406+03:30'', [ModifiedDate] = ''2022-12-18T11:21:15.2838350+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-18T11:21:15.2838409+03:30'', [ModifiedDate] = ''2022-12-18T11:21:15.2838407+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-18T11:21:15.2838412+03:30'', [ModifiedDate] = ''2022-12-18T11:21:15.2838411+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-18T11:21:15.2854928+03:30'', [ModifiedDate] = ''2022-12-18T11:21:15.2838527+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-18T11:21:15.2855033+03:30'', [ModifiedDate] = ''2022-12-18T11:21:15.2855029+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    CREATE INDEX [IX_Department_MainDepartmentId] ON [Gnr].[Department] ([MainDepartmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    ALTER TABLE [Gnr].[Department] ADD CONSTRAINT [FK_Department_Department_MainDepartmentId] FOREIGN KEY ([MainDepartmentId]) REFERENCES [Gnr].[Department] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218075115_editMainDepartmentType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221218075115_editMainDepartmentType', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[Department]') AND [c].[name] = N'MainDeptartmentId');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[Department] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Gnr].[Department] DROP COLUMN [MainDeptartmentId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-18T11:34:53.1371044+03:30'', [ModifiedDate] = ''2022-12-18T11:34:53.1370993+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-18T11:34:53.1371047+03:30'', [ModifiedDate] = ''2022-12-18T11:34:53.1371045+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-18T11:34:53.1371050+03:30'', [ModifiedDate] = ''2022-12-18T11:34:53.1371049+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-18T11:34:53.1387478+03:30'', [ModifiedDate] = ''2022-12-18T11:34:53.1371165+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-18T11:34:53.1387528+03:30'', [ModifiedDate] = ''2022-12-18T11:34:53.1387522+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221218080453_editMainDepartmentTypeSpelling')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221218080453_editMainDepartmentTypeSpelling', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformationCategory] ([Id], [Code], [CreatedDate], [CreatedUser], [ModifiedDate], [ModifiedUser], [Name], [RelatedCategoryId], [Viewable])
    VALUES (1, N''StaffType'', ''2022-12-19T11:32:18.2127713+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127709+03:30'', NULL, N''Staff Type'', NULL, CAST(0 AS bit)),
    (2, N''NamePrefix'', ''2022-12-19T11:32:18.2127716+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127714+03:30'', NULL, N''Name Prefix'', NULL, CAST(0 AS bit)),
    (3, N''Speciality'', ''2022-12-19T11:32:18.2127719+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127717+03:30'', NULL, N''Speciality'', NULL, CAST(1 AS bit)),
    (4, N''Qualification'', ''2022-12-19T11:32:18.2127721+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127720+03:30'', NULL, N''Qualification'', NULL, CAST(0 AS bit)),
    (5, N''City'', ''2022-12-19T11:32:18.2127724+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127723+03:30'', NULL, N''City'', 5, CAST(0 AS bit)),
    (6, N''Area'', ''2022-12-19T11:32:18.2127727+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127726+03:30'', NULL, N''Area'', NULL, CAST(0 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T11:32:18.2100902+03:30'', [ModifiedDate] = ''2022-12-19T11:32:18.2100836+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T11:32:18.2100908+03:30'', [ModifiedDate] = ''2022-12-19T11:32:18.2100906+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T11:32:18.2100912+03:30'', [ModifiedDate] = ''2022-12-19T11:32:18.2100910+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T11:32:18.2118361+03:30'', [ModifiedDate] = ''2022-12-19T11:32:18.2101111+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AttachmentId', N'CreatedDate', N'CreatedUser', N'Email', N'FirstName', N'LastName', N'ModifiedDate', N'ModifiedUser', N'Password', N'PhoneNumber', N'Theme', N'Username') AND [object_id] = OBJECT_ID(N'[Sec].[User]'))
        SET IDENTITY_INSERT [Sec].[User] ON;
    EXEC(N'INSERT INTO [Sec].[User] ([Id], [Active], [AttachmentId], [CreatedDate], [CreatedUser], [Email], [FirstName], [LastName], [ModifiedDate], [ModifiedUser], [Password], [PhoneNumber], [Theme], [Username])
    VALUES (2, CAST(1 AS bit), NULL, ''2022-12-19T11:32:18.2127565+03:30'', N''elias.sarband'', N'''', N''Admin'', N''AccurateCo'', ''2022-12-19T11:32:18.2118385+03:30'', NULL, N''dW/0ZNtG5T5uIyhEYh0J9Q=='', N''9125056182'', N''Light'', N''accurateco'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AttachmentId', N'CreatedDate', N'CreatedUser', N'Email', N'FirstName', N'LastName', N'ModifiedDate', N'ModifiedUser', N'Password', N'PhoneNumber', N'Theme', N'Username') AND [object_id] = OBJECT_ID(N'[Sec].[User]'))
        SET IDENTITY_INSERT [Sec].[User] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T11:32:18.2127686+03:30'', [ModifiedDate] = ''2022-12-19T11:32:18.2127684+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[Sec].[UserRole]'))
        SET IDENTITY_INSERT [Sec].[UserRole] ON;
    EXEC(N'INSERT INTO [Sec].[UserRole] ([Id], [CreatedDate], [CreatedUser], [ModifiedDate], [ModifiedUser], [RoleId], [UserId])
    VALUES (2, ''2022-12-19T11:32:18.2127689+03:30'', N''elias.sarband'', ''2022-12-19T11:32:18.2127687+03:30'', NULL, 1, 2)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[Sec].[UserRole]'))
        SET IDENTITY_INSERT [Sec].[UserRole] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080218_seedDataBasicInformationCategory')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221219080218_seedDataBasicInformationCategory', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T11:34:33.7213579+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213574+03:30'', [Viewable] = CAST(1 AS bit)
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T11:34:33.7213585+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213582+03:30'', [Viewable] = CAST(1 AS bit)
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T11:34:33.7213589+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213587+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T11:34:33.7213594+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213592+03:30'', [Viewable] = CAST(1 AS bit)
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T11:34:33.7213598+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213596+03:30'', [RelatedCategoryId] = NULL, [Viewable] = CAST(1 AS bit)
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T11:34:33.7213602+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213600+03:30'', [RelatedCategoryId] = 5, [Viewable] = CAST(1 AS bit)
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T11:34:33.7178823+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7178768+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T11:34:33.7178829+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7178827+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T11:34:33.7178881+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7178879+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T11:34:33.7197324+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7179048+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T11:34:33.7213477+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7197335+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T11:34:33.7213544+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213542+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T11:34:33.7213548+03:30'', [ModifiedDate] = ''2022-12-19T11:34:33.7213546+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219080433_seedDataBasicInformationCategoryCorrection')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221219080433_seedDataBasicInformationCategoryCorrection', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    IF SCHEMA_ID(N'med') IS NULL EXEC(N'CREATE SCHEMA [med];');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    CREATE TABLE [med].[Insurance] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [OPDDiscountPercent] int NOT NULL,
        [IPDDiscountPercent] int NOT NULL,
        [AdvancePaymentPercent] int NOT NULL,
        [AdvancePaymentAmount] int NOT NULL,
        [IncurancePaymentTypeId] int NOT NULL,
        [NotInUse] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Insurance] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Insurance_BasicInformation_IncurancePaymentTypeId] FOREIGN KEY ([IncurancePaymentTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T12:06:46.1229672+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229668+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T12:06:46.1229675+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229674+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T12:06:46.1229678+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229677+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T12:06:46.1229682+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229680+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T12:06:46.1229684+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229683+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T12:06:46.1229688+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229686+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformationCategory] ([Id], [Code], [CreatedDate], [CreatedUser], [ModifiedDate], [ModifiedUser], [Name], [RelatedCategoryId], [Viewable])
    VALUES (7, N''InsurancePaymentType'', ''2022-12-19T12:06:46.1229690+03:30'', N''elias.sarband'', ''2022-12-19T12:06:46.1229689+03:30'', NULL, N''Insurance Payment Type'', NULL, CAST(1 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T12:06:46.1209432+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1209381+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T12:06:46.1209436+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1209434+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T12:06:46.1209440+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1209438+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T12:06:46.1220172+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1209597+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T12:06:46.1229600+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1220177+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T12:06:46.1229643+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229641+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T12:06:46.1229646+03:30'', [ModifiedDate] = ''2022-12-19T12:06:46.1229644+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    CREATE INDEX [IX_Insurance_IncurancePaymentTypeId] ON [med].[Insurance] ([IncurancePaymentTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219083646_addInsurance')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221219083646_addInsurance', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    ALTER TABLE [med].[Insurance] DROP CONSTRAINT [FK_Insurance_BasicInformation_IncurancePaymentTypeId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    IF SCHEMA_ID(N'Med') IS NULL EXEC(N'CREATE SCHEMA [Med];');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    ALTER SCHEMA [Med] TRANSFER [med].[Insurance];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC sp_rename N'[Med].[Insurance].[IncurancePaymentTypeId]', N'InsurancePaymentTypeId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC sp_rename N'[Med].[Insurance].[IX_Insurance_IncurancePaymentTypeId]', N'IX_Insurance_InsurancePaymentTypeId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    CREATE TABLE [Med].[InsuranceAgreement] (
        [Id] int NOT NULL IDENTITY,
        [InsuranceId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [ToDate] datetime2 NOT NULL,
        [AttachmentId] int NULL,
        [ShowWarningBefore] int NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_InsuranceAgreement] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_InsuranceAgreement_Attachment_AttachmentId] FOREIGN KEY ([AttachmentId]) REFERENCES [Gnr].[Attachment] ([Id]),
        CONSTRAINT [FK_InsuranceAgreement_Insurance_InsuranceId] FOREIGN KEY ([InsuranceId]) REFERENCES [Med].[Insurance] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601026+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601022+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601029+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601027+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601031+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601030+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601034+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601033+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601036+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601035+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601039+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601038+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-19T13:00:26.1601042+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601040+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T13:00:26.1583236+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1583184+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T13:00:26.1583239+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1583237+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-19T13:00:26.1583242+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1583240+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T13:00:26.1592665+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1583380+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-19T13:00:26.1600953+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1592675+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T13:00:26.1601002+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601000+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-19T13:00:26.1601005+03:30'', [ModifiedDate] = ''2022-12-19T13:00:26.1601004+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    CREATE INDEX [IX_InsuranceAgreement_AttachmentId] ON [Med].[InsuranceAgreement] ([AttachmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    CREATE INDEX [IX_InsuranceAgreement_InsuranceId] ON [Med].[InsuranceAgreement] ([InsuranceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    ALTER TABLE [Med].[Insurance] ADD CONSTRAINT [FK_Insurance_BasicInformation_InsurancePaymentTypeId] FOREIGN KEY ([InsurancePaymentTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221219093026_addInsuranceAgreement')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221219093026_addInsuranceAgreement', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AllowChange', N'AllowDelete', N'CategoryId', N'Code', N'CreatedDate', N'CreatedUser', N'IsDeleted', N'ModifiedDate', N'ModifiedUser', N'Name', N'Priority', N'RelatedBasicInformationId', N'StrCode') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformation]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformation] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformation] ([Id], [Active], [AllowChange], [AllowDelete], [CategoryId], [Code], [CreatedDate], [CreatedUser], [IsDeleted], [ModifiedDate], [ModifiedUser], [Name], [Priority], [RelatedBasicInformationId], [StrCode])
    VALUES (701, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 7, 1, ''2022-12-24T10:42:47.6754413+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T10:42:47.6754408+03:30'', NULL, N''Cash'', 1, NULL, N''Cash''),
    (702, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 7, 2, ''2022-12-24T10:42:47.6754419+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T10:42:47.6754415+03:30'', NULL, N''Credit'', 2, NULL, N''Credit'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AllowChange', N'AllowDelete', N'CategoryId', N'Code', N'CreatedDate', N'CreatedUser', N'IsDeleted', N'ModifiedDate', N'ModifiedUser', N'Name', N'Priority', N'RelatedBasicInformationId', N'StrCode') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformation]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformation] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754359+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754352+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754363+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754361+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754367+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754365+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754370+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754369+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754374+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754373+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754378+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754376+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T10:42:47.6754383+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754380+03:30'', [Viewable] = CAST(0 AS bit)
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T10:42:47.6727923+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6727868+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T10:42:47.6727929+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6727927+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T10:42:47.6727933+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6727931+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T10:42:47.6742207+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6728160+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T10:42:47.6754129+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6742249+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T10:42:47.6754323+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754319+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T10:42:47.6754328+03:30'', [ModifiedDate] = ''2022-12-24T10:42:47.6754326+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224071248_editInsurancePaymentType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221224071248_editInsurancePaymentType', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE TABLE [Med].[Staff] (
        [Id] int NOT NULL IDENTITY,
        [StaffTypeId] int NULL,
        [Code] nvarchar(100) NOT NULL,
        [NamePrefixId] int NULL,
        [Name] nvarchar(200) NOT NULL,
        [DateOfJoining] datetime2 NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [SpecialityId] int NULL,
        [QualificationId] int NULL,
        [Mobile] nvarchar(15) NOT NULL,
        [Email] nvarchar(100) NOT NULL,
        [CityId] int NULL,
        [AreaId] int NULL,
        [Address] nvarchar(1000) NOT NULL,
        [OPDChargePercent] int NOT NULL,
        [IPDChargePercent] int NOT NULL,
        [NightOPDChargePercent] int NOT NULL,
        [NightIPDChargePercent] int NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Staff] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Staff_BasicInformation_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Staff_BasicInformation_CityId] FOREIGN KEY ([CityId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Staff_BasicInformation_NamePrefixId] FOREIGN KEY ([NamePrefixId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Staff_BasicInformation_QualificationId] FOREIGN KEY ([QualificationId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Staff_BasicInformation_SpecialityId] FOREIGN KEY ([SpecialityId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Staff_BasicInformation_StaffTypeId] FOREIGN KEY ([StaffTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE TABLE [Med].[StaffTiming] (
        [Id] int NOT NULL IDENTITY,
        [StaffId] int NOT NULL,
        [WeekDayNo] int NOT NULL,
        [WeekDayName] nvarchar(50) NOT NULL,
        [StartTime] time NOT NULL,
        [EndTime] time NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_StaffTiming] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StaffTiming_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Med].[Staff] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T12:02:21.3695928+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695926+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T12:02:21.3695931+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695929+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AllowChange', N'AllowDelete', N'CategoryId', N'Code', N'CreatedDate', N'CreatedUser', N'IsDeleted', N'ModifiedDate', N'ModifiedUser', N'Name', N'Priority', N'RelatedBasicInformationId', N'StrCode') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformation]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformation] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformation] ([Id], [Active], [AllowChange], [AllowDelete], [CategoryId], [Code], [CreatedDate], [CreatedUser], [IsDeleted], [ModifiedDate], [ModifiedUser], [Name], [Priority], [RelatedBasicInformationId], [StrCode])
    VALUES (101, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 1, 1, ''2022-12-24T12:02:21.3695910+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T12:02:21.3695906+03:30'', NULL, N''Doctor'', 1, NULL, N''Doctor''),
    (102, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 1, 2, ''2022-12-24T12:02:21.3695914+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T12:02:21.3695912+03:30'', NULL, N''Nurse'', 2, NULL, N''Nurse''),
    (103, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 1, 3, ''2022-12-24T12:02:21.3695918+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T12:02:21.3695916+03:30'', NULL, N''Staff'', 3, NULL, N''Staff''),
    (201, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 2, 1, ''2022-12-24T12:02:21.3695921+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T12:02:21.3695919+03:30'', NULL, N''Mr'', 1, NULL, N''Mr''),
    (202, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 2, 2, ''2022-12-24T12:02:21.3695924+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2022-12-24T12:02:21.3695922+03:30'', NULL, N''Mrs'', 2, NULL, N''Mrs'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AllowChange', N'AllowDelete', N'CategoryId', N'Code', N'CreatedDate', N'CreatedUser', N'IsDeleted', N'ModifiedDate', N'ModifiedUser', N'Name', N'Priority', N'RelatedBasicInformationId', N'StrCode') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformation]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformation] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695870+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695866+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695873+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695871+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695876+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695874+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695879+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695877+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695882+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695880+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695886+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695884+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T12:02:21.3695889+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695887+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T12:02:21.3676928+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3676876+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T12:02:21.3676989+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3676988+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T12:02:21.3676992+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3676991+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T12:02:21.3686933+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3677137+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T12:02:21.3695801+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3686938+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T12:02:21.3695847+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695844+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T12:02:21.3695850+03:30'', [ModifiedDate] = ''2022-12-24T12:02:21.3695849+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_Staff_AreaId] ON [Med].[Staff] ([AreaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_Staff_CityId] ON [Med].[Staff] ([CityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_Staff_NamePrefixId] ON [Med].[Staff] ([NamePrefixId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_Staff_QualificationId] ON [Med].[Staff] ([QualificationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_Staff_SpecialityId] ON [Med].[Staff] ([SpecialityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_Staff_StaffTypeId] ON [Med].[Staff] ([StaffTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    CREATE INDEX [IX_StaffTiming_StaffId] ON [Med].[StaffTiming] ([StaffId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224083221_addStaff')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221224083221_addStaff', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[Staff]') AND [c].[name] = N'OPDChargePercent');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Med].[Staff] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [Med].[Staff] ALTER COLUMN [OPDChargePercent] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[Staff]') AND [c].[name] = N'NightOPDChargePercent');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Med].[Staff] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [Med].[Staff] ALTER COLUMN [NightOPDChargePercent] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[Staff]') AND [c].[name] = N'NightIPDChargePercent');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Med].[Staff] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [Med].[Staff] ALTER COLUMN [NightIPDChargePercent] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[Staff]') AND [c].[name] = N'IPDChargePercent');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Med].[Staff] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [Med].[Staff] ALTER COLUMN [IPDChargePercent] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[Staff]') AND [c].[name] = N'Address');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Med].[Staff] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [Med].[Staff] ALTER COLUMN [Address] nvarchar(1000) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283257+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283249+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283264+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283260+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283270+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283266+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283275+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283272+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283281+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283278+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283287+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283283+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T13:39:46.2283293+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283289+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283187+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283180+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283193+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283190+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283198+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283196+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283203+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283201+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283209+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283206+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283214+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283211+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T13:39:46.2283219+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283216+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T13:39:46.2243962+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2243907+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T13:39:46.2243966+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2243964+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T13:39:46.2243970+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2243968+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T13:39:46.2264342+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2244154+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T13:39:46.2283030+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2264351+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T13:39:46.2283148+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283145+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T13:39:46.2283154+03:30'', [ModifiedDate] = ''2022-12-24T13:39:46.2283151+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224100946_editStaffNullableFields')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221224100946_editStaffNullableFields', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE TABLE [Med].[RefferBy] (
        [Id] int NOT NULL IDENTITY,
        [StaffTypeId] int NULL,
        [Code] nvarchar(100) NOT NULL,
        [NamePrefixId] int NULL,
        [Name] nvarchar(200) NOT NULL,
        [DateOfJoining] datetime2 NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [SpecialityId] int NULL,
        [QualificationId] int NULL,
        [Mobile] nvarchar(15) NOT NULL,
        [Email] nvarchar(100) NOT NULL,
        [CityId] int NULL,
        [AreaId] int NULL,
        [Address] nvarchar(1000) NULL,
        [OPDPercent] int NULL,
        [IPDPercent] int NULL,
        [OPDAmount] int NULL,
        [IPDAmount] int NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_RefferBy] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_RefferBy_BasicInformation_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_RefferBy_BasicInformation_CityId] FOREIGN KEY ([CityId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_RefferBy_BasicInformation_NamePrefixId] FOREIGN KEY ([NamePrefixId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_RefferBy_BasicInformation_QualificationId] FOREIGN KEY ([QualificationId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_RefferBy_BasicInformation_SpecialityId] FOREIGN KEY ([SpecialityId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_RefferBy_BasicInformation_StaffTypeId] FOREIGN KEY ([StaffTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079133+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079129+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079137+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079134+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079140+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079138+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079143+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079141+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079146+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079144+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079149+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079147+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2022-12-24T14:41:30.5079152+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079150+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079097+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079093+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079100+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079098+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079102+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079101+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079105+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079104+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079108+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079106+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079110+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079109+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2022-12-24T14:41:30.5079113+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079111+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T14:41:30.5058293+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5058239+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T14:41:30.5058297+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5058295+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2022-12-24T14:41:30.5058300+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5058299+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T14:41:30.5070182+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5058429+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2022-12-24T14:41:30.5078980+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5070262+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T14:41:30.5079072+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079069+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2022-12-24T14:41:30.5079075+03:30'', [ModifiedDate] = ''2022-12-24T14:41:30.5079074+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE INDEX [IX_RefferBy_AreaId] ON [Med].[RefferBy] ([AreaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE INDEX [IX_RefferBy_CityId] ON [Med].[RefferBy] ([CityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE INDEX [IX_RefferBy_NamePrefixId] ON [Med].[RefferBy] ([NamePrefixId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE INDEX [IX_RefferBy_QualificationId] ON [Med].[RefferBy] ([QualificationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE INDEX [IX_RefferBy_SpecialityId] ON [Med].[RefferBy] ([SpecialityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    CREATE INDEX [IX_RefferBy_StaffTypeId] ON [Med].[RefferBy] ([StaffTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221224111130_addRefferBy')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221224111130_addRefferBy', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE TABLE [Med].[Patient] (
        [Id] int NOT NULL IDENTITY,
        [NamePrefixId] int NULL,
        [Name] nvarchar(200) NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [GenderId] int NULL,
        [FatherName] nvarchar(100) NOT NULL,
        [Mobile] nvarchar(15) NOT NULL,
        [Phone] nvarchar(15) NULL,
        [Email] nvarchar(100) NULL,
        [CityId] int NULL,
        [AreaId] int NULL,
        [Address] nvarchar(1000) NULL,
        [RefferById] int NULL,
        [NationalIdCart] nvarchar(20) NOT NULL,
        [Occupation] nvarchar(200) NULL,
        [InsuranceId] int NULL,
        [InsuranceNumber] nvarchar(20) NULL,
        [ProposalNumber] nvarchar(20) NULL,
        [AttachmentId] int NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Patient] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Patient_Attachment_AttachmentId] FOREIGN KEY ([AttachmentId]) REFERENCES [Gnr].[Attachment] ([Id]),
        CONSTRAINT [FK_Patient_BasicInformation_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Patient_BasicInformation_CityId] FOREIGN KEY ([CityId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Patient_BasicInformation_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Patient_BasicInformation_NamePrefixId] FOREIGN KEY ([NamePrefixId]) REFERENCES [Gnr].[BasicInformation] ([Id]),
        CONSTRAINT [FK_Patient_Insurance_InsuranceId] FOREIGN KEY ([InsuranceId]) REFERENCES [Med].[Insurance] ([Id]),
        CONSTRAINT [FK_Patient_RefferBy_RefferById] FOREIGN KEY ([RefferById]) REFERENCES [Med].[RefferBy] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364857+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364853+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364865+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364860+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364869+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364867+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364873+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364870+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364876+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364874+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364879+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364877+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-01-14T16:33:48.8364883+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364881+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364815+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364811+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364819+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364817+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364821+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364820+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364825+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364823+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364829+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364827+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364832+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364830+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-01-14T16:33:48.8364835+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364833+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-01-14T16:33:48.8344237+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8344176+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-01-14T16:33:48.8344240+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8344239+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-01-14T16:33:48.8344243+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8344242+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-01-14T16:33:48.8355145+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8344460+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-01-14T16:33:48.8364734+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8355150+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-01-14T16:33:48.8364787+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364779+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-01-14T16:33:48.8364790+03:30'', [ModifiedDate] = ''2023-01-14T16:33:48.8364789+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_AreaId] ON [Med].[Patient] ([AreaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_AttachmentId] ON [Med].[Patient] ([AttachmentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_CityId] ON [Med].[Patient] ([CityId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_GenderId] ON [Med].[Patient] ([GenderId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_InsuranceId] ON [Med].[Patient] ([InsuranceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_NamePrefixId] ON [Med].[Patient] ([NamePrefixId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    CREATE INDEX [IX_Patient_RefferById] ON [Med].[Patient] ([RefferById]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230114130349_addPatient')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230114130349_addPatient', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    CREATE TABLE [Sec].[OPDBill] (
        [Id] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [PatientId] int NOT NULL,
        [BillNo] nvarchar(max) NOT NULL,
        [TotalAmount] int NOT NULL,
        [PayableAmount] int NOT NULL,
        [Description] nvarchar(1000) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_OPDBill] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OPDBill_Patient_PatientId] FOREIGN KEY ([PatientId]) REFERENCES [Med].[Patient] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    CREATE TABLE [Sec].[OPDBillService] (
        [Id] int NOT NULL IDENTITY,
        [OPDBillId] int NOT NULL,
        [ServiceId] int NOT NULL,
        [Quantity] int NOT NULL,
        [Rate] int NOT NULL,
        [Discount] int NOT NULL,
        [Amount] int NOT NULL,
        [StaffId] int NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_OPDBillService] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OPDBillService_OPDBill_OPDBillId] FOREIGN KEY ([OPDBillId]) REFERENCES [Sec].[OPDBill] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_OPDBillService_Service_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Gnr].[Service] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_OPDBillService_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Med].[Staff] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575872+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575867+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575875+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575873+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575878+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575876+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575912+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575910+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575915+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575913+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575919+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575916+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-12T07:02:20.7575922+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575920+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575838+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575834+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575841+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575839+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575843+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575842+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575845+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575844+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575848+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575847+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575851+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575849+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-12T07:02:20.7575853+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575852+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-12T07:02:20.7557657+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7557604+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-12T07:02:20.7557660+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7557658+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-12T07:02:20.7557663+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7557661+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-12T07:02:20.7567266+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7557783+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-12T07:02:20.7575689+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7567271+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-12T07:02:20.7575733+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575731+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-12T07:02:20.7575736+03:30'', [ModifiedDate] = ''2023-02-12T07:02:20.7575734+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    CREATE INDEX [IX_OPDBill_PatientId] ON [Sec].[OPDBill] ([PatientId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    CREATE INDEX [IX_OPDBillService_OPDBillId] ON [Sec].[OPDBillService] ([OPDBillId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    CREATE INDEX [IX_OPDBillService_ServiceId] ON [Sec].[OPDBillService] ([ServiceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    CREATE INDEX [IX_OPDBillService_StaffId] ON [Sec].[OPDBillService] ([StaffId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230212033221_addOPDBilling')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230212033221_addOPDBilling', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    ALTER TABLE [Sec].[OPDBill] ADD [ReceiptNo] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540259+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540251+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540269+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540263+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540276+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540271+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540284+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540279+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540291+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540287+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540301+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540296+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:04:11.3540309+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540304+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540173+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540167+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540180+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540176+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540186+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540183+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540194+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540190+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540200+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540197+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540208+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540203+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:04:11.3540214+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540211+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-18T21:04:11.3493683+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3493603+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-18T21:04:11.3493692+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3493688+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-18T21:04:11.3493700+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3493696+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-18T21:04:11.3519222+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3494045+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-18T21:04:11.3540031+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3519235+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-18T21:04:11.3540122+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540112+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-18T21:04:11.3540129+03:30'', [ModifiedDate] = ''2023-02-18T21:04:11.3540126+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218173411_addOPDBillReceiptNo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230218173411_addOPDBillReceiptNo', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sec].[OPDBill]') AND [c].[name] = N'Description');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Sec].[OPDBill] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [Sec].[OPDBill] ALTER COLUMN [Description] nvarchar(1000) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553757+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553752+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553761+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553758+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553765+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553762+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553768+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553766+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553771+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553769+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553775+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553773+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-18T21:49:01.9553778+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553776+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553650+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553646+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553654+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553652+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553657+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553655+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553660+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553658+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553663+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553661+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553666+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553665+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-18T21:49:01.9553669+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553667+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-18T21:49:01.9533050+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9532995+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-18T21:49:01.9533054+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9533052+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-18T21:49:01.9533057+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9533055+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-18T21:49:01.9543970+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9533265+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-18T21:49:01.9553570+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9543976+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-18T21:49:01.9553617+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553615+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-18T21:49:01.9553620+03:30'', [ModifiedDate] = ''2023-02-18T21:49:01.9553619+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230218181902_addOPDBillDescription')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230218181902_addOPDBillDescription', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    CREATE TABLE [Gnr].[ReportTemplate] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [Content] nvarchar(max) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_ReportTemplate] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867254+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867250+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867257+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867255+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867259+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867258+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867261+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867260+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867263+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867262+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867265+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867264+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-19T10:31:57.7867267+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867266+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867225+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867222+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867227+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867226+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867228+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867227+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867230+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867229+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867231+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867231+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867233+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867232+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-19T10:31:57.7867234+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867233+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-19T10:31:57.7847057+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7847045+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-19T10:31:57.7847060+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7847058+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-19T10:31:57.7847061+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7847061+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-19T10:31:57.7857787+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7847181+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-19T10:31:57.7867147+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7857791+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-19T10:31:57.7867203+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867201+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-19T10:31:57.7867205+03:30'', [ModifiedDate] = ''2023-02-19T10:31:57.7867204+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230219070158_addReportTemplate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230219070158_addReportTemplate', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    DECLARE @var19 sysname;
    SELECT @var19 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sec].[OPDBill]') AND [c].[name] = N'BillNo');
    IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Sec].[OPDBill] DROP CONSTRAINT [' + @var19 + '];');
    ALTER TABLE [Sec].[OPDBill] DROP COLUMN [BillNo];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    DECLARE @var20 sysname;
    SELECT @var20 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sec].[OPDBill]') AND [c].[name] = N'ReceiptNo');
    IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Sec].[OPDBill] DROP CONSTRAINT [' + @var20 + '];');
    ALTER TABLE [Sec].[OPDBill] DROP COLUMN [ReceiptNo];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    ALTER TABLE [Sec].[OPDBill] ADD [PaymentTypeId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305977+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305971+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305980+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305978+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305982+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305980+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305984+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305982+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305989+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305984+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305991+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305990+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T14:07:26.6305992+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305991+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T14:07:26.6305917+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305915+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T14:07:26.6305919+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305918+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T14:07:26.6305920+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305919+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T14:07:26.6305923+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305921+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T14:07:26.6305925+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305923+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T14:07:26.6305926+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305925+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [Code] = N''PaymentType'', [CreatedDate] = ''2023-02-28T14:07:26.6305927+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305926+03:30'', [Name] = N''Payment Type''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-28T14:07:26.6286473+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6286460+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-28T14:07:26.6286475+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6286474+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-28T14:07:26.6286476+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6286476+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-28T14:07:26.6296704+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6286612+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-28T14:07:26.6305839+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6296709+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-28T14:07:26.6305891+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305889+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-28T14:07:26.6305893+03:30'', [ModifiedDate] = ''2023-02-28T14:07:26.6305892+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    CREATE INDEX [IX_OPDBill_PaymentTypeId] ON [Sec].[OPDBill] ([PaymentTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    ALTER TABLE [Sec].[OPDBill] ADD CONSTRAINT [FK_OPDBill_BasicInformation_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228103727_addOPDBillPaymentType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230228103727_addOPDBillPaymentType', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    ALTER SCHEMA [Med] TRANSFER [Sec].[OPDBillService];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    ALTER SCHEMA [Med] TRANSFER [Sec].[OPDBill];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE TABLE [Med].[IPDRegisteration] (
        [Id] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [PatientId] int NOT NULL,
        [RefferById] int NOT NULL,
        [TotalAmount] int NOT NULL,
        [PayableAmount] int NOT NULL,
        [Description] nvarchar(1000) NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_IPDRegisteration] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_IPDRegisteration_Patient_PatientId] FOREIGN KEY ([PatientId]) REFERENCES [Med].[Patient] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_IPDRegisteration_RefferBy_RefferById] FOREIGN KEY ([RefferById]) REFERENCES [Med].[RefferBy] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE TABLE [Med].[IPDRegisterationPayment] (
        [Id] int NOT NULL IDENTITY,
        [IPDRegisterationId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [PaymentTypeId] int NOT NULL,
        [Amount] int NOT NULL,
        [ChequeNumber] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_IPDRegisterationPayment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_IPDRegisterationPayment_BasicInformation_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_IPDRegisterationPayment_IPDRegisteration_IPDRegisterationId] FOREIGN KEY ([IPDRegisterationId]) REFERENCES [Med].[IPDRegisteration] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE TABLE [Med].[IPDRegisterationRoom] (
        [Id] int NOT NULL IDENTITY,
        [IPDRegisterationId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [RoomId] int NOT NULL,
        [Days] int NOT NULL,
        [Rate] int NOT NULL,
        [Amount] int NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_IPDRegisterationRoom] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_IPDRegisterationRoom_IPDRegisteration_IPDRegisterationId] FOREIGN KEY ([IPDRegisterationId]) REFERENCES [Med].[IPDRegisteration] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_IPDRegisterationRoom_Room_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [Gnr].[Room] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE TABLE [Med].[IPDRegisterationService] (
        [Id] int NOT NULL IDENTITY,
        [IPDRegisterationId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [ServiceId] int NOT NULL,
        [Quantity] int NOT NULL,
        [Rate] int NOT NULL,
        [Discount] int NOT NULL,
        [Amount] int NOT NULL,
        [StaffId] int NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_IPDRegisterationService] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_IPDRegisterationService_IPDRegisteration_IPDRegisterationId] FOREIGN KEY ([IPDRegisterationId]) REFERENCES [Med].[IPDRegisteration] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_IPDRegisterationService_Service_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Gnr].[Service] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_IPDRegisterationService_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Med].[Staff] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445487+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445479+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445498+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445497+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445500+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445499+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445502+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445501+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445504+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445503+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445506+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445505+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-02-28T15:43:05.8445508+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445507+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445437+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445434+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445439+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445437+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445440+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445439+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445441+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445440+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445443+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445442+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445445+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445444+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-02-28T15:43:05.8445453+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445451+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-28T15:43:05.8424685+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8424673+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-28T15:43:05.8424688+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8424687+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-02-28T15:43:05.8424690+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8424689+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-28T15:43:05.8435603+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8424852+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-02-28T15:43:05.8445282+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8435607+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-28T15:43:05.8445406+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445405+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-02-28T15:43:05.8445409+03:30'', [ModifiedDate] = ''2023-02-28T15:43:05.8445408+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_PatientId] ON [Med].[IPDRegisteration] ([PatientId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_RefferById] ON [Med].[IPDRegisteration] ([RefferById]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationPayment_IPDRegisterationId] ON [Med].[IPDRegisterationPayment] ([IPDRegisterationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationPayment_PaymentTypeId] ON [Med].[IPDRegisterationPayment] ([PaymentTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationRoom_IPDRegisterationId] ON [Med].[IPDRegisterationRoom] ([IPDRegisterationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationRoom_RoomId] ON [Med].[IPDRegisterationRoom] ([RoomId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationService_IPDRegisterationId] ON [Med].[IPDRegisterationService] ([IPDRegisterationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationService_ServiceId] ON [Med].[IPDRegisterationService] ([ServiceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    CREATE INDEX [IX_IPDRegisterationService_StaffId] ON [Med].[IPDRegisterationService] ([StaffId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230228121306_addIPDRegisteration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230228121306_addIPDRegisteration', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    CREATE TABLE [Gnr].[Setting] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(100) NOT NULL,
        [Key] nvarchar(50) NOT NULL,
        [Value] nvarchar(200) NOT NULL,
        [Description] nvarchar(1000) NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Setting] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264187+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264181+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264190+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264188+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264193+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264191+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264195+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264194+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264198+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264196+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264201+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264199+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T11:15:58.9264204+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264201+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264150+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264147+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264152+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264151+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264154+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264153+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264156+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264155+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264158+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264157+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264160+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264159+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T11:15:58.9264161+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264160+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T11:15:58.9244198+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9244185+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T11:15:58.9244201+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9244200+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T11:15:58.9244203+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9244202+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'Description', N'Key', N'ModifiedDate', N'ModifiedUser', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[Gnr].[Setting]'))
        SET IDENTITY_INSERT [Gnr].[Setting] ON;
    EXEC(N'INSERT INTO [Gnr].[Setting] ([Id], [CreatedDate], [CreatedUser], [Description], [Key], [ModifiedDate], [ModifiedUser], [Name], [Value])
    VALUES (1, ''2023-03-05T11:15:58.9264225+03:30'', N''elias.sarband'', NULL, N''PatientIdPrefix'', ''2023-03-05T11:15:58.9264223+03:30'', NULL, N''Patient Identifier Prefix'', N''P'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'Description', N'Key', N'ModifiedDate', N'ModifiedUser', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[Gnr].[Setting]'))
        SET IDENTITY_INSERT [Gnr].[Setting] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-05T11:15:58.9254741+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9244421+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-05T11:15:58.9264051+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9254747+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-05T11:15:58.9264121+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264119+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-05T11:15:58.9264123+03:30'', [ModifiedDate] = ''2023-03-05T11:15:58.9264122+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305074559_addSetting')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230305074559_addSetting', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300317+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300311+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300320+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300318+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300322+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300320+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300324+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300323+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300326+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300325+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300328+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300327+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T15:08:10.1300330+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300328+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300286+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300283+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300288+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300287+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300290+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300289+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300291+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300290+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300292+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300292+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300294+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300293+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T15:08:10.1300295+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300294+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T15:08:10.1280600+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1280587+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T15:08:10.1280602+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1280601+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T15:08:10.1280604+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1280603+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-05T15:08:10.1300353+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300346+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'Description', N'Key', N'ModifiedDate', N'ModifiedUser', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[Gnr].[Setting]'))
        SET IDENTITY_INSERT [Gnr].[Setting] ON;
    EXEC(N'INSERT INTO [Gnr].[Setting] ([Id], [CreatedDate], [CreatedUser], [Description], [Key], [ModifiedDate], [ModifiedUser], [Name], [Value])
    VALUES (2, ''2023-03-05T15:08:10.1300355+03:30'', N''elias.sarband'', NULL, N''OPDReceiptNoPrefix'', ''2023-03-05T15:08:10.1300354+03:30'', NULL, N''OPD Receipt Identifier Prefix'', N''OP'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'Description', N'Key', N'ModifiedDate', N'ModifiedUser', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[Gnr].[Setting]'))
        SET IDENTITY_INSERT [Gnr].[Setting] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-05T15:08:10.1290951+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1280764+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-05T15:08:10.1300210+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1290954+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-05T15:08:10.1300259+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300258+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-05T15:08:10.1300261+03:30'', [ModifiedDate] = ''2023-03-05T15:08:10.1300260+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305113810_addSettingOPDReceiptSeedData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230305113810_addSettingOPDReceiptSeedData', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300933+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300928+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300936+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300934+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300938+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300937+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300940+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300938+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300968+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300967+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300970+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300969+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-05T17:39:00.0300972+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300971+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300890+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300887+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300892+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300891+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300894+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300893+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300895+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300895+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300897+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300896+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300899+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300898+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-05T17:39:00.0300905+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300899+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformationCategory] ([Id], [Code], [CreatedDate], [CreatedUser], [ModifiedDate], [ModifiedUser], [Name], [RelatedCategoryId], [Viewable])
    VALUES (8, N''Gender'', ''2023-03-05T17:39:00.0300907+03:30'', N''elias.sarband'', ''2023-03-05T17:39:00.0300906+03:30'', NULL, N''Gender'', NULL, CAST(1 AS bit)),
    (9, N''Ward'', ''2023-03-05T17:39:00.0300909+03:30'', N''elias.sarband'', ''2023-03-05T17:39:00.0300908+03:30'', NULL, N''Ward'', NULL, CAST(1 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T17:39:00.0281076+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0281062+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T17:39:00.0281079+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0281078+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-05T17:39:00.0281081+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0281080+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-05T17:39:00.0301001+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0301000+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-05T17:39:00.0301003+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0301002+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-05T17:39:00.0291490+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0281309+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-05T17:39:00.0300806+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0291494+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-05T17:39:00.0300866+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300865+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-05T17:39:00.0300868+03:30'', [ModifiedDate] = ''2023-03-05T17:39:00.0300868+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AllowChange', N'AllowDelete', N'CategoryId', N'Code', N'CreatedDate', N'CreatedUser', N'IsDeleted', N'ModifiedDate', N'ModifiedUser', N'Name', N'Priority', N'RelatedBasicInformationId', N'StrCode') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformation]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformation] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformation] ([Id], [Active], [AllowChange], [AllowDelete], [CategoryId], [Code], [CreatedDate], [CreatedUser], [IsDeleted], [ModifiedDate], [ModifiedUser], [Name], [Priority], [RelatedBasicInformationId], [StrCode])
    VALUES (801, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 8, 1, ''2023-03-05T17:39:00.0300974+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2023-03-05T17:39:00.0300973+03:30'', NULL, N''Male'', 1, NULL, N''Male''),
    (802, CAST(1 AS bit), CAST(0 AS bit), CAST(0 AS bit), 8, 2, ''2023-03-05T17:39:00.0300976+03:30'', N''elias.sarband'', CAST(0 AS bit), ''2023-03-05T17:39:00.0300975+03:30'', NULL, N''Female'', 2, NULL, N''Female'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Active', N'AllowChange', N'AllowDelete', N'CategoryId', N'Code', N'CreatedDate', N'CreatedUser', N'IsDeleted', N'ModifiedDate', N'ModifiedUser', N'Name', N'Priority', N'RelatedBasicInformationId', N'StrCode') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformation]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformation] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230305140900_BasicInformationCategorySeedData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230305140900_BasicInformationCategorySeedData', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    DECLARE @var21 sysname;
    SELECT @var21 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[RoomType]') AND [c].[name] = N'Ward');
    IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[RoomType] DROP CONSTRAINT [' + @var21 + '];');
    ALTER TABLE [Gnr].[RoomType] DROP COLUMN [Ward];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    ALTER TABLE [Gnr].[RoomType] ADD [WardId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    CREATE TABLE [Gnr].[Bed] (
        [Id] int NOT NULL IDENTITY,
        [Code] nvarchar(100) NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [RoomId] int NOT NULL,
        [NotInUse] bit NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_Bed] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Bed_Room_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [Gnr].[Room] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799613+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799607+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799615+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799614+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799617+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799616+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799619+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799618+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799621+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799619+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799622+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799621+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799624+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799623+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799626+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799625+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:19:31.3799628+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799627+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799545+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799542+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799547+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799546+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799548+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799548+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799550+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799549+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799551+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799550+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799552+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799551+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799554+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799553+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799555+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799554+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:19:31.3799556+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799555+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T11:19:31.3780224+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3780211+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T11:19:31.3780226+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3780226+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T11:19:31.3780228+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3780227+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T11:19:31.3799649+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799648+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T11:19:31.3799651+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799650+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T11:19:31.3790437+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3780411+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T11:19:31.3799477+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3790443+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T11:19:31.3799526+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799525+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T11:19:31.3799528+03:30'', [ModifiedDate] = ''2023-03-06T11:19:31.3799527+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    CREATE INDEX [IX_RoomType_WardId] ON [Gnr].[RoomType] ([WardId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    CREATE INDEX [IX_Bed_RoomId] ON [Gnr].[Bed] ([RoomId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    ALTER TABLE [Gnr].[RoomType] ADD CONSTRAINT [FK_RoomType_BasicInformation_WardId] FOREIGN KEY ([WardId]) REFERENCES [Gnr].[BasicInformation] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306074931_addBed')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230306074931_addBed', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    ALTER TABLE [Med].[IPDRegisterationRoom] DROP CONSTRAINT [FK_IPDRegisterationRoom_Room_RoomId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC sp_rename N'[Med].[IPDRegisterationRoom].[RoomId]', N'BedId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC sp_rename N'[Med].[IPDRegisterationRoom].[IX_IPDRegisterationRoom_RoomId]', N'IX_IPDRegisterationRoom_BedId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313061+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313054+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313063+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313061+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313067+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313065+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313069+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313068+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313072+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313070+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313074+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313073+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313076+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313075+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313078+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313077+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T11:44:43.1313080+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313079+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313021+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313018+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313022+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313021+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313024+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313023+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313025+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313024+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313027+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313026+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313028+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313027+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313029+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313029+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313034+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313030+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T11:44:43.1313035+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313034+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T11:44:43.1293176+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1293163+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T11:44:43.1293178+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1293177+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T11:44:43.1293185+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1293184+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T11:44:43.1313098+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313097+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T11:44:43.1313100+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1313099+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T11:44:43.1303696+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1293385+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T11:44:43.1312903+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1303700+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T11:44:43.1312994+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1312993+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T11:44:43.1312996+03:30'', [ModifiedDate] = ''2023-03-06T11:44:43.1312996+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    ALTER TABLE [Med].[IPDRegisterationRoom] ADD CONSTRAINT [FK_IPDRegisterationRoom_Bed_BedId] FOREIGN KEY ([BedId]) REFERENCES [Gnr].[Bed] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306081443_addIPDRegisteration_Beds')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230306081443_addIPDRegisteration_Beds', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549659+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549655+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549663+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549660+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549664+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549663+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549666+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549665+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549668+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549667+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549670+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549669+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549672+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549671+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549674+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549672+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:11:33.2549676+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549674+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549617+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549614+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549619+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549618+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549620+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549620+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549622+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549621+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549623+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549623+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549625+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549624+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549628+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549627+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549635+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549634+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:11:33.2549637+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549636+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T12:11:33.2529598+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2529583+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T12:11:33.2529601+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2529600+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T12:11:33.2529602+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2529602+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T12:11:33.2549697+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549695+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T12:11:33.2549699+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549698+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'Description', N'Key', N'ModifiedDate', N'ModifiedUser', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[Gnr].[Setting]'))
        SET IDENTITY_INSERT [Gnr].[Setting] ON;
    EXEC(N'INSERT INTO [Gnr].[Setting] ([Id], [CreatedDate], [CreatedUser], [Description], [Key], [ModifiedDate], [ModifiedUser], [Name], [Value])
    VALUES (3, ''2023-03-06T12:11:33.2549700+03:30'', N''elias.sarband'', NULL, N''IPDNoPrefix'', ''2023-03-06T12:11:33.2549699+03:30'', NULL, N''IPD No Prefix'', N''IP'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'CreatedUser', N'Description', N'Key', N'ModifiedDate', N'ModifiedUser', N'Name', N'Value') AND [object_id] = OBJECT_ID(N'[Gnr].[Setting]'))
        SET IDENTITY_INSERT [Gnr].[Setting] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T12:11:33.2540141+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2529805+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T12:11:33.2549543+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2540146+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T12:11:33.2549594+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549593+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T12:11:33.2549595+03:30'', [ModifiedDate] = ''2023-03-06T12:11:33.2549595+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084133_settingSeedDataIPDPrefix')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230306084133_settingSeedDataIPDPrefix', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416500+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416495+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416502+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416501+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416504+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416503+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416506+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416505+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416508+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416507+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416510+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416508+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416511+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416510+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416513+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416512+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T12:13:45.8416515+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416514+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416458+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416456+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416460+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416459+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416462+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416461+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416463+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416462+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416464+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416463+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416466+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416465+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416467+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416466+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416468+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416468+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T12:13:45.8416469+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416469+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] ON;
    EXEC(N'INSERT INTO [Gnr].[BasicInformationCategory] ([Id], [Code], [CreatedDate], [CreatedUser], [ModifiedDate], [ModifiedUser], [Name], [RelatedCategoryId], [Viewable])
    VALUES (10, N''CaseType'', ''2023-03-06T12:13:45.8416471+03:30'', N''elias.sarband'', ''2023-03-06T12:13:45.8416471+03:30'', NULL, N''Case Type'', NULL, CAST(1 AS bit)),
    (11, N''Relationship'', ''2023-03-06T12:13:45.8416473+03:30'', N''elias.sarband'', ''2023-03-06T12:13:45.8416472+03:30'', NULL, N''Relationship'', NULL, CAST(1 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedDate', N'CreatedUser', N'ModifiedDate', N'ModifiedUser', N'Name', N'RelatedCategoryId', N'Viewable') AND [object_id] = OBJECT_ID(N'[Gnr].[BasicInformationCategory]'))
        SET IDENTITY_INSERT [Gnr].[BasicInformationCategory] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T12:13:45.8397183+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8397169+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T12:13:45.8397185+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8397184+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T12:13:45.8397187+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8397186+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T12:13:45.8416533+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416531+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T12:13:45.8416534+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416533+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T12:13:45.8416535+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416535+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T12:13:45.8407343+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8397362+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T12:13:45.8416387+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8407346+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T12:13:45.8416435+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416434+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T12:13:45.8416438+03:30'', [ModifiedDate] = ''2023-03-06T12:13:45.8416437+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306084346_basicInformationSeedData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230306084346_basicInformationSeedData', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [Agreement] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [BedId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [CaseTypeId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [ConsultantInchargeId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [Details] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [RelationshipId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [RoomId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [RoomTypeId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [SecondConsultantId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [ThirdConsultantId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [WardId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [WitnessName] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998047+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998041+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998049+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998048+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998051+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998050+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998053+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998052+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998055+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998054+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998057+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998056+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998059+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998058+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998061+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998060+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-06T15:09:43.5998063+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998061+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998003+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5997995+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998005+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998004+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998007+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998006+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998008+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998008+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998010+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998009+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998011+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998010+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998013+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998012+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998014+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998013+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998015+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998015+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998018+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998017+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-06T15:09:43.5998019+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998018+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T15:09:43.5978192+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5978178+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T15:09:43.5978195+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5978195+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-06T15:09:43.5978197+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5978196+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T15:09:43.5998095+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998093+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T15:09:43.5998097+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998096+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-06T15:09:43.5998098+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5998097+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T15:09:43.5988678+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5978419+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-06T15:09:43.5997889+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5988682+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T15:09:43.5997970+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5997969+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-06T15:09:43.5997972+03:30'', [ModifiedDate] = ''2023-03-06T15:09:43.5997971+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_BedId] ON [Med].[IPDRegisteration] ([BedId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_CaseTypeId] ON [Med].[IPDRegisteration] ([CaseTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_ConsultantInchargeId] ON [Med].[IPDRegisteration] ([ConsultantInchargeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_RelationshipId] ON [Med].[IPDRegisteration] ([RelationshipId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_RoomId] ON [Med].[IPDRegisteration] ([RoomId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_RoomTypeId] ON [Med].[IPDRegisteration] ([RoomTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_SecondConsultantId] ON [Med].[IPDRegisteration] ([SecondConsultantId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_ThirdConsultantId] ON [Med].[IPDRegisteration] ([ThirdConsultantId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    CREATE INDEX [IX_IPDRegisteration_WardId] ON [Med].[IPDRegisteration] ([WardId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_BasicInformation_CaseTypeId] FOREIGN KEY ([CaseTypeId]) REFERENCES [Gnr].[BasicInformation] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_BasicInformation_RelationshipId] FOREIGN KEY ([RelationshipId]) REFERENCES [Gnr].[BasicInformation] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_BasicInformation_WardId] FOREIGN KEY ([WardId]) REFERENCES [Gnr].[BasicInformation] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_Bed_BedId] FOREIGN KEY ([BedId]) REFERENCES [Gnr].[Bed] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_RoomType_RoomTypeId] FOREIGN KEY ([RoomTypeId]) REFERENCES [Gnr].[RoomType] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_Room_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [Gnr].[Room] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_Staff_ConsultantInchargeId] FOREIGN KEY ([ConsultantInchargeId]) REFERENCES [Med].[Staff] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_Staff_SecondConsultantId] FOREIGN KEY ([SecondConsultantId]) REFERENCES [Med].[Staff] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD CONSTRAINT [FK_IPDRegisteration_Staff_ThirdConsultantId] FOREIGN KEY ([ThirdConsultantId]) REFERENCES [Med].[Staff] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230306113944_IPDRegisterationNewFields')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230306113944_IPDRegisterationNewFields', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    DECLARE @var22 sysname;
    SELECT @var22 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Gnr].[ReportTemplate]') AND [c].[name] = N'Content');
    IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Gnr].[ReportTemplate] DROP CONSTRAINT [' + @var22 + '];');
    ALTER TABLE [Gnr].[ReportTemplate] ALTER COLUMN [Content] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270649+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270644+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270651+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270650+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270653+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270652+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270655+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270654+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270657+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270656+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270659+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270658+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270661+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270660+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270663+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270661+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T13:42:34.1270665+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270663+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270608+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270605+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270610+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270609+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270612+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270611+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270613+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270613+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270615+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270614+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270616+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270615+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270618+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270617+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270619+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270618+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270620+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270620+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270623+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270622+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T13:42:34.1270624+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270623+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T13:42:34.1251321+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1251309+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T13:42:34.1251323+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1251322+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T13:42:34.1251324+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1251324+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T13:42:34.1270681+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270679+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T13:42:34.1270682+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270682+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T13:42:34.1270684+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270683+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-11T13:42:34.1261484+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1251461+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-11T13:42:34.1270494+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1261487+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-11T13:42:34.1270552+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270551+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-11T13:42:34.1270553+03:30'', [ModifiedDate] = ''2023-03-11T13:42:34.1270553+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311101234_editReportTemplate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230311101234_editReportTemplate', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    DECLARE @var23 sysname;
    SELECT @var23 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[IPDRegisterationService]') AND [c].[name] = N'Description');
    IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Med].[IPDRegisterationService] DROP CONSTRAINT [' + @var23 + '];');
    ALTER TABLE [Med].[IPDRegisterationService] ALTER COLUMN [Description] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    DECLARE @var24 sysname;
    SELECT @var24 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[IPDRegisterationRoom]') AND [c].[name] = N'Description');
    IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Med].[IPDRegisterationRoom] DROP CONSTRAINT [' + @var24 + '];');
    ALTER TABLE [Med].[IPDRegisterationRoom] ALTER COLUMN [Description] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    DECLARE @var25 sysname;
    SELECT @var25 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[IPDRegisterationPayment]') AND [c].[name] = N'Description');
    IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [Med].[IPDRegisterationPayment] DROP CONSTRAINT [' + @var25 + '];');
    ALTER TABLE [Med].[IPDRegisterationPayment] ALTER COLUMN [Description] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689762+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689756+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689764+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689762+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689766+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689764+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689770+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689766+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689772+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689771+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689774+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689773+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689776+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689774+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689778+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689776+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:02:56.5689779+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689778+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689721+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689718+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689723+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689722+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689724+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689723+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689726+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689725+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689727+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689726+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689728+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689728+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689730+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689729+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689732+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689731+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689734+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689733+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689736+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689735+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:02:56.5689738+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689737+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T15:02:56.5670075+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5670064+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T15:02:56.5670078+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5670077+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T15:02:56.5670079+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5670078+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T15:02:56.5689799+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689797+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T15:02:56.5689800+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689799+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T15:02:56.5689801+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689801+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-11T15:02:56.5680457+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5670273+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-11T15:02:56.5689650+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5680461+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-11T15:02:56.5689700+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689698+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-11T15:02:56.5689701+03:30'', [ModifiedDate] = ''2023-03-11T15:02:56.5689700+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113257_DescriptionNullableinIPDRegisteration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230311113257_DescriptionNullableinIPDRegisteration', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    DECLARE @var26 sysname;
    SELECT @var26 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Med].[IPDRegisterationPayment]') AND [c].[name] = N'ChequeNumber');
    IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [Med].[IPDRegisterationPayment] DROP CONSTRAINT [' + @var26 + '];');
    ALTER TABLE [Med].[IPDRegisterationPayment] ALTER COLUMN [ChequeNumber] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818608+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818601+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818610+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818609+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818612+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818611+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818614+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818613+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818616+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818615+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818618+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818617+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818620+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818619+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818622+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818620+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-11T15:04:45.2818623+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818622+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818506+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818504+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818508+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818507+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818509+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818509+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818569+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818568+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818570+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818570+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818572+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818571+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818573+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818573+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818575+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818574+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818576+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818575+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818579+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818578+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-11T15:04:45.2818580+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818580+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T15:04:45.2799279+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2799267+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T15:04:45.2799282+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2799281+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-11T15:04:45.2799283+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2799282+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T15:04:45.2818642+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818641+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T15:04:45.2818644+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818643+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-11T15:04:45.2818645+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818644+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-11T15:04:45.2809429+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2799484+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-11T15:04:45.2818427+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2809433+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-11T15:04:45.2818481+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818480+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-11T15:04:45.2818483+03:30'', [ModifiedDate] = ''2023-03-11T15:04:45.2818482+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230311113445_ChequeNumberNullableinIPDRegisteration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230311113445_ChequeNumberNullableinIPDRegisteration', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    ALTER TABLE [Med].[OPDBill] ADD [PrintCount] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [OPDBillId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [PrintCount] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377477+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377472+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377480+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377478+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377482+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377481+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377484+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377483+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377486+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377485+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377488+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377487+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377490+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377489+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377493+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377491+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T08:50:48.5377495+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377494+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377435+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377433+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377437+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377436+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377438+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377438+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377440+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377439+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377442+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377441+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377443+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377442+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377445+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377444+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377447+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377446+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377448+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377447+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377450+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377449+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T08:50:48.5377452+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377451+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-12T08:50:48.5358566+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5358552+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-12T08:50:48.5358569+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5358568+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-12T08:50:48.5358571+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5358570+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-12T08:50:48.5377516+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377514+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-12T08:50:48.5377518+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377517+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-12T08:50:48.5377519+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377518+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-12T08:50:48.5368460+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5358729+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-12T08:50:48.5377282+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5368465+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-12T08:50:48.5377337+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377335+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-12T08:50:48.5377340+03:30'', [ModifiedDate] = ''2023-03-12T08:50:48.5377339+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312052049_addPrintCount')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230312052049_addPrintCount', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    ALTER TABLE [Med].[OPDBill] ADD [PaidAmount] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    CREATE TABLE [Med].[OPDBillPayment] (
        [Id] int NOT NULL IDENTITY,
        [OPDBillId] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [Amount] int NOT NULL,
        [Description] nvarchar(max) NULL,
        [CreatedDate] datetime2 NOT NULL,
        [CreatedUser] nvarchar(max) NULL,
        [ModifiedDate] datetime2 NOT NULL,
        [ModifiedUser] nvarchar(max) NULL,
        CONSTRAINT [PK_OPDBillPayment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OPDBillPayment_OPDBill_OPDBillId] FOREIGN KEY ([OPDBillId]) REFERENCES [Med].[OPDBill] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973161+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973153+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973163+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973162+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973165+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973164+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973212+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973210+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973214+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973213+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973216+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973215+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973218+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973217+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973220+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973219+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-12T15:40:02.0973222+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973221+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942562+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942559+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942565+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942562+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942566+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942566+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942568+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942567+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942569+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942568+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942571+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942570+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942572+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942571+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942573+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942573+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942575+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942574+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942577+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942576+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-12T15:40:02.0942578+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942577+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-12T15:40:02.0922191+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0922179+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-12T15:40:02.0922194+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0922193+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-12T15:40:02.0922195+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0922194+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-12T15:40:02.0973311+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973309+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-12T15:40:02.0973312+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973312+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-12T15:40:02.0973314+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0973313+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-12T15:40:02.0932553+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0922341+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-12T15:40:02.0942436+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0932559+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-12T15:40:02.0942535+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942533+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-12T15:40:02.0942537+03:30'', [ModifiedDate] = ''2023-03-12T15:40:02.0942536+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    CREATE INDEX [IX_OPDBillPayment_OPDBillId] ON [Med].[OPDBillPayment] ([OPDBillId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230312121002_addOPDBillPayment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230312121002_addOPDBillPayment', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    ALTER TABLE [Med].[OPDBill] ADD [Canceled] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734916+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734909+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734919+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734917+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734922+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734920+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734924+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734922+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734926+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734924+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734928+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734927+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734930+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734929+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734932+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734931+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-03-15T13:16:01.3734939+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734933+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734861+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734853+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734863+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734862+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734865+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734864+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734866+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734866+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734868+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734867+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734869+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734868+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734875+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734874+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734879+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734876+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734887+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734886+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734889+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734889+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-03-15T13:16:01.3734891+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734890+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-15T13:16:01.3711379+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3711361+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-15T13:16:01.3711382+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3711381+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-03-15T13:16:01.3711384+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3711383+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-15T13:16:01.3734960+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734958+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-15T13:16:01.3734962+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734961+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-03-15T13:16:01.3734963+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734962+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-15T13:16:01.3725328+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3711604+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-03-15T13:16:01.3734623+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3725339+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-15T13:16:01.3734826+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734823+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-03-15T13:16:01.3734828+03:30'', [ModifiedDate] = ''2023-03-15T13:16:01.3734827+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230315094601_CancelOPdBill')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230315094601_CancelOPdBill', N'7.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    ALTER TABLE [Med].[IPDRegisteration] ADD [Canceled] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046767+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046756+03:30''
    WHERE [Id] = 101;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046773+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046770+03:30''
    WHERE [Id] = 102;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046776+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046774+03:30''
    WHERE [Id] = 103;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046780+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046777+03:30''
    WHERE [Id] = 201;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046782+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046781+03:30''
    WHERE [Id] = 202;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046785+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046783+03:30''
    WHERE [Id] = 701;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046788+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046786+03:30''
    WHERE [Id] = 702;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046792+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046790+03:30''
    WHERE [Id] = 801;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformation] SET [CreatedDate] = ''2023-04-16T15:16:56.7046799+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046794+03:30''
    WHERE [Id] = 802;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046546+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046540+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046551+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046547+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046553+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046551+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046557+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046556+03:30''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046559+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046558+03:30''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046565+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046564+03:30''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046586+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046585+03:30''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046605+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046589+03:30''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046692+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046623+03:30''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046695+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046694+03:30''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[BasicInformationCategory] SET [CreatedDate] = ''2023-04-16T15:16:56.7046697+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046696+03:30''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-04-16T15:16:56.6965881+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.6965845+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-04-16T15:16:56.6965887+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.6965886+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[Role] SET [CreatedDate] = ''2023-04-16T15:16:56.6965890+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.6965888+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-04-16T15:16:56.7046852+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046847+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-04-16T15:16:56.7046854+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046853+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Gnr].[Setting] SET [CreatedDate] = ''2023-04-16T15:16:56.7046856+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046855+03:30''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-04-16T15:16:56.6987402+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.6966604+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[User] SET [CreatedDate] = ''2023-04-16T15:16:56.7045550+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.6987477+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-04-16T15:16:56.7046457+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046450+03:30''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    EXEC(N'UPDATE [Sec].[UserRole] SET [CreatedDate] = ''2023-04-16T15:16:56.7046461+03:30'', [ModifiedDate] = ''2023-04-16T15:16:56.7046460+03:30''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230416114657_addIPDCanceled')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230416114657_addIPDCanceled', N'7.0.2');
END;
GO

COMMIT;
GO

