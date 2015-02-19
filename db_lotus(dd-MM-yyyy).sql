CREATE DATABASE db_lotus
GO
USE [db_lotus]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
-------------TABELA UNIDADE ESCOLAR---------------

CREATE TABLE [dbo].[tb_unidade_escolar](
	[cd_unidade] [int] IDENTITY(1,1) NOT NULL,
	[nm_unidade] [varchar](max) NOT NULL,
	[ds_email_unidade] [varchar](max) NOT NULL,
	[ds_endereco] [varchar](max) NOT NULL,
	[cd_telefone] [varchar](20) NOT NULL,
	[cd_interno] [int] unique NOT NULL,
	[im_logo] [varchar](max) NULL,


 CONSTRAINT [PK_tb_sede] PRIMARY KEY CLUSTERED 
(
	[cd_unidade] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

--------TB CURSO------- 

CREATE TABLE [dbo].[tb_curso](
	[cd_curso] [int] IDENTITY(1,1) NOT NULL,
	[nm_curso] [varchar](max) NOT NULL,
	[sg_curso] [varchar](10) NOT NULL,
	[qt_modulo] [int] NOT NULL,
	[ds_tipo_curso] [varchar] (15) NOT NULL,
	[qt_aula_sem] [int] NOT NULL,
	[cd_manha] [bit] NOT NULL,
	[cd_tarde] [bit] NOT NULL,
	[cd_noite] [bit] NOT NULL,

	
	CONSTRAINT [PK_tb_curso] PRIMARY KEY CLUSTERED 
(
	[cd_curso] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


--------TB JUNÇÃO DO MÓDULO NO CURSO------- 

CREATE TABLE [dbo].[tb_juncao_modulo_curso](
	[cd_modulo] [int] IDENTITY(1,1) NOT NULL,
	[ds_modulo] [varchar](15) NOT NULL,
	[cd_curso] [int] NOT NULL,
 CONSTRAINT [PK_tb_juncao_modulo_curso] PRIMARY KEY CLUSTERED 
(
	[cd_modulo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


------TABELA DISCIPLINAS--------

CREATE TABLE [dbo].[tb_disciplina](

	[cd_disciplina] [int] IDENTITY(1,1) NOT NULL,
	[nm_disciplina] [varchar](max) NOT NULL,
	[sg_disciplina] [varchar](10) NOT NULL,
	[qt_max_aulas] [int] NOT NULL,

 CONSTRAINT [PK_tb_disciplina] PRIMARY KEY CLUSTERED 
(
	[cd_disciplina] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


------TABELA JUNÇÃO DISCIPLINA NO MODULO DO CURSO--------

CREATE TABLE [dbo].[tb_juncao_disciplina_modulo_curso](
	[cd_juncao_disciplina_modulo_curso] [int] IDENTITY(1,1) NOT NULL,
	[ds_juncao_disciplina_modulo_curso] [varchar](max) NOT NULL,
	[cd_disciplina] [int] NOT NULL,
	[cd_modulo] [int] NOT NULL
 
CONSTRAINT [PK_tb_juncao_disciplina_modulo_curso] PRIMARY KEY CLUSTERED 
(
	[cd_juncao_disciplina_modulo_curso] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

--------------TABELA TURMA--------------

CREATE TABLE [dbo].[tb_turma](
	[cd_turma] [int] IDENTITY(1,1) NOT NULL,
	[nm_turma] [varchar](max) NOT NULL,
	[cd_periodo] [int] NOT NULL,
	[cd_modulo] [int] NOT NULL,
	[cd_curso] [int] NOT NULL,
	[cd_semestre] [int] NOT NULL,
	[dt_ano] [varchar](4) NOT NULL,
	[dt_inisemestre] [datetime] NOT NULL,
	[dt_fimsemestre] [datetime] NOT NULL,

	
 CONSTRAINT [PK_tb_turma] PRIMARY KEY CLUSTERED 
(
	[cd_turma] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



------------TABELA ALUNO-----------


CREATE TABLE [dbo].[tb_aluno](
	[cd_aluno] [int] IDENTITY(1,1) NOT NULL,
	[nm_aluno] [varchar](max) NOT NULL,
	[ds_endereco] [varchar](max) NOT NULL,
	[cd_rg] [varchar](20) NOT NULL,
	[dt_nascimento] [datetime] NOT NULL,
	[ds_email] [varchar](max) NULL,
	[cd_telefone] [varchar](20) NULL,
	[cd_matricula] [varchar](50) unique NOT NULL,
	[ds_observacoes] [varchar](max) NULL,
	[ic_sexo_m] [char] NOT NULL,
	[im_foto_aluno] [varchar](max) NULL,

 CONSTRAINT [PK_tb_aluno] PRIMARY KEY CLUSTERED 
(
	[cd_aluno] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



----TABELA JUNÇÃO DA DO ALUNO NA TURMA-------

CREATE TABLE [dbo].[tb_juncao_turma_aluno](
	[cd_turma] [int] NOT NULL,	
	[cd_aluno] [int] NOT NULL,

) ON [PRIMARY]

GO
SET ANSI_PADDING OFF



------TABELA PRESENÇA ALUNO-------

CREATE TABLE [dbo].[tb_presenca_aluno](
	[cd_presenca] [int] IDENTITY(1,1) NOT NULL,
	[cd_aluno] [int] NOT NULL,
	[cd_disciplina] [int] NOT NULL,
	[cd_turma] [int] NOT NULL,
	[dt_presenca] [datetime] NOT NULL,
	[ds_aula] [int] NOT NULL,
 CONSTRAINT [PK_tb_presenca_aluno] PRIMARY KEY CLUSTERED 
(
	[cd_presenca] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF



----TABELA FALTAS ALUNOS-------

CREATE TABLE [dbo].[tb_faltas_aluno](
	[cd_falta] [int] IDENTITY(1,1) NOT NULL,
	[cd_aluno] [int] NOT NULL,
	[cd_disciplina] [int] NOT NULL,
	[cd_turma] [int] NOT NULL,
	[dt_falta] [datetime] NOT NULL,
	[ds_aula] [int] NOT NULL,
 CONSTRAINT [PK_tb_faltas_aluno] PRIMARY KEY CLUSTERED 
(
	[cd_falta] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF



-------TABELA DISPENSA---------


CREATE TABLE [dbo].[tb_dispensa](
	[cd_aluno] [int] NOT NULL,
	[cd_disciplina] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF


----------------TB PROFESSOR-------------

CREATE TABLE [dbo].[tb_professor](
	[cd_professor] [int] IDENTITY(1,1) NOT NULL,
	[nm_professor] [varchar](MAX) NOT NULL,
	[ds_endereco] [varchar](MAX) NOT NULL,
	[cd_telefone] [varchar](15) NOT NULL,
	[cd_celular] [varchar](15) NOT NULL,
	[dt_nascimento] [datetime] NULL,	[cd_rg] [varchar](20) NOT NULL,
	[cd_cpf] [varchar](20) unique NOT NULL,
	[ic_sexo_m] [char] NOT NULL,
	[im_professor] [varchar](max) NULL,
	
 CONSTRAINT [PK_tb_professor] PRIMARY KEY CLUSTERED 
(
	[cd_professor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

------TABELA DISCIPLINAS MINISTRADAS--------

CREATE TABLE [dbo].[tb_disciplina_ministrada](

	[cd_disciplina_ministrada] [int] IDENTITY(1,1) NOT NULL,
	[ds_disciplina_ministrada] [varchar](50) NOT NULL,
	[cd_disciplina] [int] NOT NULL,
	[cd_professor] [int] NOT NULL,
	[cd_turma] [int] NOT NULL,


 CONSTRAINT [PK_tb_disciplina_ministrada] PRIMARY KEY CLUSTERED 
(
	[cd_disciplina_ministrada] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

-------TABELAS FALTAS PROFESSORES----------

CREATE TABLE [dbo].[tb_faltas_professor](
	[cd_falta] [int] IDENTITY(1,1) NOT NULL,
	[cd_professor] [int] NOT NULL,
	[dt_falta1] [datetime] NOT NULL,
	[dt_falta2][datetime] NULL,
	[ds_obs] [varchar](max) NULL,
	[ds_tipo_falta] [varchar](50) NULL,
 CONSTRAINT [PK_tb_faltas_professor] PRIMARY KEY CLUSTERED 
(
	[cd_falta] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


----TABELA Adcional Noturno-------

CREATE TABLE [dbo].[tb_ad_noturno](
	[cd_ad_noturno] [int] IDENTITY(1,1) NOT NULL,
	[cd_professor] [int] NOT NULL,
	[vl_ad_noturno] [numeric](18,2) NOT NULL,
	[dt_ad_noturno] [datetime] NOT NULL,
 CONSTRAINT [PK_tb_ad_noturno] PRIMARY KEY CLUSTERED 
(
	[cd_ad_noturno] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF


----------TABELA AULA-------------


CREATE TABLE [dbo].[tb_aula](
	[cd_aula] [int] IDENTITY(1,1) NOT NULL,
	[cd_turma] [int] NOT NULL,
	[cd_disciplina] [int] NOT NULL,
	[ds_dia] [varchar](7) NOT NULL,
	[ds_aula] [int] NOT NULL,
 CONSTRAINT [PK_tb_aula] PRIMARY KEY CLUSTERED 
(
	[cd_aula] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

-------TABELA AULA DADA---------

CREATE TABLE [dbo].[tb_aula_dada](
	[cd_aula] [int] IDENTITY(1,1) NOT NULL,
	[cd_disciplina_dada] [int] NOT NULL,
	[cd_disciplina_reposta] [int] NULL,
	[cd_turma] [int] NOT NULL,
	[dt_aula] [datetime] NOT NULL,
	[ds_aula] [varchar](50) NOT NULL,
	[vl_aula] [int] NOT NULL,
 CONSTRAINT [PK_tb_aula_dada] PRIMARY KEY CLUSTERED 
(
	[cd_aula] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF


------------TABELA Eventos----------------

CREATE TABLE [dbo].[tb_evento](
	[cd_evento] [int] IDENTITY(1,1) NOT NULL,
	[dt_evento] [datetime] NOT NULL,
	[nm_evento] [varchar](max) NOT NULL,
	[ds_evento] [varchar](max) NULL,

 CONSTRAINT [PK_tb_eventos] PRIMARY KEY CLUSTERED 
(
	[cd_evento] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


----------TB USUARIO-------------

CREATE TABLE [dbo].[tb_usuario](
	[cd_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nm_usuario] [varchar](50) unique NOT NULL,
	[ds_senha] [varchar](50) NOT NULL,
	[ds_email] [varchar](100) unique NOT NULL,
	[ds_dica_senha] [varchar](50) NULL,
	[ds_tipo_usuario][varchar](15) NOT NULL,
	[ds_caminho_papel_parede] [varchar](MAX) NULL,
	[cor_tema] [int] NULL,
	[ds_estado] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tb_usuario] PRIMARY KEY CLUSTERED 
(
	[cd_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF


----TABELA GEral-------

CREATE TABLE [dbo].[tb_geral](
	[cd_geral] [int] IDENTITY(1,1) NOT NULL,
	[cd_funcionario] [int] NOT NULL,
	[qt_jan_faltas] [int] NULL,
	[vl_jan_adn] [varchar](50) NULL,
	[qt_fev_faltas] [int] NULL,
	[vl_fev_adn] [varchar](50) NULL,
	[qt_mar_faltas] [int] NULL,
	[vl_mar_adn] [varchar](50) NULL,
	[qt_abr_faltas] [int] NULL,
	[vl_abr_adn] [varchar](50) NULL,
	[qt_mai_faltas] [int] NULL,
	[vl_mai_adn] [varchar](50) NULL,
	[qt_jun_faltas] [int] NULL,
	[vl_jun_adn] [varchar](50) NULL,
	[qt_jul_faltas] [int] NULL,
	[vl_jul_adn] [varchar](50) NULL,
	[qt_ago_faltas] [int] NULL,
	[vl_ago_adn] [varchar](50) NULL,
	[qt_set_faltas] [int] NULL,
	[vl_set_adn] [varchar](50) NULL,
	[qt_out_faltas] [int] NULL,
	[vl_out_adn] [varchar](50) NULL,
	[qt_nov_faltas] [int] NULL,
	[vl_nov_adn] [varchar](50) NULL,
	[qt_dez_faltas] [int] NULL,
	[vl_dez_adn] [varchar](50) NULL,
	[qt_total_faltas] [int] NULL,
	[vl_total_adn] [varchar](50) NULL,
 CONSTRAINT [PK_tb_geral] PRIMARY KEY CLUSTERED 
(
	[cd_geral] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_juncao_disciplina_modulo_curso_tb_juncao_modulo_curso]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_juncao_disciplina_modulo_curso]'))
ALTER TABLE [dbo].[tb_juncao_disciplina_modulo_curso] WITH CHECK ADD  CONSTRAINT [FK_tb_juncao_disciplina_modulo_curso_tb_juncao_modulo_curso] FOREIGN KEY([cd_modulo])
REFERENCES [dbo].[tb_juncao_modulo_curso] ([cd_modulo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_juncao_disciplina_modulo_curso] CHECK CONSTRAINT [FK_tb_juncao_disciplina_modulo_curso_tb_juncao_modulo_curso]
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_juncao_disciplina_modulo_curso_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_juncao_disciplina_modulo_curso]'))
ALTER TABLE [dbo].[tb_juncao_disciplina_modulo_curso] WITH CHECK ADD  CONSTRAINT [FK_tb_juncao_disciplina_modulo_curso_tb_disciplina] FOREIGN KEY([cd_disciplina])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_juncao_disciplina_modulo_curso] CHECK CONSTRAINT [FK_tb_juncao_disciplina_modulo_curso_tb_disciplina]
GO

------TB_DISCIPLINAS MINISTRADAS------
--cd_disciplina
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_disciplina_ministrada_tb_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_disciplina_ministrada]'))
ALTER TABLE [dbo].[tb_disciplina_ministrada]  WITH CHECK ADD  CONSTRAINT [FK_tb_disciplina_ministrada_tb_disciplina] FOREIGN KEY([cd_disciplina])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_disciplina_ministrada] CHECK CONSTRAINT [FK_tb_disciplina_ministrada_tb_disciplina]
GO

--cd_professor
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_disciplina_ministrada_tb_professor]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_disciplina_ministrada]'))
ALTER TABLE [dbo].[tb_disciplina_ministrada]  WITH CHECK ADD  CONSTRAINT [FK_tb_disciplina_ministrada_tb_professor] FOREIGN KEY([cd_professor])
REFERENCES [dbo].[tb_professor] ([cd_professor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_disciplina_ministrada] CHECK CONSTRAINT [FK_tb_disciplina_ministrada_tb_professor]
GO

--cd_turma
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_disciplina_ministrada_tb_turma]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_disciplina_ministrada]'))
ALTER TABLE [dbo].[tb_disciplina_ministrada]  WITH CHECK ADD  CONSTRAINT [FK_tb_disciplina_ministrada_tb_turma] FOREIGN KEY([cd_turma])
REFERENCES [dbo].[tb_turma] ([cd_turma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_disciplina_ministrada] CHECK CONSTRAINT [FK_tb_disciplina_ministrada_tb_turma]
GO
-------------
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_juncao_turma_aluno_tb_aluno]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_juncao_turma_aluno]'))
ALTER TABLE [dbo].[tb_juncao_turma_aluno]  WITH NOCHECK ADD  CONSTRAINT [FK_tb_juncao_turma_aluno_tb_aluno] FOREIGN KEY([cd_aluno])
REFERENCES [dbo].[tb_aluno] ([cd_aluno])
GO
ALTER TABLE [dbo].[tb_juncao_turma_aluno] NOCHECK CONSTRAINT [FK_tb_juncao_turma_aluno_tb_aluno]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_juncao_turma_aluno_tb_turma]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_juncao_turma_aluno]'))
ALTER TABLE [dbo].[tb_juncao_turma_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_juncao_turma_aluno_tb_turma] FOREIGN KEY([cd_turma])
REFERENCES [dbo].[tb_turma] ([cd_turma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_juncao_turma_aluno] CHECK CONSTRAINT [FK_tb_juncao_turma_aluno_tb_turma]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_presenca_aluno_tb_aluno]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_presenca_aluno]'))
ALTER TABLE [dbo].[tb_presenca_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_presenca_aluno_tb_aluno] FOREIGN KEY([cd_aluno])
REFERENCES [dbo].[tb_aluno] ([cd_aluno])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_presenca_aluno] CHECK CONSTRAINT [FK_tb_presenca_aluno_tb_aluno]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_presenca_aluno_tb_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_presenca_aluno]'))
ALTER TABLE [dbo].[tb_presenca_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_presenca_aluno_tb_disciplina] FOREIGN KEY([cd_disciplina])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_presenca_aluno] CHECK CONSTRAINT [FK_tb_presenca_aluno_tb_disciplina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_presenca_aluno_tb_turma]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_presenca_aluno]'))
ALTER TABLE [dbo].[tb_presenca_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_presenca_aluno_tb_turma] FOREIGN KEY([cd_turma])
REFERENCES [dbo].[tb_turma] ([cd_turma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_presenca_aluno] CHECK CONSTRAINT [FK_tb_presenca_aluno_tb_turma]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_dispensa_tb_aluno]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_dispensa]'))
ALTER TABLE [dbo].[tb_dispensa]  WITH CHECK ADD  CONSTRAINT [FK_tb_dispensa_tb_aluno] FOREIGN KEY([cd_aluno])
REFERENCES [dbo].[tb_aluno] ([cd_aluno])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_dispensa] CHECK CONSTRAINT [FK_tb_dispensa_tb_aluno]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_dispensa_tb_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_dispensa]'))
ALTER TABLE [dbo].[tb_dispensa]  WITH CHECK ADD  CONSTRAINT [FK_tb_dispensa_tb_disciplina] FOREIGN KEY([cd_disciplina])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_dispensa] CHECK CONSTRAINT [FK_tb_dispensa_tb_disciplina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_faltas_aluno_tb_aluno]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_faltas_aluno]'))
ALTER TABLE [dbo].[tb_faltas_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_faltas_aluno_tb_aluno] FOREIGN KEY([cd_aluno])
REFERENCES [dbo].[tb_aluno] ([cd_aluno])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_faltas_aluno] CHECK CONSTRAINT [FK_tb_faltas_aluno_tb_aluno]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_faltas_aluno_tb_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_faltas_aluno]'))
ALTER TABLE [dbo].[tb_faltas_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_faltas_aluno_tb_disciplina] FOREIGN KEY([cd_disciplina])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_faltas_aluno] CHECK CONSTRAINT [FK_tb_faltas_aluno_tb_disciplina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_faltas_aluno_tb_turma]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_faltas_aluno]'))
ALTER TABLE [dbo].[tb_faltas_aluno]  WITH CHECK ADD  CONSTRAINT [FK_tb_faltas_aluno_tb_turma] FOREIGN KEY([cd_turma])
REFERENCES [dbo].[tb_turma] ([cd_turma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_faltas_aluno] CHECK CONSTRAINT [FK_tb_faltas_aluno_tb_turma]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_aula_dada_tb_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_aula_dada]'))
ALTER TABLE [dbo].[tb_aula_dada]  WITH CHECK ADD  CONSTRAINT [FK_tb_aula_dada_tb_disciplina] FOREIGN KEY([cd_disciplina_dada])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_aula_dada] CHECK CONSTRAINT [FK_tb_aula_dada_tb_disciplina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_aula_dada_tb_disciplina1]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_aula_dada]'))
ALTER TABLE [dbo].[tb_aula_dada]  WITH CHECK ADD  CONSTRAINT [FK_tb_aula_dada_tb_disciplina1] FOREIGN KEY([cd_disciplina_reposta])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
GO
ALTER TABLE [dbo].[tb_aula_dada] CHECK CONSTRAINT [FK_tb_aula_dada_tb_disciplina1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_aula_dada_tb_turma]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_aula_dada]'))
ALTER TABLE [dbo].[tb_aula_dada]  WITH CHECK ADD  CONSTRAINT [FK_tb_aula_dada_tb_turma] FOREIGN KEY([cd_turma])
REFERENCES [dbo].[tb_turma] ([cd_turma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_aula_dada] CHECK CONSTRAINT [FK_tb_aula_dada_tb_turma]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_aula_tb_disciplina]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_aula]'))
ALTER TABLE [dbo].[tb_aula]  WITH CHECK ADD  CONSTRAINT [FK_tb_aula_tb_disciplina] FOREIGN KEY([cd_disciplina])
REFERENCES [dbo].[tb_disciplina] ([cd_disciplina])
GO
ALTER TABLE [dbo].[tb_aula] CHECK CONSTRAINT [FK_tb_aula_tb_disciplina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_aula_tb_turma]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_aula]'))
ALTER TABLE [dbo].[tb_aula]  WITH CHECK ADD  CONSTRAINT [FK_tb_aula_tb_turma] FOREIGN KEY([cd_turma])
REFERENCES [dbo].[tb_turma] ([cd_turma])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_aula] CHECK CONSTRAINT [FK_tb_aula_tb_turma]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_turma_tb_curso]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_turma]'))
ALTER TABLE [dbo].[tb_turma]  WITH CHECK ADD  CONSTRAINT [FK_tb_turma_tb_curso] FOREIGN KEY([cd_curso])
REFERENCES [dbo].[tb_curso] ([cd_curso])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_turma] CHECK CONSTRAINT [FK_tb_turma_tb_curso]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tb_turma_tb_juncao_modulo_curso]') AND parent_object_id = OBJECT_ID(N'[dbo].[tb_turma]'))
ALTER TABLE [dbo].[tb_turma]  WITH CHECK ADD  CONSTRAINT [FK_tb_turma_tb_juncao_modulo_curso] FOREIGN KEY([cd_modulo])
REFERENCES [dbo].[tb_juncao_modulo_curso] ([cd_modulo])
GO
ALTER TABLE [dbo].[tb_turma] CHECK CONSTRAINT [FK_tb_turma_tb_juncao_modulo_curso]
GO


--Inserção Unidade--

INSERT INTO [db_lotus].[dbo].[tb_unidade_escolar]
VALUES
('ETEC Dr.ª Ruth Cardoso','etecsaovicente@gmail.com','Praça Coronel Lopes, nº387','1334677153','131','logo.png')
INSERT INTO [db_lotus].[dbo].[tb_unidade_escolar]
VALUES
('Extensão Etec','extensao_etec@gmail.com','Área Continental, nº???','0000000000','132','logo.png')


--Inserção Curso--

INSERT INTO [db_lotus].[dbo].[tb_curso]
VALUES
('Informática','I',3,'Semestral',25,0,1,1)
INSERT INTO [db_lotus].[dbo].[tb_curso]
VALUES
('Edificações','E',3,'Semestral',25,0,1,1)
INSERT INTO [db_lotus].[dbo].[tb_curso]
VALUES
('Ensino Médio','EM',3,'Anual',25,1,0,0)


--INSERÇÃO MÓDULOS DO CURSO--

INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('1º Módulo',1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('2º Módulo',1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('3º Módulo',1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('1º Módulo',2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('2º Módulo',2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('3º Módulo',2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('1º Ano',3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('2º Ano',3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_modulo_curso]
VALUES
('3º Ano',3)


--Inserção Disciplinas--
----1º Módulo Informatica
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Organização Empresarial','OE',2)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Operação de Software Aplicativo','OSA',5)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Gestão de Sistemas Operacionais 1','GSO-I',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Lógica de Programação','LP',5)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Inglês Técnico','IT',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Linguagem Técninca e Trabalho','LTT',2)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Teoria e Linguagem de Banco de Dados 1','TLBD-I',5)
-------------------------------------------------
----2º Módulo Informatica
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Estrutura de Dados','ED',2)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Análise de Programação','AP',2)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Redes de Comunicação de Dados','RCD',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Desenvolvimento de Software Aplicativo 1','DSW-I',5)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Programação de Computadores 1','PC-I',5)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Gestão de Sistemas Operacionais 2','GSO-II',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Planejamento do Trabalho de Conclusão de Curso','PTCC',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Teoria e Linguagem de Banco de Dados 2','TLBD-II',2)
----------------------------------------------------
----3º Módulo Informatica
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Análise para Projetos de Programação','APP',2)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Ética, Cidadania e Qualdiade','ECQ',2)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Desenvolvimento de Software Aplicativo 2','DSW-II',5)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Programação de Computadores 2','PC-II',5)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Gestão de Sistemas Operacionais 3','GSO-III',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Desenvolvimento do Trabalho de Conclusão de Curso','DTCC',3)
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Programação para Internet','PI',5)
---------------------------------------------------
----1º Módulo Edificações
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Pedra 1','P-I',5)
---------------------------------------------------
----2º Módulo Edificações
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Pedra 2','P-II',5)
---------------------------------------------------
----3º Módulo Edificações
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Pedra 3','P-III',5)
---------------------------------------------------
----1º Módulo Ensino Médio
INSERT INTO [db_lotus].[dbo].[tb_disciplina]
VALUES
('Matemática 1','MAT-I',5)


--Inserção Junção Disciplina no Modulo do Curso--

INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('OE - Informática - 1º Módulo',1,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('OSA - Informática - 1º Módulo',2,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('GSO-I - Informática - 1º Módulo',3,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('LP - Informática - 1º Módulo',4,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('IT - Informática - 1º Módulo',5,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('LTT - Informática - 1º Módulo',6,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('TLBD - Informática - 1º Módulo',7,1)
------------------------------------------------------------------
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('ED - Informática - 2º Módulo',8,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('AP - Informática - 2º Módulo',9,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('RCD - Informática - 2º Módulo',10,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('DSW-I - Informática - 2º Módulo',11,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('PC-I - Informática - 2º Módulo',12,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('GSO-II - Informática - 2º Módulo',13,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('PTCC - Informática - 2º Módulo',14,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('TLBD-II - Informática - 2º Módulo',15,2)
------------------------------------------------------------------
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('APP - Informática - 3º Módulo',16,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('ECQ - Informática - 3º Módulo',17,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('DSW-II - Informática - 3º Módulo',18,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('PC-II - Informática - 3º Módulo',19,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('GSO-III - Informática - 3º Módulo',20,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('DTCC - Informática - 3º Módulo',21,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('PI - Informática - 3º Módulo',22,3)
-------------------------------------------------------------------
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('P-I - Edificações - 1º Módulo',23,4)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('P-II - Edificações - 2º Módulo',24,5)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('P-III - Edificações - 3º Módulo',25,6)
INSERT INTO [db_lotus].[dbo].[tb_juncao_disciplina_modulo_curso]
VALUES
('MAT-I - Ensino Médio - 1º Módulo',26,7)


--------Inserção Alunos-----------
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES
('Marina Isabel Carneiro','R.Pernambuco, nº50 apt 53H','42.132.129-5','1993/10/02','marina.isabel12@hotmail.com','1391077547','360','Aluno Destaque','F','marina_360.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('Gabrielle Carvalho Correa','Av. Newton Prado, nº496','44.342.568-1','1993/17/07','gabi.ccorrea@hotmail.com','1334676360','346','Aluno Destaque','F','gabi_346.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('Caio Margutti Alves','R. Floriano Peixoto, nº 80','37.195.325-X','1994/06/06','caioalves2k@hotmail.com','1334673109','812','Aluno Destaque','M','caio_812.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('Murilo Simões Sá Barreto','R. Adão Gonçalves, nº 150','43.937.311-6','1994/31/12','murilo@hotmail.com','1330562742','244','Aluno Destaque','M','murilo_244.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('Patrick Gustavo Carrega','R. Luis Steves Cordeiro N°9 Ap 2','49.218.977-8','1993/07/11','bonkura_rip@hotmail.com','1334656789','827','Aluno Destaque','M','patrick_827.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('David Cruz','R. São Lucas N°755','42.244.127-X','1991/02/09','david_pc09@hotmail.com','1334644489','815','Aluno Destaque','M','david_815.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('Felipe Ferreira de Andrade','R. Luis Barbosa N°350','56.218.337-8','1993/25/06','flp_o_cranio12@hotmail.com','1334644489','182','Aluno Destaque','M','felipe_182.png')
INSERT INTO [db_lotus].[dbo].[tb_aluno]
VALUES			
('Mauro Roberto Linck Mendonça','R. Jóse Lopez N°333','22.316.357-4','1993/06/02','nitro7x@hotmail.com','1334632189','206','Aluno Destaque','M','mauro_206.png')


--Inserção Dispensas--
---------Marina-----------
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(1,1)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(1,2)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(1,3)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(1,4)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(1,5)
---------Gabrielle-----
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(2,1)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(2,2)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(2,3)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(2,4)
---------David-------
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(6,5)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(6,1)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(6,2)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(6,3)
INSERT INTO [db_lotus].[dbo].[tb_dispensa]
VALUES
(6,4)


--Inserção Turma--

INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('1I2',2,1,1,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('2I2',2,2,1,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('3I2',2,3,1,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('1E2',2,4,2,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('2E2',2,5,2,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('3E2',2,6,2,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('1M1',1,7,3,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('2M1',1,8,3,1,2011,'2011/01/01','2011/30/06')
INSERT INTO [db_lotus].[dbo].[tb_turma]
VALUES
('3M1',1,9,3,1,2011,'2011/01/01','2011/30/06')


----INSERÇÃO ALUNO NA TURMA-------

INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,1)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,2)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,3)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,4)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,5)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,6)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,7)
INSERT INTO [db_lotus].[dbo].[tb_juncao_turma_aluno]
VALUES
(1,8)


--Inserção Professores--

INSERT INTO [db_lotus].[dbo].[tb_professor]
VALUES
('Maikel Linares','Casa da Daniela','1133333333','1199999999','1980/10/05','11.111.111-x','123.456.789-09','M','maikel.jpg')
INSERT INTO [db_lotus].[dbo].[tb_professor]
VALUES
('Daniela Uebele','Casa do Maikel','1122222222','1199999999','1980/10/06','22.222.222-x','588.564.773-94','F','daniela.jpg')
INSERT INTO [db_lotus].[dbo].[tb_professor]
VALUES
('Carlos de Oliveira','Av. Presidente Wilson','1144444444','1197799779','1980/10/07','33.333.333-x','310.127.586-56','M','carlos.jpg')
INSERT INTO [db_lotus].[dbo].[tb_professor]
VALUES
('Charles Bruno','R. 30 de Fevereiro','1155555555','1199777799','1980/10/08','55.555.555-x','181.312.536-86','M','charles.jpg')
INSERT INTO [db_lotus].[dbo].[tb_professor]
VALUES
('André Seoane','R. Pereira Costa','1155555555','1199777799','1980/10/09','66.666.666-x','871.834.861-09','M','andre.jpg')
INSERT INTO [db_lotus].[dbo].[tb_professor]
VALUES
('Fernando Di Gianni','R. XXX','1155555555','1199777799','1980/10/10','77.777.777-x','734.208.851-05','M','di_gianni.jpg')



--Inserção FALTAS Professores--
-------------Maikel------------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(1,'2011/03/01',null,'Acidente de Moto','Falta Médica')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(1,'2011/04/01',null,'Errou o Caminho','Falta Atraso')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(1,'2011/05/01',null,'Esqueceu de Vir','Falta Aula Justificada')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(1,'2011/06/01',null,'Capacitação de JAVA para WEB','Capacitação')
------------Daniela------------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(2,'2011/03/01',null,'','Falta Aula Injustificada')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(2,'2011/04/01',null,'Morte de Parente','Falta Aula Justificada')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(2,'2011/05/01','2011/06/01','Quebrou o Ombro','Licença Médica')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(2,'2011/06/01',null,'Conselho de Classe','Reunião')
--------------Carlos------------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(3,'2011/03/01',null,'Acidente de Taxi','Falta Médica')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(3,'2011/04/01',null,'Se Perdeu','Falta Atraso')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(3,'2011/05/01',null,'Engarrafamento','Falta Aula Justificada')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(3,'2011/06/01',null,'Capacitação de JAVA Enterprise','Capacitação')
---------------Charles-----------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(4,'2011/03/01',null,'Assaltado','Falta Atraso')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(4,'2011/04/01',null,'Assaltado','Falta Atraso')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(4,'2011/05/01',null,'Reunião com o Grêmio Estudantil','Reunião')
INSERT INTO [db_lotus].[dbo].[tb_faltas_professor]
VALUES
(4,'2011/06/01',null,'Capacitação de C++','Capacitação')


--Inserção Disciplinas Ministradas--
--------Maikel---------
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('OE - 1I2 - 2011 - 1º Semestre',1,1,1)
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('OSA - 1I2 - 2011 - 1º Semestre',2,1,1)
--------Daniela---------
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('GSO-I - 1I2 - 2011 - 1º Semestre',3,2,1)
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('LP - 1I2 - 2011 - 1º Semestre',4,2,1)
---------Carlos---------
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('GSO-I - 1I2 - 2011 - 1º Semestre',3,3,1)
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('LP - 1I2 - 2011 - 1º Semestre',4,3,1)
---------Charles----------
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('OE - 1I2 - 2011 - 1º Semestre',1,4,1)
INSERT INTO [db_lotus].[dbo].[tb_disciplina_ministrada]
VALUES
('OSA - 1I2 - 2011 - 1º Semestre',2,4,1)



--Inserção Adcionais Noturnos--
-----------Maikel-----------
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,40,'2011/10/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,20,'2011/11/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,30,'2011/12/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,30,'2011/10/02')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,40,'2011/11/03')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,50,'2011/12/04')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,60,'2011/10/05')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,70,'2011/11/06')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,80,'2011/12/07')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,90,'2011/10/08')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,100,'2011/11/09')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,100,'2011/12/10')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,10,'2011/10/11')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(1,15,'2011/11/12')
-----------Daniela-----------
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,10,'2011/10/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,40,'2011/11/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,50,'2011/12/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,70,'2011/10/02')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,80,'2011/11/03')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,90,'2011/12/04')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,40,'2011/10/05')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,70,'2011/11/06')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,80,'2011/12/07')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,100,'2011/10/08')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,110,'2011/11/09')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,40,'2011/12/10')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,100,'2011/10/11')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(2,20,'2011/11/12')
--------Carlos-----------
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,10,'2011/10/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,20,'2011/11/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,30,'2011/12/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,40,'2011/10/02')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,50,'2011/11/03')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,50,'2011/12/04')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,50,'2011/10/05')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,60,'2011/11/06')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,60,'2011/12/07')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,60,'2011/10/08')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,70,'2011/11/09')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,70,'2011/12/10')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,90,'2011/10/11')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(3,100,'2011/11/12')
--------Charles-----------
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,10,'2011/10/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,60,'2011/11/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,60,'2011/12/01')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,60,'2011/10/02')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,60,'2011/11/03')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,60,'2011/12/04')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,10,'2011/10/05')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,20,'2011/11/06')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,30,'2011/12/07')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,40,'2011/10/08')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,50,'2011/11/09')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,70,'2011/12/10')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,80,'2011/10/11')
INSERT INTO [db_lotus].[dbo].[tb_ad_noturno]
VALUES
(4,100,'2011/11/12')


--Inserção AULAS--
------1º Módulo informática----
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,1,'Segunda',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,1,'Segunda',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,2,'Segunda',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,2,'Segunda',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,2,'Segunda',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,2,'Terça',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,2,'Terça',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,3,'Terça',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,3,'Terça',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,3,'Terça',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,4,'Quarta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,4,'Quarta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,4,'Quarta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,4,'Quarta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,4,'Quarta',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,5,'Quinta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,5,'Quinta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,6,'Quinta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,6,'Quinta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,6,'Quinta',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,7,'Sexta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,7,'Sexta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,7,'Sexta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,7,'Sexta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(1,7,'Sexta',5)
---------------------------
----2º Módulo informática----
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,8,'Segunda',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,8,'Segunda',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,9,'Segunda',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,9,'Segunda',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,10,'Segunda',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,10,'Terça',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,10,'Terça',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,11,'Terça',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,11,'Terça',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,11,'Terça',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,11,'Quarta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,11,'Quarta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,12,'Quarta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,12,'Quarta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,12,'Quarta',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,12,'Quinta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,12,'Quinta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,13,'Quinta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,13,'Quinta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,13,'Quinta',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,14,'Sexta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,14,'Sexta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,14,'Sexta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,15,'Sexta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(2,15,'Sexta',5)
---------------------------
----3º Módulo informática----
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,16,'Segunda',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,16,'Segunda',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,17,'Segunda',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,17,'Segunda',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,18,'Segunda',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,18,'Terça',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,18,'Terça',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,18,'Terça',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,18,'Terça',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,19,'Terça',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,19,'Quarta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,19,'Quarta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,19,'Quarta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,19,'Quarta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,20,'Quarta',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,20,'Quinta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,20,'Quinta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,21,'Quinta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,21,'Quinta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,21,'Quinta',5)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,22,'Sexta',1)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,22,'Sexta',2)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,22,'Sexta',3)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,22,'Sexta',4)
INSERT INTO [db_lotus].[dbo].[tb_aula]
VALUES
(3,22,'Sexta',5)
---------------------------


----Inserção Aulas Dadas-----
-----1ª Semana Janeiro -----
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/03/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/03/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/03/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/03/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/03/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/04/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/04/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/04/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/04/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/04/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/05/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/05/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/05/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/05/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/05/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/06/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/06/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/06/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/06/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/06/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/07/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/07/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/07/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/07/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/07/01','Dada',5)
-----2ª Semana Janeiro -----
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/10/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/10/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/10/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/10/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/10/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/11/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/11/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/11/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/11/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/11/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/12/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/12/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/12/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/12/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/12/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/13/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/13/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/13/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/13/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/13/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/14/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/14/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/14/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/14/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/14/01','Dada',5)
-----3ª Semana Janeiro -----
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/17/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/17/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/17/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/17/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/17/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/18/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/18/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/18/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/18/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/18/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/19/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/19/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/19/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/19/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/19/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/20/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/20/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/20/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/20/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/20/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/21/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/21/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/21/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/21/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/21/01','Dada',5)
-----4ª Semana Janeiro -----
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/24/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(1,null,1,'2011/24/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/24/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/24/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/24/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/25/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(2,null,1,'2011/25/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/25/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/25/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(3,null,1,'2011/25/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/26/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/26/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/26/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/26/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(4,null,1,'2011/26/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/27/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(5,null,1,'2011/27/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/27/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/27/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(6,null,1,'2011/27/01','Dada',5)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/28/01','Dada',1)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/28/01','Dada',2)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/28/01','Dada',3)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/28/01','Dada',4)
INSERT INTO [db_lotus].[dbo].[tb_aula_dada]
VALUES
(7,null,1,'2011/28/01','Dada',5)


-------Inserção Faltas Alunos---------
------1ª Semana de Janeiro------
---------Marina------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/03/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/03/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/03/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/03/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/03/01',5)
---------Gabrielle---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/04/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/04/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/04/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/04/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/04/01',5)	
---------Caio---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/05/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/05/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/05/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/05/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/05/01',5)	
---------Murilo---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/06/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/06/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/06/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/06/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/06/01',5)
---------Patrick---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,1,1,'2011/03/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,2,1,'2011/04/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,3,1,'2011/04/01',5)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,4,1,'2011/05/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,5,1,'2011/06/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,6,1,'2011/06/01',5)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/07/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/07/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/07/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/07/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/07/01',5)
------2ª Semana de Janeiro------
---------Marina------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/10/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/10/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/10/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/10/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/10/01',5)
---------Gabrielle---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/11/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/11/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/11/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/11/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/11/01',5)	
---------Caio---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/12/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/12/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/12/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/12/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/12/01',5)	
---------Murilo---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/13/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/13/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/13/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/13/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/13/01',5)
---------Patrick---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,1,1,'2011/10/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,2,1,'2011/11/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,3,1,'2011/11/01',5)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,4,1,'2011/12/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,5,1,'2011/13/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,6,1,'2011/13/01',5)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/14/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/14/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/14/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/14/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/14/01',5)
------3ª Semana de Janeiro------
---------Marina------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/17/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/17/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/17/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/17/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/17/01',5)
---------Gabrielle---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/18/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/18/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/18/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/18/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/18/01',5)	
---------Caio---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/19/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/19/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/19/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/19/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/19/01',5)	
---------Murilo---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/20/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/20/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/20/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/20/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/20/01',5)
---------Patrick---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,1,1,'2011/17/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,2,1,'2011/18/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,3,1,'2011/18/01',5)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,4,1,'2011/19/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,5,1,'2011/20/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,6,1,'2011/20/01',5)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/21/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/21/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/21/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/21/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/21/01',5)
------4ª Semana de Janeiro------
---------Marina------------
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/24/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,1,1,'2011/24/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/24/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/24/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (1,2,1,'2011/24/01',5)
---------Gabrielle---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/25/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,2,1,'2011/25/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/25/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/25/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (2,3,1,'2011/25/01',5)	
---------Caio---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/26/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/26/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/26/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/26/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (3,4,1,'2011/26/01',5)	
---------Murilo---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/27/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,5,1,'2011/27/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/27/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/27/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (4,6,1,'2011/27/01',5)
---------Patrick---------	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,1,1,'2011/24/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,2,1,'2011/25/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,3,1,'2011/25/01',5)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,4,1,'2011/26/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,5,1,'2011/27/01',1)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,6,1,'2011/27/01',5)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/28/01',1)
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/28/01',2)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/28/01',3)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/28/01',4)	
INSERT INTO [db_lotus].[dbo].[tb_faltas_aluno]
VALUES (5,7,1,'2011/28/01',5)


--Inserção Eventos--

INSERT INTO [db_lotus].[dbo].[tb_evento]
VALUES
('2011/25/12','Natal','Dia em que se comemora o nascimento do Menino Jesus')
INSERT INTO [db_lotus].[dbo].[tb_evento]
VALUES
('2011/06/06','Pintura','Pintura dos laboratórios e da secretaria')
INSERT INTO [db_lotus].[dbo].[tb_evento]
VALUES
('2011/21/04','Tiradentes','Mártir brasileiro que morreu na Inconfidência Mineira')
INSERT INTO [db_lotus].[dbo].[tb_evento]
VALUES
('2011/27/06','1º Dia de Apresentação TCC','Boa Sorte a Todos!!!')
INSERT INTO [db_lotus].[dbo].[tb_evento]
VALUES
('2011/28/06','2º Dia de Apresentação TCC','Boa Sorte a Todos!!!')


--Inserção Usuários--

INSERT INTO [db_lotus].[dbo].[tb_usuario]
VALUES
('Etech','lotus','etech.2010@hotmail.com','O Meio Ambiente Agradece','Master','fundo_padrao.png',-15420550,'offline')
INSERT INTO [db_lotus].[dbo].[tb_usuario]
VALUES
('Caio','pepe','caioalves2k@hotmail.com','Nome do Pet','Administrativo','fundo_padrao.png',-15420550,'offline')
INSERT INTO [db_lotus].[dbo].[tb_usuario]
VALUES
('Marina','bongo','marina.isabel12@hotmail.com','Nome do Cachorro','Administrativo','fundo_padrao.png',-15420550,'offline')
INSERT INTO [db_lotus].[dbo].[tb_usuario]
VALUES
('Gabrielle','gabicorrea','gabi.ccorrea@hotmail.com','Sobrenome','Secretaria','fundo_padrao.png',-15420550,'offline')
INSERT INTO [db_lotus].[dbo].[tb_usuario]
VALUES
('Murilo','capricornio','murilo3112@hotmail.com','Signo','Administrativo','fundo_padrao.png',-15420550,'offline')
INSERT INTO [db_lotus].[dbo].[tb_usuario]
VALUES
('Patrick','selvagem','bonkura.rip@hotmail.com','Bebida Predileta','Secretaria','fundo_padrao.png',-15420550,'offline')
