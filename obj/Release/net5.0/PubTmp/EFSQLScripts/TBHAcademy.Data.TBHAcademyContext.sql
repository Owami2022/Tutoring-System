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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [FirstName] nvarchar(100) NULL,
        [LastName] nvarchar(100) NULL,
        [DOB] Date NOT NULL,
        [Gender] nvarchar(100) NULL,
        [Status] nvarchar(100) NULL,
        [Role] nvarchar(100) NULL,
        [date] datetime2 NOT NULL,
        [MyPicture] varbinary(max) NULL,
        [AddressLine1] nvarchar(max) NULL,
        [AddressLine2] nvarchar(max) NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [Faculty] (
        [FacultyId] int NOT NULL IDENTITY,
        [FacultyName] nvarchar(max) NOT NULL,
        [FacultyDescription] nvarchar(max) NOT NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_Faculty] PRIMARY KEY ([FacultyId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [TeamMark] (
        [Teamid] int NOT NULL IDENTITY,
        [StName] nvarchar(max) NOT NULL,
        [StSurname] nvarchar(max) NOT NULL,
        [TeamOne] int NOT NULL,
        [TeamTwo] int NOT NULL,
        [TeamThree] int NOT NULL,
        [TeamFour] int NOT NULL,
        CONSTRAINT [PK_TeamMark] PRIMARY KEY ([Teamid])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [Enroll] (
        [EnrolledID] int NOT NULL IDENTITY,
        [DateErolled] datetime2 NOT NULL,
        [ModuleID] int NOT NULL,
        [StudentID] nvarchar(max) NOT NULL,
        [TBHAcademyUserId] nvarchar(450) NULL,
        CONSTRAINT [PK_Enroll] PRIMARY KEY ([EnrolledID]),
        CONSTRAINT [FK_Enroll_AspNetUsers_TBHAcademyUserId] FOREIGN KEY ([TBHAcademyUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [Course] (
        [CourseId] int NOT NULL IDENTITY,
        [CourseName] nvarchar(max) NOT NULL,
        [CourseDescription] nvarchar(max) NOT NULL,
        [Status] int NOT NULL,
        [FacultyId] int NOT NULL,
        CONSTRAINT [PK_Course] PRIMARY KEY ([CourseId]),
        CONSTRAINT [FK_Course_Faculty_FacultyId] FOREIGN KEY ([FacultyId]) REFERENCES [Faculty] ([FacultyId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [Modules] (
        [ModuleId] int NOT NULL IDENTITY,
        [ModuleCode] nvarchar(max) NOT NULL,
        [ModuleName] nvarchar(max) NOT NULL,
        [Year] nvarchar(max) NOT NULL,
        [CourseID] int NOT NULL,
        CONSTRAINT [PK_Modules] PRIMARY KEY ([ModuleId]),
        CONSTRAINT [FK_Modules_Course_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Course] ([CourseId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [AssignModules] (
        [AssignedID] int NOT NULL IDENTITY,
        [TutorID] nvarchar(max) NOT NULL,
        [ModuleID] int NOT NULL,
        [DateAssigned] datetime2 NOT NULL,
        [TBHAcademyUserId] nvarchar(450) NULL,
        [ModulesModuleId] int NULL,
        CONSTRAINT [PK_AssignModules] PRIMARY KEY ([AssignedID]),
        CONSTRAINT [FK_AssignModules_AspNetUsers_TBHAcademyUserId] FOREIGN KEY ([TBHAcademyUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_AssignModules_Modules_ModulesModuleId] FOREIGN KEY ([ModulesModuleId]) REFERENCES [Modules] ([ModuleId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE TABLE [Content] (
        [ContentId] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [TopicName] nvarchar(max) NOT NULL,
        [TopicDescription] nvarchar(max) NULL,
        [DocumentDescription1] nvarchar(max) NULL,
        [Document1] varbinary(max) NULL,
        [DocumentDescription2] nvarchar(max) NULL,
        [Document2] varbinary(max) NULL,
        [DocumentDescription3] nvarchar(max) NULL,
        [Document3] varbinary(max) NULL,
        [DocumentDescription4] nvarchar(max) NULL,
        [Document4] varbinary(max) NULL,
        [DocumentDescription5] nvarchar(max) NULL,
        [Document5] varbinary(max) NULL,
        [LinkDescription1] nvarchar(max) NULL,
        [Link1] nvarchar(max) NULL,
        [LinkDescription2] nvarchar(max) NULL,
        [Link2] nvarchar(max) NULL,
        [LinkDescription3] nvarchar(max) NULL,
        [Link3] nvarchar(max) NULL,
        [LinkDescription4] nvarchar(max) NULL,
        [Link4] nvarchar(max) NULL,
        [LinkDescription5] nvarchar(max) NULL,
        [Link5] nvarchar(max) NULL,
        [AssignId] int NOT NULL,
        [AssignModulesAssignedID] int NULL,
        CONSTRAINT [PK_Content] PRIMARY KEY ([ContentId]),
        CONSTRAINT [FK_Content_AssignModules_AssignModulesAssignedID] FOREIGN KEY ([AssignModulesAssignedID]) REFERENCES [AssignModules] ([AssignedID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_AssignModules_ModulesModuleId] ON [AssignModules] ([ModulesModuleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_AssignModules_TBHAcademyUserId] ON [AssignModules] ([TBHAcademyUserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_Content_AssignModulesAssignedID] ON [Content] ([AssignModulesAssignedID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_Course_FacultyId] ON [Course] ([FacultyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_Enroll_TBHAcademyUserId] ON [Enroll] ([TBHAcademyUserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    CREATE INDEX [IX_Modules_CourseID] ON [Modules] ([CourseID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220913112322_InitDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220913112322_InitDB', N'5.0.17');
END;
GO

COMMIT;
GO

