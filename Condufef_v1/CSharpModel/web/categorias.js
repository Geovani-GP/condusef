/**@preserve  GeneXus C# 10_3_15-115824 on 2/2/2022 13:42:15.85
*/
gx.evt.autoSkip=!1;gx.define("categorias",!1,function(){this.ServerClass="categorias";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7categoriasid=gx.fn.getIntegerValue("vCATEGORIASID",".");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Categoriasid=function(){try{var n=gx.util.balloon.getNew("CATEGORIASID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e11055_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12055_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Categoriasid,isvalid:null,rgrid:[],fld:"CATEGORIASID",gxz:"Z14categoriasid",gxold:"O14categoriasid",gxvar:"A14categoriasid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A14categoriasid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z14categoriasid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CATEGORIASID",gx.O.A14categoriasid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A14categoriasid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CATEGORIASID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIASDSC",gxz:"Z94categoriasdsc",gxold:"O94categoriasdsc",gxvar:"A94categoriasdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A94categoriasdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z94categoriasdsc=n)},v2c:function(){gx.fn.setControlValue("CATEGORIASDSC",gx.O.A94categoriasdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A94categoriasdsc=this.val())},val:function(){return gx.fn.getControlValue("CATEGORIASDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIASUSUARIO",gxz:"Z95categoriasusuario",gxold:"O95categoriasusuario",gxvar:"A95categoriasusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A95categoriasusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z95categoriasusuario=n)},v2c:function(){gx.fn.setControlValue("CATEGORIASUSUARIO",gx.O.A95categoriasusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A95categoriasusuario=this.val())},val:function(){return gx.fn.getControlValue("CATEGORIASUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIASFECREG",gxz:"Z96categoriasfecreg",gxold:"O96categoriasfecreg",gxvar:"A96categoriasfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A96categoriasfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z96categoriasfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("CATEGORIASFECREG",gx.O.A96categoriasfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A96categoriasfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("CATEGORIASFECREG")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CATEGORIASFECULTACT",gxz:"Z97categoriasfecultact",gxold:"O97categoriasfecultact",gxvar:"A97categoriasfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A97categoriasfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z97categoriasfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("CATEGORIASFECULTACT",gx.O.A97categoriasfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A97categoriasfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("CATEGORIASFECULTACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A14categoriasid=0;this.Z14categoriasid=0;this.O14categoriasid=0;this.A94categoriasdsc="";this.Z94categoriasdsc="";this.O94categoriasdsc="";this.A95categoriasusuario="";this.Z95categoriasusuario="";this.O95categoriasusuario="";this.A96categoriasfecreg=gx.date.nullDate();this.Z96categoriasfecreg=gx.date.nullDate();this.O96categoriasfecreg=gx.date.nullDate();this.A97categoriasfecultact=gx.date.nullDate();this.Z97categoriasfecultact=gx.date.nullDate();this.O97categoriasfecultact=gx.date.nullDate();this.AV7categoriasid=0;this.A14categoriasid=0;this.A94categoriasdsc="";this.A95categoriasusuario="";this.A96categoriasfecreg=gx.date.nullDate();this.A97categoriasfecultact=gx.date.nullDate();this.Gx_mode="";this.Events={e11055_client:["ENTER",!0],e12055_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7categoriasid",fld:"vCATEGORIASID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7categoriasid","vCATEGORIASID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(categorias)