/**@preserve  GeneXus C# 10_3_15-115824 on 2/15/2022 5:8:54.71
*/
gx.evt.autoSkip=!1;gx.define("proveedores",!1,function(){this.ServerClass="proveedores";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7proveedoresid=gx.fn.getIntegerValue("vPROVEEDORESID",".");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Proveedoresid=function(){try{var n=gx.util.balloon.getNew("PROVEEDORESID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110a10_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120a10_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77];this.GXLastCtrlId=77;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Proveedoresid,isvalid:null,rgrid:[],fld:"PROVEEDORESID",gxz:"Z2proveedoresid",gxold:"O2proveedoresid",gxvar:"A2proveedoresid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2proveedoresid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESID",gx.O.A2proveedoresid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROVEEDORESID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:80,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESNOMBRE",gxz:"Z126proveedoresnombre",gxold:"O126proveedoresnombre",gxvar:"A126proveedoresnombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A126proveedoresnombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z126proveedoresnombre=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESNOMBRE",gx.O.A126proveedoresnombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.A126proveedoresnombre=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESNOMBRE")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESDIRECCION",gxz:"Z127proveedoresdireccion",gxold:"O127proveedoresdireccion",gxvar:"A127proveedoresdireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A127proveedoresdireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z127proveedoresdireccion=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESDIRECCION",gx.O.A127proveedoresdireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A127proveedoresdireccion=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESDIRECCION")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCOLONIA",gxz:"Z128proveedorescolonia",gxold:"O128proveedorescolonia",gxvar:"A128proveedorescolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A128proveedorescolonia=n)},v2z:function(n){n!==undefined&&(gx.O.Z128proveedorescolonia=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESCOLONIA",gx.O.A128proveedorescolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.A128proveedorescolonia=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESCOLONIA")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESCODIGOPOSTAL",gxz:"Z129proveedorescodigopostal",gxold:"O129proveedorescodigopostal",gxvar:"A129proveedorescodigopostal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A129proveedorescodigopostal=n)},v2z:function(n){n!==undefined&&(gx.O.Z129proveedorescodigopostal=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESCODIGOPOSTAL",gx.O.A129proveedorescodigopostal,0)},c2v:function(){this.val()!==undefined&&(gx.O.A129proveedorescodigopostal=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESCODIGOPOSTAL")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESMUNICIPIO",gxz:"Z130proveedoresmunicipio",gxold:"O130proveedoresmunicipio",gxvar:"A130proveedoresmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A130proveedoresmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.Z130proveedoresmunicipio=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESMUNICIPIO",gx.O.A130proveedoresmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A130proveedoresmunicipio=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESMUNICIPIO")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTADO",gxz:"Z131proveedorestado",gxold:"O131proveedorestado",gxvar:"A131proveedorestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A131proveedorestado=n)},v2z:function(n){n!==undefined&&(gx.O.Z131proveedorestado=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESTADO",gx.O.A131proveedorestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A131proveedorestado=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESTADO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTELEFONO1",gxz:"Z132proveedorestelefono1",gxold:"O132proveedorestelefono1",gxvar:"A132proveedorestelefono1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A132proveedorestelefono1=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z132proveedorestelefono1=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESTELEFONO1",gx.O.A132proveedorestelefono1,0)},c2v:function(){this.val()!==undefined&&(gx.O.A132proveedorestelefono1=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROVEEDORESTELEFONO1",".")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESTELEFONO2",gxz:"Z133proveedorestelefono2",gxold:"O133proveedorestelefono2",gxvar:"A133proveedorestelefono2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A133proveedorestelefono2=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z133proveedorestelefono2=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESTELEFONO2",gx.O.A133proveedorestelefono2,0)},c2v:function(){this.val()!==undefined&&(gx.O.A133proveedorestelefono2=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROVEEDORESTELEFONO2",".")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESFAX",gxz:"Z134proveedoresfax",gxold:"O134proveedoresfax",gxvar:"A134proveedoresfax",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A134proveedoresfax=n)},v2z:function(n){n!==undefined&&(gx.O.Z134proveedoresfax=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESFAX",gx.O.A134proveedoresfax,0)},c2v:function(){this.val()!==undefined&&(gx.O.A134proveedoresfax=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESFAX")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={lvl:0,type:"svchar",len:13,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESRFC",gxz:"Z135proveedoresrfc",gxold:"O135proveedoresrfc",gxvar:"A135proveedoresrfc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A135proveedoresrfc=n)},v2z:function(n){n!==undefined&&(gx.O.Z135proveedoresrfc=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESRFC",gx.O.A135proveedoresrfc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A135proveedoresrfc=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESRFC")},nac:gx.falseFn};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESUSUARIO",gxz:"Z136proveedoresusuario",gxold:"O136proveedoresusuario",gxvar:"A136proveedoresusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A136proveedoresusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z136proveedoresusuario=n)},v2c:function(){gx.fn.setControlValue("PROVEEDORESUSUARIO",gx.O.A136proveedoresusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A136proveedoresusuario=this.val())},val:function(){return gx.fn.getControlValue("PROVEEDORESUSUARIO")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"",grid:0};n[70]={lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESFECREG",gxz:"Z137proveedoresfecreg",gxold:"O137proveedoresfecreg",gxvar:"A137proveedoresfecreg",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A137proveedoresfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z137proveedoresfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESFECREG",gx.O.A137proveedoresfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A137proveedoresfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("PROVEEDORESFECREG")},nac:gx.falseFn};n[71]={fld:"",grid:0};n[72]={fld:"",grid:0};n[73]={fld:"",grid:0};n[74]={lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PROVEEDORESFECULTACT",gxz:"Z138proveedoresfecultact",gxold:"O138proveedoresfecultact",gxvar:"A138proveedoresfecultact",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A138proveedoresfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z138proveedoresfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESFECULTACT",gx.O.A138proveedoresfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A138proveedoresfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("PROVEEDORESFECULTACT")},nac:gx.falseFn};n[75]={fld:"",grid:0};n[76]={fld:"",grid:0};n[77]={fld:"",grid:0};this.A2proveedoresid=0;this.Z2proveedoresid=0;this.O2proveedoresid=0;this.A126proveedoresnombre="";this.Z126proveedoresnombre="";this.O126proveedoresnombre="";this.A127proveedoresdireccion="";this.Z127proveedoresdireccion="";this.O127proveedoresdireccion="";this.A128proveedorescolonia="";this.Z128proveedorescolonia="";this.O128proveedorescolonia="";this.A129proveedorescodigopostal="";this.Z129proveedorescodigopostal="";this.O129proveedorescodigopostal="";this.A130proveedoresmunicipio="";this.Z130proveedoresmunicipio="";this.O130proveedoresmunicipio="";this.A131proveedorestado="";this.Z131proveedorestado="";this.O131proveedorestado="";this.A132proveedorestelefono1=0;this.Z132proveedorestelefono1=0;this.O132proveedorestelefono1=0;this.A133proveedorestelefono2=0;this.Z133proveedorestelefono2=0;this.O133proveedorestelefono2=0;this.A134proveedoresfax="";this.Z134proveedoresfax="";this.O134proveedoresfax="";this.A135proveedoresrfc="";this.Z135proveedoresrfc="";this.O135proveedoresrfc="";this.A136proveedoresusuario="";this.Z136proveedoresusuario="";this.O136proveedoresusuario="";this.A137proveedoresfecreg=gx.date.nullDate();this.Z137proveedoresfecreg=gx.date.nullDate();this.O137proveedoresfecreg=gx.date.nullDate();this.A138proveedoresfecultact=gx.date.nullDate();this.Z138proveedoresfecultact=gx.date.nullDate();this.O138proveedoresfecultact=gx.date.nullDate();this.AV7proveedoresid=0;this.A2proveedoresid=0;this.A126proveedoresnombre="";this.A127proveedoresdireccion="";this.A128proveedorescolonia="";this.A129proveedorescodigopostal="";this.A130proveedoresmunicipio="";this.A131proveedorestado="";this.A132proveedorestelefono1=0;this.A133proveedorestelefono2=0;this.A134proveedoresfax="";this.A135proveedoresrfc="";this.A136proveedoresusuario="";this.A137proveedoresfecreg=gx.date.nullDate();this.A138proveedoresfecultact=gx.date.nullDate();this.Gx_mode="";this.Events={e110a10_client:["ENTER",!0],e120a10_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7proveedoresid",fld:"vPROVEEDORESID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7proveedoresid","vPROVEEDORESID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(proveedores)