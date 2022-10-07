PRINT N'Dropping [dbo].[IogvRef_NpaI]...';
GO
ALTER TABLE [dbo].[NpaI] DROP CONSTRAINT [IogvRef_NpaI];
GO
PRINT N'Creating [dbo].[IogvRef_NpaI]...';
GO
ALTER TABLE [dbo].[NpaI] WITH NOCHECK
    ADD CONSTRAINT [IogvRef_NpaI] FOREIGN KEY ([Iogv]) REFERENCES [dbo].[IogvRef] ([Iogv]) ON UPDATE CASCADE;
GO
PRINT N'Checking existing data against newly created constraints';
GO
USE [$(DatabaseName)];
GO
ALTER TABLE [dbo].[NpaI] WITH CHECK CHECK CONSTRAINT [IogvRef_NpaI];
GO
PRINT N'Update complete.';
GO
