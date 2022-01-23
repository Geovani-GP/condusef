CREATE  TABLE "public".cambs ( 
	cambsid              integer  NOT NULL ,
	cambsdsc             varchar(100)   ,
	cambsusuario         varchar(15)   ,
	cambsfecreg          timestamp   ,
	cambsfecultact       timestamp   ,
	CONSTRAINT pk_cambs_cambsid PRIMARY KEY ( cambsid )
 );

CREATE  TABLE "public".usuarios ( 
	idusuario            integer  NOT NULL ,
	usuario              varchar(25)   ,
	contrasena           varchar(10)   ,
	CONSTRAINT pk_usuarios_usuarios PRIMARY KEY ( idusuario )
 );
 --Nuevas tablas José Luis Bueno
CREATE TABLE "public".marcas(
 marcasid  integer  NOT NULL ,
 marcasdsc varchar(100)   ,
 marcasusuario varchar(15)   ,
 marcasfecreg  timestamp   ,
 marcasfecultact timestamp,   
 CONSTRAINT pk_marcas_marcasid PRIMARY KEY (marcasid)
);

CREATE TABLE "public".modelos(
modelosid integer  NOT NULL ,
modelosdsc varchar(100)   ,
modelosusuario varchar(15)   ,
modelosfecreg timestamp   ,
modelosfecultact timestamp , 
 CONSTRAINT pk_modelos_modelosid PRIMARY KEY (modelosid)
);

CREATE TABLE "public".categorias(
categoriasid integer  NOT NULL ,
categoriasdsc  varchar(100)   ,
categoriasusuario  varchar(15)   ,
categoriasfecreg timestamp   ,
categoriasfecultact timestamp   ,
CONSTRAINT pk_categorias_categoriasid PRIMARY KEY (categoriasid)
);

CREATE TABLE "public".origen(
origenid integer  NOT NULL ,
origendscorta varchar(50)   ,
origendsclarga varchar(100)   ,
origenusuario  varchar(15)   ,
origentotal  varchar(50)   ,
origenfecreg timestamp   ,
origenfecultact timestamp   ,
CONSTRAINT pk_origen_origenid PRIMARY KEY (origenid)
);






















