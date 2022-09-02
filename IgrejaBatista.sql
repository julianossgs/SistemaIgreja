Use IgrejaBatista
go


--******************************************
--Tabela de usuários
create table TblUsuarios
(IdUsuario int primary key identity not null,
 Usuario varchar(50) not null,
 Senha varchar(15) not null,
 funcao varchar(50))
 go

 alter table TblUsuarios add Funcao varchar(50) 
 go

 select * from TblUsuarios
 go



 --Procedure de inserir na tabela de usuários
 alter procedure spInserirUsuarios
 @Usuario varchar(50),
 @Senha varchar(15),
 @Funcao varchar(50)
 as begin
 begin try
 begin tran

 insert into TblUsuarios(Usuario,Senha,funcao)
 values(@Usuario,@Senha,@Funcao)
 select @@IDENTITY as Retorno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --Procedure de excluir usuários
 alter procedure spExcluirUsuarios
 @IdUsuario int
 as begin
 begin try
 begin tran

 delete from TblUsuarios
 where IdUsuario=@IdUsuario

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  


--Procedure na tabela de usuario usada no FrmUsuarios
alter procedure spListarUsuarios
 as begin
 begin try
 begin tran
 
 select * from TblUsuarios
 order by Usuario asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --Procedure na tabela de usuário usada no Frm de Login
 create procedure spChamarLogin
 @Usuario varchar(50),
 @Senha varchar(15)
 as begin
 begin try
 begin tran

 select * from TblUsuarios
 where Usuario = @Usuario and Senha = @Senha

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --Procedure na tabela de usuário usada no Frm de usuários
alter procedure spVerificarUsuarioCadastrado
 @Usuario varchar(50),
 @Senha varchar(15)
 as begin
 begin try
 begin tran

 select * from TblUsuarios
 where Usuario = @Usuario or Senha = @Senha

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --**************************************************
 --Tabela de cargos

 --Procedure na tabela de cargos usada no FrmCargos
 create procedure spVerificarCargoCadastrado
 @Cargo varchar(100)
 
 as begin
 begin try
 begin tran

 select * from TblCargo
 where Cargo = @Cargo

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --*****************************************

 --Tabela de membros

 --Procedure de listar membros usada no FrmMembros
 alter procedure spListarMembros
 as begin
 begin try
 begin tran

 select m.IdMembro,
        m.Nome,
		m.Endereco,
		m.Bairro,
		m.Cidade,
		m.Estado,
		m.Cep,
		m.CPF,
		m.Celular1,
		m.Celular2,
		m.Nascimento,
		m.Imagem,
		c.Cargo,
		m.Iniciou
		from TblMembros m inner join TblCargo c
		on m.Id_Cargo = c.IdCargo
        order by Nome asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  
 
 --Procedure na tabela de Membros usada no Frm de Membros
create procedure spVerificarCPFCadastrado
 @CPF varchar(15)
  as begin
 begin try
 begin tran

 select * from TblMembros
 where CPF = @CPF

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --Procedure de alterar Membros sem o parametro Imagem
 --usada no FrmMembros
 create procedure spAlterarMembroImgem
 @IdMembro int,
 @Nome varchar(50),
 @Endereco varchar(50),
 @Bairro varchar(50),
 @Cidade varchar(50),
 @Estado char(2),
 @Cep varchar(15),
 @CPF varchar(15),
 @Celular1 varchar(25),
 @Celular2 varchar(25),
 @Nascimento date,
 @Id_Cargo int,
 @Iniciou date
 as begin
 begin try
 begin tran

 update TblMembros
  set Nome=@Nome,Endereco=@Endereco,Bairro=@Bairro,
  Cidade=@Cidade,Estado=@Estado,Cep=@Cep,CPF=@CPF,
  Celular1=@Celular1,
 Celular2=@Celular2,Nascimento=@Nascimento,
 Id_Cargo=@Id_Cargo,Iniciou=@Iniciou
 where IdMembro=@IdMembro

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go

 
 --Procedure alterar Tab dizimista no FrmCultos

 alter procedure spAlterarDizCulto
 @IdDiz int,
 @Dizimo decimal(10,2),
 @Oferta decimal(10,2),
 @Total decimal(10,2),
 @OfertaEspecial decimal(10,2)
 as begin
 begin try
 begin tran

 update TblDD
 set Dizimo=@Dizimo,Oferta=@Oferta,
 Total=@Total,OfertaEspecial=@OfertaEspecial
 where IdDiz=@IdDiz
 select @@IDENTITY as Retorno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure p/ Listar Detalhes do Culto no FrmCultos
 alter procedure spListarDetalhesCulto
 @Id_Culto int
  as begin
 begin try
 begin tran

 select m.Nome,
        d.IdDiz,
		d.Dizimo,
		d.Oferta,
		d.OfertaEspecial,
		d.Total,
		d.Id_Membro,
		d.Id_Culto
		from TblDD d inner join TblMembros m
		on d.Id_Membro = m.IdMembro
		where Id_Culto=@Id_Culto
		order by Nome desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de buscar detalhes do culto no FrmCultos
 alter procedure spBuscarDetalhesCulto
 @Id_Culto int
  as begin
 begin try
 begin tran

 select m.Nome,
        d.IdDiz,
		d.Dizimo,
		d.Oferta,
		d.OfertaEspecial,
		d.Total,
		d.Id_Membro,
		d.Id_Culto
		from TblDD d inner join TblMembros m
		on d.Id_Membro = m.IdMembro
		 where Id_Culto = @Id_Culto
		order by Nome desc
 
 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --**********************************************
 --Tabela de Tipo de Cultos
 create table TblTipoCultos
 (IdTipoCulto int primary key identity not null,
   TipoCulto varchar(50))
   go

   --Procedure de inserir na tab Tipo de cultos
 create procedure spInserirTipoCulto
 @TipoCulto varchar(50)
as begin
 begin try
 begin tran

insert into TblTipoCultos(TipoCulto)
values(@TipoCulto)
Select @@IDENTITY as Retorno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de excluir tipo de culto no FrmTipoCulto
 create procedure spExcluirTipoCulto
 @IdTipoCulto int
as begin
 begin try
 begin tran

 delete from TblTipoCultos
 where IdTipoCulto = @IdTipoCulto

commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure na tabela de Tipo de cultos usada no FrmTipoCultos
create procedure spVerificarCultoCadastrado
 @TipoCulto varchar(50)
  as begin
 begin try
 begin tran

 select * from TblTipoCultos
 where TipoCulto = @TipoCulto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --Procedure de Listar tipos de culto no FrmTipoCulto
 create procedure spListarTipoCulto
  as begin
 begin try
 begin tran

 select * from TblTipoCultos
 order by TipoCulto asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  

 --**********************************************
 --Tabela de Movimentações
 create table TblMovimentacoes
 (IdMov int  primary key identity not null,
  Data date,
  Tipo varchar(30),
  Movimento varchar(50),
  Valor decimal(10,2),
  Id_Movimento int)
  go

 

 --Procedure de excluir Movimentações no FrmGastos
 alter procedure spExcluirMovGastos
 @IdGasto int,
 @Tipo varchar(30)
  as begin
 begin try
 begin tran

 delete from TblMovimentacoes where Id_Movimento=@IdGasto
 and Tipo= @Tipo

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go  



 --Procedure de alterar Movimentações no FrmGastos
 alter procedure spAlterarMovGastos
 @IdGasto int,
 @Tipo varchar(30),
 @Movimento varchar(50),
 @Total decimal(10,2)

 as begin
 begin try
 begin tran

 update TblMovimentacoes
 set Data=GETDATE(),Total=@Total,Tipo=@Tipo
 where Id_Movimento = @IdGasto and Movimento = @Movimento


 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 
 --Procedure p/ buscar por datas no FrmMovimentações
 create procedure spBuscarDataMov
 @DataInicial date,
 @DataFinal date
  as begin
 begin try
 begin tran

 select * from TblMovimentacoes
 where Data >=@DataInicial and Data <= @DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure p/ buscar por datas e tipo no FrmMovimentações
 create procedure spBuscarDataTipoMov
 @Tipo varchar(30),
 @DataInicial date,
 @DataFinal date
  as begin
 begin try
 begin tran

 select * from TblMovimentacoes
 where Data >=@DataInicial and Data <= @DataFinal
 and Tipo = @Tipo
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


 --*************************************************
 --Tabela de Gastos
 create table TblGastos
 (IdGasto int primary key identity not null,
  Data date,
  Descricao varchar(100),
  Valor decimal(10,2))
  go

  --PROCEDURES NA TABELA DE GASTOS
  --Inserir nos Gastos no FrmGastos

  alter procedure spInserirGastos
  @Data date,
  @Movimento varchar(100),
  @Valor decimal(10,2),
  @Tipo varchar(30)
 as begin
 begin try
 begin tran

 insert into TblGastos(Data,Movimento,Valor,Tipo)
 values(@Data,@Movimento,@Valor,@tipo)
 select @@IDENTITY as Retorno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Alterar nos Gastos no FrmGastos
 alter procedure spAlterarGastos
 @IdGasto int,
 @Data date,
 @Movimento varchar(100),
 @Valor decimal(10,2),
 @Tipo varchar(30)
 as begin
 begin try
 begin tran

 update TblGastos
 set Data=@Data,Movimento=@Movimento,Valor=@Valor,Tipo=@Tipo
 where IdGasto=@IdGasto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Excluir nos Gastos no FrmGastos
 create procedure spExcluirGastos
 @IdGasto int
 as begin
 begin try
 begin tran

 delete from TblGastos
 where IdGasto=@IdGasto

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Listar gastos no FrmGastos
 create procedure spListarGastos
 as begin
 begin try
 begin tran

 select * from TblGastos
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


 --Buscar por datas no FrmGastos
 create procedure spBuscarGastosData
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblGastos
 where Data>=@DataInicial and Data<=@DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Recuperar ultimo Id do Gasto no FrmGastos
create procedure spRecuperarUltimoIdGasto
  as begin
 begin try
 begin tran

 select top 1 IdGasto from TblGastos
 order by IdGasto desc 

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


 --***********************************
 --TABELA DE ENTRADAS
 create table TblEntradas
 (IdEntrada int primary key identity not null,
  Data date,
  Tipo varchar(30),
  Movimento varchar(100),
  Valor decimal(10,2))
  go

  --Procedures

  --procedure de inserir na ENTRADA no FrmEntradas
  alter procedure spInserirEntrada
  @Data date,
  @Tipo varchar(100),
  @Movimento varchar(100),
  @Total decimal(10,2)
   as begin
 begin try
 begin tran

 insert into TblEntradas(Data,Tipo,Movimento,Total)
 values(@Data,@Tipo,@Movimento,@Total)
 select @@IDENTITY as Retorno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --procedure de alterar na ENTRADA no FrmEntradas
 alter procedure spAlterarEntrada
 @Data date,
 @IdEntrada int,
  @Tipo varchar(100),
  @Movimento varchar(100),
  @Total decimal(10,2)
 as begin
 begin try
 begin tran

 update TblEntradas
 set Tipo=@Tipo,Movimento=@Movimento,Total=@Total,Data=@Data
 where IdEntrada=@IdEntrada
 select @@IDENTITY as Retorno

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de excluir na ENTRADA no FrmEntrada
 create procedure spExcluirEntrada
 @IdEntrada int
 as begin
 begin try
 begin tran

 delete from TblEntradas
 where IdEntrada=@IdEntrada

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de Listar Entradas no FrmEntradas
 create procedure spListarEntradas
 as begin
 begin try
 begin tran

 select * from TblEntradas
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de Buscar entradas por Datas no FrmEntradas
 create procedure spBuscarEntradasData
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblEntradas
 where Data>=@DataInicial and Data<=@DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Recuperar ultimo Id da Entrada no FrmEntradas
create procedure spRecuperarUltimoIdEntrada
  as begin
 begin try
 begin tran

 select top 1 IdEntrada from TblEntradas
 order by IdEntrada desc 

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --**********************************
 
  --Excluir na tab DetalheContasPagar no FrmContasPagar
  create procedure spExcluirDetalheContasPagar
  @IdDetalhe int
  as begin
  begin try
  begin tran

 delete from TblDetalheContasPagar
 where IdDetalhe = @IdDetalhe 

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de buscar por datas no FrmContasPagar
 create procedure spBuscarDatasContasPagar
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblDetalheContasPagar
 where Data>=@DataInicial and Data<=@DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de buscar por data e tipo no FrmContasPagar
 create procedure spBuscarDatasTipoContasPagar
  @DataInicial date,
 @DataFinal date,
 @TipoDocumento varchar(50)
 as begin
 begin try
 begin tran

 select * from TblDetalheContasPagar
 where Data>=@DataInicial and Data<=@DataFinal
 and TipoDocumento=@TipoDocumento
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

  --*************************************************
  --Tabela de Contas pagas
  create table TblContasPagas
  (Id_Mov int,
  Data date,
  TipoDocumento varchar(50),
  NºDocumento varchar(20),
  Descricao varchar(100),
  Parcela int,
  Valor decimal(10,2),
  Credor varchar(50),
  Status varchar(50))
  go


  --Procedures
  create procedure spListarContasPagas
 
 as begin
 begin try
 begin tran

 select * from TblContasPagas
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de inserir na tab de Contas pagas no FrmContasPagar
 alter procedure spInserirContasPagas
 @Id_Mov int,
 @Data date,
 @TipoDocumento varchar(50),
 @NºDocumento varchar(20),
 @Descricao varchar(100),
 @Parcela int,
 @Valor decimal(10,2),
 @Credor varchar(50),
 @Status varchar(50)
 as begin
 begin try
 begin tran

 insert into TblContasPagas
 (Id_Mov,Data,TipoDocumento,NºDocumento,Descricao,Parcela,Valor,Credor,Status)
 values(@Id_Mov,@Data,@TipoDocumento,@NºDocumento,@Descricao,@Parcela,
 @Valor,@Credor,@Status)
 select @@IDENTITY as Retorno


 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


 --Procedure p/ lançar contas pagas na tab de Movimentações
 --no FrmContasPagar
  create procedure spInserirContasPagarMov
  @Data date,
  @Tipo varchar(30),
  @Movimento varchar(50),
  @Valor decimal(10,2),
  @Id_Movimento int

 as begin
 begin try
 begin tran

 insert into TblMovimentacoes(Data,Tipo,Movimento,Valor,Id_Movimento)
 values(@Data,@Tipo,@Movimento,@Valor,@Id_Movimento)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

  --Procedure de buscar por datas no FrmContasPagar na tab Contas pagas
 create procedure spBuscarDatasContasPagas
 @DataInicial date,
 @DataFinal date
 as begin
 begin try
 begin tran

 select * from TblContasPagas
 where Data>=@DataInicial and Data<=@DataFinal
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure de buscar por data e tipo no FrmContasPagar na tab Contas pagas
 create procedure spBuscarDatasTipoContasPagas
 @DataInicial date,
 @DataFinal date,
 @TipoDocumento varchar(50)
 as begin
 begin try
 begin tran

 select * from TblContasPagas
 where Data>=@DataInicial and Data<=@DataFinal
 and TipoDocumento=@TipoDocumento
 order by Data desc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Tabela de inventário
 create table TblInventario
 (IdIv int primary key identity(100,1) not null,
  DataCadastro date not null,
  Categoria varchar(50) not null,
  Item varchar(50) not null,
  Descricao varchar(100),
  DataCompra date,
  Documento varchar(30),
  ValorCompra decimal(10,2),
  ValorAtual decimal(10,2),
  Estado varchar(50))
  go

  --Index p/ a tabela de inventário
  create index idxItem on TblInventario(Item)
  go 

  select * from TblInventario
  go

  drop table TblInventario
  go


  --Procedure de Listar
 create procedure Listar
 as begin
 begin try
 begin tran

 select * from TblInventario
 order by Item asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 
 go

 --Procedure buscar item por Nome
 create procedure spBuscarItemNome
 @Item varchar(50)
 as begin
 begin try
 begin tran

 select * from TblInventario
 where Item like '%' + @Item + '%'
 order by Item asc

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

  --Procedure p/ inserir no FrmInventário
  create procedure spInserirInventario
  @DataCadastro date,
  @Categoria varchar(50),
  @Item varchar(50),
  @Descricao varchar(100),
  @DataCompra date,
  @Documento varchar(30),
  @ValorCompra decimal(10,2),
  @ValorAtual decimal(10,2),
  @Estado varchar(50)
  as begin
 begin try
 begin tran

 insert into TblInventario(DataCadastro,Categoria,Item,Descricao,DataCompra,
 Documento,ValorCompra,ValorAtual,Estado)
 values(@DataCadastro,@Categoria,@Item,@Descricao,@DataCompra,@Documento,
 @ValorCompra,@ValorAtual,@Estado)

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 


 --Procedure de alterar no FrmInventário
  create procedure spAlterarInventario
  @IdIv int,
  @DataCadastro date,
  @Categoria varchar(50),
  @Item varchar(50),
  @Descricao varchar(100),
  @DataCompra date,
  @Documento varchar(30),
  @ValorCompra decimal(10,2),
  @ValorAtual decimal(10,2),
  @Estado varchar(50)
  as begin
 begin try
 begin tran

 update TblInventario
 set DataCadastro=@DataCadastro,Categoria=@Categoria,Item=@Item,
 Descricao=@Descricao,DataCompra=@DataCompra,Documento=@Documento,
 ValorCompra=@ValorCompra,ValorAtual=@ValorAtual,Estado=@Estado
 where IdIv = @IdIv

 commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 --Procedure Excluir
 create procedure spExcluirInventario
 @IdIv int
  as begin
 begin try
 begin tran

 delete from TblInventario
 where IdIv = @IdIv

  commit tran
 end try
 begin catch
 select ERROR_MESSAGE() as Retorno
 end catch
 end
 go 

 select * from TblInventario
 go

