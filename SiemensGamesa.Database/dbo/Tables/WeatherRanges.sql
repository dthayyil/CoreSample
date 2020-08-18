CREATE TABLE [dbo].[WeatherRanges] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Min]       INT            NOT NULL,
    [Max]       INT            NOT NULL,
    [Adjective] NVARCHAR (500) NOT NULL,
    CONSTRAINT [PK_WeatherRanges] PRIMARY KEY CLUSTERED ([Id] ASC)
);

