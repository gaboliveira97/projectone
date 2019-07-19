CREATE TABLE [dbo].[Locacao]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    [Livro] INT NOT NULL, 
    [Usuario] INT NOT NULL, 
	[Tipo] INT NOT NULL,
	[Devolucao] DATETIME NOT NULL,
    [Ativo] BIT NOT NULL, 
	--[Observacao] VARCHAR(500) NULL,
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL,
	[DataInc] DATETIME NOT NULL DEFAULT GETDATE(),
    [DataAlt] DATETIME NOT NULL DEFAULT GETDATE(),
    
	CONSTRAINT [FK_Locacao_Livros] 
	FOREIGN KEY ([Livro]) 
	REFERENCES [Livro]([Id]),

	CONSTRAINT [FK_Locacao_UsuarioAloc] 
	FOREIGN KEY ([Usuario]) 
	REFERENCES [Usuarios]([Id]),

	CONSTRAINT [FK_Locacao_UsuarioInc] 
	FOREIGN KEY ([UsuInc]) 
	REFERENCES [Usuarios]([Id]),

	CONSTRAINT [FK_Locacao_UsuAlt] 
	FOREIGN KEY ([UsuAlt]) 
	REFERENCES [Usuarios]([Id]),
	
)
