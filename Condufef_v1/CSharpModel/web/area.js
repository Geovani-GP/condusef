/**@preserve  GeneXus C# 10_3_15-115824 on 2/5/2022 16:5:53.33
*/
gx.evt.autoSkip=!1;gx.define("area",!1,function(){this.ServerClass="area";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7areaareaid=gx.fn.getIntegerValue("vAREAAREAID",".");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Areaareaid=function(){try{var n=gx.util.balloon.getNew("AREAAREAID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e110h17_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120h17_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45];this.GXLastCtrlId=45;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Areaareaid,isvalid:null,rgrid:[],fld:"AREAAREAID",gxz:"Z22areaareaid",gxold:"O22areaareaid",gxvar:"A22areaareaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A22areaareaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22areaareaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("AREAAREAID",gx.O.A22areaareaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A22areaareaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("AREAAREAID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"AREADSC",gxz:"Z27areadsc",gxold:"O27areadsc",gxvar:"A27areadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A27areadsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z27areadsc=n)},v2c:function(){gx.fn.setControlValue("AREADSC",gx.O.A27areadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A27areadsc=this.val())},val:function(){return gx.fn.getControlValue("AREADSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"AREASTATUSADSC",gxz:"Z28areastatusadsc",gxold:"O28areastatusadsc",gxvar:"A28areastatusadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A28areastatusadsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z28areastatusadsc=n)},v2c:function(){gx.fn.setControlValue("AREASTATUSADSC",gx.O.A28areastatusadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A28areastatusadsc=this.val())},val:function(){return gx.fn.getControlValue("AREASTATUSADSC")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"AREAUSUARIO",gxz:"Z29areausuario",gxold:"O29areausuario",gxvar:"A29areausuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A29areausuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z29areausuario=n)},v2c:function(){gx.fn.setControlValue("AREAUSUARIO",gx.O.A29areausuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A29areausuario=this.val())},val:function(){return gx.fn.getControlValue("AREAUSUARIO")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"AREAFECREG",gxz:"Z30areafecreg",gxold:"O30areafecreg",gxvar:"A30areafecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A30areafecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z30areafecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("AREAFECREG",gx.O.A30areafecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A30areafecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("AREAFECREG")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"AREAFECULTACT",gxz:"Z31areafecultact",gxold:"O31areafecultact",gxvar:"A31areafecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A31areafecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z31areafecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("AREAFECULTACT",gx.O.A31areafecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A31areafecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("AREAFECULTACT")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};this.A22areaareaid=0;this.Z22areaareaid=0;this.O22areaareaid=0;this.A27areadsc="";this.Z27areadsc="";this.O27areadsc="";this.A28areastatusadsc="";this.Z28areastatusadsc="";this.O28areastatusadsc="";this.A29areausuario="";this.Z29areausuario="";this.O29areausuario="";this.A30areafecreg=gx.date.nullDate();this.Z30areafecreg=gx.date.nullDate();this.O30areafecreg=gx.date.nullDate();this.A31areafecultact=gx.date.nullDate();this.Z31areafecultact=gx.date.nullDate();this.O31areafecultact=gx.date.nullDate();this.AV7areaareaid=0;this.A22areaareaid=0;this.A27areadsc="";this.A28areastatusadsc="";this.A29areausuario="";this.A30areafecreg=gx.date.nullDate();this.A31areafecultact=gx.date.nullDate();this.Gx_mode="";this.Events={e110h17_client:["ENTER",!0],e120h17_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0},{av:"Gx_mode",fld:"vMODE",pic:"@!",hsh:!0,nv:""},{av:"AV7areaareaid",fld:"vAREAAREAID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("AV7areaareaid","vAREAAREAID",0,"int");this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(area)