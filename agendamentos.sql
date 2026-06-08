CREATE TABLE [dbo].[Agendamentos] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NomeCliente]     NVARCHAR (100) NOT NULL,
    [Telefone]        NVARCHAR (20)  NOT NULL,
    [DataAgendamento] DATE           NOT NULL,
    [HoraAgendamento] NVARCHAR (10)  NOT NULL,
    [Servico]         NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

