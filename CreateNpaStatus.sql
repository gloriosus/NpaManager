--
CREATE TABLE [dbo].[NpaStatusRef](
    [Status] VARCHAR(64) NOT NULL, 
    [StatusOrder] INT NOT NULL DEFAULT 2, 
    PRIMARY KEY ([Status])
);
GO

Insert into [NpaStatusRef] ([Status], [StatusOrder]) Values ('В работе', 1);
Insert into [NpaStatusRef] ([Status], [StatusOrder]) Values ('Завершен', 2);
Insert into [NpaStatusRef] ([Status], [StatusOrder]) Values ('Перенесен', 3);
Insert into [NpaStatusRef] ([Status], [StatusOrder]) Values ('Исключен', 4);
--Select [Status], [StatusOrder] From [NpaStatus];

-- Обновить таблицы проектов НПА
ALTER TABLE [dbo].[NpaI]
    ADD [Status] VARCHAR (64) DEFAULT 'В работе' NOT NULL;
GO
ALTER TABLE [dbo].[NpaII]
    ADD [Status] VARCHAR (64) DEFAULT 'В работе' NOT NULL;
GO
ALTER TABLE [dbo].[NpaIII]
    ADD [Status] VARCHAR (64) DEFAULT 'В работе' NOT NULL;
GO
ALTER TABLE [dbo].[NpaIV]
    ADD [Status] VARCHAR (64) DEFAULT 'В работе' NOT NULL;
GO

ALTER TABLE [dbo].[NpaI] WITH NOCHECK
    ADD CONSTRAINT [NpaStatusRef_NpaI] FOREIGN KEY ([Status]) REFERENCES [dbo].[NpaStatusRef] ([Status]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [dbo].[NpaII] WITH NOCHECK
    ADD CONSTRAINT [NpaStatusRef_NpaII] FOREIGN KEY ([Status]) REFERENCES [dbo].[NpaStatusRef] ([Status]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [dbo].[NpaIII] WITH NOCHECK
    ADD CONSTRAINT [NpaStatusRef_NpaIII] FOREIGN KEY ([Status]) REFERENCES [dbo].[NpaStatusRef] ([Status]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [dbo].[NpaIV] WITH NOCHECK
    ADD CONSTRAINT [NpaStatusRef_NpaIV] FOREIGN KEY ([Status]) REFERENCES [dbo].[NpaStatusRef] ([Status]) ON DELETE CASCADE ON UPDATE CASCADE;
GO