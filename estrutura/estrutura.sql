

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[f_cli_for](
	[cod_cfo] [int] IDENTITY(1,1) NOT NULL,
	[nome_fantasia] [varchar](150) NOT NULL,
	[razao] [varchar](150) NOT NULL,
	[cpf_cnpj] [varchar](50) NULL,
	[endereco] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[f_cli_for] ADD PRIMARY KEY CLUSTERED 
(
	[cod_cfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

------------------------------------------------------------------------------


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_alunos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](150) NOT NULL,
	[matricula] [varchar](8) NOT NULL,
	[notas] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_alunos] ADD  CONSTRAINT [PK_tb_alunos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
