/**@preserve  GeneXus C# 10_3_15-115824 on 12/30/2021 22:8:56.36
*/
gx.evt.autoSkip=!1;gx.define("proveedores",!1,function(){this.ServerClass="proveedores";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Proveedoresid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Proveedoresid",["gx.O.A2proveedoresid","gx.O.A126proveedoresnombre","gx.O.A127proveedoresdireccion","gx.O.A128proveedorescolonia","gx.O.A129proveedorescodigopostal","gx.O.A130proveedoresmunicipio","gx.O.A131proveedorestado","gx.O.A132proveedorestelefono1","gx.O.A133proveedorestelefono2","gx.O.A134proveedoresfax","gx.O.A135proveedoresrfc","gx.O.A136proveedoresusuario",'gx.date.urlDateTime(gx.O.A137proveedoresfecreg,"DMY")','gx.date.urlDateTime(gx.O.A138proveedoresfecultact,"DMY")'],["A126proveedoresnombre","A127proveedoresdireccion","A128proveedorescolonia","A129proveedorescodigopostal","A130proveedoresmunicipio","A131proveedorestado","A132proveedorestelefono1","A133proveedorestelefono2","A134proveedoresfax","A135proveedoresrfc","A136proveedoresusuario","A137proveedoresfecreg","A138proveedoresfecultact","Gx_mode","Z2proveedoresid","Z126proveedoresnombre","Z127proveedoresdireccion","Z128proveedorescolonia","Z129proveedorescodigopostal","Z130proveedoresmunicipio","Z131proveedorestado","Z132proveedorestelefono1","Z133proveedorestelefono2","Z134proveedoresfax","Z135proveedoresrfc","Z136proveedoresusuario","Z137proveedoresfecreg","Z138proveedoresfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Proveedoresfecreg=function(){try{var n=gx.util.balloon.getNew("PROVEEDORESFECREG");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A137proveedoresfecreg)==0||new gx.date.gxdate(this.A137proveedoresfecreg).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo proveedoresfecreg fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Proveedoresfecultact=function(){try{var n=gx.util.balloon.getNew("PROVEEDORESFECULTACT");if(this.AnyError=0,!(new gx.date.gxdate("").compare(this.A138proveedoresfecultact)==0||new gx.date.gxdate(this.A138proveedoresfecultact).compare(gx.date.ymdhmstot(1753,01,01,00,00,00))>=0))try{n.setError("Campo proveedoresfecultact fuera de rango");this.AnyError=gx.num.trunc(1,0)}catch(t){}}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110a10_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120a10_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77];this.GXLastCtrlId=77;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Proveedoresid,isvalid:null,rgrid:[],fld:"PROVEEDORESID",gxz:"Z2proveedoresid",gxold:"O2proveedoresid",gxvar:"A2proveedoresid",ucs:[],op:[74,70,66,62,58,54,50,46,42,38,34,30,26],ip:[74,70,66,62,58,54,50,46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2proveedoresid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESID",gx.O.A2proveedoresid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROVEEDORESID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:80,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESNOMBRE",gxz:"Z126proveedoresnombre",gxold:"O126proveedoresnombre",gxvar:"A126proveedoresnombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A126proveedoresnombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z126proveedoresnombre=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESNOMBRE",gx.O.A126proveedoresnombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A126proveedoresnombre=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESNOMBRE")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESDIRECCION",gxz:"Z127proveedoresdireccion",gxold:"O127proveedoresdireccion",gxvar:"A127proveedoresdireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A127proveedoresdireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z127proveedoresdireccion=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESDIRECCION",gx.O.A127proveedoresdireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A127proveedoresdireccion=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESDIRECCION")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCOLONIA",gxz:"Z128proveedorescolonia",gxold:"O128proveedorescolonia",gxvar:"A128proveedorescolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A128proveedorescolonia=n)},v2z:function(n){n!==undefined&&(gx.O.Z128proveedorescolonia=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESCOLONIA",gx.O.A128proveedorescolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.A128proveedorescolonia=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESCOLONIA")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCODIGOPOSTAL",gxz:"Z129proveedorescodigopostal",gxold:"O129proveedorescodigopostal",gxvar:"A129proveedorescodigopostal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A129proveedorescodigopostal=n)},v2z:function(n){n!==undefined&&(gx.O.Z129proveedorescodigopostal=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESCODIGOPOSTAL",gx.O.A129proveedorescodigopostal,0)},c2v:function(){this.val()!==undefined&&(gx.O.A129proveedorescodigopostal=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESCODIGOPOSTAL")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESMUNICIPIO",gxz:"Z130proveedoresmunicipio",gxold:"O130proveedoresmunicipio",gxvar:"A130proveedoresmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A130proveedoresmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.Z130proveedoresmunicipio=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESMUNICIPIO",gx.O.A130proveedoresmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A130proveedoresmunicipio=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESMUNICIPIO")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTADO",gxz:"Z131proveedorestado",gxold:"O131proveedorestado",gxvar:"A131proveedorestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A131proveedorestado=n)},v2z:function(n){n!==undefined&&(gx.O.Z131proveedorestado=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESTADO",gx.O.A131proveedorestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A131proveedorestado=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESTADO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTELEFONO1",gxz:"Z132proveedorestelefono1",gxold:"O132proveedorestelefono1",gxvar:"A132proveedorestelefono1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A132proveedorestelefono1=n)},v2z:function(n){n!==undefined&&(gx.O.Z132proveedorestelefono1=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESTELEFONO1",gx.O.A132proveedorestelefono1,0)},c2v:function(){this.val()!==undefined&&(gx.O.A132proveedorestelefono1=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESTELEFONO1")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTELEFONO2",gxz:"Z133proveedorestelefono2",gxold:"O133proveedorestelefono2",gxvar:"A133proveedorestelefono2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A133proveedorestelefono2=n)},v2z:function(n){n!==undefined&&(gx.O.Z133proveedorestelefono2=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESTELEFONO2",gx.O.A133proveedorestelefono2,0)},c2v:function(){this.val()!==undefined&&(gx.O.A133proveedorestelefono2=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESTELEFONO2")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESFAX",gxz:"Z134proveedoresfax",gxold:"O134proveedoresfax",gxvar:"A134proveedoresfax",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A134proveedoresfax=n)},v2z:function(n){n!==undefined&&(gx.O.Z134proveedoresfax=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESFAX",gx.O.A134proveedoresfax,0)},c2v:function(){this.val()!==undefined&&(gx.O.A134proveedoresfax=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESFAX")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={lvl:0,type:"svchar",len:13,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESRFC",gxz:"Z135proveedoresrfc",gxold:"O135proveedoresrfc",gxvar:"A135proveedoresrfc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A135proveedoresrfc=n)},v2z:function(n){n!==undefined&&(gx.O.Z135proveedoresrfc=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESRFC",gx.O.A135proveedoresrfc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A135proveedoresrfc=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESRFC")},nac:gx.falseFn};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESUSUARIO",gxz:"Z136proveedoresusuario",gxold:"O136proveedoresusuario",gxvar:"A136proveedoresusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A136proveedoresusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z136proveedoresusuario=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESUSUARIO",gx.O.A136proveedoresusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A136proveedoresusuario=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESUSUARIO")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"",grid:0};n[70]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Proveedoresfecreg,isvalid:null,rgrid:[],fld:"PROVEEDORESFECREG",gxz:"Z137proveedoresfecreg",gxold:"O137proveedoresfecreg",gxvar:"A137proveedoresfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[70],ip:[70],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A137proveedoresfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z137proveedoresfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESFECREG",gx.O.A137proveedoresfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A137proveedoresfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("PROVEEDORESFECREG")},nac:gx.falseFn};n[71]={fld:"",grid:0};n[72]={fld:"",grid:0};n[73]={fld:"",grid:0};n[74]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Proveedoresfecultact,isvalid:null,rgrid:[],fld:"PROVEEDORESFECULTACT",gxz:"Z138proveedoresfecultact",gxold:"O138proveedoresfecultact",gxvar:"A138proveedoresfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[74],ip:[74],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A138proveedoresfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z138proveedoresfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESFECULTACT",gx.O.A138proveedoresfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A138proveedoresfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("PROVEEDORESFECULTACT")},nac:gx.falseFn};n[75]={fld:"",grid:0};n[76]={fld:"",grid:0};n[77]={fld:"",grid:0};this.A2proveedoresid=0;this.Z2proveedoresid=0;this.O2proveedoresid=0;this.A126proveedoresnombre="";this.Z126proveedoresnombre="";this.O126proveedoresnombre="";this.A127proveedoresdireccion="";this.Z127proveedoresdireccion="";this.O127proveedoresdireccion="";this.A128proveedorescolonia="";this.Z128proveedorescolonia="";this.O128proveedorescolonia="";this.A129proveedorescodigopostal="";this.Z129proveedorescodigopostal="";this.O129proveedorescodigopostal="";this.A130proveedoresmunicipio="";this.Z130proveedoresmunicipio="";this.O130proveedoresmunicipio="";this.A131proveedorestado="";this.Z131proveedorestado="";this.O131proveedorestado="";this.A132proveedorestelefono1="";this.Z132proveedorestelefono1="";this.O132proveedorestelefono1="";this.A133proveedorestelefono2="";this.Z133proveedorestelefono2="";this.O133proveedorestelefono2="";this.A134proveedoresfax="";this.Z134proveedoresfax="";this.O134proveedoresfax="";this.A135proveedoresrfc="";this.Z135proveedoresrfc="";this.O135proveedoresrfc="";this.A136proveedoresusuario="";this.Z136proveedoresusuario="";this.O136proveedoresusuario="";this.A137proveedoresfecreg=gx.date.nullDate();this.Z137proveedoresfecreg=gx.date.nullDate();this.O137proveedoresfecreg=gx.date.nullDate();this.A138proveedoresfecultact=gx.date.nullDate();this.Z138proveedoresfecultact=gx.date.nullDate();this.O138proveedoresfecultact=gx.date.nullDate();this.A2proveedoresid=0;this.A126proveedoresnombre="";this.A127proveedoresdireccion="";this.A128proveedorescolonia="";this.A129proveedorescodigopostal="";this.A130proveedoresmunicipio="";this.A131proveedorestado="";this.A132proveedorestelefono1="";this.A133proveedorestelefono2="";this.A134proveedoresfax="";this.A135proveedoresrfc="";this.A136proveedoresusuario="";this.A137proveedoresfecreg=gx.date.nullDate();this.A138proveedoresfecultact=gx.date.nullDate();this.Events={e110a10_client:["ENTER",!0],e120a10_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(proveedores)