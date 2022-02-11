CREATE  TABLE "public".cambs ( 
	cambsid              integer  NOT NULL ,
	cambsdsc             varchar(100)   ,
	cambsusuario         varchar(15)   ,
	cambsfecreg          date   ,
	cambsfecultact       date   ,
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
 marcasfecreg  date   ,
 marcasfecultact date,   
 CONSTRAINT pk_marcas_marcasid PRIMARY KEY (marcasid)
);

CREATE TABLE "public".modelos(
modelosid integer  NOT NULL ,
modelosdsc varchar(100)   ,
modelosusuario varchar(15)   ,
modelosfecreg date   ,
modelosfecultact date , 
 CONSTRAINT pk_modelos_modelosid PRIMARY KEY (modelosid)
);

CREATE TABLE "public".categorias(
categoriasid integer  NOT NULL ,
categoriasdsc  varchar(100)   ,
categoriasusuario  varchar(15)   ,
categoriasfecreg date   ,
categoriasfecultact date   ,
CONSTRAINT pk_categorias_categoriasid PRIMARY KEY (categoriasid)
);

CREATE TABLE "public".origen(
origenid integer  NOT NULL ,
origendscorta varchar(50)   ,
origendsclarga varchar(100)   ,
origenusuario  varchar(15)   ,
origentotal  varchar(50)   ,
origenfecreg date   ,
origenfecultact date   ,
CONSTRAINT pk_origen_origenid PRIMARY KEY (origenid)
);

CREATE TABLE "public".tipobien(
tipobienid integer  NOT NULL ,
tipobiendsc  varchar(100)   ,
tipobienusuario varchar(15)   ,
tipobienfecreg date   ,
tipobienfecultact  date   ,
CONSTRAINT pk_tipobien_tipobienid PRIMARY KEY (tipobienid)
);


CREATE TABLE "public".tipodocumento(
tipodocumentoid integer  NOT NULL ,
tipodocumentodsc varchar(100)   ,
tipodocumentousuario varchar(15)   ,
tipodocumentofecreg date   ,
tipodocumentofecultact date   ,
CONSTRAINT pk_tipodocumento_tipodocumentoid PRIMARY KEY (tipodocumentoid)
);

CREATE TABLE "public".estatusarticulo(
estatusarticuloid integer  NOT NULL ,
estatusarticulodsc varchar(100)   ,
estatusarticulodescuso varchar(100)   ,
estatusarticuloaplicamov numeric (4),
estatusarticulousotabla varchar(50),
estatusarticulousuario  varchar(15),
estatusarticulofecreg date   ,
estatusarticulofecultact date   ,
CONSTRAINT pk_estatusarticulo_estatusarticuloid PRIMARY KEY (estatusarticuloid)
);

CREATE TABLE "public".status(
statusid  integer  NOT NULL ,
statusdsc varchar(50)   ,
statususotabla varchar(50)   ,
statusdesc varchar(50)   ,
statususuario varchar(15)   ,
statusfecreg date   ,
statusfecultact date   ,
CONSTRAINT pk_status_statusid PRIMARY KEY (statusid)
);

CREATE TABLE "public".entidadfederativa(
entidafederativaid integer  NOT NULL ,
entidadfederativadsc varchar(100)   ,
entidadfederativausuario  varchar(15)   ,
entidadfederativafecreg date   ,
entidadfederativafecultact date   ,
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
articulospreciocompra numeric(8,0),
articulospreccomprareexp numeric(8,0),
articuloscantdepreacum numeric(8,0),
articulosnumserie varchar(20)   ,
articulosrefdocumento varchar(20)   ,
articulosfechacoteja  varchar(20)   ,
articulosfechaentraalmacen  date   ,
articulosfechabajaalma date   ,
articulosstatus numeric(11),
articuloscontejado varchar(1)   ,
articulosusuario  varchar(15)   ,
articulosidtrasfer integer  NOT NULL ,
articulosestatusariticulo integer  NOT NULL ,
articulostipobien integer  NOT NULL ,
articulosfecreg  date   ,
articulosfecultact date   ,
CONSTRAINT pk_articulos_articulosid PRIMARY KEY (articulosid)
); 


CREATE TABLE "public".artículosmov(
articulosmovid integer  NOT NULL ,
productoid integer  NOT NULL ,
cambsid   integer  NOT NULL ,
articulosmovarticuloid  integer  NOT NULL ,
articulosmovdepositario numeric(3),
articulosmovfechamov date   ,
articulosmovstatus varchar(100)   ,
articulosmovagregomovsist varchar(50)   ,
articulosmovususuario varchar(15)   ,
articulosmovfecreg date   ,
articulosmovfecultact date   ,
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
empleadosfecreg  date   ,
empleadosfecultact date   ,
CONSTRAINT pk_empleados_empleadosid PRIMARY KEY (empleadosid)
);

CREATE TABLE  "public".area(
areaid integer  NOT NULL ,
areadsc varchar(100)   ,
areastatusadsc varchar(100)   ,
areausuario   varchar(15)   ,
areafecreg    date   ,
areafecultact date   ,
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
parametrosfecgre date   ,
parametrosfecact date   ,
CONSTRAINT pk_parametros_parametrosid PRIMARY KEY (parametrosid)
); 

CREATE TABLE "public".empleadospiso (
empleadospisoextid integer  NOT NULL ,
empleadospisoextpiso varchar(10)   ,
empleadospisoextext  varchar(10)   ,
empleadospisoextcorreo varchar(50)   ,
empleadopisoextprofesion numeric (11),
empleadospisoextusuario varchar(15)   ,
empleadospisoextfecgre  date   ,
empleadospisoextfeact  date   ,
CONSTRAINT pk_empleadospisoext_empleadospisoextid PRIMARY KEY (empleadospisoextid)
);

CREATE TABLE "public".meses(
mesesid integer  NOT NULL ,
mesesanio  varchar(5)   ,
mesesusuario varchar(15)   ,
mesesfecgre date   ,
mesesfeact  date   ,
CONSTRAINT pk_meses_mesesid PRIMARY KEY (mesesid)
);

CREATE TABLE "public".almacen(
almacenid integer  NOT NULL ,
empleadosid integer  NOT NULL ,
almacendsc varchar(100)   ,
almacendireccion  varchar(100)   ,
almacencolonia  varchar(50)   ,
almacenmunicipio varchar(50)   ,
alamcenestado    integer   ,
alamcencodigopostal varchar(5)   ,
almacentelefono     numeric(10)   ,
alamcenobservaciones varchar(50)   ,
alamcenusuario varchar(15)   ,
almacenfecreg  date   ,
almacenfecultact date   ,
CONSTRAINT pk_almacen_almacenid PRIMARY KEY (almacenid)
);

CREATE TABLE "public".proveedores(
proveedoresid integer  NOT NULL ,
proveedoresnombre varchar(80)   ,
proveedoresdireccion  varchar(50)   ,
proveedorescolonia  varchar(25)   ,
proveedorescodigopostal varchar(5)   ,
proveedoresmunicipio varchar(25)   ,
proveedorestado  integer   ,
proveedorestelefono1 numeric(10),
proveedorestelefono2 numeric(10),
proveedoresfax   varchar(15)   ,
proveedoresrfc varchar(13)   ,
proveedoresusuario  varchar(15)   ,
proveedoresfecreg  date   ,
proveedoresfecultact  date   ,
CONSTRAINT pk_proveedores_proveedoresid PRIMARY KEY (proveedoresid)
);

CREATE TABLE  "public".etiquetas(
etiquetasid integer  NOT NULL ,
productoid integer  NOT NULL ,
cambsid    integer  NOT NULL ,
articuloid  integer  NOT NULL ,
etiquetasnumero numeric(11),
etiquetastatus varchar(100),
etiquetafecharealizada date   ,
etiquetasreimpresión varchar(100),
etiquetasusuario varchar(15),
etiquetasfecreg    date   ,
etiquetasfecultact date   ,
CONSTRAINT pk_etiquetas_etiquetasid PRIMARY KEY (etiquetasid)
);

CREATE  TABLE "public".producto ( 
	productoid           integer  NOT NULL ,
	pcambsid             integer  NOT NULL ,
	pmodeloid            integer  NOT NULL ,
	pmarcaid             integer  NOT NULL ,
	pcategoriaid         integer  NOT NULL ,
	productodsc          varchar(100)   ,
	productousuario      varchar(15)   ,
	productofecreg       date   ,
	productofecultact    date   ,
	ptipobienid          integer   ,
	CONSTRAINT pk_producto_productoid PRIMARY KEY ( productoid )
 );


CREATE TABLE "public".estados(
  estadoid integer  NOT NULL ,
  estado varchar(100) NOT NULL,
 CONSTRAINT pk_estados_estadoid PRIMARY KEY (estadoid)
);

INSERT INTO usuarios(idusuario,usuario,contrasena)
VALUES (1,'admin', 'admin');


INSERT INTO estados(
            estadoid, estado)
    VALUES (1, 'Aguascalientes'),
(2, 'Baja California'),
(3, 'Baja California Sur'),
(4, 'Campeche'),
(5, 'Coahuila de Zaragoza'),
(6, 'Colima'),
(7, 'Chiapas'),
(8, 'Chihuahua'),
(9, 'Distrito Federal'),
(10, 'Durango'),
(11, 'Guanajuato'),
(12, 'Guerrero'),
(13, 'Hidalgo'),
(14, 'Jalisco'),
(15, 'México'),
(16, 'Michoacán de Ocampo'),
(17, 'Morelos'),
(18, 'Nayarit'),
(19, 'Nuevo León'),
(20, 'Oaxaca de Juárez'),
(21, 'Puebla'),
(22, 'Querétaro'),
(23, 'Quintana Roo'),
(24, 'San Luis Potosí'),
(25, 'Sinaloa'),
(26, 'Sonora'),
(27, 'Tabasco'),
(28, 'Tamaulipas'),
(29, 'Tlaxcala'),
(30, 'Veracruz de Ignacio de la Llave'),
(31, 'Yucatán'),
(32, 'Zacatecas');


commit;