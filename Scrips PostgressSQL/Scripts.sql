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

CREATE TABLE "public".tipobien(
tipobienid integer  NOT NULL ,
tipobiendsc  varchar(100)   ,
tipobienusuario varchar(15)   ,
tipobienfecreg timestamp   ,
ipobienfecultact  timestamp   ,
CONSTRAINT pk_tipobien_tipobienid PRIMARY KEY (tipobienid)
);


CREATE TABLE "public".tipodocumento(
tipodocumentoid integer  NOT NULL ,
tipodocumentodsc varchar(100)   ,
tipodocumentousuario varchar(15)   ,
tipodocumentofecreg timestamp   ,
tipodocumentofecultact timestamp   ,
CONSTRAINT pk_tipodocumento_tipodocumentoid PRIMARY KEY (tipodocumentoid)
);

CREATE TABLE "public".estatusarticulo(
estatusarticuloid integer  NOT NULL ,
estatusarticulodsc varchar(100)   ,
estatusarticulodescuso varchar(100)   ,
estatusarticuloaplicamov numeric (4),
estatusarticulousotabla varchar(50),
estatusarticulousuario  varchar(15),
estatusarticulofecreg timestamp   ,
estatusarticulofecultact timestamp   ,
CONSTRAINT pk_estatusarticulo_estatusarticuloid PRIMARY KEY (estatusarticuloid)
);

CREATE TABLE "public".status(
statusid  integer  NOT NULL ,
statusdsc varchar(50)   ,
statususotabla varchar(50)   ,
statusdesc varchar(50)   ,
statususuario varchar(15)   ,
statusfecreg timestamp   ,
statusfecultact timestamp   ,
CONSTRAINT pk_status_statusid PRIMARY KEY (statusid)
);

CREATE TABLE "public".entidadfederativa(
entidafederativaid integer  NOT NULL ,
entidadfederativadsc varchar(100)   ,
entidadfederativausuario  varchar(15)   ,
entidadfederativafecreg timestamp   ,
entidadfederativafecultact timestamp   ,
CONSTRAINT pk_entidadfederativa_entidafederativaid PRIMARY KEY (entidafederativaid)
);

CREATE TABLE "public".articulos(
articulosid  integer  NOT NULL ,
productoid  integer  NOT NULL ,
cambsid    integer  NOT NULL ,
alamcenid  integer  NOT NULL ,
tipodocid integer  NOT NULL ,
entidadid integer  NOT NULL ,
origenid  integer  NOT NULL ,
proveedorid  integer  NOT NULL ,
articulosnoetiqueta numeric(11),
articulosdsc varchar(100)   ,
articulospreciocompra double(8,0),
articulospreccomprareexp double(8,0),
articuloscantdepreacum double(8,0),
articulosnumserie varchar(20)   ,
articulosrefdocumento varchar(20)   ,
articulosfechacoteja  varchar(20)   ,
articulosfechaentraalmacen  timestamp   ,
articulosfechabajaalma timestamp   ,
articulosstatus integer(11),
articuloscontejado varchar(1)   ,
articulosusuario  varchar(15)   ,
articulosidtrasfer integer  NOT NULL ,
articulosestatusariticulo integer  NOT NULL ,
articulostipobien nteger  NOT NULL ,
articulosfecreg  timestamp   ,
articulosfecultact timestamp   ,
CONSTRAINT pk_articulos_articulosid PRIMARY KEY (articulosid)
); 


CREATE TABLE "public".artículosmov(
articulosmovid integer  NOT NULL ,
productoid integer  NOT NULL ,
cambsid   integer  NOT NULL ,
articulosmovarticuloid  integer  NOT NULL ,
articulosmovdepositario integer(3),
articulosmovfechamov timestamp   ,
articulosmovstatus varchar(100)   ,
articulosmovagregomovsist varchar(50)   ,
articulosmovususuario varchar(15)   ,
articulosmovfecreg timestamp   ,
articulosmovfecultact timestamp   ,
CONSTRAINT pk_artículosmov_articulosmovid PRIMARY KEY (articulosmovid)
);

CREATE TABLE "public".empleados(
empleadosid integer  NOT NULL ,
areaid integer  NOT NULL ,
empleadosnomemple varchar(30)   ,
empleadosappaterno varchar(30)   ,
empleadosapmaterno varchar(30)   ,
empleadosstatus  varchar(1)   ,
empleadosusuario varchar(15)   ,
empleadoscorreo  varchar(50)   ,
empleadosext     varchar(4),
empleadosfecreg  timestamp   ,
empleadosfecultact timestamp   ,
CONSTRAINT pk_empleados_empleadosid PRIMARY KEY (empleadosid)
);

CREATE TABLE  "public".area(
areaid integer  NOT NULL ,
areadsc varchar(100)   ,
areastatusadsc varchar(100)   ,
areausuario   varchar(15)   ,
areafecreg    timestamp   ,
areafecultact timestamp   ,
CONSTRAINT pk_area_areaid PRIMARY KEY (areaid)
);

CREATE TABLE  "public".parametros(
parametrosid  integer  NOT NULL ,
parametrosdsc  varchar(100)   ,
parametrosvalor varchar(30)   ,
parametroscadena varchar(30)   ,
parametrosstatus varchar(30)   ,
parametrosuso varchar(100)   ,
parametrosusuario  varchar(15)   ,
parametrosfecgre timestamp   ,
parametrosfecact timestamp   ,
CONSTRAINT pk_parametros_parametrosid PRIMARY KEY (parametrosid)
); 

CREATE TABLE "public".empleadospisoext (
empleadospisoextid integer  NOT NULL ,
empleadospisoextpiso varchar(10)   ,
empleadospisoextext  varchar(10)   ,
empleadospisoextcorreo varchar(50)   ,
empleadopisoextprofesion numeric (11),
empleadospisoextusuario varchar(15)   ,
empleadospisoextfecgre  timestamp   ,
empleadospisoextfeact  timestamp   ,
CONSTRAINT pk_empleadospisoext_empleadospisoextid PRIMARY KEY (empleadospisoextid)
);

CREATE TABLE "public".meses(
mesesid integer  NOT NULL ,
mesesanio  varchar(5)   ,
mesesusuario varchar(15)   ,
mesesfecgre timestamp   ,
mesesfeact  timestamp   ,
CONSTRAINT pk_meses_mesesid PRIMARY KEY (mesesid)
);

CREATE TABLE "public".almacen(
almacenid integer  NOT NULL ,
empleadoid integer  NOT NULL ,
almacendsc varchar(100)   ,
almacendireccion  varchar(100)   ,
almacencolonia  varchar(50)   ,
almacenmunicipio varchar(50)   ,
alamcenestado    varchar(50)   ,
alamcencodigopostal varchar(5)   ,
almacentelefono     numeric(10)   ,
alamcenobservaciones varchar(50)   ,
alamcenusuario varchar(15)   ,
almacenfecreg  timestamp   ,
almacenfecultact timestamp   ,
CONSTRAINT pk_almacen_almacenid PRIMARY KEY (almacenid)
);

CREATE TABLE "public".proveedores(
proveedoresid integer  NOT NULL ,
proveedoresnombre varchar(80)   ,
proveedoresdireccion  varchar(50)   ,
proveedorescolonia  varchar(25)   ,
proveedorescodigopostal varchar(5)   ,
proveedoresmunicipio varchar(25)   ,
proveedorestado  varchar(20)   ,
proveedorestelefono1 numeric(10),
proveedorestelefono2 numeric(10),
proveedoresfax   varchar(15)   ,
proveedoresrfc varchar(13)   ,
proveedoresusuario  varchar(15)   ,
proveedoresfecreg  timestamp   ,
proveedoresfecultact  timestamp   ,
CONSTRAINT pk_proveedores_proveedoresid PRIMARY KEY (proveedoresid)
);

CREATE TABLE  "public".etiquetas(
etiquetasid integer  NOT NULL ,
productoid integer  NOT NULL ,
cambsid    integer  NOT NULL ,
articuloid  integer  NOT NULL ,
etiquetasnumero numeric(11),
etiquetastatus varchar(100),
etiquetafecharealizada timestamp   ,
etiquetasreimpresión varchar(100),
etiquetasusuario varchar(15),
etiquetasfecreg    timestamp   ,
etiquetasfecultact timestamp   ,
CONSTRAINT pk_etiquetas_etiquetasid PRIMARY KEY (etiquetasid)
);

CREATE TABLE "public".producto(
productoid   integer  NOT NULL ,
cambsid      integer  NOT NULL ,
modeloid     integer  NOT NULL ,
marcaid      integer  NOT NULL ,
categoriaid   integer  NOT NULL ,
productodsc varchar(100),
productousuario varchar(15),
productofecreg timestamp   ,
productofecultact timestamp   ,
CONSTRAINT pk_producto_productoid PRIMARY KEY (productoid)
);





















