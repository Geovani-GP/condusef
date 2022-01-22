CREATE  TABLE "public".cambs ( 
	cambsid              integer  NOT NULL ,
	cambsdsc             varchar(100)   ,
	cambsusuario         varchar(15)   ,
	cambsfecreg          timestamp   ,
	cambsfecultact       timestamp   ,
	CONSTRAINT pk_cambs_cambsid PRIMARY KEY ( cambsid )
 );

CREATE  TABLE "public".usuarios ( 
	idusuario            integer DEFAULT nextval('usuarios_usuarios_seq'::regclass) NOT NULL ,
	usuario              varchar(25)   ,
	contrasena           varchar(10)   ,
	CONSTRAINT pk_usuarios_usuarios PRIMARY KEY ( idusuario )
 );

